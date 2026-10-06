Option Strict On
Option Infer On

Partial Structure Velocity
    Implements IEquatable(Of Velocity), IComparable(Of Velocity)

    Public Overrides Function GetHashCode() As Integer
        Return _MetersPerSecond.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is Velocity Then
            Return DirectCast(obj, Velocity)._MetersPerSecond.Equals(Me._MetersPerSecond)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As Velocity) As Boolean Implements System.IEquatable(Of Velocity).Equals
        Return other._MetersPerSecond.Equals(Me._MetersPerSecond)
    End Function

    Public Function CompareTo(other As Velocity) As Integer Implements System.IComparable(Of Velocity).CompareTo
        Return Me._MetersPerSecond.CompareTo(other._MetersPerSecond)
    End Function

End Structure