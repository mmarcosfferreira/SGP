Imports System.IO
Module FileCompare

    ''' <summary>
    ''' Este método aceita duas strings que representam dois arquivos para comparar.
    ''' <sumary>Um valor de retorno de 0 indica que o conteúdo dos arquivos </sumary>
    ''' <sumary>são os mesmos. Um valor de retorno de qualquer outro valor indica que os arquivos não são iguais.</sumary>
    ''' </summary>
    ''' <param name="file1"></param>
    ''' <param name="file2"></param>
    ''' <returns></returns>
    Public Function FileCompare(ByVal file1 As String, ByVal file2 As String) As Boolean
        Dim file1byte As Integer
        Dim file2byte As Integer
        Dim fs1 As FileStream
        Dim fs2 As FileStream


        ' Determina se o mesmo arquivo foi referenciado duas vezes
        If file1 = file2 Then
            'Retorne verdadeiro para indicar que os arquivos são os mesmos
            Return True
        End If

        'Abra os dois arquivos.
        fs1 = New FileStream(file1, FileMode.Open)
        fs2 = New FileStream(file2, FileMode.Open)



        ' Verifique os tamanhos dos arquivos. Se eles não forem iguais, os arquivos não são os mesmos.
        If fs1.Length <> fs2.Length Then
            fs1.Close()
            fs2.Close()
            Return False
        End If


        'Leia e compare um byte de cada arquivo até um conjunto de bytes não correspondente q for encontrado 
        'ou até o final do file1 é alcançado.
        Do
            'Leia um byte de cada arquivo.
            file1byte = fs1.ReadByte()
            file2byte = fs2.ReadByte()

            '[-1 SE O FINAL DO FLUXO FOI atingido isto em leitura do integer porque o integer é convertido em byte]
        Loop While (file1byte = file2byte) AndAlso (file1byte <> -1)

        fs1.Close()
        fs2.Close()

        'Retorna o sucesso da comparação. 
        '"file1byte" é  igual a "file2byte" neste ponto apenas se os arquivos forem o mesmo
        Return ((file1byte - file2byte) = 0) 'se na subtração de bits destes arquivos sendo 0 tera q ser retornado


        '_______________________cHAMADA DO BOTÃO PARA VERIFICAR_____________________________________
        'Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'If FileCompare(Me.textBox1.Text, Me.textBox2.Text) Then
        '    MessageBox.Show("Files are equal.")
        'Else
        '    MessageBox.Show("Files are not equal.")
        'End If
        'End Sub

    End Function



End Module
