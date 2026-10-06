Option Strict On
Option Infer On

Partial Structure OneOver(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})
    Implements IUnitSupportingArithmetics

    Public ReadOnly Property IsNaN() As Boolean Implements IUnit.IsNaN
        Get
            Return Double.IsNaN(_OneOverValue.GetValue(_OneOverValue.DefaultUnit))
        End Get
    End Property

    Public ReadOnly Property IsInfinity() As Boolean Implements IUnit.IsInfinity
        Get
            Return Double.IsInfinity(_OneOverValue.GetValue(_OneOverValue.DefaultUnit))
        End Get
    End Property

    Public ReadOnly Property IsFinite() As Boolean Implements IUnit.IsFinite
        Get
            Return _OneOverValue.GetValue(_OneOverValue.DefaultUnit).IsFinite
        End Get
    End Property

    Public ReadOnly Property IsPositiveInfinity() As Boolean Implements IUnit.IsPositiveInfinity
        Get
            Return Double.IsPositiveInfinity(_OneOverValue.GetValue(_OneOverValue.DefaultUnit))
        End Get
    End Property

    Public ReadOnly Property IsNegativeInfinity() As Boolean Implements IUnit.IsNegativeInfinity
        Get
            Return Double.IsNegativeInfinity(_OneOverValue.GetValue(_OneOverValue.DefaultUnit))
        End Get
    End Property

    Friend ReadOnly Property SupportedUnitsEnumType As Type Implements IUnit.SupportedUnitsEnumType
        Get
            Return _OneOverValue.SupportedUnitsEnumType
        End Get
    End Property

    Friend ReadOnly Property DefaultUnit As [Enum] Implements IUnit.DefaultUnit
        Get
            Return _OneOverValue.DefaultUnit
        End Get
    End Property

    Friend Function GetValue(unit As [Enum]) As Double Implements IUnit.GetValue
        Return _OneOverValue.GetValue(unit)
    End Function

    Private Function IUnit_Create(value As Double, unit As [Enum]) As IUnit Implements IUnit.Create
        Return Create(value, unit)
    End Function

    Friend Function Create(value As Double, unit As [Enum]) As IUnitSupportingArithmetics Implements IUnitSupportingArithmetics.Create
        Return New OneOver(Of T) With {._OneOverValue = CType(_OneOverValue.Create(value, unit), T)}
    End Function

End Structure