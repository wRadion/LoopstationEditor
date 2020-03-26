using System;
using System.Linq;
using System.Windows.Input;

using LoopstationEditor.Commands;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.Utils;
using LoopstationEditor.ViewModels.Settings.Memory.Tab;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class MemoryApplyToWindowViewModel : ViewModel
    {
        private int _currentMemoryNumber;

        public ICommand ApplyToAllMemories { get; private set; }
        public ICommand ApplyToOnlyMemories { get; private set; }
        public ICommand ApplyToRangeMemories { get; private set; }
        public ICommand ApplyToPreviousMemories { get; private set; }
        public ICommand ApplyToNextMemories { get; private set; }

        public MemoryApplyToWindowViewModel(int currentMemoryNumber, MemoryWindowViewModel memoryViewModel, MemoryTab tab)
        {
            _currentMemoryNumber = currentMemoryNumber;

            switch (tab)
            {
                case MemoryTab.TRACKS: SetTabViewModel(memoryViewModel.TracksTabViewModel); break;
                case MemoryTab.RHYTHM: SetViewModel(memoryViewModel.RhythmViewModel); break;
                case MemoryTab.NAME: SetViewModel(memoryViewModel.NameViewModel); break;
                case MemoryTab.MASTER: SetViewModel(memoryViewModel.MasterViewModel); break;
                case MemoryTab.REC_OPTION: SetViewModel(memoryViewModel.RecOptionViewModel); break;
                case MemoryTab.PLAY_OPTION: SetViewModel(memoryViewModel.PlayOptionViewModel); break;
                case MemoryTab.ASSIGNS: SetTabViewModel(memoryViewModel.AssignsTabViewModel); break;
                case MemoryTab.INPUT_FX: SetTabViewModel(memoryViewModel.InputFxTabViewModel); break;
                case MemoryTab.TRACK_FX: SetTabViewModel(memoryViewModel.TrackFxTabViewModel); break;
            }

            ApplyToPreviousMemories = new Command<int>((previousX) => ApplyToRangeMemories.Execute(new object[] { _currentMemoryNumber - previousX, _currentMemoryNumber }));
            ApplyToNextMemories = new Command<int>((nextX) => ApplyToRangeMemories.Execute(new object[] { _currentMemoryNumber, _currentMemoryNumber + nextX }));
        }

        private void SetTabViewModel(SettingsContainerViewModel tabModel)
        {
            ApplyToAllMemories = new Command<int[]>((excepts) => ApplyTo(tabModel, (memory) => !excepts.Contains(memory.Id + 1)));
            ApplyToOnlyMemories = new Command<int[]>((only) => ApplyTo(tabModel, (memory) => only.Contains(memory.Id + 1)));
            ApplyToRangeMemories = new Command<int, int>((min, max) => ApplyTo(tabModel, (memory) => min <= (memory.Id + 1) && (memory.Id + 1) <= max));
        }

        private void SetViewModel(SettingsViewModel viewModel)
        {
            ApplyToAllMemories = new Command<int[]>((excepts) => ApplyTo(viewModel, (memory) => !excepts.Contains(memory.Id + 1)));
            ApplyToOnlyMemories = new Command<int[]>((only) => ApplyTo(viewModel, (memory) => only.Contains(memory.Id + 1)));
            ApplyToRangeMemories = new Command<int, int>((min, max) => ApplyTo(viewModel, (memory) => min <= (memory.Id + 1) && (memory.Id + 1) <= max));
        }

        private void ApplyTo(SettingsContainerViewModel currentViewModel, Func<MemoryModel, bool> predicate)
        {
            foreach (MemoryModel memory in Global.Instance.MemoryFileModel.Memories)
            {
                if (!predicate(memory)) continue;
                currentViewModel.ApplyChanges(memory);
            }
        }

        private void ApplyTo(SettingsViewModel currentViewModel, Func<MemoryModel, bool> predicate)
        {
            foreach (MemoryModel memory in Global.Instance.MemoryFileModel.Memories)
            {
                if (!predicate(memory)) continue;

                if (currentViewModel is SettingsMemoryRhythmViewModel rhythm)
                    rhythm.ApplyChanges(memory.Rhythm);
                else if (currentViewModel is SettingsMemoryNameViewModel name)
                    name.ApplyChanges(memory.Name);
                else if (currentViewModel is SettingsMemoryMasterViewModel master)
                    master.ApplyChanges(memory.Master);
                else if (currentViewModel is SettingsMemoryRecOptionViewModel recOption)
                    recOption.ApplyChanges(memory.RecOption);
                else if (currentViewModel is SettingsMemoryPlayOptionViewModel playOption)
                    playOption.ApplyChanges(memory.PlayOption);
                else
                    throw new NotImplementedException();
            }
        }
    }
}
