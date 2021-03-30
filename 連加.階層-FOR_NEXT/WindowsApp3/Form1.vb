Public Class Form1

    Dim SUM1 As Long
    Dim i1 As Long
    Dim SUM2 As Long
    Dim i2 As Long
    Dim n As Long
    Dim A As Long

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i1 = 2 To 100 Step 2
            SUM1 = SUM1 + i1
        Next i1


        Label2.Text = SUM1
        Label4.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        i2 = TextBox1.Text 'i2要在前面'

        SUM2 = 1


        For i2 = 1 To i2.ToString
            SUM2 = SUM2 * i2
        Next

        Label4.Text = SUM2

    End Sub
End Class
