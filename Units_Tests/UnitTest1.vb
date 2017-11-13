Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod(), TestCategory("UnitValue")>
    Public Sub UnitValue_Metres()
        Dim m As New Units.UnitValue.Distace.Metres(1)
        Assert.IsNotNull(m)
        Assert.IsInstanceOfType(m, GetType(Units.UnitValue.Distace.Metres))
        Assert.AreEqual(Of Decimal)(1, m.Value)
        Assert.AreEqual("1 m", m.ToString)
        Assert.AreEqual("1 metres", m.ToString("U"))
    End Sub

    <TestMethod(), TestCategory("Comparisions")>
    Public Sub Comparisions_EQ()
        Dim m0 As New Units.UnitValue.Distace.Metres(1)
        Dim m1 As New Units.UnitValue.Distace.Metres(1)
        Assert.IsTrue(m0 = m1)
    End Sub
    <TestMethod(), TestCategory("Comparisions")>
    Public Sub Comparisions_NE()
        Dim m0 As New Units.UnitValue.Distace.Metres(1)
        Dim m1 As New Units.UnitValue.Distace.Metres(2)
        Assert.IsTrue(m0 <> m1)
    End Sub
    <TestMethod(), TestCategory("Comparisions")>
    Public Sub Comparisions_GE()
        Dim m0 As New Units.UnitValue.Distace.Metres(1)
        Dim m1 As New Units.UnitValue.Distace.Metres(2)
        Assert.IsTrue(m1 >= m0)
    End Sub
    <TestMethod(), TestCategory("Comparisions")>
    Public Sub Comparisions_LE()
        Dim m0 As New Units.UnitValue.Distace.Metres(1)
        Dim m1 As New Units.UnitValue.Distace.Metres(2)
        Assert.IsTrue(m0 <= m1)
    End Sub
    <TestMethod(), TestCategory("Comparisions")>
    Public Sub Comparisions_GT()
        Dim m0 As New Units.UnitValue.Distace.Metres(1)
        Dim m1 As New Units.UnitValue.Distace.Metres(2)
        Assert.IsTrue(m1 > m0)
    End Sub
    <TestMethod(), TestCategory("Comparisions")>
    Public Sub Comparisions_LT()
        Dim m0 As New Units.UnitValue.Distace.Metres(1)
        Dim m1 As New Units.UnitValue.Distace.Metres(2)
        Assert.IsTrue(m0 < m1)
    End Sub
End Class