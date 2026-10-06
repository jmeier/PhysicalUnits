Option Strict On
Option Infer On

Imports PhysicalUnits
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class Pressure

    <TestMethod()> Public Sub Units_PressureTests()
        Dim p = Pascals(1)
        Assert.AreEqual(p.Pascals, 1.0)
        Assert.AreEqual(p.Bars, 10 ^ -5)
        Assert.AreEqual(p.TechnicalAtmospheres, 1.0197 * 10 ^ -5)
        Assert.AreEqual(p.StandardAtmospheres, 9.8692 * 10 ^ -6)
        Assert.AreEqual(p.Torrs, 7.5006 * 10 ^ -3)
        Assert.AreEqual(p.PoundsPerSquareInch, 1.450377 * 10 ^ -4)

        Assert.AreEqual(PhysicalUnits.Pressure.FromKilogramsPerSquarecentimeter(250).NewtonsPerSquaremeter, 2.452 * 10 ^ 7, 0.001 * 10 ^ 7)

        Dim g_known_NewtonsPerSquaremillimeter = 2.67
        Dim g = NewtonsPerSquaremillimeter(g_known_NewtonsPerSquaremillimeter)
        Assert.AreEqual(g_known_NewtonsPerSquaremillimeter, g.NewtonsPerSquaremillimeter)
        Assert.AreEqual(2670.0, g.KilonewtonsPerSquaremeter)
    End Sub

End Class