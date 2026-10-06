Option Strict On
Option Infer On

Partial Structure Area

    Public Shared Function Parse(s As String) As Area
        Return Parse(s, Globalization.CultureInfo.CurrentCulture)
    End Function

    Public Shared Function Parse(s As String, provider As IFormatProvider) As Area
        Dim r = UnitExtensions.Parse(s:=s, provider:=provider, knownUnits:=KnownUnits)
        Return New Area(r.Value, r.Key)
    End Function

End Structure