Public Class Form1
    Dim age As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Focus()

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False

        age = TextBox1.Text

        Select Case age
            Case 1 To 5
                Label1.Visible = True
        ' The following is the only Case clause that evaluates to True.
            Case 6 To 11
                Label1.Visible = True
                Label2.Visible = True
                Label5.Visible = True
            Case 12 To 17
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label6.Visible = True
            Case Is >= 18
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
            Case Else
                MsgBox("請輸入正確年紀",, "警告")
        End Select
    End Sub


End Class
