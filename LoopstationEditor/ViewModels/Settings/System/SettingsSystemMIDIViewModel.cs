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
            RxChannel = new PropertyIntViewModel(nameof(model.RxChannel), PropertySet, new IntChannelConverter());
            Omni = new PropertyBoolViewModel(nameof(model.Omni), PropertySet);
            TxChannel = new PropertyMixedViewModel<MIDITxChannel>(nameof(model.TxChannel), PropertySet, new IntChannelConverter());
            Sync = new PropertyEnumRadioViewModel<MIDISync>(nameof(model.Sync), PropertySet);
            SyncSource = new PropertyEnumRadioViewModel<MIDISyncSource>(nameof(model.SyncSource), PropertySet);
            PCOut = new PropertyBoolViewModel(nameof(model.PCOut), PropertySet);
        }
    }
}
