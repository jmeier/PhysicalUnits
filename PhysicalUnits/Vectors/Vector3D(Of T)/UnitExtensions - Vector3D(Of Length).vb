Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(values As IEnumerable(Of Vector3D(Of Length))) As Vector3D(Of Length)
        Return Vector3D(Of Length).Sum(values)
    End Function

    <Extension>
    Public Function Average(values As IEnumerable(Of Vector3D(Of Length))) As Vector3D(Of Length)
        Return Vector3D(Of Length).Average(values)
    End Function

    Public Function Meters(x As Double, y As Double, z As Double) As Vector3D(Of Length)
        Return New Vector3D(Of Length)(Meters(x), Meters(y), Meters(z))
    End Function

    Public Function Kilometers(x As Double, y As Double, z As Double) As Vector3D(Of Length)
        Return New Vector3D(Of Length)(Kilometers(x), Kilometers(y), Kilometers(z))
    End Function

    Public Function Millimeters(x As Double, y As Double, z As Double) As Vector3D(Of Length)
        Return New Vector3D(Of Length)(Millimeters(x), Millimeters(y), Millimeters(z))
    End Function

    Public Function Centimeters(x As Double, y As Double, z As Double) As Vector3D(Of Length)
        Return New Vector3D(Of Length)(Centimeters(x), Centimeters(y), Centimeters(z))
    End Function

    Public Function Decimeters(x As Double, y As Double, z As Double) As Vector3D(Of Length)
        Return New Vector3D(Of Length)(Decimeters(x), Decimeters(y), Decimeters(z))
    End Function

End Module