Public Class Form1

    Dim money As Long

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = Nothing Then
            TextBox1.Text = "0"
        End If

        If TextBox2.Text = Nothing Then
            TextBox2.Text = "0"
        End If

        If TextBox3.Text = Nothing Then
            TextBox3.Text = "0"
        End If

        If TextBox4.Text = Nothing Then
            TextBox4.Text = "0"
        End If


        money = TextBox1.Text * 30 + TextBox2.Text * 70 + TextBox3.Text * 65 + TextBox4.Text * 99

        Label11.Text = "=總價" & money & "元"



        If RadioButton2.Checked = True And money <= 300 Then
            money = money + 30
            Label11.Text = Label11.Text & "+" & "運費30元"
        End If

        If CheckBox1.Checked = True Then
            money = money * 0.9
            Label11.Text = Label11.Text & "+" & "打9折"
        End If

        If CheckBox2.Checked = True Then
            money = money * 0.8
            Label11.Text = Label11.Text & "+" & "打8折"
        End If

        TextBox5.Text = money
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        money = 0
        Label11.Text = "明細"
        RadioButton1.Checked = True
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        TextBox5.Text = ""
    End Sub
End Class
