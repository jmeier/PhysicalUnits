Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(values As IEnumerable(Of Vector3D(Of Force))) As Vector3D(Of Force)
        Return Vector3D(Of Force).Sum(values)
    End Function

    <Extension>
    Public Function Average(values As IEnumerable(Of Vector3D(Of Force))) As Vector3D(Of Force)
        Return Vector3D(Of Force).Average(values)
    End Function

    Public Function Newtons(x As Double, y As Double, z As Double) As Vector3D(Of Force)
        Return New Vector3D(Of Force)(Newtons(x), Newtons(y), Newtons(z))
    End Function

    Public Function Kilonewtons(x As Double, y As Double, z As Double) As Vector3D(Of Force)
        Return New Vector3D(Of Force)(Kilonewtons(x), Kilonewtons(y), Kilonewtons(z))
    End Function

    Public Function Meganewtons(x As Double, y As Double, z As Double) As Vector3D(Of Force)
        Return New Vector3D(Of Force)(Meganewtons(x), Meganewtons(y), Meganewtons(z))
    End Function

    Public Function Giganewtons(x As Double, y As Double, z As Double) As Vector3D(Of Force)
        Return New Vector3D(Of Force)(Giganewtons(x), Giganewtons(y), Giganewtons(z))
    End Function

End Module