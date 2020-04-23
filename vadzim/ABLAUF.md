# ABLAUF VOM KURS, VADZIM

[csharp-cheatsheet](CSHARP-CHEATSHEET.md)

[git-commands](GIT-COMMANDS.md)

[vs-shortcuts](VS-SHORTCUTS.md)

[csharp-snippets](CSHARP-SNIPPETS.md)

## M0 | WARMING UP

- [x] Greeter
- [x] VS [homepage](https://visualstudio.microsoft.com/de/)
- [x] Git

VS Installer > installierte Version ändern > Sprachpakete

Tools > Options > Text Editor > All Languages > General > Line numbers

## M1 | GETTING STARTED

- [x] Intro [csharp docs](https://docs.microsoft.com/de-de/dotnet/csharp/)
- [x] .NET [dotnet docs](https://docs.microsoft.com/de-de/dotnet/api/?view=netframework-4.8)
- [x] [M1HelloWorld](../vadzim/CS-GK-VC-V/M1HelloWorld/HelloWorld.cs)
- [x] [DConsole](../vadzim/CS-GK-VC-V/M1Demo-Console/DConsole.cs)

sln props > startup projects > current

## M2 | DATA TYPES, OPERATORS

- [x] Datentypen
- [x] [bool](../vadzim/CS-GK-VC-V/M2DataTypesLib/MyBool.cs)
- [x] [string](../vadzim/CS-GK-VC-V/M2DataTypesLib/MyString.cs)
- [x] [int](../vadzim/CS-GK-VC-V/M2DataTypesLib/MyInt.cs)
- [x] [double](../vadzim/CS-GK-VC-V/M2DataTypesLib/MyDouble.cs)
- [x] Operatoren
- [x] Casting
- [x] [enum](../vadzim/CS-GK-VC-V/M2DataTypesLib/MyEnum.cs)
- [x] [Ü MiniRechner](../vadzim/CS-GK-VC-V/M2MiniRechner/M2MiniRechner.cs)

## M3 | ARRAYS & CONTROLS

- [x] [Arrays](../vadzim/CS-GK-VC-V/M3ArrayNControls/MyArray.cs)
- [x] [if](../vadzim/CS-GK-VC-V/M3ArrayNControls/MyIf.cs)
- [x] for, siehe Arrays
- [x] while & do while, siehe Zahlenratespiel
- [x] [switch](../vadzim/CS-GK-VC-V/M3ArrayNControls/MySwitch.cs)
- [x] [Klasse Random](../vadzim/CS-GK-VC-V/M3ArrayNControls/MyRandom.cs)
- [x] [M3Zahlenratespiel](../vadzim/CS-GK-VC-V/M3Zahlenratespiel/M3Zahlenraten.cs)

## M4 | METHODS

- [x] arguments
- [x] parameters
- [x] params
- [x] return
- [x] overloads
- [x] out & ref parameters & args
- [x] [Demo Methods](../vadzim/CS-GK-VC-V/M4Methods/M4Methods.cs)

## M5 | CLASSES & OOP

- [x] constructor
- [x] fields
- [x] props
- [x] class methods
- [x] access modifier
- [x] inctances / objects
- [x] destructor
- [x] [public Class](../vadzim/CS-GK-VC-V/M5Classes/Detail.cs) <!-- der bessere Name: MyClassWFields -->
- [x] [private Class](../vadzim/CS-GK-VC-V/M5Classes/Umrechnung.cs)
- [x] [Classes Consumer](../vadzim/CS-GK-VC-V/M5ClassesConsumer/M5ClassesConsumer.cs)
- [x] [Ü Transport](../vadzim/CS-GK-VC-V/M5Fuhrpark/Transport.cs)
- [x] [Ü TransportConsumer](../vadzim/CS-GK-VC-V/M5Fuhrpark/FuhrparkApp.cs)

## M6 | INHERITENCE / VERERBUNG

- [ ] base
- [ ] virtual & override methods
- [ ] abstract methods
- [ ] [DLibrary - MyRandom](../vadzim/CS-GK-VC-V/M3Zahlenratespiel/MyRandomT.cs) <!-- *todo -->
- [ ] [Ü Flugzeug](../vadzim/CS-GK-VC-V/M5Fuhrpark/Flugzeug.cs)
- [ ] [Ü PKW](../vadzim/CS-GK-VC-V/M5Fuhrpark/PKW.cs)
- [ ] [Ü Schiff](../vadzim/CS-GK-VC-V/M5Fuhrpark/Schiff.cs)

## M7 | INTERFACES & POLYMORPHISM

- [ ] interfaces
- [ ] override vs overload
- [ ] [Ü IKannAndereTransportieren](../vadzim/CS-GK-VC-V/MTransport/IKannAndereTransportieren.cs)
- [ ] [Ü IMitRädern](../vadzim/CS-GK-VC-V/MTransport/IMitRädern.cs)

DLibrary, DLibraryConsumer

## M8 | GENERIC DATA STRUCTURES

- [ ] [List`<T>`](../vadzim/CS-GK-VC-V/Demo-List/DList.cs)
- [ ] [Stack`<T>`](../vadzim/CS-GK-VC-V/Demo-Stack/DStack.cs)
- [ ] [Queue`<T>`](../vadzim/CS-GK-VC-V/Demo-Queue/DQueue.cs)
- [ ] [KeyValuePair`<T1, T2>`](../vadzim/CS-GK-VC-V/Demo-KeyValuePair/DKeyValuePair.cs)
- [ ] [Dictionary`<T1, T2>`](../vadzim/CS-GK-VC-V/Demo-Dictionary/DDictionary.cs)
- [ ] Hachtable
- [ ] [Ü Passagierliste](../vadzim/CS-GK-VC-V/MTransport/Flugzeug.cs)

## M9 | WINDOWS FORMS

- [ ] partial classes
- [ ] widgets / components
- [ ] component props
- [ ] [TicTacToe](../vadzim/CS-GK-VC-V/Demo-WinForm/DWinForm.cs)

## M10 | DELEGATES & EVENTS

- [ ] custom delegates
- [ ] built-in delegates
- [ ] anonumous functions
- [ ] event handler

Ddelegate

Ü Kollidierende Buttons

Ü Einfacher Taschenrechner?

Klasse Timing?

Klasse Stopwatch?

## M11 | Exception-Handling​

- [ ] Exception & throw
- [ ] try catch finally
- [ ] Exception types
- [ ] [standard exception](https://docs.microsoft.com/de-de/dotnet/standard/design-guidelines/using-standard-exception-types)
- [ ] [Demo-Exception](../vadzim/CS-GK-VC-V/Demo-Exceptions/Form1.cs)

## M12 | Unit-Tests

- [ ] TestPackages & TestProject
- [ ] TestClasses, TestMethods, TestAnnotations
- [ ] Assert-Klasse
- [ ] [Demo-UnitTest1](../vadzim/CS-GK-VC-V/Demo-UnitTests/UnitTest1.cs)

## M13 | File Access Dateizugriff​

- [ ] SaveFileDialog & OpenFileDialog
- [ ] StreamReader & StreamWriter
- [ ] JSON, serialize & deserialize 
- [ ] [Ü TransportListe (M10Ü)](../vadzim/CS-GK-VC-V/M13Serialisierung/Form1.cs)

Ü Anmeldeformular? / Gästeliste?