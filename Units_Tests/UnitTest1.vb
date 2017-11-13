Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()>
    Public Sub TestMethod1()
        Dim m As New Units.UnitValue.Distace.Metres(1)
        Assert.IsNotNull(m)
        Assert.IsInstanceOfType(m, GetType(Units.UnitValue.Distace.Metres))
        Assert.AreEqual(Of Decimal)(1, m.Value)
        Assert.AreEqual("1 m", m.ToString)
        Assert.AreEqual("1 metres", m.ToString("U"))
    End Sub

End Class