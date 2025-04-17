Public Class Form2

    Private Sub Form2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form1.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txt_statistics.Text = Form1.txt_statistics.Text
    End Sub

    Private Sub tmr_copyright_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_copyright.Tick
        Me.lbl_copyright.Left -= 1
        If Me.lbl_copyright.Left = -135 Then
            Me.lbl_copyright.Left = 290
        End If
    End Sub
End Class