using Loopstation.Xml.Memory;
using Loopstation.Model.Memory.Base;

namespace Loopstation.Model.Memory
{
    public class ModelInputFx : ModelFxSettingsBase
    {
        public ModelInputFx(FxSlot slot, XmlFxSettings xmlFx) : base(FxType.INPUT, slot, xmlFx) { }
    }
}
