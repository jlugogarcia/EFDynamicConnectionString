Public Class Connected_User
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            Label1.Visible = False
            'Checking if user got here by connecting first to the database
            If (CType(Session.Item("IsConnected"), Boolean)) Then
                lbMessage.Visible = True
            Else
                lbMessage.Visible = False
                Label1.Visible = True
                Label1.Text = "Sorry, but you have not follow the proper connection flow."
            End If
        End If
    End Sub


End Class