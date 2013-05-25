Public Class kambing
    Dim xRand2 As New Random
    Dim rnd2 As Integer
    Dim xImgIndx As Integer
    Public isClicked As Boolean = False

    Public Sub gerak()
        Randomize()
        If Me.Left = 155 Then
            Me.Left += 1
        ElseIf Me.Left = 438 Then
            Me.Left += -1
        ElseIf Me.Top = 141 Then
            Me.Top += 1
        ElseIf Me.Top = 237 Then
            Me.Top += -1
        Else
            rnd2 = xRand2.Next(0, 100)
            If rnd Mod 2 = 0 Then
                Me.Top += -1
            Else
                Me.Top += 1
            End If

            rnd2 = xRand2.Next(0, 100)
            If rnd Mod 2 = 0 Then
                Me.Left += -1
            Else
                Me.Left += 1
            End If
        End If


    End Sub

    Public Sub minta(ByVal produk As Boolean)
        isClicked = False
        If produk = True Then
            xImgIndx = 0
            Button5.Image = ImageList1.Images(xImgIndx)
        Else
            xImgIndx = xRand2.Next(1, 4)
            xImgIndx = xRand2.Next(1, 4)
            Button5.Image = ImageList1.Images(xImgIndx)
        End If
    End Sub

    Public Function subtractHealth() As Integer
        ProgressBar1.Value -= 10
        Return ProgressBar1.Value
    End Function

    Public Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If xImgIndx = 0 Then
            tampilan.Info1.editMoney(200)
            minta(False)
        ElseIf xImgIndx = 1 Then
            'rumput
            If tampilan.stock1.getStokRumput() = 0 Then
                MsgBox("You dont have any grass")
            Else
                tampilan.stock1.editStockRumput(-1)
                tampilan.Button2.Text -= 1
                minta(False)
            End If
        ElseIf xImgIndx = 2 Then
            'air
            If tampilan.stock1.getStokAir() = 0 Then
                MsgBox("You dont have any water")
            Else
                tampilan.stock1.editStockAir(-1)
                tampilan.Button3.Text -= 1
                minta(False)
            End If
        ElseIf xImgIndx = 3 Then
            'obat
            If tampilan.stock1.getStokObat() = 0 Then
                MsgBox("You dont have any medicine")
            Else
                tampilan.stock1.editStockObat(-1)
                tampilan.Button1.Text -= 1
                minta(False)
            End If
        End If
        isClicked = True
    End Sub

    Public Sub kambing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        minta(False)
    End Sub

End Class
