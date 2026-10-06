Option Strict On
Option Infer On

Partial Structure Elevation

    Private Shared ReadOnly KnownUnits As ObjectModel.ReadOnlyDictionary(Of SupportedElevationUnits, String()) = UnitExtensions.GetKnownUnitDictionary(Of SupportedElevationUnits)()

    Public Enum SupportedElevationUnits

        ''' <summary> Elevation in m above NN </summary>
        <UnitSymbol("m")>
        <UnitName("meter")>
        MetersAboveNN = 0

        <UnitSymbol("ft")>
        <UnitName("foot")>
        FeetAboveNN

    End Enum

    Private Shared Function ConversionFactor([to] As SupportedElevationUnits) As Double
        Select Case [to]
            Case SupportedElevationUnits.MetersAboveNN
                Return 1

            'Case SupportedElevationUnits.DecimetersAboveNN
            '    Return 10

            'Case SupportedElevationUnits.CentimetersAboveNN
            '    Return 100

            'Case SupportedElevationUnits.MillimetersAboveNN
            '    Return 1000

            'Case SupportedElevationUnits.KilometersAboveNN
            '    Return 1 / 1000

            'Case SupportedElevationUnits.InchsAboveNN
            '    Return 1 / 0.0254

            Case SupportedElevationUnits.FeetAboveNN
                Return 1 / 0.3048

                'Case SupportedElevationUnits.YardsAboveNN
                '    Return 1 / 0.9144

            Case Else
                Throw New ArgumentException

        End Select
    End Function

End Structure