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
            Name = new StringBuilder().Append((char)model.Character01).Append((char)model.Character02).Append((char)model.Character03).Append((char)model.Character04).
                Append((char)model.Character05).Append((char)model.Character06).Append((char)model.Character07).Append((char)model.Character08).
                Append((char)model.Character09).Append((char)model.Character10).Append((char)model.Character11).Append((char)model.Character12).
                ToString().TrimEnd(' ');
            TempName = Name;
        }

        public override void ApplyChanges<T>(T model)
        {
            if (model is SettingsMemoryNameModel name)
            {
                string newName = TempName.TrimEnd(' ');
                if (newName.Length < SettingsMemoryNameModel.Length)
                    newName = new StringBuilder(newName).Append(' ', SettingsMemoryNameModel.Length - newName.Length).ToString();
                Name = newName;

                name.Character01 = (ValueChar)Name[0];
                name.Character02 = (ValueChar)Name[1];
                name.Character03 = (ValueChar)Name[2];
                name.Character04 = (ValueChar)Name[3];
                name.Character05 = (ValueChar)Name[4];
                name.Character06 = (ValueChar)Name[5];
                name.Character07 = (ValueChar)Name[6];
                name.Character08 = (ValueChar)Name[7];
                name.Character09 = (ValueChar)Name[8];
                name.Character10 = (ValueChar)Name[9];
                name.Character11 = (ValueChar)Name[10];
                name.Character12 = (ValueChar)Name[11];

                name.OnNameChanged();
            }
        }
    }
}
