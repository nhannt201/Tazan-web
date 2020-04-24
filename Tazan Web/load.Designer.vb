<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class load
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(load))
        Me.lb_ver = New System.Windows.Forms.Label()
        Me.lb_load = New System.Windows.Forms.Label()
        Me.tm1 = New System.Windows.Forms.Timer(Me.components)
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.lb_trailer = New System.Windows.Forms.Label()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_ver
        '
        Me.lb_ver.AutoSize = True
        Me.lb_ver.BackColor = System.Drawing.Color.Honeydew
        Me.lb_ver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ver.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ver.Location = New System.Drawing.Point(51, 203)
        Me.lb_ver.Name = "lb_ver"
        Me.lb_ver.Size = New System.Drawing.Size(117, 52)
        Me.lb_ver.TabIndex = 0
        Me.lb_ver.Text = "Phiên bản" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1.0.0"
        Me.lb_ver.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lb_load
        '
        Me.lb_load.AutoSize = True
        Me.lb_load.BackColor = System.Drawing.Color.Transparent
        Me.lb_load.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_load.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_load.Location = New System.Drawing.Point(296, 234)
        Me.lb_load.Name = "lb_load"
        Me.lb_load.Size = New System.Drawing.Size(156, 21)
        Me.lb_load.TabIndex = 2
        Me.lb_load.Text = "Đang tải dữ liệu..."
        '
        'tm1
        '
        Me.tm1.Enabled = True
        Me.tm1.Interval = 1000
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.Color.White
        Me.pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb1.Location = New System.Drawing.Point(12, 12)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(467, 177)
        Me.pb1.TabIndex = 3
        Me.pb1.TabStop = False
        '
        'lb_trailer
        '
        Me.lb_trailer.AutoSize = True
        Me.lb_trailer.BackColor = System.Drawing.Color.White
        Me.lb_trailer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_trailer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_trailer.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_trailer.Location = New System.Drawing.Point(173, 88)
        Me.lb_trailer.Name = "lb_trailer"
        Me.lb_trailer.Size = New System.Drawing.Size(151, 21)
        Me.lb_trailer.TabIndex = 4
        Me.lb_trailer.Text = "Tạo web dễ dàng" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lb_trailer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'load
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(491, 282)
        Me.Controls.Add(Me.lb_trailer)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.lb_load)
        Me.Controls.Add(Me.lb_ver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "load"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "load"
        Me.TopMost = True
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_ver As Label
    Friend WithEvents lb_load As Label
    Friend WithEvents tm1 As Timer
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents lb_trailer As Label
End Class
