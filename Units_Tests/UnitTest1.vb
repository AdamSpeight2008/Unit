Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class UnitTest2

    <TestMethod>
    Public Sub TestMethod1()
        Dim m As Units.UnitValue.Distance.Metres = 1
        Dim mm As Units.UnitValue.Distance.Millimetres = 10
        Dim As_m As Units.UnitValue.Distance.Metres = m + CType(mm, Units.UnitValue.Distance.Metres)
        Dim As_mm As Units.UnitValue.Distance.Millimetres = CType(m, Units.UnitValue.Distance.Millimetres) + mm
        Assert.IsTrue(As_m.Value = 1.01)
        Assert.IsTrue(As_m.Units.Symbol = "m")
        Assert.IsTrue(As_mm.Value = 1010)
        Assert.IsTrue(As_mm.Units.Symbol = "mm")
    End Sub

End Class