# LoopstationXml

This project contains the helpers required to write/serialize and read/deserialize the Loopstation
RC-505 XML files (*SYSTEM.RC0* and *MEMORY.RC0*).

Usage:

```csharp
using Loopstation.Xml;
using Loopstation.Xml.Helpers;

namespace ConsoleApp
{
	class Program
	{
		public static void main(string[] args)
		{
			// SYSTEM.RC0
			// Initializes a SYSTEM.RC0 xml object with the default values
			XmlSystemFile systemFile = new XmlSystemFile();

			// Read/deserialize
			systemFile = Xml.Deserialize(systemFile, "./path/to/SYSTEM.RC0");

			// Write/serialize
			Xml.Serialize(systemFile, "./path/to/new/SYSTEM.RC0");


			// MEMORY.RC0
			// Initializes a MEMORY.RC0 xml object with the default values
			XmlMemoryFile memoryFile = new XmlMemoryFile();

			// Read/deserialize
			memoryFile = Xml.Deserialize(memoryFile, "./path/to/MEMORY.RC0");

			// Write/serialize
			Xml.Serialize(memoryFile, "./path/to/new/MEMORY.RC0");
		}
	}
}
```

**All values** are **integers**. If you want better model representation with actual enums,
see [LoopstationModel](https://github.com/wRadion/loopstation_editor/tree/master/LoopstationModel).

Then you can access any properties from the `XmlSystemFile` and `XmlMemoryFile` objects
as you would expect:

```csharp
// Get/set the Master Level property of the memory entry 42
// This is base 0 but the Loopstation is base 1:
// This entry is displayed as the entry #43 on the Loopstation
memoryFile.Memories[42].Master.Level;

// Get/set the LCD Contrast of the Loopstation system
systemFile.Setup.LcdContrast;
```