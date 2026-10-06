Option Strict On
Option Infer On

Partial Structure Elevation

    Public Shared Function Parse(s As String) As Elevation
        Return Parse(s, Globalization.CultureInfo.CurrentCulture)
    End Function

    Public Shared Function Parse(s As String, provider As IFormatProvider) As Elevation
        Dim r = UnitExtensions.Parse(s:=s, provider:=provider, knownUnits:=KnownUnits)
        Return New Elevation(r.Value, r.Key)
    End Function

End Structure