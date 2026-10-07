Option Strict On
Option Infer On

Imports System.Runtime.Serialization.Formatters.Binary
Imports PhysicalUnits
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class Length

    <TestMethod()> Public Sub Basic()
        Dim m = Meters(1)
        Assert.AreEqual(m.Centimeters, 100.0)
        Assert.AreEqual(m.Decimeters, 10.0)
        Assert.AreEqual(m.Kilometers, 1 / 1000)
        Assert.AreEqual(m.Millimeters, 1000.0)
        Assert.AreEqual(m.Feet, 3.281, 0.001)
        Assert.AreEqual(m.Inchs, 39.37, 0.001)
        Assert.AreEqual(m.Yards, 1.094, 0.001)

        Assert.AreEqual(Millimeters(3).ToString, "3 mm")
        Assert.AreEqual(Millimeters(30).ToString, "3 cm")
        Assert.AreEqual(Millimeters(300).ToString, "30 cm")
        Assert.AreEqual(Millimeters(3000).ToString, "3 m")
        Assert.AreEqual(Millimeters(30000).ToString, "30 m")
        Assert.AreEqual(Millimeters(300000).ToString, "300 m")
        Assert.AreEqual(Millimeters(3000000).ToString, "3 km")
        Assert.AreEqual(Millimeters(30000000).ToString, "30 km")
    End Sub

    <TestMethod()> Public Sub Add()
        Dim a = Meters(3)
        Dim b = Meters(5)
        Assert.AreEqual(expected:=Meters(3 + 5), actual:=a + b)
    End Sub

    <TestMethod()> Public Sub Subtract()
        Dim a = Meters(3)
        Dim b = Meters(5)
        Assert.AreEqual(expected:=Meters(3 - 5), actual:=a - b)
    End Sub

    <TestMethod()> Public Sub Multiply()
        Dim a = Meters(3)
        Dim b = 5
        Assert.AreEqual(expected:=Meters(3 * 5), actual:=a * b)
    End Sub

    <TestMethod()> Public Sub Divide()
        Dim a = Meters(3)
        Dim b = 5
        Assert.AreEqual(expected:=Meters(3 / 5), actual:=a / b)
    End Sub

    <TestMethod()> Public Sub Parse()
        '2.4sec
        For i = 0 To 100000
            Dim s = "54 m"
            Dim a = PhysicalUnits.Length.Parse(s)
            Assert.AreEqual(expected:=54.0, actual:=a.Meters)
        Next
    End Sub

    <TestMethod()> Public Sub BinarySerialization()
        Dim form As New BinaryFormatter
        Using s As New IO.MemoryStream
            Dim expected = 15.8
            Dim l = Meters(expected)

            form.Serialize(s, l)

            s.Seek(0, IO.SeekOrigin.Begin)
            Dim obj = form.Deserialize(s)

            Assert.IsTrue(TypeOf obj Is PhysicalUnits.Length)

            Dim copy = DirectCast(obj, PhysicalUnits.Length)
            Assert.AreEqual(l, copy)

        End Using
    End Sub

    <TestMethod()> Public Sub XMLSerialization()
        Using s As New IO.MemoryStream
            Dim expected = 15.8
            Dim l = Meters(expected)

            Dim ser = New Xml.Serialization.XmlSerializer(l.GetType)

            ser.Serialize(s, l)

            s.Seek(0, IO.SeekOrigin.Begin)
            Dim obj = ser.Deserialize(s)

            Assert.IsTrue(TypeOf obj Is PhysicalUnits.Length)

            Dim copy = DirectCast(obj, PhysicalUnits.Length)
            Assert.AreEqual(l, copy)

        End Using
    End Sub

    <TestMethod()> Public Sub LengthTimesLengthReturnsArea()
        Dim a = Meters(3)
        Dim b = Meters(5)
        Assert.AreEqual(expected:=Squaremeters(3 * 5), actual:=a * b)
    End Sub

    <TestMethod()> Public Sub LengthTimesAreaReturnsVolume()
        Dim a = Meters(3)
        Dim b = Squaremeters(5)
        Assert.AreEqual(expected:=CubicMeters(3 * 5), actual:=a * b)
    End Sub

End Class