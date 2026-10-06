Option Strict On
Option Infer On

Partial Structure Energy

    Public Shared Function Parse(s As String) As Energy
        Return Parse(s, Globalization.CultureInfo.CurrentCulture)
    End Function

    Public Shared Function Parse(s As String, provider As IFormatProvider) As Energy
        Dim r = UnitExtensions.Parse(s:=s, provider:=provider, knownUnits:=KnownUnits)
        Return New Energy(r.Value, r.Key)
    End Function

End Structure