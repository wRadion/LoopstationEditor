using Loopstation.Xml.System;
using Loopstation.Common.Property;

namespace Loopstation.Model.System
{
    public enum IOInputSource          { MONO, STEREO }
    public enum IOOutputLevelSelection { LINE_PLUS_PHONES, PHONES }

    public class ModelInputOutputSettings
    {
        public int InputNSThreshold
        {
            get => _inputNSThresholdProperty.Value;
            set => _inputNSThresholdProperty.Value = value;
        }
        public int LineOutLevel // TODO Level (0...100) *2
        {
            get => _lineOutLevelProperty.Value;
            set => _lineOutLevelProperty.Value = value;
        }
        public IOInputSource InputSource
        {
            get => _inputSourceProperty.Value;
            set => _inputSourceProperty.Value = value;
        }
        public bool InputLineOut
        {
            get => _inputLineOutProperty.Value;
            set => _inputLineOutProperty.Value = value;
        }
        public IOOutputLevelSelection OutputLevelSelection
        {
            get => _outputLevelSelectionProperty.Value;
            set => _outputLevelSelectionProperty.Value = value;
        }

        #region private Fields
        private IntProperty _inputNSThresholdProperty;
        private IntProperty _lineOutLevelProperty;
        private EnumProperty<IOInputSource> _inputSourceProperty;
        private BoolProperty _inputLineOutProperty;
        private EnumProperty<IOOutputLevelSelection> _outputLevelSelectionProperty;

        private XmlInputOutputSettings _xml;
        #endregion private Fields

        public ModelInputOutputSettings() : this(new XmlInputOutputSettings()) { }
        public ModelInputOutputSettings(XmlInputOutputSettings xmlInputOutput)
        {
            #region private Fields initialization
            _xml = xmlInputOutput;

            _inputNSThresholdProperty     = _xml.InputNSThreshold;
            _lineOutLevelProperty         = _xml.LineOutLevel;
            _inputSourceProperty          = _xml.InputSource;
            _inputLineOutProperty         = _xml.InputLineOut;
            _outputLevelSelectionProperty = _xml.OutputLevelSelection;

            _inputNSThresholdProperty.PropertyChanged     += (_, e) => _xml.InputNSThreshold = e.Value;
            _lineOutLevelProperty.PropertyChanged         += (_, e) => _xml.LineOutLevel = e.Value;
            _inputSourceProperty.PropertyChanged          += (_, e) => _xml.InputSource = e.Value;
            _inputLineOutProperty.PropertyChanged         += (_, e) => _xml.InputLineOut = e.Value;
            _outputLevelSelectionProperty.PropertyChanged += (_, e) => _xml.OutputLevelSelection = e.Value;
            #endregion private Fields initialization
        }
    }
}
