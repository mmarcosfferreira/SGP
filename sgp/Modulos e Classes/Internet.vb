Imports System.Net.FtpWebRequest
Imports System.Text
Imports System.Net.Mail
Imports System.Net
Imports System.IO
Imports Tulpep



Public Class Internet

    Sub New()

    End Sub
    Public Function Endereço_de_Ip_local()

        Dim myHost As String = System.Net.Dns.GetHostName
        Dim myIPs As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(myHost)

        Dim ip As String = ""

        For Each myIP As System.Net.IPAddress In myIPs.AddressList

            ip = myIP.ToString
        Next
        Return ip
    End Function


    Private myHost
    Public Function Endereço_de_Host()

        myHost = System.Net.Dns.GetHostName
        Dim myIPs As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(myHost)
        Return myHost

    End Function


    Private Shared CT As Control


    Public Shared Async Sub FTP_Upload(ByVal DirArquivo As String, ByVal SiteFTP As String, ByVal Usuario As String, ByVal Senha As String)

        DirArquivo = DirArquivo
        SiteFTP = SiteFTP
        Usuario = Usuario
        Senha = Senha
        Dim X As New FrmGeral
        Try
            ' faz uma requisição web
            Dim request_ As System.Net.FtpWebRequest =
            DirectCast(System.Net.WebRequest.Create(SiteFTP),
            System.Net.FtpWebRequest)

            'DirectCast(System.Net.WebRequest.Create(SiteFTP & "/" &
            'System.IO.Path.GetFileName(Arquivo)),
            'System.Net.FtpWebRequest)
            request_.AuthenticationLevel = Security.AuthenticationLevel.MutualAuthRequested
            request_.Proxy = Nothing
            request_.Credentials = New System.Net.NetworkCredential(Usuario, Senha)
            request_.Method = WebRequestMethods.Ftp.UploadFile
            request_.ReadWriteTimeout = 50000
            request_.UsePassive = True
            request_.UseBinary = True  'xxx
            'request_.ContentOffset = 0 '<-----------------

            Await Task.Delay(1000)
            'Ler arquivo local  
            Dim file_() As Byte = IO.File.ReadAllBytes(DirArquivo)
            Await Task.Delay(100)
            'Escreve no destino
            Dim stream_ As System.IO.Stream = request_.GetRequestStream()

            stream_.Write(file_, 0, file_.Length)

            Await Task.Delay(100)

            stream_.Close()
            Dim Response = DirectCast(request_.GetResponse(), System.Net.FtpWebResponse)


            'Cria uma instancia do formulario mtr para acesar suas propriedades e métodos

            'define as características para mensagem no balão
            Dim M As String = "Banco de dados Salvo com sucesso! Upload Concluído! " & Chr(13) & "Informações do servidor: " & Response.StatusDescription
            Dim Titulo As String = Chr(9) & "     Transferencia concluída"
            Dim Texto_associado_ao_Controle As String = Nothing
            Dim informação As New Notifyicone_PopupNotifier
            ' CT = X.BtMTRsalvar
            informação.Notifyicone_PopupNotifier(M & "  Resposta do servidor: " & Response.StatusDescription, Titulo, 1000, CT)


            'exibe o balão
            Await Task.Delay(500)

            'MsgBox(M, MsgBoxStyle.Information, Titulo)
            Await Task.Delay(6000)  '

        Catch ex As Exception
            Using pa As FrmGeral = New FrmGeral
                'MsgBox("Ocorreu um, erro ao tentar subir os dados para o Servidor FTP! Detalhes:   " & ex.Message)
                '  pa.Notifyicone("Ocorreu uma excepção...ao fazer a transferencia em Upload" & "Detalhes: " & ex.Message.ToString, "Ocorreu um Erro", 10, CT)
            End Using

        Finally
        End Try

    End Sub






    Public Shared Async Sub FTP_Upload_SemMensagem(ByVal DirArquivo As String, ByVal SiteFTP As String, ByVal Usuario As String, ByVal Senha As String)

        DirArquivo = DirArquivo
        SiteFTP = SiteFTP
        Usuario = Usuario
        Senha = Senha
        Dim X As New FrmGeral
        Try
            ' faz uma requisição web
            Dim request_ As System.Net.FtpWebRequest =
            DirectCast(System.Net.WebRequest.Create(SiteFTP),
            System.Net.FtpWebRequest)

            'DirectCast(System.Net.WebRequest.Create(SiteFTP & "/" &
            'System.IO.Path.GetFileName(Arquivo)),
            'System.Net.FtpWebRequest)
            request_.AuthenticationLevel = Security.AuthenticationLevel.MutualAuthRequested
            request_.Proxy = Nothing
            request_.Credentials = New System.Net.NetworkCredential(Usuario, Senha)
            request_.Method = WebRequestMethods.Ftp.UploadFile
            request_.ReadWriteTimeout = 60000
            request_.UsePassive = True
            request_.UseBinary = True  'xxx
            'request_.ContentOffset = 0 '<-----------------

            Await Task.Delay(1000)
            'Ler arquivo local  
            Dim file_() As Byte = IO.File.ReadAllBytes(DirArquivo)
            Await Task.Delay(100)
            'Escreve no 


            Dim stream_ As System.IO.Stream = request_.GetRequestStream()
            stream_.Write(file_, 0, file_.Length)
            Await Task.Delay(100)

            stream_.Close()
            Dim Response = DirectCast(request_.GetResponse(), System.Net.FtpWebResponse)


            'Cria uma instancia do formulario mtr para acesar suas propriedades e métodos

            'define as características para mensagem no balão
            Dim M As String = "Banco de dados Salvo com sucesso! Upload Concluído sem mensagem! " & Chr(13) & "Informações do servidor: " & Response.StatusDescription
            Dim Titulo As String = Chr(9) & "     Transferencia concluída"
            Dim Texto_associado_ao_Controle As String = Nothing
            Dim informação As New Notifyicone_PopupNotifier
            ' CT = X.BtMTRsalvar
            informação.Notifyicone_PopupNotifier(M & "  Resposta do servidor: " & "------------" & Response.StatusDescription & " ", Titulo & "Tamnho bits: " & Response.ContentLength, 1300, CT) 'STATU DESCRIPTIO


            'MsgBox(M, MsgBoxStyle.Information, Titulo)
            Await Task.Delay(8000)

        Catch ex As Exception
            Using pa As FrmGeral = New FrmGeral
                MsgBox("Ocorreu um, erro ao tentar subir os dados para o Servidor FTP! Detalhes:   " & ex.Message)
                '  pa.Notifyicone("Ocorreu uma excepção...ao fazer a transferencia em Upload" & "Detalhes: " & ex.Message.ToString, "Ocorreu um Erro", 10, CT)
            End Using

        Finally
        End Try

    End Sub


    Public Shared Sub FTP_Dowload(ByVal Caminho As String, ByVal SiteFTP As String, ByVal Usuario As String, ByVal Senha As String)

        Dim info3 As New Notifyicone_PopupNotifier
        Dim X As New FrmGeral

        Try
            ' faz uma requisição web
            Dim request_ As System.Net.FtpWebRequest =
            DirectCast(System.Net.WebRequest.Create(SiteFTP),
            System.Net.FtpWebRequest)
            request_.AuthenticationLevel = Security.AuthenticationLevel.MutualAuthRequested
            request_.Proxy = Nothing
            request_.Credentials = New System.Net.NetworkCredential(Usuario, Senha)
            request_.Method = WebRequestMethods.Ftp.DownloadFile
            request_.UsePassive = True
            request_.ReadWriteTimeout = 50000



            'request_.Proxy = CByte("queirozgalvao.com.br:8080")
            Dim Response = DirectCast(request_.GetResponse(), System.Net.FtpWebResponse) ' transforma a var em um objeto de resposta do servidor
            Dim ResponseStream = Response.GetResponseStream() 'guarda na var responsestream o conteúdo... usando o método de pegar conteudo do fluxo (Get) 

            Using MemoryStream = New System.IO.MemoryStream()
                ResponseStream.CopyTo(MemoryStream)
                Dim ConteudodoArquivo = MemoryStream.ToArray()
                System.IO.File.WriteAllBytes(Caminho, ConteudodoArquivo)
            End Using

            'Cria uma instancia do formulario mtr para acesar suas propriedades e métodos
            'define as características para mensagem no balão
            Dim M As String = "Banco de dados carregado do servidor com Sucesso!! " & Chr(13) & "Dowload Concluído com exito" & Chr(13) &
            "Informações do servidor: " & Response.StatusDescription

            Dim Titulo As String = "Transferencia concluída"
            Dim Texto_associado_ao_Controle As String = Nothing
            '  CT = X.BtMTRsalvar

            'exibe o balão

            info3.Notifyicone_PopupNotifier(M, Titulo, 1200, CT)
            '  MsgBox(M, MsgBoxStyle.Information, Titulo)






        Catch ex As Exception
            Using ka As New FrmGeral
                info3.Notifyicone_PopupNotifier("Ocorreu uma excepção ao fazer dowload do servidor...!" & "Detalhes: " _
             & ex.Message, "Ocorreu um Erro", 10, CT)

                'MsgBox("Detalhes do Ocorrido:" & ex.Message.ToString )
            End Using

        End Try
        System.Threading.Thread.Sleep(20)
    End Sub


    Public Shared Sub Conexão_com_Rede(ByVal CTL As Object)
        Try
            If My.Computer.Network.Ping("www.google.com.br") = True Then
                '  LblStatusdaRede.Text = "ON"
                CTL.Text = "ON"
                DirectCast(CTL, Control).ForeColor = Color.Green

            Else

                If My.Computer.Network.Ping("www.google.com.br") = False Then
                    CTL.Text = "OF "
                    DirectCast(CTL, Control).ForeColor = Color.Red
                    Exit Sub
                End If

            End If

        Catch ex As Exception

        End Try
    End Sub



End Class
