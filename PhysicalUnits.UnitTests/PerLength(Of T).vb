Option Strict On
Option Infer On

Imports PhysicalUnits
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Runtime.Serialization.Formatters.Binary

<TestClass()> Public Class PerLengthOfT

    <TestMethod()> Public Sub Basic()
        Dim direct_zeroForce = PerLength(Of PhysicalUnits.Force).Zero

        Dim a = Kilonewtons(125)
        Dim m = a.PerRunningMeter

        'Dim zeroForce = PerLength(Of Force).Zero
        'Dim nanForce = PerLength(Of Force).NaN

        'Dim zeroBendingMoment = PerLength(Of TimesLength(Of Force)).Zero
        'Dim nanBendingMoment = PerLength(Of TimesLength(Of Force)).NaN

        Assert.AreEqual(a, m.ValuePerRunningMeter)
        Assert.AreEqual(2.7 * a, (m * 2.7).ValuePerRunningMeter)


        Assert.AreEqual(-a, (-m).ValuePerRunningMeter)
        Assert.AreEqual((-a).Abs, (-m).Abs.ValuePerRunningMeter)

    End Sub

    <TestMethod()> Public Sub BinarySerialization()
        Dim form As New BinaryFormatter
        Using s As New IO.MemoryStream
            Dim expected = 15.8
            Dim value = Kilonewtons(expected).PerRunningMeter

            form.Serialize(s, value)

            s.Seek(0, IO.SeekOrigin.Begin)
            Dim obj = form.Deserialize(s)

            Assert.IsTrue(TypeOf obj Is PerLength(Of PhysicalUnits.Force))

            Dim copy = DirectCast(obj, PerLength(Of PhysicalUnits.Force))
            Assert.AreEqual(value, copy)

        End Using
    End Sub

    <TestMethod()> Public Sub XMLSerialization()
        Using s As New IO.MemoryStream
            Dim expected = 15.8
            Dim value = Kilonewtons(expected).PerRunningMeter

            Dim ser = New Xml.Serialization.XmlSerializer(value.GetType)

            ser.Serialize(s, value)

            s.Seek(0, IO.SeekOrigin.Begin)
            Dim obj = ser.Deserialize(s)

            Assert.IsTrue(TypeOf obj Is PerLength(Of PhysicalUnits.Force))

            Dim copy = DirectCast(obj, PerLength(Of PhysicalUnits.Force))
            Assert.AreEqual(value, copy)

        End Using
    End Sub

End Class