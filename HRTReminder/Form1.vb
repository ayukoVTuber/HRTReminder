Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        WindowState = FormWindowState.Minimized
        Me.Opacity = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = TimeOfDay.ToString("HH:mm:ss")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label2.Text = "08:00:00" Then
            reminder.Show()
        End If
        If Label2.Text = "16:00:00" Then
            reminder.Show()
        End If
        If Label2.Text = "00:00:00" Then
            reminder.Show()
        End If
    End Sub
End Class
