using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxTremoloViewModel : SettingsViewModel
    {
        public PropertyMixedViewModel<FxRate> TremoloRate { get; }
        public PropertyIntViewModel TremoloDepth { get; }
        public PropertyIntViewModel TremoloLevel { get; }

        public FxTremoloViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            TremoloRate = new PropertyMixedViewModel<FxRate>(nameof(TremoloRate), _properties);
            TremoloDepth = new PropertyIntViewModel(nameof(TremoloDepth), _properties);
            TremoloLevel = new PropertyIntViewModel(nameof(TremoloLevel), _properties);
        }
    }
}
