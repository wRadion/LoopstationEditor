using System.Text;

using LoopstationEditor.Models.PropertyEngine;
using LoopstationEditor.Models.Settings.Memory;

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
            if (newName.Length < SettingsMemoryNameModel.Length)
                newName = new StringBuilder(newName).Append(' ', SettingsMemoryNameModel.Length - newName.Length).ToString();
            Name = newName;

            model.Character01 = (ValueChar)Name[0];
            model.Character02 = (ValueChar)Name[1];
            model.Character03 = (ValueChar)Name[2];
            model.Character04 = (ValueChar)Name[3];
            model.Character05 = (ValueChar)Name[4];
            model.Character06 = (ValueChar)Name[5];
            model.Character07 = (ValueChar)Name[6];
            model.Character08 = (ValueChar)Name[7];
            model.Character09 = (ValueChar)Name[8];
            model.Character10 = (ValueChar)Name[9];
            model.Character11 = (ValueChar)Name[10];
            model.Character12 = (ValueChar)Name[11];

            base.ApplyChanges();
        }
    }
}
