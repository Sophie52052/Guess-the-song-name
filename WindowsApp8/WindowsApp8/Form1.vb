Public Class Form1
    Dim C(0), max, min, total, ave
    Dim i = 0

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '檢查輸入是否為有效數值
        If IsNumeric(TextBox1.Text) And Val(TextBox1.Text) >= 0 And Val(TextBox1.Text) <= 100 Then
            If i > UBound(C) Then
                ReDim Preserve C(i) '保留原陣列的資料內容，調整陣列大小
            End If
            C(i) = Val(TextBox1.Text)
            TextBox1.Clear() '成績進入陣列，TextBox1清空
        Else
            MsgBox("請輸入有效數值")
        End If

        '成績由高到低排序
        Dim mul As String
        Array.Sort(C)
        Array.Reverse(C) '將陣列由小至大排序，再反轉順序
        For Each num In C
            mul += num.ToString & "/"
        Next
        Label1.Text = "成績由高到低排序:" & mul

        '最高分/最低分
        max = C(0)
        min = C(0)
        For i = 0 To UBound(C)
            If C(i) < min Then
                min = C(i)
            End If
            If C(i) > max Then
                max = C(i)
            End If
        Next
        Label2.Text = "最高分:" & max
        Label3.Text = "最低分:" & min

        '平均
        total = 0
        For i = 0 To UBound(C)
            total += C(i)
        Next
        Label4.Text = "平均:" & Math.Round(total / (UBound(C) + 1), 2) '計算至小數第二位

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim result = Array.IndexOf(C, Val(TextBox2.Text)) '搜尋TextBox2.Text所輸入的值，而非字串
        If result = -1 Then '無結果傳回值為-1
            MsgBox("不在此陣列")
        Else
            Label5.Text = "位於索引值:" & result
            TextBox2.Clear()
        End If

    End Sub

End Class
