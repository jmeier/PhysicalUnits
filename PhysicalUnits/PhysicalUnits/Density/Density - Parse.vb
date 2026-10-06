Option Strict On
Option Infer On

Partial Structure Density

    Public Shared Function Parse(s As String) As Density
        Return Parse(s, Globalization.CultureInfo.CurrentCulture)
    End Function

    Public Shared Function Parse(s As String, provider As IFormatProvider) As Density
        Dim r = UnitExtensions.Parse(s:=s, provider:=provider, knownUnits:=KnownUnits)
        Return New Density(r.Value, r.Key)
    End Function

End Structure