Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Left += 10
        If PictureBox1.Left <= -PictureBox1.Width Then
            PictureBox1.Left = Me.Width
        End If
    End Sub
End Class




'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
'    PictureBox1.Left += 10
'    If PictureBox1.Left <= -PictureBox1.Width Then
'        PictureBox1.Left = Me.Width
'    End If
'End Sub