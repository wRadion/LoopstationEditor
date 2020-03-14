using LoopstationEditor.Models.Settings.System;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.System
{
    public class SettingsSystemSetupViewModel : SettingsViewModel
    {
        public PropertyIntViewModel SelectedMemory { get; }
        public PropertyIntViewModel LcdContrast { get; }
        public PropertyBoolViewModel PhantomPower { get; }
        public PropertyEnumViewModel<SetupDisplayMode> DisplayMode { get; }
        public PropertyEnumViewModel<SetupIndicatorMode> IndicatorMode { get; }
        public PropertyBoolViewModel AutoOff { get; }
        public PropertyBoolViewModel AllClear { get; }
        public PropertyBoolViewModel QuickClear { get; }
        public PropertyEnumViewModel<SetupKnobMode> KnobMode { get; }

        public SettingsSystemSetupViewModel(SettingsSystemSetupModel model)
            : base(model)
        {
            SelectedMemory = new PropertyIntViewModel(SetupProperty.SelectedMemory, _properties);
            LcdContrast = new PropertyIntViewModel(SetupProperty.LcdContrast, _properties);
            PhantomPower = new PropertyBoolViewModel(SetupProperty.PhantomPower, _properties);
            DisplayMode = new PropertyEnumViewModel<SetupDisplayMode>(SetupProperty.DisplayMode, _properties);
            IndicatorMode = new PropertyEnumViewModel<SetupIndicatorMode>(SetupProperty.IndicatorMode, _properties);
            AutoOff = new PropertyBoolViewModel(SetupProperty.AutoOff, _properties);
            AllClear = new PropertyBoolViewModel(SetupProperty.AllClear, _properties);
            QuickClear = new PropertyBoolViewModel(SetupProperty.QuickClear, _properties);
            KnobMode = new PropertyEnumViewModel<SetupKnobMode>(SetupProperty.KnobMode, _properties);
        }
    }
}
