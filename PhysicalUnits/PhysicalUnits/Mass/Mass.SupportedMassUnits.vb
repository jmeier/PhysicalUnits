Option Strict On
Option Infer On

Partial Structure Mass

    Private Shared ReadOnly KnownUnits As ObjectModel.ReadOnlyDictionary(Of SupportedMassUnits, String()) = UnitExtensions.GetKnownUnitDictionary(Of SupportedMassUnits)()

    Public Enum SupportedMassUnits

        ''' <summary> Mass in kg </summary>
        <UnitSymbol("kg")>
        Kilograms = 0

        ''' <summary> Mass in g </summary>
        <UnitSymbol("g")>
        Grams

        ''' <summary> Mass in t </summary>
        <UnitSymbol("t")>
        Tons

    End Enum

    Private Shared Function ConversionFactor([to] As SupportedMassUnits) As Double
        Select Case [to]
            Case SupportedMassUnits.Kilograms
                Return 1

            Case SupportedMassUnits.Grams
                Return 1000

            Case SupportedMassUnits.Tons
                Return 1 / 1000

            Case Else
                Throw New ArgumentException

        End Select
    End Function

End Structure