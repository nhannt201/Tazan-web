Public Class phanmem
    ' Author: Nguyen Trung Nhan
    ' Email: trungnhan21.12@gmail.com
    ' Github: https://github.com/nhannt201/Tazan-web
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If (sv.ShowDialog() = DialogResult.OK) Then
            maytinh1.linkfile.Text = sv.SelectedPath
            My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\Theme\Phanmem\phanmem\", maytinh1.linkfile.Text, True)
            maytinh1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If (sv.ShowDialog() = DialogResult.OK) Then
            maytinh1.linkfile.Text = sv.SelectedPath
            My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\Theme\Phanmem\phanmem2\", maytinh1.linkfile.Text, True)
            maytinh1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If (sv.ShowDialog() = DialogResult.OK) Then
            maytinh1.linkfile.Text = sv.SelectedPath
            My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\Theme\Phanmem\phanmem3\", maytinh1.linkfile.Text, True)
            maytinh1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If (sv.ShowDialog() = DialogResult.OK) Then
            maytinh1.linkfile.Text = sv.SelectedPath
            My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\Theme\Phanmem\phanmem4\", maytinh1.linkfile.Text, True)
            maytinh1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If (sv.ShowDialog() = DialogResult.OK) Then
            maytinh1.linkfile.Text = sv.SelectedPath
            My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\Theme\Phanmem\phanmem5\", maytinh1.linkfile.Text, True)
            maytinh1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If (sv.ShowDialog() = DialogResult.OK) Then
            maytinh1.linkfile.Text = sv.SelectedPath
            My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\Theme\Phanmem\phanmem6\", maytinh1.linkfile.Text, True)
            maytinh1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If (sv.ShowDialog() = DialogResult.OK) Then
            maytinh1.linkfile.Text = sv.SelectedPath
            My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\Theme\Phanmem\phanmem7\", maytinh1.linkfile.Text, True)
            maytinh1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub bt_bk_Click(sender As Object, e As EventArgs) Handles bt_bk.Click
        theloai.Show()
        Me.Hide()

    End Sub
End Class