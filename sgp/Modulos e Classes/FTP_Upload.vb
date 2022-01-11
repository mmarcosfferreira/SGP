
Imports System.Net.FtpWebRequest
Imports System.Net
Imports System.IO
Imports System.Security
Public Class FTP_Upload

    Public Sub FTP_Upload(ByVal Caminho As String)
        Dim request As FtpWebRequest
        Try



            request = DirectCast(WebRequest.Create("ftp://ftpupload.net/htdocs/BancoMTR.txt"), System.Net.FtpWebRequest)
            request.Credentials = New NetworkCredential("epiz_25111379", "FERREIRAMARCOS")

            'request = DirectCast(WebRequest.Create("ftp://ftps1.us.100webspace.com/BancoMTR.txt"), System.Net.FtpWebRequest)
            ' request.Credentials = New NetworkCredential("marfer817", "ferreiram")
            request.Method = WebRequestMethods.Ftp.UploadFile
            request.ReadWriteTimeout = 50000
            request.UsePassive = True  'modo passivo
            request.UseBinary = True  'modo binario
            request.KeepAlive = False

            Dim file() As Byte = System.IO.File.ReadAllBytes(Caminho) 'array de bytes

            Dim stream As System.IO.Stream = request.GetRequestStream()


            stream.Write(file, 0, file.Length)
            stream.Close()
            ' stream.Dispose()

        Catch ex As Exception
            MsgBox("Detalhes da exceção: " & ex.Message.ToString)
        End Try



    End Sub

End Class
