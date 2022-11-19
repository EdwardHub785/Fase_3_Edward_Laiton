Public Class Form5

    Dim seno As Decimal
    Dim coseno As Decimal
    Dim tangente As Decimal
    Dim cotangente As Decimal
    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        seno = Math.Sin(txt_inp.Text)
        txt_seno.Text = Math.Round(seno, 7)
        lab_seno.Visible = True
        txt_seno.Visible = True
        coseno = Math.Cos(txt_inp.Text)
        txt_cos.Text = Math.Round(coseno, 7)
        lab_coseno.Visible = True
        txt_cos.Visible = True
        tangente = Math.Tan(txt_inp.Text)
        txt_tang.Text = Math.Round(tangente, 7)
        lab_tangente.Visible = True
        txt_tang.Visible = True
        cotangente = Math.Atan(txt_inp.Text)
        txt_ctan.Text = Math.Round(cotangente, 7)
        txt_ctan.Visible = True
        lab_Ctangente.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fr As New Form1
        fr.Show()
        Me.Hide()
    End Sub

    Private Sub txt_inp_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_inp.KeyUp
        If txt_inp.Text <> "" Then
            btn_calcular.Enabled = True
        End If
    End Sub

    Private Sub txt_inp_TextChanged(sender As Object, e As EventArgs) Handles txt_inp.TextChanged
        If txt_inp.Text = "" Then
            btn_calcular.Enabled = False
        End If
    End Sub
End Class