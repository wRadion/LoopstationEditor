﻿using System;
using System.Windows.Input;

using LoopstationEditor.Commands;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.Settings.Memory.Tab;
using LoopstationEditor.Views.Settings.Memory;

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
        TRACK_FX = 8
    }

    public class MemoryWindowViewModel : WindowViewModel<MemoryWindow>
    {
        public int Id { get; }

        public override SettingsViewModel CurrentViewModel
        {
            get
            {
                switch (GetCurrentTab<MemoryTab>())
                {
                    case MemoryTab.TRACKS: return TracksTabViewModel.CurrentViewModel;
                    case MemoryTab.RHYTHM: return RhythmViewModel;
                    case MemoryTab.NAME: return NameViewModel;
                    case MemoryTab.MASTER: return MasterViewModel;
                    case MemoryTab.REC_OPTION: return RecOptionViewModel;
                    case MemoryTab.PLAY_OPTION: return PlayOptionViewModel;
                    case MemoryTab.ASSIGNS: return AssignsTabViewModel.CurrentViewModel;
                    case MemoryTab.INPUT_FX: return InputFxTabViewModel.CurrentViewModel;
                    case MemoryTab.TRACK_FX: return TrackFxTabViewModel.CurrentViewModel;
                }

                throw new InvalidOperationException("Current memory tab is not valid.");
            }
        }

        public SettingsMemoryTracksTabViewModel TracksTabViewModel { get; private set; }
        public SettingsMemoryRhythmViewModel RhythmViewModel { get; private set; }
        public SettingsMemoryNameViewModel NameViewModel { get; private set; }
        public SettingsMemoryMasterViewModel MasterViewModel { get; private set; }
        public SettingsMemoryRecOptionViewModel RecOptionViewModel { get; private set; }
        public SettingsMemoryPlayOptionViewModel PlayOptionViewModel { get; private set; }
        public SettingsMemoryAssignsTabViewModel AssignsTabViewModel { get; private set; }
        public SettingsMemoryInputFxTabViewModel InputFxTabViewModel { get; private set; }
        public SettingsMemoryTrackFxTabViewModel TrackFxTabViewModel { get; private set; }

        public ICommand CopyPropertySetCommand { get; }
        public ICommand PastePropertySetCommand { get; }

        public MemoryWindowViewModel(MemoryModel model)
            : base(model)
        {
            Id = model.Id + 1;

            TracksTabViewModel = new SettingsMemoryTracksTabViewModel(model);
            RhythmViewModel = new SettingsMemoryRhythmViewModel(model.Rhythm);
            NameViewModel = new SettingsMemoryNameViewModel(model.Name);
            MasterViewModel = new SettingsMemoryMasterViewModel(model.Master);
            RecOptionViewModel = new SettingsMemoryRecOptionViewModel(model.RecOption);
            PlayOptionViewModel = new SettingsMemoryPlayOptionViewModel(model.PlayOption);
            AssignsTabViewModel = new SettingsMemoryAssignsTabViewModel(model);
            InputFxTabViewModel = new SettingsMemoryInputFxTabViewModel(model);
            TrackFxTabViewModel = new SettingsMemoryTrackFxTabViewModel(model);

            TracksTabViewModel.TabChanged += (sender, e) => UpdatePasteBtn();
            AssignsTabViewModel.TabChanged += (sender, e) => UpdatePasteBtn();

            InputFxTabViewModel.TabChanged += (sender, e) => UpdatePasteBtn();
            InputFxTabViewModel.InputFxA.TabChanged += (sender, e) => UpdatePasteBtn();
            InputFxTabViewModel.InputFxB.TabChanged += (sender, e) => UpdatePasteBtn();
            InputFxTabViewModel.InputFxC.TabChanged += (sender, e) => UpdatePasteBtn();

            TrackFxTabViewModel.TabChanged += (sender, e) => UpdatePasteBtn();
            TrackFxTabViewModel.TrackFxA.TabChanged += (sender, e) => UpdatePasteBtn();
            TrackFxTabViewModel.TrackFxB.TabChanged += (sender, e) => UpdatePasteBtn();
            TrackFxTabViewModel.TrackFxC.TabChanged += (sender, e) => UpdatePasteBtn();

            SelectTab(MemoryTab.TRACKS);

            TabChanged += (sender, e) => UpdatePasteBtn();

            CopyPropertySetCommand = new Command(() =>
            {
                CurrentViewModel.CopyToClipboard();
                UpdatePasteBtn();
            });

            PastePropertySetCommand = new Command(
                () => CurrentViewModel.PasteFromClipboard(),
                () => CurrentViewModel.CanPasteFromClipboard()
            );
        }

        private void UpdatePasteBtn() => ((Command)PastePropertySetCommand).RaiseCanExecuteChanged();

        public void ShowSubtab(MemoryTab tab, int subtab)
        {
            Show(tab);

            switch (tab)
            {
                case MemoryTab.TRACKS: TracksTabViewModel.SelectedIndex = subtab; break;
                case MemoryTab.ASSIGNS: AssignsTabViewModel.SelectedIndex = subtab; break;
                case MemoryTab.INPUT_FX: InputFxTabViewModel.SelectedIndex = subtab; break;
                case MemoryTab.TRACK_FX: TrackFxTabViewModel.SelectedIndex = subtab; break;
            }
        }

        public override void ApplyChanges()
        {
            TracksTabViewModel.ApplyChanges();
            RhythmViewModel.ApplyChanges();
            NameViewModel.ApplyChanges();
            MasterViewModel.ApplyChanges();
            RecOptionViewModel.ApplyChanges();
            PlayOptionViewModel.ApplyChanges();
            AssignsTabViewModel.ApplyChanges();
            InputFxTabViewModel.ApplyChanges();
            TrackFxTabViewModel.ApplyChanges();
        }

        public override void RevertChanges()
        {
            TracksTabViewModel.RevertChanges();
            RhythmViewModel.RevertChanges();
            NameViewModel.RevertChanges();
            MasterViewModel.RevertChanges();
            RecOptionViewModel.RevertChanges();
            PlayOptionViewModel.RevertChanges();
            AssignsTabViewModel.RevertChanges();
            InputFxTabViewModel.RevertChanges();
            TrackFxTabViewModel.RevertChanges();
        }
    }
}
