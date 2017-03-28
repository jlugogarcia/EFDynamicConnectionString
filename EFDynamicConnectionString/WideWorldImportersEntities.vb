Imports System.Data.Entity

Partial Public Class WideWorldImportersEntities
    Inherits DbContext
    Public Sub New(ByVal connString As String)
        MyBase.New(connString)
    End Sub
End Class
