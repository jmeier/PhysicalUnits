Option Strict On
Option Infer On

Partial Structure Velocity

    Public Shared Function FromMetersPerSecond(d As Double) As Velocity
        Return New Velocity With {._MetersPerSecond = d}
    End Function
    Public Shared Function FromMetersPerSecond(d As Double?) As Velocity?
        If d.HasValue Then
            Return FromMetersPerSecond(d.Value)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Velocity in m/s </summary>
    Public ReadOnly Property MetersPerSecond() As Double
        Get
            Return _MetersPerSecond
        End Get
    End Property
    Private _MetersPerSecond As Double

End Structure