Option Strict On
Option Infer On

Partial Structure Density
    Implements IEquatable(Of Density), IComparable(Of Density)

    Public Overrides Function GetHashCode() As Integer
        Return _KilogramsPerCubicmeter.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is Density Then
            Return DirectCast(obj, Density)._KilogramsPerCubicmeter.Equals(Me._KilogramsPerCubicmeter)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As Density) As Boolean Implements System.IEquatable(Of Density).Equals
        Return other._KilogramsPerCubicmeter.Equals(Me._KilogramsPerCubicmeter)
    End Function

    Public Function CompareTo(other As Density) As Integer Implements System.IComparable(Of Density).CompareTo
        Return Me._KilogramsPerCubicmeter.CompareTo(other._KilogramsPerCubicmeter)
    End Function

End Structure