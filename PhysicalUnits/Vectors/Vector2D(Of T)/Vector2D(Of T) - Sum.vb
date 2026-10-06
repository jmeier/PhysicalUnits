Option Strict On
Option Infer On

Partial Structure Vector2D(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    ''' <summary>
    ''' Computes the sum of a sequence of ForceVector2D values.
    ''' </summary>
    ''' <param name="item1"> First 2D vector to calculate the sum of. </param>
    ''' <param name="item2"> Second 2D vector to calculate the sum of. </param>
    ''' <returns> The sum of the sequence of values. </returns>
    Public Shared Function Sum(item1 As Vector2D(Of T), item2 As Vector2D(Of T)) As Vector2D(Of T)
        Return item1 + item2
    End Function

    ''' <summary>
    ''' Computes the sum of a sequence of ForceVector2D values.
    ''' </summary>
    ''' <param name="items"> Parameter array of 2D vectors to calculate the sum of. </param>
    ''' <returns> The sum of the sequence of values. </returns>
    ''' <exception cref="System.ArgumentNullException"> <paramref name="items"/> is null. </exception>
    Public Shared Function Sum(ParamArray items() As Vector2D(Of T)) As Vector2D(Of T)
        If items Is Nothing Then Throw New ArgumentNullException(NameOf(items))

        Dim unit As [Enum] = Nothing, create As Func(Of Double, [Enum], IUnitSupportingArithmetics) = Nothing
        Dim x = 0.0
        Dim y = 0.0
        For Each i In items
            If create Is Nothing Then
                unit = i.X.DefaultUnit
                create = AddressOf i.X.Create
            End If
            x += i._X.GetValue(unit)
            y += i._Y.GetValue(unit)
        Next

        Return New Vector2D(Of T)(
            x:=CType(create(x, unit), T),
            y:=CType(create(y, unit), T))

    End Function

    ''' <summary>
    ''' Computes the sum of a sequence of ForceVector2D values.
    ''' </summary>
    ''' <param name="items"> Enumeration of 2D vectors to calculate the sum of. </param>
    ''' <returns> The sum of the sequence of values. </returns>
    ''' <exception cref="System.ArgumentNullException"> <paramref name="items"/> is null. </exception>
    Public Shared Function Sum(items As IEnumerable(Of Vector2D(Of T))) As Vector2D(Of T)
        If items Is Nothing Then Throw New ArgumentNullException(NameOf(items))

        Dim unit As [Enum] = Nothing, create As Func(Of Double, [Enum], IUnitSupportingArithmetics) = Nothing
        Dim x = 0.0
        Dim y = 0.0
        For Each i In items
            If create Is Nothing Then
                unit = i.X.DefaultUnit
                create = AddressOf i.X.Create
            End If
            x += i._X.GetValue(unit)
            y += i._Y.GetValue(unit)
        Next

        Return New Vector2D(Of T)(
            x:=CType(create(x, unit), T),
            y:=CType(create(y, unit), T))

    End Function


End Structure
