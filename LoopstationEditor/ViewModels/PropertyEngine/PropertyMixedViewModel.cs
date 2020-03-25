using System;

using LoopstationEditor.Converters;
using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.ViewModels.PropertyEngine
{
    public class PropertyMixedViewModel<TEnum> : PropertyViewModel<int, int> where TEnum : Enum
    {
        private PropertyBoolViewModel MixedViewModel { get; }

        public bool IsInt
        {
            get => !MixedViewModel.Value;
            set
            {
                if (value)
                    MixedViewModel.Value = false;
            }
        }
        public PropertyIntViewModel IntViewModel { get; }

        public bool IsEnum
        {
            get => MixedViewModel.Value;
            set
            {
                if (value)
                    MixedViewModel.Value = true;
            }
        }
        public PropertyEnumComboViewModel<TEnum> EnumViewModel { get; }

        public PropertyMixedViewModel(string name, PropertySet set) : this(name, set, new IntIdentityConverter(), new EnumDefaultConverter<TEnum>()) { }
        public PropertyMixedViewModel(string name, PropertySet set, IValueConverter<int, int> intConverter) : this(name, set, intConverter, new EnumDefaultConverter<TEnum>()) { }
        public PropertyMixedViewModel(string name, PropertySet set, IValueConverter<TEnum, string> enumConverter) : this(name, set, new IntIdentityConverter(), enumConverter) { }
        public PropertyMixedViewModel(string name, PropertySet set, IValueConverter<int, int> intConverter, IValueConverter<TEnum, string> enumConverter)
            : base(name, set, intConverter)
        {
            MixedViewModel = new PropertyBoolViewModel(name + "_mixed", set);
            MixedViewModel.PropertyChanged += (sender, e) => This_PropertyChanged();
            IntViewModel = new PropertyIntViewModel(name + "_int", set, intConverter);
            EnumViewModel = new PropertyEnumComboViewModel<TEnum>(name + "_enum", set, enumConverter);
        }

        public override void This_PropertyChanged()
        {
            OnPropertyChanged(nameof(IsInt));
            OnPropertyChanged(nameof(IsEnum));
        }
    }
}
