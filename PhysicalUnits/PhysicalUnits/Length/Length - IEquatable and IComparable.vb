Option Strict On
Option Infer On

Partial Structure Length
    Implements IEquatable(Of Length), IComparable(Of Length)

    Public Overrides Function GetHashCode() As Integer
        Return _Meters.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is Length Then
            Return DirectCast(obj, Length)._Meters.Equals(Me._Meters)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As Length) As Boolean Implements IEquatable(Of Length).Equals
        Return other._Meters.Equals(Me._Meters)
    End Function

    Public Function CompareTo(other As Length) As Integer Implements IComparable(Of Length).CompareTo
        Return Me._Meters.CompareTo(other._Meters)
    End Function

End Structure