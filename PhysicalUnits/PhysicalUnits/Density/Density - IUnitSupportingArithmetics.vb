Option Strict On
Option Infer On

Partial Structure Density
    Implements IUnitSupportingArithmetics

    Friend ReadOnly Property SupportedUnitsEnumType As Type Implements IUnit.SupportedUnitsEnumType
        Get
            Return GetType(SupportedDensityUnits)
        End Get
    End Property

    Friend ReadOnly Property DefaultUnit As [Enum] Implements IUnit.DefaultUnit
        Get
            Return SupportedDensityUnits.KilogramsPerCubicmeter
        End Get
    End Property

    Friend Function GetValue(unit As [Enum]) As Double Implements IUnit.GetValue
        Return Value(CType(unit, SupportedDensityUnits))
    End Function

    Private Function IUnit_Create(value As Double, unit As [Enum]) As IUnit Implements IUnit.Create
        Return Create(value, unit)
    End Function

    Friend Function Create(value As Double, unit As [Enum]) As IUnitSupportingArithmetics Implements IUnitSupportingArithmetics.Create
        Dim result = New Density
        result.Value(CType(unit, SupportedDensityUnits)) = value
        Return result
    End Function

    Public ReadOnly Property IsNaN() As Boolean Implements IUnit.IsNaN
        Get
            Return Double.IsNaN(_KilogramsPerCubicmeter)
        End Get
    End Property

    Public ReadOnly Property IsInfinity() As Boolean Implements IUnit.IsInfinity
        Get
            Return Double.IsInfinity(_KilogramsPerCubicmeter)
        End Get
    End Property

    Public ReadOnly Property IsFinite() As Boolean Implements IUnit.IsFinite
        Get
            Return _KilogramsPerCubicmeter.IsFinite
        End Get
    End Property

    Public ReadOnly Property IsPositiveInfinity() As Boolean Implements IUnit.IsPositiveInfinity
        Get
            Return Double.IsPositiveInfinity(_KilogramsPerCubicmeter)
        End Get
    End Property

    Public ReadOnly Property IsNegativeInfinity() As Boolean Implements IUnit.IsNegativeInfinity
        Get
            Return Double.IsNegativeInfinity(_KilogramsPerCubicmeter)
        End Get
    End Property

End Structure