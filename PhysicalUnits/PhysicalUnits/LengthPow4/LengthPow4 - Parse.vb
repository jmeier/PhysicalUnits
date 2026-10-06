Option Strict On
Option Infer On

Partial Structure LengthPow4

    Public Shared Function Parse(s As String) As LengthPow4
        Return Parse(s, Globalization.CultureInfo.CurrentCulture)
    End Function

    Public Shared Function Parse(s As String, provider As IFormatProvider) As LengthPow4
        Dim r = UnitExtensions.Parse(s:=s, provider:=provider, knownUnits:=KnownUnits)
        Return New LengthPow4(r.Value, r.Key)
    End Function

End Structure