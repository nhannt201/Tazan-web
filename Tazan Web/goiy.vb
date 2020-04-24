Public Class goiy
    ' Author: Nguyen Trung Nhan
    ' Email: trungnhan21.12@gmail.com
    ' Github: https://github.com/nhannt201/Tazan-web
    Private Sub goiy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   txt_auto_txt.AutoCompleteMode = AutoCompleteMode.Suggest
        '  txt_auto_txt.AutoCompleteSource = AutoCompleteSource.CustomSource
        '  Dim DataCollection As New AutoCompleteStringCollection()
        '  addItems(DataCollection)
        ' txt_auto_txt.AutoCompleteCustomSource = DataCollection
        addItems()
    End Sub
    Sub addItems()
        ls_goiy.Items.Add("<!DOCTYPE")
        ls_goiy.Items.Add("<a")
        ls_goiy.Items.Add("</a")
        ls_goiy.Items.Add("<abbr")
        ls_goiy.Items.Add("<acronym")
        ls_goiy.Items.Add("<address")
        ls_goiy.Items.Add("<area")
        ls_goiy.Items.Add("<b")
        ls_goiy.Items.Add("<base")
        ls_goiy.Items.Add("<bdo")
        ls_goiy.Items.Add("<big")
        ls_goiy.Items.Add("<blockquote")
        ls_goiy.Items.Add("<body")
        ls_goiy.Items.Add("<br")
        ls_goiy.Items.Add("<button")
        ls_goiy.Items.Add("<caption")
        ls_goiy.Items.Add("<cite")
        ls_goiy.Items.Add("<code")
        ls_goiy.Items.Add("<col")
        ls_goiy.Items.Add("<colgroup")
        ls_goiy.Items.Add("<dd")
        ls_goiy.Items.Add("<del")
        ls_goiy.Items.Add("<dfn")
        ls_goiy.Items.Add("<div")
        ls_goiy.Items.Add("<dl")
        ls_goiy.Items.Add("<dt")
        ls_goiy.Items.Add("<em")
        ls_goiy.Items.Add("<fieldset")
        ls_goiy.Items.Add("<form")
        ls_goiy.Items.Add("<frame")
        ls_goiy.Items.Add("<frameset")
        ls_goiy.Items.Add("<h1")
        ls_goiy.Items.Add("<h2")
        ls_goiy.Items.Add("<h3")
        ls_goiy.Items.Add("<h4")
        ls_goiy.Items.Add("<h5")
        ls_goiy.Items.Add("<h6")
        ls_goiy.Items.Add("<head")
        ls_goiy.Items.Add("<hr")
        ls_goiy.Items.Add("<html")
        ls_goiy.Items.Add("<i")
        ls_goiy.Items.Add("<iframe")
        ls_goiy.Items.Add("<img")
        ls_goiy.Items.Add("<input")
        ls_goiy.Items.Add("<ins")
        ls_goiy.Items.Add("<kbd")
        ls_goiy.Items.Add("<label")
        ls_goiy.Items.Add("<legend")
        ls_goiy.Items.Add("<li")
        ls_goiy.Items.Add("<link")
        ls_goiy.Items.Add("<map")
        ls_goiy.Items.Add("<meta")
        ls_goiy.Items.Add("<noframes")
        ls_goiy.Items.Add("<noscript")
        ls_goiy.Items.Add("<object")
        ls_goiy.Items.Add("<ol")
        ls_goiy.Items.Add("<optgroup")
        ls_goiy.Items.Add("<option")
        ls_goiy.Items.Add("<p")
        ls_goiy.Items.Add("<param")
        ls_goiy.Items.Add("<pre")
        ls_goiy.Items.Add("<q")
        ls_goiy.Items.Add("<samp")
        ls_goiy.Items.Add("<script")
        ls_goiy.Items.Add("<select")
        ls_goiy.Items.Add("<small")
        ls_goiy.Items.Add("<span")
        ls_goiy.Items.Add("<strong")
        ls_goiy.Items.Add("<style")
        ls_goiy.Items.Add("<sub")
        ls_goiy.Items.Add("<sup")
        ls_goiy.Items.Add("<table")
        ls_goiy.Items.Add("<tbody")
        ls_goiy.Items.Add("<td")
        ls_goiy.Items.Add("<textarea")
        ls_goiy.Items.Add("<tfoot")
        ls_goiy.Items.Add("<th")
        ls_goiy.Items.Add("<thead")
        ls_goiy.Items.Add("<title")
        ls_goiy.Items.Add("<tr")
        ls_goiy.Items.Add("<tt")
        ls_goiy.Items.Add("<ul")
        ls_goiy.Items.Add("<var")
        'html5
        ls_goiy.Items.Add("article")
        ls_goiy.Items.Add("aside")
        ls_goiy.Items.Add("audio")
        ls_goiy.Items.Add("canvas")
        ls_goiy.Items.Add("command")
        ls_goiy.Items.Add("datalist")
        ls_goiy.Items.Add("details")
        ls_goiy.Items.Add("embed")
        ls_goiy.Items.Add("figcaption")
        ls_goiy.Items.Add("figure")
        ls_goiy.Items.Add("footer")
        ls_goiy.Items.Add("header")
        ls_goiy.Items.Add("hgroup")
        ls_goiy.Items.Add("keygen")
        ls_goiy.Items.Add("mark")
        ls_goiy.Items.Add("meter")
        ls_goiy.Items.Add("nav")
        ls_goiy.Items.Add("output")
        ls_goiy.Items.Add("progress")
        ls_goiy.Items.Add("rp")
        ls_goiy.Items.Add("rt")
        ls_goiy.Items.Add("ruby")
        ls_goiy.Items.Add("section")
        ls_goiy.Items.Add("source")
        ls_goiy.Items.Add("summary")
        ls_goiy.Items.Add("time")
        ls_goiy.Items.Add("video")
        ls_goiy.Items.Add("wbr")
        'ham khong khuyen dung
        ls_goiy.Items.Add("applet")
        ls_goiy.Items.Add("basefont")
        ls_goiy.Items.Add("center")
        ls_goiy.Items.Add("dir")
        ls_goiy.Items.Add("font")
        ls_goiy.Items.Add("isindex")
        ls_goiy.Items.Add("menu")
        ls_goiy.Items.Add("s")
        ls_goiy.Items.Add("u")
        ls_goiy.Items.Add("strike")
        'goi y khac
        ls_goiy.Items.Add("href")
        ls_goiy.Items.Add("src")
        ls_goiy.Items.Add("name")
        ls_goiy.Items.Add("class")
        ls_goiy.Items.Add("target")
        ls_goiy.Items.Add("onmouseover")
        ls_goiy.Items.Add("self.status")
        ls_goiy.Items.Add("onmouseout")
        ls_goiy.Items.Add("onclick")
        ls_goiy.Items.Add("alert")
        ls_goiy.Items.Add("confirm")
        ls_goiy.Items.Add("p")
        ls_goiy.Items.Add("text")
        ls_goiy.Items.Add("input")
        ls_goiy.Items.Add("password")
        ls_goiy.Items.Add("email")
        ls_goiy.Items.Add("none")
        ls_goiy.Items.Add("display")
        ls_goiy.Items.Add("width")
        ls_goiy.Items.Add("height")
        ls_goiy.Items.Add("align")
        ls_goiy.Items.Add("left")
        ls_goiy.Items.Add("right")
        ls_goiy.Items.Add("value")
        ls_goiy.Items.Add("alt")
        ls_goiy.Items.Add("vspace")
        ls_goiy.Items.Add("archive")
        ls_goiy.Items.Add("bgsound")
        ls_goiy.Items.Add("loop")
        ls_goiy.Items.Add("infinite")
        ls_goiy.Items.Add("n")
        ls_goiy.Items.Add("bgcolor")
        ls_goiy.Items.Add("vlink")
        ls_goiy.Items.Add("alink")
        ls_goiy.Items.Add("leftmargin")
        ls_goiy.Items.Add("topmargin")
        ls_goiy.Items.Add("commend")
        ls_goiy.Items.Add("div")
        ls_goiy.Items.Add("color")
        ls_goiy.Items.Add("face")
        ls_goiy.Items.Add("frame")
        ls_goiy.Items.Add("marginwidth")
        ls_goiy.Items.Add("marginheight")
        ls_goiy.Items.Add("no")
        ls_goiy.Items.Add("auto")
        ls_goiy.Items.Add("scrolling")
        ls_goiy.Items.Add("noresize")
        ls_goiy.Items.Add("frameborder")
        ls_goiy.Items.Add("framespacing")
        ls_goiy.Items.Add("rows")
        ls_goiy.Items.Add("number")
        ls_goiy.Items.Add("telephone")
        ls_goiy.Items.Add("noshade")
        ls_goiy.Items.Add("public")
        ls_goiy.Items.Add("en")
        ls_goiy.Items.Add("l")
        ls_goiy.Items.Add("reset")
        ls_goiy.Items.Add("checkbox")

    End Sub

    Private Sub bt_add_Click(sender As Object, e As EventArgs) Handles bt_add.Click
        txt_data.Text = txt_data.Text + txt_auto_txt.Text
        txt_auto_txt.Text = ""

    End Sub

    Private Sub bt_back_Click(sender As Object, e As EventArgs) Handles bt_back.Click
        maytinh1.Enabled = True
        Me.Hide()
        Me.Close()
    End Sub

    Private Sub bt_move_Click(sender As Object, e As EventArgs) Handles bt_move.Click
        maytinh1.txt.Text = txt_data.Text
        MsgBox("Chuyển thành công!")
    End Sub

    Private Sub txt_auto_txt_TextChanged(sender As Object, e As EventArgs) Handles txt_auto_txt.TextChanged
        Dim count As Integer = (ls_goiy.Items.Count - 1)
        Dim words As String
        For a1 = 0 To count
            words = ls_goiy.Items.Item(a1)
            Dim aString As String = Replace(words.ToLower, "<", "")
            If InStr(words.ToLower, txt_auto_txt.Text.ToLower) Then
                'If InStr("<", words.ToLower) Then
                ls_goiy.SelectedItem = words
                If Len(txt_auto_txt.Text) > 4 Then
                    txt_data.Text = txt_data.Text + words.ToLower & ">"
                    txt_auto_txt.Text = ""
                End If
                ' End If
            ElseIf InStr("</" & aString, txt_auto_txt.Text.ToLower) Then
                ls_goiy.SelectedItem = words
                If Len(txt_auto_txt.Text) > 5 Then
                    txt_data.Text = txt_data.Text + "</" & aString & ">"
                    txt_auto_txt.Text = ""
                End If
            ElseIf InStr(aString, txt_auto_txt.Text.ToLower) Then
                ls_goiy.SelectedItem = words
                If Len(txt_auto_txt.Text) > 2 Then
                    txt_data.Text = txt_data.Text + aString
                    txt_auto_txt.Text = ""
                End If
            ElseIf InStr("/>", txt_auto_txt.Text.ToLower) Then
                ls_goiy.SelectedItem = words
                If Len(txt_auto_txt.Text) > 1 Then
                    txt_data.Text = txt_data.Text + "/>"
                    txt_auto_txt.Text = ""
                End If
                ''
            ElseIf (words.ToLower = txt_auto_txt.Text.ToLower) Then
                'If InStr("<", words.ToLower) Then
                ls_goiy.SelectedItem = words
                If Len(txt_auto_txt.Text) > 0 Then
                    txt_data.Text = txt_data.Text + words.ToLower
                    txt_auto_txt.Text = ""
                End If
            End If

        Next
    End Sub


    Private Sub txt_auto_txt_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_auto_txt.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_data.Text = txt_data.Text + txt_auto_txt.Text
            txt_auto_txt.Text = ""
        End If
    End Sub
End Class