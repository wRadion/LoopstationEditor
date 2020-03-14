using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.ViewModels.PropertyEngine
{
    public abstract class PropertyViewModel<T> where T : ValueInt
    {
        protected string _name;
        protected PropertySet _set;

        public PropertyViewModel(string name, PropertySet set)
        {
            _name = name;
            _set = set;
        }
    }
}
