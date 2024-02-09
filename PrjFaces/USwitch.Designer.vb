<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USwitch
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(USwitch))
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.pbSwitch = New System.Windows.Forms.PictureBox()
        Me.btnSwitch = New System.Windows.Forms.Button()
        CType(Me.pbSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList.Images.SetKeyName(0, "Switch OFF.png")
        Me.imgList.Images.SetKeyName(1, "Switch ON.png")
        '
        'pbSwitch
        '
        Me.pbSwitch.Location = New System.Drawing.Point(3, 3)
        Me.pbSwitch.Name = "pbSwitch"
        Me.pbSwitch.Size = New System.Drawing.Size(64, 32)
        Me.pbSwitch.TabIndex = 0
        Me.pbSwitch.TabStop = False
        '
        'btnSwitch
        '
        Me.btnSwitch.Location = New System.Drawing.Point(0, 0)
        Me.btnSwitch.Name = "btnSwitch"
        Me.btnSwitch.Size = New System.Drawing.Size(64, 32)
        Me.btnSwitch.TabIndex = 1
        Me.btnSwitch.UseVisualStyleBackColor = True
        '
        'USwitch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnSwitch)
        Me.Controls.Add(Me.pbSwitch)
        Me.Name = "USwitch"
        Me.Size = New System.Drawing.Size(74, 41)
        CType(Me.pbSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgList As ImageList
    Friend WithEvents pbSwitch As PictureBox
    Friend WithEvents btnSwitch As Button
End Class
