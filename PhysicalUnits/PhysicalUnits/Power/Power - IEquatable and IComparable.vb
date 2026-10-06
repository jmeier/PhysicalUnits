Option Strict On
Option Infer On

Partial Structure Power
    Implements IEquatable(Of Power), IComparable(Of Power)

    Public Overrides Function GetHashCode() As Integer
        Return _Watts.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is Power Then
            Return DirectCast(obj, Power)._Watts.Equals(Me._Watts)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As Power) As Boolean Implements System.IEquatable(Of Power).Equals
        Return other._Watts.Equals(Me._Watts)
    End Function

    Public Function CompareTo(other As Power) As Integer Implements System.IComparable(Of Power).CompareTo
        Return Me._Watts.CompareTo(other._Watts)
    End Function

End Structure