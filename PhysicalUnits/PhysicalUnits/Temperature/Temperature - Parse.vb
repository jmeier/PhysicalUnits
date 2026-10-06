Option Strict On
Option Infer On

Partial Structure Temperature

    Public Shared Function Parse(s As String) As Temperature
        Return Parse(s, Globalization.CultureInfo.CurrentCulture)
    End Function

    Public Shared Function Parse(s As String, provider As IFormatProvider) As Temperature
        Dim r = UnitExtensions.Parse(s:=s, provider:=provider, knownUnits:=KnownUnits)
        Return New Temperature(r.Value, r.Key)
    End Function

End Structure