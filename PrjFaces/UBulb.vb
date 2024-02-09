Public Class UBulb

    ' Method to turn LED on or off


    Private Sub SetLed(ByVal intLed As Integer)
        If Not IsNothing(pbLed.Image) Then
            pbLed.Image.Dispose()
            pbLed.Image = Nothing
        End If

        pbLed.Image = imgList.Images(intLed)
    End Sub


    Public Sub SwitchLed(strLed As String)
        Select Case strLed
            Case "on"
                SetLed(1)
            Case "off"
                SetLed(0)
            Case Else
                SetLed(0)
        End Select
    End Sub




End Class
