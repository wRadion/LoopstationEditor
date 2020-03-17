using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Interfaces
{
    public interface IPropertySet
    {
        void PastePropertySet(PropertySet set);
        PropertySet CopyPropertySet();
    }
}
