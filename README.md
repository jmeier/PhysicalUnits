# PhysicalUnits .NET Library

When writing code for civil engineering applications, one has to deal with many
numbers to which physical units are assigned. The 'traditional' approach is
simply to store the numerical values (without units) in variables and perform
calculations using them. The correct use of physical units must be ensured
separately. This is a process prone to errors, even if the units are written as
comments after the variables. It would be desirable for the compiler to
recognise, check and enforce the physical units at the time of compilation.
This is the purpose of this .NET source code library.

This library enables the following:

```VB.NET
Dim a = Meters(5.2) 'type is Length
Dim b = Meters(1.3)
Dim c = a * b       'due to type inference, type is SquareMeters 
```

> [!NOTE]
> This library does *not* provide comprehensive support for all physical
> units and/or calculation operations. Rather, it focuses on common
> scenarios encountered in the fields of civil engineering and geotechnical
> engineering.

Currently, selected SI units and selected derived units are supported. Furthermore, mathematical calculations are supported to a limited extent.

> [!IMPORTANT]
> This code is provided under the
> [AGPL-3.0 license](https://www.gnu.org/licenses/agpl.html).
> No warranties are given.
