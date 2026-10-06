Option Strict On
Option Infer On

Partial Structure Pressure

    Private Shared ReadOnly KnownUnits As ObjectModel.ReadOnlyDictionary(Of SupportedPressureUnits, String()) = UnitExtensions.GetKnownUnitDictionary(Of SupportedPressureUnits)()

    Public Enum SupportedPressureUnits

        ''' <summary> Pressure in N/m² </summary>
        <UnitSymbol("N/m²")>
        NewtonsPerSquaremeter = 0

        ''' <summary> Pressure in kN/m² </summary>
        <UnitSymbol("kN/m²")>
        KilonewtonsPerSquaremeter

        ''' <summary> Pressure in MN/m² </summary>
        <UnitSymbol("MN/m²")>
        MeganewtonsPerSquaremeter

        ''' <summary> Pressure in GN/m² </summary>
        <UnitSymbol("GN/m²")>
        GiganewtonsPerSquaremeter

        ''' <summary> Pressure in N/mm² </summary>
        <UnitSymbol("N/mm²")>
        NewtonsPerSquaremillimeter

        ''' <summary> Pressure in kN/mm² </summary>
        <UnitSymbol("kN/mm²")>
        KilonewtonsPerSquaremillimeter

        ''' <summary> Pressure in bar </summary>
        <UnitSymbol("bar")>
        Bars

        ''' <summary> Pressure in kg/cm² </summary>
        <UnitSymbol("kg/cm²")>
        KilogramsPerSquarecentimeter


        ''' <summary> at </summary>
        <UnitSymbol("at")>
        TechnicalAtmospheres

        ''' <summary> atm </summary>
        <UnitSymbol("atm")>
        StandardAtmospheres

        ''' <summary> Torr </summary>
        <UnitSymbol("Torr")>
        Torrs

        ''' <summary> psi </summary>
        <UnitSymbol("psi")>
        PoundsPerSquareInch

    End Enum

    Private Shared Function ConversionFactor([to] As SupportedPressureUnits) As Double
        Select Case [to]
            Case SupportedPressureUnits.NewtonsPerSquaremeter
                Return 1

            Case SupportedPressureUnits.KilonewtonsPerSquaremeter
                Return 1 / 1000

            Case SupportedPressureUnits.MeganewtonsPerSquaremeter
                Return 1 / (1000 * 1000)

            Case SupportedPressureUnits.GiganewtonsPerSquaremeter
                Return 1 / (1000 * 1000 * 1000)

            Case SupportedPressureUnits.NewtonsPerSquaremillimeter
                Return 1 / (1000 * 1000)

            Case SupportedPressureUnits.KilonewtonsPerSquaremillimeter
                Return 1 / (1000 * 1000 * 1000)

            Case SupportedPressureUnits.KilogramsPerSquarecentimeter
                Return 1 / (Acceleration.EarthStandardGravity.MetersPerSquareSecond * 10000)

            Case SupportedPressureUnits.Bars
                Return 1 / (10 ^ 5)

            Case SupportedPressureUnits.TechnicalAtmospheres
                Return 1.0197 * 10 ^ -5

            Case SupportedPressureUnits.StandardAtmospheres
                Return 9.8692 * 10 ^ -6

            Case SupportedPressureUnits.Torrs
                Return 7.5006 * 10 ^ -3

            Case SupportedPressureUnits.PoundsPerSquareInch
                Return 1.450377 * 10 ^ -4

            Case Else
                Throw New ArgumentException

        End Select
    End Function

End Structure