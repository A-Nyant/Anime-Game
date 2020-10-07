Public Class frmDGM
    Dim This As New ChangePlace
    Dim strChara(23) As String
    Dim Player As Boolean
    Dim k As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Me.Hide()
        This.Buttons(lstChara.SelectedItem, Me)
        'lstChara.Items.Remove(lstChara.SelectedItem)
        If lstChara.Items.Count = 0 Then
            FrmActualGame.mnuDGrayMan.Visible = False
            If FrmActualGame.mnuDGrayMan.Visible = False And FrmActualGame.mnuDanganRonpa.Visible = False And FrmActualGame.mnuDragonBall.Visible = False And FrmActualGame.mnuDurarara.Visible = False Then
                FrmActualGame.mnuH.Visible = False
            End If
            Me.Close()
        End If
    End Sub

    Private Sub DGM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For k = 0 To lstChara.Items.Count - 1
            strChara(k) = lstChara.Items(k)
        Next
        'lstChara.Items.Remove(strChara(1)) 'Apocryphos missing for now
        'lstChara.Items.Remove(strChara(12)) 'Malcolm is gone for now
        'lstChara.Items.Remove(strChara(7)) 'Link is gone for now
    End Sub

    Public Sub GamePlay(Now_idle As Object, Now_Dist As Object, Opp_Idle As Object, Opp_Dist As Object, num As Integer)
        'Allen, Apocryphos, Krory, Bak, Bookman, Cross, David, Link, Jasdero, Komui, Lavi, Lenalee, Malcolm, Mana, Earl, Mirando, Nea, Road, Skin, Heart, Timcanpy. Tyki, Kanda
        Dim chara As String = lstChara.SelectedItem
        Select Case lstChara.SelectedItem
            Case strChara(0) 'Allen
                If Now_idle.Items.Contains(strChara(22)) Then 'They have lavi
                    This.add_2C_1D(Now_idle, Now_idle, Now_Dist, strChara(0), strChara(22))
                ElseIf Opp_Idle.Items.Contains(strChara(22)) Then
                    This.add_2C_1D(Now_idle, Opp_Idle, Now_Dist, strChara(0), strChara(22))
                End If

                If Opp_Idle.Items.contains(strChara(16)) Then 'Other has Allen
                    This.add(Now_idle, Opp_Idle, strChara(16)) 'Nea moves to the other side
                End If


            Case strChara(1) 'Apocryphos
                If Opp_Idle.items.contains(strChara(5)) Then
                    Opp_Idle.items.Remove(strChara(5))
                ElseIf Opp_Dist.Items.Contains(strChara(5)) Then
                    Opp_Dist.items.remove(strChara(5))
                ElseIf Now_idle.items.Contains(strChara(5)) Then
                    Now_idle.items.Remove(strChara(5))
                ElseIf Now_Dist.items.Contains(strChara(5)) Then
                    Now_Dist.items.Remove(strChara(5))
                Else
                    lstChara.Items.Remove(strChara(5))
                End If
                MessageBox.Show("Cross has gone Missing")

            Case strChara(2) 'Krory

            Case strChara(3) 'They have Bak
                If Now_idle.Items.Contains(strChara(11)) Then 'Now player has Lenalee
                    This.add(Now_Dist, Now_idle, strChara(3)) 'Bak is dist
                ElseIf Opp_Idle.Items.contains(strChara(11)) Then 'Other player has Lenalee
                    This.add(Opp_Dist, Now_idle, strChara(3)) 'Bak moves to other side and is dist
                End If

            Case strChara(5) 'Cross

            Case strChara(6) 'David

            Case strChara(7) 'Link
                If Now_Dist.items.contains(strChara(0)) Then
                    This.add(Now_Dist, Now_idle, strChara(7))
                ElseIf Opp_Idle.items.Contains(strChara(0)) Then
                    This.add(Opp_Idle, Now_idle, strChara(7))
                ElseIf Opp_Dist.items.Contains(strChara(0)) Then
                    This.add(Opp_Dist, Now_idle, strChara(7))
                End If


            Case strChara(8) 'Jasdero

            Case strChara(9) 'They picked Komui Lee
                If Opp_Idle.items.contains(strChara(11)) Then 'Other has Lenalee
                    This.add(Opp_Idle, Now_idle, strChara(9)) 'Komui Moves to Lenalee
                End If
            Case strChara(10) 'Lavi
                If Now_idle.Items.Contains(strChara(22)) Then 'They have lavi
                    This.add_2C_1D(Now_idle, Now_idle, Now_Dist, strChara(10), strChara(22))
                ElseIf Opp_Idle.Items.Contains(strChara(22)) Then
                    This.add_2C_1D(Now_idle, Opp_Idle, Now_Dist, strChara(10), strChara(22))
                End If
            Case strChara(11) 'Lenalee

            Case strChara(12) 'They picked Malcolm C. Rouvelier
                lstChara.Items.Add(strChara(7)) 'Link is added to the list

                If Now_idle.items.contains(strChara(1)) Or Now_Dist.Items.Contains(strChara(1)) Or Opp_Idle.items.contains(strChara(1)) Or Opp_Dist.items.Contains(strChara(1)) Then 'Apocryphos is here
                    If Now_idle.items.contains(strChara(5)) Then 'They have Cross
                        Now_idle.items.remove(strChara(5))
                        FrmActualGame.Ex_Point(num) = FrmActualGame.Ex_Point(num) + 2
                    ElseIf Now_Dist.items.contains(strChara(5)) Then 'They have Cross
                        Now_Dist.items.remove(strChara(5))
                        FrmActualGame.Ex_Point(num) = FrmActualGame.Ex_Point(num) + 2
                    ElseIf Opp_Dist.Items.contains(strChara(5)) Then 'Other has Cross
                        Opp_Dist.items.Remove(strChara(5))
                        FrmActualGame.Ex_Point(num) = FrmActualGame.Ex_Point(num) + 2
                    ElseIf Opp_Idle.items.Contains(strChara(5)) Then 'Other has cross
                        Opp_Idle.Items.Remove(strChara(5))
                        FrmActualGame.Ex_Point(num) = FrmActualGame.Ex_Point(num) + 2
                    Else
                        lstChara.Items.Remove(strChara(5))
                        FrmActualGame.Ex_Point(num) = FrmActualGame.Ex_Point(num) + 2
                    End If
                    MessageBox.Show("Cross has gone missing")
                End If


            Case strChara(13) 'Mana

            Case strChara(15) 'Miranda

            Case strChara(16) 'Nea
                lstChara.Items.Add(strChara(12)) 'Malcolm is add to the list

                If Opp_Idle.Items.contains(strChara(0)) Then 'Other has Allen
                    This.add(Opp_Idle, Now_idle, strChara(16)) 'Nea moves to the other side
                ElseIf Opp_Dist.Items.Contains(strChara(0)) Then
                    This.add(Opp_Dist, Now_idle, strChara(16)) 'Nea moves to the other side
                ElseIf Now_Dist.Items.Contains(strChara(0)) Then
                    This.add(Now_Dist, Now_idle, strChara(16))
                End If


            Case strChara(17) 'Road

            Case strChara(18) 'Skin
                If Now_idle.items.contains(strChara(22)) Or Now_Dist.Items.Contains(strChara(22)) Or Opp_Dist.Items.Contains(strChara(22)) Or Opp_Idle.Items.Contains(strChara(22)) Then 'They have Kanda
                    Now_idle.Items.Remove(strChara(18)) 'Skin is killed
                    FrmActualGame.battle(Me, FrmActualGame.mnuDGrayMan, "Kanda has Killed Skin")
                    FrmActualGame.Ex_Point(1) = FrmActualGame.Ex_Point(1) + 2
                    MessageBox.Show("There is a battle between Kanda and Skin")
                End If


            Case strChara(19) 'They pick the heart
                lstChara.Items.Add(strChara(1)) 'Apocryphos arrives


            Case strChara(20) 'They pick Timcanpy
                If Opp_Idle.items.Contains(strChara(0)) Then 'Other has allen
                    This.add(Opp_Idle, Now_idle, strChara(20)) 'Timcapny goes to Allen
                ElseIf Opp_Dist.items.Contains(strChara(0)) Then 'Other has allen
                    This.add(Opp_Idle, Now_idle, strChara(20)) 'Timcanpy goes to allen
                ElseIf Opp_Idle.items.Contains(strChara(5)) Then 'Other has Cross
                    This.add(Opp_Idle, Now_idle, strChara(20)) 'Timcanpy goes to Cross
                ElseIf Opp_Dist.Items.Contains(strChara(5)) Then 'Other has Cross
                    This.add(Opp_Idle, Now_idle, strChara(20))  'Timcanpy goes to Allen
                End If

            Case strChara(22) 'They have Kanda
                If Now_idle.items.Contains(strChara(18)) Then 'They have Skin
                    Now_idle.items.remove(strChara(18)) 'Skin is killed
                    FrmActualGame.battle(Me, FrmActualGame.mnuDGrayMan, "Kanda has Killed Skin")
                    FrmActualGame.Ex_Point(1) = FrmActualGame.Ex_Point(1) + 2
                    MessageBox.Show("There is a battle between Kanda and Skin")
                ElseIf Opp_Idle.Items.Contains(strChara(18)) Then
                    Opp_Idle.Items.Remove(strChara(18))
                    FrmActualGame.battle(Me, FrmActualGame.mnuDGrayMan, "Kanda has Killed Skin")
                    FrmActualGame.Ex_Point(1) = FrmActualGame.Ex_Point(1) + 2
                    MessageBox.Show("There is a battle between Kanda and Skin")
                End If

                If Now_idle.Items.Contains(strChara(10)) Then 'They have lavi
                    This.add_2C_1D(Now_idle, Now_idle, Now_Dist, strChara(22), strChara(10))
                ElseIf Opp_Idle.Items.Contains(strChara(10)) Then
                    This.add_2C_1D(Now_idle, Opp_Idle, Now_Dist, strChara(22), strChara(10))
                End If

                If Now_idle.Items.Contains(strChara(0)) Then 'They have Allen
                    This.add_2C_1D(Now_idle, Now_idle, Now_Dist, strChara(22), strChara(0))
                ElseIf Opp_Idle.Items.Contains(strChara(0)) Then
                    This.add_2C_1D(Now_idle, Opp_Idle, Now_Dist, strChara(22), strChara(0))
                End If



        End Select
    End Sub


    Private Sub lstChara_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstChara.SelectedIndexChanged
        ShowChara()
    End Sub


    Sub ShowChara()
        Select Case lstChara.SelectedItem()
            Case strChara(0)
                picMain.Image = picAllen.Image
            Case strChara(1)
                picMain.Image = picApocryphos.Image
            Case strChara(2)
                picMain.Image = picKrory.Image
            Case strChara(3)
                picMain.Image = picBak.Image
            Case strChara(4)
                picMain.Image = picBookman.Image
            Case strChara(5)
                picMain.Image = picCross.Image
            Case strChara(6)
                picMain.Image = picDevit.Image
            Case strChara(7)
                picMain.Image = picLink.Image
            Case strChara(8)
                picMain.Image = picJasdero.Image
            Case strChara(9)
                picMain.Image = picKomui.Image
            Case strChara(10)
                picMain.Image = picLavi.Image
            Case strChara(11)
                picMain.Image = picLenalee.Image
            Case strChara(12)
                picMain.Image = picMalcolm.Image
            Case strChara(13)
                picMain.Image = picMana.Image
            Case strChara(14)
                picMain.Image = picEarl.Image
            Case strChara(15)
                picMain.Image = picMiranda.Image
            Case strChara(16)
                picMain.Image = PicNea.Image
            Case strChara(17)
                picMain.Image = picRoad.Image
            Case strChara(18)
                picMain.Image = picSkin.Image
            Case strChara(19)
                picMain.Image = picHeart.Image
            Case strChara(20)
                picMain.Image = picTimcanpy.Image
            Case strChara(21)
                picMain.Image = picTyki.Image
            Case strChara(22)
                picMain.Image = picKanda.Image
        End Select
    End Sub
End Class