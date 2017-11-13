Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Units.UnitValue.Distance

<TestClass, TestCategory("Millimetres")>
Public Class UnitValue_MilliMetres_Tests

    <TestMethod, TestCategory("UnitValue")>
    Public Sub UnitValue_MilliMetres()
        Dim m As New Millimetres(1)
        Assert.IsNotNull(m)
        Assert.IsInstanceOfType(m, GetType(Millimetres))
        Assert.AreEqual(Of Decimal)(1, m.Value)
        Assert.AreEqual("1 mm", m.ToString)
        Assert.AreEqual("1 millimetres", m.ToString("U"))
    End Sub
    <TestMethod, TestCategory("UnitValue")>
    Public Sub To_UnitValue_Millimetres()
        Dim m As Millimetres = 1
        Assert.IsNotNull(m)
        Assert.IsInstanceOfType(m, GetType(Millimetres))
        Assert.AreEqual(Of Decimal)(1, m.Value)
        Assert.AreEqual("1 mm", m.ToString)
        Assert.AreEqual("1 millimetres", m.ToString("U"))
    End Sub
    <TestMethod, TestCategory("Comparisions")>
    Public Sub Comparisions_EQ()
        Dim m0 As New Millimetres(1)
        Dim m1 As New Millimetres(1)
        Assert.IsTrue(m0 = m1)
    End Sub
    <TestMethod, TestCategory("Comparisions")>
    Public Sub Comparisions_NE()
        Dim m0 As New Millimetres(1)
        Dim m1 As New Millimetres(2)
        Assert.IsTrue(m0 <> m1)
    End Sub
    <TestMethod, TestCategory("Comparisions")>
    Public Sub Comparisions_GE()
        Dim m0 As New Millimetres(1)
        Dim m1 As New Millimetres(2)
        Assert.IsTrue(m1 >= m0)
    End Sub
    <TestMethod, TestCategory("Comparisions")>
    Public Sub Comparisions_LE()
        Dim m0 As New Millimetres(1)
        Dim m1 As New Millimetres(2)
        Assert.IsTrue(m0 <= m1)
    End Sub
    <TestMethod, TestCategory("Comparisions")>
    Public Sub Comparisions_GT()
        Dim m0 As New Millimetres(1)
        Dim m1 As New Millimetres(2)
        Assert.IsTrue(m1 > m0)
    End Sub
    <TestMethod, TestCategory("Comparisions")>
    Public Sub Comparisions_LT()
        Dim m0 As New Millimetres(1)
        Dim m1 As New Millimetres(2)
        Assert.IsTrue(m0 < m1)
    End Sub
End Class