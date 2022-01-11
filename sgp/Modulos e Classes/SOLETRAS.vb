Module SOLETRAS


    Public Sub SOLETRAS(ByVal OBJ As Object, e As KeyPressEventArgs, Optional e3 As KeyEventArgs = Nothing)

        'If Not Char.IsLetter(e.KeyChar) = True Or e.KeyChar = Chr(32) Or Char.IsControl(e.KeyChar) Then
        '    e.Handled = True
        'Else
        '    e.Handled = False
        'End If
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = "," And Not e.KeyChar = Chr(32) Then

            e.Handled = True

        End If

    End Sub

End Module
