Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports EFDynamicConnectionString

<TestClass()> Public Class TestEFDynamicConnection

    <TestMethod()> Public Sub TestCallingStoredProcedure()
        Dim connection As Boolean = DataAccess.TestConnection()
        Dim expected As Boolean = True

        Assert.AreEqual(expected, connection)
    End Sub

End Class