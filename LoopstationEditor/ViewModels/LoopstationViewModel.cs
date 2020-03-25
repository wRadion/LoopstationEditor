using System.ComponentModel;
using System.Windows.Input;

using LoopstationEditor.Commands;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.Models.Settings.System;
using LoopstationEditor.ViewModels.Settings.Memory;
using LoopstationEditor.ViewModels.Settings.System;

namespace LoopstationEditor.ViewModels
{
    public class ScreenText : ViewModel
    {
        public string TextLine1 { get; set; }
        public string TextLine2 { get; set; }

        public ScreenText() : this(string.Empty, string.Empty) { }
        public ScreenText(string line1) : this(line1, string.Empty) { }
        public ScreenText(string line1, string line2)
        {
            TextLine1 = line1;
            TextLine2 = line2;
        }
    }

    public class LoopstationViewModel : ViewModel
    {
        private SystemWindowViewModel _systemViewModel;
        private MemoryWindowViewModel _memoryViewModel;

        public ScreenText ScreenText { get; private set; }

        public ICommand OpenSystemWindowSetupTab { get; }
        public ICommand OpenSystemWindowInputOutputTab { get; }
        public ICommand OpenSystemWindowUSBTab { get; }
        public ICommand OpenSystemWindowMIDITab { get; }

        public ICommand OpenMemoryWindowTracksTab { get; }
        public ICommand OpenMemoryWindowRhythmTab { get; }
        public ICommand OpenMemoryWindowNameTab { get; }
        public ICommand OpenMemoryWindowMasterTab { get; }
        public ICommand OpenMemoryWindowRecOptionTab { get; }
        public ICommand OpenMemoryWindowPlayOptionTab { get; }
        public ICommand OpenMemoryWindowAssignsTab { get; }
        public ICommand OpenMemoryWindowInputFxTab { get; }
        public ICommand OpenMemoryWindowTrackFxTab { get; }

        public LoopstationViewModel()
        {
            ScreenText = new ScreenText();

            // System
            OpenSystemWindowSetupTab = new Command(() => _systemViewModel.Show(SystemTab.SETUP));
            OpenSystemWindowInputOutputTab = new Command(() => _systemViewModel.Show(SystemTab.INPUT_OUTPUT));
            OpenSystemWindowUSBTab = new Command(() => _systemViewModel.Show(SystemTab.USB));
            OpenSystemWindowMIDITab = new Command(() => _systemViewModel.Show(SystemTab.MIDI));

            // Memory
            OpenMemoryWindowTracksTab = new Command<int>((track) => _memoryViewModel.ShowSubtab(MemoryTab.TRACKS, track - 1));
            OpenMemoryWindowRhythmTab = new Command(() => _memoryViewModel.Show(MemoryTab.RHYTHM));
            OpenMemoryWindowNameTab = new Command(() => _memoryViewModel.Show(MemoryTab.NAME));
            OpenMemoryWindowMasterTab = new Command(() => _memoryViewModel.Show(MemoryTab.MASTER));
            OpenMemoryWindowRecOptionTab = new Command(() => _memoryViewModel.Show(MemoryTab.REC_OPTION));
            OpenMemoryWindowPlayOptionTab = new Command(() => _memoryViewModel.Show(MemoryTab.PLAY_OPTION));
            OpenMemoryWindowAssignsTab = new Command<int>((assign) => _memoryViewModel.ShowSubtab(MemoryTab.ASSIGNS, assign - 1));
            OpenMemoryWindowInputFxTab = new Command<int>((tab) => _memoryViewModel.ShowSubtab(MemoryTab.INPUT_FX, tab - 1));
            OpenMemoryWindowTrackFxTab = new Command<int>((tab) => _memoryViewModel.ShowSubtab(MemoryTab.TRACK_FX, tab - 1));
        }

        public void SetSystem(SystemModel model)
        {
            _systemViewModel = new SystemWindowViewModel(model);
        }

        public MemoryWindowViewModel SetMemory(MemoryModel model)
        {
            if (_memoryViewModel != null)
                _memoryViewModel.CloseWindow();

            _memoryViewModel = new MemoryWindowViewModel(model);
            _memoryViewModel.NameViewModel.PropertyChanged += NameChanged;
            NameChanged(_memoryViewModel.NameViewModel, new PropertyChangedEventArgs(nameof(_memoryViewModel.NameViewModel.Name)));

            return _memoryViewModel;
        }

        private void NameChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "Name") return;

            ScreenText.TextLine1 = $"{ _memoryViewModel.Id:D2}  { _memoryViewModel.NameViewModel.Name }";
        }
    }
}
