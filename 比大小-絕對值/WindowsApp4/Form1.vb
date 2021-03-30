Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TextBox1.Text = "請輸入數字"
        Me.TextBox2.Text = "請輸入數字"

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        Me.TextBox1.Text = ""
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        Me.TextBox2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Long
        Dim b As Long
        a = TextBox1.Text
        b = TextBox2.Text
        Label1.Text = "| " + TextBox1.Text + " |"
        Label2.Text = "| " + TextBox2.Text + " |"
        If Math.Abs(a) > Math.Abs(b) Then
            Label3.Text = ">"
        ElseIf Math.Abs(a) < Math.Abs(b) Then
            Label3.Text = "<"
        Else
            Label3.Text = "="
        End If
    End Sub


End Class
