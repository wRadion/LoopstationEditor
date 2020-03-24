using System;
using System.Windows.Input;

using LoopstationEditor.Commands;
using LoopstationEditor.Models.Settings;

namespace LoopstationEditor.ViewModels.Settings
{
    public abstract class WindowViewModel<TWindow> : SettingsContainerViewModel where TWindow : XenionDark.Windows.Window
    {
        protected TWindow _view;
        protected bool _isClosed;

        public ICommand ApplyChangesCommand { get; }
        public ICommand CancelChangesCommand { get; }

        public WindowViewModel(SettingsContainerModel model)
            : base(model)
        {
            _view = null;
            _isClosed = true;

            ApplyChangesCommand = new Command(() => ApplyChanges());
            CancelChangesCommand = new Command(() => { });

            InitViewModels();
        }

        public TEnum GetCurrentTab<TEnum>() where TEnum : Enum => (TEnum)Enum.ToObject(typeof(TEnum), SelectedIndex);
        public void SelectTab<TEnum>(TEnum tab) where TEnum : Enum => SelectedIndex = Convert.ToInt32(tab);

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
