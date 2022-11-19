Public Class Form8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fr As New Form9
        fr.Show()
        Me.Hide()
        If radioB_correcto_3.Checked = True Then
            puntaje_3 += 1
        Else
            puntaje_3 = 0
        End If
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        puntaje_3 = 0
        If radioB_4.Checked = False And radioB_correcto_3.Checked = False And RadioButton5.Checked = False Then
            Button1.Enabled = False
        End If
        Timer1.Start()

    End Sub

    Private Sub radioB_4_CheckedChanged(sender As Object, e As EventArgs) Handles radioB_4.CheckedChanged
        If radioB_4.Checked = True Then
            Button1.Enabled = True
        End If
    End Sub

    Private Sub radioB_correcto_3_CheckedChanged(sender As Object, e As EventArgs) Handles radioB_correcto_3.CheckedChanged
        If radioB_correcto_3.Checked = True Then
            Button1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lab_time.Text = time
    End Sub
End Class