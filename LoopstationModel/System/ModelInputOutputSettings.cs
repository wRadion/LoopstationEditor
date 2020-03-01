using Loopstation.Xml.System;

namespace Loopstation.Model.System
{
    public enum IOInputSource { MONO, STEREO }
    public enum IOOutputLevelSelection { LINE_PLUS_PHONES, PHONES }

    public class ModelInputOutputSettings
    {
        public int InputNSTreshold { get; set; }

        // TODO Level (0...100) *2
        private int _lineOutLvl;
        public int LineOutLevel { get; set; }

        public IOInputSource InputSource { get; set; }
        public bool IsInputLineOut { get; set; }
        public IOOutputLevelSelection OutputLevelSelection { get; set; }

        public ModelInputOutputSettings(XmlInputOutputSettings xmlInputOutput)
        {
            InputNSTreshold = xmlInputOutput.InputNSTreshold;
            LineOutLevel = xmlInputOutput.LineOutLevel;
            InputSource = (IOInputSource)xmlInputOutput.InputSource;
            IsInputLineOut = xmlInputOutput.InputLineOut == 1;
            OutputLevelSelection = (IOOutputLevelSelection)xmlInputOutput.OutputLevelSelection;
        }
    }
}
