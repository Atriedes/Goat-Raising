Public Class tampilan

    Public stock1 As New Stok
    Dim xCount As Integer = 0
    Dim xRand As New Random
    Dim rnd As Integer


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'For xCountElm As Integer = 0 To Me.Controls.OfType(Of kambing).Count() - 1
        'Me.Controls.OfType(Of kambing).ElementAt(xCountElm).gerak()
        ' Next

        If Info1.setTimer() = 1 Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            Dim skor As New score
            Dim cl As New cleared
                If skor.skornow > skor.lihatScoreTertinggi Then
                    cl.Label5.Text = skor.skornow
                    skor.simpanScore(skor.skornow)
                Else
                    cl.Label5.Visible = False
                    cl.Label6.Visible = False
                    cl.Label7.Visible = False
                End If
                cl.Top = 10
                cl.Left = 155
                cl.Lbskor.Text = skor.skornow
                Me.Controls.Add(cl)
                Button1.Visible = False
                Button2.Visible = False
                Button3.Visible = False
                For Each sd As Object In Me.Controls
                    If TypeOf sd Is kambing Then
                        sd.visible = False
                    End If
                Next
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Info1.getMoney() >= 20 Then
            stock1.editStockAir(1)
            Info1.editMoney(-20)
            Button3.Text += 1
        Else
            MsgBox("You dont have enough money")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Info1.getMoney() >= 50 Then
            stock1.editStockRumput(1)
            Info1.editMoney(-50)
            Button2.Text += 1
        Else
            MsgBox("You dont have enough money")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Info1.getMoney() >= 100 Then
            stock1.editStockObat(1)
            Info1.editMoney(-100)
            Button1.Text += 1
        Else
            MsgBox("You dont have enough money")
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If xCount = rnd Then
            For xCountElm As Integer = 0 To Me.Controls.OfType(Of kambing).Count() - 1
                Me.Controls.OfType(Of kambing).ElementAt(xCountElm).minta(True)
            Next
            rnd = xRand.Next(1, 5)
            xCount = 0
        Else
            For xCountElm As Integer = 0 To Me.Controls.OfType(Of kambing).Count() - 1
                If Me.Controls.OfType(Of kambing).ElementAt(xCountElm).isClicked = False Then
                    If Me.Controls.OfType(Of kambing).ElementAt(xCountElm).subtractHealth() = 0 Then
                        Timer1.Enabled = False
                        Timer2.Enabled = False
                        Dim skor As New score
                        Dim go As New gameover
                        go.Top = 10
                        go.Left = 155
                        go.lbskor.Text = skor.skornow
                        If skor.skornow >= skor.lihatScoreTertinggi Then
                            go.Label5.Text = skor.skornow
                            skor.simpanScore(skor.skornow)
                        Else
                            go.Label5.Visible = False
                            go.Label6.Visible = False
                            go.Label7.Visible = False
                        End If
                        Me.Controls.Add(go)
                        Button1.Visible = False
                        Button2.Visible = False
                        Button3.Visible = False
                        For Each sd As Object In Me.Controls
                            If TypeOf sd Is kambing Then
                                sd.visible = False
                            End If
                        Next
                    End If
                End If
                Me.Controls.OfType(Of kambing).ElementAt(xCountElm).minta(False)
            Next
        End If

        xCount += 1
    End Sub

    Sub nexLevel(ByVal level As Integer)
        Info1.reset()
        If level = 2 Then
            For xCountElm As Integer = 0 To Me.Controls.OfType(Of kambing).Count() - 1
                Me.Controls.OfType(Of kambing).ElementAt(xCountElm).Dispose()
            Next

            For xCount As Integer = 0 To 1
                Dim wedus As New kambing
                wedus.Left = xCount * 145 + 155
                wedus.Top = 230
                Me.Controls.Add(wedus)
            Next
            Info1.Label5.Text = "Level 2"
            Info1.setLevel(level)
        ElseIf level = 3 Then
            For xCountElm As Integer = 0 To Me.Controls.OfType(Of kambing).Count() - 1
                Me.Controls.OfType(Of kambing).ElementAt(0).Dispose()
            Next

            For xCount As Integer = 0 To 2
                Dim wedus As New kambing
                wedus.Left = xCount * 145 + 155
                wedus.Top = 230
                Me.Controls.Add(wedus)
            Next
            Info1.Label5.Text = "Level 3"
            Info1.setLevel(level)
        End If
    End Sub

    Private Sub tampilan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer2.Enabled = True
        rnd = xRand.Next(1, 5)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Start.Visible = True
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Dispose()
    End Sub
End Class