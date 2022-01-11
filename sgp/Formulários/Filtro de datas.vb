Imports System.Drawing.Printing
Imports System.Data

Public Class FRMFiltroDatas


    'Imprimir usando as classes PrintDocument e PrintPreviewDialog
    'O PrintDocument envia a saída para impressora eo PrintPreviewDialog exibe uma
    'caixa de dialogo visualizar a impressão

    ' O Objeto prinddocument dispara eventos: 

    '***BeginPrint Ocorre quando a impressão vai começar, neste momento o programa pode iniciar a estrutura de daos, inciar a conexão com a fonte
    ' de dados e realizar qualquer outra operação que for necessária antes de iniciar a ímpressão

    '***O PrintPage ocorre para gerar a página, o programa precisa capturara este evento e usar o Objeto Graphics Fornecidos pelos pâmetros do MANIPULADOR
    ' de eventos para gerar a saída do relatório, ao final o manipulador de eventos deverá definir o valor de  e.HashMorePage para True ou False
    'e devolver para o Objeto PrintDocument informando se existem mais páginas a serem geradas
    '***EndPrint este  evento no término da impressão ele pode sercapturado para liberar recursos usados fechar conexões e etc

    Private PaginaAtual As Integer = 1
    Private RelatorioTitulos

    Private Sub BTImprimir_Click(sender As Object, e As EventArgs) Handles BTImprimir.Click
        Dim RelatorioTitulos = "Relatório de " & LBLrotulo.Text & " - "  'aqui concatenar a data depois
        Dim Pd As Printing.PrintDocument = New Printing.PrintDocument() 'define o objeto printdocuments e eventos associados

        ' definimos 3 eventos p tratar a impressão

        AddHandler Pd.BeginPrint, New Printing.PrintEventHandler(AddressOf Me.Begin_Print)

        AddHandler Pd.PrintPage, New Printing.PrintPageEventHandler(AddressOf Me.PdRelatorios_PrintPage)

        AddHandler Pd.EndPrint, New Printing.PrintEventHandler(AddressOf Me.End_Print)


        '===============Definindo atributos do PrintPreviw Dialog=============================================
        Dim ObjPrintPreviewDialog As New PrintPreviewDialog 'define o objeto para visualizar a impressão
        Try
            'define o objeto como maximazado e com zum
            With ObjPrintPreviewDialog
                .Document = Pd  'tenho que atribuir ao obj printpreview dialog o documento  q quero imprimir(PD) 
                'ao preview dialog que vao me dar a visualização  

                .WindowState = FormWindowState.Maximized
                .PrintPreviewControl.Zoom = 1
                .Text = RelatorioTitulos
                .ShowDialog()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        '===================================================================================================

        ' Agora eu tenho que começar com o evento begin print  adicionado anteriormente em addhandled
        ' AddHandler Pd.BeginPrint, New Printing.PrintPageEventHandler(AddressOf Me.Begin_Print)
        'O begin print vai tratar do evento que é disparado pelo printdocument
        'Configurar_Impressão.ShowDialog()

    End Sub

    Private Sub Begin_Print(sender As Object, e As PrintEventArgs)
        PaginaAtual = 1
    End Sub

    'ou seja p imprimir c estes componentes precisa dos tres eventos se n dara erro
    Private Sub End_Print(ByVal sender As Object, ByVal e As Printing.PrintEventArgs)

    End Sub

    'Netse evento é onde vai muitos códigos
    'pois é aqui mque definimos a forma que a impressão vai tomar ou seja 
    'O layout da pagina a imprimir

    Private Sub PdRelatorios_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        'variaveis das linhas
        Dim LinhasPorPaginas As Single = 0 'defindo quantas linhas por paginas eu vou ter
        Dim PosiçãoDaLinha As Single = 0   'Qual é a posição dalinha  
        Dim LinhaAtual As Integer = 0      'Qual é a linha atual
        ' então p fazer isto estou usando o Obnjeto PrintPageEventArgs que é representado pela variavel e
        '=========================================================================================================================

        'Variaveis das margens(e.MarginBounds obtem a área retangular que representa a parte da página dentro das margens.)
        Dim MargemEsquerda As Single = 0 ' e.MarginBounds.Left  'defindo a margem equerda
        Dim MargemSuperior As Single = e.MarginBounds.Top + 100  'A margem superior q incluo mais 100 un por causa do titulo
        Dim MargemDireita As Single = 0 'e.MarginBounds.Right        'A Margem direira
        Dim MargemInferior As Single = 0 'e.MarginBounds.Bottom      'A Margem inferior

        'exemplo
        'Bounds.X=0;
        'Bounds.y=0;
        'Bounds.widht=850;
        'Bounds.Height=1100;
        'PaperSize.PaperName="Letter"; esta propriedade da classe papersize especifica um pedaço de papel
        'PaperSize.Height=1100;
        'PaperSize.Widht = 850

        'Então eu teria um quadrado assim 'Tamanho do papel

        '              'Margins.Top = 100
        '               '  _______________
        '               ' |               |
        '               ' |               |
        'Margin.Right=100 |               |   'Margins.Right = 100
        '               ' |               |
        '               ' |               |  
        '               ' |_______________|

        '                'Margins.Bottom = 100

        'MarginsBounds:(100,100,650,900)
        '===========================================================================================================================



        'Classe Pen define um Objeto usado para definir as linhas e curvas
        Dim CanetaDaImpressora As Pen = New Pen(Color.Black, 1)

        '=====================================================Campos da tabela========================================================

        'definimos agora variaveis que serão usadas p impreensão´que serão usadas na listview referentes aos campos
        'da tabela,
        Dim Id, Registro, Nome, Motivo, DataInicio, DataFim, Diferenca, Status, OpcaoEntrada, OpcaoSaida As String

        '=============================================================================================================================

        '======================================'Definindo as fontes que serão usadas p impressão=================================
        Dim FonteNegrito As Font = New Font("Arial", 9, FontStyle.Bold)
        Dim FonteTitulo As Font = New Font("Arial", 15, FontStyle.Bold)
        Dim FonteSubtitulo As Font = New Font("Arial", 12, FontStyle.Bold)
        Dim FonteRodape As Font = New Font("Arial", 8)
        Dim FonteNormal As Font = New Font("Arial", 8)

        '===============================================================================================================================


        '=================================Define valores para linha atual e p linha de impressão========================================
        LinhaAtual = 0
        ' cabeçario
        'drawline - Desenha uma linha q conecta os dois pontos especificados pelos pares ordenados os seja
        ' A linha da Borda da página   

        ' aqui faço o desenho quadrado q no seu interior vou desenha oq colocar usando o código abaixo isto tudo dentro do interior deste linha ou quadrado
        e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 100, MargemDireita, 100) '  60 quando matenho o memso valor significa q vai desenha uma linha desenha uma linha no plano horizontal especificado
        e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 160, MargemDireita, 160) '160,160


        '=============================================Definir o Nome Da Empresa dentro do quadrado=========================================
        e.Graphics.DrawString(My.Settings.NomeDaEmpresa, FonteTitulo, Brushes.Black, MargemEsquerda + 280, 80, New StringFormat()) '  OK
        e.Graphics.DrawString("Relatório", FonteTitulo, Brushes.Black, MargemEsquerda + 360, 37, New StringFormat())

        '====================================='imprime o logo tipo da empresa ===============================================================

        e.Graphics.DrawImage(Image.FromFile(Application.StartupPath & "\Vital.ico"), 0, 40) '  ok 0 é o eixo x e 40 é o eixo y
        '============================================================================100========================================================

        '================================================Imprime o titulo do relatório=======================================================
        'quando vou imprimir tenho q me preocupar c a margem esquerda e da a ela um deslocamento para ela ficar mais a frente como um titulo ou siuubtitulo

        'aqui é a data maior                                                                                           'eixo x, eixo y
        e.Graphics.DrawString(RelatorioTitulos & System.DateTime.Now, FonteSubtitulo, Brushes.Black, MargemEsquerda + 334, 130, New StringFormat()) ' na linha 120
        '=-===================================================================================================================================


        '================Aqui vai entrar os campos q serão impressos no nosso Relatorio DO CABEÇARIO ============================

        'ID,Registro,Nome,Motivo,DataInicio,DataFim,Diferença,Status,OpcaoEntrada,OpcaoSaida
        e.Graphics.DrawString("Id", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 170, New StringFormat()) 'todos tem um deslocamento na horizontal + a vertical permaneça
        e.Graphics.DrawString("Reg", FonteNegrito, Brushes.Black, MargemEsquerda + 40, 170, New StringFormat()) ' mais só quando eu for imprimir a linha q vai mudar
        e.Graphics.DrawString("Nome", FonteNegrito, Brushes.Black, MargemEsquerda + 132, 170, New StringFormat())
        e.Graphics.DrawString("Motivo", FonteNegrito, Brushes.Black, MargemEsquerda + 265, 170, New StringFormat())
        e.Graphics.DrawString("DataInício", FonteNegrito, Brushes.Black, MargemEsquerda + 357, 170, New StringFormat())
        e.Graphics.DrawString("DataFim", FonteNegrito, Brushes.Black, MargemEsquerda + 430, 170, New StringFormat())
        e.Graphics.DrawString("Dif", FonteNegrito, Brushes.Black, MargemEsquerda + 500, 170, New StringFormat())
        e.Graphics.DrawString("Status", FonteNegrito, Brushes.Black, MargemEsquerda + 532, 170, New StringFormat())
        e.Graphics.DrawString("Op Entrada", FonteNegrito, Brushes.Black, MargemEsquerda + 595, 170, New StringFormat())
        e.Graphics.DrawString("Op Saída", FonteNegrito, Brushes.Black, MargemEsquerda + 710, 170, New StringFormat())

        'imprime a linha e é aqui q meu deslocamento na vertical acontece com 190 pixels
        e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 200, MargemDireita, 0)
        'define o número de linhas por páginas
        LinhasPorPaginas = CInt(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9) 'aqui pego a altura doa área (quadrado) e divido pela altura do tamnho da fonte q estou utilizando

        'ID,Registro,Nome,Motivo,DataInicio,DataFim,Diferença,Status,OpcaoEntrada,OpcaoSaida
        'agora usaremos um laço  while para lançar p imprenssão



        While (LinhaAtual < LinhasPorPaginas AndAlso LinhaAtual < ListView2.Items.Count)
            For i As Integer = 0 To ListView2.Items.Count - 1

                'Obtendo os valores do listview
                'atribuindo valores as variaveis

                Id = ListView2.Items(i).SubItems(0).Text
                Registro = ListView2.Items(i).SubItems(1).Text
                Nome = ListView2.Items(i).SubItems(2).Text
                Motivo = ListView2.Items(i).SubItems(3).Text
                DataInicio = ListView2.Items(i).SubItems(4).Text
                DataFim = ListView2.Items(i).SubItems(5).Text
                Diferenca = ListView2.Items(i).SubItems(6).Text
                Status = ListView2.Items(i).SubItems(7).Text
                OpcaoEntrada = ListView2.Items(i).SubItems(8).Text
                OpcaoSaida = ListView2.Items(i).SubItems(9).Text

                'iniciando a impressão DAS ROWS LINHAS
                ' 'ID,Registro,Nome,Motivo,DataInicio,DataFim,Diferença,Status,OpcaoEntrada,OpcaoSaida
                PosiçãoDaLinha = MargemSuperior + (LinhaAtual * FonteNormal.GetHeight(e.Graphics)) ' definindo a posição da line no momento q ele esta imprimindo
                e.Graphics.DrawString(Id.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 0, PosiçãoDaLinha, New StringFormat())
                e.Graphics.DrawString(Registro.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 35, PosiçãoDaLinha, New StringFormat())
                e.Graphics.DrawString(Nome.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 115, PosiçãoDaLinha, New StringFormat())
                e.Graphics.DrawString(Motivo.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 260, PosiçãoDaLinha, New StringFormat())
                e.Graphics.DrawString(DataInicio.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 355, PosiçãoDaLinha, New StringFormat())
                e.Graphics.DrawString(DataFim.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 428, PosiçãoDaLinha, New StringFormat())
                e.Graphics.DrawString(Diferenca.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 505, PosiçãoDaLinha, New StringFormat())
                e.Graphics.DrawString(Status.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 526, PosiçãoDaLinha, New StringFormat())
                e.Graphics.DrawString(OpcaoEntrada.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 590, PosiçãoDaLinha, New StringFormat())
                e.Graphics.DrawString(OpcaoSaida.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 706, PosiçãoDaLinha, New StringFormat())


                'incremeta a linha atual
                LinhaAtual += 1
            Next
        End While


        'imprimir o rodapé
        e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, MargemInferior, MargemDireita, MargemInferior) 'inserindo a linha p o rodapé
        LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
        LinhaAtual += 1
        e.Graphics.DrawString("Página: " & PaginaAtual, FonteRodape, Brushes.Blue, MargemDireita - 70, MargemInferior, New StringFormat())
        e.Graphics.DrawString("                                               Report View from Marcos Ferreira to " & UsuarioLogado.UsuarioLogado & "  " & DateTime.Now, FonteRodape, Brushes.Black, MargemEsquerda + 80, MargemInferior + 1140, New StringFormat()) 'usando o draw string p escrever a data e hora, font e alinhamemto
        'verifica se continua imprimindo
        If (LinhaAtual > LinhasPorPaginas) Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If

    End Sub





    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Close()
    End Sub

    Private Item_Backup As New List(Of ListViewItem) 'LISTA DE LISTVIEW ITEMS 'S
    Private Async Sub FRMFiltroDatas_Load(sender As Object, e As EventArgs) Handles MyBase.Load






        DTPde.Visible = False
        DTPate.Visible = False
        Lbl_de.Visible = False
        Lbl_Ate.Visible = False
        TXTPESQUISAR.Visible = True

        Await Task.Delay(1000)
        CboFiltrarPor.SelectedItem = "Nº do Registro"

        LBLrotulo.Text = "Interna"
        Item_Backup.Clear()

        For Each item As ListViewItem In FrmGeral.ListView1.Items
            Item_Backup.Add(item)
        Next


        ListView2.Items.Clear() 'No evento load limpo antes de adicionar

        For Each item As ListViewItem In Item_Backup

            ListView2.Items.Add(item.Clone)
        Next

    End Sub



    Private Sub BtPesquisar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click

        If CboFiltrarPor.SelectedItem = "Nº do Registro" Then
            ListView2.Items.Clear()
            ListView2.BeginUpdate()
            Dim Cont As Integer = 0

            For Each item As ListViewItem In Item_Backup

                If (item.SubItems(1).Text.ToLowerInvariant = TXTPESQUISAR.Text.ToLowerInvariant AndAlso Not String.IsNullOrEmpty(TXTPESQUISAR.Text)) Then
                    ListView2.Items.Add(item.Clone)
                    Cont += 1
                End If


            Next
            I1.Notifyicone_PopupNotifier(vbCrLf & "             Foram encontrados " & Cont & " registro 's ", vbCrLf & vbCrLf & vbCrLf & "                    Consulta concluída!", 1100, BtBuscar)
            ListView2.EndUpdate() ' SO VAI DESENHAR NATELA OS ITEMS APOS O DESENHO SER SUSPENSO PELO BEGIN UPDATE
            Beep()


        ElseIf CboFiltrarPor.SelectedItem = "Status" AndAlso Not String.IsNullOrEmpty(TXTPESQUISAR.Text) Then
            Dim Cont As Integer = 0
            ListView2.Items.Clear()
            ListView2.BeginUpdate()

            For Each item As ListViewItem In Item_Backup
                If item.SubItems(7).Text = Trim(TXTPESQUISAR.Text) AndAlso Not String.IsNullOrEmpty(TXTPESQUISAR.Text) Then
                    Me.ListView2.Items.Add(item.Clone)
                    Cont += 1
                End If
            Next

            I1.Notifyicone_PopupNotifier(vbCrLf & "             Foram encontrados " & Cont & " registro 's ", vbCrLf & vbCrLf & vbCrLf & "                    Consulta concluída!", 1100, BtBuscar)
            ListView2.EndUpdate()


        ElseIf CboFiltrarPor.SelectedItem = "Nome" AndAlso Not String.IsNullOrEmpty(TXTPESQUISAR.Text) Then
            Dim Cont As Integer = 0
            ListView2.Items.Clear()
            ListView2.BeginUpdate()

            For Each item As ListViewItem In Item_Backup
                If item.SubItems(2).Text.ToLowerInvariant = Trim(TXTPESQUISAR.Text.ToLowerInvariant) AndAlso Not String.IsNullOrEmpty(TXTPESQUISAR.Text) Then
                    ListView2.Items.Add(item.Clone)
                    Cont += 1
                End If
            Next
            I1.Notifyicone_PopupNotifier(vbCrLf & "             Foram encontrados " & Cont & " registro 's ", vbCrLf & vbCrLf & vbCrLf & "                    Consulta concluída!", 1100, BtBuscar)
            ListView2.EndUpdate()




        ElseIf CboFiltrarPor.SelectedItem = "Data" Then

            If DTPde.Value > DTPate.Value Then
                I1.Notifyicone_PopupNotifier(vbCrLf & vbCrLf & "             Data do início deve ser menor que a data do fim para" & vbCrLf & "                                  uma filtragem correta! ", vbCrLf & "                                       Atenção!", 1300, BtBuscar)
                Exit Sub
            Else
                If DTPde.Value <= DTPate.Value Then

                    Dim Cont As Integer = 0
                    ListView2.Items.Clear()
                    ListView2.BeginUpdate()

                    For i As Integer = 0 To FrmGeral.ListView1.Items.Count - 1

                        If FrmGeral.ListView1.Items(i).SubItems(4).Text >= DTPde.Value.ToShortDateString AndAlso
                           FrmGeral.ListView1.Items(i).SubItems(4).Text <= DTPate.Value.ToShortDateString Then
                            Dim Lvi As ListViewItem = FrmGeral.ListView1.Items(i)

                            ListView2.Items.Add(Lvi.Clone)


                            Cont += 1
                        End If

                    Next
                    I1.Notifyicone_PopupNotifier(vbCrLf & "                     Foram contabilizados " & Cont & " Registros em " & "                     " & vbCrLf & "                         " &
                                                 DTPde.Value.ToString("dd/MM/yyyy") & "  até  " & DTPate.Value.ToString("dd/MM/yyyy"), vbCrLf & "                                     Atenção!  ", 1300, BtBuscar)

                    ListView2.EndUpdate()

                End If






            End If

        ElseIf CboFiltrarPor.SelectedItem = "Motivo" AndAlso Not String.IsNullOrEmpty(TXTPESQUISAR.Text) Then
            Dim Cont As Integer = 0
            ListView2.Items.Clear()
            ListView2.BeginUpdate()

            For Each item As ListViewItem In Item_Backup
                If item.SubItems(3).Text.ToLowerInvariant = Trim(TXTPESQUISAR.Text.ToLowerInvariant) AndAlso Not String.IsNullOrEmpty(TXTPESQUISAR.Text) Then
                    ListView2.Items.Add(item.Clone)
                    Cont += 1
                End If
            Next
            I1.Notifyicone_PopupNotifier(vbCrLf & "             Foram encontrados " & Cont & " registro 's ", vbCrLf & vbCrLf & vbCrLf & "                    Consulta concluída!", 1100, BtBuscar)
            ListView2.EndUpdate()


        End If
    End Sub


    'Try
    '    Dim Completar As AutoCompleteStringCollection = New AutoCompleteStringCollection
    '    Completar.Clear()

    '    For Each i As ListViewItem In FrmGeral.ListView1.Items
    '        Await Task.Delay(50)
    '        Completar.Add(i.SubItems(1).Text)
    '    Next

    '    TXTPESQUISAR.AutoCompleteCustomSource = Completar


    'Catch ex As Exception
    '    Dim P As Notifyicone_PopupNotifier = New Notifyicone_PopupNotifier
    '    P.Notifyicone_PopupNotifier("Detalhes da excepção: " & ex.Message, "Excepção encontrada", 700, TXTPESQUISAR)
    '    ex.Message.ToString()
    'End Try

    Private Async Sub TXTPESQUISAR_TextChanged(sender As Object, e As EventArgs) Handles TXTPESQUISAR.TextChanged



        Await Task.Delay(10)
        Me.TXTPESQUISAR.AutoCompleteCustomSource = AutoCompletar


        If Me.TXTPESQUISAR.Text = String.Empty Then

            ListView2.Items.Clear()

            For Each ITEM As ListViewItem In Item_Backup
                ListView2.Items.Add(ITEM.Clone)
            Next


        End If
    End Sub


    Private AutoCompletar As AutoCompleteStringCollection = New AutoCompleteStringCollection
    Private Sub CboFiltrarPor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboFiltrarPor.SelectedIndexChanged


        If CboFiltrarPor.SelectedItem = "Nº do Registro" Then
            TXTPESQUISAR.Visible = True
            DTPde.Visible = False
            DTPate.Visible = False
            Lbl_de.Visible = False
            Lbl_Ate.Visible = False

            LBLrotulo.Text = "dos Registros"
            AutoCompletar.Clear()


            'For o As Integer = 0 To ListView2.Items.Count - 1
            '    AutoCompletar.Add(ListView2.Items(o).SubItems(1).Text)
            'Next

            For Each o As ListViewItem In ListView2.Items
                AutoCompletar.Add(o.SubItems(1).Text)
            Next


        ElseIf CboFiltrarPor.SelectedItem = "Nome" Then
            TXTPESQUISAR.Visible = True
            DTPde.Visible = False
            DTPate.Visible = False
            Lbl_de.Visible = False
            Lbl_Ate.Visible = False

            LBLrotulo.Text = "dos Nomes"
            AutoCompletar.Clear()

            'For i As Integer = 0 To ListView2.Items.Count - 1
            '    AutoCompletar.Add(ListView2.Items(i).SubItems(2).Text)
            'Next

            For Each i As ListViewItem In ListView2.Items
                AutoCompletar.Add(i.SubItems(2).Text)
            Next


        ElseIf CboFiltrarPor.SelectedItem = "Status" Then
            TXTPESQUISAR.Visible = True
            DTPde.Visible = False
            DTPate.Visible = False
            Lbl_de.Visible = False
            Lbl_Ate.Visible = False

            LBLrotulo.Text = "dos Status"
            AutoCompletar.Clear()
            AutoCompletar.Add("Concluído")
            AutoCompletar.Add("Em aberto")


        ElseIf CboFiltrarPor.SelectedItem = "Data" Then

            DTPde.Visible = True
            DTPate.Visible = True
            Lbl_de.Visible = True
            Lbl_Ate.Visible = True
            LBLrotulo.Text = "das Data"
            TXTPESQUISAR.Visible = False

        ElseIf CboFiltrarPor.SelectedItem = "Motivo" Then
            TXTPESQUISAR.Visible = True
            DTPde.Visible = False
            DTPate.Visible = False
            Lbl_de.Visible = False
            Lbl_Ate.Visible = False

            LBLrotulo.Text = "por Motivo"
            AutoCompletar.Clear()

            'For o As Integer = 0 To ListView2.Items.Count - 1
            '    AutoCompletar.Add(ListView2.Items(o).SubItems(3).Text)
            'Next

            For Each B As ListViewItem In ListView2.Items
                AutoCompletar.Add(B.SubItems(3).Text)
            Next


        Else
            LBLrotulo.Text = "Interna"
            DTPde.Visible = False
            DTPate.Visible = False
            Lbl_de.Visible = False
            Lbl_Ate.Visible = False
            TXTPESQUISAR.Visible = True
        End If
    End Sub

    Private Sub TXTPESQUISAR_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTPESQUISAR.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtBuscar.PerformClick()
            TXTPESQUISAR.Focus()
        End If
    End Sub

    Private Sub FRMFiltroDatas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Alt And e.KeyCode = Keys.P Then
            BTImprimir.PerformClick()
        End If
    End Sub


    Private Sub BTImprimir_MouseEnter(sender As Object, e As EventArgs) Handles BTImprimir.MouseEnter
        Ajuda_Tooltip(Guna2HtmlToolTip1, BTImprimir, " Imprimir relatórios! Pode usar ALT+P como atalho.")

        With Guna2HtmlToolTip1

            .BackColor = Color.AliceBlue
            .ForeColor = Color.RoyalBlue
            .AutoPopDelay = 5000


        End With
    End Sub


    Private Sub BtPesquisar_MouseEnter(sender As Object, e As EventArgs) Handles BtBuscar.MouseEnter
        Ajuda_Tooltip(Guna2HtmlToolTip1, BtBuscar, " Pesquisar registros, relatórios com base em parâmetros Use ALT+B como atalho!")

        With Guna2HtmlToolTip1

            .BackColor = Color.AliceBlue
            .ForeColor = Color.RoyalBlue
            .AutoPopDelay = 5000


        End With
    End Sub



End Class