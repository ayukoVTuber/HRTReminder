Public Class reminder
    Private Sub reminder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("C:\a\ambatukam.wav")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("good girl! keep it up <3")
        My.Computer.Audio.Stop()
        Me.Close()
    End Sub
End Class