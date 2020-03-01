using Loopstation.Xml.System;

namespace Loopstation.Model.System
{
    public enum IOInputSource { MONO, STEREO }
    public enum IOOutputLevelSelection { LINE_PLUS_PHONES, PHONES }

    public class ModelInputOutputSettings
    {
        public int InputNSTreshold { get; set; } = 40;

        // TODO Level (0...100) *2
        private int _lineOutLvl;
        public int LineOutLevel { get; set; } = 50;

        public IOInputSource InputSource { get; set; } = IOInputSource.STEREO;

        public bool IsInputLineOut { get; set; } = true;
        public IOOutputLevelSelection OutputLevelSelection { get; set; } = IOOutputLevelSelection.LINE_PLUS_PHONES;

        public ModelInputOutputSettings() : this(null) { }
        public ModelInputOutputSettings(XmlInputOutputSettings xmlInputOutput)
        {
            if (xmlInputOutput == null) return;

            InputNSTreshold = xmlInputOutput.InputNSTreshold;
            LineOutLevel = xmlInputOutput.LineOutLevel;
            InputSource = (IOInputSource)xmlInputOutput.InputSource;
            IsInputLineOut = xmlInputOutput.InputLineOut == 1;
            OutputLevelSelection = (IOOutputLevelSelection)xmlInputOutput.OutputLevelSelection;
        }
    }
}
