<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVolume
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVolume))
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.LblValor = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2VTrackBar1 = New Guna.UI2.WinForms.Guna2VTrackBar()
        Me.Btfixar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BtDesfixar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTminimizar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.Controls.Add(Me.LblValor)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2VTrackBar1)
        Me.Guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.RoyalBlue
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2GradientPanel1.FillColor = System.Drawing.SystemColors.MenuHighlight
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(58, 145)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'LblValor
        '
        Me.LblValor.AutoSize = True
        Me.LblValor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblValor.ForeColor = System.Drawing.Color.Cornsilk
        Me.LblValor.Location = New System.Drawing.Point(10, 121)
        Me.LblValor.Name = "LblValor"
        Me.LblValor.Size = New System.Drawing.Size(33, 15)
        Me.LblValor.TabIndex = 4
        Me.LblValor.Text = "Valor"
        '
        'Guna2VTrackBar1
        '
        Me.Guna2VTrackBar1.DisplayFocus = True
        Me.Guna2VTrackBar1.FillColor = System.Drawing.Color.Blue
        Me.Guna2VTrackBar1.HoverState.Parent = Me.Guna2VTrackBar1
        Me.Guna2VTrackBar1.Location = New System.Drawing.Point(13, 16)
        Me.Guna2VTrackBar1.MouseWheelBarPartitions = 5
        Me.Guna2VTrackBar1.Name = "Guna2VTrackBar1"
        Me.Guna2VTrackBar1.Size = New System.Drawing.Size(23, 102)
        Me.Guna2VTrackBar1.TabIndex = 0
        Me.Guna2VTrackBar1.ThumbColor = System.Drawing.Color.DarkBlue
        Me.Guna2VTrackBar1.Value = 0
        '
        'Btfixar
        '
        Me.Btfixar.CheckedState.Parent = Me.Btfixar
        Me.Btfixar.CustomImages.Parent = Me.Btfixar
        Me.Btfixar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btfixar.ForeColor = System.Drawing.Color.White
        Me.Btfixar.HoverState.Parent = Me.Btfixar
        Me.Btfixar.Location = New System.Drawing.Point(71, 10)
        Me.Btfixar.Name = "Btfixar"
        Me.Btfixar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Btfixar.ShadowDecoration.Parent = Me.Btfixar
        Me.Btfixar.Size = New System.Drawing.Size(45, 27)
        Me.Btfixar.TabIndex = 1
        Me.Btfixar.Text = "Fixar"
        '
        'BtDesfixar
        '
        Me.BtDesfixar.CheckedState.Parent = Me.BtDesfixar
        Me.BtDesfixar.CustomImages.Parent = Me.BtDesfixar
        Me.BtDesfixar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtDesfixar.ForeColor = System.Drawing.Color.White
        Me.BtDesfixar.HoverState.Parent = Me.BtDesfixar
        Me.BtDesfixar.Location = New System.Drawing.Point(64, 49)
        Me.BtDesfixar.Name = "BtDesfixar"
        Me.BtDesfixar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtDesfixar.ShadowDecoration.Parent = Me.BtDesfixar
        Me.BtDesfixar.Size = New System.Drawing.Size(59, 30)
        Me.BtDesfixar.TabIndex = 2
        Me.BtDesfixar.Text = "Desfixar"
        '
        'BTminimizar
        '
        Me.BTminimizar.CheckedState.Parent = Me.BTminimizar
        Me.BTminimizar.CustomImages.Parent = Me.BTminimizar
        Me.BTminimizar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTminimizar.ForeColor = System.Drawing.Color.White
        Me.BTminimizar.HoverState.Parent = Me.BTminimizar
        Me.BTminimizar.Location = New System.Drawing.Point(62, 90)
        Me.BTminimizar.Name = "BTminimizar"
        Me.BTminimizar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTminimizar.ShadowDecoration.Parent = Me.BTminimizar
        Me.BTminimizar.Size = New System.Drawing.Size(62, 41)
        Me.BTminimizar.TabIndex = 3
        Me.BTminimizar.Text = "Minimizar"
        '
        'FrmVolume
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(131, 145)
        Me.Controls.Add(Me.BTminimizar)
        Me.Controls.Add(Me.BtDesfixar)
        Me.Controls.Add(Me.Btfixar)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVolume"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Volume"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2VTrackBar1 As Guna.UI2.WinForms.Guna2VTrackBar
    Friend WithEvents Btfixar As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents LblValor As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BtDesfixar As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTminimizar As Guna.UI2.WinForms.Guna2CircleButton
End Class
