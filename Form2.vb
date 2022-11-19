Public Class Form2

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text <> "" Then
            TextBox1.Enabled = True
        End If
        If ComboBox1.Text = "Tiempo" Then
            TextBox4.Text = "En minutos"
        End If
        If ComboBox1.Text = "Distancia" Then
            TextBox4.Text = "En KM"
        End If
        If ComboBox1.Text = "Velocidad" Then
            TextBox4.Text = "En Km/H"
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text <> "" Then
            TextBox2.Enabled = True
        End If
        If ComboBox2.Text = "Tiempo" Then
            TextBox5.Text = "En minutos"
        End If
        If ComboBox2.Text = "Distancia" Then
            TextBox5.Text = "En KM"
        End If
        If ComboBox2.Text = "Velocidad" Then
            TextBox5.Text = "En Km/H"
        End If
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            Btn_1.Enabled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            Btn_1.Enabled = True
        End If
    End Sub

    Private Sub Btn_1_Click(sender As Object, e As EventArgs) Handles Btn_1.Click
        If ComboBox1.Text = "Velocidad" And ComboBox2.Text = "Velocidad" Then
            MessageBox.Show("No puedes escoger la misma variable", "No se acepta la misma variable", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ComboBox1.Text = "Tiempo" And ComboBox2.Text = "Tiempo" Then
            MessageBox.Show("No puedes escoger la misma variable", "No se acepta la misma variable", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ComboBox1.Text = "Distancia" And ComboBox2.Text = "Distancia" Then
            MessageBox.Show("No puedes escoger la misma variable", "No se acepta la misma variable", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If ComboBox1.Text = "Tiempo" And ComboBox2.Text = "Velocidad" Or ComboBox1.Text = "Velocidad" And ComboBox2.Text = "Tiempo" Then
            If ComboBox1.Text = "Tiempo" Or ComboBox2.Text = "Tiempo" Then
                Dim minutos As Double
                minutos = Val(TextBox1.Text) / 60
                Dim x As Double
                x = Val(TextBox2.Text)
                Dim distancia As Double = Math.Round(minutos * x)
                TextBox3.Text = "El vehiculo recorrio " & distancia & " Km"
            End If
        End If
        If ComboBox1.Text = "Tiempo" And ComboBox2.Text = "Distancia" Or ComboBox1.Text = "Distancia" And ComboBox2.Text = "Tiempo" Then
            If ComboBox1.Text = "Tiempo" Or ComboBox2.Text = "Tiempo" Then
                Dim minutos As Double
                minutos = Val(TextBox1.Text) / 60
                Dim x As Double
                x = Val(TextBox2.Text)
                Dim recorrido As Double = Math.Round(x / minutos)
                TextBox3.Text = "Velocidad del recorrido " & recorrido & " Km/h"
            End If
        End If
        If ComboBox1.Text = "Distancia" And ComboBox2.Text = "Velocidad" Or ComboBox1.Text = "Velocidad" And ComboBox2.Text = "Distancia" Then
            If ComboBox1.Text = "Distancia" Or ComboBox2.Text = "Distancia" Then
                Dim minutos As Double
                minutos = Val(TextBox1.Text) * 60
                Dim x As Double
                x = Val(TextBox2.Text)
                Dim tiempo As Double = Math.Round(minutos / x, 1)
                TextBox3.Text = "Tiempo del recorrido " & tiempo & " Minutos"
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form1 As New Form1
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class