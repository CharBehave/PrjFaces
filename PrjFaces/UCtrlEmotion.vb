﻿Public Class UCtrlEmotion
    'Klassisisene meetod kuvatava pildi määramiseks

    Private Sub selectMood(ByVal intMood As Integer)
        pbEmotion.Image = imgLoend.Images(intMood)
    End Sub


    'avalik liidesmeetod

    Public Sub setMood(ByVal strMood As String)
        Select Case strMood
            Case "confused"
                Me.selectMood(0)
            Case "cool"
                Me.selectMood(1)
            Case "smile"
                Me.selectMood(2)
            Case "star"
                Me.selectMood(3)
            Case "teeth"
                Me.selectMood(4)
            Case "yell"
                Me.selectMood(5)
            Case Else
                Me.selectMood(0)
        End Select
    End Sub


    Public Sub emptyMood()


        If Not IsNothing(pbEmotion.Image) Then
            pbEmotion.Image.Dispose()
            pbEmotion.Image = Nothing
        End If



    End Sub


End Class
