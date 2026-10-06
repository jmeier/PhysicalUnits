Option Strict On
Option Infer On

Partial Structure Acceleration

    Private Shared ReadOnly KnownUnits As ObjectModel.ReadOnlyDictionary(Of SupportedAccelerationUnits, String()) = UnitExtensions.GetKnownUnitDictionary(Of SupportedAccelerationUnits)()

    Public Enum SupportedAccelerationUnits

        ''' <summary> Acceleration in m/s² </summary>
        <UnitSymbol("m/s²")>
        MetersPerSquareSecond = 0

        ''' <summary> Acceleration in mm/s² </summary>
        <UnitSymbol("mm/s²")>
        MillimetersPerSquareSecond

    End Enum

    Private Shared Function ConversionFactor([to] As SupportedAccelerationUnits) As Double
        Select Case [to]
            Case SupportedAccelerationUnits.MetersPerSquareSecond
                Return 1

            Case SupportedAccelerationUnits.MillimetersPerSquareSecond
                Return 1000

            Case Else
                Throw New ArgumentException

        End Select
    End Function

End Structure