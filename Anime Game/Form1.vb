Public Class frmMainP1


    'button to get the ball rolling
    Private Sub btnDoneP1_Click(sender As Object, e As EventArgs) Handles btnDoneP1.Click
        'Checks to make sure that the players input a name.
        If txtNameP1.Text = String.Empty Then
            MessageBox.Show("Player 1, Please pick a name and type it in")
        ElseIf txtNameP2.Text = String.Empty Then
            MessageBox.Show("Player 2 Please pick a name and type it in")
        Else
            'if so, then it will go to the next form
            Me.Hide()
            frmAnimeP1.Show()
        End If
    End Sub

    'This is a debug button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtNameP1.Text = "Afia"
        txtNameP2.Text = "Yaa"
        Me.Hide()
        FrmActualGame.Show()
        FrmActualGame.MnuB.Visible = True
        FrmActualGame.mnuBokuNoHeroAcademia.Visible = True
        FrmActualGame.mnuH.Visible = True
        FrmActualGame.mnuHetalia.Visible = True
        FrmActualGame.MnuD.Visible = True
        FrmActualGame.mnuDGrayMan.Visible = True

    End Sub
End Class
