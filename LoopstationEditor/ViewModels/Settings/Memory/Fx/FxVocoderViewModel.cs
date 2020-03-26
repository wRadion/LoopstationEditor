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
            VocoderCarrier = new PropertyEnumComboViewModel<Track>(nameof(model.VocoderCarrier), PropertySet);
            VocoderModSens = new PropertyIntViewModel(nameof(model.VocoderModSens), PropertySet);
            VocoderAttack = new PropertyIntViewModel(nameof(model.VocoderAttack), PropertySet);
            VocoderBalance = new PropertyIntViewModel(nameof(model.VocoderBalance), PropertySet);
        }
    }
}
