Public Class Form11
    Dim numero() As Integer = {1, 2, 3}
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i As Integer = 0 To numero.Length

            Label1.Text = numero(i)

        Next
    End Sub
End Class