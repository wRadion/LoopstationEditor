using LoopstationModels.Base;
using System.Text;

namespace LoopstationModels.Memory
{
    public class NameSettings : BaseSettings
    {
        public const int MAX_LENGTH = 12;

        public string Value
        {
            get
            {
                return new StringBuilder((char)GetProperty("C01")).Append((char)GetProperty("C02")).
                        Append((char)GetProperty("C03")).Append((char)GetProperty("C04")).
                        Append((char)GetProperty("C05")).Append((char)GetProperty("C06")).
                        Append((char)GetProperty("C07")).Append((char)GetProperty("C08")).
                        Append((char)GetProperty("C09")).Append((char)GetProperty("C10")).
                        Append((char)GetProperty("C11")).Append((char)GetProperty("C12")).
                    ToString();
            }

            set
            {
                if (value.Length < MAX_LENGTH)
                {
                    StringBuilder newStr = new StringBuilder(value);

                    for (int i = 0; i < MAX_LENGTH - value.Length; ++i)
                        newStr.Append(' ');

                    value = newStr.ToString();
                }

                for (int i = 0; i < MAX_LENGTH; ++i)
                    SetProperty("C" + i.ToString("D2"), value[i]);
            }
        }

        public NameSettings() : base("NAME")
        {
            AddProperty("C01", def: 73, min: 32, max: 126);
            AddProperty("C02", def: 78, min: 32, max: 126);
            AddProperty("C03", def: 73, min: 32, max: 126);
            AddProperty("C04", def: 84, min: 32, max: 126);
            AddProperty("C05", def: 32, min: 32, max: 126);
            AddProperty("C06", def: 77, min: 32, max: 126);
            AddProperty("C07", def: 69, min: 32, max: 126);
            AddProperty("C08", def: 77, min: 32, max: 126);
            AddProperty("C09", def: 79, min: 32, max: 126);
            AddProperty("C10", def: 82, min: 32, max: 126);
            AddProperty("C11", def: 89, min: 32, max: 126);
            AddProperty("C12", def: 32, min: 32, max: 126);
        }
    }
}
