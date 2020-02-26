namespace LoopstationModels
{
    public class Settings
    {
        public SystemSettings System;
        public MemorySettings[] Memory;

        public Settings()
        {
            System = new SystemSettings();
            Memory = new MemorySettings[99];

            for (int i = 0; i < Memory.Length; ++i)
                Memory[i] = new MemorySettings(i);
        }
    }
}
