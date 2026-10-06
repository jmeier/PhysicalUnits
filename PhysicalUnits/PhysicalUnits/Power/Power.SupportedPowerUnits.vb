Option Strict On
Option Infer On

Partial Structure Power

    Private Shared ReadOnly KnownUnits As ObjectModel.ReadOnlyDictionary(Of SupportedPowerUnits, String()) = UnitExtensions.GetKnownUnitDictionary(Of SupportedPowerUnits)()

    Public Enum SupportedPowerUnits

        ''' <summary> Power in W </summary>
        ''' <remarks> 1 W = 1 J/s </remarks>
        <UnitSymbol("W")>
        Watts = 0

        ''' <summary> Power in kW </summary>
        <UnitSymbol("kW")>
        Kilowatts

    End Enum

    Private Shared Function ConversionFactor([to] As SupportedPowerUnits) As Double
        Select Case [to]
            Case SupportedPowerUnits.Watts
                Return 1

            Case SupportedPowerUnits.Kilowatts
                Return 1 / 1000

            Case Else
                Throw New ArgumentException

        End Select
    End Function

End Structure