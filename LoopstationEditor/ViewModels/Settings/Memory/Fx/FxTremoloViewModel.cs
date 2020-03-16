using LoopstationEditor.Models.Settings.Memory.Fx;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxTremoloViewModel : SettingsViewModel
    {
        public PropertyMixedViewModel<FxRate> TremoloRate { get; }
        public PropertyIntViewModel TremoloDepth { get; }
        public PropertyIntViewModel TremoloLevel { get; }

        public FxTremoloViewModel(FxTremoloModel model)
            : base(model)
        {
            TremoloRate = new PropertyMixedViewModel<FxRate>(FxProperty.TremoloRate, _properties);
            TremoloDepth = new PropertyIntViewModel(FxProperty.TremoloDepth, _properties);
            TremoloLevel = new PropertyIntViewModel(FxProperty.TremoloLevel, _properties);
        }
    }
}
