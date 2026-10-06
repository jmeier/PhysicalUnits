Option Strict On
Option Infer On

Partial Structure Elevation
    Implements IEquatable(Of Elevation), IComparable(Of Elevation)

    Public Overrides Function GetHashCode() As Integer
        Return _MetersAboveNN.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is Elevation Then
            Return DirectCast(obj, Elevation)._MetersAboveNN.Equals(Me._MetersAboveNN)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As Elevation) As Boolean Implements System.IEquatable(Of Elevation).Equals
        Return other._MetersAboveNN.Equals(Me._MetersAboveNN)
    End Function

    Public Function CompareTo(other As Elevation) As Integer Implements System.IComparable(Of Elevation).CompareTo
        Return Me._MetersAboveNN.CompareTo(other._MetersAboveNN)
    End Function

End Structure