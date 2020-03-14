using LoopstationEditor.Extensions;
using LoopstationEditor.Models.PropertyEngine;
using LoopstationEditor.Models.Settings;
using LoopstationEditor.ViewModels.PropertyEngine;
using System;

namespace LoopstationEditor.ViewModels.Settings
{
    public class SettingsSystemInputOutputViewModel : SettingsViewModel
    {
        private readonly PropertyViewModel<ValueInt> _inputNSThreshold;
        private readonly PropertyViewModel<ValueInt> _lineOutLevel;
        private readonly PropertyViewModel<ValueEnum<IOInputSource>> _inputSource;
        private readonly PropertyViewModel<ValueBool> _inputLineOut;
        private readonly PropertyViewModel<ValueEnum<IOOutputLevelSelection>> _outputLevelSelection;

        public int InputNSThreshold
        {
            get => _inputNSThreshold.GetValue();
            set => _inputNSThreshold.SetValue(value);
        }
        public int InputNSThresholdMinimum => _inputNSThreshold.MinimumValue;
        public int InputNSThresholdMaximum => _inputNSThreshold.MaximumValue;

        public int LineOutLevel
        {
            get => _lineOutLevel.GetValue();
            set => _lineOutLevel.SetValue(value);
        }
        public int LineOutLevelMinimum => _lineOutLevel.MinimumValue;
        public int LineOutLevelMaximum => _lineOutLevel.MaximumValue;

        public string[] InputSources => EnumUtils.GetEnums<IOInputSource>();
        private IOInputSource InputSource
        {
            get => _inputSource.GetValue();
            set => _inputSource.SetValue(value);
        }
        public string InputSourceString
        {
            get => EnumUtils.ToString(InputSource);
            set => InputSource = EnumUtils.FromString<IOInputSource>(value);
        }

        public bool InputLineOut
        {
            get => _inputLineOut.GetValue();
            set => _inputLineOut.SetValue(value);
        }

        public string[] OutputLevelSelections => EnumUtils.GetEnums<IOOutputLevelSelection>();
        private IOOutputLevelSelection OutputLevelSelection
        {
            get => _outputLevelSelection.GetValue();
            set => _outputLevelSelection.SetValue(value);
        }
        public string OutputLevelSelectionString
        {
            get => EnumUtils.ToString(OutputLevelSelection);
            set => OutputLevelSelection = EnumUtils.FromString<IOOutputLevelSelection>(value);
        }

        public SettingsSystemInputOutputViewModel(SettingsSystemInputOutputModel model)
            : base(model)
        {
            _inputNSThreshold = new PropertyViewModel<ValueInt>(InputOutputProperty.InputNSThreshold, _properties);
            _lineOutLevel = new PropertyViewModel<ValueInt>(InputOutputProperty.LineOutLevel, _properties);
            _inputSource = new PropertyViewModel<ValueEnum<IOInputSource>>(InputOutputProperty.InputSource, _properties);
            _inputLineOut = new PropertyViewModel<ValueBool>(InputOutputProperty.InputLineOut, _properties);
            _outputLevelSelection = new PropertyViewModel<ValueEnum<IOOutputLevelSelection>>(InputOutputProperty.OutputLevelSelection, _properties);
        }
    }
}
