namespace LoopstationEditor.Models.Properties
{
    public class PropertyInt : Property<int>
    {
        public PropertyInt(int def, int min, int max) : base(def, min, max) { }

        protected override void UpdateValue() => _value = _intValue;
    }
}
