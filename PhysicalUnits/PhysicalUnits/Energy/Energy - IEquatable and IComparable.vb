Option Strict On
Option Infer On

Partial Structure Energy
    Implements IEquatable(Of Energy), IComparable(Of Energy)

    Public Overrides Function GetHashCode() As Integer
        Return _Joules.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is Energy Then
            Return DirectCast(obj, Energy)._Joules.Equals(Me._Joules)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As Energy) As Boolean Implements System.IEquatable(Of Energy).Equals
        Return other._Joules.Equals(Me._Joules)
    End Function

    Public Function CompareTo(other As Energy) As Integer Implements System.IComparable(Of Energy).CompareTo
        Return Me._Joules.CompareTo(other._Joules)
    End Function

End Structure