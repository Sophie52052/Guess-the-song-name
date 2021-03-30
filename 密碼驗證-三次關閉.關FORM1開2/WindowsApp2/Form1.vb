Public Class Form1

    Dim A As Long
    Dim B As Long
    Dim C As Long




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Form2.ShowDialog()
        Me.Hide()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'char(48 ~ 57)---0~9
        If e.KeyChar = Chr(48) Or e.KeyChar = Chr(49) Or e.KeyChar = Chr(50) Or e.KeyChar = Chr(51) Or e.KeyChar = Chr(52) Or e.KeyChar = Chr(53) Or e.KeyChar = Chr(54) Or e.KeyChar = Chr(55) Or e.KeyChar = Chr(56) Or e.KeyChar = Chr(57) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If IsNumeric(Trim(TextBox1.Text)) = False Then
            MsgBox(“請輸入數字”, 0 + 48, “警告”)
            TextBox1.Text = ""
            Exit Sub
        End If
        If TextBox1.Text > 100 Or TextBox1.Text < 0 Or TextBox1.Text = "" Or TextBox2.Text > 100 Or TextBox2.Text < 0 Or TextBox2.Text = "" Or TextBox3.Text > 100 Or TextBox3.Text < 0 Or TextBox3.Text = "" Then
            MsgBox(“金額請介於0~100”, 0 + 48, “警告”)

            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
