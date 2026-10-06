Option Strict On
Option Infer On

Partial Structure SoundPressure

    Private Shared ReadOnly KnownUnits As ObjectModel.ReadOnlyDictionary(Of SupportedSoundPressureUnits, String()) = UnitExtensions.GetKnownUnitDictionary(Of SupportedSoundPressureUnits)()

    Public Enum SupportedSoundPressureUnits

        ''' <summary> SoundPressure in dB </summary>
        <UnitSymbol("dB")>
        Decibel = 0

    End Enum

    Private Shared Function ConversionFactor([to] As SupportedSoundPressureUnits) As Double
        Select Case [to]
            Case SupportedSoundPressureUnits.Decibel
                Return 1

            Case Else
                Throw New ArgumentException

        End Select
    End Function

End Structure