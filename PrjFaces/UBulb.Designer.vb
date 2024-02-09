<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UBulb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UBulb))
        Me.pbLed = New System.Windows.Forms.PictureBox()
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.pbLed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbLed
        '
        Me.pbLed.Location = New System.Drawing.Point(0, 0)
        Me.pbLed.Name = "pbLed"
        Me.pbLed.Size = New System.Drawing.Size(64, 64)
        Me.pbLed.TabIndex = 0
        Me.pbLed.TabStop = False
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList.Images.SetKeyName(0, "led-green-md.png")
        Me.imgList.Images.SetKeyName(1, "led-green-md ON.png")
        '
        'UBulb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbLed)
        Me.Name = "UBulb"
        Me.Size = New System.Drawing.Size(69, 68)
        CType(Me.pbLed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbLed As PictureBox
    Friend WithEvents imgList As ImageList
End Class
