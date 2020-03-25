using System;
using System.Windows.Input;

using LoopstationEditor.Commands;
using LoopstationEditor.Models.Settings;

namespace LoopstationEditor.ViewModels.Settings
{
    public abstract class WindowViewModel<TWindow> : SettingsContainerViewModel where TWindow : XenionDark.Windows.Window
    {
        protected TWindow _view;
        protected bool _applyChanges;
        protected bool _isClosed;

        public ICommand ApplyChangesAndCloseCommand { get; }
        public ICommand RevertChangesAndCloseCommand { get; }

        public WindowViewModel(SettingsContainerModel model)
            : base(model)
        {
            _view = null;
            _applyChanges = false;
            _isClosed = true;

            ApplyChangesAndCloseCommand = new Command(() =>
            {
                _applyChanges = true;
                ApplyChanges();
                CloseWindow();
            });

            RevertChangesAndCloseCommand = new Command(() =>
            {
                if (!_applyChanges)
                    RevertChanges();
                else
                    _applyChanges = false;
                CloseWindow();
            });
        }

        public TEnum GetCurrentTab<TEnum>() where TEnum : Enum => (TEnum)Enum.ToObject(typeof(TEnum), SelectedIndex);
        public void SelectTab<TEnum>(TEnum tab) where TEnum : Enum => SelectedIndex = Convert.ToInt32(tab);

        public void Show<TEnum>(TEnum tab) where TEnum : Enum
        {
            OpenWindow();
            SelectTab(tab);
        }

        public void OpenWindow()
        {
            if (_view == null || _isClosed)
            {
                _isClosed = false;
                _view = (TWindow)Activator.CreateInstance(typeof(TWindow), this);
                _view.Unloaded += (sender, e) => RevertChangesAndCloseCommand.Execute(null);
                _view.Show();
            }
            else
                _view.Focus();
        }

        public void CloseWindow()
        {
            if (_view != null && !_isClosed)
            {
                _view.Close();
                _isClosed = true;
            }
        }
    }
}
