Option Strict On
Option Infer On

Partial Structure SoundPressure

    Public Shared Function Parse(s As String) As SoundPressure
        Return Parse(s, Globalization.CultureInfo.CurrentCulture)
    End Function

    Public Shared Function Parse(s As String, provider As IFormatProvider) As SoundPressure
        Dim r = UnitExtensions.Parse(s:=s, provider:=provider, knownUnits:=KnownUnits)
        Return New SoundPressure(r.Value, r.Key)
    End Function

End Structure