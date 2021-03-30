<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2_1 = New System.Windows.Forms.Button()
        Me.Button2_2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(24, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "密碼："
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(80, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Button2_1
        '
        Me.Button2_1.Location = New System.Drawing.Point(74, 72)
        Me.Button2_1.Name = "Button2_1"
        Me.Button2_1.Size = New System.Drawing.Size(50, 23)
        Me.Button2_1.TabIndex = 2
        Me.Button2_1.Text = "確認"
        Me.Button2_1.UseVisualStyleBackColor = True
        '
        'Button2_2
        '
        Me.Button2_2.Location = New System.Drawing.Point(130, 72)
        Me.Button2_2.Name = "Button2_2"
        Me.Button2_2.Size = New System.Drawing.Size(50, 23)
        Me.Button2_2.TabIndex = 3
        Me.Button2_2.Text = "結束"
        Me.Button2_2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 116)
        Me.Controls.Add(Me.Button2_2)
        Me.Controls.Add(Me.Button2_1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "密碼確認"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2_1 As Button
    Friend WithEvents Button2_2 As Button
End Class
