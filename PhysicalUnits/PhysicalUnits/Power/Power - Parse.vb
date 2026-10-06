Option Strict On
Option Infer On

Partial Structure Power

    Public Shared Function Parse(s As String) As Power
        Return Parse(s, Globalization.CultureInfo.CurrentCulture)
    End Function

    Public Shared Function Parse(s As String, provider As IFormatProvider) As Power
        Dim r = UnitExtensions.Parse(s:=s, provider:=provider, knownUnits:=KnownUnits)
        Return New Power(r.Value, r.Key)
    End Function

End Structure