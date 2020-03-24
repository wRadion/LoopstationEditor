using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxTremoloViewModel : FxViewModel
    {
        public PropertyMixedViewModel<FxRate> TremoloRate { get; }
        public PropertyIntViewModel TremoloDepth { get; }
        public PropertyIntViewModel TremoloLevel { get; }

        public FxTremoloViewModel(SettingsMemoryFxModel model)
            : base("Tremolo", model)
        {
            TremoloRate = new PropertyMixedViewModel<FxRate>(nameof(model.TremoloRate), _properties, new EnumNoteConverter<FxRate>());
            TremoloDepth = new PropertyIntViewModel(nameof(model.TremoloDepth), _properties);
            TremoloLevel = new PropertyIntViewModel(nameof(model.TremoloLevel), _properties);
        }
    }
}
