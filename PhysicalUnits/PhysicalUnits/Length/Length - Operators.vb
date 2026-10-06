Option Strict On
Option Infer On

Partial Structure Length

#Region "Equality, Comparison"

    Public Shared Operator =(a As Length, b As Length) As Boolean
        Return a._Meters = b._Meters
    End Operator

    Public Shared Operator <>(a As Length, b As Length) As Boolean
        Return a._Meters <> b._Meters
    End Operator

    Public Shared Operator <(a As Length, b As Length) As Boolean
        Return a._Meters < b._Meters
    End Operator

    Public Shared Operator >(a As Length, b As Length) As Boolean
        Return a._Meters > b._Meters
    End Operator

    Public Shared Operator <=(a As Length, b As Length) As Boolean
        Return a._Meters <= b._Meters
    End Operator

    Public Shared Operator >=(a As Length, b As Length) As Boolean
        Return a._Meters >= b._Meters
    End Operator

#End Region

#Region "Arithmetics"

    Public Shared Operator +(a As Length) As Length
        Return a
    End Operator

    Public Shared Operator +(a As Length?) As Length?
        Return a
    End Operator

    Public Shared Operator -(a As Length) As Length
        Return Length.FromMeters(-a._Meters)
    End Operator

    Public Shared Operator -(a As Length?) As Length?
        If a.HasValue Then
            Return Length.FromMeters(-a.Value._Meters)
        Else
            Return Nothing
        End If
    End Operator

    Public Shared Operator +(a As Length, b As Length) As Length
        Return Length.FromMeters(a._Meters + b._Meters)
    End Operator

    Public Shared Operator -(a As Length, b As Length) As Length
        Return Length.FromMeters(a._Meters - b._Meters)
    End Operator


    Public Shared Operator *(a As Length, b As Double) As Length
        Return Length.FromMeters(a._Meters * b)
    End Operator
    Public Shared Operator *(a As Double, b As Length) As Length
        Return Length.FromMeters(b._Meters * a)
    End Operator
    Public Shared Operator /(a As Length, b As Double) As Length
        Return Length.FromMeters(a._Meters / b)
    End Operator
    Public Shared Operator /(a As Length, b As Length) As Double
        Return a._Meters / b.Meters
    End Operator
    Public Shared Operator /(a As Double, b As Length) As OneOver(Of Length)
        Return (b / a).OneOver
    End Operator

    Public Shared Operator *(a As Length, b As Length) As Area
        Return Area.FromSquaremeters(a._Meters * b.Meters)
    End Operator

    Public Shared Operator /(a As PerLength(Of Force), b As Length) As PerArea(Of Force)
        Return Newtons(a.ValuePerRunningMeter.Newtons / b.Meters).PerSquaremeter
    End Operator

    Public Shared Operator /(a As PerArea(Of Force), b As Length) As PerVolume(Of Force)
        Return Newtons(a.ValuePerSquaremeter.Newtons / b.Meters).PerCubicmeter
    End Operator

    Public Shared Operator *(a As PerLength(Of Force), b As Length) As Force
        Return Newtons(a.ValuePerRunningMeter.Newtons * b.Meters)
    End Operator
    Public Shared Operator *(a As Length, b As PerLength(Of Force)) As Force
        Return Newtons(a.Meters * b.ValuePerRunningMeter.Newtons)
    End Operator

    Public Shared Operator *(a As PerArea(Of Force), b As Length) As PerLength(Of Force)
        Return NewtonsPerMeter(a.ValuePerSquaremeter.Newtons * b.Meters)
    End Operator
    Public Shared Operator *(a As Length, b As PerArea(Of Force)) As PerLength(Of Force)
        Return NewtonsPerMeter(a.Meters * b.ValuePerSquaremeter.Newtons)
    End Operator

    Public Shared Operator *(a As PerVolume(Of Force), b As Length) As PerArea(Of Force)
        Return NewtonsPerSquaremeter(a.ValuePerCubicmeter.Newtons * b.Meters)
    End Operator
    Public Shared Operator *(a As Length, b As PerVolume(Of Force)) As PerArea(Of Force)
        Return NewtonsPerSquaremeter(a.Meters * b.ValuePerCubicmeter.Newtons)
    End Operator


#End Region

#Region "Vector Arithmetics"

    Public Shared Operator /(a As Vector3D(Of Force), d As Length) As Vector3D(Of PerLength(Of Force))
        Return New Vector3D(Of PerLength(Of Force))(x:=a.X / d,
                                                    y:=a.Y / d,
                                                    z:=a.Z / d)
    End Operator
    Public Shared Operator *(a As Vector3D(Of Force), d As Length) As Vector3D(Of TimesLength(Of Force))
        Return New Vector3D(Of TimesLength(Of Force))(x:=a.X * d,
                                                 y:=a.Y * d,
                                                 z:=a.Z * d)
    End Operator

#End Region

End Structure