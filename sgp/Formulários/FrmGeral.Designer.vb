Imports Guna.UI2.WinForms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGeral
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGeral))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Guna2HtmlToolTip1 = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.DTPFIM = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DTPINICIO = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.BTPESQUISAR = New System.Windows.Forms.PictureBox()
        Me.BTCARREGAR = New System.Windows.Forms.PictureBox()
        Me.BTEDIT = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerProgresbar = New System.Windows.Forms.Timer(Me.components)
        Me.PainelContainer_de_Frms_Filhos = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Registro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Motivo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DataInicio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DataFim = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Diferenca = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OpçãoEntrada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OpçãoSaída = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.ProgressBar1 = New Guna.UI.WinForms.GunaCircleProgressBar()
        Me.Lblaguarde = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BTlimparCampos = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.LBLDATAFIM = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LBLDATAINICIO = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LblNome_ = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LblReg_ = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LblId_ = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BTLIMPARDATAFIM = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTLIMPARDATAINICIO = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.TXTNOME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTREGISTRO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblMotivo_ = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.CBOMOTIVO = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LblQuantidadeFRMGeral = New Guna.UI.WinForms.GunaLabel()
        Me.Barra_de_TituloBunifuGradientPanel = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BTNminimizar = New System.Windows.Forms.PictureBox()
        Me.BTNMaximizar = New System.Windows.Forms.PictureBox()
        Me.VitalPintureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.LblRede = New Guna.UI.WinForms.GunaLabel()
        Me.LblConetado = New Guna.UI.WinForms.GunaLabel()
        Me.MenuVertical_BunifuGradientPanel = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BTVolume = New System.Windows.Forms.PictureBox()
        Me.BTSalvar = New System.Windows.Forms.PictureBox()
        Me.BTEXCLUIR = New System.Windows.Forms.PictureBox()
        Me.BTADD = New System.Windows.Forms.PictureBox()
        CType(Me.BTPESQUISAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTCARREGAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTEDIT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PainelContainer_de_Frms_Filhos.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        Me.ProgressBar1.SuspendLayout()
        Me.Barra_de_TituloBunifuGradientPanel.SuspendLayout()
        CType(Me.BTNminimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VitalPintureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuVertical_BunifuGradientPanel.SuspendLayout()
        CType(Me.BTVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTSalvar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTEXCLUIR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTADD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "blue_01.ico")
        Me.ImageList1.Images.SetKeyName(1, "CQG.ICO")
        Me.ImageList1.Images.SetKeyName(2, "edit_user.ico")
        '
        'Guna2HtmlToolTip1
        '
        Me.Guna2HtmlToolTip1.AllowLinksHandling = True
        Me.Guna2HtmlToolTip1.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'DTPFIM
        '
        Me.DTPFIM.Animated = True
        Me.DTPFIM.AutoRoundedCorners = True
        Me.DTPFIM.BackColor = System.Drawing.Color.Transparent
        Me.DTPFIM.BorderColor = System.Drawing.Color.RoyalBlue
        Me.DTPFIM.BorderRadius = 18
        Me.DTPFIM.BorderThickness = 1
        Me.DTPFIM.CheckedState.Parent = Me.DTPFIM
        Me.DTPFIM.FillColor = System.Drawing.Color.WhiteSmoke
        Me.DTPFIM.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFIM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DTPFIM.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFIM.HoverState.BorderColor = System.Drawing.Color.Black
        Me.DTPFIM.HoverState.FillColor = System.Drawing.Color.White
        Me.DTPFIM.HoverState.ForeColor = System.Drawing.Color.SeaGreen
        Me.DTPFIM.HoverState.Parent = Me.DTPFIM
        Me.DTPFIM.Location = New System.Drawing.Point(295, 217)
        Me.DTPFIM.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTPFIM.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTPFIM.Name = "DTPFIM"
        Me.DTPFIM.ShadowDecoration.BorderRadius = 8
        Me.DTPFIM.ShadowDecoration.Color = System.Drawing.Color.LimeGreen
        Me.DTPFIM.ShadowDecoration.Depth = 10
        Me.DTPFIM.ShadowDecoration.Enabled = True
        Me.DTPFIM.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.DTPFIM.ShadowDecoration.Parent = Me.DTPFIM
        Me.DTPFIM.Size = New System.Drawing.Size(299, 38)
        Me.DTPFIM.TabIndex = 5
        Me.Guna2HtmlToolTip1.SetToolTip(Me.DTPFIM, "Insira a data de fim")
        Me.DTPFIM.UseTransparentBackground = True
        Me.DTPFIM.Value = New Date(2020, 7, 2, 23, 17, 42, 439)
        '
        'DTPINICIO
        '
        Me.DTPINICIO.Animated = True
        Me.DTPINICIO.AutoRoundedCorners = True
        Me.DTPINICIO.BackColor = System.Drawing.Color.Transparent
        Me.DTPINICIO.BorderColor = System.Drawing.Color.RoyalBlue
        Me.DTPINICIO.BorderRadius = 18
        Me.DTPINICIO.BorderThickness = 1
        Me.DTPINICIO.CheckedState.Parent = Me.DTPINICIO
        Me.DTPINICIO.FillColor = System.Drawing.Color.WhiteSmoke
        Me.DTPINICIO.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPINICIO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DTPINICIO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPINICIO.HoverState.BorderColor = System.Drawing.Color.Black
        Me.DTPINICIO.HoverState.FillColor = System.Drawing.Color.White
        Me.DTPINICIO.HoverState.ForeColor = System.Drawing.Color.SeaGreen
        Me.DTPINICIO.HoverState.Parent = Me.DTPINICIO
        Me.DTPINICIO.Location = New System.Drawing.Point(7, 217)
        Me.DTPINICIO.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTPINICIO.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTPINICIO.Name = "DTPINICIO"
        Me.DTPINICIO.ShadowDecoration.BorderRadius = 8
        Me.DTPINICIO.ShadowDecoration.Color = System.Drawing.Color.LimeGreen
        Me.DTPINICIO.ShadowDecoration.Depth = 10
        Me.DTPINICIO.ShadowDecoration.Enabled = True
        Me.DTPINICIO.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.DTPINICIO.ShadowDecoration.Parent = Me.DTPINICIO
        Me.DTPINICIO.Size = New System.Drawing.Size(278, 38)
        Me.DTPINICIO.TabIndex = 4
        Me.Guna2HtmlToolTip1.SetToolTip(Me.DTPINICIO, "Insira a data de início")
        Me.DTPINICIO.UseTransparentBackground = True
        Me.DTPINICIO.Value = New Date(2020, 7, 2, 23, 33, 31, 13)
        '
        'BTPESQUISAR
        '
        Me.BTPESQUISAR.BackColor = System.Drawing.Color.Transparent
        Me.BTPESQUISAR.Image = Global.Develop_SGP.My.Resources.Resources.file_document_paper_blue_g14989
        Me.BTPESQUISAR.Location = New System.Drawing.Point(8, 269)
        Me.BTPESQUISAR.Name = "BTPESQUISAR"
        Me.BTPESQUISAR.Size = New System.Drawing.Size(32, 42)
        Me.BTPESQUISAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BTPESQUISAR.TabIndex = 1
        Me.BTPESQUISAR.TabStop = False
        Me.Guna2HtmlToolTip1.SetToolTip(Me.BTPESQUISAR, "Filtrar em lista determinada data para visualização de relatório")
        '
        'BTCARREGAR
        '
        Me.BTCARREGAR.BackColor = System.Drawing.Color.Transparent
        Me.BTCARREGAR.Image = Global.Develop_SGP.My.Resources.Resources.database
        Me.BTCARREGAR.Location = New System.Drawing.Point(8, 199)
        Me.BTCARREGAR.Name = "BTCARREGAR"
        Me.BTCARREGAR.Size = New System.Drawing.Size(32, 42)
        Me.BTCARREGAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BTCARREGAR.TabIndex = 1
        Me.BTCARREGAR.TabStop = False
        Me.Guna2HtmlToolTip1.SetToolTip(Me.BTCARREGAR, "Carregar banco de dados")
        '
        'BTEDIT
        '
        Me.BTEDIT.BackColor = System.Drawing.Color.Transparent
        Me.BTEDIT.Image = Global.Develop_SGP.My.Resources.Resources.lapiz_azul
        Me.BTEDIT.Location = New System.Drawing.Point(8, 69)
        Me.BTEDIT.Name = "BTEDIT"
        Me.BTEDIT.Size = New System.Drawing.Size(32, 42)
        Me.BTEDIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BTEDIT.TabIndex = 1
        Me.BTEDIT.TabStop = False
        Me.Guna2HtmlToolTip1.SetToolTip(Me.BTEDIT, "Editar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 5000
        '
        'TimerProgresbar
        '
        Me.TimerProgresbar.Enabled = True
        Me.TimerProgresbar.Interval = 300
        '
        'PainelContainer_de_Frms_Filhos
        '
        Me.PainelContainer_de_Frms_Filhos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PainelContainer_de_Frms_Filhos.BackgroundImage = CType(resources.GetObject("PainelContainer_de_Frms_Filhos.BackgroundImage"), System.Drawing.Image)
        Me.PainelContainer_de_Frms_Filhos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PainelContainer_de_Frms_Filhos.Controls.Add(Me.ListView1)
        Me.PainelContainer_de_Frms_Filhos.Controls.Add(Me.BunifuCards1)
        Me.PainelContainer_de_Frms_Filhos.Controls.Add(Me.LblQuantidadeFRMGeral)
        Me.PainelContainer_de_Frms_Filhos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PainelContainer_de_Frms_Filhos.GradientBottomLeft = System.Drawing.Color.SeaShell
        Me.PainelContainer_de_Frms_Filhos.GradientBottomRight = System.Drawing.SystemColors.Menu
        Me.PainelContainer_de_Frms_Filhos.GradientTopLeft = System.Drawing.Color.WhiteSmoke
        Me.PainelContainer_de_Frms_Filhos.GradientTopRight = System.Drawing.Color.DeepSkyBlue
        Me.PainelContainer_de_Frms_Filhos.Location = New System.Drawing.Point(47, 68)
        Me.PainelContainer_de_Frms_Filhos.Name = "PainelContainer_de_Frms_Filhos"
        Me.PainelContainer_de_Frms_Filhos.Quality = 10
        Me.PainelContainer_de_Frms_Filhos.Size = New System.Drawing.Size(1273, 619)
        Me.PainelContainer_de_Frms_Filhos.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BackColor = System.Drawing.Color.PowderBlue
        Me.ListView1.BackgroundImageTiled = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Id, Me.Registro, Me.Nome, Me.Motivo, Me.DataInicio, Me.DataFim, Me.Diferenca, Me.Status, Me.OpçãoEntrada, Me.OpçãoSaída})
        Me.ListView1.Font = New System.Drawing.Font("Dubai", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.DimGray
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(2, 307)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1273, 308)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Id
        '
        Me.Id.Text = "Id"
        '
        'Registro
        '
        Me.Registro.Text = "N° Registro"
        Me.Registro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Registro.Width = 123
        '
        'Nome
        '
        Me.Nome.Text = "Nome"
        Me.Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Nome.Width = 182
        '
        'Motivo
        '
        Me.Motivo.Text = "Motivo"
        Me.Motivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Motivo.Width = 160
        '
        'DataInicio
        '
        Me.DataInicio.Text = "Data Inicio"
        Me.DataInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataInicio.Width = 110
        '
        'DataFim
        '
        Me.DataFim.Text = "Data Fim"
        Me.DataFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataFim.Width = 110
        '
        'Diferenca
        '
        Me.Diferenca.Text = "Dif em dias"
        Me.Diferenca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Diferenca.Width = 78
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Status.Width = 126
        '
        'OpçãoEntrada
        '
        Me.OpçãoEntrada.Text = "Opção de Entrada"
        Me.OpçãoEntrada.Width = 150
        '
        'OpçãoSaída
        '
        Me.OpçãoSaída.Text = "Opção de saída"
        Me.OpçãoSaída.Width = 230
        '
        'BunifuCards1
        '
        Me.BunifuCards1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCards1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.RoyalBlue
        Me.BunifuCards1.Controls.Add(Me.ProgressBar1)
        Me.BunifuCards1.Controls.Add(Me.BTlimparCampos)
        Me.BunifuCards1.Controls.Add(Me.LBLDATAFIM)
        Me.BunifuCards1.Controls.Add(Me.BunifuCustomLabel2)
        Me.BunifuCards1.Controls.Add(Me.LBLDATAINICIO)
        Me.BunifuCards1.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuCards1.Controls.Add(Me.LblNome_)
        Me.BunifuCards1.Controls.Add(Me.LblReg_)
        Me.BunifuCards1.Controls.Add(Me.LblId_)
        Me.BunifuCards1.Controls.Add(Me.BTLIMPARDATAFIM)
        Me.BunifuCards1.Controls.Add(Me.BTLIMPARDATAINICIO)
        Me.BunifuCards1.Controls.Add(Me.TXTNOME)
        Me.BunifuCards1.Controls.Add(Me.TXTREGISTRO)
        Me.BunifuCards1.Controls.Add(Me.TXTID)
        Me.BunifuCards1.Controls.Add(Me.DTPFIM)
        Me.BunifuCards1.Controls.Add(Me.DTPINICIO)
        Me.BunifuCards1.Controls.Add(Me.LblMotivo_)
        Me.BunifuCards1.Controls.Add(Me.CBOMOTIVO)
        Me.BunifuCards1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(1273, 283)
        Me.BunifuCards1.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Animated = True
        Me.ProgressBar1.AnimationSpeed = 0.1!
        Me.ProgressBar1.BaseColor = System.Drawing.Color.Lavender
        Me.ProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.Transition
        Me.ProgressBar1.Controls.Add(Me.Lblaguarde)
        Me.ProgressBar1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.ProgressBar1.IdleColor = System.Drawing.SystemColors.ActiveCaption
        Me.ProgressBar1.IdleOffset = 20
        Me.ProgressBar1.Image = Nothing
        Me.ProgressBar1.ImageSize = New System.Drawing.Size(50, 50)
        Me.ProgressBar1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ProgressBar1.LineEndCap = System.Drawing.Drawing2D.LineCap.AnchorMask
        Me.ProgressBar1.LineStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.ProgressBar1.Location = New System.Drawing.Point(971, 57)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.ProgressMaxColor = System.Drawing.Color.Green
        Me.ProgressBar1.ProgressMinColor = System.Drawing.Color.SaddleBrown
        Me.ProgressBar1.ProgressOffset = 20
        Me.ProgressBar1.ProgressThickness = 24
        Me.ProgressBar1.Size = New System.Drawing.Size(290, 187)
        Me.ProgressBar1.TabIndex = 12
        Me.ProgressBar1.Value = 1
        '
        'Lblaguarde
        '
        Me.Lblaguarde.AutoSize = True
        Me.Lblaguarde.Location = New System.Drawing.Point(60, 86)
        Me.Lblaguarde.Name = "Lblaguarde"
        Me.Lblaguarde.Size = New System.Drawing.Size(66, 19)
        Me.Lblaguarde.TabIndex = 13
        Me.Lblaguarde.Text = "Aguarde"
        '
        'BTlimparCampos
        '
        Me.BTlimparCampos.BorderRadius = 7
        Me.BTlimparCampos.CheckedState.Parent = Me.BTlimparCampos
        Me.BTlimparCampos.CustomImages.Parent = Me.BTlimparCampos
        Me.BTlimparCampos.FillColor2 = System.Drawing.Color.Silver
        Me.BTlimparCampos.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTlimparCampos.ForeColor = System.Drawing.Color.White
        Me.BTlimparCampos.HoverState.Parent = Me.BTlimparCampos
        Me.BTlimparCampos.Location = New System.Drawing.Point(604, 223)
        Me.BTlimparCampos.Name = "BTlimparCampos"
        Me.BTlimparCampos.ShadowDecoration.Parent = Me.BTlimparCampos
        Me.BTlimparCampos.Size = New System.Drawing.Size(104, 32)
        Me.BTlimparCampos.TabIndex = 8
        Me.BTlimparCampos.Text = "Limpar"
        '
        'LBLDATAFIM
        '
        Me.LBLDATAFIM.AutoSize = True
        Me.LBLDATAFIM.BackColor = System.Drawing.Color.Transparent
        Me.LBLDATAFIM.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDATAFIM.ForeColor = System.Drawing.Color.SeaGreen
        Me.LBLDATAFIM.Location = New System.Drawing.Point(384, 195)
        Me.LBLDATAFIM.Name = "LBLDATAFIM"
        Me.LBLDATAFIM.Size = New System.Drawing.Size(0, 19)
        Me.LBLDATAFIM.TabIndex = 11
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoEllipsis = True
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(305, 197)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(70, 19)
        Me.BunifuCustomLabel2.TabIndex = 8
        Me.BunifuCustomLabel2.Text = "Data Fim"
        '
        'LBLDATAINICIO
        '
        Me.LBLDATAINICIO.AutoSize = True
        Me.LBLDATAINICIO.BackColor = System.Drawing.Color.Transparent
        Me.LBLDATAINICIO.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDATAINICIO.ForeColor = System.Drawing.Color.SeaGreen
        Me.LBLDATAINICIO.Location = New System.Drawing.Point(129, 196)
        Me.LBLDATAINICIO.Name = "LBLDATAINICIO"
        Me.LBLDATAINICIO.Size = New System.Drawing.Size(0, 19)
        Me.LBLDATAINICIO.TabIndex = 10
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(19, 198)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(101, 19)
        Me.BunifuCustomLabel1.TabIndex = 9
        Me.BunifuCustomLabel1.Text = "Data de Início"
        '
        'LblNome_
        '
        Me.LblNome_.AutoSize = True
        Me.LblNome_.BackColor = System.Drawing.Color.Transparent
        Me.LblNome_.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNome_.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblNome_.ImageList = Me.ImageList1
        Me.LblNome_.Location = New System.Drawing.Point(22, 118)
        Me.LblNome_.Name = "LblNome_"
        Me.LblNome_.Size = New System.Drawing.Size(50, 19)
        Me.LblNome_.TabIndex = 6
        Me.LblNome_.Text = "Nome"
        '
        'LblReg_
        '
        Me.LblReg_.AutoSize = True
        Me.LblReg_.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblReg_.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReg_.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblReg_.Location = New System.Drawing.Point(20, 71)
        Me.LblReg_.Name = "LblReg_"
        Me.LblReg_.Size = New System.Drawing.Size(35, 19)
        Me.LblReg_.TabIndex = 5
        Me.LblReg_.Text = "Reg"
        '
        'LblId_
        '
        Me.LblId_.AutoSize = True
        Me.LblId_.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblId_.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblId_.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblId_.Location = New System.Drawing.Point(19, 30)
        Me.LblId_.Name = "LblId_"
        Me.LblId_.Size = New System.Drawing.Size(22, 19)
        Me.LblId_.TabIndex = 5
        Me.LblId_.Text = "Id"
        '
        'BTLIMPARDATAFIM
        '
        Me.BTLIMPARDATAFIM.Animated = True
        Me.BTLIMPARDATAFIM.BackColor = System.Drawing.Color.Transparent
        Me.BTLIMPARDATAFIM.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BTLIMPARDATAFIM.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton
        Me.BTLIMPARDATAFIM.CheckedState.Parent = Me.BTLIMPARDATAFIM
        Me.BTLIMPARDATAFIM.CustomBorderColor = System.Drawing.Color.Transparent
        Me.BTLIMPARDATAFIM.CustomImages.Parent = Me.BTLIMPARDATAFIM
        Me.BTLIMPARDATAFIM.FillColor = System.Drawing.Color.DarkGray
        Me.BTLIMPARDATAFIM.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.BTLIMPARDATAFIM.ForeColor = System.Drawing.Color.White
        Me.BTLIMPARDATAFIM.HoverState.BorderColor = System.Drawing.Color.Lime
        Me.BTLIMPARDATAFIM.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTLIMPARDATAFIM.HoverState.ForeColor = System.Drawing.Color.White
        Me.BTLIMPARDATAFIM.HoverState.Parent = Me.BTLIMPARDATAFIM
        Me.BTLIMPARDATAFIM.IndicateFocus = True
        Me.BTLIMPARDATAFIM.Location = New System.Drawing.Point(567, 198)
        Me.BTLIMPARDATAFIM.Name = "BTLIMPARDATAFIM"
        Me.BTLIMPARDATAFIM.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTLIMPARDATAFIM.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTLIMPARDATAFIM.ShadowDecoration.Parent = Me.BTLIMPARDATAFIM
        Me.BTLIMPARDATAFIM.Size = New System.Drawing.Size(26, 19)
        Me.BTLIMPARDATAFIM.TabIndex = 7
        Me.BTLIMPARDATAFIM.Text = "e"
        Me.BTLIMPARDATAFIM.UseTransparentBackground = True
        '
        'BTLIMPARDATAINICIO
        '
        Me.BTLIMPARDATAINICIO.Animated = True
        Me.BTLIMPARDATAINICIO.BackColor = System.Drawing.Color.Transparent
        Me.BTLIMPARDATAINICIO.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BTLIMPARDATAINICIO.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton
        Me.BTLIMPARDATAINICIO.CheckedState.Parent = Me.BTLIMPARDATAINICIO
        Me.BTLIMPARDATAINICIO.CustomBorderColor = System.Drawing.Color.Transparent
        Me.BTLIMPARDATAINICIO.CustomImages.Parent = Me.BTLIMPARDATAINICIO
        Me.BTLIMPARDATAINICIO.FillColor = System.Drawing.Color.DarkGray
        Me.BTLIMPARDATAINICIO.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.BTLIMPARDATAINICIO.ForeColor = System.Drawing.Color.White
        Me.BTLIMPARDATAINICIO.HoverState.BorderColor = System.Drawing.Color.Lime
        Me.BTLIMPARDATAINICIO.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTLIMPARDATAINICIO.HoverState.ForeColor = System.Drawing.Color.White
        Me.BTLIMPARDATAINICIO.HoverState.Parent = Me.BTLIMPARDATAINICIO
        Me.BTLIMPARDATAINICIO.IndicateFocus = True
        Me.BTLIMPARDATAINICIO.Location = New System.Drawing.Point(262, 198)
        Me.BTLIMPARDATAINICIO.Name = "BTLIMPARDATAINICIO"
        Me.BTLIMPARDATAINICIO.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTLIMPARDATAINICIO.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTLIMPARDATAINICIO.ShadowDecoration.Parent = Me.BTLIMPARDATAINICIO
        Me.BTLIMPARDATAINICIO.Size = New System.Drawing.Size(26, 19)
        Me.BTLIMPARDATAINICIO.TabIndex = 6
        Me.BTLIMPARDATAINICIO.Text = "e"
        Me.BTLIMPARDATAINICIO.UseTransparentBackground = True
        '
        'TXTNOME
        '
        Me.TXTNOME.Animated = True
        Me.TXTNOME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXTNOME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TXTNOME.AutoRoundedCorners = True
        Me.TXTNOME.AutoScroll = True
        Me.TXTNOME.BorderColor = System.Drawing.Color.RoyalBlue
        Me.TXTNOME.BorderRadius = 17
        Me.TXTNOME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTNOME.DefaultText = ""
        Me.TXTNOME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTNOME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTNOME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTNOME.DisabledState.Parent = Me.TXTNOME
        Me.TXTNOME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTNOME.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TXTNOME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTNOME.FocusedState.Parent = Me.TXTNOME
        Me.TXTNOME.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOME.HideSelection = False
        Me.TXTNOME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTNOME.HoverState.Parent = Me.TXTNOME
        Me.TXTNOME.Location = New System.Drawing.Point(7, 111)
        Me.TXTNOME.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTNOME.Name = "TXTNOME"
        Me.TXTNOME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTNOME.PlaceholderText = ""
        Me.TXTNOME.SelectedText = ""
        Me.TXTNOME.ShadowDecoration.Parent = Me.TXTNOME
        Me.TXTNOME.Size = New System.Drawing.Size(350, 36)
        Me.TXTNOME.TabIndex = 2
        Me.TXTNOME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTREGISTRO
        '
        Me.TXTREGISTRO.Animated = True
        Me.TXTREGISTRO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TXTREGISTRO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TXTREGISTRO.AutoRoundedCorners = True
        Me.TXTREGISTRO.BorderColor = System.Drawing.Color.RoyalBlue
        Me.TXTREGISTRO.BorderRadius = 17
        Me.TXTREGISTRO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTREGISTRO.DefaultText = ""
        Me.TXTREGISTRO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTREGISTRO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTREGISTRO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTREGISTRO.DisabledState.Parent = Me.TXTREGISTRO
        Me.TXTREGISTRO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTREGISTRO.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TXTREGISTRO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTREGISTRO.FocusedState.Parent = Me.TXTREGISTRO
        Me.TXTREGISTRO.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTREGISTRO.HideSelection = False
        Me.TXTREGISTRO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTREGISTRO.HoverState.Parent = Me.TXTREGISTRO
        Me.TXTREGISTRO.Location = New System.Drawing.Point(7, 67)
        Me.TXTREGISTRO.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXTREGISTRO.Name = "TXTREGISTRO"
        Me.TXTREGISTRO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTREGISTRO.PlaceholderText = ""
        Me.TXTREGISTRO.SelectedText = ""
        Me.TXTREGISTRO.ShadowDecoration.Parent = Me.TXTREGISTRO
        Me.TXTREGISTRO.Size = New System.Drawing.Size(261, 36)
        Me.TXTREGISTRO.TabIndex = 1
        Me.TXTREGISTRO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTID
        '
        Me.TXTID.Animated = True
        Me.TXTID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXTID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TXTID.AutoRoundedCorners = True
        Me.TXTID.BackColor = System.Drawing.Color.Transparent
        Me.TXTID.BorderColor = System.Drawing.Color.RoyalBlue
        Me.TXTID.BorderRadius = 17
        Me.TXTID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTID.DefaultText = ""
        Me.TXTID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTID.DisabledState.Parent = Me.TXTID
        Me.TXTID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTID.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TXTID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTID.FocusedState.Parent = Me.TXTID
        Me.TXTID.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTID.HideSelection = False
        Me.TXTID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTID.HoverState.Parent = Me.TXTID
        Me.TXTID.Location = New System.Drawing.Point(7, 25)
        Me.TXTID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXTID.Name = "TXTID"
        Me.TXTID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTID.PlaceholderText = ""
        Me.TXTID.SelectedText = ""
        Me.TXTID.ShadowDecoration.Parent = Me.TXTID
        Me.TXTID.Size = New System.Drawing.Size(167, 36)
        Me.TXTID.TabIndex = 0
        Me.TXTID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblMotivo_
        '
        Me.LblMotivo_.AutoSize = True
        Me.LblMotivo_.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblMotivo_.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMotivo_.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblMotivo_.Location = New System.Drawing.Point(21, 161)
        Me.LblMotivo_.Name = "LblMotivo_"
        Me.LblMotivo_.Size = New System.Drawing.Size(57, 19)
        Me.LblMotivo_.TabIndex = 8
        Me.LblMotivo_.Text = "Motivo"
        '
        'CBOMOTIVO
        '
        Me.CBOMOTIVO.Animated = True
        Me.CBOMOTIVO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CBOMOTIVO.AutoRoundedCorners = True
        Me.CBOMOTIVO.BackColor = System.Drawing.Color.Transparent
        Me.CBOMOTIVO.BorderColor = System.Drawing.Color.RoyalBlue
        Me.CBOMOTIVO.BorderRadius = 17
        Me.CBOMOTIVO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBOMOTIVO.DropDownHeight = 108
        Me.CBOMOTIVO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOMOTIVO.DropDownWidth = 530
        Me.CBOMOTIVO.FillColor = System.Drawing.Color.WhiteSmoke
        Me.CBOMOTIVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBOMOTIVO.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBOMOTIVO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBOMOTIVO.FocusedState.FillColor = System.Drawing.Color.AliceBlue
        Me.CBOMOTIVO.FocusedState.ForeColor = System.Drawing.Color.SeaGreen
        Me.CBOMOTIVO.FocusedState.Parent = Me.CBOMOTIVO
        Me.CBOMOTIVO.Font = New System.Drawing.Font("Corbel", 11.25!)
        Me.CBOMOTIVO.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CBOMOTIVO.HoverState.FillColor = System.Drawing.Color.White
        Me.CBOMOTIVO.HoverState.Parent = Me.CBOMOTIVO
        Me.CBOMOTIVO.IntegralHeight = False
        Me.CBOMOTIVO.ItemHeight = 30
        Me.CBOMOTIVO.Items.AddRange(New Object() {"Atestado", "Suspensão ", "Advertência", "Falta não Justif", "Férias"})
        Me.CBOMOTIVO.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBOMOTIVO.ItemsAppearance.Parent = Me.CBOMOTIVO
        Me.CBOMOTIVO.ItemsAppearance.SelectedBackColor = System.Drawing.Color.White
        Me.CBOMOTIVO.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBOMOTIVO.Location = New System.Drawing.Point(7, 154)
        Me.CBOMOTIVO.Name = "CBOMOTIVO"
        Me.CBOMOTIVO.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CBOMOTIVO.ShadowDecoration.Parent = Me.CBOMOTIVO
        Me.CBOMOTIVO.Size = New System.Drawing.Size(518, 36)
        Me.CBOMOTIVO.TabIndex = 3
        Me.CBOMOTIVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblQuantidadeFRMGeral
        '
        Me.LblQuantidadeFRMGeral.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblQuantidadeFRMGeral.AutoSize = True
        Me.LblQuantidadeFRMGeral.BackColor = System.Drawing.Color.Transparent
        Me.LblQuantidadeFRMGeral.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblQuantidadeFRMGeral.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblQuantidadeFRMGeral.Location = New System.Drawing.Point(1103, 290)
        Me.LblQuantidadeFRMGeral.Name = "LblQuantidadeFRMGeral"
        Me.LblQuantidadeFRMGeral.Size = New System.Drawing.Size(136, 15)
        Me.LblQuantidadeFRMGeral.TabIndex = 11
        Me.LblQuantidadeFRMGeral.Text = "Quantidade de Registros"
        '
        'Barra_de_TituloBunifuGradientPanel
        '
        Me.Barra_de_TituloBunifuGradientPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Barra_de_TituloBunifuGradientPanel.BackgroundImage = CType(resources.GetObject("Barra_de_TituloBunifuGradientPanel.BackgroundImage"), System.Drawing.Image)
        Me.Barra_de_TituloBunifuGradientPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Barra_de_TituloBunifuGradientPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Barra_de_TituloBunifuGradientPanel.Controls.Add(Me.BTNminimizar)
        Me.Barra_de_TituloBunifuGradientPanel.Controls.Add(Me.BTNMaximizar)
        Me.Barra_de_TituloBunifuGradientPanel.Controls.Add(Me.VitalPintureBoxLogo)
        Me.Barra_de_TituloBunifuGradientPanel.Controls.Add(Me.LblRede)
        Me.Barra_de_TituloBunifuGradientPanel.Controls.Add(Me.LblConetado)
        Me.Barra_de_TituloBunifuGradientPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Barra_de_TituloBunifuGradientPanel.GradientBottomLeft = System.Drawing.Color.Navy
        Me.Barra_de_TituloBunifuGradientPanel.GradientBottomRight = System.Drawing.SystemColors.Menu
        Me.Barra_de_TituloBunifuGradientPanel.GradientTopLeft = System.Drawing.Color.WhiteSmoke
        Me.Barra_de_TituloBunifuGradientPanel.GradientTopRight = System.Drawing.Color.DeepSkyBlue
        Me.Barra_de_TituloBunifuGradientPanel.Location = New System.Drawing.Point(47, 0)
        Me.Barra_de_TituloBunifuGradientPanel.Name = "Barra_de_TituloBunifuGradientPanel"
        Me.Barra_de_TituloBunifuGradientPanel.Quality = 10
        Me.Barra_de_TituloBunifuGradientPanel.Size = New System.Drawing.Size(1273, 68)
        Me.Barra_de_TituloBunifuGradientPanel.TabIndex = 1
        '
        'BTNminimizar
        '
        Me.BTNminimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNminimizar.BackColor = System.Drawing.Color.Transparent
        Me.BTNminimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNminimizar.Image = Global.Develop_SGP.My.Resources.Resources.minimize1
        Me.BTNminimizar.InitialImage = Nothing
        Me.BTNminimizar.Location = New System.Drawing.Point(1126, 18)
        Me.BTNminimizar.Name = "BTNminimizar"
        Me.BTNminimizar.Size = New System.Drawing.Size(67, 30)
        Me.BTNminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BTNminimizar.TabIndex = 1
        Me.BTNminimizar.TabStop = False
        '
        'BTNMaximizar
        '
        Me.BTNMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNMaximizar.BackColor = System.Drawing.Color.Transparent
        Me.BTNMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNMaximizar.Image = Global.Develop_SGP.My.Resources.Resources.button_blue_stop
        Me.BTNMaximizar.Location = New System.Drawing.Point(1193, 18)
        Me.BTNMaximizar.Name = "BTNMaximizar"
        Me.BTNMaximizar.Size = New System.Drawing.Size(67, 30)
        Me.BTNMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BTNMaximizar.TabIndex = 1
        Me.BTNMaximizar.TabStop = False
        '
        'VitalPintureBoxLogo
        '
        Me.VitalPintureBoxLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VitalPintureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.VitalPintureBoxLogo.Image = Global.Develop_SGP.My.Resources.Resources.Vital
        Me.VitalPintureBoxLogo.Location = New System.Drawing.Point(586, 7)
        Me.VitalPintureBoxLogo.Name = "VitalPintureBoxLogo"
        Me.VitalPintureBoxLogo.Size = New System.Drawing.Size(121, 56)
        Me.VitalPintureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.VitalPintureBoxLogo.TabIndex = 0
        Me.VitalPintureBoxLogo.TabStop = False
        '
        'LblRede
        '
        Me.LblRede.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblRede.AutoSize = True
        Me.LblRede.BackColor = System.Drawing.Color.Transparent
        Me.LblRede.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblRede.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblRede.Location = New System.Drawing.Point(800, 28)
        Me.LblRede.Name = "LblRede"
        Me.LblRede.Size = New System.Drawing.Size(65, 15)
        Me.LblRede.TabIndex = 2
        Me.LblRede.Text = "  Você está " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblConetado
        '
        Me.LblConetado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblConetado.AutoSize = True
        Me.LblConetado.BackColor = System.Drawing.Color.Transparent
        Me.LblConetado.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblConetado.ForeColor = System.Drawing.Color.White
        Me.LblConetado.Location = New System.Drawing.Point(957, 28)
        Me.LblConetado.Name = "LblConetado"
        Me.LblConetado.Size = New System.Drawing.Size(0, 15)
        Me.LblConetado.TabIndex = 2
        '
        'MenuVertical_BunifuGradientPanel
        '
        Me.MenuVertical_BunifuGradientPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MenuVertical_BunifuGradientPanel.BackgroundImage = CType(resources.GetObject("MenuVertical_BunifuGradientPanel.BackgroundImage"), System.Drawing.Image)
        Me.MenuVertical_BunifuGradientPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuVertical_BunifuGradientPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MenuVertical_BunifuGradientPanel.Controls.Add(Me.BTVolume)
        Me.MenuVertical_BunifuGradientPanel.Controls.Add(Me.BTSalvar)
        Me.MenuVertical_BunifuGradientPanel.Controls.Add(Me.BTPESQUISAR)
        Me.MenuVertical_BunifuGradientPanel.Controls.Add(Me.BTCARREGAR)
        Me.MenuVertical_BunifuGradientPanel.Controls.Add(Me.BTEXCLUIR)
        Me.MenuVertical_BunifuGradientPanel.Controls.Add(Me.BTEDIT)
        Me.MenuVertical_BunifuGradientPanel.Controls.Add(Me.BTADD)
        Me.MenuVertical_BunifuGradientPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuVertical_BunifuGradientPanel.GradientBottomLeft = System.Drawing.Color.MediumPurple
        Me.MenuVertical_BunifuGradientPanel.GradientBottomRight = System.Drawing.SystemColors.Menu
        Me.MenuVertical_BunifuGradientPanel.GradientTopLeft = System.Drawing.Color.WhiteSmoke
        Me.MenuVertical_BunifuGradientPanel.GradientTopRight = System.Drawing.Color.PaleTurquoise
        Me.MenuVertical_BunifuGradientPanel.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.MenuVertical_BunifuGradientPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuVertical_BunifuGradientPanel.Name = "MenuVertical_BunifuGradientPanel"
        Me.MenuVertical_BunifuGradientPanel.Quality = 10
        Me.MenuVertical_BunifuGradientPanel.Size = New System.Drawing.Size(47, 687)
        Me.MenuVertical_BunifuGradientPanel.TabIndex = 1
        '
        'BTVolume
        '
        Me.BTVolume.BackColor = System.Drawing.Color.Transparent
        Me.BTVolume.Image = Global.Develop_SGP.My.Resources.Resources.Volume
        Me.BTVolume.Location = New System.Drawing.Point(10, 409)
        Me.BTVolume.Name = "BTVolume"
        Me.BTVolume.Size = New System.Drawing.Size(32, 42)
        Me.BTVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BTVolume.TabIndex = 1
        Me.BTVolume.TabStop = False
        '
        'BTSalvar
        '
        Me.BTSalvar.BackColor = System.Drawing.Color.Transparent
        Me.BTSalvar.Image = Global.Develop_SGP.My.Resources.Resources.cheacado
        Me.BTSalvar.Location = New System.Drawing.Point(8, 340)
        Me.BTSalvar.Name = "BTSalvar"
        Me.BTSalvar.Size = New System.Drawing.Size(32, 42)
        Me.BTSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BTSalvar.TabIndex = 1
        Me.BTSalvar.TabStop = False
        '
        'BTEXCLUIR
        '
        Me.BTEXCLUIR.BackColor = System.Drawing.Color.Transparent
        Me.BTEXCLUIR.Image = Global.Develop_SGP.My.Resources.Resources.Lixeira
        Me.BTEXCLUIR.Location = New System.Drawing.Point(8, 133)
        Me.BTEXCLUIR.Name = "BTEXCLUIR"
        Me.BTEXCLUIR.Size = New System.Drawing.Size(32, 42)
        Me.BTEXCLUIR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BTEXCLUIR.TabIndex = 1
        Me.BTEXCLUIR.TabStop = False
        '
        'BTADD
        '
        Me.BTADD.BackColor = System.Drawing.Color.Transparent
        Me.BTADD.Image = Global.Develop_SGP.My.Resources.Resources.Add
        Me.BTADD.Location = New System.Drawing.Point(8, 6)
        Me.BTADD.Name = "BTADD"
        Me.BTADD.Size = New System.Drawing.Size(32, 42)
        Me.BTADD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BTADD.TabIndex = 1
        Me.BTADD.TabStop = False
        '
        'FrmGeral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 687)
        Me.Controls.Add(Me.PainelContainer_de_Frms_Filhos)
        Me.Controls.Add(Me.Barra_de_TituloBunifuGradientPanel)
        Me.Controls.Add(Me.MenuVertical_BunifuGradientPanel)
        Me.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmGeral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Develop SGP by Marcos Ferreira"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BTPESQUISAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTCARREGAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTEDIT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PainelContainer_de_Frms_Filhos.ResumeLayout(False)
        Me.PainelContainer_de_Frms_Filhos.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.ProgressBar1.ResumeLayout(False)
        Me.ProgressBar1.PerformLayout()
        Me.Barra_de_TituloBunifuGradientPanel.ResumeLayout(False)
        Me.Barra_de_TituloBunifuGradientPanel.PerformLayout()
        CType(Me.BTNminimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VitalPintureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuVertical_BunifuGradientPanel.ResumeLayout(False)
        CType(Me.BTVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTSalvar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTEXCLUIR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTADD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuVertical_BunifuGradientPanel As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Barra_de_TituloBunifuGradientPanel As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PainelContainer_de_Frms_Filhos As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents VitalPintureBoxLogo As PictureBox
    Friend WithEvents BTNMaximizar As PictureBox
    Friend WithEvents BTNminimizar As PictureBox
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BTCARREGAR As PictureBox
    Friend WithEvents BTEXCLUIR As PictureBox
    Friend WithEvents BTEDIT As PictureBox
    Friend WithEvents BTADD As PictureBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents BTPESQUISAR As PictureBox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Id As ColumnHeader
    Friend WithEvents LblNome_ As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblReg_ As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblMotivo_ As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents CBOMOTIVO As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Registro As ColumnHeader
    Friend WithEvents Nome As ColumnHeader
    Friend WithEvents Motivo As ColumnHeader
    Friend WithEvents DataInicio As ColumnHeader
    Friend WithEvents DataFim As ColumnHeader
    Friend WithEvents Diferenca As ColumnHeader
    Friend WithEvents Status As ColumnHeader
    Friend WithEvents LblId_ As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TXTNOME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTREGISTRO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DTPFIM As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DTPINICIO As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents LBLDATAFIM As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LBLDATAINICIO As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BTLIMPARDATAFIM As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTLIMPARDATAINICIO As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Guna2HtmlToolTip1 As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents OpçãoEntrada As ColumnHeader
    Friend WithEvents OpçãoSaída As ColumnHeader
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LblRede As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents LblConetado As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BTSalvar As PictureBox
    Friend WithEvents LblQuantidadeFRMGeral As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BTlimparCampos As Guna.UI2.WinForms.Guna2GradientButton
    'Friend WithEvents ProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents TimerProgresbar As Timer
    Friend WithEvents ProgressBar1 As Guna.UI.WinForms.GunaCircleProgressBar
    Friend WithEvents BTVolume As PictureBox
    Friend WithEvents Lblaguarde As Bunifu.Framework.UI.BunifuCustomLabel
End Class
