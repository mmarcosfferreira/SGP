Module LIMPARTODASTEXTBOX
    Public Sub LIMPARTODASTEXTBOX(ByVal ControlP_TextBox As Control, ByVal Optional CB As ComboBox = Nothing,
                                ByVal Optional LBL1 As Label = Nothing, ByVal Optional LBL2 As Label = Nothing)

        Dim CT As Control

        For Each CT In ControlP_TextBox.Controls
            If TypeOf CT Is TextBox Then

                DirectCast(CT, TextBox).Text = String.Empty

            ElseIf TypeOf CT Is ComboBox Then
                DirectCast(CT, ComboBox).Text = String.Empty

            ElseIf TypeOf LBL1 Is Label Then
                'DirectCast(CT, Label).Text = String.Empty
                'CType(CT, Label).Text = String.Empty

            ElseIf TypeOf LBL2 Is Label Then
                DirectCast(CT, Label).Text = String.Empty

            ElseIf CT.Controls.Count > 0 Then

                LIMPARTODASTEXTBOX(CT, CB, LBL1)
                CT.Text = String.Empty
                'CB.Text = String.Empty
                ' LBL1.Text = If(LBL1 Is Nothing = True, Nothing, "") ' String.Empty
                'LBL2.Text = ""  ' String.Empty
            End If

        Next
    End Sub
End Module
