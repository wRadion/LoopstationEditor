using LoopstationEditor.Converters.Int;
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
            EqLow = new PropertyIntViewModel(nameof(EqLow), _properties, new IntDbConverter());
            EqLowMid = new PropertyIntViewModel(nameof(EqLowMid), _properties, new IntDbConverter());
            EqHighMid = new PropertyIntViewModel(nameof(EqHighMid), _properties, new IntDbConverter());
            EqHigh = new PropertyIntViewModel(nameof(EqHigh), _properties, new IntDbConverter());
            EqLevel = new PropertyIntViewModel(nameof(EqLevel), _properties, new IntDbConverter());
        }
    }
}
