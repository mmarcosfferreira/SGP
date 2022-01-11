Imports System.IO.StreamReader

Module CarregarDados
    Public info5 As New Notifyicone_PopupNotifier
    Public Async Sub CarregarDadosLocalmenteListview(ByVal DiretoriodoArquivo As String, LV As ListView, Optional bt As Object = Nothing)
        Dim SR As IO.StreamReader
        '   LV.Items.Clear()
        Try
            If My.Computer.FileSystem.FileExists(DiretoriodoArquivo) Then
                LV.Items.Clear()
                SR = My.Computer.FileSystem.OpenTextFileReader(DiretoriodoArquivo)
                Dim Array() As String

                Do While Not SR.EndOfStream
                    Dim lvi As New ListViewItem
                    Array = SR.ReadLine.Split(Chr(9))
                    lvi.Text = Array(0).ToString ' ID
                    lvi.SubItems.Add(Array(1).ToString) ' registro
                    lvi.SubItems.Add(Array(2).ToString) ' nome
                    lvi.SubItems.Add(Array(3).ToString) 'motivo 
                    lvi.SubItems.Add(Array(4).ToString) 'dtinicio
                    lvi.SubItems.Add(Array(5).ToString) 'dtfim
                    lvi.SubItems.Add(Array(6).ToString) 'dif em dias 
                    lvi.SubItems.Add(Array(7).ToString) 'status
                    lvi.SubItems.Add(Array(8).ToString) 'op entrada
                    lvi.SubItems.Add(Array(9).ToString) 'op de saida
                    LV.Items.Add(lvi)

                Loop
                Await Task.Delay(100)
                ' TextBoxMTRobservação.AutoCompleteCustomSource.Add(lvi.SubItems(3).Text)
                SR.Close()

            End If

        Catch ex As Exception

        End Try
    End Sub

    Public Contar As Integer = 0
    Public Async Sub CarregarDadosdaNuvem(ByVal DiretoriodoArquivo As String, LV As ListView, Optional bt As Object = Nothing)
        Dim SR As IO.StreamReader
        LV.Items.Clear()

        Internet.FTP_Dowload(Application.StartupPath & "\BD\Reg.txt",
                                      "ftp://files.000webhost.com/public_html/Reg.txt",
                                      "marcosferreiramf",
                                      "Senha0789")
        Await Task.Delay(4000)

        Try
            If My.Computer.FileSystem.FileExists(DiretoriodoArquivo) Then

                SR = My.Computer.FileSystem.OpenTextFileReader(DiretoriodoArquivo)



                Dim Array() As String

                Do While Not SR.EndOfStream
                    Dim lvi As New ListViewItem
                    Array = SR.ReadLine.Split(Chr(9))
                    lvi.Text = Array(0).ToString ' ID
                    lvi.SubItems.Add(Array(1).ToString) ' registro
                    lvi.SubItems.Add(Array(2).ToString) ' nome
                    lvi.SubItems.Add(Array(3).ToString) 'motivo 
                    lvi.SubItems.Add(Array(4).ToString) 'dtinicio
                    lvi.SubItems.Add(Array(5).ToString) 'dtfim
                    lvi.SubItems.Add(Array(6).ToString) 'dif em dias 
                    lvi.SubItems.Add(Array(7).ToString) 'status
                    lvi.SubItems.Add(Array(8).ToString) 'op entrada
                    lvi.SubItems.Add(Array(9).ToString) 'op de saida
                    LV.Items.Add(lvi)

                    Contar += 1
                Loop
                Await Task.Delay(100)
                ' TextBoxMTRobservação.AutoCompleteCustomSource.Add(lvi.SubItems(3).Text)
                SR.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            '  Exit Sub
        Finally

        End Try
    End Sub




End Module
