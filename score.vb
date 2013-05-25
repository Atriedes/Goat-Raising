Public Class score
    Dim score As Integer
    Dim xhs() As String = Split(System.IO.File.ReadAllText("hs.txt"), vbCrLf)
    Dim xskor As Integer
    Public Sub New()
        score = tampilan.Info1.getMoney()
    End Sub
    Public Property skornow As Integer
        Get
            Return score
        End Get
        Set(ByVal value As Integer)
            score = value
        End Set
    End Property

    Public Function lihatScore() As Integer
        Return score
    End Function

    Public Sub simpanScore(ByVal sk As Integer)
        xskor = sk
        System.IO.File.WriteAllText("hs.txt", xskor & vbCrLf)
    End Sub

    Public Function lihatScoreTertinggi()
        xskor = xhs(0)
        Return xskor
    End Function

End Class
