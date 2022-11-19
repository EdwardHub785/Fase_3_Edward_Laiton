Imports System.ComponentModel

Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fr As New Form7
        fr.Show()
        Me.Hide()
        If radioB_correcto_1.Checked = True Then
            puntaje_1 += 1
        Else
            puntaje_1 = 0
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        puntaje_1 = 0
        If RadioButton1.Checked = False And radioB_correcto_1.Checked = False And RadioButton2.Checked = False Then
            Button1.Enabled = False
        End If
        Timer1.Start()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Button1.Enabled = True
        End If
    End Sub

    Private Sub radioB_correcto_1_CheckedChanged(sender As Object, e As EventArgs) Handles radioB_correcto_1.CheckedChanged
        If radioB_correcto_1.Checked = True Then
            Button1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Me.lab_time.Text = time
        time -= 1
        If time = 0 Then
            Timer1.Stop()
            MessageBox.Show("Se agoto su tiempo debes empezar de nuevo", "Limite de Tiempo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim frm As New Form6
            frm.Show()
            Me.Hide()
            time = 180
            If time = 300 Then
                Timer1.Stop()
            End If
        End If
    End Sub
End Class