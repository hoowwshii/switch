Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nilai As Integer
        nilai = TextBox1.Text
        Dim ket As String

        Select Case nilai
            Case 90 To 100
                ket = "Lulus, A"
            Case 80 To 89
                ket = "Lulus, B"
            Case 70 To 79
                ket = "Lulus, C"
            Case 60 To 69
                ket = "Tidak Lulus, D"
            Case 0 To 59
                ket = "Tidak Lulus, F"
        End Select
        TextBox2.Text = ket
    End Sub
End Class