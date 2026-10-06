Option Strict On
Option Infer On

Partial Structure Force
    Implements IEquatable(Of Force), IComparable(Of Force)

    Public Overrides Function GetHashCode() As Integer
        Return _Newtons.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is Force Then
            Return DirectCast(obj, Force)._Newtons.Equals(Me._Newtons)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As Force) As Boolean Implements System.IEquatable(Of Force).Equals
        Return other._Newtons.Equals(Me._Newtons)
    End Function

    Public Function CompareTo(other As Force) As Integer Implements System.IComparable(Of Force).CompareTo
        Return Me._Newtons.CompareTo(other._Newtons)
    End Function

End Structure