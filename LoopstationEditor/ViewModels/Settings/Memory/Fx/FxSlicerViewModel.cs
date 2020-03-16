using LoopstationEditor.Models.Settings.Memory.Fx;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxSlicerViewModel : SettingsViewModel
    {
        public PropertyEnumViewModel<FxSlicerPattern> SlicerPattern { get; }
        public PropertyMixedViewModel<FxRate> SlicerRate { get; }
        public PropertyIntViewModel SlicerDepth { get; }

        public FxSlicerViewModel(FxSlicerModel model)
            : base(model)
        {
            SlicerPattern = new PropertyEnumViewModel<FxSlicerPattern>(FxProperty.SlicerPattern, _properties);
            SlicerRate = new PropertyMixedViewModel<FxRate>(FxProperty.SlicerRate, _properties);
            SlicerDepth = new PropertyIntViewModel(FxProperty.SlicerDepth, _properties);
        }
    }
}
