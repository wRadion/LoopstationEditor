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
            SelectedMemory = new PropertyIntViewModel(nameof(model.SelectedMemory), PropertySet, new IntMemoryNumberConverter());
            LcdContrast = new PropertyIntViewModel(nameof(model.LcdContrast), PropertySet);
            PhantomPower = new PropertyBoolViewModel(nameof(model.PhantomPower), PropertySet);
            DisplayMode = new PropertyEnumComboViewModel<SetupDisplayMode>(nameof(model.DisplayMode), PropertySet);
            IndicatorMode = new PropertyEnumComboViewModel<SetupIndicatorMode>(nameof(model.IndicatorMode), PropertySet);
            AutoOff = new PropertyBoolViewModel(nameof(model.AutoOff), PropertySet);
            AllClear = new PropertyBoolViewModel(nameof(model.AllClear), PropertySet);
            QuickClear = new PropertyBoolViewModel(nameof(model.QuickClear), PropertySet);
            KnobMode = new PropertyEnumRadioViewModel<SetupKnobMode>(nameof(model.KnobMode), PropertySet);
        }
    }
}
