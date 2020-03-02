using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public enum RobotNote { C, Db, D, Eb, E, F, Gb, G, Ab, A, Bb, B }

    public class RobotFx
    {
        public RobotNote Note
        {
            get => _noteProperty.Value;
            set => _noteProperty.Value = value;
        }
        public int Gender // TODO: Robot Gender (0...20) -10
        {
            get => _genderProperty.Value;
            set => _genderProperty.Value = value;
        }

        #region private Fields
        private readonly EnumProperty<RobotNote> _noteProperty;
        private readonly IntProperty _genderProperty;

        private XmlFxSettings _xml;
        #endregion private Fields

        public RobotFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _noteProperty   = _xml.RobotNote;
            _genderProperty = _xml.RobotGender;

            _noteProperty.PropertyChanged   += (_, e) => _xml.RobotNote = e.Value;
            _genderProperty.PropertyChanged += (_, e) => _xml.RobotGender = e.Value;
            #endregion private Fields initialization
        }
    }
}
