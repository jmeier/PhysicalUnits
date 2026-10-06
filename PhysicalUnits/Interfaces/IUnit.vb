Option Strict On
Option Infer On

Imports System.Runtime.Serialization

<CLSCompliant(True)>
Public Interface IUnit : Inherits Xml.Serialization.IXmlSerializable, ISerializable

    ReadOnly Property SupportedUnitsEnumType As Type

    ReadOnly Property DefaultUnit() As [Enum]

    Function GetValue(unit As [Enum]) As Double

    Function Create(value As Double, unit As [Enum]) As IUnit

    ReadOnly Property IsNaN As Boolean

    ReadOnly Property IsInfinity As Boolean

    ReadOnly Property IsPositiveInfinity As Boolean

    ReadOnly Property IsNegativeInfinity As Boolean

    ''' <summary>
    ''' Determines whether a number is a finite, legal number.
    ''' This Function returns False If the value Is +infinity, -infinity, Or NaN (Not-a-Number), otherwise it returns True.
    ''' </summary>
    ''' <returns></returns>
    ReadOnly Property IsFinite As Boolean

End Interface
