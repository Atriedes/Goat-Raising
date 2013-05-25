Public Class credits

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
        For Each i As Object In Form.ActiveForm.Controls
            If TypeOf i Is Button Then
                i.visible = True
            End If
        Next
    End Sub
End Class
