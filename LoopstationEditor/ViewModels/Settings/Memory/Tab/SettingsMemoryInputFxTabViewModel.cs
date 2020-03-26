using System;

using LoopstationEditor.Models.Settings.Memory;

namespace LoopstationEditor.ViewModels.Settings.Memory.Tab
{
    public class SettingsMemoryInputFxTabViewModel : SettingsContainerViewModel
    {
        public override SettingsViewModel CurrentViewModel
        {
            get
            {
                switch (SelectedIndex)
                {
                    case 0: return InputFx;
                    case 1: return InputFxA.CurrentViewModel;
                    case 2: return InputFxB.CurrentViewModel;
                    case 3: return InputFxC.CurrentViewModel;
                }

                throw new ArgumentOutOfRangeException("InputFxTab index must be between 0 and 3.");
            }
        }

        public SettingsMemoryInputFxViewModel InputFx { get; }
        public SettingsMemoryFxInputViewModel InputFxA { get; }
        public SettingsMemoryFxInputViewModel InputFxB { get; }
        public SettingsMemoryFxInputViewModel InputFxC { get; }

        public SettingsMemoryInputFxTabViewModel(MemoryModel model)
            : base(model)
        {
            InputFx = new SettingsMemoryInputFxViewModel(model.InputFx);
            InputFxA = new SettingsMemoryFxInputViewModel(FxSlot.A, model.InputFxA);
            InputFxB = new SettingsMemoryFxInputViewModel(FxSlot.B, model.InputFxB);
            InputFxC = new SettingsMemoryFxInputViewModel(FxSlot.C, model.InputFxC);
        }

        public override void ApplyChanges<T>(T model)
        {
            if (model is MemoryModel memory)
            {
                InputFx.ApplyChanges(memory.InputFx);
                InputFxA.ApplyChanges(memory.InputFxA);
                InputFxB.ApplyChanges(memory.InputFxB);
                InputFxC.ApplyChanges(memory.InputFxC);
            }
            else
                throw new ArgumentException("Model must be of type MemoryModel.");
        }

        public override void RevertChanges()
        {
            InputFx.RevertChanges();
            InputFxA.RevertChanges();
            InputFxB.RevertChanges();
            InputFxC.RevertChanges();
        }
    }
}
