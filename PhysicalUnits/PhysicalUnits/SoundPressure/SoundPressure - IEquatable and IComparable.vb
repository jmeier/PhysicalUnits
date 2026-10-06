Option Strict On
Option Infer On

Partial Structure SoundPressure
    Implements IEquatable(Of SoundPressure), IComparable(Of SoundPressure)

    Public Overrides Function GetHashCode() As Integer
        Return _Decibel.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then
            Return False
        ElseIf TypeOf obj Is SoundPressure Then
            Return DirectCast(obj, SoundPressure)._Decibel.Equals(Me._Decibel)
        Else
            Return False
        End If
    End Function

    Public Overloads Function Equals(other As SoundPressure) As Boolean Implements System.IEquatable(Of SoundPressure).Equals
        Return other._Decibel.Equals(Me._Decibel)
    End Function

    Public Function CompareTo(other As SoundPressure) As Integer Implements System.IComparable(Of SoundPressure).CompareTo
        Return Me._Decibel.CompareTo(other._Decibel)
    End Function

End Structure