using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxVocoderViewModel : SettingsViewModel
    {
        public PropertyEnumViewModel<Track> VocoderCarrier { get; }
        public PropertyIntViewModel VocoderModSens { get; }
        public PropertyIntViewModel VocoderAttack { get; }
        public PropertyIntViewModel VocoderBalance { get; }

        public FxVocoderViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            VocoderCarrier = new PropertyEnumViewModel<Track>(nameof(VocoderCarrier), _properties);
            VocoderModSens = new PropertyIntViewModel(nameof(VocoderModSens), _properties);
            VocoderAttack = new PropertyIntViewModel(nameof(VocoderAttack), _properties);
            VocoderBalance = new PropertyIntViewModel(nameof(VocoderBalance), _properties);
        }
    }
}
