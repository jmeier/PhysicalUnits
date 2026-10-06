Option Strict On
Option Infer On

Partial Structure Pressure

    Public Shared Function Parse(s As String) As Pressure
        Return Parse(s, Globalization.CultureInfo.CurrentCulture)
    End Function

    Public Shared Function Parse(s As String, provider As IFormatProvider) As Pressure
        Dim r = UnitExtensions.Parse(s:=s, provider:=provider, knownUnits:=KnownUnits)
        Return New Pressure(r.Value, r.Key)
    End Function

End Structure