Imports System.Runtime.InteropServices

Public Class FrmVolume
    Private Sub BtDesfixar_Click(sender As Object, e As EventArgs) Handles BtDesfixar.Click
        Me.TopMost = False
    End Sub

    Private Sub Btfixar_Click(sender As Object, e As EventArgs) Handles Btfixar.Click
        Me.TopMost = True
    End Sub

    Private Sub BTSair_Click(sender As Object, e As EventArgs)
        Close()
    End Sub


    Private Sub FrmVolume_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If e.KeyChar = Chr(43) Then '+

            BTN_IncVol_Click(Me, e)

        Else
            If e.KeyChar = Chr(45) Then '-
                BTN_DecVol_Click(Me, e)
            Else
                If e.KeyChar = Chr(42) Then '*
                    BTN_Mute_Click(Me, e)
                End If
            End If
        End If



        If Guna2VTrackBar1.Value > TRACKANTERIOR Then
            For i = TRACKANTERIOR To Guna2VTrackBar1.Value
                SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)

                TRACKANTERIOR = Guna2VTrackBar1.Value
                LblValor.Text = "Valor " & i & "%"

            Next
            'LblValor.Text = "Valor " & Guna2VTrackBar1.Value & "%"
        End If

        If Guna2VTrackBar1.Value < TRACKANTERIOR Then
            For i = Guna2VTrackBar1.Value To TRACKANTERIOR
                SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)

                TRACKANTERIOR = Guna2VTrackBar1.Value
                LblValor.Text = "Valor " & i & "%"

            Next

        End If



        LblValor.Text = "Valor " & Guna2VTrackBar1.Value


    End Sub









    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function
    Const WM_APPCOMMAND As UInteger = &H319
    Const APPCOMMAND_VOLUME_UP As UInteger = &HA
    Const APPCOMMAND_VOLUME_DOWN As UInteger = &H9
    Const APPCOMMAND_VOLUME_MUTE As UInteger = &H8

    Dim TRACKANTERIOR As Integer = 0
    Dim BANDERA As Boolean = False
    Private Sub Guna2VTrackBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles Guna2VTrackBar1.Scroll

        If Guna2VTrackBar1.Value > TRACKANTERIOR Then
            For i = TRACKANTERIOR To Guna2VTrackBar1.Value
                SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)

                TRACKANTERIOR = Guna2VTrackBar1.Value
                LblValor.Text = "Valor " & i & "%"

            Next
            'LblValor.Text = "Valor " & Guna2VTrackBar1.Value & "%"
        End If

        If Guna2VTrackBar1.Value < TRACKANTERIOR Then
            For i = Guna2VTrackBar1.Value To TRACKANTERIOR
                SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)

                TRACKANTERIOR = Guna2VTrackBar1.Value
                LblValor.Text = "Valor " & i & "%"

            Next

        End If




    End Sub

    Private Sub Guna2VTrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2VTrackBar1.ValueChanged



        If Guna2VTrackBar1.Value > TRACKANTERIOR Then
            For i = TRACKANTERIOR To Guna2VTrackBar1.Value
                SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)

                TRACKANTERIOR = Guna2VTrackBar1.Value
                LblValor.Text = "Valor " & i & "%"

            Next
            'LblValor.Text = "Valor " & Guna2VTrackBar1.Value & "%"
        End If

        If Guna2VTrackBar1.Value < TRACKANTERIOR Then
            For i = Guna2VTrackBar1.Value To TRACKANTERIOR
                SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)

                TRACKANTERIOR = Guna2VTrackBar1.Value
                LblValor.Text = "Valor " & i & "%"

            Next

        End If



        LblValor.Text = "Valor " & Guna2VTrackBar1.Value


    End Sub

    Private Sub BTminimizar_Click(sender As Object, e As EventArgs) Handles BTminimizar.Click
        MinimizeBox = True
        Visible = False
    End Sub
End Class