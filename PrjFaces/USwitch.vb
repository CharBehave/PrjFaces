Public Class USwitch

    Public Flag As Boolean = False

    Public Event FlagStateChanged()


    Public Sub SetSwitch(intSwitch As Integer)
        If Not IsNothing(btnSwitch.Image) Then
            btnSwitch.Image.Dispose()
            btnSwitch.Image = Nothing
        End If
        btnSwitch.Image = imgList.Images(intSwitch)
    End Sub

    Public Sub TurnSwitch(strSwitch As String)

        Select Case strSwitch
            Case "on"
                SetSwitch(1)
            Case "off"
                SetSwitch(0)
            Case Else
                SetSwitch(0)
        End Select
    End Sub

    Private Sub btnSwitch_Click(sender As Object, e As EventArgs) _
        Handles btnSwitch.Click


        If Flag = False Then
            Flag = True

            TurnSwitch("on")
            RaiseEvent FlagStateChanged()
        Else
            Flag = False

            TurnSwitch("off")
            RaiseEvent FlagStateChanged()
        End If

    End Sub
End Class
