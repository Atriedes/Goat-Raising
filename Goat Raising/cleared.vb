Public Class cleared
    Dim lv As Integer = tampilan.Info1.getLevel
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Dispose()
        Form.ActiveForm.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()

        If Button1.Text = "Next Level" Then
            tampilan.nexLevel(lv + 1)
            tampilan.Timer2.Enabled = True
            tampilan.Timer1.Enabled = True
            tampilan.Button1.Visible = True
            tampilan.Button2.Visible = True
            tampilan.Button3.Visible = True
            For Each sd As Object In tampilan.Controls
                If TypeOf sd Is kambing Then
                    sd.visible = True
                End If
            Next
        ElseIf Button1.Text = "Main Menu" Then

            Start.Visible = True
            tampilan.Close()
        End If

    End Sub

    Private Sub cleared_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If lv <= 3 Then
            Button1.Text = "Next Level"
        Else
            Button1.Text = "Main Menu"
        End If
    End Sub
End Class
