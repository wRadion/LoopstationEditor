using LoopstationEditor.Models.Settings.Memory.Fx;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxRobotViewModel : SettingsViewModel
    {
        public PropertyEnumViewModel<FxRobotNote> RobotNote { get; }
        public PropertyIntViewModel RobotGender { get; }

        public FxRobotViewModel(FxRobotModel model)
            : base(model)
        {
            RobotNote = new PropertyEnumViewModel<FxRobotNote>(FxProperty.RobotNote, _properties);
            RobotGender = new PropertyIntViewModel(FxProperty.RobotGender, _properties);
        }
    }
}
