Option Strict On
Option Infer On

Partial Structure Volume
    Implements IEquatable(Of Volume), IComparable(Of Volume)

    Public Overrides Function GetHashCode() As Integer
        Return _MetersPow3.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is Volume Then
            Return DirectCast(obj, Volume)._MetersPow3.Equals(Me._MetersPow3)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As Volume) As Boolean Implements IEquatable(Of Volume).Equals
        Return other._MetersPow3.Equals(Me._MetersPow3)
    End Function

    Public Function CompareTo(other As Volume) As Integer Implements IComparable(Of Volume).CompareTo
        Return Me._MetersPow3.CompareTo(other._MetersPow3)
    End Function

End Structure