Public Class Form1

    Private Sub txt_password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_password.TextChanged
        If Me.txt_password.Text = "tellmesecret" Then
            Me.Visible = False
            Form2.Show()
        End If
    End Sub

    Private Sub lbl_statistics_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_statistics.MouseDoubleClick
        Me.tmr_close.Enabled = False
        Me.lbl_statistics.Visible = False
        Me.txt_password.Visible = True
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.statistics = Me.txt_statistics.Text
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txt_statistics.Text = My.Settings.statistics
        Me.txt_statistics.Text += vbCrLf + Now
    End Sub

    Private Sub tmr_close_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_close.Tick
        Me.Close()
    End Sub
End Class
