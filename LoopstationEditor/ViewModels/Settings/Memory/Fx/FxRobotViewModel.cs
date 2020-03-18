using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxRobotViewModel : SettingsViewModel
    {
        public PropertyEnumViewModel<FxRobotNote> RobotNote { get; }
        public PropertyIntViewModel RobotGender { get; }

        public FxRobotViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            RobotNote = new PropertyEnumViewModel<FxRobotNote>(nameof(RobotNote), _properties);
            RobotGender = new PropertyIntViewModel(nameof(RobotGender), _properties, new IntGenderConverter());
        }
    }
}
