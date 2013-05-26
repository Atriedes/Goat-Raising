Public Class info
    Dim level As Integer = 1

    Function setTimer() As Integer
        Label4.Text = Label4.Text + 1
        If Me.level = 1 Then
            If Label4.Text = 50 Then
                Return 1
            End If
        ElseIf Me.level = 2 Then
            If Label4.Text = 100 Then
                Return 1
            End If
        ElseIf Me.level = 3 Then
            If Label4.Text = 150 Then
                Return 1
            End If
        End If

        Return 0
    End Function

    Sub setLevel(ByVal lvl As Integer)
        level = lvl
    End Sub

    Function getLevel() As Integer
        Return level
    End Function

    Sub editMoney(ByVal value As Integer)
        Label2.Text += value
    End Sub

    Function getMoney() As Integer
        Return Label2.Text
    End Function

    Sub reset()
        Label2.Text = 100
        Label4.Text = 0
    End Sub

End Class
