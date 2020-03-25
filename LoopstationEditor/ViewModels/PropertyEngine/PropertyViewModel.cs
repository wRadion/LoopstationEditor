using LoopstationEditor.Converters;
using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.ViewModels.PropertyEngine
{
    public abstract class PropertyViewModel<TInput, TOutput> : ViewModel
    {
        protected string _name;
        protected PropertySet _set;
        protected IValueConverter<TInput, TOutput> _converter;

        public PropertyViewModel(string name, PropertySet set, IValueConverter<TInput, TOutput> converter)
        {
            _name = name;
            _set = set;
            _converter = converter;

            _set.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == name)
                    This_PropertyChanged();
            };
        }

        public abstract void This_PropertyChanged();
    }
}
