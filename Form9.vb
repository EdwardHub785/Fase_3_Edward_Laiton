Public Class Form9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fr As New Form10
        fr.Show()
        Me.Hide()
        If radioB_correcto_4.Checked = True Then
            puntaje_4 += 1
        Else
            puntaje_4 = 0
        End If
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        puntaje_4 = 0
        If RadioButton5.Checked = False And radioB_correcto_4.Checked = False And RadioButton6.Checked = False Then
            Button1.Enabled = False
        End If
        Timer1.Start()

    End Sub

    Private Sub radioB_correcto_4_CheckedChanged(sender As Object, e As EventArgs) Handles radioB_correcto_4.CheckedChanged
        If radioB_correcto_4.Checked = True Then
            Button1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            Button1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lab_time.Text = time
    End Sub
End Class