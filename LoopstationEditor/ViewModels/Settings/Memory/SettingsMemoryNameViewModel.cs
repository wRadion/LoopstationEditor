using LoopstationEditor.Models.Settings.Memory;
using System;
using System.Text;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryNameViewModel : SettingsViewModel
    {
        public string TempName { get; set; }
        public string Name { get; set; }

        public SettingsMemoryNameViewModel(SettingsMemoryNameModel model)
            : base(model, false)
        {
            Name = new StringBuilder().Append(model.Character01).Append(model.Character02).Append(model.Character03).Append(model.Character04).
                Append(model.Character05).Append(model.Character06).Append(model.Character07).Append(model.Character08).
                Append(model.Character09).Append(model.Character10).Append(model.Character11).Append(model.Character12).
                ToString().TrimEnd(' ');
            TempName = Name;
        }

        public override void ApplyChanges()
        {
            SettingsMemoryNameModel model = (SettingsMemoryNameModel)_model;

            string newName = TempName.TrimEnd(' ');
            if (newName.Length < NameProperty.Length)
                newName = new StringBuilder(newName).Append(' ', NameProperty.Length - newName.Length).ToString();
            Name = newName;

            model.Character01 = Name[0];
            model.Character02 = Name[1];
            model.Character03 = Name[2];
            model.Character04 = Name[3];
            model.Character05 = Name[4];
            model.Character06 = Name[5];
            model.Character07 = Name[6];
            model.Character08 = Name[7];
            model.Character09 = Name[8];
            model.Character10 = Name[9];
            model.Character11 = Name[10];
            model.Character12 = Name[11];
        }
    }
}
