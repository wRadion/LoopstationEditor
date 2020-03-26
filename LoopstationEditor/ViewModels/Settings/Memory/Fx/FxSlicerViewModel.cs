using LoopstationEditor.Converters.Enum;
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
            SlicerPattern = new PropertyEnumComboViewModel<FxSlicerPattern>(nameof(model.SlicerPattern), PropertySet);
            SlicerRate = new PropertyMixedViewModel<FxRate>(nameof(model.SlicerRate), PropertySet, new EnumNoteConverter<FxRate>());
            SlicerDepth = new PropertyIntViewModel(nameof(model.SlicerDepth), PropertySet);
        }
    }
}
