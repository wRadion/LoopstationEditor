using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory.Fx
{
    public class FxSlicerViewModel : FxViewModel
    {
        public PropertyEnumComboViewModel<FxSlicerPattern> SlicerPattern { get; }
        public PropertyMixedViewModel<FxRate> SlicerRate { get; }
        public PropertyIntViewModel SlicerDepth { get; }

        public FxSlicerViewModel(SettingsMemoryFxModel model)
            : base("Slicer", model)
        {
            SlicerPattern = new PropertyEnumComboViewModel<FxSlicerPattern>(nameof(SlicerPattern), _properties);
            SlicerRate = new PropertyMixedViewModel<FxRate>(nameof(SlicerRate), _properties);
            SlicerDepth = new PropertyIntViewModel(nameof(SlicerDepth), _properties);
        }
    }
}
