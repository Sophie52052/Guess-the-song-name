Public Class Form1
    Dim max As Long
    Dim min As Long
    Dim avg As Long
    Dim number As Long
    Dim x As Long
    Dim sum As Long
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        x = Val(TextBox1.Text)
        'avg = 0

        If x > 0 Then
            If number = 0 Then '初始 不能用NUMBER=1
                max = x
                min = x
            Else
                If x > max Then
                    max = x
                End If
                If x < min Then
                    min = x
                End If
            End If
            number = number + 1
            sum = x + sum
            avg = sum / number
            Label1.Text = "最大值：" & max
            Label2.Text = "最小值：" & min
            Label3.Text = "平均值：" & avg
            Label4.Text = "個數值：" & number


        ElseIf x = -1 Then
            Me.Close()
        ElseIf x <= 0 Then
            MsgBox("您輸入的不是正整數")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
