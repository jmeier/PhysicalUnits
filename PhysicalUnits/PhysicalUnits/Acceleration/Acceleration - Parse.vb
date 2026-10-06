Option Strict On
Option Infer On

Partial Structure Acceleration

    Public Shared Function Parse(s As String) As Acceleration
        Return Parse(s, Globalization.CultureInfo.CurrentCulture)
    End Function

    Public Shared Function Parse(s As String, provider As IFormatProvider) As Acceleration
        Dim r = UnitExtensions.Parse(s:=s, provider:=provider, knownUnits:=KnownUnits)
        Return New Acceleration(r.Value, r.Key)
    End Function

End Structure