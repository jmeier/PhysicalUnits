Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    <Extension>
    Public Function Sum(values As IEnumerable(Of Vector3D(Of Pressure))) As Vector3D(Of Pressure)
        Return Vector3D(Of Pressure).Sum(values)
    End Function

    <Extension>
    Public Function Average(values As IEnumerable(Of Vector3D(Of Pressure))) As Vector3D(Of Pressure)
        Return Vector3D(Of Pressure).Average(values)
    End Function

    Public Function NewtonsPerSquaremeter(x As Double, y As Double, z As Double) As Vector3D(Of Pressure)
        Return New Vector3D(Of Pressure)(NewtonsPerSquaremeter(x), NewtonsPerSquaremeter(y), NewtonsPerSquaremeter(z))
    End Function

    Public Function KilonewtonsPerSquaremeter(x As Double, y As Double, z As Double) As Vector3D(Of Pressure)
        Return New Vector3D(Of Pressure)(KilonewtonsPerSquaremeter(x), KilonewtonsPerSquaremeter(y), KilonewtonsPerSquaremeter(z))
    End Function

    Public Function KilogramsPerSqarecentimeter(x As Double, y As Double, z As Double) As Vector3D(Of Pressure)
        Return New Vector3D(Of Pressure)(KilogramsPerSqarecentimeter(x), KilogramsPerSqarecentimeter(y), KilogramsPerSqarecentimeter(z))
    End Function

    Public Function Bars(x As Double, y As Double, z As Double) As Vector3D(Of Pressure)
        Return New Vector3D(Of Pressure)(Bars(x), Bars(y), Bars(z))
    End Function

    Public Function KilonewtonsPerSquaremillimeter(x As Double, y As Double, z As Double) As Vector3D(Of Pressure)
        Return New Vector3D(Of Pressure)(KilonewtonsPerSquaremillimeter(x), KilonewtonsPerSquaremillimeter(y), KilonewtonsPerSquaremillimeter(z))
    End Function

    Public Function MeganewtonsPerSquaremeter(x As Double, y As Double, z As Double) As Vector3D(Of Pressure)
        Return New Vector3D(Of Pressure)(MeganewtonsPerSquaremeter(x), MeganewtonsPerSquaremeter(y), MeganewtonsPerSquaremeter(z))
    End Function

    Public Function GiganewtonsPerSquaremeter(x As Double, y As Double, z As Double) As Vector3D(Of Pressure)
        Return New Vector3D(Of Pressure)(GiganewtonsPerSquaremeter(x), GiganewtonsPerSquaremeter(y), GiganewtonsPerSquaremeter(z))
    End Function

    Public Function NewtonsPerSquaremillimeter(x As Double, y As Double, z As Double) As Vector3D(Of Pressure)
        Return New Vector3D(Of Pressure)(NewtonsPerSquaremillimeter(x), NewtonsPerSquaremillimeter(y), NewtonsPerSquaremillimeter(z))
    End Function

    Public Function Pascals(x As Double, y As Double, z As Double) As Vector3D(Of Pressure)
        Return New Vector3D(Of Pressure)(Pascals(x), Pascals(y), Pascals(z))
    End Function

    Public Function Kilopascals(x As Double, y As Double, z As Double) As Vector3D(Of Pressure)
        Return New Vector3D(Of Pressure)(Kilopascals(x), Kilopascals(y), Kilopascals(z))
    End Function

    Public Function Megapascals(x As Double, y As Double, z As Double) As Vector3D(Of Pressure)
        Return New Vector3D(Of Pressure)(Megapascals(x), Megapascals(y), Megapascals(z))
    End Function

    Public Function Gigapascals(x As Double, y As Double, z As Double) As Vector3D(Of Pressure)
        Return New Vector3D(Of Pressure)(Gigapascals(x), Gigapascals(y), Gigapascals(z))
    End Function

End Module