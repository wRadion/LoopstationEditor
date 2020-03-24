using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings
{
    public class Clipboard
    {
        #region Singleton
        public static Clipboard _instance;
        public static Clipboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Clipboard();
                return _instance;
            }
        }
        #endregion Singleton

        public PropertySet PropertySet;

        public Clipboard() { }
    }
}
