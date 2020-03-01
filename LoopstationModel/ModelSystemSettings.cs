﻿using Loopstation.Xml;
using Loopstation.Model.System;

namespace Loopstation.Model
{
    public class ModelSystemSettings
    {
        public ModelSetupSettings Setup;
        public ModelInputOutputSettings InputOutput;
        public ModelUSBSettings USB;
        public ModelMIDISettings MIDI;

        public ModelSystemSettings(XmlSystemSettings xmlSystem)
        {
            Setup = new ModelSetupSettings(xmlSystem.Setup);
            InputOutput = new ModelInputOutputSettings(xmlSystem.InputOutput);
            USB = new ModelUSBSettings(xmlSystem.USB);
            MIDI = new ModelMIDISettings(xmlSystem.MIDI);
        }
    }
}