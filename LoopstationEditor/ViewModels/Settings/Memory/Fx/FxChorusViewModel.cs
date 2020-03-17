using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxChorusViewModel : SettingsViewModel
    {
        public PropertyMixedViewModel<FxRate> ChorusRate { get; }
        public PropertyIntViewModel ChorusDepth { get; }
        public PropertyIntViewModel ChorusLevel { get; }

        public FxChorusViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            ChorusRate = new PropertyMixedViewModel<FxRate>(FxProperty.ChorusRate, _properties);
            ChorusDepth = new PropertyIntViewModel(FxProperty.ChorusDepth, _properties);
            ChorusLevel = new PropertyIntViewModel(FxProperty.ChorusLevel, _properties);
        }
    }
}
