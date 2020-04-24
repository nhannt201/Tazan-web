Public Class fr_canhan
    ' Author: Nguyen Trung Nhan
    ' Email: trungnhan21.12@gmail.com
    ' Github: https://github.com/nhannt201/Tazan-web
    Private Sub pn1_Paint(sender As Object, e As PaintEventArgs) Handles pn1.Paint

    End Sub

    Private Sub bt_back_Click(sender As Object, e As EventArgs) Handles bt_back.Click
        pn1.Visible = False
        bt_bk.Visible = True
    End Sub

    Private Sub pb_1_Click(sender As Object, e As EventArgs) Handles pb_1.Click
        pb_review.Image = My.Resources._1
        lb_num.Text = 1
        bt_bk.Visible = False
        pn1.Visible = True
    End Sub

    Private Sub pb_2_Click(sender As Object, e As EventArgs) Handles pb_2.Click
        pb_review.Image = My.Resources._2
        lb_num.Text = 2
        bt_bk.Visible = False
        pn1.Visible = True
    End Sub

    Private Sub pb_3_Click(sender As Object, e As EventArgs) Handles pb_3.Click
        pb_review.Image = My.Resources._3
        lb_num.Text = 3
        bt_bk.Visible = False
        pn1.Visible = True
    End Sub

    Private Sub pb_4_Click(sender As Object, e As EventArgs) Handles pb_4.Click
        pb_review.Image = My.Resources._4
        lb_num.Text = 4
        bt_bk.Visible = False
        pn1.Visible = True
    End Sub

    Private Sub pb_5_Click(sender As Object, e As EventArgs) Handles pb_5.Click
        pb_review.Image = My.Resources._5
        lb_num.Text = 5
        bt_bk.Visible = False
        pn1.Visible = True
    End Sub

    Private Sub pb_6_Click(sender As Object, e As EventArgs) Handles pb_6.Click
        pb_review.Image = My.Resources._6
        lb_num.Text = 6
        bt_bk.Visible = False
        pn1.Visible = True
    End Sub

    Private Sub pb_7_Click(sender As Object, e As EventArgs) Handles pb_7.Click
        pb_review.Image = My.Resources._8
        lb_num.Text = 7
        bt_bk.Visible = False
        pn1.Visible = True
    End Sub

    Private Sub pb_8_Click(sender As Object, e As EventArgs) Handles pb_8.Click
        pb_review.Image = My.Resources._9
        lb_num.Text = 8
        bt_bk.Visible = False
        pn1.Visible = True
    End Sub

    Private Sub pb_9_Click(sender As Object, e As EventArgs) Handles pb_9.Click
        pb_review.Image = My.Resources._10
        lb_num.Text = 9
        bt_bk.Visible = False
        pn1.Visible = True
    End Sub

    Private Sub pb_10_Click(sender As Object, e As EventArgs) Handles pb_10.Click
        pb_review.Image = My.Resources._11
        lb_num.Text = 10
        bt_bk.Visible = False
        pn1.Visible = True
    End Sub

    Private Sub pb_11_Click(sender As Object, e As EventArgs) Handles pb_11.Click
        pb_review.Image = My.Resources._12
        lb_num.Text = 11
        bt_bk.Visible = False
        pn1.Visible = True
    End Sub

    Private Sub pb_12_Click(sender As Object, e As EventArgs) Handles pb_12.Click
        pb_review.Image = My.Resources._13
        lb_num.Text = 12
        bt_bk.Visible = False
        pn1.Visible = True
    End Sub

    Private Sub pb_13_Click(sender As Object, e As EventArgs) Handles pb_13.Click
        pb_review.Image = My.Resources._14
        lb_num.Text = 13
        bt_bk.Visible = False
        pn1.Visible = True
    End Sub

    Private Sub bt_use_Click(sender As Object, e As EventArgs) Handles bt_use.Click
        Try
            If (sv.ShowDialog() = DialogResult.OK) Then
                lb_wait.Visible = True
                maytinh1.linkfile.Text = sv.SelectedPath
                My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\Theme\Canhan\" & lb_num.Text & "\", maytinh1.linkfile.Text, True)
                maytinh1.Show()
                Me.Hide()
                Me.Close()
            End If
        Catch
            Me.Text = "Gặp sự cố ~~ Đợi hoặc thoát..."
        End Try
    End Sub

    Private Sub bt_bk_Click(sender As Object, e As EventArgs) Handles bt_bk.Click
        theloai.Show()
        pn1.Visible = False
        Me.Hide()

    End Sub

    Private Sub fr_canhan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class