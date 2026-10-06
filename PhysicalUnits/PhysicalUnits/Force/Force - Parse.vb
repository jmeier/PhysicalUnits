Option Strict On
Option Infer On

Partial Structure Force

    Public Shared Function Parse(s As String) As Force
        Return Parse(s, Globalization.CultureInfo.CurrentCulture)
    End Function

    Public Shared Function Parse(s As String, provider As IFormatProvider) As Force
        Dim r = UnitExtensions.Parse(s:=s, provider:=provider, knownUnits:=KnownUnits)
        Return New Force(r.Value, r.Key)
    End Function

End Structure