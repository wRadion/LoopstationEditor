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
        public PropertyEnumViewModel<SetupDisplayMode> DisplayMode { get; }
        public PropertyEnumViewModel<SetupIndicatorMode> IndicatorMode { get; }
        public PropertyBoolViewModel AutoOff { get; }
        public PropertyBoolViewModel AllClear { get; }
        public PropertyBoolViewModel QuickClear { get; }
        public PropertyEnumViewModel<SetupKnobMode> KnobMode { get; }

        public SettingsSystemSetupViewModel(SettingsSystemSetupModel model)
            : base(model)
        {
            SelectedMemory = new PropertyIntViewModel(nameof(SelectedMemory), _properties, new IntMemoryNumberConverter());
            LcdContrast = new PropertyIntViewModel(nameof(LcdContrast), _properties);
            PhantomPower = new PropertyBoolViewModel(nameof(PhantomPower), _properties);
            DisplayMode = new PropertyEnumViewModel<SetupDisplayMode>(nameof(DisplayMode), _properties);
            IndicatorMode = new PropertyEnumViewModel<SetupIndicatorMode>(nameof(IndicatorMode), _properties);
            AutoOff = new PropertyBoolViewModel(nameof(AutoOff), _properties);
            AllClear = new PropertyBoolViewModel(nameof(AllClear), _properties);
            QuickClear = new PropertyBoolViewModel(nameof(QuickClear), _properties);
            KnobMode = new PropertyEnumViewModel<SetupKnobMode>(nameof(KnobMode), _properties);
        }
    }
}
