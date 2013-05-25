Public Class Start

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tampilan.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Dim i As New high_score
        i.Top = 10
        i.Left = 100
        Me.Controls.Add(i)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Dispose()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Dim i As New credits
        i.Top = 10
        i.Left = 100
        Me.Controls.Add(i)
    End Sub
End Class