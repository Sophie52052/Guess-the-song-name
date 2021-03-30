Public Class Form1
    Dim array1() As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text

        For i = 0 To array1.Length - 1

            Label4.Text = TextBox1.Text & array1(i)
        Next
    End Sub

End Class
