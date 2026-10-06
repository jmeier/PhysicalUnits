Option Strict On
Option Infer On

Partial Structure PerVolume(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})
    Implements IUnitSupportingArithmetics

    Friend ReadOnly Property SupportedUnitsEnumType As Type Implements IUnit.SupportedUnitsEnumType
        Get
            Return _ValuePerCubicemeter.SupportedUnitsEnumType
        End Get
    End Property

    Friend ReadOnly Property DefaultUnit As [Enum] Implements IUnit.DefaultUnit
        Get
            Return _ValuePerCubicemeter.DefaultUnit
        End Get
    End Property

    Friend Function GetValue(unit As [Enum]) As Double Implements IUnit.GetValue
        Return _ValuePerCubicemeter.GetValue(unit)
    End Function

    Private Function IUnit_Create(value As Double, unit As [Enum]) As IUnit Implements IUnit.Create
        Return Create(value, unit)
    End Function

    Friend Function Create(value As Double, unit As [Enum]) As IUnitSupportingArithmetics Implements IUnitSupportingArithmetics.Create
        Return New PerVolume(Of T) With {._ValuePerCubicemeter = CType(_ValuePerCubicemeter.Create(value, unit), T)}
    End Function

    Public ReadOnly Property IsNaN() As Boolean Implements IUnit.IsNaN
        Get
            Return Double.IsNaN(_ValuePerCubicemeter.GetValue(_ValuePerCubicemeter.DefaultUnit))
        End Get
    End Property

    Public ReadOnly Property IsInfinity() As Boolean Implements IUnit.IsInfinity
        Get
            Return Double.IsInfinity(_ValuePerCubicemeter.GetValue(_ValuePerCubicemeter.DefaultUnit))
        End Get
    End Property

    Public ReadOnly Property IsFinite() As Boolean Implements IUnit.IsFinite
        Get
            Return _ValuePerCubicemeter.GetValue(_ValuePerCubicemeter.DefaultUnit).IsFinite
        End Get
    End Property

    Public ReadOnly Property IsPositiveInfinity() As Boolean Implements IUnit.IsPositiveInfinity
        Get
            Return Double.IsPositiveInfinity(_ValuePerCubicemeter.GetValue(_ValuePerCubicemeter.DefaultUnit))
        End Get
    End Property

    Public ReadOnly Property IsNegativeInfinity() As Boolean Implements IUnit.IsNegativeInfinity
        Get
            Return Double.IsNegativeInfinity(_ValuePerCubicemeter.GetValue(_ValuePerCubicemeter.DefaultUnit))
        End Get
    End Property

End Structure