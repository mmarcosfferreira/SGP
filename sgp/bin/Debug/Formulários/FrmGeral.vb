Imports System.Security.Cryptography
Imports System.IO
Class FrmGeral
    Public info6 As Notifyicone_PopupNotifier
    Public QuantidadeRegistros As Long = 0
    'Friend WithEvents ProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    '  Public Notficar As New Notifyicone_PopupNotifier

    'Declare Function GetUserName Lib "advapi32.dll" Alias "GetUserNameA" (
    'ByVal lpBuffer As String, ByRef nSize As Integer) As Integer
    'Sub GetUser()
    '    Dim buffer As String = New String(CChar(" "), 25)
    '    Dim retVal As Integer = GetUserName(buffer, 25)
    '    Dim userName As String = Strings.Left(buffer, InStr(buffer, Chr(0)) - 1)
    '    MsgBox(userName)
    'End Sub

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        Me.ProgressBar1 = ProgressBar1
    End Sub



    Public Function ComparaArquivos(ByVal nomeCaminhoCompletoArquivo1 As String, ByVal nomeCaminhoCompletoArquivo2 As String) As Boolean


        Dim objMD5 As New MD5CryptoServiceProvider()
        Dim objEncoding As New System.Text.ASCIIEncoding()
        Dim aArquivo1() As Byte, aArquivo2() As Byte 'Array do tipo byte
        Dim strConteudo1, strConteudo2 As String
        Dim objReader As StreamReader
        Dim objFS As FileStream
        Dim bResposta As Boolean


        If Not File.Exists(nomeCaminhoCompletoArquivo1) Then Throw New Exception(nomeCaminhoCompletoArquivo1)
        If Not File.Exists(nomeCaminhoCompletoArquivo2) Then Throw New Exception(nomeCaminhoCompletoArquivo1)

        Try

            objFS = New FileStream(nomeCaminhoCompletoArquivo1, FileMode.Open)
            objReader = New StreamReader(objFS)
            aArquivo1 = objEncoding.GetBytes(objReader.ReadToEnd)
            strConteudo1 = objEncoding.GetString(objMD5.ComputeHash(aArquivo1))
            objReader.Close()
            objFS.Close()


            objFS = New FileStream(nomeCaminhoCompletoArquivo2, FileMode.Open)
            objReader = New StreamReader(objFS)

            aArquivo2 = objEncoding.GetBytes(objReader.ReadToEnd)
            strConteudo2 = objEncoding.GetString(objMD5.ComputeHash(aArquivo2))
            bResposta = strConteudo1 = strConteudo2
            objReader.Close()
            objFS.Close()


            aArquivo1 = Nothing
            aArquivo2 = Nothing

        Catch ex As Exception
            Throw ex
        End Try



        Return bResposta


    End Function

    '  <DllImport("user32.dll", EntryPoint:="ReleaseCapture")> Private Shared

    Private Sub BTNminimizar_Click(sender As Object, e As EventArgs) Handles BTNminimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub


    Friend Lvi As New ListViewItem
    Private Async Sub ADICIONAR()

        ' Dim LVI_Pesquisado As ListViewItem = LVCONTROLEDEPESAGEMMANUAL.FindItemWithText(TXTPLACA_SAIDA.Text)

        If My.Computer.Network.IsAvailable Then

            If ListView1.Items.Count = 0 Then

                'Se usuario colocar a data de entrada  e não colocar a de saida p deixa-lá em aberto até o fechamento isto no 1 item
                If LBLDATAINICIO.Text <> "" AndAlso LBLDATAFIM.Text = "" Then
                    Lvi = New ListViewItem(TXTID.Text, 0)
                    'Dim Lvi As New ListViewItem(TXTID.Text)

                    Lvi.SubItems.Add(TXTREGISTRO.Text)     '0.1 

                    Lvi.SubItems.Add(TXTNOME.Text)         '0.2

                    Lvi.SubItems.Add(CBOMOTIVO.Text)       '0.3 

                    Lvi.SubItems.Add(LBLDATAINICIO.Text)   '0.4

                    Lvi.SubItems.Add(LBLDATAFIM.Text)      '0.5

                    Lvi.SubItems.Add("")
                    Lvi.SubItems.Add("Em aberto") ' STATUS 0.7


                    ' se no momento de lançar a lbl data Ini maior q data fim e o valor de lbldata fim é uma string nula então intecepte o código e para
                    If Val(LBLDATAINICIO.Text) > Val(LBLDATAFIM.Text) And Not Val(LBLDATAFIM.Text) = vbNullString Then
                        MsgBox("A data de início não pode ser maior que a data fim!", MsgBoxStyle.Exclamation, "Atenção!")

                        Exit Sub
                    End If


                    Lvi.SubItems.Add(UsuarioLogado.UsuarioLogado & " " & TimeOfDay.ToString("HH:mm"))  '8 opção de entrada

                    Lvi.SubItems.Add("")                          '9 Opção de saída

                    ' adiciona os lvis adicionado anteriormente
                    ListView1.Items.Add(Lvi)


                    Dim ko As New Notifyicone_PopupNotifier
                    ko.Notifyicone_PopupNotifier(vbCrLf & "           < Registro adicionado com êxito > " & vbCrLf &
                                     "               <  com situação em aberto! >",
                                     "                                Notificação ", 1000, BTADD)

                    Await Task.Delay(6000)



                    SalvarDados.SalvarDadosLocalmenteListview_depoisnaNuvem(Application.StartupPath & "\BD\Reg.txt", ListView1, BTADD) 'tem imbutido o upload 
                    Await Task.Delay(3000)

                    Reproduzir_Som.Play("incoming-message-v2.wav")


                    LBLDATAINICIO.Text = String.Empty
                    LBLDATAFIM.Text = String.Empty
                    LIMPARTODASTEXTBOX.LIMPARTODASTEXTBOX(Me, CBOMOTIVO)

                    '---------------tira a seleção do listview----------------------
                    ListView1.SelectedItems.Clear() 'zerar a seleção
                    Lvi.Selected = False
                    ListView1.HideSelection = True
                    ListView1.EnsureVisible(ListView1.Items.Count - 1)
                    '----------------------------------------------------------------------

                    Exit Sub

                    'se ainda no 1° item a data inicio e data fim estiverem preenchidas então
                ElseIf LBLDATAINICIO.Text <> "" AndAlso LBLDATAFIM.Text <> "" Then

                    Dim Lvi As New ListViewItem(TXTID.Text, 0) '0
                    Lvi.SubItems.Add(TXTREGISTRO.Text)     '1
                    Lvi.SubItems.Add(TXTNOME.Text)         '2
                    Lvi.SubItems.Add(CBOMOTIVO.Text)       '3
                    Lvi.SubItems.Add(LBLDATAINICIO.Text)    '4
                    Lvi.SubItems.Add(LBLDATAFIM.Text)      '5


                    '---------------subitem 6 com Condicional Diferença-----------------------------------------------------------------
                    If LBLDATAINICIO.Text <> Nothing AndAlso LBLDATAFIM.Text <> Nothing Then

                        Dim A1, A2 As Date
                        A1 = DTPINICIO.Value.ToShortDateString
                        A2 = DTPFIM.Value.ToShortDateString

                        Dim T As TimeSpan = A2.Subtract(A1)

                        ' ListView1.Items(0).SubItems(6).Text = T.Days
                        Lvi.SubItems.Add(T.Days)                'diferença

                    Else
                        MsgBox("Adicione a data de saída!", MsgBoxStyle.Exclamation, "Atenção!")
                        Return
                    End If
                    '--------------------------------------------------subitem 6 com Condicional 6   -------------------------------------------------------------


                    Lvi.SubItems.Add("Concluído")  '7

                    If Val(CDate(LBLDATAINICIO.Text).Ticks) > Val(CDate(LBLDATAFIM.Text).Ticks) Then
                        MsgBox("A data de início não pode ser maior que a data fim!", MsgBoxStyle.Exclamation, "Atenção!")
                        Exit Sub
                    End If

                    Lvi.SubItems.Add(UsuarioLogado.UsuarioLogado & " " & TimeOfDay.ToString("HH:mm")) 'opção de entrada
                    Lvi.SubItems.Add(UsuarioLogado.UsuarioLogado & " " & TimeOfDay.ToString("HH:mm")) 'opção de saída


                    ListView1.Items.Add(Lvi)
                    LBLDATAINICIO.Text = String.Empty
                    LBLDATAFIM.Text = String.Empty


                    Dim ko As New Notifyicone_PopupNotifier
                    If LBLDATAINICIO.Text <> "" AndAlso LBLDATAFIM.Text = "" Then

                        ko.Notifyicone_PopupNotifier(vbCrLf & "           < Registro adicionado com êxito > " & vbCrLf &
                                     "               < com situação em aberto! >",
                                     "                                  Notificação ", 1100, BTADD)

                        Await Task.Delay(6000)



                        SalvarDados.SalvarDadosLocalmenteListview_depoisnaNuvem(Application.StartupPath & "\BD\Reg.txt", ListView1, BTADD)
                        Await Task.Delay(1500)


                        Beep()
                        ListView1.EnsureVisible(ListView1.Items.Count - 1)
                        FileCopy(Application.StartupPath & "\BD\Reg.txt", Application.StartupPath & "\BD\Backup\Reg.txt")
                        '-------------------------------------------------------------------------------------------------------------------------------

                    ElseIf LBLDATAINICIO.Text <> "" AndAlso LBLDATAFIM.Text <> "" Then

                        ko.Notifyicone_PopupNotifier(vbCrLf & "           < Registro adicionado com êxito > " & vbCrLf &
                                "               < com situação finalizada! >",
                                "                        Notificação ", 1100, BTADD)

                        Await Task.Delay(6000)


                        SalvarDados.SalvarDadosLocalmenteListview_depoisnaNuvem(Application.StartupPath & "\BD\Reg.txt", ListView1, BTADD)
                        Await Task.Delay(1500)

                        Beep()
                        FileCopy(Application.StartupPath & "\BD\Reg.txt", Application.StartupPath & "\BD\Backup\Reg.txt")
                    End If
                    '-----------------------------------------------------------------------------------------------------------------------------------

                    LBLDATAINICIO.Text = String.Empty
                    LBLDATAFIM.Text = String.Empty
                    LIMPARTODASTEXTBOX.LIMPARTODASTEXTBOX(Me, CBOMOTIVO)
                    ListView1.SelectedItems.Clear() 'zerar a seleção
                    Lvi.Selected = False
                    ListView1.HideSelection = True
                    ListView1.EnsureVisible(ListView1.Items.Count - 1)
                    Exit Sub
                End If



                'se a função de pesquisa 'find item text' não é vazia ou seja se encontrar a correspondencia q procura neste caso a txtId.text  então
            ElseIf Not ListView1.FindItemWithText(TXTID.Text, False, 0, True) Is Nothing AndAlso
                ListView1.Items.Count = 0 Then
                Lvi.Selected = True
                'ListView1.Items(0).Text = ListView1.FindItemWithText(TXTID.Text, False, 0, True).Text
                ListView1.Items(0).SubItems(0).Text = TXTID.Text
                ListView1.Items(0).SubItems(1).Text = TXTREGISTRO.Text
                ListView1.Items(0).SubItems(2).Text = TXTNOME.Text
                ListView1.Items(0).SubItems(3).Text = CBOMOTIVO.Text
                ListView1.Items(0).SubItems(4).Text = LBLDATAINICIO.Text
                ListView1.Items(0).SubItems(5).Text = LBLDATAFIM.Text

                '-------------------------------------------------subitem 6 com Condicional--------------------------------------------------


                If LBLDATAFIM.Text <> Nothing AndAlso LBLDATAINICIO.Text <> Nothing Then

                    Dim A1, A2 As Date
                    A1 = DTPINICIO.Value.ToString("dd/MM/yyyy")
                    A2 = DTPFIM.Value.ToString("dd/MM/yyyy")

                    Dim T As TimeSpan = A2.Subtract(A1)

                    ListView1.Items(0).SubItems(6).Text = T.Days
                Else
                    MsgBox("Adicione a data de saída!", MsgBoxStyle.Exclamation, "Atenção!")
                    Return
                End If
                '--------------------------------------------------subitem 6 com Condicional ---------------------------------------------------------------


                ListView1.Items(0).SubItems(7).Text = "Concluído" 'subitem 
                'ListView1.Items.Add(Lvi2) 'NÃO PRECISO ADICIONAR PQP JÁINSTANCIEI EU VALOR ACIMA ANTES DA CONDIÇÃO > Lvi2.Text = TXTID.Text

                Dim k1 As New Notifyicone_PopupNotifier
                k1.Notifyicone_PopupNotifier(vbCrLf & "                    < Registro finalizado com êxito! >", "                                   Notificação ", 1100, BTADD)

                Await Task.Delay(6000)

                LBLDATAINICIO.Text = String.Empty
                LBLDATAFIM.Text = String.Empty


                SalvarDados.SalvarDadosLocalmenteListview_depoisnaNuvem(Application.StartupPath & "\BD\Reg.txt", ListView1, BTADD)
                Await Task.Delay(1500)

                '-------------------------------------------------------------------------------------------------------------------------------------------------
                LIMPARTODASTEXTBOX.LIMPARTODASTEXTBOX(Me, CBOMOTIVO)
                ListView1.EnsureVisible(ListView1.Items.Count - 1)
                ListView1.SelectedItems.Clear()
                LBLDATAINICIO.Text = String.Empty
                LBLDATAFIM.Text = String.Empty
                ListView1.EnsureVisible(ListView1.Items.Count - 1)
                Exit Sub
                FileCopy(Application.StartupPath & "\BD\Reg.txt", Application.StartupPath & "\BD\Backup\Reg.txt")
                Beep()
            End If


            '##########################################################################



            If ListView1.Items.Count > 0 Then
                ListView1.SelectedItems.Clear()
                Lvi.Selected = False
                If ListView1.FindItemWithText(TXTID.Text, False, 0, True) Is Nothing Then


                    'Se o usuário querer lançar um registro para depois d alguns dias ter que fazer o fechamento do registro p ficar em aberto
                    'a data de início terá que ser adicionado uma data e a data de saida terá que ficar vazia
                    If LBLDATAINICIO.Text <> "" AndAlso LBLDATAFIM.Text = "" Then
                        Lvi = New ListViewItem(TXTID.Text, 0)

                        'Lvi.Text = TXTID.Text
                        Lvi.SubItems.Add(TXTREGISTRO.Text)
                        Lvi.SubItems.Add(TXTNOME.Text)
                        Lvi.SubItems.Add(CBOMOTIVO.Text)
                        Lvi.SubItems.Add(LBLDATAINICIO.Text)
                        Lvi.SubItems.Add(LBLDATAFIM.Text)
                        Lvi.SubItems.Add("")        'dif em dias
                        Lvi.SubItems.Add("Em aberto") 'status
                        Lvi.SubItems.Add(UsuarioLogado.UsuarioLogado & " " & TimeOfDay.ToString("HH:mm")) 'Opção de entrada
                        Lvi.SubItems.Add("")

                        'If Val(CDate(LBLDATAINICIO.Text).Ticks) > Val(CDate(LBLDATAFIM.Text).Ticks) Then
                        '    MsgBox("A data de início não pode ser maior que a data fim!", MsgBoxStyle.Exclamation, "Atenção!")
                        '    Exit Sub
                        'End If

                        ListView1.Items.Add(Lvi)
                        LBLDATAINICIO.Text = String.Empty
                        LBLDATAFIM.Text = String.Empty
                        ListView1.EnsureVisible(ListView1.Items.Count - 1)

                        Dim ko As New Notifyicone_PopupNotifier
                        ko.Notifyicone_PopupNotifier(vbCrLf & "           < Registro adicionado com êxito > " & vbCrLf &
                                     "               < com situação em aberto! >",
                                     "                                   Notificação ", 1000, BTADD)
                        '-----------------------------------------------------------------------------------------------------------------------------
                        Await Task.Delay(6000)

                        Await Task.Delay(100)
                        SalvarDados.SalvarDadosLocalmenteListview_depoisnaNuvem(Application.StartupPath & "\BD\Reg.txt", ListView1, BTADD)
                        Await Task.Delay(1500)



                        '----------------------------------------------------------------------------------------------------------------------------

                        LIMPARTODASTEXTBOX.LIMPARTODASTEXTBOX(Me, CBOMOTIVO)
                        ListView1.SelectedItems.Clear() 'zerar a seleção
                        Lvi.Selected = False
                        ListView1.HideSelection = True
                        ListView1.EnsureVisible(ListView1.Items.Count - 1)
                        Beep()
                        FileCopy(Application.StartupPath & "\BD\Reg.txt", Application.StartupPath & "\BD\Backup\Reg.txt")

                        'caso o usuário queira lançar de uma vez o registro, ou seja dar entrada e fazer o fechamento do registro em aberto na mesma hora
                        ' ou momento aqui na finalização do registro, o campo de SITUAÇÃO deverá ser Concluído > CONCLUÍDO
                        ' para isso aqui deverá ser esta rotina
                    ElseIf LBLDATAINICIO.Text <> String.Empty AndAlso
                        LBLDATAFIM.Text <> String.Empty Then

                        Lvi = New ListViewItem(TXTID.Text, 0)  '0
                        Lvi.SubItems.Add(TXTREGISTRO.Text)     '1
                        Lvi.SubItems.Add(TXTNOME.Text)         '2
                        Lvi.SubItems.Add(CBOMOTIVO.Text)       '3
                        Lvi.SubItems.Add(LBLDATAINICIO.Text)    '4
                        Lvi.SubItems.Add(LBLDATAFIM.Text)      '5

                        '-----------------------------------subitem 6 com Condicional Diferença em dias----------------------------------------------
                        If LBLDATAFIM.Text <> Nothing AndAlso LBLDATAINICIO.Text <> Nothing Then

                            Dim A1, A2 As Date
                            A1 = DTPINICIO.Value.ToString("dd/MM/yyyy")
                            A2 = DTPFIM.Value.ToString("dd/MM/yyyy")

                            Dim T As TimeSpan = A2.Subtract(A1)

                            ' ListView1.Items(0).SubItems(6).Text = T.Days
                            Lvi.SubItems.Add(T.Days)

                        Else
                            MsgBox("Adicione a data de saída!", MsgBoxStyle.Exclamation, "Atenção!")
                            Return
                        End If
                        '---------------------------------------fechamento sub item 6 com Condicional-------------------------------------------------------




                        Lvi.SubItems.Add("Concluído")  'status
                        Lvi.SubItems.Add(UsuarioLogado.UsuarioLogado & " " & TimeOfDay.ToString("HH:mm")) 'Opção de entrada
                        Lvi.SubItems.Add(UsuarioLogado.UsuarioLogado & " " & TimeOfDay.ToString("HH:mm")) 'opção de saida


                        If Val(CDate(LBLDATAINICIO.Text).Ticks) > Val(CDate(LBLDATAFIM.Text).Ticks) Then
                            MsgBox("A data de início não pode ser maior que a data fim!", MsgBoxStyle.Exclamation, "Atenção!")
                            Exit Sub
                        End If

                        ListView1.Items.Add(Lvi)
                        LBLDATAINICIO.Text = String.Empty
                        LBLDATAFIM.Text = String.Empty
                        ListView1.EnsureVisible(ListView1.Items.Count - 1)

                        Dim ko As New Notifyicone_PopupNotifier
                        ko.Notifyicone_PopupNotifier(vbCrLf & "           < Registro adicionado com êxito > " & vbCrLf &
                                     "               < com situação Concluída! >",
                                     "                        Notificação ", 1100, BTADD)
                        '------------------------------------------------------------------------------------------------------------------------------------
                        Await Task.Delay(6000)



                        Await Task.Delay(100)

                        SalvarDados.SalvarDadosLocalmenteListview_depoisnaNuvem(Application.StartupPath & "\BD\Reg.txt", ListView1, BTADD)
                        Await Task.Delay(1500)

                        Beep()


                        LIMPARTODASTEXTBOX.LIMPARTODASTEXTBOX(Me, CBOMOTIVO)
                        ListView1.SelectedItems.Clear() 'zerar a seleção
                        Lvi.Selected = False
                        ListView1.HideSelection = True
                        ListView1.EnsureVisible(ListView1.Items.Count - 1)
                        FileCopy(Application.StartupPath & "\BD\Reg.txt", Application.StartupPath & "\BD\Backup\Reg.txt")

                    End If


                    ' se existe o item pesquisado pela função
                ElseIf Not ListView1.FindItemWithText(TXTID.Text, False, 0, True) Is Nothing Then
                    For I As Integer = 0 To ListView1.Items.Count - 1
                        If ListView1.Items(I).Text.Contains(TXTID.Text) Then
                            'Lvi.Selected = True

                            ListView1.Items(I).SubItems(0).Text = TXTID.Text
                            ListView1.Items(I).SubItems(1).Text = TXTREGISTRO.Text
                            ListView1.Items(I).SubItems(2).Text = TXTNOME.Text
                            ListView1.Items(I).SubItems(3).Text = CBOMOTIVO.Text
                            ListView1.Items(I).SubItems(4).Text = LBLDATAINICIO.Text
                            ListView1.Items(I).SubItems(5).Text = LBLDATAFIM.Text

                            'subitem 6 com Condicional ===============================================================
                            If LBLDATAFIM.Text <> Nothing AndAlso LBLDATAINICIO.Text <> Nothing Then

                                Dim A1, A2 As Date
                                A1 = DTPINICIO.Value.ToString("dd/MM/yyyy")
                                A2 = DTPFIM.Value.ToString("dd/MM/yyyy")

                                Dim T As TimeSpan = A2.Subtract(A1)

                                ListView1.Items(I).SubItems(6).Text = T.Days
                            Else
                                MsgBox("Adicione a data de saída!", MsgBoxStyle.Exclamation, "Atenção!")
                                Return
                            End If
                            ''''''''''''''''''''''''''subitem 6 com Condicional'''''''''''''''''''


                            ListView1.Items(I).SubItems(7).Text = "Concluído" 'subitem 
                            'ListView1.Items.Add(Lvi2) 'NÃO PRECISO ADICIONAR PQP JÁINSTANCIEI EU VALOR ACIMA ANTES DA CONDIÇÃO > Lvi2.Text = TXTID.Text
                            If ListView1.Items(I).SubItems(7).Text = "Concluído" Then
                                ListView1.Items(I).SubItems(9).Text = UsuarioLogado.UsuarioLogado & " " & TimeOfDay.ToString("HH:mm")
                            End If

                            Exit For

                        End If
                    Next

                    Dim k1 As New Notifyicone_PopupNotifier
                    k1.Notifyicone_PopupNotifier(vbCrLf & "                    < Registro finalizado com êxito! >", "                                  Notificação ", 1100, BTADD)

                    Await Task.Delay(6000)
                    Await Task.Delay(100)
                    SalvarDados.SalvarDadosLocalmenteListview_depoisnaNuvem(Application.StartupPath & "\BD\Reg.txt", ListView1, BTADD)
                    Await Task.Delay(1500)
                    Beep()
                    LBLDATAINICIO.Text = String.Empty
                    LBLDATAFIM.Text = String.Empty
                    LIMPARTODASTEXTBOX.LIMPARTODASTEXTBOX(Me, CBOMOTIVO)
                    ListView1.EnsureVisible(ListView1.Items.Count - 1)
                    ListView1.SelectedItems.Clear()
                    LIMPARTODASTEXTBOX.LIMPARTODASTEXTBOX(Me)
                    ListView1.EnsureVisible(ListView1.Items.Count - 1)
                    FileCopy(Application.StartupPath & "\BD\Reg.txt", Application.StartupPath & "\BD\Backup\Reg.txt")
                End If

            End If


            ' se não tem internet
        Else
            ' MsgBox("Sem rede", MsgBoxStyle.Exclamation, "Atenção")
            'Close()

            If Not My.Computer.Network.IsAvailable Then

                I1.Notifyicone_PopupNotifier(vbCrLf & "           Voce está desconectado com a Internet! " & vbCrLf & vbCrLf & vbCrLf & "                    ", "                       Verificação da rede!", 1000, Me)
                ListView1.EnsureVisible(ListView1.Items.Count - 1)
                Return
                Exit Sub

            End If

        End If

        CriarBackup(Application.StartupPath & "\Reg.txt",
                   Application.StartupPath & "\BD\Backup\", Application.StartupPath & "\Reg.txt",
                   BTCARREGAR,
                   BTADD)

    End Sub

    Private Sub BTADD_Click(sender As Object, e As EventArgs) Handles BTADD.Click
        If TXTID.Text = "" Then

            I1.Notifyicone_PopupNotifier(vbCrLf & "              Preencha o campo " & "Id" & " corretamente!", vbCrLf & vbCrLf & vbCrLf & "                    Validação de entrada de dados!", 1500, TXTID)
            TXTID.Focus()
            Exit Sub

        ElseIf TXTREGISTRO.Text = "" Then
            I1.Notifyicone_PopupNotifier(vbCrLf & "              Preencha o campo " & "Registro" & " corretamente!", vbCrLf & vbCrLf & vbCrLf & "                    Validação de entrada de dados!", 1100, TXTREGISTRO)
            TXTREGISTRO.Focus()
            Exit Sub

        ElseIf TXTNOME.Text = "" Then
            I1.Notifyicone_PopupNotifier(vbCrLf & "              Preencha o campo " & "Nome" & " corretamente!", vbCrLf & vbCrLf & vbCrLf & "                    Validação de entrada de dados!", 1100, TXTNOME)
            TXTNOME.Focus()
            Exit Sub

        ElseIf CBOMOTIVO.SelectedItem = "" Then
            I1.Notifyicone_PopupNotifier(vbCrLf & "              Preencha o campo " & "Motivo" & " corretamente!", vbCrLf & vbCrLf & vbCrLf & "                    Validação de entrada de dados!", 1100, CBOMOTIVO)
            CBOMOTIVO.Focus()
            Exit Sub

        ElseIf LBLDATAINICIO.Text = "" Then
            I1.Notifyicone_PopupNotifier(vbCrLf & "              Preencha o campo " & "Data de início" & " corretamente!", vbCrLf & vbCrLf & vbCrLf & "                    Validação de entrada de dados!", 1100, DTPINICIO)
            DTPINICIO.Select()
            Exit Sub

            Dim P As Object = If(My.Computer.Network.IsAvailable, "Conexão da internet está Ok", "Não há coexão com a internet")


        ElseIf LBLDATAINICIO.Text <> "" AndAlso LBLDATAFIM.Text <> "" AndAlso
            Val(CDate(LBLDATAINICIO.Text).Ticks > Val(CDate(LBLDATAFIM.Text).Ticks)) Then
            I1.Notifyicone_PopupNotifier(vbCrLf & "           Data de INICIO não pode ser MAIOR que a data FIM.", vbCrLf & vbCrLf & vbCrLf & "                    Validação de entrada de dados!", 1100, BTADD)
            Exit Sub
            DTPINICIO.Select()

        End If

        '-------------------------------------------------------------------------------------------------------------

        ADICIONAR()


        ListView1.EnsureVisible(ListView1.Items.Count - 1)
        QuantidadeRegistros = ListView1.Items.Count
        LblQuantidadeFRMGeral.Text = "Quantidade de Registros: " & QuantidadeRegistros
        Play("morning.wav")

    End Sub
    Private Sub BTNMaximizar_Click(sender As Object, e As EventArgs) Handles BTNMaximizar.Click
        If WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        Else
            WindowState = FormWindowState.Maximized
        End If

    End Sub

    Private Sub DTPINICIO_CloseUp(sender As Object, e As EventArgs) Handles DTPINICIO.CloseUp
        LBLDATAINICIO.Text = DTPINICIO.Value.ToShortDateString
        If LBLDATAINICIO.Text <> "" Then BTLIMPARDATAINICIO.Checked = True
    End Sub

    Private Sub DTPFIM_CloseUp(sender As Object, e As EventArgs) Handles DTPFIM.CloseUp
        LBLDATAFIM.Text = DTPFIM.Value.ToShortDateString

        If LBLDATAFIM.Text <> "" Then BTLIMPARDATAFIM.Checked = True

    End Sub

    Private Sub BTLIMPARDATAINICIO_Click(sender As Object, e As EventArgs) Handles BTLIMPARDATAINICIO.Click
        LBLDATAINICIO.Text = ""

    End Sub

    Private Sub BTLIMPARDATAFIM_Click(sender As Object, e As EventArgs) Handles BTLIMPARDATAFIM.Click
        LBLDATAFIM.Text = ""
    End Sub

    Private Sub TXTID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTID.KeyPress
        SONUMEROS.SONUMEROS(TXTID.Text, e)
    End Sub

    Private Sub TXTREGISTRO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTREGISTRO.KeyPress
        TXTREGISTRO.MaxLength = 11
        SONUMEROS.SONUMEROS(TXTREGISTRO.Text, e)
    End Sub

    Private Sub TXTNOME_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTNOME.KeyPress
        TXTNOME.MaxLength = 23
        SOLETRAS.SOLETRAS(TXTNOME.Text, e)
    End Sub

    Private Sub SELECIONARDTPFIM()
        DTPFIM.Select()
    End Sub
    Private Sub TXTID_Leave(sender As Object, e As EventArgs) Handles TXTID.Leave



        If ListView1.Items.Count > 0 Then
            Dim Lvi As New ListViewItem(TXTID.Text, 0)

            For K As Integer = 0 To ListView1.Items.Count - 1
                Lvi.Text = TXTID.Text

                If ListView1.Items(K).Text = (Trim(Lvi.Text)) AndAlso
                    ListView1.Items(K).SubItems(7).Text = "Em aberto" AndAlso
                    ListView1.Items(K).Text IsNot Nothing Then

                    MsgBox("ID Existente de Número " & Lvi.Text & " encontrado em aberto!", MsgBoxStyle.Information, "Atenção")

                    ListView1.Items(K).Selected = True
                    ListView1.EnsureVisible(K)

                    If MsgBox("Deseja fazer o fechamento deste registro" & Chr(13) & "que se encontra em aberto? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Atenção") = MsgBoxResult.Yes Then

                        'TXTID.ForeColor = Color.Green

                        TXTREGISTRO.Text = ListView1.Items(K).SubItems(1).Text
                        'TXTREGISTRO.ForeColor = Color.Green

                        TXTNOME.Text = ListView1.Items(K).SubItems(2).Text
                        'TXTNOME.ForeColor = Color.Green

                        CBOMOTIVO.Text = ListView1.Items(K).SubItems(3).Text
                        'CBOMOTIVO.ForeColor = Color.Green

                        DTPINICIO.Value = ListView1.Items(K).SubItems(4).Text
                        LBLDATAINICIO.Text = DTPINICIO.Value
                        ListView1.HideSelection = True
                        Exit For
                        Exit Sub

                    Else
                        MsgBox("Ação cancelada pelo usuário!", MsgBoxStyle.Information, "Atenção")
                        LIMPARTODASTEXTBOX.LIMPARTODASTEXTBOX(Me)
                        Exit Sub
                    End If

                    Stop
                    Exit For
                    Exit Sub

                ElseIf ListView1.Items(K).Text = (Trim(Lvi.Text)) AndAlso
                    ListView1.Items(K).SubItems(7).Text = "Concluído" AndAlso
                    ListView1.Items(K).Text IsNot Nothing Then

                    Dim I As New Notifyicone_PopupNotifier
                    I.Notifyicone_PopupNotifier(vbCrLf & "               Id de identificação existente!   ", "                          Notificação!", 1200, TXTID)
                    ListView1.Items(K).Selected = True
                    TXTID.Focus()
                End If
            Next
        End If

        '  LIMPARTODASTEXTBOX.LIMPARTODASTEXTBOX(Me)



    End Sub


    ' Public DesejaTrabalharOffLine As Boolean

    Private Async Sub FrmGeral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblaguarde.Visible = False
        'With ProgressBar1
        '    .Name = "ProgressBar1"
        '    .Animated = True
        '    .AnimationSpeed = 0.6
        '    .FillColor = Color.CornflowerBlue
        '    .BackColor = Color.Transparent
        '    .Enabled = True
        '    .ForeColor = Color.CornflowerBlue
        '    .Backwards = False
        '    .Minimum = 0
        '    .Maximum = 100
        '    .ShowPercentage = True
        '    .GradientMode = Drawing2D.LinearGradientMode.Horizontal
        '    .FillThickness = 23
        '    .ProgressColor = Color.CornflowerBlue
        '    .ProgressColor2 = Color.LightCyan
        '    .ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Gradient
        '    .Location = New Point(587, 30)
        '    .Size = New Size(95, 88)
        '    .ImageSize = New Size(42, 42)
        '    .Anchor = AnchorStyles.Top + AnchorStyles.Left
        '    .ProgressStartCap = Drawing2D.LineCap.Flat
        '    .ProgressEndCap = Drawing2D.LineCap.Flat
        '    .Font = New Font("Corbel", 12, FontStyle.Regular)
        'End With


        ProgressBar1.Visible = False
        TimerProgresbar.Stop()

        Dim Valor1 As Boolean = My.Computer.Network.Ping("www.google.com.br")
        IniciliazarComponets()
        Validar_No_Load()


        BTCARREGAR.Enabled = False

        Await Task.Delay(2000)

        'Internet.FTP_Dowload(Application.StartupPath & "\BD\Reg.txt",
        '                  "ftp://files.000webhost.com/public_html/Reg.txt",
        '                  "marcosferreiramf",
        '                  "Senha0789")

        'Await Task.Delay(6000)

        If Valor1 = True Then
            LblRede.Text = "Conectado"
            I1.Notifyicone_PopupNotifier(vbCrLf & "                    Você está conectado a Internet " & vbCrLf & vbCrLf & vbCrLf & "                    ", "                       Verificação da rede!", 1000, Me)

        Else

            LblRede.Text = "Você está " & "Desconectado"

        End If


        BTCARREGAR.Enabled = True


    End Sub

    Private Sub IniciliazarComponets()

        CenterToParent()
        Opacity = 0.02
        Timer1.Interval = 1          '50
        Timer1.Enabled = True

    End Sub

    Sub Validar_No_Load()

        TXTID.Enabled = False
        LblId_.Visible = False
        TXTNOME.Enabled = False
        LblNome_.Visible = False
        TXTREGISTRO.Enabled = False
        LblReg_.Visible = False
        CBOMOTIVO.Enabled = False
        LblMotivo_.Visible = False
        DTPINICIO.Enabled = False
        DTPFIM.Enabled = False
        ListView1.Enabled = False

        BTADD.Enabled = False
        BTNminimizar.Enabled = False
        BTNMaximizar.Enabled = False
        BTEDIT.Enabled = False
        BTPESQUISAR.Enabled = False
        BTEXCLUIR.Enabled = False
    End Sub

    Private Async Sub DesvalidardadosnoLoad()

        TXTID.Enabled = True
        LblId_.Visible = True
        TXTNOME.Enabled = True
        LblNome_.Visible = True
        TXTREGISTRO.Enabled = True
        LblReg_.Visible = True
        CBOMOTIVO.Enabled = True
        LblMotivo_.Visible = True
        DTPINICIO.Enabled = True
        DTPFIM.Enabled = True
        ListView1.Enabled = True

        BTADD.Enabled = True
        BTNminimizar.Enabled = True
        BTNMaximizar.Enabled = True
        BTEDIT.Enabled = True
        BTPESQUISAR.Enabled = True
        BTEXCLUIR.Enabled = True

        Await Task.Delay(2000)
        TXTID.Focus()

        'info5.Notifyicone_PopupNotifier(vbCrLf & "              Banco de dados carregados corretamente", "                      Leitura do data Reader", 1500, BTCARREGAR)
    End Sub


    Private Async Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        If e.KeyData = Keys.Delete Then
            If ListView1.SelectedItems.Count > 0 Then
                If MsgBox("Deseja deletar este's' item's ? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Cuidado!") = DialogResult.Yes Then
                    For Each I As ListViewItem In ListView1.SelectedItems
                        I.Remove()
                    Next
                    LblQuantidadeFRMGeral.Text = "Quantidade de Registros: " & QuantidadeRegistros
                    info5.Notifyicone_PopupNotifier(vbCrLf & "            < Item(s) excluído(s) da lista com êxito >", "                             ...Exclusão...", 1100, Me)
                    '-----------------------------------------------------------------------------------------------

                    Await Task.Delay(5000)
                    SalvarDados.SalvarDadosLocalmenteListview_depoisnaNuvem(Application.StartupPath & "\BD\Reg.txt", ListView1, BTADD)
                    Await Task.Delay(5000)
                    FileCopy(Application.StartupPath & "\BD\Reg.txt", Application.StartupPath & "\BD\Backup\Reg.txt")
                    Play("pikachu.wav")
                    '-------------------------------------------------------------------------------------------
                    LBLDATAFIM.Text = ""
                    LBLDATAINICIO.Text = ""
                    BTLIMPARDATAINICIO.FillColor = Color.Empty
                    BTLIMPARDATAFIM.FillColor = Color.Empty

                Else
                    info5.Notifyicone_PopupNotifier(vbCrLf & "                   <<Cancelado pelo Usuario! > ", "                          ...Informativo...", 1100, Me)
                End If
            End If
        End If

    End Sub

    Private Sub BTADD_MouseEnter(sender As Object, e As EventArgs) Handles BTADD.MouseEnter

        Ajuda_Tooltip(Guna2HtmlToolTip1, BTADD, " Adicionar items! Pode usar ALT+I para inserir registros.")

        With Guna2HtmlToolTip1
            .BackColor = Color.AliceBlue
            .ForeColor = Color.RoyalBlue
            .AutoPopDelay = 5000
            .BorderColor = Color.White

        End With

    End Sub

    'Private Sub TXTID_GotFocus(sender As Object, e As EventArgs) Handles TXTID.GotFocus
    '    ListView1.SelectedItems.Clear()
    '    Lvi.Selected = False
    'End Sub


    Private Sub BTPESQUISAR_Click(sender As Object, e As EventArgs) Handles BTPESQUISAR.Click
        FRMFiltroDatas.ShowDialog()
    End Sub


    Private Sub BTEDIT_MouseEnter(sender As Object, e As EventArgs) Handles BTEDIT.MouseEnter

        Ajuda_Tooltip(Guna2HtmlToolTip1, BTEDIT, " Editar items! Use as teclas ALT+E para acessar pelo atalho!")
        With Guna2HtmlToolTip1
            .BackColor = Color.White
            .ForeColor = Color.RoyalBlue
            .AutoPopDelay = 10000
            .BorderColor = Color.Blue

        End With

    End Sub

    Private Sub BTNMaximizar_MouseEnter(sender As Object, e As EventArgs) Handles BTNMaximizar.MouseEnter

        Ajuda_Tooltip(Guna2HtmlToolTip1, BTNMaximizar, " Maximizar tela")

        With Guna2HtmlToolTip1

            .BackColor = Color.White
            .ForeColor = Color.RoyalBlue
            .AutoPopDelay = 10000
            .BorderColor = Color.Blue

        End With

    End Sub

    Private Sub BTEXCLUIR_MouseEnter(sender As Object, e As EventArgs) Handles BTEXCLUIR.MouseEnter

        Ajuda_Tooltip(Guna2HtmlToolTip1, BTEXCLUIR, " Exclui item 's selecionados 's .Você tambem pode selecionar na lista e pressionar delete para excluir!")

        With Guna2HtmlToolTip1

            .BackColor = Color.White
            .ForeColor = Color.RoyalBlue
            .AutoPopDelay = 10000
            .BorderColor = Color.Blue

        End With
    End Sub

    Private Sub BTCARREGAR_MouseEnter(sender As Object, e As EventArgs) Handles BTCARREGAR.MouseEnter
        Ajuda_Tooltip(Guna2HtmlToolTip1, BTCARREGAR, " Carrega o Banco de dados. Use ALT+Enter para atalho!")

        With Guna2HtmlToolTip1
            .BackColor = Color.White
            .ForeColor = Color.RoyalBlue
            .AutoPopDelay = 10000
            .BorderColor = Color.Blue

        End With
    End Sub

    Private Sub BTNminimizar_MouseEnter(sender As Object, e As EventArgs) Handles BTNminimizar.MouseEnter
        Ajuda_Tooltip(Guna2HtmlToolTip1, BTNminimizar, " Minimizar tela")

        With Guna2HtmlToolTip1
            .BackColor = Color.White
            .ForeColor = Color.RoyalBlue
            .AutoPopDelay = 10000
            .BorderColor = Color.Blue

        End With
    End Sub

    Private Sub BTPESQUISAR_MouseEnter(sender As Object, e As EventArgs) Handles BTPESQUISAR.MouseEnter
        Ajuda_Tooltip(Guna2HtmlToolTip1, BTPESQUISAR, "Pesquisa, Consulta, Relatório! Use ALT+P para atalho!")

        With Guna2HtmlToolTip1
            .BackColor = Color.White
            .ForeColor = Color.RoyalBlue
            .AutoPopDelay = 10000
            .BorderColor = Color.Blue

        End With
    End Sub

    'Public Enum PathBackup
    '    LocaldoArquivo = [Enum].Parse(TypeCode.Boolean, Application.StartupPath & "\BD\Backup")
    '    Destino
    '    NomedoArquivo

    'End Enum

    Public Async Sub CriarBackup(ByVal LocaldoArquivo As String, ByVal Destino As String, NomedoArquivo As String, ByVal Optional ct As Control = Nothing, ByVal Optional ct2 As Control = Nothing)

        Dim K As New Notifyicone_PopupNotifier

        If Not IO.Directory.Exists(Application.StartupPath & "\BD\Backup") = True Then ' se não tem a pasta cria
            IO.Directory.CreateDirectory(Destino)
        End If

        'SE arq backup existe então lanço a condição
        If IO.File.Exists(Application.StartupPath & "\BD\Backup\Reg.txt") = True Then ' 

            'SE ARQUIVO RAIZ TEM O MESMO TAMNHO DO ARQ DE BACKUP
            If FileCompare.FileCompare(Application.StartupPath & "\BD\Reg.txt", Application.StartupPath & "\BD\Backup\Reg.txt") = True Then

                FileCopy(Application.StartupPath & "\BD\Reg.txt", Destino & "\Reg.txt")

                K.Notifyicone_PopupNotifier(vbNewLine & Chr(9) & " <Banco de dados com o mesmo tamanho>" & vbNewLine & Chr(9) & "   do Backup! " &
                                            " Backup realizado com êxito", vbNewLine & Chr(9) & Chr(9) & "Informação adicional", 1300, ct)
                Await Task.Delay(3000)

            Else

                'se não tem o mesmo tamanho
                If FileCompare.FileCompare(Application.StartupPath & "\BD\Reg.txt", Application.StartupPath & "\BD\Backup\Reg.txt") = False Then



                    ' SE O TAMANHO DO ARQUIVO da raiz = ZERO
                    If FileLen(Application.StartupPath & "\BD\Reg.txt") = 0 Then

                        FileCopy(Application.StartupPath & "\BD\Backup\Reg.txt", Application.StartupPath & "\BD\Reg.txt") 'COPIA O BKP PARA RAIZ

                        K.Notifyicone_PopupNotifier("Banco de dados com o tamanho = a 0 " & vbCrLf &
                                                    "Banco de dados pode estar corrompido ou vazio!" & vbCrLf & "Restaurando Backup do Banco de dados",
                                                     Chr(9) & "Contacte o administrado do Sistema",
                                                    1000, ct) 'EXIBE A MENSAGEM

                        Await Task.Delay(4000) ' ESPERA 4 SEGUNDOS DE FORMA SINCRONA

                        Internet.FTP_Upload(Application.StartupPath & "\BD\Reg.txt",
                                       "ftp://files.000webhost.com/public_html/Reg.txt",
                                       "marcosferreiramf",
                                       "Senha0789")

                        Await Task.Delay(4000)
                        Exit Sub





                    ElseIf FileLen(Application.StartupPath & "\BD\Reg.txt") < 0 Then
                        K.Notifyicone_PopupNotifier(Chr(9) & "Banco de dados com o tamanho < a 0 " & "Excepção!", Chr(9) & Chr(9) & "Informação adicional", 1300, ct)

                        Await Task.Delay(3000)
                        System.Threading.Thread.Sleep(2000)
                        Exit Sub




                    ElseIf FileLen(Application.StartupPath & "\BD\Reg.txt") > 0 Then

                        'o banco de dados seja maior q o backup, se for copie o banco para a pasta de backup
                        If FileLen(Application.StartupPath & "\BD\Reg.txt") >
                            FileLen(Application.StartupPath & "\BD\Backup\Reg.txt") Then
                            FileCopy(Application.StartupPath & "\BD\Reg.txt", Destino & "\Reg.txt")




                            'se meu banco de dados for menor que o backup significa que quando fez o dowload p a raiz, pela alteração que deveria ter acontecido
                            'mais não aconteceu, então deve-se pegar o backup q é maior e colocar na raiz p q seja o banco principal para usa-lo
                        ElseIf FileLen(Application.StartupPath & "\BD\Reg.txt") <
                            FileLen(Application.StartupPath & "\BD\Backup\Reg.txt") Then


                            K.Notifyicone_PopupNotifier(vbCrLf & Chr(9) & "Banco de dados em Backup (" & FileLen(Application.StartupPath & "\BD\Backup\Reg.txt") & " Bytes) " &
                                                        "É maior que o original " & FileLen(Application.StartupPath & "\BD\Reg.txt") & " Bytes)" & ", Oque significa que o servidor não conseguiu Escrever na nuvem corretamente.Iremos usar o banco de dados local! Backup copiado para a raiz, " &
                                                        "restaurado com êxito!", vbCrLf & Chr(9) & "        Informação adicional", 1200, ct)
                            Await Task.Delay(6100) ';(6000)

                            'For Each i As Process In Process.GetProcesses
                            '    If i.ProcessName = "Reg.txt" Then
                            '        i.Kill()
                            '    End If

                            'Next

                            FileCopy(Application.StartupPath & "\BD\Backup\Reg.txt", Application.StartupPath & "\BD\Reg.txt")
                            CarregarDadosLocalmenteListview(Application.StartupPath & "\BD\Reg.txt", ListView1, BTCARREGAR)
                            SalvarDados.SalvarDadosLocalmenteListview_depoisnaNuvem(Application.StartupPath & "\BD\Reg.txt", ListView1, BTSalvar)
                            Await Task.Delay(5900)
                            TXTID.Clear()

                        End If




                    End If


                End If

            End If


        Else

            If MsgBox("O arquivo de Backup não existe ou foi deletado" & Chr(13) & "Deseja recriar o Backup do banco de dados para segurança dos dados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Atenção") = DialogResult.Yes Then
                FileCopy(Application.StartupPath & "\BD\Reg.txt", Destino & "\Reg.txt")

            End If


        End If
    End Sub



    ''' <summary>
    ''' Faz o dowload do servidor para em seguida carregar no local de destino onde fará a leitura para o objeto Listview
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub BTCARREGAR_Click(sender As Object, e As EventArgs) Handles BTCARREGAR.Click

        Carregabancodedados()
        Play("classic-whistle-old-spice-v2.wav")
        Await Task.Delay(10000)
        TXTID.SelectedText = Nothing
        TXTID.Focus()
        TXTID.Text = ListView1.Items.Count + 1



    End Sub


    Async Sub Carregabancodedados()




        If ListView1.Items.Count > 0 Then
            MsgBox("Banco de dados já foi carregado!", MsgBoxStyle.Exclamation, "Cuidado")
            Exit Sub
        End If

        If ListView1.Items.Count = 0 Then

            ProgressBar1.Visible = True
            lblaguarde.Visible = True
            TimerProgresbar.Start()

            CarregarDados.CarregarDadosdaNuvem(Application.StartupPath & "\BD\Reg.txt", ListView1, BTCARREGAR)




            ' DesvalidardadosnoLoad()
            Await Task.Delay(12000)

            If ListView1.Items.Count > 0 Then
                'Await Task.CompletedTask

                ListView1.EnsureVisible(ListView1.Items.Count - 1)
            End If
            Await Task.Delay(1100)
            QuantidadeRegistros = ListView1.Items.Count
            LblQuantidadeFRMGeral.Text = "Quantidade de Registros: " & QuantidadeRegistros


        End If

        CriarBackup(Application.StartupPath & "\Reg.txt",
                                Application.StartupPath & "\BD\Backup", Application.StartupPath & "\Reg.txt",
                                BTCARREGAR,
                                BTADD)



        Await Task.Delay(5000)

        'Carregar autocomplete de registros
        Try
            Dim Completar As AutoCompleteStringCollection = New AutoCompleteStringCollection
            Completar.Clear()
            For Each i As ListViewItem In ListView1.Items
                Completar.Add(i.SubItems(1).Text)
            Next

            TXTREGISTRO.AutoCompleteCustomSource = Completar

        Catch ex As Exception
            Dim P As Notifyicone_PopupNotifier = New Notifyicone_PopupNotifier
            P.Notifyicone_PopupNotifier("Detalhes da excepção: " & ex.Message, "Excepção encontrada", 700, BTCARREGAR)
            ex.Message.ToString()
        End Try


        'carregar autocomplete do nome

        Try
            Dim Completar2 As AutoCompleteStringCollection = New AutoCompleteStringCollection
            Completar2.Clear()

            For Each i As ListViewItem In ListView1.Items
                Completar2.Add(i.SubItems(2).Text)
            Next
            TXTNOME.AutoCompleteCustomSource = Completar2
        Catch ex As Exception
            Dim P As Notifyicone_PopupNotifier = New Notifyicone_PopupNotifier
            P.Notifyicone_PopupNotifier("Detalhes da excepção: " & ex.Message, "Excepção encontrada", 700, BTCARREGAR)
            ex.Message.ToString()
        End Try


    End Sub


    Private Sub TXTNOME_Leave(sender As Object, e As EventArgs) Handles TXTNOME.Leave

        Dim Palavra_Capitulada = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TXTNOME.Text)
        TXTNOME.Text = Palavra_Capitulada
    End Sub

    Private Async Sub BTEXCLUIR_Click(sender As Object, e As EventArgs) Handles BTEXCLUIR.Click

        If ListView1.SelectedItems.Count > 0 Then



            If MsgBox("Você deseja excluir este(s) item(s) da sua lista?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Cuidado") = DialogResult.Yes Then

                QuantidadeRegistros = 0

                For Each item As ListViewItem In ListView1.SelectedItems
                    If item.Selected = True Then
                        ListView1.Items.Remove(item)
                    End If
                Next
                SalvarDados.SalvarDadosLocalmenteListview_depoisnaNuvem(Application.StartupPath & "\BD\Reg.txt", ListView1, BTEXCLUIR)
                QuantidadeRegistros = ListView1.Items.Count
                LblQuantidadeFRMGeral.Text = "Quantidade de Registros: " & QuantidadeRegistros
                MsgBox("Item(s) excluídos com êxito", 64, "Informativo")


                Await Task.Delay(4000)
                FileCopy(Application.StartupPath & "\BD\Reg.txt", Application.StartupPath & "\BD\Backup\Reg.txt")

            End If
        Else
            MsgBox("Nenhum item(s) selecionado", 64, "Informativo")

        End If

    End Sub


    Private Sub BTLIMPARDATAINICIO_MouseEnter(sender As Object, e As EventArgs) Handles BTLIMPARDATAINICIO.MouseEnter
        Ajuda.Ajuda_Tooltip(Guna2HtmlToolTip1, BTLIMPARDATAINICIO, "Limpar data de Início")
        With Guna2HtmlToolTip1
            .BackColor = Color.White
            .ForeColor = Color.RoyalBlue
            .AutoPopDelay = 10000
            .BorderColor = Color.Red
        End With
    End Sub



    Private Sub BTEDIT_Click(sender As Object, e As EventArgs) Handles BTEDIT.Click
        FRM_edição.ShowDialog()
    End Sub

    Private Sub TXTID_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTID.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXTREGISTRO.Focus()

        End If
    End Sub

    Private Sub TXTREGISTRO_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTREGISTRO.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXTNOME.Focus()

        End If
    End Sub
    Private Sub TXTNOME_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTNOME.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBOMOTIVO.Focus()
        End If
    End Sub


    Private Sub CBOMOTIVO_KeyDown(sender As Object, e As KeyEventArgs) Handles CBOMOTIVO.KeyDown
        If e.KeyCode = Keys.Enter Then
            DTPINICIO.Focus()
            DTPINICIO.Checked = True
        End If
    End Sub

    Private Sub DTPINICIO_KeyDown(sender As Object, e As KeyEventArgs) Handles DTPINICIO.KeyDown
        If e.KeyCode = Keys.Enter Then
            DTPFIM.Focus()

        End If
    End Sub

    Private Sub BTLIMPARDATAFIM_MouseEnter(sender As Object, e As EventArgs) Handles BTLIMPARDATAFIM.MouseEnter
        Ajuda.Ajuda_Tooltip(Guna2HtmlToolTip1, BTLIMPARDATAFIM, "Limpar data fim")
        With Guna2HtmlToolTip1
            .BackColor = Color.White
            .ForeColor = Color.RoyalBlue
            .AutoPopDelay = 10000
            .BorderColor = Color.Red
        End With
    End Sub


    ' Private Async Sub TXTNOME_TextChanged(sender As Object, e As EventArgs) Handles TXTNOME.TextChanged

    'Dim Completar As AutoCompleteStringCollection = New AutoCompleteStringCollection

    'Try

    '    Completar.Clear()
    '    For i As Integer = 0 To FRM_edição.ListView3.Items.Count - 1

    '        Completar.Add(FRM_edição.ListView3.Items(i).SubItems(2).Text)

    '    Next


    '    TXTNOME.AutoCompleteCustomSource = Completar
    '    Await Task.Delay(7)

    'Catch ex As Exception
    '    Dim P As Notifyicone_PopupNotifier = New Notifyicone_PopupNotifier
    '    P.Notifyicone_PopupNotifier("Detalhes da excepção: " & ex.Message, "Excepção encontrada", 700, TXTNOME)
    '    ex.Message.ToString()

    'End Try


    'End Sub

    Private Async Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Opacity += 0.002                'a cada 50 mili segundo eu quero que o timer aumente a opacidade
        Await Task.Delay(10) ' e finalmente fecho o formulário
        If Opacity = 1 Then
            Timer1.Enabled = False                     'se a opacidade for igual a 1 eu desabilito o timer 
            Visible = False                           ' e faço o formulário ficar invisivel
            ' Close()   

            Show()
        End If

    End Sub

    Private Sub TXTID_TextChanged(sender As Object, e As EventArgs) Handles TXTID.TextChanged
        If TXTID.Text = "" Then
            ListView1.SelectedItems.Clear()
        End If
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim Valor1 As Boolean = My.Computer.Network.Ping("www.google.com.br")



        If Valor1 = True Then
            Internet.Conexão_com_Rede(LblConetado)
            LblRede.Text = "Você está conectado"

        Else
            If Valor1 = False Then
                Internet.Conexão_com_Rede(LblConetado)
                LblRede.Text = "Você não está conectado "
            End If

        End If

        'If Valor1 = True AndAlso My.Computer.Network.IsAvailable Then
        '    Internet.Conexão_com_Rede(LblConetado)
        '    LblRede.Text = "Você está conectado"

        'Else
        '    If Not Valor1 = True AndAlso Not My.Computer.Network.IsAvailable AndAlso
        '        LblRede.Text = "Você está desconectado " Then
        '    End If

        'End If

    End Sub

    Private Sub FrmGeral_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Alt And e.KeyCode = Keys.I Then
            BTADD_Click(BTADD, e)
            BTLIMPARDATAINICIO.Checked = False
            BTLIMPARDATAFIM.Checked = False
        ElseIf e.Alt And e.KeyCode = Keys.Enter Then
            BTCARREGAR_Click(BTCARREGAR, e)
            BTLIMPARDATAINICIO.Checked = False
            BTLIMPARDATAFIM.Checked = False
        ElseIf e.Alt And e.KeyCode = Keys.P Then
            BTPESQUISAR_Click(BTPESQUISAR, e)
            BTLIMPARDATAINICIO.Checked = False
            BTLIMPARDATAFIM.Checked = False
        ElseIf e.Alt And e.KeyCode = Keys.E Then
            BTEDIT_Click(BTEDIT, e)
            BTLIMPARDATAINICIO.Checked = False
            BTLIMPARDATAFIM.Checked = False
        ElseIf e.Alt And e.KeyCode = Keys.L Then
            LimparTodoscamposdascaixas()
        End If
    End Sub


    Private Async Sub BTSalvar_Click(sender As Object, e As EventArgs) Handles BTSalvar.Click

        CriarBackup(Application.StartupPath & "\Reg.txt",
                         Application.StartupPath & "\BD\Backup\",
                         Application.StartupPath & "\Reg.txt")

        Await Task.Delay(100)

        SalvarDados.SalvarDadosLocalmenteListview_depoisnaNuvem(Application.StartupPath & "\BD\Reg.txt", ListView1, BTSalvar)
        Await Task.Delay(5000)
    End Sub

    Private Sub BTSalvar_MouseEnter(sender As Object, e As EventArgs) Handles BTSalvar.MouseEnter
        Ajuda_Tooltip(Guna2HtmlToolTip1, BTSalvar, "O sistema já salva automaticamente exceto quando há picos na rede! " & vbNewLine & Chr(13) & "Reconfirme o salvamento caso haja problema de pico e oscilação na rede ou aparecer mensagem de erro do programa!!")

        With Guna2HtmlToolTip1
            .BackColor = Color.White
            .ForeColor = Color.RoyalBlue
            .AutoPopDelay = 10000
            .BorderColor = Color.Blue

        End With
    End Sub


    Private Sub DTPINICIO_GotFocus(sender As Object, e As EventArgs) Handles DTPINICIO.GotFocus
        DTPINICIO.Checked = True
    End Sub

    Private Sub DTPINICIO_Leave(sender As Object, e As EventArgs) Handles DTPINICIO.Leave
        DTPINICIO.Checked = False
    End Sub

    Private Sub BTLIMPARDATAINICIO_GotFocus(sender As Object, e As EventArgs) Handles BTLIMPARDATAINICIO.GotFocus
        BTLIMPARDATAINICIO.BackColor = Color.Green
        BTLIMPARDATAINICIO.ForeColor = Color.Red

    End Sub
    Private Sub BTLIMPARDATAFIM_GotFocus(sender As Object, e As EventArgs) Handles BTLIMPARDATAFIM.GotFocus
        BTLIMPARDATAFIM.BackColor = Color.Green
        BTLIMPARDATAFIM.ForeColor = Color.Red
    End Sub


    Private Sub BTLIMPARDATAINICIO_Leave(sender As Object, e As EventArgs) Handles BTLIMPARDATAINICIO.Leave
        BTLIMPARDATAINICIO.BackColor = Color.DarkGray
        BTLIMPARDATAINICIO.ForeColor = Color.White
    End Sub


    Private Sub BTLIMPARDATAFIM_Leave(sender As Object, e As EventArgs) Handles BTLIMPARDATAFIM.Leave
        BTLIMPARDATAFIM.BackColor = Color.DarkGray
        BTLIMPARDATAFIM.ForeColor = Color.White
    End Sub


    Private Sub DTPFIM_GotFocus(sender As Object, e As EventArgs) Handles DTPFIM.GotFocus
        DTPFIM.Checked = True
    End Sub

    Private Sub DTPFIM_Leave(sender As Object, e As EventArgs) Handles DTPFIM.Leave
        DTPFIM.Checked = False
    End Sub

    Private Sub LblMotivo__GotFocus(sender As Object, e As EventArgs) Handles LblMotivo_.GotFocus
        LblMotivo_.BackColor = Color.White
    End Sub
    Private Sub LblMotivo__Leave(sender As Object, e As EventArgs) Handles LblMotivo_.Leave
        LblMotivo_.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub FrmGeral_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        TXTID.Focus()
    End Sub

    Private Sub LimparTodoscamposdascaixas()
        TXTID.Text = Nothing
        TXTREGISTRO.Text = Nothing
        TXTNOME.Text = Nothing
        CBOMOTIVO.Text = Nothing
        LBLDATAINICIO.Text = Nothing
        LBLDATAFIM.Text = Nothing
        BTLIMPARDATAINICIO.Checked = False
        BTLIMPARDATAFIM.Checked = False
        TXTID.Focus()
    End Sub

    Private Sub TXTID_Enter(sender As Object, e As EventArgs) Handles TXTID.Enter

        BTLIMPARDATAINICIO.Checked = False
        BTLIMPARDATAFIM.Checked = False
        QuantidadeRegistros = ListView1.Items.Count + 1
        If TXTID.Text = "" Then

            If TXTID.Text.Equals(QuantidadeRegistros) = True Then
                TXTID.SelectedText = QuantidadeRegistros
            Else
                TXTID.SelectedText = QuantidadeRegistros
            End If

        End If
    End Sub

    Private Sub BTlimparCampos_Click(sender As Object, e As EventArgs) Handles BTlimparCampos.Click
        LimparTodoscamposdascaixas()
    End Sub

    Private Sub BTlimparCampos_MouseEnter(sender As Object, e As EventArgs) Handles BTlimparCampos.MouseEnter
        Ajuda.Ajuda_Tooltip(Guna2HtmlToolTip1, BTlimparCampos, "Limpa todos campos das caixas de textos ou use ALT+L ")
        With Guna2HtmlToolTip1
            .BackColor = Color.White
            .ForeColor = Color.RoyalBlue
            .AutoPopDelay = 10000
            .BorderColor = Color.Blue
        End With
    End Sub

    Private Async Sub TimerProgresbar_Tick(sender As Object, e As EventArgs) Handles TimerProgresbar.Tick

        ProgressBar1.Increment(1)


        Select Case ProgressBar1.Value.ToString
            Case < 10
                Lblaguarde.Text = "Aguarde..."

            Case = 25
                Lblaguarde.Text = "Em andamento"

            Case = 40

                Lblaguarde.Text = "Carregando Banco de dados"

                'estou delegando o evento click do botão carregar para a rotina desvalidar no load usando o comando AddressOf (endereço de)
                AddHandler BTCARREGAR.Click, AddressOf Carregabancodedados
                Await Task.CompletedTask
            Case = 55
                Lblaguarde.Text = "Processando dados..."


                If System.Threading.Thread.CurrentThread.IsAlive = True Then
                    Lblaguarde.Text = "Threading iniciada"
                Else
                    Lblaguarde.Text = "Threading não foi iniciada"
                End If


            Case = 70
                Lblaguarde.Text = "Finalizando Operações..."


            Case = 100
                Lblaguarde.Text = "Concluído!"

                'estou delegando o evento click do botão carregar para a rotina desvalidar no load usando o comando AddressOf (endereço de)
                'AddHandler BTCARREGAR.Click, AddressOf DesvalidardadosnoLoad

                Lblaguarde.Visible = False
                ProgressBar1.Visible = False

                Lblaguarde.Visible = False
                ProgressBar1.Visible = False
                TimerProgresbar.Stop()
                DesvalidardadosnoLoad()
                Play("incoming-message-v2.wav")

        End Select


        'wxpressão lambda action
        'Dim t = System.Threading.Tasks.Task.Factory.StartNew(Sub()
        '                                                        DesvalidardadosnoLoad()
        '                                                   End Sub)
        't.Wait()
    End Sub


    Private Sub FrmGeral_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        '   Const V As Char = Chr(13)

        If e.KeyChar = Chr(43) Then '+
            BTN_IncVol_Click(BTVolume, e)
        Else
            If e.KeyChar = Chr(45) Then '-
                BTN_DecVol_Click(BTVolume, e)
            Else
                If e.KeyChar = Chr(42) Then '*
                    BTN_Mute_Click(BTVolume, e)
                End If
            End If
        End If

    End Sub

    Private Sub BTVolume_MouseEnter(sender As Object, e As EventArgs) Handles BTVolume.MouseEnter
        Ajuda_Tooltip(Guna2HtmlToolTip1, BTVolume, "Aumentar o volume. " & ChrW(13) & "Teclas de atalho: Aumentar(+) , Subtrair(-) , Mudo(*)  ")

        With Guna2HtmlToolTip1
            .BackColor = Color.White
            .ForeColor = Color.RoyalBlue
            .AutoPopDelay = 10000
            .BorderColor = Color.Blue

        End With
    End Sub

    Private Sub BTVolume_Click(sender As Object, e As EventArgs) Handles BTVolume.Click


        If FrmVolume.MinimizeBox Then
            FrmVolume.Show()
            FrmVolume.Focus()
        Else
            FrmVolume.Show()
            FrmVolume.Focus()
        End If



    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub



    'If ProgressBar1.Value = 100 Then
    '    Dim t As Task = System.Threading.Tasks.Task.Run(Sub()
    '                                                        DesvalidardadosnoLoad()
    '                                                    End Sub)
    '    t.Wait()
    'End If



End Class