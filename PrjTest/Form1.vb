Public Class Form1



    Private Sub btnConfused_Click(sender As Object, e As EventArgs) _
        Handles btnConfused.Click

        UCtrlEmotion1.setMood("confused")
    End Sub

    Private Sub btnCool_Click(sender As Object, e As EventArgs) _
        Handles btnCool.Click

        UCtrlEmotion1.setMood("cool")
    End Sub

    Private Sub btnSmile_Click(sender As Object, e As EventArgs) _
        Handles btnSmile.Click

        UCtrlEmotion1.setMood("smile")
    End Sub

    Private Sub btnStar_Click(sender As Object, e As EventArgs) _
        Handles btnStar.Click

        UCtrlEmotion1.setMood("star")
    End Sub

    Private Sub btnTeeth_Click(sender As Object, e As EventArgs) _
        Handles btnTeeth.Click

        UCtrlEmotion1.setMood("teeth")
    End Sub

    Private Sub btnYell_Click(sender As Object, e As EventArgs) _
        Handles btnYell.Click

        UCtrlEmotion1.setMood("yell")
    End Sub

    Private Sub btnPuhasta_Click(sender As Object, e As EventArgs) _
        Handles btnPuhasta.Click

        UCtrlEmotion1.emptyMood()

    End Sub

    Private Sub USwitch1_Load(sender As Object, e As EventArgs) _
        Handles USwitch1.Load

        USwitch1.TurnSwitch("off")
    End Sub

    Private Sub UBulb1_Load(sender As Object, e As EventArgs) _
        Handles UBulb1.Load

        UBulb1.SwitchLed("off")
    End Sub

    Private Sub USwitch1_FlagStateChanged() Handles USwitch1.FlagStateChanged

        If USwitch1.Flag = False Then
            UBulb1.SwitchLed("off")
        Else
            UBulb1.SwitchLed("on")
        End If
    End Sub
End Class
