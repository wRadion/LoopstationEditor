using System;

namespace LoopstationEditor.Models.Properties
{
    public class PropertyBool : Property<bool>
    {
        public PropertyBool(bool def, int min, int max) : base(def, min, max) { }

        protected override void UpdateValue() => _value = Convert.ToBoolean(_intValue);
    }
}
