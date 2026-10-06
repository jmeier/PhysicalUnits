Option Strict On
Option Infer On

Partial Structure Velocity

    Public Shared Function Parse(s As String) As Velocity
        Return Parse(s, Globalization.CultureInfo.CurrentCulture)
    End Function

    Public Shared Function Parse(s As String, provider As IFormatProvider) As Velocity
        Dim r = UnitExtensions.Parse(s:=s, provider:=provider, knownUnits:=KnownUnits)
        Return New Velocity(r.Value, r.Key)
    End Function

End Structure