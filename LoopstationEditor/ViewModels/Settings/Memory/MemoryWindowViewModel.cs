using LoopstationEditor.Commands;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.Settings.Memory.Tab;
using LoopstationEditor.Views.Settings.Memory;
using System;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public enum MemoryTab
    {
        TRACKS = 0,
        RHYTHM = 1,
        NAME = 2,
        MASTER = 3,
        REC_OPTION = 4,
        PLAY_OPTION = 5,
        ASSIGNS = 6,
        INPUT_FX = 7,
        TRACK_FX = 8,
        INPUT_FXS = 9,
        TRACK_FXS = 10
    }

    public class MemoryWindowViewModel : WindowViewModel<MemoryWindow>
    {
        public int Id { get; }

        public delegate void NameViewModelInitializedEventHandler(SettingsMemoryNameViewModel viewModel);
        public event NameViewModelInitializedEventHandler NameViewModelInitialized;

        public SettingsMemoryTracksTabViewModel TracksTabViewModel { get; private set; }
        public SettingsMemoryRhythmViewModel RhythmViewModel { get; private set; }
        public SettingsMemoryNameViewModel NameViewModel { get; private set; }
        public SettingsMemoryMasterViewModel MasterViewModel { get; private set; }
        public SettingsMemoryRecOptionViewModel RecOptionViewModel { get; private set; }
        public SettingsMemoryPlayOptionViewModel PlayOptionViewModel { get; private set; }
        public SettingsMemoryAssignViewModel[] AssignViewModels { get; private set; }
        public SettingsMemoryInputFxViewModel InputFxViewModel { get; private set; }
        public SettingsMemoryTrackFxViewModel TrackFxViewModel { get; private set; }
        public SettingsMemoryFxInputViewModel[] FxInputViewModels { get; private set; }
        public SettingsMemoryFxTrackViewModel[] FxTrackViewModels { get; private set; }

        public MemoryWindowViewModel(MemoryModel model)
            : base(model)
        {
            Id = model.Id + 1;

            ApplyChangesCommand = new RelayCommand(() =>
            {
                TracksTabViewModel.Track1.ApplyChanges();
                TracksTabViewModel.Track2.ApplyChanges();
                TracksTabViewModel.Track3.ApplyChanges();
                TracksTabViewModel.Track4.ApplyChanges();
                TracksTabViewModel.Track5.ApplyChanges();
                RhythmViewModel.ApplyChanges();
                NameViewModel.ApplyChanges();
                MasterViewModel.ApplyChanges();
            });
        }

        public void ShowSubtab(MemoryTab tab, int subtab)
        {
            Show(tab);
            _view.SetSelectedSubtabIndex(subtab);
        }

        protected override void InitViewModels()
        {
            MemoryModel model = (MemoryModel)_model;

            TracksTabViewModel = new SettingsMemoryTracksTabViewModel(model);
            RhythmViewModel = new SettingsMemoryRhythmViewModel(model.Rhythm);

            NameViewModel = new SettingsMemoryNameViewModel(model.Name);
            NameViewModelInitialized?.Invoke(NameViewModel);

            MasterViewModel = new SettingsMemoryMasterViewModel(model.Master);
            RecOptionViewModel = new SettingsMemoryRecOptionViewModel(model.RecOption);
            PlayOptionViewModel = new SettingsMemoryPlayOptionViewModel(model.PlayOption);

            AssignViewModels = new SettingsMemoryAssignViewModel[16]
            {
                new SettingsMemoryAssignViewModel(model.Assign1), new SettingsMemoryAssignViewModel(model.Assign2), new SettingsMemoryAssignViewModel(model.Assign3),
                new SettingsMemoryAssignViewModel(model.Assign4), new SettingsMemoryAssignViewModel(model.Assign5), new SettingsMemoryAssignViewModel(model.Assign6),
                new SettingsMemoryAssignViewModel(model.Assign7), new SettingsMemoryAssignViewModel(model.Assign8), new SettingsMemoryAssignViewModel(model.Assign9),
                new SettingsMemoryAssignViewModel(model.Assign10), new SettingsMemoryAssignViewModel(model.Assign11), new SettingsMemoryAssignViewModel(model.Assign12),
                new SettingsMemoryAssignViewModel(model.Assign13), new SettingsMemoryAssignViewModel(model.Assign14), new SettingsMemoryAssignViewModel(model.Assign15),
                new SettingsMemoryAssignViewModel(model.Assign16)
            };

            InputFxViewModel = new SettingsMemoryInputFxViewModel(model.InputFx);
            TrackFxViewModel = new SettingsMemoryTrackFxViewModel(model.TrackFx);

            FxInputViewModels = new SettingsMemoryFxInputViewModel[3]
            {
                new SettingsMemoryFxInputViewModel(model.InputFxA), new SettingsMemoryFxInputViewModel(model.InputFxB), new SettingsMemoryFxInputViewModel(model.InputFxC)
            };

            FxTrackViewModels = new SettingsMemoryFxTrackViewModel[3]
            {
                new SettingsMemoryFxTrackViewModel(model.TrackFxA, model.BeatFxA), new SettingsMemoryFxTrackViewModel(model.TrackFxB, model.BeatFxB), new SettingsMemoryFxTrackViewModel(model.TrackFxC, model.BeatFxC)
            };
        }
    }
}
