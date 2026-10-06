Option Strict On
Option Infer On

Partial Structure LengthPow4
    Implements IUnitSupportingArithmetics

    Friend ReadOnly Property SupportedUnitsEnumType As Type Implements IUnit.SupportedUnitsEnumType
        Get
            Return GetType(SupportedLengthPow4Units)
        End Get
    End Property

    Friend ReadOnly Property DefaultUnit As [Enum] Implements IUnit.DefaultUnit
        Get
            Return SupportedLengthPow4Units.MetersPow4
        End Get
    End Property

    Friend Function GetValue(unit As [Enum]) As Double Implements IUnit.GetValue
        Return Value(CType(unit, SupportedLengthPow4Units))
    End Function

    Private Function IUnit_Create(value As Double, unit As [Enum]) As IUnit Implements IUnit.Create
        Return Create(value, unit)
    End Function

    Friend Function Create(value As Double, unit As [Enum]) As IUnitSupportingArithmetics Implements IUnitSupportingArithmetics.Create
        Dim result = New LengthPow4
        result.Value(CType(unit, SupportedLengthPow4Units)) = value
        Return result
    End Function

    Public ReadOnly Property IsNaN() As Boolean Implements IUnit.IsNaN
        Get
            Return Double.IsNaN(_MetersPow4)
        End Get
    End Property

    Public ReadOnly Property IsInfinity() As Boolean Implements IUnit.IsInfinity
        Get
            Return Double.IsInfinity(_MetersPow4)
        End Get
    End Property

    Public ReadOnly Property IsFinite() As Boolean Implements IUnit.IsFinite
        Get
            Return _MetersPow4.IsFinite
        End Get
    End Property

    Public ReadOnly Property IsPositiveInfinity() As Boolean Implements IUnit.IsPositiveInfinity
        Get
            Return Double.IsPositiveInfinity(_MetersPow4)
        End Get
    End Property

    Public ReadOnly Property IsNegativeInfinity() As Boolean Implements IUnit.IsNegativeInfinity
        Get
            Return Double.IsNegativeInfinity(_MetersPow4)
        End Get
    End Property

End Structure