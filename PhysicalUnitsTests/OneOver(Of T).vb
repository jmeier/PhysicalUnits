Option Strict On
Option Infer On

Imports PhysicalUnits
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Runtime.Serialization.Formatters.Binary

<TestClass()> Public Class OneOverOfT

    <TestMethod()> Public Sub Basic()

        Dim d = Meters(3)
        Dim v1 = OneOver(Of PhysicalUnits.Length).From(d)
        Dim v2 = 1 / d

        Dim f1 = 1 / v1
        Dim f2 = 1 / v2

        Assert.AreEqual(f1, f2)
    End Sub

    <TestMethod()> Public Sub Add()
        Dim a = 5
        Dim b = 3
        Dim va = KilonewtonsPerCubicMeter(a).OneOver
        Dim vb = KilonewtonsPerCubicMeter(b).OneOver
        Assert.AreEqual(expected:=1 / (1 / a + 1 / b), actual:=(va + vb).OneOver.KilonewtonsPerCubicMeter)
    End Sub

    <TestMethod()> Public Sub Subtract()
        Dim a = 5
        Dim b = 3
        Dim va = KilonewtonsPerCubicMeter(a).OneOver
        Dim vb = KilonewtonsPerCubicMeter(b).OneOver
        Assert.AreEqual(expected:=1 / (1 / a - 1 / b), actual:=(va - vb).OneOver.KilonewtonsPerCubicMeter, delta:=1.8 * 10 ^ -15)
    End Sub

    <TestMethod()> Public Sub DivideOneOverByOneOver()
        Dim a = 4
        Dim b = 8
        Dim va = KilonewtonsPerCubicMeter(a).OneOver
        Dim vb = KilonewtonsPerCubicMeter(b).OneOver
        Assert.AreEqual(expected:=b / a, actual:=va / vb)
    End Sub

    <TestMethod()> Public Sub DivideOneOverByDouble()
        Dim a = 4.0
        Dim b = 2.0
        Dim va = KilonewtonsPerCubicMeter(a).OneOver
        Dim vb = b
        Assert.AreEqual(expected:=b * a, actual:=(va / vb).OneOver.KilonewtonsPerCubicMeter)
    End Sub

    <TestMethod()> Public Sub BinarySerialization()
        Dim form As New BinaryFormatter
        Using s As New IO.MemoryStream
            Dim expected = 15.8
            Dim value = Kilonewtons(expected).OneOver

            form.Serialize(s, value)

            s.Seek(0, IO.SeekOrigin.Begin)
            Dim obj = form.Deserialize(s)

            Assert.IsTrue(TypeOf obj Is OneOver(Of PhysicalUnits.Force))

            Dim copy = DirectCast(obj, OneOver(Of PhysicalUnits.Force))
            Assert.AreEqual(value, copy)
        End Using
    End Sub

    <TestMethod()> Public Sub XMLSerialization()
        Using s As New IO.MemoryStream
            Dim expected = 15.8
            Dim value = Kilonewtons(expected).OneOver

            Dim ser = New Xml.Serialization.XmlSerializer(value.GetType)

            ser.Serialize(s, value)

            s.Seek(0, IO.SeekOrigin.Begin)
            Dim obj = ser.Deserialize(s)

            Assert.IsTrue(TypeOf obj Is OneOver(Of PhysicalUnits.Force))

            Dim copy = DirectCast(obj, OneOver(Of PhysicalUnits.Force))
            Assert.AreEqual(value, copy)

        End Using
    End Sub

End Class