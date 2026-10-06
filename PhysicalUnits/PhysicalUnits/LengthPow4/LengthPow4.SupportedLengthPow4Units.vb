Option Strict On
Option Infer On

Partial Structure LengthPow4

    Private Shared ReadOnly KnownUnits As ObjectModel.ReadOnlyDictionary(Of SupportedLengthPow4Units, String()) = UnitExtensions.GetKnownUnitDictionary(Of SupportedLengthPow4Units)()

    Public Enum SupportedLengthPow4Units

        ''' <summary> Length to the fourth power in m⁴ </summary>
        <UnitSymbol("m⁴")>
        <UnitName("meter to the fourth power")>
        MetersPow4 = 0

        ''' <summary> Length in cm </summary>
        <UnitSymbol("cm⁴")>
        <UnitName("centimeter to the fourth power")>
        CentimetersPow4

        <UnitSymbol("dm⁴")>
        <UnitName("decimeter to the fourth power")>
        DecimetersPow4

        ''' <summary> Length in mm </summary>
        <UnitSymbol("mm⁴")>
        <UnitName("millimeter to the fourth power")>
        MillimetersPow4

        <UnitSymbol("km⁴")>
        <UnitName("kilometer to the fourth power")>
        KilometersPow4

        <UnitSymbol("in⁴")>
        <UnitName("inch to the fourth power")>
        InchsPow4

        <UnitSymbol("ft⁴")>
        <UnitName("foot to the fourth power")>
        FeetPow4

        <UnitSymbol("yd⁴")>
        <UnitName("yard to the fourth power")>
        YardsPow4

    End Enum

    Private Shared Function ConversionFactor([to] As SupportedLengthPow4Units) As Double
        Const pow = 4
        Select Case [to]
            Case SupportedLengthPow4Units.MetersPow4
                Return 1 ^ pow

            Case SupportedLengthPow4Units.DecimetersPow4
                Return 10 ^ pow

            Case SupportedLengthPow4Units.CentimetersPow4
                Return 100 ^ pow

            Case SupportedLengthPow4Units.MillimetersPow4
                Return 1000 ^ pow

            Case SupportedLengthPow4Units.KilometersPow4
                Return 1 / 1000 ^ pow

            Case SupportedLengthPow4Units.InchsPow4
                Return 1 / 0.0254 ^ pow

            Case SupportedLengthPow4Units.FeetPow4
                Return 1 / 0.3048 ^ pow

            Case SupportedLengthPow4Units.YardsPow4
                Return 1 / 0.9144 ^ pow

            Case Else
                Throw New ArgumentException

        End Select
    End Function

End Structure