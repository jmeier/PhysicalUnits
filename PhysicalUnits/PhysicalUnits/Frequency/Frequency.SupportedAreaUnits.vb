Option Strict On
Option Infer On

Partial Structure Frequency

    Private Shared ReadOnly KnownUnits As ObjectModel.ReadOnlyDictionary(Of SupportedFrequencyUnits, String()) = UnitExtensions.GetKnownUnitDictionary(Of SupportedFrequencyUnits)()

    Public Enum SupportedFrequencyUnits

        ''' <summary> Frequency in Hz </summary>
        <UnitSymbol("Hz")>
        Hertz

        ''' <summary> Frequency in kHz </summary>
        <UnitSymbol("kHz")>
        Kilohertz

    End Enum

    Private Shared Function ConversionFactor([to] As SupportedFrequencyUnits) As Double
        Select Case [to]
            Case SupportedFrequencyUnits.Hertz
                Return 1

            Case SupportedFrequencyUnits.Kilohertz
                Return 1 / 1000

            Case Else
                Throw New ArgumentException

        End Select
    End Function

End Structure