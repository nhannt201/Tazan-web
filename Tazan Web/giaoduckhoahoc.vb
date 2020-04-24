Public Class giaoduckhoahoc
    ' Author: Nguyen Trung Nhan
    ' Email: trungnhan21.12@gmail.com
    ' Github: https://github.com/nhannt201/Tazan-web
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If (sv.ShowDialog() = DialogResult.OK) Then
            maytinh1.linkfile.Text = sv.SelectedPath
            My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\Theme\Giaoduckhoahoc\giaoduc1\", maytinh1.linkfile.Text, True)
            maytinh1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If (sv.ShowDialog() = DialogResult.OK) Then
            maytinh1.linkfile.Text = sv.SelectedPath
            My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\Theme\Giaoduckhoahoc\giaoduc2\", maytinh1.linkfile.Text, True)
            maytinh1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If (sv.ShowDialog() = DialogResult.OK) Then
            maytinh1.linkfile.Text = sv.SelectedPath
            My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\Theme\Giaoduckhoahoc\giaoduc3\", maytinh1.linkfile.Text, True)
            maytinh1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If (sv.ShowDialog() = DialogResult.OK) Then
            maytinh1.linkfile.Text = sv.SelectedPath
            My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\Theme\Giaoduckhoahoc\giaoduc4\", maytinh1.linkfile.Text, True)
            maytinh1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If (sv.ShowDialog() = DialogResult.OK) Then
            maytinh1.linkfile.Text = sv.SelectedPath
            My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\Theme\Giaoduckhoahoc\giaoduc5\", maytinh1.linkfile.Text, True)
            maytinh1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub bt_bk_Click(sender As Object, e As EventArgs) Handles bt_bk.Click
        theloai.Show()
        Me.Hide()

    End Sub

    Private Sub giaoduckhoahoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class