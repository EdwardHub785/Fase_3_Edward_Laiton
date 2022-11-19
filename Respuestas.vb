Public Class respuestas
    Private Sub Respuestas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim contador_puntaje As Integer = 0
        If puntaje_1 = 1 Then
            TextBox1.Text = "Correcta"
            contador_puntaje += 1
        ElseIf puntaje_1 = 0 Then
            TextBox1.Text = "Incorrecta"
            Label6.Visible = True
            contador_puntaje -= 0
        End If
        If puntaje_2 = 1 Then
            TextBox2.Text = "Correcta"
            contador_puntaje += 1
        ElseIf puntaje_2 = 0 Then
            TextBox2.Text = "Incorrecta"
            Label8.Visible = True
            contador_puntaje -= 0
        End If
        If puntaje_3 = 1 Then
            TextBox3.Text = "Correcta"
            contador_puntaje += 1
        ElseIf puntaje_3 = 0 Then
            TextBox3.Text = "Incorrecta"
            Label9.Visible = True
            contador_puntaje -= 0
        End If
        If puntaje_4 = 1 Then
            TextBox4.Text = "Correcta"
            contador_puntaje += 1
        ElseIf puntaje_4 = 0 Then
            TextBox4.Text = "Incorrecta"
            Label10.Visible = True
            contador_puntaje -= 0
        End If
        If puntaje_6 = 1 Then
            TextBox5.Text = "Correcta"
            contador_puntaje += 1
        ElseIf puntaje_6 = 0 Then
            TextBox5.Text = "Incorrecta"
            Label11.Visible = True
            contador_puntaje -= 0
        End If
        If contador_puntaje = 5 Then
            MessageBox.Show("Felicitaciones Pasaste el Quiz obtuviste el 100% de tu nota sigue asi", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf contador_puntaje = 4 Then
            MessageBox.Show("Felicitaciones Pasaste el Quiz obtuviste el 80% de tu nota revisa algunos temas", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf contador_puntaje = 3 Then
            MessageBox.Show("Pasaste raspando el Quiz Obtuviste el 60% de tu nota estudia mas los temas", "Regular", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf contador_puntaje = 2 Then
            MessageBox.Show("Perdiste el Quiz Obtuviste el 40% de tu nota estudia mas no seas vago", "Mal", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf contador_puntaje = 1 Then
            MessageBox.Show("Perdiste el Quiz Obtuviste el 20% de tu nota esfuerzate mas", "Muy Mal", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf contador_puntaje = 0 Then
            MessageBox.Show("Perdiste el Quiz Obtuviste el 0% de tu nota estas perdido", "Re Mal", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fr As New Form1
        fr.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fr As New Form6
        fr.Show()
        Me.Hide()
        time = 180

    End Sub
End Class