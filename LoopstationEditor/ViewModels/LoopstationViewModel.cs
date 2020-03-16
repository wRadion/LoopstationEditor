using System.Windows.Input;

using LoopstationEditor.Commands;
using LoopstationEditor.Models.Settings.System;
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
        private SystemModel _systemModel;
        private SystemViewModel _systemViewModel;

        public ScreenText ScreenText { get; }

        public ICommand OpenSystemWindowSetupTab { get; }
        public ICommand OpenSystemWindowInputOutputTab { get; }
        public ICommand OpenSystemWindowUSBTab { get; }
        public ICommand OpenSystemWindowMIDITab { get; }

        public LoopstationViewModel()
        {
            _systemModel = new SystemModel();
            _systemViewModel = new SystemViewModel(_systemModel);

            ScreenText = new ScreenText();

            OpenSystemWindowSetupTab = new RelayCommand(() => _systemViewModel.Show(SystemTab.SETUP));
            OpenSystemWindowInputOutputTab = new RelayCommand(() => _systemViewModel.Show(SystemTab.INPUT_OUTPUT));
            OpenSystemWindowUSBTab = new RelayCommand(() => _systemViewModel.Show(SystemTab.USB));
            OpenSystemWindowMIDITab = new RelayCommand(() => _systemViewModel.Show(SystemTab.MIDI));
        }
    }
}
