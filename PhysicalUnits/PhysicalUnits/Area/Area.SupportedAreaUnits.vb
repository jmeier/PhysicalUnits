Option Strict On
Option Infer On

Partial Structure Area

    Private Shared ReadOnly KnownUnits As ObjectModel.ReadOnlyDictionary(Of SupportedAreaUnits, String()) = UnitExtensions.GetKnownUnitDictionary(Of SupportedAreaUnits)()

    Public Enum SupportedAreaUnits

        ''' <summary> Area in m² </summary>
        <UnitSymbol("m²")>
        SquareMeters = 0

        ''' <summary> Area in cm² </summary>
        <UnitSymbol("cm²")>
        SquareCentimeters

        ''' <summary> Area in mm² </summary>
        <UnitSymbol("mm²")>
        SquareMillimeters

        ''' <summary> Area in km² </summary>
        <UnitSymbol("km²")>
        SquareKilometers

    End Enum

    Private Shared Function ConversionFactor([to] As SupportedAreaUnits) As Double
        Select Case [to]
            Case SupportedAreaUnits.SquareMeters
                Return 1

            Case SupportedAreaUnits.SquareCentimeters
                Return 100 * 100

            Case SupportedAreaUnits.SquareMillimeters
                Return 1000 * 1000

            Case SupportedAreaUnits.SquareKilometers
                Return 1 / (1000 * 1000)

            Case Else
                Throw New ArgumentException

        End Select
    End Function

End Structure