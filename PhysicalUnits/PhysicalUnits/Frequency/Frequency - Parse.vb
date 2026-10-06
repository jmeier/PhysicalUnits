Option Strict On
Option Infer On

Partial Structure Frequency

    Public Shared Function Parse(s As String) As Frequency
        Return Parse(s, Globalization.CultureInfo.CurrentCulture)
    End Function

    Public Shared Function Parse(s As String, provider As IFormatProvider) As Frequency
        Dim r = UnitExtensions.Parse(s:=s, provider:=provider, knownUnits:=KnownUnits)
        Return New Frequency(r.Value, r.Key)
    End Function

End Structure