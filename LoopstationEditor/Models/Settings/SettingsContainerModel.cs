using LoopstationEditor.Models.Interfaces;

namespace LoopstationEditor.Models.Settings
{
    public abstract class SettingsContainerModel : IXmlContainer
    {
        public abstract void ApplyXmlValues();
        public abstract void ApplyPropertyValues();
    }
}
