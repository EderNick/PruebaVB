Public Class frmHolaMundo

    Private Sub btnPulsa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPulsa.Click
        If txtNombre.Text <> "" Then
            MsgBox("Hola Mundo, mi nombre es: " & txtNombre.Text, MsgBoxStyle.Exclamation, Me.Text)
        Else
            MsgBox("Ingresa un nombre primero ¬¬'", MsgBoxStyle.Exclamation, Me.Text)
        End If
    End Sub
End Class
