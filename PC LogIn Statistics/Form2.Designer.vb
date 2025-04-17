<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txt_statistics = New System.Windows.Forms.TextBox
        Me.lbl_copyright = New System.Windows.Forms.Label
        Me.tmr_copyright = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txt_statistics
        '
        Me.txt_statistics.BackColor = System.Drawing.Color.Black
        Me.txt_statistics.ForeColor = System.Drawing.Color.White
        Me.txt_statistics.Location = New System.Drawing.Point(12, 12)
        Me.txt_statistics.MaxLength = 999999999
        Me.txt_statistics.Multiline = True
        Me.txt_statistics.Name = "txt_statistics"
        Me.txt_statistics.ReadOnly = True
        Me.txt_statistics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_statistics.Size = New System.Drawing.Size(180, 270)
        Me.txt_statistics.TabIndex = 3
        Me.txt_statistics.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_copyright
        '
        Me.lbl_copyright.AutoSize = True
        Me.lbl_copyright.Font = New System.Drawing.Font("Aharoni", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lbl_copyright.Location = New System.Drawing.Point(203, 290)
        Me.lbl_copyright.Name = "lbl_copyright"
        Me.lbl_copyright.Size = New System.Drawing.Size(138, 16)
        Me.lbl_copyright.TabIndex = 4
        Me.lbl_copyright.Text = "© Eslam Abdullah"
        Me.lbl_copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmr_copyright
        '
        Me.tmr_copyright.Enabled = True
        Me.tmr_copyright.Interval = 1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(204, 316)
        Me.Controls.Add(Me.lbl_copyright)
        Me.Controls.Add(Me.txt_statistics)
        Me.Font = New System.Drawing.Font("Aharoni", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(212, 350)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(212, 350)
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PC LogIn Statistics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_statistics As System.Windows.Forms.TextBox
    Friend WithEvents lbl_copyright As System.Windows.Forms.Label
    Friend WithEvents tmr_copyright As System.Windows.Forms.Timer
End Class
