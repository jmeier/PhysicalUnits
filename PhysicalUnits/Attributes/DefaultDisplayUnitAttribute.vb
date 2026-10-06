Option Strict On
Option Infer On

<CLSCompliant(True)>
Public Class DefaultDisplayUnitAttribute : Inherits Attribute

    Sub New(unit As Acceleration.SupportedAccelerationUnits)
        Me.Unit = unit
    End Sub

    Sub New(unit As Area.SupportedAreaUnits)
        Me.Unit = unit
    End Sub

    'Sub New(unit As TimesLength(Of Force).SupportedTimesLength(Of Force)Units)
    '    Me.Unit = unit
    'End Sub

    Sub New(unit As Density.SupportedDensityUnits)
        Me.Unit = unit
    End Sub

    Sub New(unit As Energy.SupportedEnergyUnits)
        Me.Unit = unit
    End Sub

    Sub New(unit As Force.SupportedForceUnits)
        Me.Unit = unit
    End Sub

    'Sub New(unit As PerLength(Of Force).SupportedForcePerLengthUnits)
    '    Me.Unit = unit
    'End Sub

    Sub New(unit As Frequency.SupportedFrequencyUnits)
        Me.Unit = unit
    End Sub

    Sub New(unit As Intensity.SupportedIntensityUnits)
        Me.Unit = unit
    End Sub

    Sub New(unit As Length.SupportedLengthUnits)
        Me.Unit = unit
    End Sub

    Sub New(unit As Mass.SupportedMassUnits)
        Me.Unit = unit
    End Sub

    Sub New(unit As Pressure.SupportedPressureUnits)
        Me.Unit = unit
    End Sub

    Sub New(unit As LengthPow4.SupportedLengthPow4Units)
        Me.Unit = unit
    End Sub

    'Sub New(unit As TimesArea(Of Force).SupportedTimesArea(Of Force)Units)
    '    Me.Unit = unit
    'End Sub

    Sub New(unit As SoundPressure.SupportedSoundPressureUnits)
        Me.Unit = unit
    End Sub

    Sub New(unit As Temperature.SupportedTemperatureUnits)
        Me.Unit = unit
    End Sub

    Sub New(unit As Velocity.SupportedVelocityUnits)
        Me.Unit = unit
    End Sub

    Sub New(unit As Volume.SupportedVolumeUnits)
        Me.Unit = unit
    End Sub

    Sub New(unit As Elevation.SupportedElevationUnits)
        Me.Unit = unit
    End Sub

    Public Property Unit As [Enum]

End Class
