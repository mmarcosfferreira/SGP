Module TopMost_
    Public Sub TopMost_(ByVal Bt As Control, ByVal F As System.Windows.Forms.Form)

        If Bt IsNot Nothing AndAlso F.TopMost = False AndAlso F.Name = F.Name Then
            F.TopMost = True
            MsgBox("A função Top Most foi ativada")

        Else

            If Bt IsNot Nothing AndAlso F.TopMost = True AndAlso F.Name = F.Name Then
                MsgBox("A função Top Most foi Desativada")
                F.TopMost = False
            End If


        End If
    End Sub

End Module
