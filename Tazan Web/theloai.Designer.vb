<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class theloai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(theloai))
        Me.list = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_new = New System.Windows.Forms.Button()
        Me.bt_canhan = New System.Windows.Forms.Button()
        Me.sv = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'list
        '
        Me.list.FormattingEnabled = True
        Me.list.Location = New System.Drawing.Point(46, 75)
        Me.list.Name = "list"
        Me.list.Size = New System.Drawing.Size(475, 21)
        Me.list.TabIndex = 0
        Me.list.Text = "Chọn thể loại"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(185, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Chọn thể loại :"
        '
        'bt_new
        '
        Me.bt_new.BackColor = System.Drawing.Color.White
        Me.bt_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_new.Location = New System.Drawing.Point(46, 114)
        Me.bt_new.Name = "bt_new"
        Me.bt_new.Size = New System.Drawing.Size(229, 65)
        Me.bt_new.TabIndex = 2
        Me.bt_new.Text = "&Tạo mới không dùng mẫu sẵn"
        Me.bt_new.UseVisualStyleBackColor = False
        '
        'bt_canhan
        '
        Me.bt_canhan.BackColor = System.Drawing.Color.White
        Me.bt_canhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_canhan.Location = New System.Drawing.Point(299, 114)
        Me.bt_canhan.Name = "bt_canhan"
        Me.bt_canhan.Size = New System.Drawing.Size(222, 65)
        Me.bt_canhan.TabIndex = 3
        Me.bt_canhan.Text = "&Tạo trang cá nhân từ mẫu"
        Me.bt_canhan.UseVisualStyleBackColor = False
        '
        'theloai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(556, 208)
        Me.Controls.Add(Me.bt_canhan)
        Me.Controls.Add(Me.bt_new)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.list)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "theloai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tanza Web - Tuỳ chọn mã nguồn"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents list As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_new As Button
    Friend WithEvents bt_canhan As Button
    Friend WithEvents sv As FolderBrowserDialog
End Class
