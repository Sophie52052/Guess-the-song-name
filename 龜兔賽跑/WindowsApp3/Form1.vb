Public Class Form1
    Dim a As Long
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Timer1.Interval = 200
        If RadioButton1.Checked = True Then
            PictureBox2.Left += 20
        End If

        If RadioButton2.Checked = True Then
            PictureBox2.Left += 30
        End If

        If RadioButton3.Checked = True Then
            PictureBox2.Left += 40

        End If
        If PictureBox2.Left >= Me.ClientSize.Width - PictureBox2.Width Then
            PictureBox2.Left = Me.ClientSize.Width - PictureBox2.Width
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Left += 30
        If PictureBox1.Left >= Me.ClientSize.Width - PictureBox1.Width Then
            PictureBox1.Left = Me.ClientSize.Width - PictureBox1.Width
        End If



        If (PictureBox1.Left >= PictureBox3.Left) And (PictureBox1.Left <= PictureBox3.Left + PictureBox3.Width) Then
            Timer1.Interval = 2000
        Else
            Timer1.Interval = 200
        End If

        If PictureBox1.Left = Me.ClientSize.Width - PictureBox1.Width Then
            Timer1.Stop()
            MsgBox("兔子贏了")

        End If

        If PictureBox2.Left = Me.ClientSize.Width - PictureBox1.Width Then
            Timer1.Stop()
            MsgBox("烏龜贏了")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim X As Long
        X = MsgBox("", vbOKCancel, "")
        If X = vbOK Then                              ' 若使用者按下 [是]
            End                                                 ' 若使用者按下 [否]

        End If
    End Sub
End Class
