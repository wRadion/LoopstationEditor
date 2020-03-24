using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxEqViewModel : FxViewModel
    {
        public PropertyIntViewModel EqLow { get; }
        public PropertyIntViewModel EqLowMid { get; }
        public PropertyIntViewModel EqHighMid { get; }
        public PropertyIntViewModel EqHigh { get; }
        public PropertyIntViewModel EqLevel { get; }

        public FxEqViewModel(SettingsMemoryFxModel model)
            : base("EQ", model)
        {
            EqLow = new PropertyIntViewModel(nameof(model.EqLow), _properties, new IntDbConverter());
            EqLowMid = new PropertyIntViewModel(nameof(model.EqLowMid), _properties, new IntDbConverter());
            EqHighMid = new PropertyIntViewModel(nameof(model.EqHighMid), _properties, new IntDbConverter());
            EqHigh = new PropertyIntViewModel(nameof(model.EqHigh), _properties, new IntDbConverter());
            EqLevel = new PropertyIntViewModel(nameof(model.EqLevel), _properties, new IntDbConverter());
        }
    }
}
