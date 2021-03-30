Public Class Form1
    Dim a, b As Long
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Timer1.Enabled = True Then
            Timer1.Enabled = False
        Else
            Timer1.Enabled = True
            Timer1.Interval = Timer1.Interval
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Interval -= 10
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Interval += 10
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim c
        c = MsgBox("是否要退出系統?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "退出")
        If c = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        Select Case a
            Case 0
                PictureBox1.Left += 50
                If PictureBox1.Left >= Me.ClientSize.Width - PictureBox1.Width Then
                    PictureBox1.Left = Me.ClientSize.Width - PictureBox1.Width
                    a = 1
                End If
            Case 1
                PictureBox1.Top += 50
                If PictureBox1.Top + PictureBox1.Height >= Me.ClientSize.Height Then
                    PictureBox1.Top = Me.ClientSize.Height - PictureBox1.Height
                    a = 2
                End If
            Case 2
                PictureBox1.Left -= 50
                If PictureBox1.Left <= 0 Then
                    PictureBox1.Left = 0
                    a = 3
                End If
            Case 3
                PictureBox1.Top -= 50
                If PictureBox1.Top <= 0 Then
                    PictureBox1.Top = 0
                    a = 0
                    b = b + 1
                    Label4.Text = b
                End If
        End Select
    End Sub
End Class
