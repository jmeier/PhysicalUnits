Option Strict On
Option Infer On

Partial Structure Intensity

    Private Shared ReadOnly KnownUnits As ObjectModel.ReadOnlyDictionary(Of SupportedIntensityUnits, String()) = UnitExtensions.GetKnownUnitDictionary(Of SupportedIntensityUnits)()

    Public Enum SupportedIntensityUnits

        ''' <summary> Intensity in W/m² </summary>
        <UnitSymbol("W/m²")>
        WattsPerSquaremeter = 0

        ''' <summary> Intensity in kW/m² </summary>
        <UnitSymbol("kW/m²")>
        KilowattsPerSquaremeter

    End Enum

    Private Shared Function ConversionFactor([to] As SupportedIntensityUnits) As Double
        Select Case [to]
            Case SupportedIntensityUnits.WattsPerSquaremeter
                Return 1

            Case SupportedIntensityUnits.KilowattsPerSquaremeter
                Return 1 / 1000

            Case Else
                Throw New ArgumentException

        End Select
    End Function

End Structure