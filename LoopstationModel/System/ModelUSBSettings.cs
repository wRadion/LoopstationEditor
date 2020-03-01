using Loopstation.Xml.System;

namespace Loopstation.Model.System
{
    public enum USBMode { STORAGE, AUDIO_MIDI }
    public enum USBAudioRouting { LOOP_IN, SUBMIX, LINEOUT }

    public class ModelUSBSettings
    {
        public USBMode Mode { get; set; }
        public USBAudioRouting AudioRouting { get; set; }

        // TODO Level (0...100) *2
        private int _inLvl;
        public int InputLevel { get; set; }

        // TODO Level (0...100) *2
        private int _outLvl;
        public int OutputLevel { get; set; }

        public ModelUSBSettings(XmlUSBSettings xmlUSB)
        {
            Mode = (USBMode)xmlUSB.Mode;
            AudioRouting = (USBAudioRouting)xmlUSB.AudioRouting;
            InputLevel = xmlUSB.InputLevel;
            OutputLevel = xmlUSB.OutputLevel;
        }
    }
}
