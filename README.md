# PhysicalUnits .NET Library

A .NET library that provides **compile-time support for physical units**, helping developers write safer engineering calculations by making units part of the type system.

## Why PhysicalUnits?

Engineering software frequently works with quantities such as lengths, areas, forces, pressures, and densities. In traditional implementations, these values are stored as plain numeric types (e.g. `Double`), leaving it up to the developer to ensure that units are used correctly.

This approach can lead to errors such as:

- Mixing incompatible units
- Applying incorrect conversion factors
- Returning values with the wrong dimensions
- Introducing subtle calculation mistakes that are difficult to detect

PhysicalUnits addresses these problems by representing physical quantities as strongly typed structures, allowing the compiler to verify dimensional consistency wherever possible.

## Example

```vbnet
Dim a = Meters(5.2) 'type is Length
Dim b = Meters(1.3)
Dim c = a * b       'due to type inference, type is SquareMeters 
```

## Key Features

- Designed for Civil, Structural, and Geotechnical engineering applications
- Compile-time unit checking
- Strongly typed physical quantities. Physical quantities (e.g. 'Length', 'Volume', 'Mass', etc.) are represented by structures to avoid overhead from classes.
- Support for selected SI units
- Support for selected derived units
- Automatic type inference for common operations
- Operators and Extensions are defined where applicable
- All physical implement IEquatable(Of T), IComparable(Of T)
- All physical quantities are serializeable (ISerializeable and IXmlSerializable)

> [!NOTE]
> This library does *not* provide comprehensive support for all physical
> units and/or calculation operations. Rather, it focuses on common
> scenarios encountered in the fields of civil engineering and geotechnical
> engineering.
>
> For example, lengths up to an exponent of 4 are implemented (m, m², m³,
> and m⁴) - but not higher.

## Scope

Mathematical functionality is limited to frequently encountered engineering calculations.

The goal is simplicity, readability, and compile-time safety rather than exhaustive coverage of every physical unit system.

## Installation

The library is intended to be used as a git-submodule in Visual Studio projects:

```Shell
git submodule add -b main https://github.com/jmeier/PhysicalUnits.git
```

## Design Philosophy

PhysicalUnits follows a few simple principles:

- Units should be visible in the code.
- Invalid dimensional operations should be prevented whenever possible triggering a compiler error.
- Engineering calculations should remain easy to read.
- PhysicalUnits should be used for UI, serialization, and API. It should not be used in computationally intensive calculations.

## API Overview

### Creating Quantities

Physical quantities are typically created through unit factory functions:

```vbnet
Dim l = Meters(5.0)         ' Type: Length
Dim a = SquareMeters(20.0)  ' Type: Area
Dim f = KiloNewtons(150.0)  ' Type: Force
```

### Accessing Values

Retrieve the numeric value of a quantity:

```vbnet
Dim length = Centimeters(5.0)
Dim valueInMeters = length.Meters
```

### Arithmetic Operations

#### Addition and Subtraction

Only quantities with the same dimension can be added or subtracted:

```vbnet
Dim total = Meters(5.0) + Meters(2.0)
Dim diff = Meters(5.0) - Meters(2.0)
```

#### Multiplication and Division

Derived quantities are created automatically:

```vbnet
Dim area = Meters(5.0) * Meters(2.0)             ' Type: Area
Dim volume = area * Meters(3.0)                  ' Type: Volume
Dim stress = Newtons(100.0) / SquareMeters(10.0) ' Type: Pressure
```

#### Comparison

Quantities of the same type can be compared directly:

```vbnet
If Meters(5.0) > Meters(2.0) Then
    Console.WriteLine("Longer")
End If
```

#### Dimensional Safety

The compiler prevents invalid operations:

```vbnet
Dim length = Meters(5.0)
Dim force = Newtons(10.0)

' Invalid:
' Dim x = length + force
```

#### Implemented Physical Quantities

The implemented physical quantities are listed in the table below. These
physical quantities internally convert the given values into the primary unit
(usually the SI unit; *highlighted* in the table below).

| Quantity      | Factory Function (identical to physical unit)                         |
| ------------- | --------------------------------------------------------------------- |
| Acceleration  | *`MetersPerSquareSecond`*, `MillimetersPerSquareSecond`               |
| Area          | *`SquareMeters`* `SquareCentimeters`, ...                             |
| Density       | *`KilogramsPerCubicmeter`*, `TonsPerCubicmeter`, ...                  |
| Elevation     | *`MetersAboveNN`*, `FeetAboveNN`                                      |
| Energy        | *`Joules`*                                                            |
| Force         | *`Newtons`*, `Kilonewtons`, `Meganewtons`, ...                        |
| Frequency     | *`Hertz`*, `Kilohertz`                                                |
| Intensity     | *`WattsPerSquaremeter`*, `KilowattsPerSquaremeter`                    |
| Length        | *`Meters`*, `Centimeters`, `Millimeters`, `Kilometers`, ...           |
| LengthPow4    | *`MetersPow4`*, `MillimetersPow4`, ...                                |
| Mass          | *`Kilograms`*, `Grams`, `Tons`, ...                                   |
| Power         | *`Watts`*, `Kilowatts`                                                |
| Pressure      | *`NewtonsPerSquaremeter`*, `Pascals`, `Kilopascals`, ...              |
| SoundPressure | *`Decibel`*                                                           |
| Temperature   | *`Kelvin`*, `DegreeCelcius`, `DegreeFahrenheit`, ...                  |
| Time          | *use .NET TimeSpan structure*                                         |
| Velocity      | *`MetersPerSecond`*, `MetersPerDay`, ...                              |
| Volume        | *`CubicMeters`*, `CubicCentimeters`, `CubicMillimeters`, ...          |

## Contributing

Bug reports and suggestions are welcome. Please open an issue.

## License

This project is licensed under the [GNU Affero General Public License v3.0 (AGPL-3.0)](https://www.gnu.org/licenses/agpl.html). See the [LICENSE file](LICENSE) for details.

## Disclaimer

This software is provided without warranty of any kind. Users are responsible for verifying the correctness and suitability of calculations for their specific applications.
