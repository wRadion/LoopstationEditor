using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;

using LoopstationEditor.Commands;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.Models.Settings.System;
using LoopstationEditor.ViewModels.Settings.Memory;
using System.IO;

namespace LoopstationEditor.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        private readonly Window _window;
        private SystemFileModel _systemFile;
        private MemoryFileModel _memoryFile;

        public bool IsNull => _systemFile != null && _memoryFile != null;
        public bool IsNotNull => !IsNull;
        public LoopstationViewModel LoopstationViewModel { get; }

        private int _currentMemoryIndex;
        public int CurrentMemoryIndex
        {
            get => _currentMemoryIndex;
            set
            {
                if (value < 0) return;
                _currentMemoryIndex = value;
                MemoryWindowViewModel memoryViewModel = LoopstationViewModel.SetMemory(_memoryFile.Memories[_currentMemoryIndex]);
                memoryViewModel.NameViewModel.AppliedChanges += (sender, e) => UpdateMemoryNames();
            }
        }
        public string[] MemoryNames { get; private set; }

        public ICommand NewSettingsCommand { get; }
        public ICommand OpenSettingsCommand { get; }
        public ICommand SaveSettingsCommand { get; }
        public ICommand SaveSettingsAsCommand { get; }

        public MainWindowViewModel(Window window)
        {
            _window = window;
            _systemFile = null;
            _memoryFile = null;
            _currentMemoryIndex = -1;

            LoopstationViewModel = new LoopstationViewModel();

            NewSettingsCommand = new Command(() =>
            {
                if (_systemFile != null || _memoryFile != null)
                    if (MessageBox.Show(_window, "Are you sure to replace the current settings with a new set of settings? This operation cannot be undone.", "Replacing Current Settings", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                        return;

                InitializeFileModels(new SystemFileModel(), new MemoryFileModel());
            });

            OpenSettingsCommand = new Command(() =>
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Title = "Open Loopstation Settings",
                    Filter = "All Settings file|*.RC0",
                    Multiselect = true
                };

                if ((bool)dialog.ShowDialog(_window))
                {
                    if (_systemFile != null || _memoryFile != null)
                        if (MessageBox.Show(_window, "Are you sure to replace the current settings with the selected files? This operation cannot be undone.", "Replacing Current Settings", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                            return;

                    if (dialog.FileNames.Length != 2)
                    {
                        MessageBox.Show(_window, "You need to select the SYSTEM.RC0 and MEMORY.RC0 files.", "Invalid Settings files", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }

                    string memoryFileName = string.Empty;
                    string systemFileName = string.Empty;

                    string[] fileNames = dialog.FileNames;

                    foreach (string fileName in fileNames)
                    {
                        if (Path.GetFileName(fileName) == "MEMORY.RC0")
                            memoryFileName = fileName;
                        else if (Path.GetFileName(fileName) == "SYSTEM.RC0")
                            systemFileName = fileName;
                    }

                    if (string.IsNullOrWhiteSpace(memoryFileName) || string.IsNullOrWhiteSpace(systemFileName))
                    {
                        MessageBox.Show("You need to select the SYSTEM.RC0 and MEMORY.RC0 files.", "Invalid Settings files", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }

                    InitializeFileModels(SystemFileModel.Load(systemFileName), MemoryFileModel.Load(memoryFileName));
                }
            });

            SaveSettingsCommand = new Command(() =>
            {
                if (_systemFile == null && _memoryFile == null) return;

                if (string.IsNullOrWhiteSpace(_systemFile.CurrentPath) || string.IsNullOrWhiteSpace(_memoryFile.CurrentPath))
                {
                    SaveSettingsAsCommand.Execute(null);
                    return;
                }

                if (MessageBox.Show(_window, "Are you sure to overwrite the current settings files? This operation cannot be undone.", "Overwrite Current Files", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                    return;

                _systemFile.Save();
                _memoryFile.Save();
            });

            SaveSettingsAsCommand = new Command(() =>
            {
                if (_systemFile == null && _memoryFile == null) return;

                // System
                SaveFileDialog dialog = new SaveFileDialog
                {
                    Title = "Save SYSTEM.RC0 file As...",
                    Filter = "System Settings file|SYSTEM.RC0",
                    FileName = "SYSTEM.RC0"
                };

                if ((bool)dialog.ShowDialog(_window))
                    _systemFile.Save(dialog.FileName);

                // Memory
                dialog = new SaveFileDialog
                {
                    Title = "Save MEMORY.RC0 file As...",
                    Filter = "System Settings file|MEMORY.RC0",
                    FileName = "MEMORY.RC0"
                };

                if ((bool)dialog.ShowDialog(_window))
                    _memoryFile.Save(dialog.FileName);
            });
        }

        private void InitializeFileModels(SystemFileModel system, MemoryFileModel memory)
        {
            _systemFile = system;
            _memoryFile = memory;

            LoopstationViewModel.SetSystem(_systemFile.System);
            CurrentMemoryIndex = (int)_systemFile.System.Setup.SelectedMemory;
            UpdateMemoryNames();

            OnPropertyChanged(nameof(IsNull));
            OnPropertyChanged(nameof(IsNotNull));
        }

        private void UpdateMemoryNames()
        {
            MemoryNames = _memoryFile.Memories.Select((m) => $"{ m.Id+1:D2}  { m.Name }").ToArray();
        }
    }
}
