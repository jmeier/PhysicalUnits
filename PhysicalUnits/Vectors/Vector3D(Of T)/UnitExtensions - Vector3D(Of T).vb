Option Strict On
Option Infer On

Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function WithX(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(vector As Vector3D(Of T), value As T) As Vector3D(Of T)
        Return New Vector3D(Of T)(x:=value, y:=vector.Y, z:=vector.Z)
    End Function

    <Extension>
    Public Function WithY(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(vector As Vector3D(Of T), value As T) As Vector3D(Of T)
        Return New Vector3D(Of T)(x:=vector.X, y:=value, z:=vector.Z)
    End Function

    <Extension>
    Public Function WithZ(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})(vector As Vector3D(Of T), value As T) As Vector3D(Of T)
        Return New Vector3D(Of T)(x:=vector.X, y:=vector.Y, z:=value)
    End Function

End Module