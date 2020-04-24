Public Class load
    ' Author: Nguyen Trung Nhan
    ' Email: trungnhan21.12@gmail.com
    ' Github: https://github.com/nhannt201/Tazan-web
    Dim number As String = 0

    Private Sub tm1_Tick(sender As Object, e As EventArgs) Handles tm1.Tick
        number = number + 1
        If number = 1 Then
            lb_trailer.Text = "Chỉnh sửa đơn giản"
            lb_load.Text = "Đang tải dữ liệu...(3)"
        ElseIf number = 2 Then
            lb_trailer.Text = "Giao diện tiện dụng"
            lb_load.Text = "Đang tải dữ liệu...(2)"
            ' For a folder
            Dim dir As New IO.DirectoryInfo(Application.StartupPath & "\Theme")
            If dir.Exists Then

            Else
                nonefoder()


            End If
        ElseIf number = 3 Then
            lb_trailer.Text = "Tiết kiệm thời gian"
            lb_load.Text = "Đang tải dữ liệu...(1)"
            Dim dir As New IO.DirectoryInfo(Application.StartupPath & "\Theme")
            If dir.Exists Then

            Else
                ends()
                tm1.Enabled = False

            End If
        ElseIf number = 4 Then
            lb_trailer.Text = "Tất cả có tại Tanza Web!"
            lb_trailer.Left = lb_trailer.Left - 20
            lb_load.Text = "Chuẩn bị..."
        ElseIf number = 5 Then
            theloai.Show()
            Me.Hide()
            tm1.Stop()
        End If
    End Sub

    Sub nonefoder()
        '    lb_load.Text = ("Thư mục Data không tồn tại!!!")
        lb_trailer.Text = "Thư mục Data không tồn tại!!!"
        lb_trailer.Left = lb_trailer.Left - 30
    End Sub
    Sub ends()
        End
    End Sub

    Private Sub load_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class