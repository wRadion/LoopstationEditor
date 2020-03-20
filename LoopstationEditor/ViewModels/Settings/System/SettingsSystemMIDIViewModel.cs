using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.System;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.System
{
    public class SettingsSystemMIDIViewModel : SettingsViewModel
    {
        public PropertyIntViewModel RxChannel { get; }
        public PropertyBoolViewModel Omni { get; }
        public PropertyMixedViewModel<MIDITxChannel> TxChannel { get; }
        public PropertyEnumRadioViewModel<MIDISync> Sync { get; }
        public PropertyEnumRadioViewModel<MIDISyncSource> SyncSource { get; }
        public PropertyBoolViewModel PCOut { get; }

        public SettingsSystemMIDIViewModel(SettingsSystemMIDIModel model)
            : base(model)
        {
            RxChannel = new PropertyIntViewModel(nameof(RxChannel), _properties, new IntChannelConverter());
            Omni = new PropertyBoolViewModel(nameof(Omni), _properties);
            TxChannel = new PropertyMixedViewModel<MIDITxChannel>(nameof(TxChannel), _properties, new IntChannelConverter());
            Sync = new PropertyEnumRadioViewModel<MIDISync>(nameof(Sync), _properties);
            SyncSource = new PropertyEnumRadioViewModel<MIDISyncSource>(nameof(SyncSource), _properties);
            PCOut = new PropertyBoolViewModel(nameof(PCOut), _properties);
        }
    }
}
