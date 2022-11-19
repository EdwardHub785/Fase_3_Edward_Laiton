Public Class pregunta5

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fr As New respuestas
        fr.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New Form6
        frm.Show()
        Me.Hide()
        time = 180
    End Sub

    Private Sub pregunta5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Stop()

    End Sub
End Class