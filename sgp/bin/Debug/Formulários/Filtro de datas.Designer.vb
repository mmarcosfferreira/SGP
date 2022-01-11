<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMFiltroDatas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMFiltroDatas))
        Me.ListView2 = New System.Windows.Forms.ListView()
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
        Me.BtBuscar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Lbl_Ate = New MetroFramework.Controls.MetroLabel()
        Me.Lbl_de = New MetroFramework.Controls.MetroLabel()
        Me.DTPate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DTPde = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.LBLrotulo = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.TXTPESQUISAR = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CboFiltrarPor = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LblPesquisar = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BTImprimir = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2HtmlToolTip1 = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView2
        '
        Me.ListView2.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView2.BackColor = System.Drawing.Color.White
        Me.ListView2.BackgroundImageTiled = True
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Id, Me.Registro, Me.Nome, Me.Motivo, Me.DataInicio, Me.DataFim, Me.Diferenca, Me.Status, Me.OpçãoEntrada, Me.OpçãoSaída})
        Me.ListView2.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(4, 246)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(1345, 410)
        Me.ListView2.TabIndex = 1
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
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
        Me.Nome.Width = 140
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
        Me.OpçãoEntrada.Width = 243
        '
        'OpçãoSaída
        '
        Me.OpçãoSaída.Text = "Opção de Saída"
        Me.OpçãoSaída.Width = 230
        '
        'BtBuscar
        '
        Me.BtBuscar.Animated = True
        Me.BtBuscar.CheckedState.Parent = Me.BtBuscar
        Me.BtBuscar.CustomImages.Parent = Me.BtBuscar
        Me.BtBuscar.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtBuscar.ForeColor = System.Drawing.Color.White
        Me.BtBuscar.HoverState.Parent = Me.BtBuscar
        Me.BtBuscar.Location = New System.Drawing.Point(880, 195)
        Me.BtBuscar.Name = "BtBuscar"
        Me.BtBuscar.ShadowDecoration.Parent = Me.BtBuscar
        Me.BtBuscar.Size = New System.Drawing.Size(65, 25)
        Me.BtBuscar.TabIndex = 3
        Me.BtBuscar.Text = "Buscar"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GroupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2GroupBox1.Controls.Add(Me.Lbl_Ate)
        Me.Guna2GroupBox1.Controls.Add(Me.Lbl_de)
        Me.Guna2GroupBox1.Controls.Add(Me.DTPate)
        Me.Guna2GroupBox1.Controls.Add(Me.DTPde)
        Me.Guna2GroupBox1.Controls.Add(Me.LBLrotulo)
        Me.Guna2GroupBox1.Controls.Add(Me.GunaLabel1)
        Me.Guna2GroupBox1.Controls.Add(Me.TXTPESQUISAR)
        Me.Guna2GroupBox1.Controls.Add(Me.CboFiltrarPor)
        Me.Guna2GroupBox1.Controls.Add(Me.LblPesquisar)
        Me.Guna2GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2GradientButton1)
        Me.Guna2GroupBox1.Controls.Add(Me.BTImprimir)
        Me.Guna2GroupBox1.Controls.Add(Me.BtBuscar)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.RoyalBlue
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Yellow
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(1, -10)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1345, 250)
        Me.Guna2GroupBox1.TabIndex = 4
        Me.Guna2GroupBox1.Text = "Filtro"
        '
        'Lbl_Ate
        '
        Me.Lbl_Ate.AutoSize = True
        Me.Lbl_Ate.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_Ate.Location = New System.Drawing.Point(652, 163)
        Me.Lbl_Ate.Name = "Lbl_Ate"
        Me.Lbl_Ate.Size = New System.Drawing.Size(29, 19)
        Me.Lbl_Ate.TabIndex = 5
        Me.Lbl_Ate.Text = "Até"
        Me.Lbl_Ate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Lbl_de
        '
        Me.Lbl_de.AutoSize = True
        Me.Lbl_de.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_de.Location = New System.Drawing.Point(426, 163)
        Me.Lbl_de.Name = "Lbl_de"
        Me.Lbl_de.Size = New System.Drawing.Size(25, 19)
        Me.Lbl_de.TabIndex = 5
        Me.Lbl_de.Text = "De"
        Me.Lbl_de.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'DTPate
        '
        Me.DTPate.Animated = True
        Me.DTPate.AutoRoundedCorners = True
        Me.DTPate.BackColor = System.Drawing.Color.Transparent
        Me.DTPate.BorderColor = System.Drawing.Color.RoyalBlue
        Me.DTPate.BorderRadius = 18
        Me.DTPate.BorderThickness = 1
        Me.DTPate.CheckedState.Parent = Me.DTPate
        Me.DTPate.FillColor = System.Drawing.Color.White
        Me.DTPate.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPate.ForeColor = System.Drawing.Color.RoyalBlue
        Me.DTPate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPate.HoverState.BorderColor = System.Drawing.Color.Black
        Me.DTPate.HoverState.FillColor = System.Drawing.Color.White
        Me.DTPate.HoverState.ForeColor = System.Drawing.Color.SeaGreen
        Me.DTPate.HoverState.Parent = Me.DTPate
        Me.DTPate.Location = New System.Drawing.Point(557, 181)
        Me.DTPate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTPate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTPate.Name = "DTPate"
        Me.DTPate.ShadowDecoration.BorderRadius = 8
        Me.DTPate.ShadowDecoration.Color = System.Drawing.Color.Transparent
        Me.DTPate.ShadowDecoration.Depth = 10
        Me.DTPate.ShadowDecoration.Parent = Me.DTPate
        Me.DTPate.Size = New System.Drawing.Size(223, 38)
        Me.DTPate.TabIndex = 10
        Me.DTPate.Value = New Date(2020, 7, 2, 23, 33, 31, 13)
        '
        'DTPde
        '
        Me.DTPde.Animated = True
        Me.DTPde.AutoRoundedCorners = True
        Me.DTPde.BackColor = System.Drawing.Color.Transparent
        Me.DTPde.BorderColor = System.Drawing.Color.RoyalBlue
        Me.DTPde.BorderRadius = 18
        Me.DTPde.BorderThickness = 1
        Me.DTPde.CheckedState.Parent = Me.DTPde
        Me.DTPde.FillColor = System.Drawing.Color.White
        Me.DTPde.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPde.ForeColor = System.Drawing.Color.RoyalBlue
        Me.DTPde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPde.HoverState.BorderColor = System.Drawing.Color.Black
        Me.DTPde.HoverState.FillColor = System.Drawing.Color.White
        Me.DTPde.HoverState.ForeColor = System.Drawing.Color.SeaGreen
        Me.DTPde.HoverState.Parent = Me.DTPde
        Me.DTPde.Location = New System.Drawing.Point(328, 181)
        Me.DTPde.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTPde.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTPde.Name = "DTPde"
        Me.DTPde.ShadowDecoration.BorderRadius = 8
        Me.DTPde.ShadowDecoration.Color = System.Drawing.Color.Transparent
        Me.DTPde.ShadowDecoration.Depth = 10
        Me.DTPde.ShadowDecoration.Parent = Me.DTPde
        Me.DTPde.Size = New System.Drawing.Size(220, 38)
        Me.DTPde.TabIndex = 10
        Me.DTPde.Value = New Date(2020, 7, 2, 23, 33, 31, 13)
        '
        'LBLrotulo
        '
        Me.LBLrotulo.BackColor = System.Drawing.Color.Transparent
        Me.LBLrotulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBLrotulo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLrotulo.ForeColor = System.Drawing.Color.Black
        Me.LBLrotulo.Location = New System.Drawing.Point(746, 79)
        Me.LBLrotulo.Name = "LBLrotulo"
        Me.LBLrotulo.Size = New System.Drawing.Size(282, 40)
        Me.LBLrotulo.TabIndex = 9
        Me.LBLrotulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GunaLabel1
        '
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel1.Location = New System.Drawing.Point(561, 79)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(195, 40)
        Me.GunaLabel1.TabIndex = 9
        Me.GunaLabel1.Text = "Relatório de Consulta"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TXTPESQUISAR
        '
        Me.TXTPESQUISAR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXTPESQUISAR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TXTPESQUISAR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTPESQUISAR.DefaultText = ""
        Me.TXTPESQUISAR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTPESQUISAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTPESQUISAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTPESQUISAR.DisabledState.Parent = Me.TXTPESQUISAR
        Me.TXTPESQUISAR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTPESQUISAR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTPESQUISAR.FocusedState.Parent = Me.TXTPESQUISAR
        Me.TXTPESQUISAR.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTPESQUISAR.HoverState.Parent = Me.TXTPESQUISAR
        Me.TXTPESQUISAR.Location = New System.Drawing.Point(330, 183)
        Me.TXTPESQUISAR.Name = "TXTPESQUISAR"
        Me.TXTPESQUISAR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTPESQUISAR.PlaceholderText = ""
        Me.TXTPESQUISAR.SelectedText = ""
        Me.TXTPESQUISAR.ShadowDecoration.Parent = Me.TXTPESQUISAR
        Me.TXTPESQUISAR.Size = New System.Drawing.Size(230, 36)
        Me.TXTPESQUISAR.TabIndex = 8
        '
        'CboFiltrarPor
        '
        Me.CboFiltrarPor.BackColor = System.Drawing.Color.Transparent
        Me.CboFiltrarPor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CboFiltrarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFiltrarPor.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CboFiltrarPor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CboFiltrarPor.FocusedState.Parent = Me.CboFiltrarPor
        Me.CboFiltrarPor.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.CboFiltrarPor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CboFiltrarPor.HoverState.Parent = Me.CboFiltrarPor
        Me.CboFiltrarPor.ItemHeight = 30
        Me.CboFiltrarPor.Items.AddRange(New Object() {"Nº do Registro", "Nome", "Data", "Status", "Motivo"})
        Me.CboFiltrarPor.ItemsAppearance.Parent = Me.CboFiltrarPor
        Me.CboFiltrarPor.Location = New System.Drawing.Point(11, 183)
        Me.CboFiltrarPor.Name = "CboFiltrarPor"
        Me.CboFiltrarPor.ShadowDecoration.Parent = Me.CboFiltrarPor
        Me.CboFiltrarPor.Size = New System.Drawing.Size(273, 36)
        Me.CboFiltrarPor.TabIndex = 7
        '
        'LblPesquisar
        '
        Me.LblPesquisar.AutoSize = True
        Me.LblPesquisar.BackColor = System.Drawing.SystemColors.Control
        Me.LblPesquisar.Location = New System.Drawing.Point(328, 159)
        Me.LblPesquisar.Name = "LblPesquisar"
        Me.LblPesquisar.Size = New System.Drawing.Size(58, 19)
        Me.LblPesquisar.TabIndex = 5
        Me.LblPesquisar.Text = "Pesquisa"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.SystemColors.Control
        Me.MetroLabel3.Location = New System.Drawing.Point(11, 160)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel3.TabIndex = 5
        Me.MetroLabel3.Text = "Filtrar por"
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.Animated = True
        Me.Guna2GradientButton1.CheckedState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.CustomImages.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.HoverState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(1022, 195)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.ShadowDecoration.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(65, 25)
        Me.Guna2GradientButton1.TabIndex = 3
        Me.Guna2GradientButton1.Text = "Sair"
        '
        'BTImprimir
        '
        Me.BTImprimir.Animated = True
        Me.BTImprimir.CheckedState.Parent = Me.BTImprimir
        Me.BTImprimir.CustomImages.Parent = Me.BTImprimir
        Me.BTImprimir.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTImprimir.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTImprimir.ForeColor = System.Drawing.Color.White
        Me.BTImprimir.HoverState.Parent = Me.BTImprimir
        Me.BTImprimir.Location = New System.Drawing.Point(951, 195)
        Me.BTImprimir.Name = "BTImprimir"
        Me.BTImprimir.ShadowDecoration.Parent = Me.BTImprimir
        Me.BTImprimir.Size = New System.Drawing.Size(65, 25)
        Me.BTImprimir.TabIndex = 3
        Me.BTImprimir.Text = "Imprimir"
        '
        'Guna2HtmlToolTip1
        '
        Me.Guna2HtmlToolTip1.AllowLinksHandling = True
        Me.Guna2HtmlToolTip1.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'FRMFiltroDatas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 654)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.ListView2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FRMFiltroDatas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtro de datas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView2 As ListView
    Friend WithEvents Id As ColumnHeader
    Friend WithEvents Registro As ColumnHeader
    Friend WithEvents Nome As ColumnHeader
    Friend WithEvents Motivo As ColumnHeader
    Friend WithEvents DataInicio As ColumnHeader
    Friend WithEvents DataFim As ColumnHeader
    Friend WithEvents Diferenca As ColumnHeader
    Friend WithEvents Status As ColumnHeader
    Friend WithEvents BtBuscar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BTImprimir As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents CboFiltrarPor As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TXTPESQUISAR As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents OpçãoEntrada As ColumnHeader
    Friend WithEvents OpçãoSaída As ColumnHeader
    Friend WithEvents LBLrotulo As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LblPesquisar As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents DTPde As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DTPate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Lbl_Ate As MetroFramework.Controls.MetroLabel
    Friend WithEvents Lbl_de As MetroFramework.Controls.MetroLabel
    Friend WithEvents Guna2HtmlToolTip1 As Guna.UI2.WinForms.Guna2HtmlToolTip
End Class
