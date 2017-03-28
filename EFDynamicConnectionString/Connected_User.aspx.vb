Public Class Connected_User
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then

            'Checking if user got here by connecting first to the database
            If (CType(Session.Item("IsConnected"), Boolean)) Then
                lbMessage.Visible = True
            Else
                lbMessage.Visible = False
            End If
        End If
    End Sub


End Class