<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.txt_password = New System.Windows.Forms.TextBox
        Me.txt_statistics = New System.Windows.Forms.TextBox
        Me.lbl_statistics = New System.Windows.Forms.Label
        Me.tmr_close = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.Color.Black
        Me.txt_password.ForeColor = System.Drawing.Color.White
        Me.txt_password.Location = New System.Drawing.Point(12, 9)
        Me.txt_password.MaxLength = 12
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(180, 34)
        Me.txt_password.TabIndex = 1
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_password.Visible = False
        '
        'txt_statistics
        '
        Me.txt_statistics.BackColor = System.Drawing.Color.Black
        Me.txt_statistics.ForeColor = System.Drawing.Color.White
        Me.txt_statistics.Location = New System.Drawing.Point(12, 9)
        Me.txt_statistics.MaxLength = 999999999
        Me.txt_statistics.Multiline = True
        Me.txt_statistics.Name = "txt_statistics"
        Me.txt_statistics.ReadOnly = True
        Me.txt_statistics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_statistics.ShortcutsEnabled = False
        Me.txt_statistics.Size = New System.Drawing.Size(180, 34)
        Me.txt_statistics.TabIndex = 2
        Me.txt_statistics.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_statistics.Visible = False
        '
        'lbl_statistics
        '
        Me.lbl_statistics.AutoSize = True
        Me.lbl_statistics.Location = New System.Drawing.Point(12, 13)
        Me.lbl_statistics.Name = "lbl_statistics"
        Me.lbl_statistics.Size = New System.Drawing.Size(181, 27)
        Me.lbl_statistics.TabIndex = 0
        Me.lbl_statistics.Text = "▼ Statistics ▼"
        Me.lbl_statistics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmr_close
        '
        Me.tmr_close.Enabled = True
        Me.tmr_close.Interval = 3000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(204, 53)
        Me.Controls.Add(Me.lbl_statistics)
        Me.Controls.Add(Me.txt_statistics)
        Me.Controls.Add(Me.txt_password)
        Me.Font = New System.Drawing.Font("Aharoni", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(212, 87)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(212, 87)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PC LogIn Statistics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents txt_statistics As System.Windows.Forms.TextBox
    Friend WithEvents lbl_statistics As System.Windows.Forms.Label
    Friend WithEvents tmr_close As System.Windows.Forms.Timer

End Class
