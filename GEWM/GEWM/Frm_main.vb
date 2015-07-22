Public Class Frm_main

    Private Sub Frm_main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If ConnectDatabase() Then
            Frm_login.ShowDialog()
            If Trim(C_login.userTypeProperty).Length = 0 Then
                Me.Close()
            End If
        Else
            ConnectDatabase.ShowDialog()
        End If

    End Sub

    Private Sub Btn_officer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_officer.Click
        Frm_officer.MdiParent = Me
        Frm_officer.Show()
        Frm_officer.Focus()
    End Sub

    Private Sub NavBarItem_exit_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem_exit.LinkClicked
        If MessageBox.Show("คุณต้องการออกจากโปรแกรม?", " Message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub
End Class
