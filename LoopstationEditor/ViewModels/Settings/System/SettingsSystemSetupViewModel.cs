using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.System;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.System
{
    public class SettingsSystemSetupViewModel : SettingsViewModel
    {
        public PropertyIntViewModel SelectedMemory { get; }
        public PropertyIntViewModel LcdContrast { get; }
        public PropertyBoolViewModel PhantomPower { get; }
        public PropertyEnumComboViewModel<SetupDisplayMode> DisplayMode { get; }
        public PropertyEnumComboViewModel<SetupIndicatorMode> IndicatorMode { get; }
        public PropertyBoolViewModel AutoOff { get; }
        public PropertyBoolViewModel AllClear { get; }
        public PropertyBoolViewModel QuickClear { get; }
        public PropertyEnumRadioViewModel<SetupKnobMode> KnobMode { get; }

        public SettingsSystemSetupViewModel(SettingsSystemSetupModel model)
            : base(model)
        {
            SelectedMemory = new PropertyIntViewModel(nameof(model.SelectedMemory), _properties, new IntMemoryNumberConverter());
            LcdContrast = new PropertyIntViewModel(nameof(model.LcdContrast), _properties);
            PhantomPower = new PropertyBoolViewModel(nameof(model.PhantomPower), _properties);
            DisplayMode = new PropertyEnumComboViewModel<SetupDisplayMode>(nameof(model.DisplayMode), _properties);
            IndicatorMode = new PropertyEnumComboViewModel<SetupIndicatorMode>(nameof(model.IndicatorMode), _properties);
            AutoOff = new PropertyBoolViewModel(nameof(model.AutoOff), _properties);
            AllClear = new PropertyBoolViewModel(nameof(model.AllClear), _properties);
            QuickClear = new PropertyBoolViewModel(nameof(model.QuickClear), _properties);
            KnobMode = new PropertyEnumRadioViewModel<SetupKnobMode>(nameof(model.KnobMode), _properties);
        }
    }
}
