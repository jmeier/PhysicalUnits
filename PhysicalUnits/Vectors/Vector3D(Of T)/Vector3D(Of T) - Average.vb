Option Strict On
Option Infer On

Partial Structure Vector3D(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    ''' <summary>
    ''' Computes the average of a sequence of ForceVector3D values.
    ''' </summary>
    ''' <param name="item1"> First 3D vector to calculate the average of. </param>
    ''' <param name="item2"> Second 3D vector to calculate the average of. </param>
    ''' <returns> The average of the sequence of values. </returns>
    Public Shared Function Average(item1 As Vector3D(Of T), item2 As Vector3D(Of T)) As Vector3D(Of T)
        Dim unit = item1.X.DefaultUnit

        Dim x1 = item1.X.GetValue(unit)
        Dim y1 = item1.Y.GetValue(unit)
        Dim z1 = item1.Z.GetValue(unit)

        Dim x2 = item2.X.GetValue(unit)
        Dim y2 = item2.Y.GetValue(unit)
        Dim z2 = item2.Z.GetValue(unit)

        Return New Vector3D(Of T)(
            x:=CType(item1.X.Create((x1 + x2) / 2, unit), T),
            y:=CType(item1.X.Create((y1 + y2) / 2, unit), T),
            z:=CType(item1.X.Create((z1 + z2) / 2, unit), T))

    End Function

    ''' <summary>
    ''' Computes the average of a sequence of ForceVector3D values.
    ''' </summary>
    ''' <param name="item1"> First 3D vector to calculate the average of. </param>
    ''' <param name="item2"> Second 3D vector to calculate the average of. </param>
    ''' <param name="item3"> Third 3D vector to calculate the average of. </param>
    ''' <returns> The average of the sequence of values. </returns>
    Public Shared Function Average(item1 As Vector3D(Of T), item2 As Vector3D(Of T), item3 As Vector3D(Of T)) As Vector3D(Of T)
        Dim unit = item1.X.DefaultUnit

        Dim x1 = item1.X.GetValue(unit)
        Dim y1 = item1.Y.GetValue(unit)
        Dim z1 = item1.Z.GetValue(unit)

        Dim x2 = item2.X.GetValue(unit)
        Dim y2 = item2.Y.GetValue(unit)
        Dim z2 = item2.Z.GetValue(unit)

        Dim x3 = item3.X.GetValue(unit)
        Dim y3 = item3.Y.GetValue(unit)
        Dim z3 = item3.Z.GetValue(unit)

        Return New Vector3D(Of T)(
            x:=CType(item1.X.Create((x1 + x2 + x3) / 3, unit), T),
            y:=CType(item1.X.Create((y1 + y2 + y3) / 3, unit), T),
            z:=CType(item1.X.Create((z1 + z2 + z3) / 3, unit), T))

    End Function

    ''' <summary>
    ''' Computes the average of a sequence of ForceVector3D values.
    ''' </summary>
    ''' <param name="item1"> First 3D vector to calculate the average of. </param>
    ''' <param name="item2"> Second 3D vector to calculate the average of. </param>
    ''' <param name="item3"> Third 3D vector to calculate the average of. </param>
    ''' <param name="item4"> Fourth 3D vector to calculate the average of. </param>
    ''' <returns> The average of the sequence of values. </returns>
    Public Shared Function Average(item1 As Vector3D(Of T), item2 As Vector3D(Of T), item3 As Vector3D(Of T), item4 As Vector3D(Of T)) As Vector3D(Of T)
        Dim unit = item1.X.DefaultUnit

        Dim x1 = item1.X.GetValue(unit)
        Dim y1 = item1.Y.GetValue(unit)
        Dim z1 = item1.Z.GetValue(unit)

        Dim x2 = item2.X.GetValue(unit)
        Dim y2 = item2.Y.GetValue(unit)
        Dim z2 = item2.Z.GetValue(unit)

        Dim x3 = item3.X.GetValue(unit)
        Dim y3 = item3.Y.GetValue(unit)
        Dim z3 = item3.Z.GetValue(unit)

        Dim x4 = item4.X.GetValue(unit)
        Dim y4 = item4.Y.GetValue(unit)
        Dim z4 = item4.Z.GetValue(unit)

        Return New Vector3D(Of T)(
            x:=CType(item1.X.Create((x1 + x2 + x3 + x4) / 4, unit), T),
            y:=CType(item1.X.Create((y1 + y2 + y3 + y4) / 4, unit), T),
            z:=CType(item1.X.Create((z1 + z2 + z3 + z4) / 4, unit), T))
    End Function

    ''' <summary>
    ''' Computes the average of a sequence of ForceVector3D values.
    ''' </summary>
    ''' <param name="item1"> First 3D vector to calculate the average of. </param>
    ''' <param name="item2"> Second 3D vector to calculate the average of. </param>
    ''' <param name="item3"> Third 3D vector to calculate the average of. </param>
    ''' <param name="item4"> Fourth 3D vector to calculate the average of. </param>
    ''' <param name="item5"> Fifth 3D vector to calculate the average of. </param>
    ''' <returns> The average of the sequence of values. </returns>
    Public Shared Function Average(item1 As Vector3D(Of T), item2 As Vector3D(Of T), item3 As Vector3D(Of T), item4 As Vector3D(Of T), item5 As Vector3D(Of T)) As Vector3D(Of T)
        Dim unit = item1.X.DefaultUnit

        Dim x1 = item1.X.GetValue(unit)
        Dim y1 = item1.Y.GetValue(unit)
        Dim z1 = item1.Z.GetValue(unit)

        Dim x2 = item2.X.GetValue(unit)
        Dim y2 = item2.Y.GetValue(unit)
        Dim z2 = item2.Z.GetValue(unit)

        Dim x3 = item3.X.GetValue(unit)
        Dim y3 = item3.Y.GetValue(unit)
        Dim z3 = item3.Z.GetValue(unit)

        Dim x4 = item4.X.GetValue(unit)
        Dim y4 = item4.Y.GetValue(unit)
        Dim z4 = item4.Z.GetValue(unit)

        Dim x5 = item5.X.GetValue(unit)
        Dim y5 = item5.Y.GetValue(unit)
        Dim z5 = item5.Z.GetValue(unit)

        Return New Vector3D(Of T)(
            x:=CType(item1.X.Create((x1 + x2 + x3 + x4 + x5) / 5, unit), T),
            y:=CType(item1.X.Create((y1 + y2 + y3 + y4 + y5) / 5, unit), T),
            z:=CType(item1.X.Create((z1 + z2 + z3 + z4 + z5) / 5, unit), T))
    End Function

    ''' <summary>
    ''' Computes the average of a sequence of ForceVector3D values.
    ''' </summary>
    ''' <param name="items"> Parameter array of 3D vectors to calculate the average of. </param>
    ''' <returns> The average of the sequence of values. </returns>
    ''' <exception cref="System.ArgumentNullException"> <paramref name="items"/> is null. </exception>
    ''' <exception cref="System.InvalidOperationException"> <paramref name="items"/> contains no elements. </exception>
    Public Shared Function Average(ParamArray items() As Vector3D(Of T)) As Vector3D(Of T)
        If items Is Nothing Then Throw New ArgumentNullException(NameOf(items))

        Dim n As Integer = 0
        Dim unit As [Enum] = Nothing, create As Func(Of Double, [Enum], IUnitSupportingArithmetics) = Nothing
        Dim x = 0.0
        Dim y = 0.0
        Dim z = 0.0
        For Each i In items
            n += 1
            If n = 1 Then
                unit = i.X.DefaultUnit
                create = AddressOf i.X.Create
            End If
            x += i._X.GetValue(unit)
            y += i._Y.GetValue(unit)
            z += i._Z.GetValue(unit)
        Next

        If n > 0 Then
            Return New Vector3D(Of T)(
            x:=CType(create(x / n, unit), T),
            y:=CType(create(y / n, unit), T),
            z:=CType(create(z / n, unit), T))
        Else
            'throw InvalidOperationException to be consistent with
            'https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.average?view=netframework-4.8#System_Linq_Enumerable_Average_System_Collections_Generic_IEnumerable_System_Int32__
            Throw New InvalidOperationException("Parameter array contains no elements.")
        End If
    End Function

    ''' <summary>
    ''' Computes the average of a sequence of ForceVector3D values.
    ''' </summary>
    ''' <param name="items"> Enumeration of 3D vectors to calculate the average of. </param>
    ''' <returns> The average of the sequence of values. </returns>
    ''' <exception cref="System.ArgumentNullException"> <paramref name="items"/> is null. </exception>
    ''' <exception cref="System.InvalidOperationException"> <paramref name="items"/> contains no elements. </exception>
    Public Shared Function Average(items As IEnumerable(Of Vector3D(Of T))) As Vector3D(Of T)
        If items Is Nothing Then Throw New ArgumentNullException(NameOf(items))

        Dim n As Integer = 0
        Dim unit As [Enum] = Nothing, create As Func(Of Double, [Enum], IUnitSupportingArithmetics) = Nothing
        Dim x = 0.0
        Dim y = 0.0
        Dim z = 0.0
        For Each i In items
            n += 1
            If n = 1 Then
                unit = i.X.DefaultUnit
                create = AddressOf i.X.Create
            End If
            x += i._X.GetValue(unit)
            y += i._Y.GetValue(unit)
            z += i._Z.GetValue(unit)
        Next

        If n > 0 Then
            Return New Vector3D(Of T)(
            x:=CType(create(x / n, unit), T),
            y:=CType(create(y / n, unit), T),
            z:=CType(create(z / n, unit), T))
        Else
            'throw InvalidOperationException to be consistent with
            'https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.average?view=netframework-4.8#System_Linq_Enumerable_Average_System_Collections_Generic_IEnumerable_System_Int32__
            Throw New InvalidOperationException("Parameter array contains no elements.")
        End If
    End Function

End Structure
