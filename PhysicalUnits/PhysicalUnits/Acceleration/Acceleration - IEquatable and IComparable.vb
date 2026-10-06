Option Strict On
Option Infer On

Partial Structure Acceleration
    Implements IEquatable(Of Acceleration), IComparable(Of Acceleration)

    Public Overrides Function GetHashCode() As Integer
        Return _MetersPerSquareSecond.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is Acceleration Then
            Return DirectCast(obj, Acceleration)._MetersPerSquareSecond.Equals(Me._MetersPerSquareSecond)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As Acceleration) As Boolean Implements System.IEquatable(Of Acceleration).Equals
        Return other._MetersPerSquareSecond.Equals(Me._MetersPerSquareSecond)
    End Function

    Public Function CompareTo(other As Acceleration) As Integer Implements System.IComparable(Of Acceleration).CompareTo
        Return Me._MetersPerSquareSecond.CompareTo(other._MetersPerSquareSecond)
    End Function

End Structure