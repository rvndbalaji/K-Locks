Public Class Strt


    Private Sub Panel1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseClick
        Me.Close()
    End Sub


    Private Sub timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer.Tick

        If Control.IsKeyLocked(Keys.CapsLock) Then

            c.BackColor = Color.FromArgb(0, 186, 16)

        Else
            c.BackColor = Color.FromArgb(30, 30, 30)
        End If


        If Control.IsKeyLocked(Keys.Scroll) Then

            s.BackColor = Color.FromArgb(0, 186, 16)

        Else
            s.BackColor = Color.FromArgb(30, 30, 30)
        End If


        If Control.IsKeyLocked(Keys.NumLock) Then

            n.BackColor = Color.FromArgb(0, 186, 16)

        Else
            n.BackColor = Color.FromArgb(30, 30, 30)
        End If

    End Sub

    Private Sub Strt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timer.Start()
    End Sub
End Class
