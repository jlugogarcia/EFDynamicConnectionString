Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then

            lb_Message.Visible = False

        End If
    End Sub

    Protected Sub btn_TestConn_Click(sender As Object, e As EventArgs) Handles btn_TestConn.Click
        Try

            Dim success = DataAccess.TestConnection()

            Session("IsConnected") = success

            If (success) Then
                Response.Redirect("~/Connected_User.aspx", False)
            Else
                lb_Message.Text = "Connection not succeded. :( "
            End If

        Catch ex As Exception
            lb_Message.Text = ex.Message

        End Try
    End Sub
End Class