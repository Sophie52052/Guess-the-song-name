Public Class Form1
    Private Sub VIS_Click(sender As Object, e As EventArgs) Handles VIS.Click
        LTS.Visible = True
        PS.Text = "Visible"
    End Sub

    Private Sub HID_Click(sender As Object, e As EventArgs) Handles HID.Click
        LTS.Visible = False
        PS.Text = "Invisible"
    End Sub


    Private Sub BIG_Click(sender As Object, e As EventArgs) Handles BIG.Click
        LTS.Size = New Size(LTS.Size.Width + 10, LTS.Size.Height + 10)
        LTS.Location = New Point(LTS.Location.X - 5, LTS.Location.Y - 5)
    End Sub

    Private Sub SMALL_Click(sender As Object, e As EventArgs) Handles SMALL.Click
        LTS.Size = New Size(LTS.Size.Width - 10, LTS.Size.Height - 10)
        LTS.Location = New Point(LTS.Location.X + 5, LTS.Location.Y + 5)
    End Sub

    Private Sub Top_Click(sender As Object, e As EventArgs) Handles Top.Click
        LTS.Top = LTS.Top - 10
    End Sub

    Private Sub Left_Click(sender As Object, e As EventArgs) Handles Left.Click
        LTS.Left = LTS.Left - 10
    End Sub

    Private Sub Right_Click(sender As Object, e As EventArgs) Handles Right.Click
        LTS.Left = LTS.Left + 10
    End Sub

    Private Sub Botton_Click(sender As Object, e As EventArgs) Handles Botton.Click
        LTS.Top = LTS.Top + 10
    End Sub

    Private Sub THEEND_Click(sender As Object, e As EventArgs) Handles THEEND.Click
        MsgBox("你確定要結束嗎", 4 + 64, "結束")


        End
    End Sub

    Private Sub LTS_Click(sender As Object, e As EventArgs) Handles LTS.Click

    End Sub
End Class
