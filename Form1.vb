Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case TextBox1.Text
            Case "1"
                TextBox2.Text = "Senin"
            Case "2"
                TextBox2.Text = "Selasa"
            Case "3"
                TextBox2.Text = "Rabu"
            Case "4"
                TextBox2.Text = "Kamis"
            Case "5"
                TextBox2.Text = "Jumat"
            Case "6"
                TextBox2.Text = "Sabtu"
            Case "7"
                TextBox2.Text = "Minggu"
            Case Else
                TextBox2.Text = "Isi hari dengan benar, antara 1 - 7"
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
