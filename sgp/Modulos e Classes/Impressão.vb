Module Impressão

    Dim Prev As New PrintPreviewDialog()
    Dim PrintDoc As New Printing.PrintDocument()
    Public Sub Visualizar(ByVal sender As Object)

        sender = sender

        Prev.Document = PrintDoc

        If Prev.ShowDialog() = DialogResult.OK Then
            PrintDoc.Print()
        End If

    End Sub

    Public Sub Imprimir(ByVal Evento_ As Printing.PrintPageEventArgs)


        PrintDoc.Print()

    End Sub



End Module
