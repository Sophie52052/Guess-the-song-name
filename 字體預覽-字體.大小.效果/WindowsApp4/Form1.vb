Public Class Form1

    Dim fs As System.Drawing.FontStyle
    Dim fm As System.Drawing.FontFamily
    Dim f As System.Drawing.Font
    Dim fSize As Single

    'FONT'
    Private Sub font1RadioButton_Click(sender As Object, e As EventArgs) Handles font1RadioButton.Click
        fs = ShowLabel.Font.Style

        If (FontTextBox.Text = "") Then
            fSize = 9
        End If

        ShowLabel.Font = New Font("標楷體", fSize, fs)
    End Sub

    Private Sub font2RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles font2RadioButton.CheckedChanged
        fs = ShowLabel.Font.Style

        If (FontTextBox.Text = "") Then
            fSize = 9
        End If

        ShowLabel.Font = New Font("新細明體", fSize, fs)
    End Sub

    'FONTSIZE'
    Private Sub Size9RadioButton_Click(sender As Object, e As EventArgs) Handles Size9RadioButton.Click
        fs = ShowLabel.Font.Style
        fm = ShowLabel.Font.FontFamily
        ShowLabel.Font = New Font(fm, 9, fs)
        FontTextBox.Text = "9"
    End Sub

    Private Sub Size10RadioButton_Click(sender As Object, e As EventArgs) Handles Size10RadioButton.Click
        fs = ShowLabel.Font.Style
        fm = ShowLabel.Font.FontFamily
        ShowLabel.Font = New Font(fm, 10, fs)
        FontTextBox.Text = "10"

    End Sub

    Private Sub Size11RadioButton_Click(sender As Object, e As EventArgs) Handles Size11RadioButton.Click
        fs = ShowLabel.Font.Style
        fm = ShowLabel.Font.FontFamily
        ShowLabel.Font = New Font(fm, 11, fs)
        FontTextBox.Text = "11"
    End Sub

    Private Sub Size12RadioButton_Click(sender As Object, e As EventArgs) Handles Size12RadioButton.Click
        fs = ShowLabel.Font.Style
        fm = ShowLabel.Font.FontFamily
        ShowLabel.Font = New Font(fm, 12, fs)
        FontTextBox.Text = "12"
    End Sub

    '+/-'
    Private Sub PLUSButton_Click(sender As Object, e As EventArgs) Handles PLUSButton.Click

        If (FontTextBox.Text = "") Then
            FontTextBox.Text = "9"
        End If

        fs = ShowLabel.Font.Style
        fm = ShowLabel.Font.FontFamily
        FontTextBox.Text = FontTextBox.Text + 1
        fSize = FontTextBox.Text
        ShowLabel.Font = New Font(fm, fSize, fs)
    End Sub

    Private Sub MinusButton_Click(sender As Object, e As EventArgs) Handles MinusButton.Click

        If (FontTextBox.Text = "") Then
            FontTextBox.Text = "9"
        End If

        fs = ShowLabel.Font.Style
        fm = ShowLabel.Font.FontFamily
        FontTextBox.Text = FontTextBox.Text - 1
        fSize = FontTextBox.Text

        If fSize < 1 Then
            MsgBox("字體錯誤",, "警告")
            ShowLabel.Font = New Font(fm, 1, fs)
            FontTextBox.Text = "1"
        Else
            ShowLabel.Font = New Font(fm, fSize, fs)
        End If

    End Sub

    '效果'
    Private Sub boldCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles boldCheckBox.CheckedChanged
        FontChang()
    End Sub

    Private Sub ItalicCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ItalicCheckBox.CheckedChanged
        FontChang()
    End Sub

    Private Sub UnderlineCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles UnderlineCheckBox.CheckedChanged
        FontChang()
    End Sub

    Private Sub StrikeThroughCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles StrikeThroughCheckBox.CheckedChanged
        FontChang()
    End Sub

    Sub FontChang()

        Dim f1 As FontStyle
        If boldCheckBox.Checked Then
            f1 = FontStyle.Bold
        Else
            f1 = FontStyle.Regular
        End If

        Dim f2 As FontStyle
        If ItalicCheckBox.Checked Then
            f2 = FontStyle.Italic
        Else
            f2 = FontStyle.Regular
        End If

        Dim f3 As FontStyle
        If StrikeThroughCheckBox.Checked Then
            f3 = FontStyle.Strikeout
        Else
            f3 = FontStyle.Regular
        End If

        Dim f4 As FontStyle
        If UnderlineCheckBox.Checked Then
            f4 = FontStyle.Underline
        Else
            f4 = FontStyle.Regular
        End If

        fm = ShowLabel.Font.FontFamily

        If (FontTextBox.Text = "") Then
            fSize = "9"
        End If

        ShowLabel.Font = New Font(fm, fSize, f1 Or f2 Or f3 Or f4)

    End Sub

    '恢復原值'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        font1RadioButton.Checked = False
        font2RadioButton.Checked = False

        Size9RadioButton.Checked = False
        Size10RadioButton.Checked = False
        Size11RadioButton.Checked = False
        Size12RadioButton.Checked = False

        boldCheckBox.Checked = False
        ItalicCheckBox.Checked = False
        StrikeThroughCheckBox.Checked = False
        UnderlineCheckBox.Checked = False

        fs = ShowLabel.Font.Style
        fm = ShowLabel.Font.FontFamily

        ShowLabel.Font = New Font("新細明體", 9, fs)
        FontTextBox.Text = ""
    End Sub

    '關閉'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim X As Long '區域變數
        X = MsgBox(“確定要關閉視窗”, 4 + 64, “警告”) 'MsgBox設計
        If X = 6 Then End '確定關閉
    End Sub


End Class
