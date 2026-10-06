Option Strict On
Option Infer On

Partial Structure Area
    Implements IEquatable(Of Area), IComparable(Of Area)

    Public Overrides Function GetHashCode() As Integer
        Return _MetersPow2.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is Area Then
            Return DirectCast(obj, Area)._MetersPow2.Equals(Me._MetersPow2)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As Area) As Boolean Implements System.IEquatable(Of Area).Equals
        Return other._MetersPow2.Equals(Me._MetersPow2)
    End Function

    Public Function CompareTo(other As Area) As Integer Implements System.IComparable(Of Area).CompareTo
        Return Me._MetersPow2.CompareTo(other._MetersPow2)
    End Function

End Structure