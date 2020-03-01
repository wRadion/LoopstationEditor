using Loopstation.Xml.System;

namespace Loopstation.Model.System
{
    public enum USBMode { STORAGE, AUDIO_MIDI }
    public enum USBAudioRouting { LOOP_IN, SUBMIX, LINEOUT }

    public class ModelUSBSettings
    {
        public USBMode Mode { get; set; } = USBMode.STORAGE;
        public USBAudioRouting AudioRouting { get; set; } = USBAudioRouting.LOOP_IN;

        // TODO Level (0...100) *2
        private int _inLvl;
        public int InputLevel { get; set; } = 50;

        // TODO Level (0...100) *2
        private int _outLvl;
        public int OutputLevel { get; set; } = 50;

        public ModelUSBSettings() : this(null) { }
        public ModelUSBSettings(XmlUSBSettings xmlUSB)
        {
            if (xmlUSB == null) return;

            Mode = (USBMode)xmlUSB.Mode;
            AudioRouting = (USBAudioRouting)xmlUSB.AudioRouting;
            InputLevel = xmlUSB.InputLevel;
            OutputLevel = xmlUSB.OutputLevel;
        }
    }
}
