using System.Xml.Serialization;

using Loopstation.Xml.Interfaces;
using Loopstation.Xml.Utils;

namespace Loopstation.Xml.System
{
    [XmlRoot("INPUT_OUTPUT")]
    public class XmlInputOutputSettings : ICloneable<XmlInputOutputSettings>
    {
        private int _inputNSThreshold;
        private int _lineOutLevel;
        private int _inputSource;
        private int _inputLineOut;
        private int _outputLevelSelection;

        /// <summary>
		/// Integer from <c>0</c> to <c>100</c>.
		/// <para>Default value is <c>40</c>.</para>
		/// </summary>
        [XmlElement("InNsThrs")]
        public int InputNSThreshold
        {
            get => _inputNSThreshold;
            set => _inputNSThreshold = Range.Guard(value);
        }

        /// <summary>
		/// Integer from <c>0</c> to <c>100</c>.
		/// <para>Default value is <c>50</c>.</para>
		/// </summary>
        [XmlElement("LineOutLvl")]
        public int LineOutLevel
        {
            get => _lineOutLevel;
            set => _lineOutLevel = Range.Guard(value);
        }

        /// <summary>
		/// Integer from <c>0</c> to <c>1</c>.
		/// <para>Default value is <c>1</c>.</para>
		/// </summary>
        [XmlElement("InSrc")]
        public int InputSource
        {
            get => _inputSource;
            set => _inputSource = Range.Guard(value, max: 1);
        }

        /// <summary>
		/// Integer from <c>0</c> to <c>1</c>.
		/// <para>Default value is <c>1</c>.</para>
		/// </summary>
        [XmlElement("InLineOut")]
        public int InputLineOut
        {
            get => _inputLineOut;
            set => _inputLineOut = Range.Guard(value, max: 1);
        }

        /// <summary>
		/// Integer from <c>0</c> to <c>1</c>.
		/// <para>Default value is <c>0</c>.</para>
		/// </summary>
        [XmlElement("OutLvlSel")]
        public int OutputLevelSelection
        {
            get => _outputLevelSelection;
            set => _outputLevelSelection = Range.Guard(value, max: 1);
        }

        public XmlInputOutputSettings() : this(null) { }
        public XmlInputOutputSettings(XmlInputOutputSettings other)
        {
            InputNSThreshold     = other?.InputNSThreshold     ?? 40;
            LineOutLevel         = other?.LineOutLevel         ?? 50;
            InputSource          = other?.InputSource          ?? 1;
            InputLineOut         = other?.InputLineOut         ?? 1;
            OutputLevelSelection = other?.OutputLevelSelection ?? 0;
        }

        public XmlInputOutputSettings Clone() => new XmlInputOutputSettings(this);
    }
}
