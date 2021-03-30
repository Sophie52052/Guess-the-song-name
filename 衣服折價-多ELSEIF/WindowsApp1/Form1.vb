Public Class Form1
    Dim A As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TextBox1.Text = "請輸入件數"
    End Sub
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(TextBox1.Text) = False Then
            MsgBox("輸入不正確",, "警告") : Exit Sub : End If
        If TextBox1.Text = 2 Then
            Label5.Text = TextBox1.Text * 200 * 0.95
        ElseIf 3 <= TextBox1.Text And TextBox1.Text <= 5 Then '不可以寫聯立要用AND
            Label5.Text = TextBox1.Text * 200 * 0.9
        ElseIf 6 <= TextBox1.Text And TextBox1.Text <= 10 Then
            Label5.Text = TextBox1.Text * 200 * 0.8
        ElseIf TextBox1.Text > 10 Then
            Label5.Text = TextBox1.Text * 200 * 0.7
        ElseIf TextBox1.Text = 1 Then
            Label5.Text = TextBox1.Text * 200 * 1

        Else
            MsgBox("輸入不正確",, "警告")
        End If
    End Sub


End Class
