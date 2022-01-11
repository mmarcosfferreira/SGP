Module SONUMEROS
    Public Sub SONUMEROS(OBJ As Object, e As KeyPressEventArgs, Optional e2 As KeyEventArgs = Nothing)
        If (Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))) Then
            e.Handled = True

        End If


        'If Asc(e.KeyChar) = 3 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 22 Or Asc(e.KeyChar) = 24 Or Asc(e.KeyChar) = 44 Then
        '    Exit Sub
        'End If

        'If Not Char.IsNumber(e.KeyChar) Then
        '    e.Handled = True
        'End If

        'Na primeira linha, os números ASCII representam, CTRL + C, Backspace, CTRL + V, CTRL + X, e vírgula, respectivamente.
    End Sub

End Module
