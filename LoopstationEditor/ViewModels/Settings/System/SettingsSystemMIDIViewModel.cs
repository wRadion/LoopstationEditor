using LoopstationEditor.Models.Settings.System;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.System
{
    public class SettingsSystemMIDIViewModel : SettingsViewModel
    {
        public PropertyIntViewModel RxChannel { get; }
        public PropertyBoolViewModel Omni { get; }
        // TODO MIXED
        public PropertyIntViewModel TxChannel { get; }
        public PropertyEnumViewModel<MIDISync> Sync { get; }
        public PropertyEnumViewModel<MIDISyncSource> SyncSource { get; }
        public PropertyBoolViewModel PCOut { get; }

        public SettingsSystemMIDIViewModel(SettingsSystemMIDIModel model)
            : base(model)
        {
            RxChannel = new PropertyIntViewModel(MIDIProperty.RxChannel, _properties);
            Omni = new PropertyBoolViewModel(MIDIProperty.Omni, _properties);
            TxChannel = new PropertyIntViewModel(MIDIProperty.TxChannel, _properties);
            Sync = new PropertyEnumViewModel<MIDISync>(MIDIProperty.Sync, _properties);
            SyncSource = new PropertyEnumViewModel<MIDISyncSource>(MIDIProperty.SyncSource, _properties);
            PCOut = new PropertyBoolViewModel(MIDIProperty.PCOut, _properties);
        }
    }
}
