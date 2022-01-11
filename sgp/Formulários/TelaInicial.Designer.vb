<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaInicial
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TelaInicial))
        Me.MainLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.DetailsLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MainLayoutPanel.SuspendLayout()
        Me.DetailsLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainLayoutPanel
        '
        Me.MainLayoutPanel.BackColor = System.Drawing.Color.LightBlue
        Me.MainLayoutPanel.BackgroundImage = CType(resources.GetObject("MainLayoutPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainLayoutPanel.ColumnCount = 1
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 290.0!))
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MainLayoutPanel.Controls.Add(Me.DetailsLayoutPanel, 0, 1)
        Me.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainLayoutPanel.Name = "MainLayoutPanel"
        Me.MainLayoutPanel.RowCount = 2
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MainLayoutPanel.Size = New System.Drawing.Size(1330, 767)
        Me.MainLayoutPanel.TabIndex = 0
        '
        'DetailsLayoutPanel
        '
        Me.DetailsLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.DetailsLayoutPanel.ColumnCount = 1
        Me.DetailsLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1093.0!))
        Me.DetailsLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.DetailsLayoutPanel.Controls.Add(Me.Copyright, 0, 2)
        Me.DetailsLayoutPanel.Controls.Add(Me.Version, 0, 1)
        Me.DetailsLayoutPanel.Controls.Add(Me.Label1, 0, 0)
        Me.DetailsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DetailsLayoutPanel.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.DetailsLayoutPanel.Location = New System.Drawing.Point(3, 553)
        Me.DetailsLayoutPanel.Name = "DetailsLayoutPanel"
        Me.DetailsLayoutPanel.RowCount = 1
        Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.DetailsLayoutPanel.Size = New System.Drawing.Size(1324, 211)
        Me.DetailsLayoutPanel.TabIndex = 1
        '
        'Copyright
        '
        Me.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Copyright.AutoSize = True
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.ForeColor = System.Drawing.Color.White
        Me.Copyright.Location = New System.Drawing.Point(563, 168)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(197, 18)
        Me.Copyright.TabIndex = 2
        Me.Copyright.Text = "Copyright Marcos Ferreira"
        Me.Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Version
        '
        Me.Version.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Version.AutoSize = True
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.ForeColor = System.Drawing.Color.White
        Me.Version.Location = New System.Drawing.Point(618, 101)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(88, 15)
        Me.Version.TabIndex = 1
        Me.Version.Text = "Versão: 1.0.0.0"
        Me.Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(561, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Vital Engenharia Ambiental"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TelaInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1330, 767)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TelaInicial"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MainLayoutPanel.ResumeLayout(False)
        Me.DetailsLayoutPanel.ResumeLayout(False)
        Me.DetailsLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainLayoutPanel As TableLayoutPanel
    Friend WithEvents DetailsLayoutPanel As TableLayoutPanel
    Friend WithEvents Copyright As Label
    Friend WithEvents Version As Label
    Friend WithEvents Label1 As Label

End Class
