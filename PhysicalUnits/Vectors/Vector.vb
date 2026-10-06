Option Strict On
Option Infer On

<CLSCompliant(True)>
Public MustInherit Class Vector

    Private Sub New()
    End Sub

    Public Shared Function Create(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(x As T, y As T) As Vector2D(Of T)
        Return New Vector2D(Of T)(x, y)
    End Function

    Public Shared Function Create(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(x As T, y As T, z As T) As Vector3D(Of T)
        Return New Vector3D(Of T)(x, y, z)
    End Function

End Class
