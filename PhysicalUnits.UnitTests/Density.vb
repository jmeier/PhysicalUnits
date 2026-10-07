Option Strict On
Option Infer On

Imports System.Runtime.Serialization.Formatters.Binary
Imports PhysicalUnits
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class Density

    <TestMethod()> Public Sub Basic()

        Assert.AreEqual(expected:=GramsPerCubiccentimeter(2.35), actual:=TonsPerCubicmeter(2.35))
        Assert.AreEqual(expected:=GramsPerCubiccentimeter(2.35), actual:=KilogramsPerCubicmeter(2350))

    End Sub

End Class