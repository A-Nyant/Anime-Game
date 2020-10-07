Public Class frmAnimeP1

    Dim Anime(1, 34) As String
    Dim Player As Integer = 0
    Dim This As New ChangePlace

    'Add The shows to the wanted list
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAddP1.Click
        If cboShow.SelectedIndex = -1 Then
            MessageBox.Show("Please pick an Anime")
        Else
            This.add(lstWant, cboShow, cboShow.SelectedItem)
        End If
    End Sub



    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btnDeleteP1.Click
        If lstWant.SelectedIndex = -1 Then
            MessageBox.Show("Please pick an Anime")
        Else
            This.add(cboShow, lstWant, lstWant.SelectedItem)
        End If
    End Sub



    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDoneP1.Click
        Dim K As Integer 'Delcares a variable
        If lstWant.Items.Count <> 0 Then
            If Player = 0 Then

                For K = 0 To lstWant.Items.Count - 1
                    Anime(Player, K) = lstWant.Items(K)
                Next

                Player = Player + 1

                ClearThis()

                Me.Hide() 'Hides this form
                Me.Show()

                lblPlayer1.Text = frmMainP1.txtNameP2.Text & ", please pick the Anime you wish to play with."


            Else


                For K = 0 To lstWant.Items.Count - 1
                    Anime(Player, K) = lstWant.Items(K)
                Next

                Compare()

                Me.Close()

                FrmActualGame.Show()
            End If
        Else
            MessageBox.Show("Please Pick A Show")
        End If

    End Sub



    Private Sub frmAnimeP1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblPlayer1.Text = frmMainP1.txtNameP1.Text & ", please pick the Anime you wish to play with." 'Tells which Player is first and tell them to pick their shows.

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddAll.Click
        Dim K As Integer
        For K = 0 To cboShow.Items.Count - 1
            lstWant.Items.Add(cboShow.Items(K))
        Next
        cboShow.Items.Clear()
    End Sub



    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If Player = 0 Then
            frmMainP1.Show()
            Me.Hide()
        Else
            Player = 0
            lblPlayer1.Text = frmMainP1.txtNameP1.Text & ", please pick the Anime you wish to play with."
            ClearThis()
            For k = 0 To Anime.Length - 1
                If Anime(Player, k) <> "" Then
                    lstWant.Items.Add(Anime(Player, k))
                    If cboShow.Items.Contains(Anime(Player, k)) Then
                        cboShow.Items.Remove(Anime(Player, k))
                    End If
                End If
            Next
        End If

    End Sub



    Sub ClearThis()
        Dim j As Integer

        For j = 0 To lstWant.Items.Count - 1
            cboShow.Items.Add(lstWant.Items(j))
        Next

        lstWant.Items.Clear()

    End Sub



    Sub Compare()

        Dim Same As String

        For k = 0 To 34
            For j = 0 To 34
                If Anime(1, k) <> "" Then
                    If Anime(1, k) = Anime(0, j) Then
                        track(Anime(1, k))
                        Same += ControlChars.CrLf & Anime(1, k)
                    End If
                End If
            Next
        Next

        MessageBox.Show("The anime is " & ControlChars.CrLf & Same)

    End Sub



    Sub track(why As String)
        Select Case True
            Case why.StartsWith("A")
                FrmActualGame.MnuA.Visible = True
            Case why.StartsWith("B")
                FrmActualGame.MnuB.Visible = True
            Case why.StartsWith("D")
                FrmActualGame.MnuD.Visible = True
            Case why.StartsWith("F")
                FrmActualGame.MnuF.Visible = True
            Case why.StartsWith("G")
                FrmActualGame.MnuG.Visible = True
            Case why.StartsWith("H")
                FrmActualGame.mnuH.Visible = True
            Case why.StartsWith("I")
                FrmActualGame.mnuI.Visible = True
            Case why.StartsWith("K")
                FrmActualGame.mnuK.Visible = True
            Case why.StartsWith("M")
                FrmActualGame.mnuM.Visible = True
            Case why.StartsWith("N")
                FrmActualGame.mnuN.Visible = True
            Case why.StartsWith("P")
                FrmActualGame.mnuP.Visible = True
            Case why.StartsWith("R")
                FrmActualGame.mnuR.Visible = True
            Case why.StartsWith("S")
                FrmActualGame.mnuS.Visible = True
        End Select

        Select Case why
            Case "Aldnoah.Zero"
                FrmActualGame.mnuAldnoahzero.Visible = True
            Case "Black Butler"
                FrmActualGame.mnuBlackButler.Visible = True
            Case "Blue Exorcist"
                FrmActualGame.mnuBlueExorcist.Visible = True
            Case "Boku No Hero Academia"
                FrmActualGame.mnuBokuNoHeroAcademia.Visible = True
            Case "Bungou Stray Dogs"
                FrmActualGame.mnuBungouStrayDogs.Visible = True
            Case "D.Gray-Man"
                FrmActualGame.mnuDGrayMan.Visible = True
            Case "Dangan Ronpa The Series"
                FrmActualGame.mnuDanganRonpa.Visible = True
            Case "Dragonball"
                FrmActualGame.mnuDragonBall.Visible = True
            Case "Durarara"
                FrmActualGame.mnuDurarara.Visible = True
            Case "Fairy Tail"
                FrmActualGame.mnuFairyTail.Visible = True
            Case "Fruit Basket"
                FrmActualGame.mnuFruitBasket.Visible = True
            Case "Fullmetal Alchemist"
                FrmActualGame.MnuFMA.Visible = True
            Case "Gintama"
                FrmActualGame.mnuGintama.Visible = True
            Case "Hetalia"
                FrmActualGame.mnuHetalia.Visible = True
            Case "Higurashi No Naku Koro NI"
                FrmActualGame.mnuHigurashi.Visible = True
            Case "Hitman Reborn"
                FrmActualGame.mnuHitmanReborn.Visible = True
            Case "Hunter x Hunter"
                FrmActualGame.mnuHunterxHunter.Visible = True
            Case "Inuyasha"
                FrmActualGame.mnuInuyasha.Visible = True
            Case "Kuroko No Basketball"
                FrmActualGame.mnuKnB.Visible = True
            Case "Maid-Sama"
                FrmActualGame.mnuMaidSama.Visible = True
            Case "Naruto"
                FrmActualGame.mnuNaruto.Visible = True
            Case "No.6"
                FrmActualGame.mnuNo6.Visible = True
            Case "Noragami"
                FrmActualGame.mnuNoragami.Visible = True
            Case "Pandora Hearts"
                FrmActualGame.mnuPandoraHearts.Visible = True
            Case "Re:Zero Kara Hajimeru Isekai Seikatsu"
                FrmActualGame.mnuReZero.Visible = True
            Case "Senyuu"
                FrmActualGame.mnuSenyuu.Visible = True
            Case "Seraph Of The End"
                FrmActualGame.mnuSeraph.Visible = True
            Case "Soul Eater"
                FrmActualGame.mnuSoulEater.Visible = True
        End Select

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearThis()
    End Sub
End Class