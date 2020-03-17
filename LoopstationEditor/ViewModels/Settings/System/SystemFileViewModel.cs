using System.Windows.Input;

using LoopstationEditor.Commands;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.Models.Settings.System;
using LoopstationEditor.ViewModels.Settings.Memory;

namespace LoopstationEditor.ViewModels.Settings.System
{
    public class SystemFileViewModel : FileViewModel
    {
        private SystemViewModel _systemViewModel;
        private MemoryViewModel _defaultMemoryViewModel;

        public ICommand OpenSystemWindowSetupTab { get; }
        public ICommand OpenSystemWindowInputOutputTab { get; }
        public ICommand OpenSystemWindowUSBTab { get; }
        public ICommand OpenSystemWindowMIDITab { get; }

        public SystemFileViewModel()
        {
            _systemViewModel = new SystemViewModel(new SystemModel());
            _defaultMemoryViewModel = new MemoryViewModel(new MemoryModel());

            OpenSystemWindowSetupTab = new RelayCommand(() => _systemViewModel.Show(SystemTab.SETUP));
            OpenSystemWindowInputOutputTab = new RelayCommand(() => _systemViewModel.Show(SystemTab.INPUT_OUTPUT));
            OpenSystemWindowUSBTab = new RelayCommand(() => _systemViewModel.Show(SystemTab.USB));
            OpenSystemWindowMIDITab = new RelayCommand(() => _systemViewModel.Show(SystemTab.MIDI));
        }
    }
}
