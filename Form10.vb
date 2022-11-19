Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        puntaje_6 = 0
        If RadioButton1.Checked = False And RadioButton2.Checked = False And radioB_correcto_1.Checked = False Then
            Button1.Enabled = False
        End If
        Timer1.Start()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New pregunta5
        frm.Show()
        Me.Hide()
        If radioB_correcto_1.Checked = True Then
            puntaje_6 += 1
        Else
            puntaje_6 = 0
        End If
        time = 300
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Button1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Button1.Enabled = True
        End If
    End Sub

    Private Sub radioB_correcto_1_CheckedChanged(sender As Object, e As EventArgs) Handles radioB_correcto_1.CheckedChanged
        If radioB_correcto_1.Checked = True Then
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lab_time.Text = time
    End Sub
End Class