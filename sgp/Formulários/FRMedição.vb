Imports System.Drawing.Printing

Public Class FRM_edição

    Private WithEvents M_PrintDocument As PrintDocument

    Private Sub BtImprimir_para_Impressora_Click(sender As Object, e As EventArgs)

        M_PrintDocument = New PrintDocument
        M_PrintDocument.Print()

    End Sub

    Private Sub BtExibir_Visualizacao_da_Impresao_Click(sender As Object, e As EventArgs)

        'M_PrintDocument = New PrintDocument
        'PrintPreviewDialog1.Document = M_PrintDocument
        'PrintPreviewDialog1.ShowDialog()

    End Sub



    Private Sub Exibir_dialogos_de_Impressao_Click(sender As Object, e As EventArgs)
        'M_PrintDocument = New PrintDocument
        'PrintDialog1.Document = M_PrintDocument
        'PrintDialog1.ShowDialog()
    End Sub




    Private ListadeLviBackup As New List(Of ListViewItem)
    Private Sub FRM_edição_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListadeLviBackup.Clear()

        'ESTOU PEGANDO os items da listview1 e adicionando a uma lista separada
        For Each item As ListViewItem In FrmGeral.ListView1.Items
            ListadeLviBackup.Add(item)
        Next

        'p toda vez que carregar o formulário vou limpar primeiro e depois carregar-los
        ListView3.Items.Clear()

        For Each item As ListViewItem In ListadeLviBackup
            ListView3.Items.Add(item.Clone)
        Next

    End Sub

    Private Sub ListView3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView3.SelectedIndexChanged
        Try
            If ListView3.SelectedItems.Count > 0 Then
                TXTID.Text = ListView3.SelectedItems(0).SubItems(0).Text
                TXTREGISTRO.Text = ListView3.SelectedItems(0).SubItems(1).Text
                TXTNOME.Text = ListView3.SelectedItems(0).SubItems(2).Text
                CBOMOTIVO.Text = ListView3.SelectedItems(0).SubItems(3).Text
                DTINICIO.Value = ListView3.SelectedItems(0).SubItems(4).Text
                DTFIM.Value = ListView3.SelectedItems(0).SubItems(5).Text
                TXTDIFERENÇA.Text = ListView3.SelectedItems(0).SubItems(6).Text
                TXTSTATUS.Text = ListView3.SelectedItems(0).SubItems(7).Text
                TXTOPCAODEENTRADA.Text = ListView3.SelectedItems(0).SubItems(8).Text
                TXTOPCAOSAIDA.Text = ListView3.SelectedItems(0).SubItems(9).Text

                LBLDATAINICIOO.Text = ""
                LBLDATAFIMM.Text = ""
                LblResultado_Alterar.Text = ""

            End If
        Catch ex As Exception

        End Try


    End Sub



    Private Async Sub BTalterar_Click(sender As Object, e As EventArgs) Handles BTalterar.Click
        'Dim R As TimeSpan = CDate(LBLDATAFIMM.Text).Subtract(LBLDATAINICIOO.Text)

        If ListView3.SelectedItems.Count > 0 Then

            If MsgBox("Deseja fazer alteração neste item? ", MsgBoxStyle.YesNo, "Cuidado...") = DialogResult.Yes Then
                ListView3.SelectedItems(0).SubItems(0).Text = TXTID.Text
                ListView3.SelectedItems(0).SubItems(1).Text = TXTREGISTRO.Text
                ListView3.SelectedItems(0).SubItems(2).Text = TXTNOME.Text
                ListView3.SelectedItems(0).SubItems(3).Text = CBOMOTIVO.Text
                ListView3.SelectedItems(0).SubItems(4).Text = LBLDATAINICIOO.Text 'DTINICIO.Value.ToShortDateString
                ListView3.SelectedItems(0).SubItems(5).Text = LBLDATAFIMM.Text 'DTFIM.Value.ToShortDateString
                ListView3.SelectedItems(0).SubItems(6).Text = LblResultado_Alterar.Text 'R.TotalDays 'TXTDIFERENÇA.Text
                ListView3.SelectedItems(0).SubItems(7).Text = TXTSTATUS.Text
                ListView3.SelectedItems(0).SubItems(8).Text = TXTOPCAODEENTRADA.Text
                ListView3.SelectedItems(0).SubItems(9).Text = TXTOPCAOSAIDA.Text
                info5.Notifyicone_PopupNotifier(vbCrLf & "                         Alteração realizada com exito", "                                    Aviso", 1000, info5)

                'criar a rotina p alterar no listview 1 q é o principal

                FrmGeral.ListView1.Items.Clear()
                ListadeLviBackup.Clear()

                For Each item As ListViewItem In ListView3.Items
                    ListadeLviBackup.Add(item)
                Next

                For Each item As ListViewItem In ListadeLviBackup
                    FrmGeral.ListView1.Items.Add(item.Clone)
                Next
                Await Task.Delay(2000)

                SalvarDados.SalvarDadosLocalmenteListview_depoisnaNuvem(Application.StartupPath & "\BD\Reg.txt", FrmGeral.ListView1, BTalterar)
                LBLDATAINICIOO.Text = ""
                LBLDATAFIMM.Text = ""
                LblResultado_Alterar.Text = ""
            End If
        End If
    End Sub



    Private Sub TXTDIFERENÇA_TextChanged(sender As Object, e As EventArgs) Handles TXTDIFERENÇA.TextChanged

        Try
            Dim DTI As DateTime = LBLDATAINICIOO.Text    'DTINICIO.Value.ToString("dd/MM/yyyy")
            Dim DTF As DateTime = LBLDATAFIMM.Text     'DTFIM.Value.ToString("dd/MM/yyyy")
            Dim Result As TimeSpan = DTF.Subtract(DTI.ToString("dd/MM/yyyy"))    'DTF.Subtract(DTI.ToString("dd/MM/yyyy"))
            Text = Result.Days

        Catch ex As Exception

        End Try

    End Sub

    Private Sub DTINICIO_ValueChanged(sender As Object, e As EventArgs) Handles DTINICIO.ValueChanged
        'Dim DTI As DateTime = DTINICIO.Value.ToString("dd/MM/yyyy")
        'Dim DTF As DateTime = DTFIM.Value.ToString("dd/MM/yyyy")
        'Dim Result As TimeSpan = DTF.Subtract(DTI.ToString("dd/MM/yyyy"))
        'TXTDIFERENÇA.Text = Result.Days


    End Sub

    Private Sub DTFIM_ValueChanged(sender As Object, e As EventArgs) Handles DTFIM.ValueChanged
        'Dim DTI As DateTime = DTINICIO.Value.ToString("dd/MM/yyyy")
        'Dim DTF As DateTime = DTFIM.Value.ToString("dd/MM/yyyy")
        'Dim Result As TimeSpan = DTF.Subtract(DTI.ToString("dd/MM/yyyy"))
        'TXTDIFERENÇA.Text = Result.Days

    End Sub



    Private Async Sub TXTNOME_TextChanged(sender As Object, e As EventArgs) Handles TXTNOME.TextChanged

        Try
            Dim CompletarNome As New AutoCompleteStringCollection()
            CompletarNome.Clear()
            For i As Integer = 0 To ListView3.Items.Count - 1
                Await Task.Delay(300)
                CompletarNome.Add(ListView3.Items(i).SubItems(2).Text)
            Next
            TXTNOME.AutoCompleteCustomSource = CompletarNome
        Catch ex As Exception
            Dim P As Notifyicone_PopupNotifier = New Notifyicone_PopupNotifier
            P.Notifyicone_PopupNotifier("Detalhes da excepção: " & ex.Message, "Excepção encontrada", 700, TXTNOME)
            ex.Message.ToString()

        End Try


    End Sub

    Private Async Sub TXTREGISTRO_TextChanged(sender As Object, e As EventArgs) Handles TXTREGISTRO.TextChanged

        Dim Completar As AutoCompleteStringCollection = New AutoCompleteStringCollection

        Try

            Completar.Clear()
            For i As Integer = 0 To ListView3.Items.Count - 1
                Await Task.Delay(300)
                Completar.Add(ListView3.Items(i).SubItems(1).Text)

            Next
            TXTREGISTRO.AutoCompleteCustomSource = Completar
        Catch ex As Exception
            Dim P As Notifyicone_PopupNotifier = New Notifyicone_PopupNotifier
            P.Notifyicone_PopupNotifier("Detalhes da excepção: " & ex.Message, "Excepção encontrada", 700, TXTNOME)
            ex.Message.ToString()

        End Try
    End Sub


    Private Sub DTINICIO_CloseUp(sender As Object, e As EventArgs) Handles DTINICIO.CloseUp
        LBLDATAINICIOO.Text = DTINICIO.Value.ToString("dd/MM/yyyy")

    End Sub

    Private Sub DTFIM_CloseUp(sender As Object, e As EventArgs) Handles DTFIM.CloseUp

        LBLDATAFIMM.Text = DTFIM.Value.ToString("dd/MM/yyyy")

        If LBLDATAINICIOO.Text <> "" Then
            Dim A1 As DateTime = LBLDATAINICIOO.Text
            Dim A2 As DateTime = LBLDATAFIMM.Text
            Dim Result As TimeSpan = A2.Subtract(A1)
            LblResultado_Alterar.Text = Result.Days
        End If


    End Sub

    Private Sub BTDel_DataInicio_Click(sender As Object, e As EventArgs) Handles BTDel_DataInicio.Click
        LBLDATAINICIOO.Text = ""
    End Sub

    Private Sub BTDel_DataFim_Click(sender As Object, e As EventArgs) Handles BTDel_DataFim.Click
        LBLDATAFIMM.Text = ""
    End Sub

    Private Sub BTDel_DataInicio_MouseEnter(sender As Object, e As EventArgs) Handles BTDel_DataInicio.MouseEnter
        Ajuda.Ajuda_Tooltip(FrmGeral.Guna2HtmlToolTip1, BTDel_DataInicio, "[Limpar data de Início selecionada]")
        With FrmGeral.Guna2HtmlToolTip1
            .BackColor = Color.White
            .ForeColor = Color.RoyalBlue
            .AutoPopDelay = 10000
            .BorderColor = Color.Red
        End With
    End Sub

    Private Sub BTDel_DataFim_MouseEnter(sender As Object, e As EventArgs) Handles BTDel_DataFim.MouseEnter
        Ajuda.Ajuda_Tooltip(FrmGeral.Guna2HtmlToolTip1, BTDel_DataFim, "[Limpar data Fim selecionada]")
        With FrmGeral.Guna2HtmlToolTip1
            .BackColor = Color.White
            .ForeColor = Color.RoyalBlue
            .AutoPopDelay = 10000
            .BorderColor = Color.Red
        End With
    End Sub
End Class