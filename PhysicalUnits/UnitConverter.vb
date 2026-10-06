Option Strict On
Option Infer On

Imports System.ComponentModel

<CLSCompliant(True)>
Public Class UnitConverter : Inherits TypeConverter

    Public Overrides Function CanConvertFrom(context As ITypeDescriptorContext, sourceType As Type) As Boolean
        If sourceType Is GetType(String) Then Return True
        Return MyBase.CanConvertFrom(context, sourceType)
    End Function

    Public Overrides Function ConvertFrom(context As ITypeDescriptorContext, culture As Globalization.CultureInfo, value As Object) As Object
        If value Is Nothing Then Return MyBase.ConvertFrom(context, culture, value)

        If TypeOf value Is String Then
            Dim s = CType(value, String).Trim

            Dim type = context.PropertyDescriptor.PropertyType
            If type.IsGenericType AndAlso type.GetGenericTypeDefinition Is GetType(Double?).GetGenericTypeDefinition Then
                type = type.GetGenericArguments.Single
            End If

            Dim dummy = CType(Activator.CreateInstance(type), IUnit)

            Dim supportedUnits = dummy.SupportedUnitsEnumType.GetEnumValues

            Dim knownSuffixes As New Dictionary(Of String, [Enum])
            For Each item In supportedUnits
                Dim v = CType(item, [Enum])
                Dim s1 = item.ToString
                Dim s2 = UnitSymbolAttribute.GetUnitSymbol(v)
                knownSuffixes.Add(s1, v)
                If s1 <> s2 Then
                    knownSuffixes.Add(s2, v)
                End If
            Next

            For Each item In knownSuffixes
                If Not s.EndsWith(item.Key) Then Continue For
                Dim i = s.Length - item.Key.Length - 1
                If i < 1 Then Continue For
                Dim c = s.Substring(i, 1)
                If "0123456789 ".IndexOf(c) < 0 Then Continue For

                Dim sValue = s.Substring(0, i + 1)
                Dim dvalue = Double.Parse(sValue, culture)
                Return dummy.Create(dvalue, item.Value)
            Next

            Dim plainValue As Double
            Dim b = Double.TryParse(s, Globalization.NumberStyles.Any, culture, plainValue)
            If b Then
                Dim outUnit = dummy.DefaultUnit

                Dim att = context.PropertyDescriptor.Attributes.OfType(Of DefaultDisplayUnitAttribute).SingleOrDefault
                If att IsNot Nothing Then
                    Dim ddu = CType(att, DefaultDisplayUnitAttribute)
                    outUnit = ddu.Unit
                End If

                Return dummy.Create(plainValue, outUnit)
            End If
        End If

        Return MyBase.ConvertFrom(context, culture, value)
    End Function


    Public Overrides Function CanConvertTo(context As ITypeDescriptorContext, destinationType As Type) As Boolean
        If destinationType Is GetType(String) Then Return True
        Return MyBase.CanConvertTo(context, destinationType)
    End Function

    Public Overrides Function ConvertTo(context As ITypeDescriptorContext, culture As Globalization.CultureInfo, value As Object, destinationType As Type) As Object
        If value Is Nothing OrElse TypeOf value IsNot IUnit Then Return MyBase.ConvertTo(context, culture, value, destinationType)

        If destinationType Is GetType(String) Then
            Dim u = CType(value, IUnit)

            Dim outUnit = u.DefaultUnit

            Dim att = context.PropertyDescriptor.Attributes.OfType(Of DefaultDisplayUnitAttribute).SingleOrDefault
            If att IsNot Nothing Then
                Dim ddu = CType(att, DefaultDisplayUnitAttribute)
                outUnit = ddu.Unit
            End If

            Dim outUnitString = UnitSymbolAttribute.GetUnitSymbol(outUnit)

            Return String.Format("{0} {1}", u.GetValue(outUnit), outUnitString)
        End If
        Return MyBase.ConvertTo(context, culture, value, destinationType)
    End Function

    'Public Overrides Function GetPropertiesSupported(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
    '    Return MyBase.GetPropertiesSupported(context)
    'End Function

    'Public Overrides Function GetProperties(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal value As Object, ByVal attributes() As System.Attribute) As System.ComponentModel.PropertyDescriptorCollection
    '    Return MyBase.GetProperties(context, value, attributes)
    'End Function

End Class