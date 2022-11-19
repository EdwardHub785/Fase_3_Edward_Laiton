Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fr8 As New Form8
        fr8.Show()
        Me.Hide()
        If radioB_correcto_2.Checked = True Then
            puntaje_2 += 1
        Else
            puntaje_2 = 0
        End If
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        puntaje_2 = 0
        If RadioButton4.Checked = False And radioB_correcto_2.Checked = False And RadioButton6.Checked = False Then
            Button1.Enabled = False
        End If
        Timer1.Start()

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            Button1.Enabled = True
        End If
    End Sub

    Private Sub radioB_correcto_2_CheckedChanged(sender As Object, e As EventArgs) Handles radioB_correcto_2.CheckedChanged
        If radioB_correcto_2.Checked = True Then
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