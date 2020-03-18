using LoopstationEditor.Converters;
using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.ViewModels.PropertyEngine
{
    public abstract class PropertyViewModel<TInput, TOutput>
    {
        protected string _name;
        protected PropertySet _set;
        protected IValueConverter<TInput, TOutput> _converter;

        public PropertyViewModel(string name, PropertySet set, IValueConverter<TInput, TOutput> converter)
        {
            _name = name;
            _set = set;
            _converter = converter;
        }
    }
}
