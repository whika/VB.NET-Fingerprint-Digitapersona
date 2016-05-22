Public NotInheritable Class auth
    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            If txtPassword.Text = "Nutrimax21Lautze" Then
                Auth_Login = "OK"
                MainForm.Show()
                Me.Close()
            End If
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(27) Then
            End
        End If


    End Sub
End Class
