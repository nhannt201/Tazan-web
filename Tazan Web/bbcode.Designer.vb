<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bbcode
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bbcode))
        Me.bt_back = New System.Windows.Forms.Button()
        Me.txt_bbcode = New System.Windows.Forms.TextBox()
        Me.bt_select = New System.Windows.Forms.Button()
        Me.bt_cp = New System.Windows.Forms.Button()
        Me.bt_ch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bt_back
        '
        Me.bt_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_back.Location = New System.Drawing.Point(689, 332)
        Me.bt_back.Name = "bt_back"
        Me.bt_back.Size = New System.Drawing.Size(111, 56)
        Me.bt_back.TabIndex = 0
        Me.bt_back.Text = "&Quay lại"
        Me.bt_back.UseVisualStyleBackColor = True
        '
        'txt_bbcode
        '
        Me.txt_bbcode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_bbcode.Location = New System.Drawing.Point(12, 12)
        Me.txt_bbcode.Multiline = True
        Me.txt_bbcode.Name = "txt_bbcode"
        Me.txt_bbcode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_bbcode.Size = New System.Drawing.Size(671, 376)
        Me.txt_bbcode.TabIndex = 1
        Me.txt_bbcode.Text = "[color=blue]blue[/color]"
        '
        'bt_select
        '
        Me.bt_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_select.Location = New System.Drawing.Point(689, 270)
        Me.bt_select.Name = "bt_select"
        Me.bt_select.Size = New System.Drawing.Size(111, 56)
        Me.bt_select.TabIndex = 2
        Me.bt_select.Text = "&Chọn tất cả"
        Me.bt_select.UseVisualStyleBackColor = True
        '
        'bt_cp
        '
        Me.bt_cp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cp.Location = New System.Drawing.Point(689, 208)
        Me.bt_cp.Name = "bt_cp"
        Me.bt_cp.Size = New System.Drawing.Size(111, 56)
        Me.bt_cp.TabIndex = 3
        Me.bt_cp.Text = "&Sao chép"
        Me.bt_cp.UseVisualStyleBackColor = True
        '
        'bt_ch
        '
        Me.bt_ch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_ch.Location = New System.Drawing.Point(689, 146)
        Me.bt_ch.Name = "bt_ch"
        Me.bt_ch.Size = New System.Drawing.Size(111, 56)
        Me.bt_ch.TabIndex = 4
        Me.bt_ch.Text = "&Chuyển sang BBCODE"
        Me.bt_ch.UseVisualStyleBackColor = True
        '
        'bbcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(805, 400)
        Me.Controls.Add(Me.bt_ch)
        Me.Controls.Add(Me.bt_cp)
        Me.Controls.Add(Me.bt_select)
        Me.Controls.Add(Me.txt_bbcode)
        Me.Controls.Add(Me.bt_back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "bbcode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tanza Web - BBCODE Covert"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_back As Button
    Friend WithEvents txt_bbcode As TextBox
    Friend WithEvents bt_select As Button
    Friend WithEvents bt_cp As Button
    Friend WithEvents bt_ch As Button
End Class
