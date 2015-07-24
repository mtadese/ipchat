Public Class AboutForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        frmIPChat.Enabled = True
        frmIPChat.Focus()

    End Sub

 
End Class