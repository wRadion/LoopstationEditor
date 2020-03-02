using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public class ReverbFx
    {
        public int Time // TODO: Reverb Time (1...100) /10 (sec)
        {
            get => _timeProperty.Value;
            set => _timeProperty.Value = value;
        }
        public int Level
        {
            get => _levelProperty.Value;
            set => _levelProperty.Value = value;
        }
        public int DryLevel
        {
            get => _dryLevelProperty.Value;
            set => _dryLevelProperty.Value = value;
        }

        #region private Fields
        private readonly IntProperty _timeProperty;
        private readonly IntProperty _levelProperty;
        private readonly IntProperty _dryLevelProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public ReverbFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _timeProperty     = _xml.ReverbTime;
            _levelProperty    = _xml.ReverbLevel;
            _dryLevelProperty = _xml.ReverbDryLevel;

            _timeProperty.PropertyChanged     += (_, e) => _xml.ReverbTime = e.Value;
            _levelProperty.PropertyChanged    += (_, e) => _xml.ReverbLevel = e.Value;
            _dryLevelProperty.PropertyChanged += (_, e) => _xml.ReverbDryLevel = e.Value;
            #endregion private Fields initialization
        }
    }
}
