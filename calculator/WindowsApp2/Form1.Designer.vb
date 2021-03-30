<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checkout
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.NUMLabel = New System.Windows.Forms.Label()
        Me.PLUS = New System.Windows.Forms.Button()
        Me.ZERO = New System.Windows.Forms.Button()
        Me.CANCEL = New System.Windows.Forms.Button()
        Me.SUMLabel = New System.Windows.Forms.Label()
        Me.NUMTextBox = New System.Windows.Forms.TextBox()
        Me.SUMTextBox = New System.Windows.Forms.TextBox()
        Me.NUM = New System.Windows.Forms.Label()
        Me.SUM = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NUMLabel
        '
        Me.NUMLabel.AutoSize = True
        Me.NUMLabel.Font = New System.Drawing.Font("微軟正黑體", 10.0!)
        Me.NUMLabel.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.NUMLabel.Location = New System.Drawing.Point(42, 29)
        Me.NUMLabel.Name = "NUMLabel"
        Me.NUMLabel.Size = New System.Drawing.Size(126, 18)
        Me.NUMLabel.TabIndex = 0
        Me.NUMLabel.Text = "請輸入第     項金額"
        '
        'PLUS
        '
        Me.PLUS.Location = New System.Drawing.Point(91, 128)
        Me.PLUS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PLUS.Name = "PLUS"
        Me.PLUS.Size = New System.Drawing.Size(99, 33)
        Me.PLUS.TabIndex = 1
        Me.PLUS.Text = "累加"
        Me.PLUS.UseVisualStyleBackColor = True
        '
        'ZERO
        '
        Me.ZERO.Location = New System.Drawing.Point(91, 177)
        Me.ZERO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ZERO.Name = "ZERO"
        Me.ZERO.Size = New System.Drawing.Size(99, 33)
        Me.ZERO.TabIndex = 2
        Me.ZERO.Text = "歸零"
        Me.ZERO.UseVisualStyleBackColor = True
        '
        'CANCEL
        '
        Me.CANCEL.Location = New System.Drawing.Point(91, 223)
        Me.CANCEL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CANCEL.Name = "CANCEL"
        Me.CANCEL.Size = New System.Drawing.Size(99, 33)
        Me.CANCEL.TabIndex = 3
        Me.CANCEL.Text = "結束"
        Me.CANCEL.UseVisualStyleBackColor = True
        '
        'SUMLabel
        '
        Me.SUMLabel.AutoSize = True
        Me.SUMLabel.Font = New System.Drawing.Font("微軟正黑體", 10.0!)
        Me.SUMLabel.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.SUMLabel.Location = New System.Drawing.Point(42, 75)
        Me.SUMLabel.Name = "SUMLabel"
        Me.SUMLabel.Size = New System.Drawing.Size(182, 18)
        Me.SUMLabel.TabIndex = 4
        Me.SUMLabel.Text = "目前已累積     項，合計金額"
        '
        'NUMTextBox
        '
        Me.NUMTextBox.Font = New System.Drawing.Font("新細明體", 10.0!)
        Me.NUMTextBox.Location = New System.Drawing.Point(173, 26)
        Me.NUMTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NUMTextBox.Name = "NUMTextBox"
        Me.NUMTextBox.Size = New System.Drawing.Size(132, 23)
        Me.NUMTextBox.TabIndex = 5
        '
        'SUMTextBox
        '
        Me.SUMTextBox.Font = New System.Drawing.Font("新細明體", 10.0!)
        Me.SUMTextBox.Location = New System.Drawing.Point(229, 72)
        Me.SUMTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SUMTextBox.Name = "SUMTextBox"
        Me.SUMTextBox.Size = New System.Drawing.Size(132, 23)
        Me.SUMTextBox.TabIndex = 6
        '
        'NUM
        '
        Me.NUM.AutoSize = True
        Me.NUM.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NUM.Location = New System.Drawing.Point(104, 29)
        Me.NUM.Name = "NUM"
        Me.NUM.Size = New System.Drawing.Size(16, 17)
        Me.NUM.TabIndex = 7
        Me.NUM.Text = "1"
        '
        'SUM
        '
        Me.SUM.AutoSize = True
        Me.SUM.Font = New System.Drawing.Font("微軟正黑體", 10.0!, System.Drawing.FontStyle.Bold)
        Me.SUM.Location = New System.Drawing.Point(118, 75)
        Me.SUM.Name = "SUM"
        Me.SUM.Size = New System.Drawing.Size(16, 18)
        Me.SUM.TabIndex = 8
        Me.SUM.Text = "0"
        '
        'Checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp2.My.Resources.Resources._227866
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(430, 321)
        Me.Controls.Add(Me.SUM)
        Me.Controls.Add(Me.NUM)
        Me.Controls.Add(Me.SUMTextBox)
        Me.Controls.Add(Me.NUMTextBox)
        Me.Controls.Add(Me.SUMLabel)
        Me.Controls.Add(Me.CANCEL)
        Me.Controls.Add(Me.ZERO)
        Me.Controls.Add(Me.PLUS)
        Me.Controls.Add(Me.NUMLabel)
        Me.Font = New System.Drawing.Font("微軟正黑體", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Checkout"
        Me.Text = "結帳系統"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NUMLabel As Label
    Friend WithEvents ZERO As Button
    Friend WithEvents CANCEL As Button
    Friend WithEvents SUMLabel As Label
    Friend WithEvents NUMTextBox As TextBox
    Friend WithEvents NUM As Label
    Friend WithEvents SUM As Label
    Friend WithEvents PLUS As Button
    Friend WithEvents SUMTextBox As TextBox
End Class
