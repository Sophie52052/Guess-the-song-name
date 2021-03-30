Public Class Form2

    Dim i As Long
    Dim X As Long

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i = 0
    End Sub

    Private Sub Button2_1_Click(sender As Object, e As EventArgs) Handles Button2_1.Click

        If TextBox1.Text = "Sophie" Then
            i = 0
            Me.Close()
            Form1.Show()
        Else
            i = i + 1
            If i = 3 Then
                MsgBox(“強制關閉”, , “警告”)
                End
            Else
                MsgBox(“你還有" & 3 - i & "次機會”, , “警告”)
                TextBox1.Focus()
            End If
        End If

    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Close()
        Form1.Close()
    End Sub


    'Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    '    X = MsgBox(“確定要關閉視窗”, vbYesNo + vbInformation, “警告”) '
    '    If X = 6 Then End

    'End Sub

    Private Sub Button2_2_Click(sender As Object, e As EventArgs) Handles Button2_2.Click
        Me.Close()
        Form1.Close()
    End Sub
End Class