

Module Ajuda

    Public Sub Ajuda_Tooltip(ByVal T As ToolTip, B As Control, ByVal Mensagem As String)
        T.RemoveAll()
        T.SetToolTip(B, Mensagem)
        T.AutoPopDelay = 20000
        T.InitialDelay = 200
        T.IsBalloon = False
        T.Active = True
        T.BackColor = Color.Azure
    End Sub

End Module
