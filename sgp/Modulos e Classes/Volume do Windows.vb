
Imports System
Imports System.Windows.Forms
Imports System.Runtime.InteropServices



'<DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
'End Function
'Const WM_APPCOMMAND As UInteger = &H319
'Const APPCOMMAND_VOLUME_UP As UInteger = &HA
'Const APPCOMMAND_VOLUME_DOWN As UInteger = &H9
'Const APPCOMMAND_VOLUME_MUTE As UInteger = &H8
'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
'    SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
'End Sub
'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
'    SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
'End Sub
'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
'    SendMessage(Me.Handle, WM_APPCOMMAND, &H200EB0, APPCOMMAND_VOLUME_MUTE * &H10000)
'End Sub

Module Volume_do_Windows

    Sub New()

    End Sub

    '<DllImport("winmm.dll", EntryPoint:="waveOutSetVolume")>
    'Public Function WaveOutSetVolume(hwo As IntPtr, Volume As UInteger) As Integer

    'End Function


    Private Const APPCOMMAND_VOLUME_MUTE As Integer = &H80000
    Private Const APPCOMMAND_VOLUME_UP As Integer = &HA0000
    Private Const APPCOMMAND_VOLUME_DOWN As Integer = &H90000
    Private Const WM_APPCOMMAND As Integer = &H319

    <DllImport("user32.dll")>
    Friend Function SendMessageW(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr,
                                 ByVal lParam As IntPtr) As IntPtr

    End Function

    Public Sub BTN_Mute_Click(ByVal sender As Object, ByVal e As EventArgs)
        SendMessageW(sender.Handle, WM_APPCOMMAND,
                      sender.Handle, New IntPtr(APPCOMMAND_VOLUME_MUTE))
    End Sub

    Public Sub BTN_DecVol_Click(ByVal sender As Object, ByVal e As EventArgs)
        SendMessageW(sender.Handle, WM_APPCOMMAND,
                     sender.Handle, New IntPtr(APPCOMMAND_VOLUME_DOWN))
    End Sub

    Public Sub BTN_IncVol_Click(ByVal sender As Object, ByVal e As EventArgs)
        SendMessageW(sender.Handle, WM_APPCOMMAND,
                     sender.Handle, New IntPtr(APPCOMMAND_VOLUME_UP))
    End Sub


    Public Sub TodosCanais()


        Dim WshShell = CreateObject("WScript.Shell")

        WshShell.Run("%SystemRoot%\System32\SndVol.exe")
        WshShell.AppActivate("Volume Mixer")

        WshShell.SendKeys("{PGUP}") ' Aumente o volume em 20. Se desativado, o som será desativado.
        WshShell.SendKeys("%{F4}") ' Alt+F4

    End Sub



End Module
