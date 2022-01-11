
Imports Bunifu.Framework
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_edição
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_edição))
        Me.Cards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.LblResultado_Alterar = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BTDel_DataFim = New Guna.UI2.WinForms.Guna2Chip()
        Me.BTDel_DataInicio = New Guna.UI2.WinForms.Guna2Chip()
        Me.LBLDATAFIMM = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LBLDATAINICIOO = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.CBOMOTIVO = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.DTFIM = New MetroFramework.Controls.MetroDateTime()
        Me.DTINICIO = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.TXTNOME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTREGISTRO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTOPCAOSAIDA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTOPCAODEENTRADA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTSTATUS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTDIFERENÇA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ListView3 = New System.Windows.Forms.ListView()
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
        Me.BTalterar = New Guna.UI.WinForms.GunaButton()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Cards1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cards1
        '
        Me.Cards1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cards1.BackColor = System.Drawing.Color.White
        Me.Cards1.BorderRadius = 5
        Me.Cards1.BottomSahddow = True
        Me.Cards1.color = System.Drawing.Color.RoyalBlue
        Me.Cards1.Controls.Add(Me.LblResultado_Alterar)
        Me.Cards1.Controls.Add(Me.BTDel_DataFim)
        Me.Cards1.Controls.Add(Me.BTDel_DataInicio)
        Me.Cards1.Controls.Add(Me.LBLDATAFIMM)
        Me.Cards1.Controls.Add(Me.LBLDATAINICIOO)
        Me.Cards1.Controls.Add(Me.CBOMOTIVO)
        Me.Cards1.Controls.Add(Me.DTFIM)
        Me.Cards1.Controls.Add(Me.DTINICIO)
        Me.Cards1.Controls.Add(Me.MetroLabel6)
        Me.Cards1.Controls.Add(Me.MetroLabel5)
        Me.Cards1.Controls.Add(Me.MetroLabel4)
        Me.Cards1.Controls.Add(Me.MetroLabel3)
        Me.Cards1.Controls.Add(Me.MetroLabel2)
        Me.Cards1.Controls.Add(Me.MetroLabel10)
        Me.Cards1.Controls.Add(Me.MetroLabel8)
        Me.Cards1.Controls.Add(Me.MetroLabel9)
        Me.Cards1.Controls.Add(Me.MetroLabel7)
        Me.Cards1.Controls.Add(Me.MetroLabel1)
        Me.Cards1.Controls.Add(Me.TXTNOME)
        Me.Cards1.Controls.Add(Me.TXTREGISTRO)
        Me.Cards1.Controls.Add(Me.TXTOPCAOSAIDA)
        Me.Cards1.Controls.Add(Me.TXTOPCAODEENTRADA)
        Me.Cards1.Controls.Add(Me.TXTSTATUS)
        Me.Cards1.Controls.Add(Me.TXTDIFERENÇA)
        Me.Cards1.Controls.Add(Me.TXTID)
        Me.Cards1.Controls.Add(Me.ListView3)
        Me.Cards1.Controls.Add(Me.BTalterar)
        Me.Cards1.LeftSahddow = False
        Me.Cards1.Location = New System.Drawing.Point(9, 6)
        Me.Cards1.Name = "Cards1"
        Me.Cards1.RightSahddow = True
        Me.Cards1.ShadowDepth = 20
        Me.Cards1.Size = New System.Drawing.Size(998, 601)
        Me.Cards1.TabIndex = 0
        '
        'LblResultado_Alterar
        '
        Me.LblResultado_Alterar.AutoSize = True
        Me.LblResultado_Alterar.BackColor = System.Drawing.Color.Transparent
        Me.LblResultado_Alterar.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResultado_Alterar.ForeColor = System.Drawing.Color.SeaGreen
        Me.LblResultado_Alterar.Location = New System.Drawing.Point(217, 303)
        Me.LblResultado_Alterar.Name = "LblResultado_Alterar"
        Me.LblResultado_Alterar.Size = New System.Drawing.Size(0, 19)
        Me.LblResultado_Alterar.TabIndex = 15
        '
        'BTDel_DataFim
        '
        Me.BTDel_DataFim.FillColor = System.Drawing.Color.DodgerBlue
        Me.BTDel_DataFim.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTDel_DataFim.ForeColor = System.Drawing.Color.White
        Me.BTDel_DataFim.Location = New System.Drawing.Point(311, 243)
        Me.BTDel_DataFim.Name = "BTDel_DataFim"
        Me.BTDel_DataFim.ShadowDecoration.Parent = Me.BTDel_DataFim
        Me.BTDel_DataFim.Size = New System.Drawing.Size(31, 13)
        Me.BTDel_DataFim.TabIndex = 14
        Me.BTDel_DataFim.Text = "Del"
        Me.BTDel_DataFim.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'BTDel_DataInicio
        '
        Me.BTDel_DataInicio.FillColor = System.Drawing.Color.DodgerBlue
        Me.BTDel_DataInicio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTDel_DataInicio.ForeColor = System.Drawing.Color.White
        Me.BTDel_DataInicio.Location = New System.Drawing.Point(311, 203)
        Me.BTDel_DataInicio.Name = "BTDel_DataInicio"
        Me.BTDel_DataInicio.ShadowDecoration.Parent = Me.BTDel_DataInicio
        Me.BTDel_DataInicio.Size = New System.Drawing.Size(31, 13)
        Me.BTDel_DataInicio.TabIndex = 14
        Me.BTDel_DataInicio.Text = "Del"
        Me.BTDel_DataInicio.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'LBLDATAFIMM
        '
        Me.LBLDATAFIMM.AutoSize = True
        Me.LBLDATAFIMM.BackColor = System.Drawing.Color.Transparent
        Me.LBLDATAFIMM.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDATAFIMM.ForeColor = System.Drawing.Color.SeaGreen
        Me.LBLDATAFIMM.Location = New System.Drawing.Point(190, 254)
        Me.LBLDATAFIMM.Name = "LBLDATAFIMM"
        Me.LBLDATAFIMM.Size = New System.Drawing.Size(0, 19)
        Me.LBLDATAFIMM.TabIndex = 13
        '
        'LBLDATAINICIOO
        '
        Me.LBLDATAINICIOO.AutoSize = True
        Me.LBLDATAINICIOO.BackColor = System.Drawing.Color.Transparent
        Me.LBLDATAINICIOO.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDATAINICIOO.ForeColor = System.Drawing.Color.SeaGreen
        Me.LBLDATAINICIOO.Location = New System.Drawing.Point(190, 214)
        Me.LBLDATAINICIOO.Name = "LBLDATAINICIOO"
        Me.LBLDATAINICIOO.Size = New System.Drawing.Size(0, 19)
        Me.LBLDATAINICIOO.TabIndex = 13
        '
        'CBOMOTIVO
        '
        Me.CBOMOTIVO.BackColor = System.Drawing.Color.Transparent
        Me.CBOMOTIVO.BorderColor = System.Drawing.Color.Blue
        Me.CBOMOTIVO.BorderRadius = 5
        Me.CBOMOTIVO.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.CBOMOTIVO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBOMOTIVO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOMOTIVO.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBOMOTIVO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBOMOTIVO.FocusedState.Parent = Me.CBOMOTIVO
        Me.CBOMOTIVO.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.CBOMOTIVO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBOMOTIVO.HoverState.Parent = Me.CBOMOTIVO
        Me.CBOMOTIVO.ItemHeight = 30
        Me.CBOMOTIVO.Items.AddRange(New Object() {"Atestado", "Suspensão ", "Advertência", "Falta não Justif", "Férias"})
        Me.CBOMOTIVO.ItemsAppearance.Parent = Me.CBOMOTIVO
        Me.CBOMOTIVO.Location = New System.Drawing.Point(107, 161)
        Me.CBOMOTIVO.Name = "CBOMOTIVO"
        Me.CBOMOTIVO.ShadowDecoration.Parent = Me.CBOMOTIVO
        Me.CBOMOTIVO.Size = New System.Drawing.Size(237, 36)
        Me.CBOMOTIVO.TabIndex = 12
        '
        'DTFIM
        '
        Me.DTFIM.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DTFIM.CalendarTrailingForeColor = System.Drawing.SystemColors.HotTrack
        Me.DTFIM.DisplayFocus = True
        Me.DTFIM.FontWeight = MetroFramework.MetroDateTimeWeight.Light
        Me.DTFIM.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFIM.Location = New System.Drawing.Point(107, 248)
        Me.DTFIM.MinimumSize = New System.Drawing.Size(0, 29)
        Me.DTFIM.Name = "DTFIM"
        Me.DTFIM.Size = New System.Drawing.Size(236, 29)
        Me.DTFIM.Style = MetroFramework.MetroColorStyle.Blue
        Me.DTFIM.TabIndex = 5
        Me.DTFIM.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'DTINICIO
        '
        Me.DTINICIO.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTINICIO.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DTINICIO.CalendarTrailingForeColor = System.Drawing.SystemColors.HotTrack
        Me.DTINICIO.DisplayFocus = True
        Me.DTINICIO.FontWeight = MetroFramework.MetroDateTimeWeight.Light
        Me.DTINICIO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTINICIO.Location = New System.Drawing.Point(107, 208)
        Me.DTINICIO.MinimumSize = New System.Drawing.Size(0, 29)
        Me.DTINICIO.Name = "DTINICIO"
        Me.DTINICIO.Size = New System.Drawing.Size(236, 29)
        Me.DTINICIO.Style = MetroFramework.MetroColorStyle.Silver
        Me.DTINICIO.TabIndex = 4
        Me.DTINICIO.UseCustomBackColor = True
        Me.DTINICIO.UseCustomForeColor = True
        Me.DTINICIO.UseStyleColors = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Location = New System.Drawing.Point(15, 259)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(71, 23)
        Me.MetroLabel6.TabIndex = 6
        Me.MetroLabel6.Text = "Data Fim"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Location = New System.Drawing.Point(15, 217)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(100, 23)
        Me.MetroLabel5.TabIndex = 6
        Me.MetroLabel5.Text = "Data de Inicio."
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Location = New System.Drawing.Point(15, 173)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(55, 23)
        Me.MetroLabel4.TabIndex = 6
        Me.MetroLabel4.Text = "Motivo"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Location = New System.Drawing.Point(15, 125)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(55, 23)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Nome"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(15, 73)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(32, 19)
        Me.MetroLabel2.TabIndex = 6
        Me.MetroLabel2.Text = "Reg"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(15, 449)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(85, 19)
        Me.MetroLabel10.TabIndex = 6
        Me.MetroLabel10.Text = "Opção Saída"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(15, 355)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel8.TabIndex = 6
        Me.MetroLabel8.Text = "Status"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(15, 400)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel9.TabIndex = 6
        Me.MetroLabel9.Text = "Opção Ent"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(15, 309)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel7.TabIndex = 6
        Me.MetroLabel7.Text = "Diferença"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(15, 29)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(20, 19)
        Me.MetroLabel1.TabIndex = 6
        Me.MetroLabel1.Text = "Id"
        '
        'TXTNOME
        '
        Me.TXTNOME.Animated = True
        Me.TXTNOME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TXTNOME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TXTNOME.BorderColor = System.Drawing.Color.Blue
        Me.TXTNOME.BorderRadius = 5
        Me.TXTNOME.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.TXTNOME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTNOME.DefaultText = ""
        Me.TXTNOME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTNOME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTNOME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTNOME.DisabledState.Parent = Me.TXTNOME
        Me.TXTNOME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTNOME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTNOME.FocusedState.Parent = Me.TXTNOME
        Me.TXTNOME.Font = New System.Drawing.Font("Corbel", 9.75!)
        Me.TXTNOME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTNOME.HoverState.Parent = Me.TXTNOME
        Me.TXTNOME.Location = New System.Drawing.Point(107, 114)
        Me.TXTNOME.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTNOME.Name = "TXTNOME"
        Me.TXTNOME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTNOME.PlaceholderText = ""
        Me.TXTNOME.SelectedText = ""
        Me.TXTNOME.ShadowDecoration.Parent = Me.TXTNOME
        Me.TXTNOME.Size = New System.Drawing.Size(235, 36)
        Me.TXTNOME.TabIndex = 2
        Me.TXTNOME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTREGISTRO
        '
        Me.TXTREGISTRO.Animated = True
        Me.TXTREGISTRO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TXTREGISTRO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TXTREGISTRO.BorderColor = System.Drawing.Color.Blue
        Me.TXTREGISTRO.BorderRadius = 5
        Me.TXTREGISTRO.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.TXTREGISTRO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTREGISTRO.DefaultText = ""
        Me.TXTREGISTRO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTREGISTRO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTREGISTRO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTREGISTRO.DisabledState.Parent = Me.TXTREGISTRO
        Me.TXTREGISTRO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTREGISTRO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTREGISTRO.FocusedState.Parent = Me.TXTREGISTRO
        Me.TXTREGISTRO.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.TXTREGISTRO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTREGISTRO.HoverState.Parent = Me.TXTREGISTRO
        Me.TXTREGISTRO.Location = New System.Drawing.Point(107, 70)
        Me.TXTREGISTRO.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXTREGISTRO.Name = "TXTREGISTRO"
        Me.TXTREGISTRO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTREGISTRO.PlaceholderText = ""
        Me.TXTREGISTRO.SelectedText = ""
        Me.TXTREGISTRO.ShadowDecoration.Parent = Me.TXTREGISTRO
        Me.TXTREGISTRO.Size = New System.Drawing.Size(236, 36)
        Me.TXTREGISTRO.TabIndex = 1
        Me.TXTREGISTRO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTOPCAOSAIDA
        '
        Me.TXTOPCAOSAIDA.Animated = True
        Me.TXTOPCAOSAIDA.BorderColor = System.Drawing.Color.RoyalBlue
        Me.TXTOPCAOSAIDA.BorderRadius = 5
        Me.TXTOPCAOSAIDA.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.TXTOPCAOSAIDA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTOPCAOSAIDA.DefaultText = ""
        Me.TXTOPCAOSAIDA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTOPCAOSAIDA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTOPCAOSAIDA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTOPCAOSAIDA.DisabledState.Parent = Me.TXTOPCAOSAIDA
        Me.TXTOPCAOSAIDA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTOPCAOSAIDA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTOPCAOSAIDA.FocusedState.Parent = Me.TXTOPCAOSAIDA
        Me.TXTOPCAOSAIDA.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.TXTOPCAOSAIDA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTOPCAOSAIDA.HoverState.Parent = Me.TXTOPCAOSAIDA
        Me.TXTOPCAOSAIDA.Location = New System.Drawing.Point(107, 441)
        Me.TXTOPCAOSAIDA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXTOPCAOSAIDA.Name = "TXTOPCAOSAIDA"
        Me.TXTOPCAOSAIDA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTOPCAOSAIDA.PlaceholderText = ""
        Me.TXTOPCAOSAIDA.SelectedText = ""
        Me.TXTOPCAOSAIDA.ShadowDecoration.Parent = Me.TXTOPCAOSAIDA
        Me.TXTOPCAOSAIDA.Size = New System.Drawing.Size(237, 36)
        Me.TXTOPCAOSAIDA.TabIndex = 9
        Me.TXTOPCAOSAIDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTOPCAODEENTRADA
        '
        Me.TXTOPCAODEENTRADA.Animated = True
        Me.TXTOPCAODEENTRADA.BorderColor = System.Drawing.Color.RoyalBlue
        Me.TXTOPCAODEENTRADA.BorderRadius = 5
        Me.TXTOPCAODEENTRADA.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.TXTOPCAODEENTRADA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTOPCAODEENTRADA.DefaultText = ""
        Me.TXTOPCAODEENTRADA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTOPCAODEENTRADA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTOPCAODEENTRADA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTOPCAODEENTRADA.DisabledState.Parent = Me.TXTOPCAODEENTRADA
        Me.TXTOPCAODEENTRADA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTOPCAODEENTRADA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTOPCAODEENTRADA.FocusedState.Parent = Me.TXTOPCAODEENTRADA
        Me.TXTOPCAODEENTRADA.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.TXTOPCAODEENTRADA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTOPCAODEENTRADA.HoverState.Parent = Me.TXTOPCAODEENTRADA
        Me.TXTOPCAODEENTRADA.Location = New System.Drawing.Point(107, 392)
        Me.TXTOPCAODEENTRADA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXTOPCAODEENTRADA.Name = "TXTOPCAODEENTRADA"
        Me.TXTOPCAODEENTRADA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTOPCAODEENTRADA.PlaceholderText = ""
        Me.TXTOPCAODEENTRADA.SelectedText = ""
        Me.TXTOPCAODEENTRADA.ShadowDecoration.Parent = Me.TXTOPCAODEENTRADA
        Me.TXTOPCAODEENTRADA.Size = New System.Drawing.Size(236, 36)
        Me.TXTOPCAODEENTRADA.TabIndex = 8
        Me.TXTOPCAODEENTRADA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTSTATUS
        '
        Me.TXTSTATUS.Animated = True
        Me.TXTSTATUS.BorderColor = System.Drawing.Color.RoyalBlue
        Me.TXTSTATUS.BorderRadius = 5
        Me.TXTSTATUS.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.TXTSTATUS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTSTATUS.DefaultText = ""
        Me.TXTSTATUS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTSTATUS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTSTATUS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTSTATUS.DisabledState.Parent = Me.TXTSTATUS
        Me.TXTSTATUS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTSTATUS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTSTATUS.FocusedState.Parent = Me.TXTSTATUS
        Me.TXTSTATUS.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.TXTSTATUS.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTSTATUS.HoverState.Parent = Me.TXTSTATUS
        Me.TXTSTATUS.Location = New System.Drawing.Point(107, 343)
        Me.TXTSTATUS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXTSTATUS.Name = "TXTSTATUS"
        Me.TXTSTATUS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTSTATUS.PlaceholderText = ""
        Me.TXTSTATUS.SelectedText = ""
        Me.TXTSTATUS.ShadowDecoration.Parent = Me.TXTSTATUS
        Me.TXTSTATUS.Size = New System.Drawing.Size(236, 36)
        Me.TXTSTATUS.TabIndex = 7
        Me.TXTSTATUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTDIFERENÇA
        '
        Me.TXTDIFERENÇA.Animated = True
        Me.TXTDIFERENÇA.BorderColor = System.Drawing.Color.RoyalBlue
        Me.TXTDIFERENÇA.BorderRadius = 5
        Me.TXTDIFERENÇA.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.TXTDIFERENÇA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTDIFERENÇA.DefaultText = ""
        Me.TXTDIFERENÇA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTDIFERENÇA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTDIFERENÇA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTDIFERENÇA.DisabledState.Parent = Me.TXTDIFERENÇA
        Me.TXTDIFERENÇA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTDIFERENÇA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTDIFERENÇA.FocusedState.Parent = Me.TXTDIFERENÇA
        Me.TXTDIFERENÇA.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.TXTDIFERENÇA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTDIFERENÇA.HoverState.Parent = Me.TXTDIFERENÇA
        Me.TXTDIFERENÇA.Location = New System.Drawing.Point(107, 293)
        Me.TXTDIFERENÇA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXTDIFERENÇA.Name = "TXTDIFERENÇA"
        Me.TXTDIFERENÇA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTDIFERENÇA.PlaceholderText = ""
        Me.TXTDIFERENÇA.SelectedText = ""
        Me.TXTDIFERENÇA.ShadowDecoration.Parent = Me.TXTDIFERENÇA
        Me.TXTDIFERENÇA.Size = New System.Drawing.Size(236, 36)
        Me.TXTDIFERENÇA.TabIndex = 6
        '
        'TXTID
        '
        Me.TXTID.Animated = True
        Me.TXTID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXTID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TXTID.BorderColor = System.Drawing.Color.Blue
        Me.TXTID.BorderRadius = 5
        Me.TXTID.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.TXTID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTID.DefaultText = ""
        Me.TXTID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTID.DisabledState.Parent = Me.TXTID
        Me.TXTID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTID.FocusedState.Parent = Me.TXTID
        Me.TXTID.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.TXTID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTID.HoverState.Parent = Me.TXTID
        Me.TXTID.Location = New System.Drawing.Point(107, 27)
        Me.TXTID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXTID.Name = "TXTID"
        Me.TXTID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTID.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.TXTID.PlaceholderText = ""
        Me.TXTID.ReadOnly = True
        Me.TXTID.SelectedText = ""
        Me.TXTID.ShadowDecoration.Parent = Me.TXTID
        Me.TXTID.Size = New System.Drawing.Size(235, 36)
        Me.TXTID.TabIndex = 0
        Me.TXTID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ListView3
        '
        Me.ListView3.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView3.BackColor = System.Drawing.Color.White
        Me.ListView3.BackgroundImageTiled = True
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Id, Me.Registro, Me.Nome, Me.Motivo, Me.DataInicio, Me.DataFim, Me.Diferenca, Me.Status, Me.OpçãoEntrada, Me.OpçãoSaída})
        Me.ListView3.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.HideSelection = False
        Me.ListView3.Location = New System.Drawing.Point(349, 23)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(645, 575)
        Me.ListView3.TabIndex = 11
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'Id
        '
        Me.Id.Text = "Id"
        Me.Id.Width = 50
        '
        'Registro
        '
        Me.Registro.Text = "N° Registro"
        Me.Registro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Registro.Width = 100
        '
        'Nome
        '
        Me.Nome.Text = "Nome"
        Me.Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Nome.Width = 130
        '
        'Motivo
        '
        Me.Motivo.Text = "Motivo"
        Me.Motivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Motivo.Width = 150
        '
        'DataInicio
        '
        Me.DataInicio.Text = "Data Inicio"
        Me.DataInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataInicio.Width = 150
        '
        'DataFim
        '
        Me.DataFim.Text = "Data Fim"
        Me.DataFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataFim.Width = 150
        '
        'Diferenca
        '
        Me.Diferenca.Text = "Diferença"
        Me.Diferenca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Diferenca.Width = 90
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Status.Width = 95
        '
        'OpçãoEntrada
        '
        Me.OpçãoEntrada.Text = "Opção de Entrada"
        Me.OpçãoEntrada.Width = 190
        '
        'OpçãoSaída
        '
        Me.OpçãoSaída.Text = "Opção de Saída"
        Me.OpçãoSaída.Width = 230
        '
        'BTalterar
        '
        Me.BTalterar.AnimationHoverSpeed = 0.07!
        Me.BTalterar.AnimationSpeed = 0.03!
        Me.BTalterar.BaseColor = System.Drawing.Color.SteelBlue
        Me.BTalterar.BorderColor = System.Drawing.Color.Black
        Me.BTalterar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTalterar.FocusedColor = System.Drawing.Color.DarkGreen
        Me.BTalterar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTalterar.ForeColor = System.Drawing.Color.White
        Me.BTalterar.Image = CType(resources.GetObject("BTalterar.Image"), System.Drawing.Image)
        Me.BTalterar.ImageSize = New System.Drawing.Size(20, 20)
        Me.BTalterar.Location = New System.Drawing.Point(15, 497)
        Me.BTalterar.Name = "BTalterar"
        Me.BTalterar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTalterar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTalterar.OnHoverForeColor = System.Drawing.Color.White
        Me.BTalterar.OnHoverImage = Nothing
        Me.BTalterar.OnPressedColor = System.Drawing.Color.Black
        Me.BTalterar.Size = New System.Drawing.Size(329, 42)
        Me.BTalterar.TabIndex = 10
        Me.BTalterar.Text = "Alterar"
        Me.BTalterar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'FRM_edição
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 620)
        Me.Controls.Add(Me.Cards1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FRM_edição"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Formulário de Edição"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Cards1.ResumeLayout(False)
        Me.Cards1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Cards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BTalterar As Guna.UI.WinForms.GunaButton
    Friend WithEvents ListView3 As ListView
    Friend WithEvents Id As ColumnHeader
    Friend WithEvents Registro As ColumnHeader
    Friend WithEvents Nome As ColumnHeader
    Friend WithEvents Motivo As ColumnHeader
    Friend WithEvents DataInicio As ColumnHeader
    Friend WithEvents DataFim As ColumnHeader
    Friend WithEvents Diferenca As ColumnHeader
    Friend WithEvents Status As ColumnHeader
    Friend WithEvents OpçãoEntrada As ColumnHeader
    Friend WithEvents OpçãoSaída As ColumnHeader
    Friend WithEvents TXTREGISTRO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TXTNOME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents DTFIM As MetroFramework.Controls.MetroDateTime
    Friend WithEvents DTINICIO As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TXTOPCAOSAIDA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTOPCAODEENTRADA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTSTATUS As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTDIFERENÇA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents TXTID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CBOMOTIVO As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LBLDATAFIMM As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LBLDATAINICIOO As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BTDel_DataFim As Guna.UI2.WinForms.Guna2Chip
    Friend WithEvents BTDel_DataInicio As Guna.UI2.WinForms.Guna2Chip
    Friend WithEvents LblResultado_Alterar As UI.BunifuCustomLabel
End Class
