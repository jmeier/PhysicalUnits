Option Strict On
Option Infer On

Partial Structure LengthPow4
    Implements IEquatable(Of LengthPow4), IComparable(Of LengthPow4)

    Public Overrides Function GetHashCode() As Integer
        Return _MetersPow4.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is LengthPow4 Then
            Return DirectCast(obj, LengthPow4)._MetersPow4.Equals(Me._MetersPow4)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As LengthPow4) As Boolean Implements System.IEquatable(Of LengthPow4).Equals
        Return other._MetersPow4.Equals(Me._MetersPow4)
    End Function

    Public Function CompareTo(other As LengthPow4) As Integer Implements System.IComparable(Of LengthPow4).CompareTo
        Return Me._MetersPow4.CompareTo(other._MetersPow4)
    End Function

End Structure