Module ColocarFormularionoTopo

    Public Sub Topo(ByVal FRM As Form)
        FRM.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - FRM.Width) / 2)
        FRM.WindowState = FormWindowState.Normal
        FRM.StartPosition = FormStartPosition.Manual

    End Sub

    Public Sub Lado_Esquerdo_daTela(ByVal FRM As Form)
        FRM.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - FRM.Width), y:=160)
    End Sub

    Public Sub Chamadadeformularios(ByVal formulario As Form)
        formulario.Show()
    End Sub

    Public Sub ColocaFormularionoCentro(ByVal Formulario As Form)
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.WindowState = FormWindowState.Normal
    End Sub

End Module
