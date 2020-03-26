using LoopstationEditor.Models.PropertyEngine;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.Views.Settings.Memory;

namespace LoopstationEditor.Utils
{
    public class Global
    {
        #region Singleton
        public static Global _instance;
        public static Global Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Global();
                return _instance;
            }
        }
        #endregion Singleton

        public MemoryFileModel MemoryFileModel { get; set; }
        public PropertySet Clipboard { get; set; }
        public MemoryApplyToWindowState MemoryApplyToWindowState { get; set; }

        public Global() { }
    }
}
