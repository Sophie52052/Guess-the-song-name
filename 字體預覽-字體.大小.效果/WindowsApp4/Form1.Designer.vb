<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.font2RadioButton = New System.Windows.Forms.RadioButton()
        Me.font1RadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Size12RadioButton = New System.Windows.Forms.RadioButton()
        Me.Size11RadioButton = New System.Windows.Forms.RadioButton()
        Me.Size10RadioButton = New System.Windows.Forms.RadioButton()
        Me.Size9RadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.StrikeThroughCheckBox = New System.Windows.Forms.CheckBox()
        Me.UnderlineCheckBox = New System.Windows.Forms.CheckBox()
        Me.ItalicCheckBox = New System.Windows.Forms.CheckBox()
        Me.boldCheckBox = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FontTextBox = New System.Windows.Forms.TextBox()
        Me.PLUSButton = New System.Windows.Forms.Button()
        Me.MinusButton = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ShowLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.font2RadioButton)
        Me.GroupBox1.Controls.Add(Me.font1RadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(106, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "字體"
        '
        'font2RadioButton
        '
        Me.font2RadioButton.AutoSize = True
        Me.font2RadioButton.Location = New System.Drawing.Point(18, 45)
        Me.font2RadioButton.Name = "font2RadioButton"
        Me.font2RadioButton.Size = New System.Drawing.Size(71, 16)
        Me.font2RadioButton.TabIndex = 1
        Me.font2RadioButton.TabStop = True
        Me.font2RadioButton.Text = "新細明體"
        Me.font2RadioButton.UseVisualStyleBackColor = True
        '
        'font1RadioButton
        '
        Me.font1RadioButton.AutoCheck = False
        Me.font1RadioButton.AutoSize = True
        Me.font1RadioButton.Location = New System.Drawing.Point(18, 22)
        Me.font1RadioButton.Name = "font1RadioButton"
        Me.font1RadioButton.Size = New System.Drawing.Size(59, 16)
        Me.font1RadioButton.TabIndex = 0
        Me.font1RadioButton.TabStop = True
        Me.font1RadioButton.Text = "標楷體"
        Me.font1RadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Size12RadioButton)
        Me.GroupBox2.Controls.Add(Me.Size11RadioButton)
        Me.GroupBox2.Controls.Add(Me.Size10RadioButton)
        Me.GroupBox2.Controls.Add(Me.Size9RadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(57, 241)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(106, 71)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "大小"
        '
        'Size12RadioButton
        '
        Me.Size12RadioButton.AutoSize = True
        Me.Size12RadioButton.Location = New System.Drawing.Point(43, 45)
        Me.Size12RadioButton.Name = "Size12RadioButton"
        Me.Size12RadioButton.Size = New System.Drawing.Size(35, 16)
        Me.Size12RadioButton.TabIndex = 3
        Me.Size12RadioButton.TabStop = True
        Me.Size12RadioButton.Text = "12"
        Me.Size12RadioButton.UseVisualStyleBackColor = True
        '
        'Size11RadioButton
        '
        Me.Size11RadioButton.AutoSize = True
        Me.Size11RadioButton.Location = New System.Drawing.Point(7, 45)
        Me.Size11RadioButton.Name = "Size11RadioButton"
        Me.Size11RadioButton.Size = New System.Drawing.Size(35, 16)
        Me.Size11RadioButton.TabIndex = 2
        Me.Size11RadioButton.TabStop = True
        Me.Size11RadioButton.Text = "11"
        Me.Size11RadioButton.UseVisualStyleBackColor = True
        '
        'Size10RadioButton
        '
        Me.Size10RadioButton.AutoSize = True
        Me.Size10RadioButton.Location = New System.Drawing.Point(43, 21)
        Me.Size10RadioButton.Name = "Size10RadioButton"
        Me.Size10RadioButton.Size = New System.Drawing.Size(35, 16)
        Me.Size10RadioButton.TabIndex = 1
        Me.Size10RadioButton.TabStop = True
        Me.Size10RadioButton.Text = "10"
        Me.Size10RadioButton.UseVisualStyleBackColor = True
        '
        'Size9RadioButton
        '
        Me.Size9RadioButton.AutoSize = True
        Me.Size9RadioButton.Location = New System.Drawing.Point(7, 22)
        Me.Size9RadioButton.Name = "Size9RadioButton"
        Me.Size9RadioButton.Size = New System.Drawing.Size(29, 16)
        Me.Size9RadioButton.TabIndex = 0
        Me.Size9RadioButton.TabStop = True
        Me.Size9RadioButton.Text = "9"
        Me.Size9RadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.StrikeThroughCheckBox)
        Me.GroupBox3.Controls.Add(Me.UnderlineCheckBox)
        Me.GroupBox3.Controls.Add(Me.ItalicCheckBox)
        Me.GroupBox3.Controls.Add(Me.boldCheckBox)
        Me.GroupBox3.Location = New System.Drawing.Point(212, 160)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(109, 123)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "效果"
        '
        'StrikeThroughCheckBox
        '
        Me.StrikeThroughCheckBox.AutoSize = True
        Me.StrikeThroughCheckBox.Location = New System.Drawing.Point(19, 90)
        Me.StrikeThroughCheckBox.Name = "StrikeThroughCheckBox"
        Me.StrikeThroughCheckBox.Size = New System.Drawing.Size(72, 16)
        Me.StrikeThroughCheckBox.TabIndex = 3
        Me.StrikeThroughCheckBox.Text = "加刪除線"
        Me.StrikeThroughCheckBox.UseVisualStyleBackColor = True
        '
        'UnderlineCheckBox
        '
        Me.UnderlineCheckBox.AutoSize = True
        Me.UnderlineCheckBox.Location = New System.Drawing.Point(19, 67)
        Me.UnderlineCheckBox.Name = "UnderlineCheckBox"
        Me.UnderlineCheckBox.Size = New System.Drawing.Size(60, 16)
        Me.UnderlineCheckBox.TabIndex = 2
        Me.UnderlineCheckBox.Text = "加底線"
        Me.UnderlineCheckBox.UseVisualStyleBackColor = True
        '
        'ItalicCheckBox
        '
        Me.ItalicCheckBox.AutoSize = True
        Me.ItalicCheckBox.Location = New System.Drawing.Point(19, 44)
        Me.ItalicCheckBox.Name = "ItalicCheckBox"
        Me.ItalicCheckBox.Size = New System.Drawing.Size(48, 16)
        Me.ItalicCheckBox.TabIndex = 1
        Me.ItalicCheckBox.Text = "斜體"
        Me.ItalicCheckBox.UseVisualStyleBackColor = True
        '
        'boldCheckBox
        '
        Me.boldCheckBox.AutoSize = True
        Me.boldCheckBox.Location = New System.Drawing.Point(19, 21)
        Me.boldCheckBox.Name = "boldCheckBox"
        Me.boldCheckBox.Size = New System.Drawing.Size(48, 16)
        Me.boldCheckBox.TabIndex = 0
        Me.boldCheckBox.Text = "粗體"
        Me.boldCheckBox.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(212, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "回復正常樣式"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(142, 330)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "離開"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "字體大小："
        '
        'FontTextBox
        '
        Me.FontTextBox.Location = New System.Drawing.Point(213, 122)
        Me.FontTextBox.Name = "FontTextBox"
        Me.FontTextBox.Size = New System.Drawing.Size(24, 22)
        Me.FontTextBox.TabIndex = 6
        '
        'PLUSButton
        '
        Me.PLUSButton.Font = New System.Drawing.Font("新細明體", 10.0!)
        Me.PLUSButton.Location = New System.Drawing.Point(71, 122)
        Me.PLUSButton.Name = "PLUSButton"
        Me.PLUSButton.Size = New System.Drawing.Size(28, 23)
        Me.PLUSButton.TabIndex = 7
        Me.PLUSButton.Text = "+"
        Me.PLUSButton.UseVisualStyleBackColor = True
        '
        'MinusButton
        '
        Me.MinusButton.Font = New System.Drawing.Font("新細明體", 10.0!)
        Me.MinusButton.Location = New System.Drawing.Point(286, 122)
        Me.MinusButton.Name = "MinusButton"
        Me.MinusButton.Size = New System.Drawing.Size(26, 23)
        Me.MinusButton.TabIndex = 8
        Me.MinusButton.Text = "-"
        Me.MinusButton.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ShowLabel)
        Me.GroupBox4.Location = New System.Drawing.Point(91, 21)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 85)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        '
        'ShowLabel
        '
        Me.ShowLabel.AutoSize = True
        Me.ShowLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShowLabel.Location = New System.Drawing.Point(3, 18)
        Me.ShowLabel.Name = "ShowLabel"
        Me.ShowLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowLabel.Size = New System.Drawing.Size(37, 12)
        Me.ShowLabel.TabIndex = 0
        Me.ShowLabel.Text = "Label2"
        Me.ShowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 378)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.MinusButton)
        Me.Controls.Add(Me.PLUSButton)
        Me.Controls.Add(Me.FontTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents font2RadioButton As RadioButton
    Friend WithEvents font1RadioButton As RadioButton
    Friend WithEvents Size12RadioButton As RadioButton
    Friend WithEvents Size11RadioButton As RadioButton
    Friend WithEvents Size10RadioButton As RadioButton
    Friend WithEvents Size9RadioButton As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents StrikeThroughCheckBox As CheckBox
    Friend WithEvents UnderlineCheckBox As CheckBox
    Friend WithEvents ItalicCheckBox As CheckBox
    Friend WithEvents boldCheckBox As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FontTextBox As TextBox
    Friend WithEvents PLUSButton As Button
    Friend WithEvents MinusButton As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ShowLabel As Label
End Class
