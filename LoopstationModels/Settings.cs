namespace LoopstationModels
{
    public class Settings
    {
        public SystemSettings System;
        public MemorySettings[] Memories;

        public Settings()
        {
            System = new SystemSettings();
            Memories = new MemorySettings[99];

            for (int i = 0; i < Memories.Length; ++i)
                Memories[i] = new MemorySettings(i);
        }
    }
}
