using LoopstationModels.System;

namespace LoopstationModels
{
    public class SystemSettings
    {
        public SetupSettings Setup;
        public InputOutputSettings InputOutput;
        public USBSettings USB;
        public MIDISettings MIDI;

        public MemorySettings DefaultMemory;

        public SystemSettings()
        {
            Setup = new SetupSettings();
            InputOutput = new InputOutputSettings();
            USB = new USBSettings();
            MIDI = new MIDISettings();

            DefaultMemory = new MemorySettings(0);
        }
    }
}
