# CHEATSHEET CSHARP (Vadzim)

[classes](#classes) |
[class props](#class-props) |
[constructors](#constructors) |
[class methods](#class-methods)

[variable declaration](#variable-declaration) |
[variable initialisation](#variable-initialisation)

[conditions](#conditions) | 
[conditionals](#conditionals)

[loops](#loops) | 
[iterators](#iterators)

[instantiation](#instantiation) |
[inheritance](#inheritance) |
[interfaces](#interfaces)

[generic structures](#generic-structures)

[delegates](#delegates) |
[arrow functions](#arrow-functions)

<br><br>

## CLASSES

**SEMANTIC SYNTAX**

Konvention bei Klassennamen - PascalCase<br>
Wenn kein Modifizierer, dann ist es private

```csharp
_modifier_ class _Identifier_
{
    // class members
}
```

**EXAMPLE**

```csharp
public class Person
{
    // class members
}
```

**SNIPPET**

`class` `tab` `tab`

**MEMBERS**

```csharp
public class Person
{
    // possibly data types, evtl. Datentypen (enums)
    
    // possibly fields, evtl. Felder

    // possibly properties, evtl. Eigenschaften

    // possibly constructors, evtl. Konstruktoren

    // possibly methods, evtl. Methoden

    // possibly destructor, evtl. Destruktor
}
```

<br><br>

## VARIABLE DECLARATION

Konvention - camelCase

**SEMANTIC SYNTAX**

```csharp
_type_ _identifier_;
```

**EXAMPLE**

```csharp
int allowedAmount;
```

<br><br>

## VARIABLE INITIALISATION

**SEMANTIC SYNTAX**

```csharp
_type_ _identifier_ = _value_;
```

**EXAMPLE**

```csharp
int allowedAmount = 5;
```

<br><br>

## CLASS PROPS

Konvention - PascalCase

**SEMANTIC SYNTAX**

```csharp
public _type_ _Identifier_ { get; set; }
```

**EXAMPLE**

```csharp
public string FirstName { get; set; }
```

<br><br>

## CONSTRUCTORS

Konstruktoren heißen genauso wie die Klasse selbst! <br>
Konstruktoren haben keinen Rückgabetyp. <br>
Konventionen wie bei anderen Methoden.

**SEMANTIC SYNTAX**

```csharp
public _ClassName_(_type_ _param1_, _type_ _param2_)
{
    this._PropName1_ = _param1_;
    this._PropName2_ = _param2_;
}
```

**EXAMPLE**

```csharp
public Person(string fn, string ln) 
{
    this.FirstName = fn;
    this.LastName = ln;
}
```
**SNIPPET**

`ctor` `tab`

<br><br>

## CLASS METHODS

Konventionen - PascalCase 

**SEMANTIC SYNTAX**

```csharp
_modifier_ _returntype_ _Identifier_(_parameters_)
{
    // Ausdrücke | Expressions
    // Anweisungen | Statements 
}
```

**EXAMPLE**

```csharp
static void Main(string text)
{
    // Ausdrücke | Expressions
    // Anweisungen | Statements 
}
```

<br><br>

## CONDITIONS

#### SINGLE CONDITION

**SEMANTIC SYNTAX**

```csharp
_value1_ == / != / > / >= / < / <= _value2_
```

**EXAMPLE**

```csharp
Person.Firstname == "Max"
```

<br>

#### MANY CONDITIONS

**SEMANTIC SYNTAX**

```csharp
_condition1_ && / || / ^ _condition2_
```

**EXAMPLE**

```csharp
myPerson.Firstname == "Max" && myPerson.Age < 30
```

<br><br>

## CONDITIONALS


### IF

 

**SEMANTIC SYNTAX**

 

```csharp
if (_condition_)
{
    // true-Block
}
else
{
    // false-Block
}
```

 

**EXAMPLE**

 

```csharp
if (DateTime.Now == "22.04.2020")
{
    Console.WriteLine("Tag für Sport");
}
```

**SEMANTIC SYNTAX**

```csharp
```

**EXAMPLE**

```csharp
```

<br>
 

### IF-EXPRESSION

```csharp
true ? "true" : "false";
```
<br><br>

## LOOPS

**SEMANTIC SYNTAX**

```csharp
```

**EXAMPLE**

```csharp
```

<br><br>

## ITERATORS

**SEMANTIC SYNTAX**

```csharp
```

**EXAMPLE**

```csharp
```

<br><br>

## INSTANTIATION

**SEMANTIC SYNTAX**

```csharp
```

**EXAMPLE**

```csharp
```

<br><br>

## INHERITANCE

**SEMANTIC SYNTAX**

```csharp
```

**EXAMPLE**

```csharp
```

<br><br>

## INTERFACES

Konvention bei Schnittstellen - IPascalCase

**SEMANTIC SYNTAX**

```csharp
```

**EXAMPLE**

```csharp
```

<br><br>

## GENERIC STRUCTURES

**SEMANTIC SYNTAX**

```csharp
```

**EXAMPLE**

```csharp
```

<br><br>

## DELEGATES

**SEMANTIC SYNTAX**

```csharp
```

**EXAMPLE**

```csharp
```

<br><br>

## ARROW FUNCTIONS

**SEMANTIC SYNTAX**

```csharp
```

**EXAMPLE**

```csharp
```