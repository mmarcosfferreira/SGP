Module Pesquisar_em_Listview_o_Item

    Public Function Pesquisar_em_Listview_o_Item(Lv As ListView, PalavraPrincipal As String, ByVal Optional Palavra_SubitemOpcional As String = Nothing)

        For i As Integer = 0 To Lv.Items.Count - 1

            Dim lvi As ListViewItem = Lv.FindItemWithText(PalavraPrincipal, False, 0, True)

            If Trim(Lv.Items(i).Text.ToUpper) = Trim(PalavraPrincipal.ToUpper) Then
                'MsgBox("Item(s) encontrado! ", MsgBoxStyle.Exclamation)
                Return (i)  'Se encontrar retorne o n da linha
            End If
            For i2 As Integer = 0 To Lv.Items(i).SubItems.Count - 1
                If Trim(Lv.Items(i).SubItems(i2).Text.ToUpper) = Trim(Palavra_SubitemOpcional.ToUpper) Then
                    Return (i)
                End If
            Next
        Next

        Return False
        MsgBox("Nada encontrado! ", MsgBoxStyle.Exclamation)
    End Function

End Module
