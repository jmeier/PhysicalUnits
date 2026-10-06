Option Strict On
Option Infer On

Partial Structure Mass
    Implements IEquatable(Of Mass), IComparable(Of Mass)

    Public Overrides Function GetHashCode() As Integer
        Return _Kilograms.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is Mass Then
            Return DirectCast(obj, Mass)._Kilograms.Equals(Me._Kilograms)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As Mass) As Boolean Implements IEquatable(Of Mass).Equals
        Return other._Kilograms.Equals(Me._Kilograms)
    End Function

    Public Function CompareTo(other As Mass) As Integer Implements IComparable(Of Mass).CompareTo
        Return Me._Kilograms.CompareTo(other._Kilograms)
    End Function

End Structure