Option Strict On
Option Infer On

Partial Structure TimesLength(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})
    Implements IEquatable(Of TimesLength(Of T)), IComparable(Of TimesLength(Of T))

    Public Overrides Function GetHashCode() As Integer
        Return _ValueTimesMeter.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is TimesLength(Of T) Then
            Return DirectCast(obj, TimesLength(Of T))._ValueTimesMeter.Equals(Me._ValueTimesMeter)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As TimesLength(Of T)) As Boolean Implements System.IEquatable(Of TimesLength(Of T)).Equals
        Return other._ValueTimesMeter.Equals(Me._ValueTimesMeter)
    End Function

    Public Function CompareTo(other As TimesLength(Of T)) As Integer Implements System.IComparable(Of TimesLength(Of T)).CompareTo
        Return Me._ValueTimesMeter.CompareTo(other._ValueTimesMeter)
    End Function

End Structure