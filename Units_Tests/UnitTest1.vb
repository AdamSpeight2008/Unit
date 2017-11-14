Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Units.UnitValue

<TestClass>
Public Class UnitTest2

    <TestMethod>
    Public Sub TestMethod1()
        Dim m As Distance.Metres = 1
        Dim mm As Distance.Millimetres = 10
        Dim As_m As Distance.Metres = m + CType(mm, Distance.Metres)
        Dim As_mm As Distance.Millimetres = CType(m, Distance.Millimetres) + mm
        Assert.IsTrue(As_m.Value = 1.01)
        Assert.IsTrue(As_m.Units.Symbol = "m")
        Assert.IsTrue(As_mm.Value = 1010)
        Assert.IsTrue(As_mm.Units.Symbol = "mm")
        Dim sec As Time.Seconds = 1
        Dim min As Time.Minutes = 60
    End Sub

End Class