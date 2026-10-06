Option Strict On
Option Infer On

Partial Structure Vector2D(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    ''' <summary>
    ''' Performs a linear interpolation between two vectors based on the given weighting.
    ''' </summary>
    ''' <param name="item1"> The first vector. </param>
    ''' <param name="item2"> The second vector. </param>
    ''' <param name="factor"> A value between 0 and 1 that indicates the weight. </param>
    ''' <returns> The interpolated vector. </returns>
    Public Shared Function Lerp(item1 As Vector2D(Of T), item2 As Vector2D(Of T), factor As Double) As Vector2D(Of T)

        Dim unit = item1.X.DefaultUnit

        Dim x1 = item1.X.GetValue(unit)
        Dim y1 = item1.Y.GetValue(unit)

        Dim x2 = item2.X.GetValue(unit)
        Dim y2 = item2.Y.GetValue(unit)

        Return New Vector2D(Of T)(
            x:=CType(item1.X.Create(x1 + (x2 - x1) * factor, unit), T),
            y:=CType(item1.X.Create(y1 + (y2 - y1) * factor, unit), T))

    End Function

End Structure
