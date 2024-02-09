<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.UCtrlEmotion1 = New PrjFaces.UCtrlEmotion()
        Me.btnConfused = New System.Windows.Forms.Button()
        Me.btnCool = New System.Windows.Forms.Button()
        Me.btnSmile = New System.Windows.Forms.Button()
        Me.btnStar = New System.Windows.Forms.Button()
        Me.btnTeeth = New System.Windows.Forms.Button()
        Me.btnYell = New System.Windows.Forms.Button()
        Me.btnPuhasta = New System.Windows.Forms.Button()
        Me.USwitch1 = New PrjFaces.USwitch()
        Me.UBulb1 = New PrjFaces.UBulb()
        Me.SuspendLayout()
        '
        'UCtrlEmotion1
        '
        Me.UCtrlEmotion1.Location = New System.Drawing.Point(12, 12)
        Me.UCtrlEmotion1.Name = "UCtrlEmotion1"
        Me.UCtrlEmotion1.Size = New System.Drawing.Size(81, 63)
        Me.UCtrlEmotion1.TabIndex = 0
        '
        'btnConfused
        '
        Me.btnConfused.Location = New System.Drawing.Point(184, 12)
        Me.btnConfused.Name = "btnConfused"
        Me.btnConfused.Size = New System.Drawing.Size(75, 23)
        Me.btnConfused.TabIndex = 1
        Me.btnConfused.Text = "Confused"
        Me.btnConfused.UseVisualStyleBackColor = True
        '
        'btnCool
        '
        Me.btnCool.Location = New System.Drawing.Point(184, 41)
        Me.btnCool.Name = "btnCool"
        Me.btnCool.Size = New System.Drawing.Size(75, 23)
        Me.btnCool.TabIndex = 2
        Me.btnCool.Text = "Cool"
        Me.btnCool.UseVisualStyleBackColor = True
        '
        'btnSmile
        '
        Me.btnSmile.Location = New System.Drawing.Point(184, 70)
        Me.btnSmile.Name = "btnSmile"
        Me.btnSmile.Size = New System.Drawing.Size(75, 23)
        Me.btnSmile.TabIndex = 3
        Me.btnSmile.Text = "Smile"
        Me.btnSmile.UseVisualStyleBackColor = True
        '
        'btnStar
        '
        Me.btnStar.Location = New System.Drawing.Point(184, 99)
        Me.btnStar.Name = "btnStar"
        Me.btnStar.Size = New System.Drawing.Size(75, 23)
        Me.btnStar.TabIndex = 4
        Me.btnStar.Text = "Star"
        Me.btnStar.UseVisualStyleBackColor = True
        '
        'btnTeeth
        '
        Me.btnTeeth.Location = New System.Drawing.Point(184, 128)
        Me.btnTeeth.Name = "btnTeeth"
        Me.btnTeeth.Size = New System.Drawing.Size(75, 23)
        Me.btnTeeth.TabIndex = 5
        Me.btnTeeth.Text = "Teeth"
        Me.btnTeeth.UseVisualStyleBackColor = True
        '
        'btnYell
        '
        Me.btnYell.Location = New System.Drawing.Point(184, 157)
        Me.btnYell.Name = "btnYell"
        Me.btnYell.Size = New System.Drawing.Size(75, 23)
        Me.btnYell.TabIndex = 6
        Me.btnYell.Text = "Yell"
        Me.btnYell.UseVisualStyleBackColor = True
        '
        'btnPuhasta
        '
        Me.btnPuhasta.Location = New System.Drawing.Point(184, 209)
        Me.btnPuhasta.Name = "btnPuhasta"
        Me.btnPuhasta.Size = New System.Drawing.Size(75, 23)
        Me.btnPuhasta.TabIndex = 7
        Me.btnPuhasta.Text = "Clean"
        Me.btnPuhasta.UseVisualStyleBackColor = True
        '
        'USwitch1
        '
        Me.USwitch1.Location = New System.Drawing.Point(28, 195)
        Me.USwitch1.Name = "USwitch1"
        Me.USwitch1.Size = New System.Drawing.Size(65, 46)
        Me.USwitch1.TabIndex = 8
        '
        'UBulb1
        '
        Me.UBulb1.Location = New System.Drawing.Point(28, 70)
        Me.UBulb1.Name = "UBulb1"
        Me.UBulb1.Size = New System.Drawing.Size(69, 68)
        Me.UBulb1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 244)
        Me.Controls.Add(Me.UBulb1)
        Me.Controls.Add(Me.USwitch1)
        Me.Controls.Add(Me.btnPuhasta)
        Me.Controls.Add(Me.btnYell)
        Me.Controls.Add(Me.btnTeeth)
        Me.Controls.Add(Me.btnStar)
        Me.Controls.Add(Me.btnSmile)
        Me.Controls.Add(Me.btnCool)
        Me.Controls.Add(Me.btnConfused)
        Me.Controls.Add(Me.UCtrlEmotion1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UCtrlEmotion1 As PrjFaces.UCtrlEmotion
    Friend WithEvents btnConfused As Button
    Friend WithEvents btnCool As Button
    Friend WithEvents btnSmile As Button
    Friend WithEvents btnStar As Button
    Friend WithEvents btnTeeth As Button
    Friend WithEvents btnYell As Button
    Friend WithEvents btnPuhasta As Button
    Friend WithEvents USwitch1 As PrjFaces.USwitch
    Friend WithEvents UBulb1 As PrjFaces.UBulb
End Class
