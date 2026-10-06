Option Strict On
Option Infer On

Partial Structure Intensity

    Public Shared Function Parse(s As String) As Intensity
        Return Parse(s, Globalization.CultureInfo.CurrentCulture)
    End Function

    Public Shared Function Parse(s As String, provider As IFormatProvider) As Intensity
        Dim r = UnitExtensions.Parse(s:=s, provider:=provider, knownUnits:=KnownUnits)
        Return New Intensity(r.Value, r.Key)
    End Function

End Structure