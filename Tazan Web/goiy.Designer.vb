<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class goiy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(goiy))
        Me.txt_auto_txt = New System.Windows.Forms.TextBox()
        Me.bt_back = New System.Windows.Forms.Button()
        Me.txt_data = New System.Windows.Forms.TextBox()
        Me.bt_add = New System.Windows.Forms.Button()
        Me.bt_move = New System.Windows.Forms.Button()
        Me.ls_goiy = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_auto_txt
        '
        Me.txt_auto_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_auto_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_auto_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_auto_txt.Location = New System.Drawing.Point(12, 12)
        Me.txt_auto_txt.Name = "txt_auto_txt"
        Me.txt_auto_txt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_auto_txt.Size = New System.Drawing.Size(685, 20)
        Me.txt_auto_txt.TabIndex = 0
        '
        'bt_back
        '
        Me.bt_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_back.Location = New System.Drawing.Point(620, 114)
        Me.bt_back.Name = "bt_back"
        Me.bt_back.Size = New System.Drawing.Size(129, 43)
        Me.bt_back.TabIndex = 1
        Me.bt_back.Text = "&Quay lại"
        Me.bt_back.UseVisualStyleBackColor = True
        '
        'txt_data
        '
        Me.txt_data.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_data.Location = New System.Drawing.Point(12, 182)
        Me.txt_data.Multiline = True
        Me.txt_data.Name = "txt_data"
        Me.txt_data.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_data.Size = New System.Drawing.Size(737, 217)
        Me.txt_data.TabIndex = 2
        '
        'bt_add
        '
        Me.bt_add.Location = New System.Drawing.Point(703, 12)
        Me.bt_add.Name = "bt_add"
        Me.bt_add.Size = New System.Drawing.Size(46, 20)
        Me.bt_add.TabIndex = 3
        Me.bt_add.Text = "&Thêm"
        Me.bt_add.UseVisualStyleBackColor = True
        '
        'bt_move
        '
        Me.bt_move.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_move.Location = New System.Drawing.Point(620, 65)
        Me.bt_move.Name = "bt_move"
        Me.bt_move.Size = New System.Drawing.Size(129, 43)
        Me.bt_move.TabIndex = 4
        Me.bt_move.Text = "&Chuyển code sang..."
        Me.bt_move.UseVisualStyleBackColor = True
        '
        'ls_goiy
        '
        Me.ls_goiy.FormattingEnabled = True
        Me.ls_goiy.Location = New System.Drawing.Point(12, 38)
        Me.ls_goiy.Name = "ls_goiy"
        Me.ls_goiy.Size = New System.Drawing.Size(602, 134)
        Me.ls_goiy.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(634, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Enter để thêm hoặc " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "nhấn thêm"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'goiy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(761, 411)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ls_goiy)
        Me.Controls.Add(Me.bt_move)
        Me.Controls.Add(Me.bt_add)
        Me.Controls.Add(Me.txt_data)
        Me.Controls.Add(Me.bt_back)
        Me.Controls.Add(Me.txt_auto_txt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "goiy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tanza Web - Gợi ý hàm"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_auto_txt As TextBox
    Friend WithEvents bt_back As Button
    Friend WithEvents txt_data As TextBox
    Friend WithEvents bt_add As Button
    Friend WithEvents bt_move As Button
    Friend WithEvents ls_goiy As ListBox
    Friend WithEvents Label1 As Label
End Class
