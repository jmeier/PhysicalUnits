Option Strict On
Option Infer On

Imports System.Runtime.Serialization.Formatters.Binary
Imports PhysicalUnits
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class Force

    <TestMethod()> Public Shadows Sub ToString()
        Assert.AreEqual(Newtons(3).ToString, "3 N")
        Assert.AreEqual(Newtons(30).ToString, "30 N")
        Assert.AreEqual(Newtons(300).ToString, "300 N")
        Assert.AreEqual(Newtons(3000).ToString, "3 kN")
        Assert.AreEqual(Newtons(30000).ToString, "30 kN")
        Assert.AreEqual(Newtons(300000).ToString, "300 kN")
        Assert.AreEqual(Newtons(3000000).ToString, "3 MN")
        Assert.AreEqual(Newtons(30000000).ToString, "30 MN")
    End Sub

End Class