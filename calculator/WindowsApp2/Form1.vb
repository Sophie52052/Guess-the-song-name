Public Class Checkout

    Dim money As Byte '全域變數

    Private Sub Checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '鎖總金額
        SUMTextBox.ReadOnly = True

        '加入ICON
        Dim ico As New System.Drawing.Icon("calculator.ico")
        Me.Icon = ico
    End Sub
    Private Sub NUMTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NUMTextBox.KeyPress
        'char(48 ~ 57)---0~9
        If e.KeyChar = Chr(48) Or e.KeyChar = Chr(49) Or e.KeyChar = Chr(50) Or e.KeyChar = Chr(51) Or e.KeyChar = Chr(52) Or e.KeyChar = Chr(53) Or e.KeyChar = Chr(54) Or e.KeyChar = Chr(55) Or e.KeyChar = Chr(56) Or e.KeyChar = Chr(57) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub PLUS_Click(sender As Object, e As EventArgs) Handles PLUS.Click
        'BOX判斷http://it-easy.tw/msgbox/
        If IsNumeric(Trim(NUMTextBox.Text)) = False Then MsgBox(“請輸入數字”, 0 + 48, “警告”) : NUMTextBox.Text = "" : Exit Sub '非數字處理
        If NUMTextBox.Text > 1000 Or NUMTextBox.Text < 0 Or NUMTextBox.Text = "" Then MsgBox(“金額請介於0~1000”, 0 + 48, “警告”) : NUMTextBox.Text = "" : Exit Sub '数字大小處理

        '累加
        money = money + NUMTextBox.Text '相加
        SUMTextBox.Text = Format(money, "總金額是 $####") '顯示總額
        NUM.Text = NUM.Text + 1 'label +1
        SUM.Text = SUM.Text + 1 'label +1
        NUMTextBox.Text = "" '清空NUMTextBox

    End Sub
    Private Sub ZERO_Click(sender As Object, e As EventArgs) Handles ZERO.Click
        '歸零
        money = 0 '清除緩存
        NUMTextBox.Text = "" '清除 NUMTextBox值
        SUMTextBox.Text = "總金額是 $0" '清除SUMTextBox值
        NUM.Text = "1" 'label顯示
        SUM.Text = "0" 'label顯示
    End Sub

    Private Sub CANCEL_Click(sender As Object, e As EventArgs) Handles CANCEL.Click
        '結束
        Dim X As Long '區域變數
        X = MsgBox(“確定要關閉視窗”, 4 + 64, “警告”) 'MsgBox設計
        If X = 6 Then End '確定關閉
    End Sub


End Class