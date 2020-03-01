using Loopstation.Model.Memory.Base;
using Loopstation.Xml.Memory;

namespace Loopstation.Model.Memory
{
    public class ModelInputFx : ModelFxSettingsBase
    {
        public ModelInputFx(FxSlot slot) : this(slot, null) { }
        public ModelInputFx(FxSlot slot, XmlFxSettings xmlFx) : base(FxType.INPUT, slot, xmlFx) { }
    }
}
