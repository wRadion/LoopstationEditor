using System.Windows.Input;

using LoopstationEditor.Commands;
using LoopstationEditor.Models.Settings.System;
using LoopstationEditor.Views.Settings.System_;

namespace LoopstationEditor.ViewModels.Settings.System
{
    public enum SystemTab
    {
        SETUP = 0,
        INPUT_OUTPUT = 1,
        USB = 2,
        MIDI = 3
    }

    public class SystemViewModel : ViewModel
    {
        private SystemModel _model;
        private SystemWindow _view;
        private bool _isClosed;

        public SettingsSystemSetupViewModel SetupViewModel { get; private set; }
        public SettingsSystemInputOutputViewModel InputOutputViewModel { get; private set; }
        public SettingsSystemUSBViewModel USBViewModel { get; private set; }
        public SettingsSystemMIDIViewModel MIDIViewModel { get; private set; }

        public int SelectedTabIndex { get; set; }

        public ICommand ApplyChangesCommand { get; }
        public ICommand CancelChangesCommand { get; }

        public SystemViewModel(SystemModel model)
        {
            _model = model;
            _view = null;
            _isClosed = true;

            InitViewModels();
            SelectTab(SystemTab.SETUP);

            ApplyChangesCommand = new RelayCommand(() =>
            {
                SetupViewModel.ApplyChanges();
                InputOutputViewModel.ApplyChanges();
                USBViewModel.ApplyChanges();
                MIDIViewModel.ApplyChanges();
            });
            CancelChangesCommand = new RelayCommand(() => { });
        }

        public void InitViewModels()
        {
            SetupViewModel = new SettingsSystemSetupViewModel(_model.Setup);
            InputOutputViewModel = new SettingsSystemInputOutputViewModel(_model.InputOutput);
            USBViewModel = new SettingsSystemUSBViewModel(_model.USB);
            MIDIViewModel = new SettingsSystemMIDIViewModel(_model.MIDI);
        }

        public void SelectTab(SystemTab tab) => SelectedTabIndex = (int)tab;

        public void Show(SystemTab tab)
        {
            if (_view == null || _isClosed)
            {
                _isClosed = false;
                _view = new SystemWindow(this);
                InitViewModels();
                _view.Closed += (sender, e) => _isClosed = true;
                _view.Show();
            }
            else
                _view.Focus();

            SelectTab(tab);
        }
    }
}
