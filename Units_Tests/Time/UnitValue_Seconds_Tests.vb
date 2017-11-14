Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Units.UnitValue.Time

<TestClass, TestCategory("Seconds")>
Public Class UnitValue_Seconds_Tests

    <TestMethod, TestCategory("UnitValue")>
    Public Sub UnitValue_Seconds()
        Dim m As New Seconds(1)
        Assert.IsNotNull(m)
        Assert.IsInstanceOfType(m, GetType(Seconds))
        Assert.AreEqual(Of Decimal)(1, m.Value)
        Assert.AreEqual("1 s", m.ToString)
        Assert.AreEqual("1 seconds", m.ToString("U"))
    End Sub
    <TestMethod, TestCategory("UnitValue")>
    Public Sub To_UnitValue_Metres()
        Dim m As Seconds = 1
        Assert.IsNotNull(m)
        Assert.IsInstanceOfType(m, GetType(Seconds))
        Assert.AreEqual(Of Decimal)(1, m.Value)
        Assert.AreEqual("1 s", m.ToString)
        Assert.AreEqual("1 seconds", m.ToString("U"))
    End Sub
    <TestMethod, TestCategory("Comparisions")>
    Public Sub Comparisions_EQ()
        Dim m0 As New Seconds(1)
        Dim m1 As New Seconds(1)
        Assert.IsTrue(m0 = m1)
    End Sub
    <TestMethod, TestCategory("Comparisions")>
    Public Sub Comparisions_NE()
        Dim m0 As New Seconds(1)
        Dim m1 As New Seconds(2)
        Assert.IsTrue(m0 <> m1)
    End Sub
    <TestMethod, TestCategory("Comparisions")>
    Public Sub Comparisions_GE()
        Dim m0 As New Seconds(1)
        Dim m1 As New Seconds(2)
        Assert.IsTrue(m1 >= m0)
    End Sub
    <TestMethod, TestCategory("Comparisions")>
    Public Sub Comparisions_LE()
        Dim m0 As New Seconds(1)
        Dim m1 As New Seconds(2)
        Assert.IsTrue(m0 <= m1)
    End Sub
    <TestMethod, TestCategory("Comparisions")>
    Public Sub Comparisions_GT()
        Dim m0 As New Seconds(1)
        Dim m1 As New Seconds(2)
        Assert.IsTrue(m1 > m0)
    End Sub
    <TestMethod, TestCategory("Comparisions")>
    Public Sub Comparisions_LT()
        Dim m0 As New Seconds(1)
        Dim m1 As New Seconds(2)
        Assert.IsTrue(m0 < m1)
    End Sub
End Class