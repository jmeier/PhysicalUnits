Option Strict On
Option Infer On

Imports PhysicalUnits
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Runtime.Serialization.Formatters.Binary

<TestClass()> Public Class PerVolumeOfT

    <TestMethod()> Public Sub Basic()
        Dim m = Meganewtons(5) / CubicMeters(2)
        Assert.AreEqual(m.MeganewtonsPerCubicMeter, 2.5)
        Assert.AreEqual(m.KilonewtonsPerCubicMeter, 2500.0)
        Assert.AreEqual(m.NewtonsPerCubicMeter, 2500000.0)
    End Sub

    <TestMethod()> Public Sub Add()
        Dim a = KilonewtonsPerCubicMeter(5)
        Dim b = KilonewtonsPerCubicMeter(3)
        Assert.AreEqual(expected:=KilonewtonsPerCubicMeter(5 + 3), actual:=a + b)
    End Sub

    <TestMethod()> Public Sub Subtract()
        Dim a = KilonewtonsPerCubicMeter(5)
        Dim b = KilonewtonsPerCubicMeter(3)
        Assert.AreEqual(expected:=KilonewtonsPerCubicMeter(5 - 3), actual:=a - b)
    End Sub

    <TestMethod()> Public Sub MultiplyByArea()
        Dim fpv = New PerVolume(Of PhysicalUnits.Force)(valuePerCubicmeter:=Kilonewtons(5))
        Dim a = Squaremeters(5)
        Assert.AreEqual(expected:=KilonewtonsPerMeter(5 * 5), actual:=fpv * a)
    End Sub

    <TestMethod()> Public Sub BinarySerialization()
        Dim form As New BinaryFormatter
        Using s As New IO.MemoryStream
            Dim expected = 15.8
            Dim value = KilonewtonsPerCubicMeter(expected)

            form.Serialize(s, value)

            s.Seek(0, IO.SeekOrigin.Begin)
            Dim obj = form.Deserialize(s)

            Assert.IsTrue(TypeOf obj Is PerVolume(Of PhysicalUnits.Force))

            Dim copy = DirectCast(obj, PerVolume(Of PhysicalUnits.Force))
            Assert.AreEqual(value, copy)
        End Using
    End Sub

    <TestMethod()> Public Sub XMLSerialization()
        Using s As New IO.MemoryStream
            Dim expected = 15.8
            Dim value = KilonewtonsPerCubicMeter(expected)

            Dim ser = New Xml.Serialization.XmlSerializer(value.GetType)

            ser.Serialize(s, value)

            s.Seek(0, IO.SeekOrigin.Begin)
            Dim obj = ser.Deserialize(s)

            Assert.IsTrue(TypeOf obj Is PerVolume(Of PhysicalUnits.Force))

            Dim copy = DirectCast(obj, PerVolume(Of PhysicalUnits.Force))
            Assert.AreEqual(value, copy)

        End Using
    End Sub

End Class