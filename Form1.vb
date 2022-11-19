Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fr As New Form3
        fr.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fr As New Form2
        fr.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fr As New Form5
        fr.Show()
        Me.Hide()
    End Sub

    Private Sub btn_13_Click(sender As Object, e As EventArgs) Handles btn_13.Click
        Dim fr As New Form6
        fr.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim fr As New Form11
        fr.Show()
        Me.Hide()
    End Sub
End Class