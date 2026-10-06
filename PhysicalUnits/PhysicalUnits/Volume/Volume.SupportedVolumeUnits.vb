Option Strict On
Option Infer On

Partial Structure Volume


    Public Enum SupportedVolumeUnits

        ''' <summary> Length to the third power in m^3 </summary>
        <UnitSymbol("m³")>
        <UnitName("meter to the third power")>
        MetersPow3 = 0

        ''' <summary> Length in cm </summary>
        <UnitSymbol("cm³")>
        <UnitName("centimeter to the third power")>
        CentimetersPow3

        <UnitSymbol("dm³")>
        <UnitName("decimeter to the third power")>
        DecimetersPow3

        ''' <summary> Length in mm </summary>
        <UnitSymbol("mm³")>
        <UnitName("millimeter to the third power")>
        MillimetersPow3

        <UnitSymbol("km³")>
        <UnitName("kilometer to the third power")>
        KilometersPow3

        <UnitSymbol("in³")>
        <UnitName("inch to the third power")>
        InchsPow3

        <UnitSymbol("ft³")>
        <UnitName("foot to the third power")>
        FeetPow3

        <UnitSymbol("yd³")>
        <UnitName("yard to the third power")>
        YardsPow3

    End Enum

    Private Shared Function ConversionFactor([to] As SupportedVolumeUnits) As Double
        Const pow = 3
        Select Case [to]
            Case SupportedVolumeUnits.MetersPow3
                Return 1 ^ pow

            Case SupportedVolumeUnits.DecimetersPow3
                Return 10 ^ pow

            Case SupportedVolumeUnits.CentimetersPow3
                Return 100 ^ pow

            Case SupportedVolumeUnits.MillimetersPow3
                Return 1000 ^ pow

            Case SupportedVolumeUnits.KilometersPow3
                Return 1 / 1000 ^ pow

            Case SupportedVolumeUnits.InchsPow3
                Return 1 / 0.0254 ^ pow

            Case SupportedVolumeUnits.FeetPow3
                Return 1 / 0.3048 ^ pow

            Case SupportedVolumeUnits.YardsPow3
                Return 1 / 0.9144 ^ pow

            Case Else
                Throw New ArgumentException

        End Select
    End Function

    'Public Enum SupportedVolumeUnits

    '    ''' <summary> Length to the third power in m³ </summary>
    '    <UnitSymbolAttribute("m³")>
    '    <UnitNameAttribute("meter to the third power")>
    '    CubicMeters = 0

    '    ''' <summary> Length in cm </summary>
    '    <UnitSymbolAttribute("cm³")>
    '    <UnitNameAttribute("centimeter to the third power")>
    '    CubicCentimeters

    '    <UnitSymbolAttribute("dm³")>
    '    <UnitNameAttribute("decimeter to the third power")>
    '    CubicDecimeters

    '    ''' <summary> Length in mm </summary>
    '    <UnitSymbolAttribute("mm³")>
    '    <UnitNameAttribute("millimeter to the third power")>
    '    CubicMillimeters

    '    <UnitSymbolAttribute("km³")>
    '    <UnitNameAttribute("kilometer to the third power")>
    '    CubicKilometers

    '    <UnitSymbolAttribute("in³")>
    '    <UnitNameAttribute("inch to the third power")>
    '    CubicInchs

    '    <UnitSymbolAttribute("ft³")>
    '    <UnitNameAttribute("foot to the third power")>
    '    CubicFeet

    '    <UnitSymbolAttribute("yd³")>
    '    <UnitNameAttribute("yard to the third power")>
    '    CubicYards

    'End Enum

    'Private Shared Function ConversionFactor([to] As SupportedVolumeUnits) As Double
    '    Const pow = 3
    '    Select Case [to]
    '        Case SupportedVolumeUnits.CubicMeters
    '            Return 1 ^ pow

    '        Case SupportedVolumeUnits.CubicDecimeters
    '            Return 10 ^ pow

    '        Case SupportedVolumeUnits.CubicCentimeters
    '            Return 100 ^ pow

    '        Case SupportedVolumeUnits.CubicMillimeters
    '            Return 1000 ^ pow

    '        Case SupportedVolumeUnits.CubicKilometers
    '            Return 1 / 1000 ^ pow

    '        Case SupportedVolumeUnits.CubicInchs
    '            Return 1 / 0.0254 ^ pow

    '        Case SupportedVolumeUnits.CubicFeet
    '            Return 1 / 0.3048 ^ pow

    '        Case SupportedVolumeUnits.CubicYards
    '            Return 1 / 0.9144 ^ pow

    '        Case Else
    '            Throw New ArgumentException

    '    End Select
    'End Function

End Structure