Option Strict On
Option Infer On

Partial Structure Temperature
    Implements IEquatable(Of Temperature), IComparable(Of Temperature)

    Public Overrides Function GetHashCode() As Integer
        Return _Kelvin.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is Temperature Then
            Return DirectCast(obj, Temperature)._Kelvin.Equals(Me._Kelvin)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As Temperature) As Boolean Implements System.IEquatable(Of Temperature).Equals
        Return other._Kelvin.Equals(Me._Kelvin)
    End Function

    Public Function CompareTo(other As Temperature) As Integer Implements System.IComparable(Of Temperature).CompareTo
        Return Me._Kelvin.CompareTo(other._Kelvin)
    End Function

End Structure