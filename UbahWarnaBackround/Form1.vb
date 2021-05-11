Public Class Form1

    Private Sub RdMerah_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RdMerah.CheckedChanged, RdBiru.CheckedChanged, RdKuning.CheckedChanged, RdHijau.CheckedChanged, RdPutih.CheckedChanged, RdUngu.CheckedChanged
        If sender.text = "Merah" Then
            GbBox.BackColor = Color.Red
        ElseIf sender.text = "Biru" Then
            GbBox.BackColor = Color.Blue
        ElseIf sender.text = "Kuning" Then
            GbBox.BackColor = Color.Yellow
        ElseIf sender.text = "Hijau" Then
            GbBox.BackColor = Color.Green
        ElseIf sender.text = "Putih" Then
            GbBox.BackColor = Color.White
        ElseIf sender.text = "Ungu" Then
            GbBox.BackColor = Color.Violet
        End If
    End Sub
End Class
