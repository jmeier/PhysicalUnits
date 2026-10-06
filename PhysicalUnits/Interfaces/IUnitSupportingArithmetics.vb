Option Strict On
Option Infer On

Imports System.Runtime.Serialization

<CLSCompliant(True)>
Public Interface IUnitSupportingArithmetics : Inherits IUnit

    Shadows Function Create(value As Double, unit As [Enum]) As IUnitSupportingArithmetics

End Interface
