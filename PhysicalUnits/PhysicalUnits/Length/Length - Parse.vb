Option Strict On
Option Infer On

Partial Structure Length

    Public Shared Function Parse(s As String) As Length
        Return Parse(s, Globalization.CultureInfo.CurrentCulture)
    End Function

    Public Shared Function Parse(s As String, provider As IFormatProvider) As Length
        Dim r = UnitExtensions.Parse(s:=s, provider:=provider, knownUnits:=KnownUnits)
        Return New Length(r.Value, r.Key)
    End Function

End Structure