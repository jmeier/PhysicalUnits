Option Strict On
Option Infer On

Partial Structure Mass

    Public Shared Function Parse(s As String) As Mass
        Return Parse(s, Globalization.CultureInfo.CurrentCulture)
    End Function

    Public Shared Function Parse(s As String, provider As IFormatProvider) As Mass
        Dim r = UnitExtensions.Parse(s:=s, provider:=provider, knownUnits:=KnownUnits)
        Return New Mass(r.Value, r.Key)
    End Function

End Structure