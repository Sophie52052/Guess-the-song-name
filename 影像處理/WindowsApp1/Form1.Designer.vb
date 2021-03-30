<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim PS As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LTS = New System.Windows.Forms.PictureBox()
        Me.VIS = New System.Windows.Forms.Button()
        Me.HID = New System.Windows.Forms.Button()
        Me.BIG = New System.Windows.Forms.Button()
        Me.SMALL = New System.Windows.Forms.Button()
        Me.THEEND = New System.Windows.Forms.Button()
        Me.Top = New System.Windows.Forms.Button()
        Me.Left = New System.Windows.Forms.Button()
        Me.Right = New System.Windows.Forms.Button()
        Me.Botton = New System.Windows.Forms.Button()
        PS = New System.Windows.Forms.Label()
        CType(Me.LTS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PS
        '
        PS.AutoSize = True
        PS.BackColor = System.Drawing.Color.White
        PS.Location = New System.Drawing.Point(179, 70)
        PS.Name = "PS"
        PS.Size = New System.Drawing.Size(53, 12)
        PS.TabIndex = 6
        PS.Text = "圖片狀態"
        '
        'LTS
        '
        Me.LTS.Image = CType(resources.GetObject("LTS.Image"), System.Drawing.Image)
        Me.LTS.Location = New System.Drawing.Point(91, 103)
        Me.LTS.Name = "LTS"
        Me.LTS.Size = New System.Drawing.Size(255, 193)
        Me.LTS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LTS.TabIndex = 0
        Me.LTS.TabStop = False
        '
        'VIS
        '
        Me.VIS.Location = New System.Drawing.Point(543, 103)
        Me.VIS.Name = "VIS"
        Me.VIS.Size = New System.Drawing.Size(75, 23)
        Me.VIS.TabIndex = 1
        Me.VIS.Text = "顯示"
        Me.VIS.UseVisualStyleBackColor = True
        '
        'HID
        '
        Me.HID.Location = New System.Drawing.Point(543, 158)
        Me.HID.Name = "HID"
        Me.HID.Size = New System.Drawing.Size(75, 23)
        Me.HID.TabIndex = 2
        Me.HID.Text = "隱藏"
        Me.HID.UseVisualStyleBackColor = True
        '
        'BIG
        '
        Me.BIG.Location = New System.Drawing.Point(543, 205)
        Me.BIG.Name = "BIG"
        Me.BIG.Size = New System.Drawing.Size(75, 23)
        Me.BIG.TabIndex = 3
        Me.BIG.Text = "放大"
        Me.BIG.UseVisualStyleBackColor = True
        '
        'SMALL
        '
        Me.SMALL.Location = New System.Drawing.Point(543, 267)
        Me.SMALL.Name = "SMALL"
        Me.SMALL.Size = New System.Drawing.Size(75, 23)
        Me.SMALL.TabIndex = 4
        Me.SMALL.Text = "縮小"
        Me.SMALL.UseVisualStyleBackColor = True
        '
        'THEEND
        '
        Me.THEEND.Location = New System.Drawing.Point(181, 379)
        Me.THEEND.Name = "THEEND"
        Me.THEEND.Size = New System.Drawing.Size(75, 23)
        Me.THEEND.TabIndex = 5
        Me.THEEND.Text = "結束"
        Me.THEEND.UseVisualStyleBackColor = True
        '
        'Top
        '
        Me.Top.Location = New System.Drawing.Point(563, 350)
        Me.Top.Name = "Top"
        Me.Top.Size = New System.Drawing.Size(75, 23)
        Me.Top.TabIndex = 7
        Me.Top.Text = "上"
        Me.Top.UseVisualStyleBackColor = True
        '
        'Left
        '
        Me.Left.Location = New System.Drawing.Point(519, 379)
        Me.Left.Name = "Left"
        Me.Left.Size = New System.Drawing.Size(75, 23)
        Me.Left.TabIndex = 8
        Me.Left.Text = "左"
        Me.Left.UseVisualStyleBackColor = True
        '
        'Right
        '
        Me.Right.Location = New System.Drawing.Point(600, 379)
        Me.Right.Name = "Right"
        Me.Right.Size = New System.Drawing.Size(75, 23)
        Me.Right.TabIndex = 9
        Me.Right.Text = "右"
        Me.Right.UseVisualStyleBackColor = True
        '
        'Botton
        '
        Me.Botton.Location = New System.Drawing.Point(563, 408)
        Me.Botton.Name = "Botton"
        Me.Botton.Size = New System.Drawing.Size(75, 23)
        Me.Botton.TabIndex = 10
        Me.Botton.Text = "下"
        Me.Botton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Botton)
        Me.Controls.Add(Me.Right)
        Me.Controls.Add(Me.Left)
        Me.Controls.Add(Me.Top)
        Me.Controls.Add(PS)
        Me.Controls.Add(Me.THEEND)
        Me.Controls.Add(Me.SMALL)
        Me.Controls.Add(Me.BIG)
        Me.Controls.Add(Me.HID)
        Me.Controls.Add(Me.VIS)
        Me.Controls.Add(Me.LTS)
        Me.Name = "Form1"
        Me.Text = "就是愛玩圖-沛兒"
        CType(Me.LTS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LTS As PictureBox
    Friend WithEvents VIS As Button
    Friend WithEvents HID As Button
    Friend WithEvents BIG As Button
    Friend WithEvents SMALL As Button
    Friend WithEvents THEEND As Button
    Friend WithEvents PS As Label
    Friend WithEvents Top As Button
    Friend WithEvents Left As Button
    Friend WithEvents Right As Button
    Friend WithEvents Botton As Button
End Class
