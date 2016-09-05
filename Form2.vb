Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LblMensaje.Text = "Usted pagó con éxito: S/."
    End Sub
End Class