Option Strict On
Option Infer On

Partial Structure Pressure
    Implements IEquatable(Of Pressure), IComparable(Of Pressure)

    Public Overrides Function GetHashCode() As Integer
        Return _NewtonsPerSquaremeter.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is Pressure Then
            Return DirectCast(obj, Pressure)._NewtonsPerSquaremeter.Equals(Me._NewtonsPerSquaremeter)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As Pressure) As Boolean Implements System.IEquatable(Of Pressure).Equals
        Return other._NewtonsPerSquaremeter.Equals(Me._NewtonsPerSquaremeter)
    End Function

    Public Function CompareTo(other As Pressure) As Integer Implements System.IComparable(Of Pressure).CompareTo
        Return Me._NewtonsPerSquaremeter.CompareTo(other._NewtonsPerSquaremeter)
    End Function

End Structure