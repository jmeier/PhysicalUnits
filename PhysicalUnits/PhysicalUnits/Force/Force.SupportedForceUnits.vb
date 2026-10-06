Option Strict On
Option Infer On

Partial Structure Force

    Private Shared ReadOnly KnownUnits As ObjectModel.ReadOnlyDictionary(Of SupportedForceUnits, String()) = UnitExtensions.GetKnownUnitDictionary(Of SupportedForceUnits)()

    Public Enum SupportedForceUnits

        ''' <summary> Force in N </summary>
        ''' <remarks> 1 N ≡ 1 kg · m / s² </remarks>
        <UnitSymbol("N")>
        <UnitName("Newton")>
        Newtons = 0

        ''' <summary> Force in kN </summary>
        <UnitSymbol("kN")>
        <UnitName("Kilonewton")>
        Kilonewtons

        ''' <summary> Force in MN </summary>
        <UnitSymbol("MN")>
        <UnitName("Meganewton")>
        Meganewtons

        ''' <summary> Force in GN </summary>
        <UnitSymbol("GN")>
        <UnitName("Giganewtons")>
        Giganewtons

    End Enum

    Private Shared Function ConversionFactor([to] As SupportedForceUnits) As Double
        Select Case [to]
            Case SupportedForceUnits.Newtons
                Return 1

            Case SupportedForceUnits.Kilonewtons
                Return 1 / 1000

            Case SupportedForceUnits.Meganewtons
                Return 1 / 1000000

            Case SupportedForceUnits.Giganewtons
                Return 1 / 1000000000

            Case Else
                Throw New ArgumentException

        End Select
    End Function

End Structure