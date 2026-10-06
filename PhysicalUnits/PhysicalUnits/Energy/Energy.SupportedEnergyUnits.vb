Option Strict On
Option Infer On

Partial Structure Energy

    Private Shared ReadOnly KnownUnits As ObjectModel.ReadOnlyDictionary(Of SupportedEnergyUnits, String()) = UnitExtensions.GetKnownUnitDictionary(Of SupportedEnergyUnits)()

    Public Enum SupportedEnergyUnits

        ''' <summary> Energy in J </summary>
        ''' <remarks> 1 J = 1 kg⋅m²/s² = 1 N⋅m </remarks>
        <UnitSymbol("J")>
        Joules

    End Enum

    Private Shared Function ConversionFactor([to] As SupportedEnergyUnits) As Double
        Select Case [to]
            Case SupportedEnergyUnits.Joules
                Return 1

            Case Else
                Throw New ArgumentException

        End Select
    End Function


End Structure