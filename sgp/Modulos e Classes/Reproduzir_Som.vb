Module Reproduzir_Som
    ''' <summary>
    ''' AudioPlayMode.Background: Reproduz o som em segundo plano. O código de chamada continua a ser executado.
    ''' AudioPlayMode.BackgroundLoop: Reproduz o som em segundo plano até que o método Stop seja chamado. O código de chamada continua a ser executado.
    ''' AudioPlayMode.WaitToComplete: Reproduz o som e aguarda até que seja concluído antes que o código de chamada continue.
    ''' </summary>
    ''' <param name="NomedoArquivo_e_Extencão"></param>
    Public Sub Play(ByVal NomedoArquivo_e_Extencão As String)
        My.Computer.Audio.Play(Application.StartupPath & "\Snd\" & NomedoArquivo_e_Extencão, AudioPlayMode.Background)
    End Sub

End Module
