<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_canhan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fr_canhan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pn1 = New System.Windows.Forms.Panel()
        Me.lb_wait = New System.Windows.Forms.Label()
        Me.lb_num = New System.Windows.Forms.Label()
        Me.lb_sect = New System.Windows.Forms.Label()
        Me.lb_review = New System.Windows.Forms.Label()
        Me.bt_back = New System.Windows.Forms.Button()
        Me.bt_use = New System.Windows.Forms.Button()
        Me.pb_review = New System.Windows.Forms.PictureBox()
        Me.sv = New System.Windows.Forms.FolderBrowserDialog()
        Me.bt_bk = New System.Windows.Forms.Button()
        Me.pb_13 = New System.Windows.Forms.PictureBox()
        Me.pb_12 = New System.Windows.Forms.PictureBox()
        Me.pb_11 = New System.Windows.Forms.PictureBox()
        Me.pb_10 = New System.Windows.Forms.PictureBox()
        Me.pb_9 = New System.Windows.Forms.PictureBox()
        Me.pb_8 = New System.Windows.Forms.PictureBox()
        Me.pb_7 = New System.Windows.Forms.PictureBox()
        Me.pb_6 = New System.Windows.Forms.PictureBox()
        Me.pb_5 = New System.Windows.Forms.PictureBox()
        Me.pb_4 = New System.Windows.Forms.PictureBox()
        Me.pb_3 = New System.Windows.Forms.PictureBox()
        Me.pb_2 = New System.Windows.Forms.PictureBox()
        Me.pb_1 = New System.Windows.Forms.PictureBox()
        Me.pn1.SuspendLayout()
        CType(Me.pb_review, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(712, 367)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Template by HTML5UP"
        '
        'pn1
        '
        Me.pn1.Controls.Add(Me.lb_wait)
        Me.pn1.Controls.Add(Me.lb_num)
        Me.pn1.Controls.Add(Me.lb_sect)
        Me.pn1.Controls.Add(Me.lb_review)
        Me.pn1.Controls.Add(Me.bt_back)
        Me.pn1.Controls.Add(Me.bt_use)
        Me.pn1.Controls.Add(Me.pb_review)
        Me.pn1.Location = New System.Drawing.Point(12, 12)
        Me.pn1.Name = "pn1"
        Me.pn1.Size = New System.Drawing.Size(830, 380)
        Me.pn1.TabIndex = 14
        Me.pn1.Visible = False
        '
        'lb_wait
        '
        Me.lb_wait.AutoSize = True
        Me.lb_wait.BackColor = System.Drawing.Color.White
        Me.lb_wait.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_wait.ForeColor = System.Drawing.Color.Gold
        Me.lb_wait.Location = New System.Drawing.Point(175, 176)
        Me.lb_wait.Name = "lb_wait"
        Me.lb_wait.Size = New System.Drawing.Size(278, 42)
        Me.lb_wait.TabIndex = 6
        Me.lb_wait.Text = "Đợi một chút..."
        Me.lb_wait.Visible = False
        '
        'lb_num
        '
        Me.lb_num.AutoSize = True
        Me.lb_num.BackColor = System.Drawing.Color.MintCream
        Me.lb_num.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_num.Location = New System.Drawing.Point(721, 295)
        Me.lb_num.Name = "lb_num"
        Me.lb_num.Size = New System.Drawing.Size(25, 25)
        Me.lb_num.TabIndex = 5
        Me.lb_num.Text = "0"
        Me.lb_num.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lb_sect
        '
        Me.lb_sect.AutoSize = True
        Me.lb_sect.BackColor = System.Drawing.Color.MintCream
        Me.lb_sect.Location = New System.Drawing.Point(688, 259)
        Me.lb_sect.Name = "lb_sect"
        Me.lb_sect.Size = New System.Drawing.Size(106, 13)
        Me.lb_sect.TabIndex = 4
        Me.lb_sect.Text = "Đang chọn giao diện"
        '
        'lb_review
        '
        Me.lb_review.AutoSize = True
        Me.lb_review.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.lb_review.Location = New System.Drawing.Point(14, 17)
        Me.lb_review.Name = "lb_review"
        Me.lb_review.Size = New System.Drawing.Size(55, 13)
        Me.lb_review.TabIndex = 3
        Me.lb_review.Text = "Xem trước"
        '
        'bt_back
        '
        Me.bt_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_back.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_back.Location = New System.Drawing.Point(654, 115)
        Me.bt_back.Name = "bt_back"
        Me.bt_back.Size = New System.Drawing.Size(165, 86)
        Me.bt_back.TabIndex = 2
        Me.bt_back.Text = "&Quay lại"
        Me.bt_back.UseVisualStyleBackColor = True
        '
        'bt_use
        '
        Me.bt_use.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_use.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_use.Location = New System.Drawing.Point(654, 17)
        Me.bt_use.Name = "bt_use"
        Me.bt_use.Size = New System.Drawing.Size(165, 86)
        Me.bt_use.TabIndex = 1
        Me.bt_use.Text = "&Chọn giao diện này"
        Me.bt_use.UseVisualStyleBackColor = True
        '
        'pb_review
        '
        Me.pb_review.Image = Global.Tanza_Web.My.Resources.Resources._1
        Me.pb_review.Location = New System.Drawing.Point(17, 17)
        Me.pb_review.Name = "pb_review"
        Me.pb_review.Size = New System.Drawing.Size(631, 351)
        Me.pb_review.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_review.TabIndex = 0
        Me.pb_review.TabStop = False
        '
        'bt_bk
        '
        Me.bt_bk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_bk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_bk.Location = New System.Drawing.Point(498, 282)
        Me.bt_bk.Name = "bt_bk"
        Me.bt_bk.Size = New System.Drawing.Size(165, 86)
        Me.bt_bk.TabIndex = 15
        Me.bt_bk.Text = "&Quay lại"
        Me.bt_bk.UseVisualStyleBackColor = True
        '
        'pb_13
        '
        Me.pb_13.Image = Global.Tanza_Web.My.Resources.Resources._14
        Me.pb_13.Location = New System.Drawing.Point(330, 271)
        Me.pb_13.Name = "pb_13"
        Me.pb_13.Size = New System.Drawing.Size(135, 109)
        Me.pb_13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_13.TabIndex = 12
        Me.pb_13.TabStop = False
        '
        'pb_12
        '
        Me.pb_12.Image = Global.Tanza_Web.My.Resources.Resources._13
        Me.pb_12.Location = New System.Drawing.Point(166, 271)
        Me.pb_12.Name = "pb_12"
        Me.pb_12.Size = New System.Drawing.Size(135, 109)
        Me.pb_12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_12.TabIndex = 11
        Me.pb_12.TabStop = False
        '
        'pb_11
        '
        Me.pb_11.Image = Global.Tanza_Web.My.Resources.Resources._12
        Me.pb_11.Location = New System.Drawing.Point(12, 271)
        Me.pb_11.Name = "pb_11"
        Me.pb_11.Size = New System.Drawing.Size(135, 109)
        Me.pb_11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_11.TabIndex = 10
        Me.pb_11.TabStop = False
        '
        'pb_10
        '
        Me.pb_10.Image = Global.Tanza_Web.My.Resources.Resources._11
        Me.pb_10.Location = New System.Drawing.Point(671, 143)
        Me.pb_10.Name = "pb_10"
        Me.pb_10.Size = New System.Drawing.Size(135, 109)
        Me.pb_10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_10.TabIndex = 9
        Me.pb_10.TabStop = False
        '
        'pb_9
        '
        Me.pb_9.Image = Global.Tanza_Web.My.Resources.Resources._10
        Me.pb_9.Location = New System.Drawing.Point(498, 143)
        Me.pb_9.Name = "pb_9"
        Me.pb_9.Size = New System.Drawing.Size(135, 109)
        Me.pb_9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_9.TabIndex = 8
        Me.pb_9.TabStop = False
        '
        'pb_8
        '
        Me.pb_8.Image = Global.Tanza_Web.My.Resources.Resources._9
        Me.pb_8.Location = New System.Drawing.Point(330, 143)
        Me.pb_8.Name = "pb_8"
        Me.pb_8.Size = New System.Drawing.Size(135, 109)
        Me.pb_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_8.TabIndex = 7
        Me.pb_8.TabStop = False
        '
        'pb_7
        '
        Me.pb_7.Image = Global.Tanza_Web.My.Resources.Resources._8
        Me.pb_7.Location = New System.Drawing.Point(166, 143)
        Me.pb_7.Name = "pb_7"
        Me.pb_7.Size = New System.Drawing.Size(135, 109)
        Me.pb_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_7.TabIndex = 6
        Me.pb_7.TabStop = False
        '
        'pb_6
        '
        Me.pb_6.Image = Global.Tanza_Web.My.Resources.Resources._6
        Me.pb_6.Location = New System.Drawing.Point(12, 143)
        Me.pb_6.Name = "pb_6"
        Me.pb_6.Size = New System.Drawing.Size(135, 109)
        Me.pb_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_6.TabIndex = 5
        Me.pb_6.TabStop = False
        '
        'pb_5
        '
        Me.pb_5.Image = Global.Tanza_Web.My.Resources.Resources._5
        Me.pb_5.Location = New System.Drawing.Point(671, 12)
        Me.pb_5.Name = "pb_5"
        Me.pb_5.Size = New System.Drawing.Size(135, 109)
        Me.pb_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_5.TabIndex = 4
        Me.pb_5.TabStop = False
        '
        'pb_4
        '
        Me.pb_4.Image = Global.Tanza_Web.My.Resources.Resources._4
        Me.pb_4.Location = New System.Drawing.Point(498, 12)
        Me.pb_4.Name = "pb_4"
        Me.pb_4.Size = New System.Drawing.Size(135, 109)
        Me.pb_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_4.TabIndex = 3
        Me.pb_4.TabStop = False
        '
        'pb_3
        '
        Me.pb_3.Image = Global.Tanza_Web.My.Resources.Resources._3
        Me.pb_3.Location = New System.Drawing.Point(330, 12)
        Me.pb_3.Name = "pb_3"
        Me.pb_3.Size = New System.Drawing.Size(135, 109)
        Me.pb_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_3.TabIndex = 2
        Me.pb_3.TabStop = False
        '
        'pb_2
        '
        Me.pb_2.Image = Global.Tanza_Web.My.Resources.Resources._2
        Me.pb_2.Location = New System.Drawing.Point(166, 12)
        Me.pb_2.Name = "pb_2"
        Me.pb_2.Size = New System.Drawing.Size(135, 109)
        Me.pb_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_2.TabIndex = 1
        Me.pb_2.TabStop = False
        '
        'pb_1
        '
        Me.pb_1.Image = Global.Tanza_Web.My.Resources.Resources._1
        Me.pb_1.Location = New System.Drawing.Point(12, 12)
        Me.pb_1.Name = "pb_1"
        Me.pb_1.Size = New System.Drawing.Size(135, 109)
        Me.pb_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_1.TabIndex = 0
        Me.pb_1.TabStop = False
        '
        'fr_canhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(854, 404)
        Me.Controls.Add(Me.bt_bk)
        Me.Controls.Add(Me.pn1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb_13)
        Me.Controls.Add(Me.pb_12)
        Me.Controls.Add(Me.pb_11)
        Me.Controls.Add(Me.pb_10)
        Me.Controls.Add(Me.pb_9)
        Me.Controls.Add(Me.pb_8)
        Me.Controls.Add(Me.pb_7)
        Me.Controls.Add(Me.pb_6)
        Me.Controls.Add(Me.pb_5)
        Me.Controls.Add(Me.pb_4)
        Me.Controls.Add(Me.pb_3)
        Me.Controls.Add(Me.pb_2)
        Me.Controls.Add(Me.pb_1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "fr_canhan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tanza Web - Thiết kế trang cá nhân"
        Me.TopMost = True
        Me.pn1.ResumeLayout(False)
        Me.pn1.PerformLayout()
        CType(Me.pb_review, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_1 As PictureBox
    Friend WithEvents pb_2 As PictureBox
    Friend WithEvents pb_3 As PictureBox
    Friend WithEvents pb_4 As PictureBox
    Friend WithEvents pb_5 As PictureBox
    Friend WithEvents pb_10 As PictureBox
    Friend WithEvents pb_9 As PictureBox
    Friend WithEvents pb_8 As PictureBox
    Friend WithEvents pb_7 As PictureBox
    Friend WithEvents pb_6 As PictureBox
    Friend WithEvents pb_13 As PictureBox
    Friend WithEvents pb_12 As PictureBox
    Friend WithEvents pb_11 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pn1 As Panel
    Friend WithEvents lb_sect As Label
    Friend WithEvents lb_review As Label
    Friend WithEvents bt_back As Button
    Friend WithEvents bt_use As Button
    Friend WithEvents pb_review As PictureBox
    Friend WithEvents lb_num As Label
    Friend WithEvents sv As FolderBrowserDialog
    Friend WithEvents bt_bk As Button
    Friend WithEvents lb_wait As Label
End Class
