using Loopstation.Xml.System;
using Loopstation.Common.Property;

namespace Loopstation.Model.System
{
    public enum USBMode         { STORAGE, AUDIO_MIDI }
    public enum USBAudioRouting { LOOP_IN, SUBMIX, LINEOUT }

    public class ModelUSBSettings
    {
        public USBMode Mode
        {
            get => _modeProperty.Value;
            set => _modeProperty.Value = value;
        }
        public USBAudioRouting AudioRouting
        {
            get => _audioRoutingProperty.Value;
            set => _audioRoutingProperty.Value = value;
        }
        public int InputLevel // TODO Level (0...100) *2
        {
            get => _inputLevelProperty.Value;
            set => _inputLevelProperty.Value = value;
        }
        public int OutputLevel // TODO Level (0...100) *2
        {
            get => _outputLevelProperty.Value;
            set => _outputLevelProperty.Value = value;
        }

        #region private Fields
        private readonly EnumProperty<USBMode> _modeProperty;
        private readonly EnumProperty<USBAudioRouting> _audioRoutingProperty;
        private readonly IntProperty _inputLevelProperty;
        private readonly IntProperty _outputLevelProperty;

        private readonly XmlUSBSettings _xml;
        #endregion private Fields

        public ModelUSBSettings(XmlUSBSettings xmlUSB)
        {
            #region private Fields initialization
            _xml = xmlUSB;

            _modeProperty         = _xml.Mode;
            _audioRoutingProperty = _xml.AudioRouting;
            _inputLevelProperty   = _xml.InputLevel;
            _outputLevelProperty  = _xml.OutputLevel;

            _modeProperty.PropertyChanged         += (_, e) => _xml.Mode = e.Value;
            _audioRoutingProperty.PropertyChanged += (_, e) => _xml.AudioRouting = e.Value;
            _inputLevelProperty.PropertyChanged   += (_, e) => _xml.InputLevel = e.Value;
            _outputLevelProperty.PropertyChanged  += (_, e) => _xml.OutputLevel = e.Value;
            #endregion private Fields initialization
        }
    }
}
