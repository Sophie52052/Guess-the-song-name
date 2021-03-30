Public Class Form1
    Dim H1, H2, H3, H4, i As Long
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = H1 & "    " & H2 & "    " & H3 & "    " & H4 & "    "
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Time(,) = {{4, 5, 4, 3, 4}, {5, 3, 4, 4, 4}, {4, 4, 5, 4.5, 4.5}, {3, 4, 3, 4, 5}}
        For i = 0 To 4
            H1 += Time(0, i)
            H2 += Time(1, i)
            H3 += Time(2, i)
            H4 += Time(3, i)
        Next
        H1 *= 130
        H2 *= 130
        H3 *= 130
        H4 *= 130
    End Sub
End Class
