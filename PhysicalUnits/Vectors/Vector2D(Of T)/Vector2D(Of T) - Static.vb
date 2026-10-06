Option Strict On
Option Infer On

Partial Structure Vector2D(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Shared ReadOnly Property Zero() As Vector2D(Of T)
        Get
            Dim k As New T
            Dim z = DirectCast(k.Create(0.0, k.DefaultUnit), T)

            Return New Vector2D(Of T)(x:=z, y:=z)
        End Get
    End Property

    Public Shared ReadOnly Property UnitX() As Vector2D(Of T)
        Get
            Dim k As New T
            Dim one = DirectCast(k.Create(1.0, k.DefaultUnit), T)
            Dim zero = DirectCast(k.Create(0.0, k.DefaultUnit), T)

            Return New Vector2D(Of T)(x:=one, y:=zero)
        End Get
    End Property

    Public Shared ReadOnly Property UnitY() As Vector2D(Of T)
        Get
            Dim k As New T
            Dim one = DirectCast(k.Create(1.0, k.DefaultUnit), T)
            Dim zero = DirectCast(k.Create(0.0, k.DefaultUnit), T)

            Return New Vector2D(Of T)(x:=zero, y:=one)
        End Get
    End Property


    Public Shared ReadOnly Property NegativeUnitX() As Vector2D(Of T)
        Get
            Dim k As New T
            Dim minusone = DirectCast(k.Create(-1.0, k.DefaultUnit), T)
            Dim zero = DirectCast(k.Create(0.0, k.DefaultUnit), T)

            Return New Vector2D(Of T)(x:=minusone, y:=zero)
        End Get
    End Property

    Public Shared ReadOnly Property NegativeUnitY() As Vector2D(Of T)
        Get
            Dim k As New T
            Dim minusone = DirectCast(k.Create(-1.0, k.DefaultUnit), T)
            Dim zero = DirectCast(k.Create(0.0, k.DefaultUnit), T)

            Return New Vector2D(Of T)(x:=zero, y:=minusone)
        End Get
    End Property

End Structure
