using Loopstation.Xml.System;

namespace Loopstation.Model.System
{
    public enum InputSource { MONO, STEREO }
    public enum InputLineOut { OFF, ON }
    public enum OutputLevelSelection { LINE_PLUS_PHONES, PHONES }

    public class ModelInputOutputSettings
    {
        public int InputNSTreshold { get; set; }

        // TODO Level (0...100) *2
        private int _lineOutLvl;
        public int LineOutLevel { get; set; }

        public InputSource InputSource { get; set; }
        public InputLineOut InputLineOut { get; set; }
        public OutputLevelSelection OutputLevelSelection { get; set; }

        public ModelInputOutputSettings(XmlInputOutputSettings xmlInputOutput)
        {
            InputNSTreshold = xmlInputOutput.InputNSTreshold;
            LineOutLevel = xmlInputOutput.LineOutLevel;
            InputSource = (InputSource)xmlInputOutput.InputSource;
            InputLineOut = (InputLineOut)xmlInputOutput.InputLineOut;
            OutputLevelSelection = (OutputLevelSelection)xmlInputOutput.OutputLevelSelection;
        }
    }
}
