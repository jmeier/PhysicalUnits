Option Strict On
Option Infer On

Partial Structure Intensity
    Implements IEquatable(Of Intensity), IComparable(Of Intensity)

    Public Overrides Function GetHashCode() As Integer
        Return _WattsPerSquaremeter.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is Intensity Then
            Return DirectCast(obj, Intensity)._WattsPerSquaremeter.Equals(Me._WattsPerSquaremeter)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As Intensity) As Boolean Implements System.IEquatable(Of Intensity).Equals
        Return other._WattsPerSquaremeter.Equals(Me._WattsPerSquaremeter)
    End Function

    Public Function CompareTo(other As Intensity) As Integer Implements System.IComparable(Of Intensity).CompareTo
        Return Me._WattsPerSquaremeter.CompareTo(other._WattsPerSquaremeter)
    End Function

End Structure