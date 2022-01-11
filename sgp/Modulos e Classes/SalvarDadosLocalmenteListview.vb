Imports System.IO

Module SalvarDados

    ''' <summary>
    ''' Salva no local diretorio e faz o upload p o server
    ''' </summary>
    ''' <param name="Local"></param>
    ''' <param name="lV"></param>
    ''' <param name="bt"></param>
    Public Async Sub SalvarDadosLocalmenteListview_depoisnaNuvem(ByVal Local As String, lV As ListView, bt As Object)

        Try
            If My.Computer.FileSystem.FileExists(Local) Then
                My.Computer.FileSystem.DeleteFile(Local)



                Dim FS As New FileStream(Local, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite)
                Dim SW As New StreamWriter(FS)



                For i As Integer = 0 To lV.Items.Count - 1
                    For i2 As Integer = 0 To lV.Items(i).SubItems.Count - 1
                        SW.Write(lV.Items(i).SubItems(i2).Text & Chr(9))
                    Next
                    SW.Write(Environment.NewLine) 'cria nova linha

                Next

                SW.Close()
                FS.Close()

                Await Task.Delay(820)


                Internet.FTP_Upload(Application.StartupPath & "\BD\Reg.txt",
                                      "ftp://files.000webhost.com/public_html/Reg.txt",
                                      "marcosferreiramf",
                                      "Senha0789")
                Await Task.Delay(3000) '3000
                Play("Powerup.wav")


                Await Task.Delay(100)
            End If





        Catch ex As Exception
        Finally
        End Try


    End Sub

    '---------------------
    Public Async Sub SalvardadosLocal_apenas(ByVal Local As String, lV As ListView, bt As Object)
        Try
            If My.Computer.FileSystem.FileExists(Local) Then
                My.Computer.FileSystem.DeleteFile(Local)

                '  verifica se o caminho e nome do arquivo estão ok
                If String.IsNullOrEmpty(Local) Or Not Local.Contains(".txt") Then
                    MsgBox("Informe o caminho do arquivo texto origem.", MsgBoxStyle.Information)
                    Return
                End If


                Dim FS As New FileStream(Local, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite)
                Dim SW As New StreamWriter(FS)



                For i As Integer = 0 To lV.Items.Count - 1
                    For i2 As Integer = 0 To lV.Items(i).SubItems.Count - 1
                        SW.Write(lV.Items(i).SubItems(i2).Text & Chr(9))
                    Next
                    SW.Write(Environment.NewLine) 'cria nova linha
                Next

                Await Task.Delay(420)

                SW.Close()
                FS.Close()
                Await Task.Delay(420)

                Beep()


                'If info5 IsNot Nothing Then  'tirarrrrrrrrrrrrrrrrrrrrrrrr
                '    info5.Notifyicone_PopupNotifier(vbCrLf & vbCrLf & "                  Dados salvos localmente corretamente", Chr(13) & "                                     Atenção", 1100, bt)

                'End If

            End If
        Catch ex As Exception

            MsgBox("Detalhe: " + ex.TargetSite.ToString() & Chr(13) & "+++++++++++++++++++++++++++++++++++!", MsgBoxStyle.Critical, "Erro gerado")

        Finally
        End Try

    End Sub


End Module
