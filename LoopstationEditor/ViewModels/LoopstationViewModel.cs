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

        public ScreenText() { }
    }

    public class LoopstationViewModel : ViewModel
    {
        private SystemWindowViewModel _systemViewModel;
        private MemoryWindowViewModel[] _memoryViewModels;
        private int _currentMemory;

        public ScreenText ScreenText { get; }

        public ICommand OpenSystemWindowSetupTab { get; }
        public ICommand OpenSystemWindowInputOutputTab { get; }
        public ICommand OpenSystemWindowUSBTab { get; }
        public ICommand OpenSystemWindowMIDITab { get; }

        public ICommand OpenMemoryWindowRhythmTab { get; }

        public LoopstationViewModel()
        {
            _systemViewModel = new SystemWindowViewModel(new SystemModel());
            _memoryViewModels = new MemoryWindowViewModel[MemoryFileModel.MemoryCount];
            _currentMemory = 0;

            for (int i = 0; i < _memoryViewModels.Length; ++i)
                _memoryViewModels[i] = new MemoryWindowViewModel(new MemoryModel(i));

            ScreenText = new ScreenText();

            OpenSystemWindowSetupTab = new RelayCommand(() => _systemViewModel.Show(SystemTab.SETUP));
            OpenSystemWindowInputOutputTab = new RelayCommand(() => _systemViewModel.Show(SystemTab.INPUT_OUTPUT));
            OpenSystemWindowUSBTab = new RelayCommand(() => _systemViewModel.Show(SystemTab.USB));
            OpenSystemWindowMIDITab = new RelayCommand(() => _systemViewModel.Show(SystemTab.MIDI));

            OpenMemoryWindowRhythmTab = new RelayCommand(() => _memoryViewModels[_currentMemory].Show(MemoryTab.TRACKS));
        }
    }
}
