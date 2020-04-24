Public Class theloai
    ' Author: Nguyen Trung Nhan
    ' Email: trungnhan21.12@gmail.com
    ' Github: https://github.com/nhannt201/Tazan-web
    Private Sub theloai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        list.Items.Add("Máy tính/Thiết bị")
        list.Items.Add("Nghệ thuật/Thiết kế")
        list.Items.Add("Sách")
        list.Items.Add("Giáo dục/Khoa học")
        list.Items.Add("Phần mềm")
        list.Items.Add("Con người")
        list.Items.Add("Thiên nhiên")
        list.Items.Add("Internet")
        list.Items.Add("Hosting/Servers")
        list.Items.Add("Trang chủ/Blog")
        list.Items.Add("Trò chơi")
        list.Items.Add("Tôn giáo")
        list.Items.Add("Media")
        list.Items.Add("Đẹp")
        list.Items.Add("Con vật/Thú cưng")
        list.Items.Add("Hẹn hò")
        list.Items.Add("Khác")
    End Sub

    Private Sub list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list.SelectedIndexChanged
        Try
            If list.Text = "" Then
            ElseIf list.Text = "Máy tính/Thiết bị" Then
                maytinhthietbi.Show()
                Me.Hide()
                Me.Close()
            ElseIf list.Text = "Nghệ thuật/Thiết kế" Then
                nghethuatthietke.Show()
                Me.Hide()
                Me.Close()
            ElseIf list.Text = "Sách" Then
                sach.Show()
                Me.Hide()
                Me.Close()
            ElseIf list.Text = "Giáo dục/Khoa học" Then
                giaoduckhoahoc.Show()
                Me.Hide()
                Me.Close()
            ElseIf list.Text = "Phần mềm" Then
                phanmem.Show()
                Me.Hide()
                Me.Close()
            ElseIf list.Text = "Con người" Then
                connguoi.Show()
                Me.Hide()
                Me.Close()
            ElseIf list.Text = "Thiên nhiên" Then
                MsgBox("Hiện chúng tôi chưa thể cập nhật chủ đề này, hẹn bạn vào phiên bản sau!", vbInformation, "Thông báo")

            ElseIf list.Text = "Internet" Then
                MsgBox("Hiện chúng tôi chưa thể cập nhật chủ đề này, hẹn bạn vào phiên bản sau!", vbInformation, "Thông báo")

            ElseIf list.Text = "Hosting/Servers" Then
                MsgBox("Hiện chúng tôi chưa thể cập nhật chủ đề này, hẹn bạn vào phiên bản sau!", vbInformation, "Thông báo")
            ElseIf list.Text = "Trang chủ/Blog" Then
                MsgBox("Hiện chúng tôi chưa thể cập nhật chủ đề này, hẹn bạn vào phiên bản sau!", vbInformation, "Thông báo")
            Else
                MsgBox("Hiện chúng tôi chưa thể cập nhật chủ đề này, hẹn bạn vào phiên bản sau!", vbInformation, "Thông báo")
            End If
            If list.Text = "Chọn thể loại" Then
                list.Text = "Chọn thể loại"
            End If
        Catch
            MsgBox("Có lỗi xảy ra, không thể lựa chọn thể loại!")
            End
        End Try

    End Sub

    Private Sub bt_canhan_Click(sender As Object, e As EventArgs) Handles bt_canhan.Click
        Try
            fr_canhan.Show()
            Me.Hide()
            Me.Close()
        Catch
            MsgBox("Có lỗi xảy ra, không thể mở mục lựa chọn!")
            End
        End Try
    End Sub

    Private Sub bt_new_Click(sender As Object, e As EventArgs) Handles bt_new.Click
        Try
            If (sv.ShowDialog() = DialogResult.OK) Then
                maytinh1.linkfile.Text = sv.SelectedPath
                My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\Theme\New\", maytinh1.linkfile.Text, True)
                maytinh1.Show()
                Me.Hide()
                Me.Close()
            End If
        Catch
            MsgBox("Có lỗi xảy ra, không thể tạo mới!")
            End
        End Try

    End Sub

    Private Sub list_KeyPress(sender As Object, e As KeyPressEventArgs) Handles list.KeyPress
        If Not (IsNumeric(e.KeyChar)) Then
            e.Handled = True
        End If

    End Sub
End Class