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

        public bool IsMemoryNotNull => _memoryViewModel != null;

        public Command OpenSystemWindowSetupTab { get; }
        public Command OpenSystemWindowInputOutputTab { get; }
        public Command OpenSystemWindowUSBTab { get; }
        public Command OpenSystemWindowMIDITab { get; }

        public Command<int> OpenMemoryWindowTracksTab { get; }
        public Command OpenMemoryWindowRhythmTab { get; }
        public Command OpenMemoryWindowNameTab { get; }
        public Command OpenMemoryWindowMasterTab { get; }
        public Command OpenMemoryWindowRecOptionTab { get; }
        public Command OpenMemoryWindowPlayOptionTab { get; }
        public Command<int> OpenMemoryWindowAssignsTab { get; }
        public Command<int> OpenMemoryWindowInputFxTab { get; }
        public Command<int> OpenMemoryWindowTrackFxTab { get; }

        public LoopstationViewModel()
        {
            ScreenText = new ScreenText();

            // System
            OpenSystemWindowSetupTab = new Command(() => _systemViewModel.Show(SystemTab.SETUP), () => _systemViewModel != null);
            OpenSystemWindowInputOutputTab = new Command(() => _systemViewModel.Show(SystemTab.INPUT_OUTPUT), () => _systemViewModel != null);
            OpenSystemWindowUSBTab = new Command(() => _systemViewModel.Show(SystemTab.USB), () => _systemViewModel != null);
            OpenSystemWindowMIDITab = new Command(() => _systemViewModel.Show(SystemTab.MIDI), () => _systemViewModel != null);

            // Memory
            OpenMemoryWindowTracksTab = new Command<int>((track) => _memoryViewModel.ShowSubtab(MemoryTab.TRACKS, track - 1));
            OpenMemoryWindowRhythmTab = new Command(() => _memoryViewModel.Show(MemoryTab.RHYTHM), () => _memoryViewModel != null);
            OpenMemoryWindowNameTab = new Command(() => _memoryViewModel.Show(MemoryTab.NAME), () => _memoryViewModel != null);
            OpenMemoryWindowMasterTab = new Command(() => _memoryViewModel.Show(MemoryTab.MASTER), () => _memoryViewModel != null);
            OpenMemoryWindowRecOptionTab = new Command(() => _memoryViewModel.Show(MemoryTab.REC_OPTION), () => _memoryViewModel != null);
            OpenMemoryWindowPlayOptionTab = new Command(() => _memoryViewModel.Show(MemoryTab.PLAY_OPTION), () => _memoryViewModel != null);
            OpenMemoryWindowAssignsTab = new Command<int>((assign) => _memoryViewModel.ShowSubtab(MemoryTab.ASSIGNS, assign - 1));
            OpenMemoryWindowInputFxTab = new Command<int>((tab) => _memoryViewModel.ShowSubtab(MemoryTab.INPUT_FX, tab - 1));
            OpenMemoryWindowTrackFxTab = new Command<int>((tab) => _memoryViewModel.ShowSubtab(MemoryTab.TRACK_FX, tab - 1));
        }

        public void SetSystem(SystemModel model)
        {
            _systemViewModel = new SystemWindowViewModel(model);

            OpenSystemWindowSetupTab.RaiseCanExecuteChanged();
            OpenSystemWindowInputOutputTab.RaiseCanExecuteChanged();
            OpenSystemWindowUSBTab.RaiseCanExecuteChanged();
            OpenSystemWindowMIDITab.RaiseCanExecuteChanged();
        }

        public void SetMemory(MemoryModel model)
        {
            if (_memoryViewModel != null)
                _memoryViewModel.CloseWindow();

            _memoryViewModel = new MemoryWindowViewModel(model);
            model.Name.NameChanged += (sender, e) => UpdateScreen();
            UpdateScreen();

            OpenMemoryWindowRhythmTab.RaiseCanExecuteChanged();
            OpenMemoryWindowNameTab.RaiseCanExecuteChanged();
            OpenMemoryWindowMasterTab.RaiseCanExecuteChanged();
            OpenMemoryWindowRecOptionTab.RaiseCanExecuteChanged();
            OpenMemoryWindowPlayOptionTab.RaiseCanExecuteChanged();
            OnPropertyChanged(nameof(IsMemoryNotNull));
        }

        private void UpdateScreen()
        {
            ScreenText.TextLine1 = $"{ _memoryViewModel.Id:D2}  { _memoryViewModel.NameViewModel.Name }";
        }
    }
}
