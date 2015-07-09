Public Class Frm_main

    Private Sub Frm_main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If ConnectDatabase() Then
            Frm_login.ShowDialog()
            If Trim(C_Login.userTypeProperty).Length = 0 Then
                Me.Close()
            End If
        Else
            ConnectDatabase.ShowDialog()
        End If

    End Sub
End Class
