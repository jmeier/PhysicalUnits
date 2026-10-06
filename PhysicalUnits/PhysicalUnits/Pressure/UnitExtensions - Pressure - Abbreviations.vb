Option Strict On
Option Infer On
Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    Public Function Pa(value As Double) As Pressure
        Return Pascals(value)
    End Function
    Public Function Pa(value As Double?) As Pressure?
        Return Pascals(value)
    End Function

#Disable Warning IDE1006 ' Naming Styles
    Public Function kPa(value As Double) As Pressure
        Return Kilopascals(value)
    End Function
    Public Function kPa(value As Double?) As Pressure?
        Return Kilopascals(value)
    End Function
#Enable Warning IDE1006 ' Naming Styles

    Public Function MPa(value As Double) As Pressure
        Return Megapascals(value)
    End Function
    Public Function MPa(value As Double?) As Pressure?
        Return Megapascals(value)
    End Function

    Public Function GPa(value As Double) As Pressure
        Return Gigapascals(value)
    End Function
    Public Function GPa(value As Double?) As Pressure?
        Return Gigapascals(value)
    End Function

End Module