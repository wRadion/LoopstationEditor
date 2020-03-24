using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxRobotViewModel : FxViewModel
    {
        public PropertyEnumComboViewModel<FxRobotNote> RobotNote { get; }
        public PropertyIntViewModel RobotGender { get; }

        public FxRobotViewModel(SettingsMemoryFxModel model)
            : base("Robot", model)
        {
            RobotNote = new PropertyEnumComboViewModel<FxRobotNote>(nameof(model.RobotNote), _properties);
            RobotGender = new PropertyIntViewModel(nameof(model.RobotGender), _properties, new IntGenderConverter());
        }
    }
}
