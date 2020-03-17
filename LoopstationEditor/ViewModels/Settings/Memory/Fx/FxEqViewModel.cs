using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxEqViewModel : SettingsViewModel
    {
        public PropertyIntViewModel EqLow { get; }
        public PropertyIntViewModel EqLowMid { get; }
        public PropertyIntViewModel EqHighMid { get; }
        public PropertyIntViewModel EqHigh { get; }
        public PropertyIntViewModel EqLevel { get; }

        public FxEqViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            EqLow = new PropertyIntViewModel(FxProperty.EqLow, _properties);
            EqLowMid = new PropertyIntViewModel(FxProperty.EqLowMid, _properties);
            EqHighMid = new PropertyIntViewModel(FxProperty.EqHighMid, _properties);
            EqHigh = new PropertyIntViewModel(FxProperty.EqHigh, _properties);
            EqLevel = new PropertyIntViewModel(FxProperty.EqLevel, _properties);
        }
    }
}
