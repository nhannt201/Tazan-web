Imports System.Text.RegularExpressions
' Author: Nguyen Trung Nhan
' Email: trungnhan21.12@gmail.com
' Github: https://github.com/nhannt201/Tazan-web
Public Class bbcode
    Private Sub bbcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bt_back_Click(sender As Object, e As EventArgs) Handles bt_back.Click
        maytinh1.Enabled = True
        Me.Hide()
        Me.Close()
    End Sub

    Private Sub bt_select_Click(sender As Object, e As EventArgs) Handles bt_select.Click
        txt_bbcode.SelectAll()
    End Sub

    Private Sub bt_cp_Click(sender As Object, e As EventArgs) Handles bt_cp.Click
        txt_bbcode.Copy()
    End Sub

    Public Function BBCode_Cvrt(ByVal strTextToReplace As String) As String

        '//Define regex
        Dim regExp As Regex

        '//Regex for URL tag without anchor
        regExp = New Regex("\[url\]([^\]]+)\[\/url\]")
        strTextToReplace = regExp.Replace(strTextToReplace, "<a href=""$1"">$1</a>")

        '//Regex for URL with anchor
        regExp = New Regex("\[url=([^\]]+)\]([^\]]+)\[\/url\]")
        strTextToReplace = regExp.Replace(strTextToReplace, "<a href=""$1"">$2</a>")

        '//Image regex
        regExp = New Regex("\[img\]([^\]]+)\[\/img\]")
        strTextToReplace = regExp.Replace(strTextToReplace, "<img src=""$1"" />")

        '//Bold text
        regExp = New Regex("\[b\](.+?)\[\/b\]")
        strTextToReplace = regExp.Replace(strTextToReplace, "<b>$1</b>")

        '//Italic text
        regExp = New Regex("\[i\](.+?)\[\/i\]")
        strTextToReplace = regExp.Replace(strTextToReplace, "<i>$1</i>")

        '//Underline text
        regExp = New Regex("\[u\](.+?)\[\/u\]")
        strTextToReplace = regExp.Replace(strTextToReplace, "<u>$1</u>")

        '//Font size
        regExp = New Regex("\[size=([^\]]+)\]([^\]]+)\[\/size\]")
        strTextToReplace = regExp.Replace(strTextToReplace, "<span style=""font-size: $1px"">$2</span>")

        '//Font color
        regExp = New Regex("\[color=([^\]]+)\]([^\]]+)\[\/color\]")
        strTextToReplace = regExp.Replace(strTextToReplace, "<span style=""color: $1"">$2</span>")

        Return strTextToReplace
    End Function

    Private Sub bt_ch_Click(sender As Object, e As EventArgs) Handles bt_ch.Click
        txt_bbcode.Text = BBCode_Cvrt(txt_bbcode.Text)
    End Sub
End Class