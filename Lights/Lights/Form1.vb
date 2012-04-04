Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Lights on" Then
            Button1.Text = "Lights off"
            PictureBox1.Image = Lights.My.Resources.Resources.Light_on
        Else
            Button1.Text = "Lights on"
            PictureBox1.Image = Lights.My.Resources.Resources.Light_off
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs)

    End Sub
End Class
