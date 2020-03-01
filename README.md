# RC-505 Loopstation Editor

This project is currently under construction.

The solution is separated into three distincts project:
- [**LoopstationXml**](https://github.com/wRadion/loopstation_editor/tree/master/LoopstationXml): The goal of this project is to provide an easy and clean
way to Write/Serialize and Read/Deserialize the Loopstation RC-505 XML files (SYSTEM.RC0 and MEMORY.RC0).
- [**LoopstationModel**](https://github.com/wRadion/loopstation_editor/tree/master/LoopstationModel): This project contains the intermediate representation between
the XML settings objects from *LoopstationXml* and the actual editor models in *LoopstationEditor*.
- [**LoopstationEditor**](https://github.com/wRadion/loopstation_editor/tree/master/LoopstationModels): This third and last project is the actual desktop software in WPF (MVVM).
