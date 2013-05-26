Public Class Stok
    Dim stokRumput As Integer
    Dim stokAir As Integer
    Dim stokObat As Integer
    Public Sub New()
        stokRumput = 0
        stokAir = 0
        stokObat = 0
    End Sub

    Public Sub editStockRumput(ByVal val As Integer)
        Me.stokRumput += val
    End Sub

    Public Sub editStockAir(ByVal val As Integer)
        Me.stokAir += val
    End Sub

    Public Sub editStockObat(ByVal val As Integer)
        Me.stokObat += val
    End Sub

    Function getStokAir() As Integer
        Return Me.stokAir
    End Function

    Function getStokRumput() As Integer
        Return Me.stokRumput
    End Function

    Function getStokObat() As Integer
        Return Me.stokObat
    End Function
End Class
