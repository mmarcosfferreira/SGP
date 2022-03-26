
Imports Tulpep.NotificationWindow
Imports Guna.UI2
Public Class Notifyicone_PopupNotifier
    Public Sub New()
        SetBalloonTip()

    End Sub



    Public Sub Notifyicone_PopupNotifier(ByVal Exibirtexto_no_Balao As String, ByVal Titulo As String,
                          ByVal tempo_deexibicao As Integer, ByVal Optional Ct As Object = Nothing)  'ByVal Textoassociado_ao_Controle As String


      Dim notificacao = New PopupNotifier With {
            .ImageSize = New Size(70, 70),
            .BodyColor = Color.White,
            .AnimationInterval = 1,
            .ContentText = Exibirtexto_no_Balao,
            .TitleText = Titulo,
            .AnimationDuration = tempo_deexibicao,
            .IsRightToLeft = False,
            .ShowCloseButton = True,
            .ContentColor = Color.Black, 'cor da escrita
            .Image = Image.FromFile(Application.StartupPath + "\Icones\ico\VS.ico", True)'Image.FromFile("C:\Develop SGP\Icones\ico\VS.ico", True) ' .Image = Image.FromFile("C:\Users\marcosferreira\Desktop\MTR\Principal\Resources\vs.ico", True)    
                    }
      notificacao.Popup()


    End Sub



    Private Sub SetBalloonTip()  'seta o tipo do balão
        Dim notifyIcon1 As New NotifyIcon With {
            .Icon = SystemIcons.Information,
            .BalloonTipTitle = "Balloon Tip Title",
            .BalloonTipText = "Balloon Tip Text.",
            .BalloonTipIcon = ToolTipIcon.Info
        }

    End Sub



    Public Sub Notificar_Net(ByVal Exibirtexto_no_Balao As String, ByVal Titulo As String,
                        ByVal tempo_deexibicao As Integer, ByVal Optional Ct As Object = Nothing)  'ByVal Textoassociado_ao_Controle As String

        'Dim notifyIcon2 As New FRM_edição
        'With notifyIcon2.NotifyIcon1
        '    .Visible = True
        FRM_edição.NotifyIcon1.Visible = True
        FRM_edição.NotifyIcon1.ShowBalloonTip(tempo_deexibicao, Titulo, Exibirtexto_no_Balao, ToolTipIcon.Warning)

        'End With


    End Sub


End Class
