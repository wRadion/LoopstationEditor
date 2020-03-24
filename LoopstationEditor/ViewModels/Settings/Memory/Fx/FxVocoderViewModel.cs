using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxVocoderViewModel : FxViewModel
    {
        public PropertyEnumComboViewModel<Track> VocoderCarrier { get; }
        public PropertyIntViewModel VocoderModSens { get; }
        public PropertyIntViewModel VocoderAttack { get; }
        public PropertyIntViewModel VocoderBalance { get; }

        public FxVocoderViewModel(SettingsMemoryFxModel model)
            : base("Vocoder", model)
        {
            VocoderCarrier = new PropertyEnumComboViewModel<Track>(nameof(model.VocoderCarrier), _properties);
            VocoderModSens = new PropertyIntViewModel(nameof(model.VocoderModSens), _properties);
            VocoderAttack = new PropertyIntViewModel(nameof(model.VocoderAttack), _properties);
            VocoderBalance = new PropertyIntViewModel(nameof(model.VocoderBalance), _properties);
        }
    }
}
