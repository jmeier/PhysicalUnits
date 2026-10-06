Option Strict On
Option Infer On

Partial Structure Length

    Private Shared ReadOnly KnownUnits As ObjectModel.ReadOnlyDictionary(Of SupportedLengthUnits, String()) = UnitExtensions.GetKnownUnitDictionary(Of SupportedLengthUnits)()

    Public Enum SupportedLengthUnits

        ''' <summary> Length in m </summary>
        <UnitSymbol("m")>
        <UnitName("meter")>
        Meters = 0

        ''' <summary> Length in cm </summary>
        <UnitSymbol("cm")>
        <UnitName("centimeter")>
        Centimeters

        <UnitSymbol("dm")>
        <UnitName("decimeter")>
        Decimeters

        ''' <summary> Length in mm </summary>
        <UnitSymbol("mm")>
        <UnitName("millimeter")>
        Millimeters

        <UnitSymbol("km")>
        <UnitName("kilometer")>
        Kilometers

        <UnitSymbol("in")>
        <UnitName("inch")>
        Inchs

        <UnitSymbol("ft")>
        <UnitName("foot")>
        Feet

        <UnitSymbol("yd")>
        <UnitName("yard")>
        Yards

    End Enum

    Private Shared Function ConversionFactor([to] As SupportedLengthUnits) As Double
        Select Case [to]
            Case SupportedLengthUnits.Meters
                Return 1

            Case SupportedLengthUnits.Decimeters
                Return 10

            Case SupportedLengthUnits.Centimeters
                Return 100

            Case SupportedLengthUnits.Millimeters
                Return 1000

            Case SupportedLengthUnits.Kilometers
                Return 1 / 1000

            Case SupportedLengthUnits.Inchs
                Return 1 / 0.0254

            Case SupportedLengthUnits.Feet
                Return 1 / 0.3048

            Case SupportedLengthUnits.Yards
                Return 1 / 0.9144

            Case Else
                Throw New ArgumentException

        End Select
    End Function

End Structure