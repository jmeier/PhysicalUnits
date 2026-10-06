Option Strict On
Option Infer On

Partial Structure PerVolume(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})
    Implements IEquatable(Of PerVolume(Of T)), IComparable(Of PerVolume(Of T))

    Public Overrides Function GetHashCode() As Integer
        Return _ValuePerCubicemeter.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is PerVolume(Of T) Then
            Return DirectCast(obj, PerVolume(Of T))._ValuePerCubicemeter.Equals(Me._ValuePerCubicemeter)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As PerVolume(Of T)) As Boolean Implements System.IEquatable(Of PerVolume(Of T)).Equals
        Return other._ValuePerCubicemeter.Equals(Me._ValuePerCubicemeter)
    End Function

    Public Function CompareTo(other As PerVolume(Of T)) As Integer Implements System.IComparable(Of PerVolume(Of T)).CompareTo
        Return Me._ValuePerCubicemeter.CompareTo(other._ValuePerCubicemeter)
    End Function

End Structure