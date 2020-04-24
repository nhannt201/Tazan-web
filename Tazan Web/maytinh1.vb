Imports System
Imports System.IO
Imports System.Text
Imports mshtml
Imports System.Text.RegularExpressions
' Author: Nguyen Trung Nhan
' Email: trungnhan21.12@gmail.com
' Github: https://github.com/nhannt201/Tazan-web
Public Class maytinh1
    Private Declare Function VarPtr Lib "msvbvm60.dll" Alias "VarPtr" (ByVal lpObject As String) As Integer
    Public sName, sRp1, sRp2 As String
    Dim sURL_file As String
    Dim co_open As String = False



    Private Sub maytinh1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label2.Text = "Đang nạp..."
    End Sub





    Private Sub ChạyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChạyToolStripMenuItem.Click
        tab2.Show()

        Me.TabControl1.SelectedIndex = 1

        '   Me.tab2.Text = "myTabPage1"
        Me.tab2.TabIndex = 0


        '  Me.TabControl1.TabIndex = 2


        checkhtmlfileurl()
        Me.tab2.Text = wb.DocumentTitle
    End Sub


    Sub checkhtmlfileurl()

        If co_open = True Then

            wb.Navigate(linkfile.Text)
        Else
            wb.Navigate(linkfile.Text & "\index.html")
        End If
    End Sub

    Sub checkurlfile()
        '   If InStr(".html", linkfile.Text) Then
        ' sURL_file = (linkfile.Text)
        '   ElseIf InStr(".htm", linkfile.Text) Then
        '       sURL_file = (linkfile.Text)
        '  ElseIf InStr(".xhtml", linkfile.Text) Then
        '      sURL_file = (linkfile.Text)
        '  Else
        '      sURL_file = (linkfile.Text & "\index.html")
        '  End If
        If co_open = True Then

            sURL_file = (linkfile.Text)
        Else
            sURL_file = (linkfile.Text & "\index.html")
        End If

    End Sub


    Private Sub txt_TextChanged_1(sender As Object, e As EventArgs)
        ' Dim loc As String

        'check if it contains the <html> tag and if it does select it and change the colour to red.

        'If txt.Text.Contains("<html>") Then

        'Loc = txt.Find("<html>")



        'txt.SelectionColor = Color.Blue


        'End If

        'Label1.Text = "Số dòng: " & txt.Lines.Length
    End Sub

    Private Sub wb_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wb.DocumentCompleted
        Me.tab2.Text = wb.DocumentTitle

        If Me.tab2.Text = "" Then
            Me.tab2.Text = "IE Browser"
        End If
    End Sub

    Private Sub TạoMớiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TạoMớiToolStripMenuItem.Click
        theloai.Show()
        Me.Hide()
        Me.Close()
    End Sub



    Private Sub LưuLạiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LưuLạiToolStripMenuItem.Click
        Dim unicode As Byte() = Encoding.Unicode.GetBytes(txt.Text)
        ' Cover byte unicode sang byte utf8  
        Dim utf8 As Byte() = Encoding.Convert(Encoding.Unicode, Encoding.UTF8, unicode)
        ' chuyển từ mảng byte utf8 về dạng string  
        Dim szDuLieuUTF8 As String = Encoding.UTF8.GetString(utf8)
        checkurlfile()

        Dim FILE_NAME As String = sURL_file

        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            objWriter.Write("<meta charset=utf-8>" & szDuLieuUTF8)
            objWriter.Close()


        Else

            MsgBox("Không thể lưu tập tin !")

        End If

    End Sub

    Private Sub LưuLạiVàoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LưuLạiVàoToolStripMenuItem.Click
        Dim unicode As Byte() = Encoding.Unicode.GetBytes(txt.Text)
        ' Cover byte unicode sang byte utf8  
        Dim utf8 As Byte() = Encoding.Convert(Encoding.Unicode, Encoding.UTF8, unicode)
        ' chuyển từ mảng byte utf8 về dạng string  
        Dim szDuLieuUTF8 As String = Encoding.UTF8.GetString(utf8)
        sd.Filter = "HTML Files (*.html*)|*.htm"
        If sd.ShowDialog = Windows.Forms.DialogResult.OK _
        Then
            My.Computer.FileSystem.WriteAllText _
            (sd.FileName, szDuLieuUTF8, True)
        End If
    End Sub


    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        End
    End Sub


    Private Sub TắtMàuHTMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TắtMàuHTMLToolStripMenuItem.Click
        checkurlfile()

        If System.IO.File.Exists(sURL_file) = True Then
            Dim FILE_NAME As String = sURL_file

            Dim objReader As New System.IO.StreamReader(FILE_NAME)

            txt.Text = objReader.ReadToEnd

            objReader.Close()

        Else

            MsgBox("Không thể nạp dữ liệu !")

        End If
        txt.ForeColor = Color.Black


    End Sub

    Private Sub HiệnMàuHTMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HiệnMàuHTMLToolStripMenuItem.Click
        code_color()
    End Sub
    Sub code_color()
        Dim wordsRED As New List(Of String)
        Dim wordsBLUE As New List(Of String)
        Dim wordsPurple As New List(Of String)
        Dim wordsGREEN As New List(Of String)

        'red
        wordsRED.Add("RED")
        wordsRED.Add("HTTP-EQUIV")
        wordsRED.Add("http-equiv")
        wordsRED.Add("CONTENT")
        wordsRED.Add("content")
        wordsRED.Add("type")
        wordsRED.Add("TYPE")
        wordsRED.Add("rel")
        wordsRED.Add("REL")
        wordsRED.Add("href")
        wordsRED.Add("HREF")
        wordsRED.Add("BGCOLOR")
        wordsRED.Add("bgcolor")
        wordsRED.Add("background")
        wordsRED.Add("BACKGROUND")
        wordsRED.Add("background-color")
        wordsRED.Add("LEFTMARGIN")
        wordsRED.Add("leftmargin")
        wordsRED.Add("TOPMARGIN")
        wordsRED.Add("topmargin")
        wordsRED.Add("MARGINWIDTH")
        wordsRED.Add("marginwidth")
        wordsRED.Add("MARGINHEIGHT")
        wordsRED.Add("marginheight")
        wordsRED.Add("ONLOAD")
        wordsRED.Add("onload")
        wordsRED.Add("WIDTH")
        wordsRED.Add("width")
        wordsRED.Add("BORDER")
        wordsRED.Add("border")
        wordsRED.Add("CELLPADDING")
        wordsRED.Add("cellpadding")
        wordsRED.Add("CELLSPACING")
        wordsRED.Add("cellspacing")
        wordsRED.Add("SRC")
        wordsRED.Add("src")
        wordsRED.Add("COLSPAN")
        wordsRED.Add("colspan")
        wordsRED.Add("ROWSPAN")
        wordsRED.Add("rowspan")
        wordsRED.Add("alt")
        wordsRED.Add("ALT")
        wordsRED.Add("height")
        wordsRED.Add("HEIGHT")
        wordsRED.Add("ONMOUSEOVER")
        wordsRED.Add("onmouseover")
        wordsRED.Add("ONMOUSEOUT")
        wordsRED.Add("onmouseout")
        wordsRED.Add("NAME")
        wordsRED.Add("name")
        wordsRED.Add("valign")
        wordsRED.Add("VALIGN")
        wordsRED.Add("align")
        wordsRED.Add("ALIGN")
        wordsRED.Add("class")
        wordsRED.Add("CLASS")
        wordsRED.Add("id")
        wordsRED.Add("ID")
        wordsRED.Add("title")
        wordsRED.Add("lang")
        'blue
        wordsBLUE.Add("<meta>")
        wordsBLUE.Add("<HTML>")
        wordsBLUE.Add("</HTML>")
        wordsBLUE.Add("<html>")
        wordsBLUE.Add("</html>")
        wordsBLUE.Add("</meta>")
        wordsBLUE.Add("<html ")
        wordsBLUE.Add(">")
        wordsBLUE.Add("<")
        wordsBLUE.Add("<meta")
        wordsBLUE.Add("/>")
        wordsBLUE.Add("<head>")
        wordsBLUE.Add("</head>")
        wordsBLUE.Add("<HEAD>")
        wordsBLUE.Add("</HEAD>")
        wordsBLUE.Add("<META>")
        wordsBLUE.Add("</META>")
        wordsBLUE.Add("<META")
        wordsBLUE.Add("<TITLE>")
        wordsBLUE.Add("</TITLE>")
        wordsBLUE.Add("<TITLE")
        wordsBLUE.Add("<script")
        wordsBLUE.Add("<SCRIPT")
        wordsBLUE.Add("</script>")
        wordsBLUE.Add("</SCIPT>")
        wordsBLUE.Add("<h1")
        wordsBLUE.Add("</h1>")
        wordsBLUE.Add("<h1>")
        wordsBLUE.Add("<h2")
        wordsBLUE.Add("</h2>")
        wordsBLUE.Add("<h2>")
        wordsBLUE.Add("<h3")
        wordsBLUE.Add("</h3>")
        wordsBLUE.Add("<h3>")
        wordsBLUE.Add("<h4")
        wordsBLUE.Add("</h4>")
        wordsBLUE.Add("<h4>")
        wordsBLUE.Add("<h5")
        wordsBLUE.Add("</h5>")
        wordsBLUE.Add("<h5>")
        wordsBLUE.Add("<h6")
        wordsBLUE.Add("</h6>")
        wordsBLUE.Add("<h6>")
        wordsBLUE.Add("<H1")
        wordsBLUE.Add("</H1>")
        wordsBLUE.Add("<H1>")
        wordsBLUE.Add("<H2")
        wordsBLUE.Add("</H2>")
        wordsBLUE.Add("<H2>")
        wordsBLUE.Add("<H3")
        wordsBLUE.Add("</H3>")
        wordsBLUE.Add("<H3>")
        wordsBLUE.Add("<H4")
        wordsBLUE.Add("</H4>")
        wordsBLUE.Add("<H4>")
        wordsBLUE.Add("<H5")
        wordsBLUE.Add("</H5>")
        wordsBLUE.Add("<H5>")
        wordsBLUE.Add("<H6")
        wordsBLUE.Add("</H6>")
        wordsBLUE.Add("<H6>")
        wordsBLUE.Add("<p")
        wordsBLUE.Add("<p>")
        wordsBLUE.Add("</p>")
        wordsBLUE.Add("<P>")
        wordsBLUE.Add("<P")
        wordsBLUE.Add("</P>")
        wordsBLUE.Add("<body>")
        wordsBLUE.Add("</body>")
        wordsBLUE.Add("<BODY>")
        wordsBLUE.Add("</BODY>")
        wordsBLUE.Add("<center>")
        wordsBLUE.Add("</center>")
        wordsBLUE.Add("<CENTER>")
        wordsBLUE.Add("</CENTER>")
        wordsBLUE.Add("<center")
        wordsBLUE.Add("<CENTER")
        wordsBLUE.Add("<tr>")
        wordsBLUE.Add("<tr")
        wordsBLUE.Add("<TR")
        wordsBLUE.Add("<TR>")
        wordsBLUE.Add("</tr>")
        wordsBLUE.Add("</TR>")
        wordsBLUE.Add("<div>")
        wordsBLUE.Add("</div>")
        wordsBLUE.Add("<DIV>")
        wordsBLUE.Add("</DIV>")
        wordsBLUE.Add("<div")
        wordsBLUE.Add("<DIV")
        wordsBLUE.Add("<table>")
        wordsBLUE.Add("<TABLE>")
        wordsBLUE.Add("<table")
        wordsBLUE.Add("<TABLE")
        wordsBLUE.Add("</table>")
        wordsBLUE.Add("</TABLE")
        wordsBLUE.Add("<a>")
        wordsBLUE.Add("<a")
        wordsBLUE.Add("<A")
        wordsBLUE.Add("<A>")
        wordsBLUE.Add("</a>")
        wordsBLUE.Add("</A>")
        wordsBLUE.Add("<td>")
        wordsBLUE.Add("<TD>")
        wordsBLUE.Add("<td")
        wordsBLUE.Add("<TD")
        wordsBLUE.Add("</td>")
        wordsBLUE.Add("</TD>")
        wordsBLUE.Add("<img>")
        wordsBLUE.Add("<IMG>")
        wordsBLUE.Add("</img>")
        wordsBLUE.Add("</IMG>")
        wordsBLUE.Add("<img")
        wordsBLUE.Add("<IMG")
        wordsBLUE.Add("<span>")
        wordsBLUE.Add("<SPAN>")
        wordsBLUE.Add("<span")
        wordsBLUE.Add("<SPAN")
        wordsBLUE.Add("</span>")
        wordsBLUE.Add("</SPAN>")
        wordsBLUE.Add("<style>")
        wordsBLUE.Add("</style>")
        wordsBLUE.Add("</STYLE>")
        wordsBLUE.Add("<STYLE>")
        wordsBLUE.Add("<style")
        wordsBLUE.Add("<STYLE")
        wordsBLUE.Add("<tbody>")
        wordsBLUE.Add("</tbody>")
        wordsBLUE.Add("<TBODY>")
        wordsBLUE.Add("</TBODY>")
        wordsBLUE.Add("<tbody")
        wordsBLUE.Add("<TBODY")
        wordsBLUE.Add("""")
        wordsBLUE.Add("html xmlns")
        wordsBLUE.Add("<li>")
        wordsBLUE.Add("</li>")
        wordsBLUE.Add("<LI>")
        wordsBLUE.Add("</LI>")
        wordsBLUE.Add("<ul>")
        wordsBLUE.Add("</ul>")
        wordsBLUE.Add("<UL>")
        wordsBLUE.Add("</UL>")
        wordsBLUE.Add("<ul")
        wordsBLUE.Add("<UL")
        wordsBLUE.Add("<li")
        wordsBLUE.Add("<LI")
        wordsBLUE.Add("blockquote")
        wordsBLUE.Add("font size")
        wordsBLUE.Add("body")
        wordsBLUE.Add("br")
        wordsBLUE.Add("nowrap")
        'Purple
        wordsPurple.Add("Content-Type")
        wordsPurple.Add("text/html; charset=iso-8859-1")
        wordsPurple.Add("text/javascript")
        wordsPurple.Add("text/css")
        wordsPurple.Add("preloadImages();")
        wordsPurple.Add("margin: -10px 0px 0px 0px;")
        wordsPurple.Add("text/html; charset=windows-1250")
        wordsPurple.Add("window.status")
        wordsPurple.Add("#")
        wordsPurple.Add("'")
        wordsPurple.Add("portfolio")
        wordsPurple.Add("changeImages")
        wordsPurple.Add("return true")
        wordsPurple.Add(";")
        wordsPurple.Add("center")
        wordsPurple.Add(";")
        wordsPurple.Add("vlink")
        wordsPurple.Add(";")
        wordsPurple.Add("link")
        wordsPurple.Add("text/html; charset=UTF-8")
        'green
        wordsGREEN.Add("<!--")
        wordsGREEN.Add("-->")
        wordsGREEN.Add("<!")
        wordsGREEN.Add("<!DOCTYPE HTML PUBLIC & """ & "-//W3C//DTD HTML 4.01 Transitional//EN" & ">")
        If txt.Lines.Length > 0 Then
            Dim selectStart As Integer = txt.SelectionStart
            txt.Select(0, txt.Text.Length)
            txt.SelectionColor = Color.Black
            txt.DeselectAll()

            'red color words
            For Each oneWord As String In wordsRED
                Dim pos As Integer = 0

                Do While txt.Text.ToUpper.IndexOf(oneWord.ToUpper, pos) >= 0
                    pos = txt.Text.ToUpper.IndexOf(oneWord.ToUpper, pos)
                    txt.Select(pos, oneWord.Length)
                    txt.SelectionColor = Color.Red
                    pos += 1
                Loop
            Next
            txt.SelectionStart = selectStart
            'blue color words
            For Each oneWord As String In wordsBLUE
                Dim pos As Integer = 0

                Do While txt.Text.ToUpper.IndexOf(oneWord.ToUpper, pos) >= 0
                    pos = txt.Text.ToUpper.IndexOf(oneWord.ToUpper, pos)
                    txt.Select(pos, oneWord.Length)
                    txt.SelectionColor = Color.Blue
                    pos += 1
                Loop
            Next
            txt.SelectionStart = selectStart
            'Purple color words
            For Each oneWord As String In wordsPurple
                Dim pos As Integer = 0

                Do While txt.Text.ToUpper.IndexOf(oneWord.ToUpper, pos) >= 0
                    pos = txt.Text.ToUpper.IndexOf(oneWord.ToUpper, pos)
                    txt.Select(pos, oneWord.Length)
                    txt.SelectionColor = Color.Purple
                    pos += 1
                Loop
            Next
            txt.SelectionStart = selectStart
            'green color words
            For Each oneWord As String In wordsGREEN
                Dim pos As Integer = 0

                Do While txt.Text.ToUpper.IndexOf(oneWord.ToUpper, pos) >= 0
                    pos = txt.Text.ToUpper.IndexOf(oneWord.ToUpper, pos)
                    txt.Select(pos, oneWord.Length)
                    txt.SelectionColor = Color.Green
                    pos += 1
                Loop
            Next
            txt.SelectionStart = selectStart
        End If
    End Sub
    Private Sub txt_TextChanged(sender As Object, e As EventArgs) Handles txt.TextChanged
        Label1.Text = "Số dòng:" & txt.Lines.Length
    End Sub
    Private Sub r_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt.Resize
        MyPictureBox.Invalidate()
    End Sub

    Private Sub r_VScroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt.VScroll
        MyPictureBox.Invalidate()
    End Sub

    Private Sub p_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyPictureBox.Paint
        DrawRichTextBoxLineNumbers(e.Graphics)
    End Sub
    Private Sub DrawRichTextBoxLineNumbers(ByRef g As Graphics)
        'calculate font heigth as the difference in Y coordinate between line 2 and line 1
        'note that the RichTextBox text must have at least two lines. So the initial Text property of the RichTextBox should not be an empty string. It could be something like vbcrlf & vbcrlf & vbcrlf 
        Dim font_height As Single = txt.GetPositionFromCharIndex(txt.GetFirstCharIndexFromLine(2)).Y - txt.GetPositionFromCharIndex(txt.GetFirstCharIndexFromLine(1)).Y
        If font_height = 0 Then Exit Sub

        'Get the first line index and location
        Dim firstIndex As Integer = txt.GetCharIndexFromPosition(New Point(0, g.VisibleClipBounds.Y + font_height / 3))
        Dim firstLine As Integer = txt.GetLineFromCharIndex(firstIndex)
        Dim firstLineY As Integer = txt.GetPositionFromCharIndex(firstIndex).Y

        'Print on the PictureBox the visible line numbers of the RichTextBox
        g.Clear(Control.DefaultBackColor)
        Dim i As Integer = firstLine
        Dim y As Single
        Do While y < g.VisibleClipBounds.Y + g.VisibleClipBounds.Height
            y = firstLineY + 2 + font_height * (i - firstLine - 1)
            g.DrawString((i).ToString, txt.Font, Brushes.DarkBlue, MyPictureBox.Width - g.MeasureString((i).ToString, txt.Font).Width, y)
            i += 1
        Loop
        'Debug.WriteLine("Finished: " & firstLine + 1 & " " & i - 1)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        checkurlfile()

        If System.IO.File.Exists(sURL_file) = True Then
            Dim FILE_NAME As String = sURL_file

            Dim objReader As New System.IO.StreamReader(FILE_NAME)

            txt.Text = objReader.ReadToEnd

            objReader.Close()
            code_color()
        Else

            MsgBox("Không thể nạp dữ liệu !")

        End If
        Label2.Text = "Nạp 100%"
        Timer1.Enabled = False
    End Sub

    Private Sub DừngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DừngToolStripMenuItem.Click
        wb.DocumentText =
       "<meta charset=utf-8><h1>Tazan Web - Dừng lại - WebBrowser</h1>" &
       "</body></html>"
        Me.TabControl1.SelectedIndex = 0

        '   Me.tab2.Text = "myTabPage1"
        Me.tab1.TabIndex = 0
        Me.tab2.Text = "IE Browser"
        If Me.tab2.Text = "" Then
            Me.tab2.Text = "IE Browser"
        End If
    End Sub

    Private Sub ColorHTMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorHTMLToolStripMenuItem.Click

    End Sub




    Private Sub ThôngTinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinToolStripMenuItem.Click
        'MsgBox("Phần tạo được tạo bởi Nguyễn Trung Nhẫn - 2015 Ver 1.0", vbInformation, "Thông tin")
    End Sub

    Private Sub TrangChủToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrangChủToolStripMenuItem.Click

        Me.Enabled = False
        about.Show()
        'Tao form moi o dang form cu
        ' Dim mydialogbox As New aboutbox1
        '  aboutbox1.showdialog()
    End Sub

    Private Sub PhầnMềmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhầnMềmToolStripMenuItem.Click
        'MsgBox("Bản sơ khai 2015 Ver 1.0 - Bản nâng cấp 2017 Ver 1.0.0 - Dùng trình duyệt IE -> Dự kiến Update lên Mozilla ở bản sau.", vbInformation, "Thông tin")

        Me.Enabled = False
        about_soft.Show()
    End Sub

    Private Sub TìmKiếmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKiếmToolStripMenuItem.Click
        'nhap find
        sName = InputBox("Nhập từ khoá tìm kiếm")

        If sName = "" Then
            ' If sName string is empty 
            MsgBox("Vui lòng nhập một từ khoá hợp lệ!")
        Else
            ' When sName string is filled
            '   If txt.Text.Contains(sName) Then
            'MsgBox("Đã tìm thấy từ khoá này!")
            'My.Settings.key = txt.Text
            '   Else
            '       MsgBox("Không tìm thấy từ khoá cho '" & sName & "'")
            '  End If

            '
            'Will contain the position where the text was found.
            Dim textFound As Integer
            '
            'Find the first occurance of the text “box” at the beginning of the textbox through to the end of the textbox. Selected True to Highlight the text that was found and disabled searching text for the same casing.
            textFound = SearchText(sName, 0, txt.TextLength, True, False)
            '
            'Display a message with the starting position of the text if it was found. If a -1 is returned then it means it did Not find the specified text.
            '   MsgBox(textFound.ToString)

            Me.TabControl1.SelectedIndex = 0

            '   Me.tab2.Text = "myTabPage1"
            Me.tab2.TabIndex = 0
            '  Me.TabControl1.TabIndex = 2
            Try
                '   txt.SelectionStart = textFound.ToString
                '  txt.SelectionLength = textFound.ToString

                Dim sSource As String = txt.Text 'String that is being searched
                Dim sDelimStart As String = textFound.ToString 'First delimiting word
                Dim sDelimEnd As String = textFound.ToString 'Second delimiting word
                Dim nIndexStart As Integer = sSource.IndexOf(sDelimStart) 'Find the first occurrence of f1
                Dim nIndexEnd As Integer = sSource.IndexOf(sDelimEnd) 'Find the first occurrence of f2

                If nIndexStart > -1 AndAlso nIndexEnd > -1 Then '-1 means the word was not found.
                    Dim res As String = Strings.Mid(sSource, nIndexStart + sDelimStart.Length + 1, nIndexEnd - nIndexStart - sDelimStart.Length) 'Crop the text between
                    MessageBox.Show(res) 'Display
                Else
                    '  MessageBox.Show("One or both of the delimiting words were not found!")
                End If

            Catch
                MsgBox("Không tìm thấy từ khoá!")

            End Try




        End If
        'end nhap

    End Sub

    Private Sub SaoChépToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaoChépToolStripMenuItem.Click
        txt.Copy()
        MsgBox("Đã sao chép nội dung!")
    End Sub

    Private Sub CắtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CắtToolStripMenuItem.Click
        txt.Cut()
        MsgBox("Đã cắt nội dung!")
    End Sub
    Private Sub DánToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DánToolStripMenuItem.Click
        txt.Paste()
        MsgBox("Đã dán nội dung!")
    End Sub

    Private Sub TiếnTớiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiếnTớiToolStripMenuItem.Click
        If txt.CanRedo = True Then
            txt.Redo()
            LùiLạiToolStripMenuItem.Enabled = False
            TiếnTớiToolStripMenuItem.Enabled = True
        Else : Return
        End If
    End Sub

    Private Sub LùiLạiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LùiLạiToolStripMenuItem.Click
        If txt.CanUndo = True Then
            ' Undo the last operation.
            txt.Undo()
            ' Clear the undo buffer to prevent last action from being redone.
            txt.ClearUndo()
            TiếnTớiToolStripMenuItem.Enabled = False
            LùiLạiToolStripMenuItem.Enabled = True

        End If
    End Sub



    Private Sub MởTừChromeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MởTừChromeToolStripMenuItem.Click
        Try
            checkurlfile()

            NavigateWebURL(sURL_file, "chrome.exe") '//  Chrome
            '  Dim url_file_index As String = linkfile.Text + "\index.html"
            '    Process.Start("chrome.exe", url_file_index)

        Catch ex As Exception
            MsgBox("Không tìm thấy trình duyệt Chrome  trên máy bạn!", vbInformation, "Thông báo")
        End Try
    End Sub

    Private Sub MởTừCốcCốcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MởTừCốcCốcToolStripMenuItem.Click
        Try
            checkurlfile()

            NavigateWebURL(sURL_file, "CocCoc") '//  Coccoc

            '  NavigateWebURL(linkfile.Text & "\index.html", "browser.exe") '//  Coccoc
        Catch ex As Exception
            MsgBox("Không tìm thấy trình duyệt Cốc Cốc trên máy bạn!", vbInformation, "Thông báo")
        End Try
    End Sub

    Public Overloads Function SearchText(ByVal textToFind As String, Optional ByVal startPosition As Integer = 0, Optional ByVal endPosition As Integer = 0, Optional ByVal highlightText As Boolean = True, Optional ByVal matchCase As Boolean = False) As Integer
        '
        'Contains the return value of the search. IT it returns -1, then a match was not found.
        Dim i As Integer

        If endPosition < 1 Then

            If Not matchCase Then

                textToFind = textToFind.ToLower

                Dim temp As String = txt.Text.ToLower

                i = temp.IndexOf(textToFind, startPosition, Me.Text.Length)

            Else

                i = txt.Text.IndexOf(textToFind, startPosition, Me.Text.Length)

            End If

        Else

            If matchCase = False Then

                textToFind = textToFind.ToLower

                Dim temp As String = txt.Text.ToLower

                i = temp.IndexOf(textToFind, startPosition, endPosition)

            Else

                i = txt.Text.IndexOf(textToFind, startPosition, endPosition)

            End If

        End If

        If i > -1 Then

            If highlightText Then

                txt.Focus()

                txt.SelectionStart = i

                txt.SelectionLength = textToFind.Length

            End If

        End If
        '
        Return i

    End Function



    Private Sub MởTừTrìnhDuyệtMặcĐịnhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MởTừTrìnhDuyệtMặcĐịnhToolStripMenuItem.Click
        Try
            checkurlfile()

            NavigateWebURL(sURL_file, "default")
            'MicrosoftEdge

            '  Dim url_file_index As String = linkfile.Text & "\index.html"
            '   Process.Start("MicrosoftEdge.exe", url_file_index)
        Catch ex As Exception
            MsgBox("Không tìm thấy trình duyệt trên máy bạn!", vbInformation, "Thông báo")

        End Try
    End Sub

    Private Sub MởTệpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MởTệpToolStripMenuItem.Click
        Try
            Me.TabControl1.SelectedIndex = 0

            '   Me.tab2.Text = "myTabPage1"
            Me.tab1.TabIndex = 0
            Dim openFileDialog1 As System.Windows.Forms.OpenFileDialog

            openFileDialog1 = New System.Windows.Forms.OpenFileDialog()

            openFileDialog1.Filter = "HTML (*.html) |*.html;*.html"

            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                '  Console.WriteLine(openFileDialog1.FileName)
                Dim FILE_NAME As String = openFileDialog1.FileName
                linkfile.Text = openFileDialog1.FileName
                Dim objReader As New System.IO.StreamReader(FILE_NAME)

                txt.Text = objReader.ReadToEnd

                objReader.Close()
                code_color()
                co_open = True
            End If


        Catch
            MsgBox("Có lỗi xảy ra, mở tệp thất bại!")
        End Try

    End Sub

    Private Sub sd_FileOk(sender As Object, e As ComponentModel.CancelEventArgs) Handles sd.FileOk

    End Sub

    Private Sub KiểmTraCậpNhậtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KiểmTraCậpNhậtToolStripMenuItem.Click
        Me.TabControl1.SelectedIndex = 1

        '   Me.tab2.Text = "myTabPage1"
        Me.tab2.TabIndex = 0
        wb.Navigate("http://luutru360.com/tazan/update.html")
    End Sub

    Private Sub ChuyểnHTMLSangBBCODEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChuyểnHTMLSangBBCODEToolStripMenuItem.Click

        Me.Enabled = False
        '  bbcode.txt_bbcode.Text = (txt.Text)
        bbcode.Show()
        '  bbcode.txt_bbcode.Text = StripTags(bbcode.txt_bbcode.Text)
    End Sub
    ' Imports mshtml    'add a reference to this
    Function textFromHtml(ByVal htmlToParse As String) As String
        Dim htmlDocument As IHTMLDocument = New HtmlDocument
        Dim sCollect As String = ""

        htmlDocument.write(htmlToParse)
        htmlDocument.close()

        Dim allElements As IHTMLElementCollection = htmlDocument.body.all

        For Each elem As IHTMLElement In allElements
            sCollect += elem.innerText
        Next

        Return sCollect
    End Function

    Function StripTags(ByVal html As String) As String
        ' Remove HTML tags.
        Return Regex.Replace(html, "<.*?>", "")
    End Function


    Private Sub GợiÝHàmHTMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GợiÝHàmHTMLToolStripMenuItem.Click
        Me.Enabled = False
        goiy.Show()
    End Sub

    Private Sub ThayThếToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThayThếToolStripMenuItem.Click

        sRp1 = InputBox("Nhập từ khoá ban đầu (Từ khoá)")
        sRp2 = InputBox("Nhập từ khoá thay thế")
        If sRp1 = "" Then
            ' If sName string is empty 
            MsgBox("Vui lòng nhập một từ khoá hợp lệ!")
        ElseIf sRp2 = "" Then
            MsgBox("Vui lòng nhập một từ khoá hợp lệ!")
        Else
            If txt.Text.Contains(sRp1) Then
                txt.Text = txt.Text.Replace(sRp1, sRp2)
                MsgBox("Đã thay thế!")
            End If
        End If
    End Sub

    Private Sub NavigateWebURL(ByVal URL As String, Optional browser As String = "default")

        If Not (browser = "default") Then
            Try
                '// try set browser if there was an error (browser not installed)
                Process.Start(browser, URL)
            Catch ex As Exception
                '// use default browser
                Process.Start(URL)
            End Try

        Else
            '// use default browser
            Process.Start(URL)

        End If

    End Sub


End Class