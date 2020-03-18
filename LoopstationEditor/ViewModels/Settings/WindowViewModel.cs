using System;
using System.Windows.Input;

using LoopstationEditor.Commands;
using LoopstationEditor.Models.Settings;
using LoopstationEditor.Views.Settings;

namespace LoopstationEditor.ViewModels.Settings
{
    public abstract class WindowViewModel<TWindow> : SettingsContainerViewModel where TWindow : XenionDark.Windows.Window
    {
        protected TWindow _view;
        protected bool _isClosed;

        public int SelectedTabIndex { get; set; }

        public ICommand ApplyChangesCommand { get; protected set; }
        public ICommand CancelChangesCommand { get; }

        public WindowViewModel(SettingsContainerModel model)
            : base(model)
        {
            _view = null;
            _isClosed = true;

            CancelChangesCommand = new RelayCommand(() => { });

            InitViewModels();
        }

        public void SelectTab<TEnum>(TEnum tab) where TEnum : Enum => SelectedTabIndex = Convert.ToInt32(tab);

        public void Show<TEnum>(TEnum tab) where TEnum : Enum
        {
            if (_view == null || _isClosed)
            {
                _isClosed = false;
                _view = (TWindow)Activator.CreateInstance(typeof(TWindow), this);
                InitViewModels();
                _view.Closed += (sender, e) => _isClosed = true;
                _view.Show();
            }
            else
                _view.Focus();

            SelectTab(tab);
        }

        protected abstract void InitViewModels();
    }
}
