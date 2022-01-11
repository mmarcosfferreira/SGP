Module UsuarioLogado

    Public Function UsuarioLogado()

        Dim i As Object = CreateObject("Wscript.network")
        Dim j As Object = i.username()
        UsuarioLogado = j
        Return UsuarioLogado

    End Function

End Module
