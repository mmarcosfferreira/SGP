Imports System.ComponentModel
Imports System.Threading
Imports System.Net
Module ModuleFTP
    '------------------------------------------------------------CREDENCIAIS PARA ATT SERVIDOR FTP---------------------------------------------------------/
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Public usuarioftp As String = "epiz_24992095" '.........................NOME DE USUARIO PARA ACESSAR SERVIDOR FTP
    Public senhaftp As String = "Senha0789" '...........................SENHA DO USUARIO PARA ACESSAR O FTP
    Public ftp_root As String = "ftp://ftpupload.net/htdocs/" '..............DIRETORIO RAIZ AONDE ESTÁ LOCALIZADO O ARQUIVO.ZIP(PADRAO.ZIP/BACKUP.ZIP)
    Public download_dir As String = Application.StartupPath '......................DIRETORIO RAIZ DE SEU PROGRAMA, AONDE ESTÁ OS ARQUIVOS QUE DEVEM SOFRER ATT
    '------------------------------------------------------------------------------------------------------------------------------------------------------/
    Dim WithEvents WClient As New System.Net.WebClient
    Public MaxValue As String
    Public TH1 As Thread
    Public start_download As Boolean

    'Public Sub GetSizeFile()
    '    Dim wTotalSize As String
    '    Dim clsRequest As System.Net.FtpWebRequest = System.Net.WebRequest.Create(ftp_root & "/BancoMTR.txt") '< informe local do arquivo.zip
    '    clsRequest.Credentials = New System.Net.NetworkCredential(usuarioftp, senhaftp)
    '    clsRequest.Method = System.Net.WebRequestMethods.Ftp.GetFileSize
    '    Dim listResponse As System.Net.FtpWebResponse = clsRequest.GetResponse
    '    wTotalSize = listResponse.ContentLength
    '    MaxValue = wTotalSize.ToString
    '    '-----------------------------------------------/
    '    start_download = True
    '    TH1 = New Thread(AddressOf DownloadFile)
    '    TH1.IsBackground = True
    '    TH1.Start()
    'End Sub  'OBTEM TAMANHO DO ARQUIVO REMOTO




    'Barra normal servidor linus
    ' barra invertida servidor windows

    Private Sub DownloadFile()
        Dim ArquivoPadrao As New Uri(ftp_root & "\BancoMTR.txt") '< informe local do arquivo.zip
        WClient.Credentials = New System.Net.NetworkCredential(usuarioftp, senhaftp)
        WClient.DownloadFileAsync(ArquivoPadrao, download_dir & "\C:\MTR\MTR\BD\BancoMTR.txt") '< informe local para download.zip
    End Sub 'FAZ DOWNLOAD DO ARQUIVO REMOTO
    Private Sub WClient_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles WClient.DownloadFileCompleted
        MsgBox("Download concluido!", MsgBoxStyle.Information, "Donwload")
        start_download = False
    End Sub 'DOWNLOAD 100%

End Module