Option Strict On
Option Infer On

Partial Structure Frequency
    Implements IEquatable(Of Frequency), IComparable(Of Frequency)

    Public Overrides Function GetHashCode() As Integer
        Return _Hertz.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is Frequency Then
            Return DirectCast(obj, Frequency)._Hertz.Equals(Me._Hertz)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As Frequency) As Boolean Implements System.IEquatable(Of Frequency).Equals
        Return other._Hertz.Equals(Me._Hertz)
    End Function

    Public Function CompareTo(other As Frequency) As Integer Implements System.IComparable(Of Frequency).CompareTo
        Return Me._Hertz.CompareTo(other._Hertz)
    End Function

End Structure