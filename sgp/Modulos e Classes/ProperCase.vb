Module ProperCase

    Friend Sub TextBoxUppercaseFirstLetters(sender As Object, e As EventArgs)
        Try
            Dim tb = DirectCast(sender, TextBox)  'CType(sender, TextBox) ' se o objeto for uma textbox
            Dim s = tb.Text                      ' a string ou palavra da textbox que será convertida


            Dim cursorPos = tb.SelectionStart        'Variavel que definira onde o cursor vai posicionar dentro da textbox


            Dim wb = (" ,;:.'""" & vbCrLf).ToCharArray()

            Dim t = ""



            For i = 0 To s.Length - 1  'meu contador vai contar de 0 até o q etsa na e, todo o comprimento da textbox

                If i = 0 Then  ' condição se for o primeioro caractere
                    t = CStr(s(i)).ToUpper()   ' Minha variavel localm do tipo string 't' vai receber uma conversão em maiusculo

                Else  ' se não for = a 0 then    

                    If wb.Contains(s(i - 1)) Then
                        t &= CStr(s(i)).ToUpper()
                    Else
                        t &= s(i)
                    End If

                End If
            Next

            tb.Text = t
            tb.SelectionStart = cursorPos


            'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            '    AddHandler TextBox1.TextChanged, AddressOf TextBoxUppercaseFirstLetters

            'End Sub
        Catch ex As Exception

        End Try
    End Sub

End Module
