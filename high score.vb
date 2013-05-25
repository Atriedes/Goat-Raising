Public Class high_score

    Private Sub high_score_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim skor As New score
        j1.Text = skor.lihatScoreTertinggi()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
        For Each i As Object In Form.ActiveForm.Controls
            If TypeOf i Is Button Then
                i.visible = True
            End If
        Next
    End Sub
End Class
