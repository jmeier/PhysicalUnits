Option Strict On
Option Infer On

Partial Structure Vector2D(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Function ScaleAbsolute(length As T) As Vector2D(Of T)
        Dim unit = length.DefaultUnit

        Dim x = Me.X.GetValue(unit)
        Dim y = Me.Y.GetValue(unit)

        Dim l = Math.Sqrt(x ^ 2 + y ^ 2)

        Dim f = length.GetValue(unit) / l

        Return New Vector2D(Of T)(x:=DirectCast(length.Create(x * f, unit), T),
                                  y:=DirectCast(length.Create(y * f, unit), T))
    End Function

End Structure
