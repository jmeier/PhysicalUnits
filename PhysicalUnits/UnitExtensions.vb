Option Strict On
Option Infer On

Imports System.Runtime.CompilerServices

<CLSCompliant(True)>
Public Module UnitExtensions

    ''' <summary>
    ''' Determines whether a number is a finite, legal number.
    ''' This Function returns False If the value Is +infinity, -infinity, Or NaN (Not-a-Number), otherwise it returns True.
    ''' </summary>
    ''' <returns></returns>
    <Extension>
    Friend Function IsFinite(value As Double) As Boolean
        Return Not (Double.IsNaN(value) OrElse Double.IsInfinity(value))
    End Function

    ''' <summary>
    ''' Determines whether a number is a finite, legal number.
    ''' This Function returns False If the value Is +infinity, -infinity, Or NaN (Not-a-Number), otherwise it returns True.
    ''' </summary>
    ''' <returns></returns>
    <Extension>
    Friend Function IsFinite(value As Single) As Boolean
        Return Not (Single.IsNaN(value) OrElse Single.IsInfinity(value))
    End Function

End Module