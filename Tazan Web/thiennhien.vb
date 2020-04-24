Public Class thiennhien
    ' Author: Nguyen Trung Nhan
    ' Email: trungnhan21.12@gmail.com
    ' Github: https://github.com/nhannt201/Tazan-web
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If (sv.ShowDialog() = DialogResult.OK) Then
            maytinh1.linkfile.Text = sv.SelectedPath
            My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\Theme\Thiennhien\phanmem\", maytinh1.linkfile.Text, True)
            maytinh1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub bt_bk_Click(sender As Object, e As EventArgs) Handles bt_bk.Click
        theloai.Show()
        Me.Hide()
    End Sub
End Class