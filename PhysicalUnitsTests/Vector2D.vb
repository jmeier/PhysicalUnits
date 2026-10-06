Option Strict On
Option Infer On

Imports System.Runtime.Serialization.Formatters.Binary
Imports PhysicalUnits
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class Vector2D

    <TestMethod()> Public Sub Basic()
        Dim x = Meters(2)
        Dim y = Meters(5)
        Dim v1 = Vector.Create(x, y)
        Dim v2 = Vector.Create(x, y)

        Assert.AreEqual(v1, v2)
        Assert.AreEqual(v1 + v2, v2 * 2)
        Assert.AreEqual(2 * v1 - v2, v2)
        Assert.AreEqual(v1.Magnitude, (x.Pow2 + y.Pow2).Sqrt)
    End Sub

    <TestMethod()> Public Sub BinarySerialization()
        Dim form As New BinaryFormatter
        Using s As New IO.MemoryStream
            Dim expectedX = 15.8
            Dim expectedY = -98.1
            Dim l = New Vector2D(Of PhysicalUnits.Force)(x:=Kilonewtons(expectedX), y:=Kilonewtons(expectedY))

            form.Serialize(s, l)

            s.Seek(0, IO.SeekOrigin.Begin)
            Dim obj = form.Deserialize(s)

            Assert.IsTrue(TypeOf obj Is Vector2D(Of PhysicalUnits.Force))

            Dim copy = DirectCast(obj, Vector2D(Of PhysicalUnits.Force))
            Assert.AreEqual(l, copy)

        End Using
    End Sub

    <TestMethod()> Public Sub XMLSerialization()
        Using s As New IO.MemoryStream
            Dim expectedX = 15.8
            Dim expectedY = -98.1
            Dim l = New Vector2D(Of PhysicalUnits.Force)(x:=Kilonewtons(expectedX), y:=Kilonewtons(expectedY))

            Dim ser = New Xml.Serialization.XmlSerializer(l.GetType)

            ser.Serialize(s, l)

            s.Seek(0, IO.SeekOrigin.Begin)
            Dim obj = ser.Deserialize(s)

            Assert.IsTrue(TypeOf obj Is Vector2D(Of PhysicalUnits.Force))

            Dim copy = DirectCast(obj, Vector2D(Of PhysicalUnits.Force))
            Assert.AreEqual(l, copy)

        End Using
    End Sub

End Class