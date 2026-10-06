Option Strict On
Option Infer On

Partial Structure Density

    Private Shared ReadOnly KnownUnits As ObjectModel.ReadOnlyDictionary(Of SupportedDensityUnits, String()) = UnitExtensions.GetKnownUnitDictionary(Of SupportedDensityUnits)()

    Public Enum SupportedDensityUnits

        ''' <summary> Material density in kg/m³ </summary>
        <UnitSymbol("kg/m³")>
        KilogramsPerCubicmeter = 0

        ''' <summary> Material density in t/m³ </summary>
        <UnitSymbol("t/m³")>
        TonsPerCubicmeter

    End Enum

    Private Shared Function ConversionFactor([to] As SupportedDensityUnits) As Double
        Select Case [to]
            Case SupportedDensityUnits.KilogramsPerCubicmeter
                Return 1.0

            Case SupportedDensityUnits.TonsPerCubicmeter
                Return 1 / 1000

                'Case SupportedDensityUnits.KilonewtonsPerCubicmeter
                '    Return 9.81 / 1000

            Case Else
                Throw New ArgumentException

        End Select
    End Function

End Structure