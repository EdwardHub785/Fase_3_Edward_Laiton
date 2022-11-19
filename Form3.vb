Public Class Form3
    Dim intento As Integer
    Dim nombre As String
    Dim contar As Integer
    Dim time As Integer

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        intento += 1

        If txt_usuario.Text = "Edward" And txt_contraseña.Text = "123" Then
            Dim frm As New Form4
            frm.Show()
            Me.Hide()
            Timer1.Stop()
        Else
            txt_contraseña.Text = ""
            txt_usuario.Text = ""
            lab_error.Visible = True
            MessageBox.Show("Datos errados  " & nombre & "  Intento  " & intento & "  de 3", "Verifica", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If intento = 2 Then
                MessageBox.Show("Te queda solo un intento " & nombre, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            If intento = 3 Then
                MessageBox.Show("haz agotado el numero de intentos vuelve a intentarlo en un minuto " & nombre, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                intento = 0
                txt_contraseña.Visible = False
                txt_usuario.Visible = False
                Label1.Visible = False
                Label2.Visible = False
            End If
        End If
        If txt_contraseña.Text = "" Or txt_usuario.Text = "" Then
            btn_ingresar.Enabled = False
        End If

        If intento = 1 Then
            Timer1.Start()
            lab_tem.Text = time
            Label3.Visible = True
            Label4.Visible = True
        End If

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intento = 0
        contar = 1
        time = 60
        While contar <= 1
            nombre = InputBox("Hola digita tu nombre", "bienvenido")
            If nombre = "" Then
                MessageBox.Show("No puedes dejer el campo vacio", "Debes poner tu nombre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                contar += 1
            End If
        End While

    End Sub
    Private Sub txt_usuario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_usuario.Validating
        If txt_usuario.Text = "" Then
            Me.error_p.SetError(sender, "Campo Obligatorio")
        End If
    End Sub
    Private Sub txt_contraseña_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_contraseña.Validating
        If txt_contraseña.Text = "" Then
            Me.error_p.SetError(sender, "Campo Obligatorio")
        End If

    End Sub
    Private Sub txt_contraseña_TextChanged(sender As Object, e As EventArgs) Handles txt_contraseña.TextChanged
        If txt_contraseña.Text <> "" Then
            error_p.Clear()
        End If
        lab_error.Visible = False
        If txt_contraseña.Text <> "" And txt_usuario.Text <> "" Then
            btn_ingresar.Enabled = True
        End If
    End Sub

    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged
        If txt_usuario.Text <> "" Then
            error_p.Clear()
        End If
        lab_error.Visible = False
        If txt_usuario.Text <> "" And txt_contraseña.Text <> "" Then
            btn_ingresar.Enabled = True
        End If

    End Sub

    Private Sub txt_usuario_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_usuario.KeyUp
        If txt_usuario.Text = "" Then
            btn_ingresar.Enabled = False
        End If
    End Sub

    Private Sub txt_contraseña_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_contraseña.KeyUp
        If txt_contraseña.Text = "" Then
            btn_ingresar.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time -= 1
        Me.lab_tem.Text = time
        If time = 0 Then
            txt_contraseña.Visible = False
            txt_usuario.Visible = False
            Timer1.Stop()
            MsgBox("Se agoto su tiempo")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fr As New Form1
        fr.Show()
        Me.Hide()
    End Sub
End Class