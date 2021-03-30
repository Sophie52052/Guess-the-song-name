Public Class Form1
    Dim s As Long '全域變數
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(Trim(TextBox1.Text)) = False Then MsgBox(“輸入數字”, 5 + 64, “警告”) : Exit Sub '非數字處理
        If TextBox1.Text > 1000 Or TextBox1.Text < 0 Then MsgBox(“金額需介於0~1000”, 5 + 64, “警告”) : Exit Sub '数字大小處理

        '累加
        s = s + Format(TextBox1.Text) '累加
        TextBox2.Text = Format(s) '显示相加的值
        Label3.Text = Label3.Text + 1
        Label4.Text = Label4.Text + 1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        s = 0
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label3.Text = "1"
        Label4.Text = "0"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim X As Long
        X = MsgBox(“確定要關閉視窗”, 1 + 16, “警告”)
        If X = 1 Then End
    End Sub
End Class
