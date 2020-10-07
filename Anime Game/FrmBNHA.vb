Imports System.Windows.Forms
Public Class FrmBNHA
    Dim ET(100) As Integer
    Dim strChara(61) As String
    Dim PlayChara(61) As Integer

    Private Sub FrmBNHA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim k As Integer
        For k = 0 To strChara.Count - 1
            strChara(k) = lstBNHA_Chara.Items(k)
            Debug.Print(strChara(k))
        Next
    End Sub
    Private Sub btnGo_P1_Click(sender As Object, e As EventArgs) Handles btnGo_P1.Click
        Me.Hide()
        FrmActualGame.lstP1_Chara_Idle.Items.Add(lstBNHA_Chara.SelectedItem)
        Actual_gameplayP1()
        lstBNHA_Chara.Items.Remove(lstBNHA_Chara.SelectedItem)
        'FrmActualGame.p2Buttons()
    End Sub

    Private Sub btnGo_P2_Click(sender As Object, e As EventArgs) Handles btnGo_P2.Click
        FrmActualGame.lstP2_Chara_Idle.Items.Add(lstBNHA_Chara.SelectedItem)
        gameplay()
        Me.Hide()
        lstBNHA_Chara.Items.Remove(lstBNHA_Chara.SelectedItem)
        'FrmActualGame.P1Buttons()
    End Sub

    Sub gameplay()

        'Select Case lstBNHA_Chara.SelectedItem()
        'Case "Midoriya"
        'Select Case True
        'Case FrmActualGame.lstP2_Chara_Idle.Items.Contains("Bakugo")
        'MessageBox.Show("DEKU")
        'Case FrmActualGame.lstP2_Chara_Idle.Items.Contains("Todoroki")
        '
        'Case FrmActualGame.lstP2_Chara_Idle.Items.Contains("Kota Izumi")
        'And If one of them has Muscular, then there will be a fight between the two.
        'Case FrmActualGame.lstP2_Chara_Idle.Items.Contains("Stain, The hero Killer")
        '           'If one of them has todoroki and Lida, then they will fight
        'Case FrmActualGame.lstP2_Chara_Idle.Items.Contains("Mr.Compress")
        'If they have Midoriya, Todoroki, Shoji and Bakugo
        'Case FrmActualGame.lstP2_Chara_Idle.Items.Contains("Mirio")
        'IF all of class 1-a is there, they will fight.
        'Case FrmActualGame.lstP2_Chara_Idle.Items.Contains("Shinso")
        'They will fight for a bit.
        'Case FrmActualGame.lstP2_Chara_Idle.Items.Contains("Thirthen")
        'If they have the warp Gate, Then they will be distracted
        'Case FrmActualGame.lstP2_Chara_Idle.Items.Contains("Gran Torino")
        'They train for a bit.
        'Case FrmActualGame.lstP2_Chara_Idle.Items.Contains("Noumu")
        'They are distracted until All Might is there.
        'Case FrmActualGame.lstP2_Chara_Idle.Items.Contains("Himiko")
        'She is distracted only
        'Case FrmActualGame.lstP2_Chara_Idle.Items.Contains("Mustard")
        'Most of class 1 and 2 are distracted, until the two who beat him are there.

        'End Select
        'End Select
        'If FrmActualGame.lstP1_Chara_Idle.Items.Contains("Midoriya") Then


        'End If
    End Sub

    Private Sub tmrDekuvTodo_Tick(sender As Object, e As EventArgs) Handles tmrDekuvTodo.Tick
        'If FrmActualGame.lstP1_Chara_Idle.Items.Contains("Midoriya") And FrmActualGame.lstP2_Chara_Idle.Items.Contains("Todoroki") Then
        'FrmActualGame.lstP1_Chara_Dist.Items.Add("Midoriya")
        'FrmActualGame.lstP1_Chara_Dist.Items.Add("Todoroki")
        'FrmActualGame.lstP1_Chara_Idle.Items.Remove("Midoriya")
        'FrmActualGame.lstP2_Chara_Idle.Items.Remove("Todoroki")


        'End If
    End Sub

    Sub Actual_gameplayP1()

        Select Case lstBNHA_Chara.SelectedItem
            Case strChara(23) 'Kota Izumi
                PlayChara(23) = 1
                If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(18)) Or FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(18)) Then ' If They has Midoriya

                    If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(35)) Then 'If player 1 has Muscular
                        FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(35)) 'Muscular is removed from Player 1
                        FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(35)) 'Muscular is Added to p1 Dist list
                    ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(35)) Then 'If player 2 has Muscular
                        FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(35)) 'He is removed from player 2 list
                        FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(35)) 'He is added to Player 1 list
                    End If
                Else ' If Niether had Midoriya
                    If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(35)) Then 'If player 1 has Muscular
                        FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(35)) 'Muscular is removed from player 1 list
                        FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(23)) ' Removes Kota from Player 1 Idle list
                        FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(35)) 'He is added to player 1 list
                        FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(23)) ' Add Kota to Player 1 Distracted List
                    ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(35)) Then ' If player 2 has Muscular
                        FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(35)) 'Muscular is removed from p2 list
                        FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(23)) 'Kota removed from p1 list
                        FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(35)) 'Muscular add p1 list
                        FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(23)) 'Muscular add p1 list
                    End If
                End If

            Case strChara(4) ' Player 1 picks Stain
                PlayChara(23) = 1
                'If Ingenium is There
                If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(50)) Then 'Player 1 has Ingenium
                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(50)) 'Ingenium removed from p1 list
                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(50)) 'Ingenium added to p1 list
                    MessageBox.Show("Great, He Can't Walk Now")
                ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(50)) Then 'Player 2 has Ingenium
                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(50)) 'Ingenium removed from p2 list
                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(50)) 'Ingenium added to p1 list
                    MessageBox.Show("Great, He Can't Walk Now")
                End If

                'If Midoriya, Lida,  or Todoroki is there
                If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(51)) Then 'P1 has Lida
                    If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(18)) Then ' if player 1 has midoriya
                        If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(47)) Then 'P1 has Todoroki
                            FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(4)) 'Stain removed from p1 list
                            FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(4)) 'Stain added to P1 list
                        ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(47)) Then 'p2 has todoroki
                            FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(4)) 'stain removed from p1 list
                            FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(4)) 'stain added to p1 list
                        End If
                    ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(18)) Then 'If player 2 has midoriya
                        If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(47)) Then 'P1 has Todoroki
                            FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(4)) 'Stain removed from p1 list
                            FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(4)) 'Stain added to P1 list
                        ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(47)) Then 'p2 has todoroki
                            FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(4)) 'stain removed from p1 list
                            FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(4)) 'stain added to p1 list
                        End If
                    Else 'If Midoriya is not there
                        FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(51)) 'Lida Removed from P1 list
                        FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(51)) 'Lida Added To P1 List
                        FrmActualGame.lstP1_Chara_Dist.Items.Remove(strChara(4)) 'Stain Removed from p1 List
                        FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(4)) 'Stain added to P1 List
                    End If

                ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(51)) Then 'P2 has Lida
                    If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(18)) Then 'If Player 1 has Midoriya

                    ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(18)) Then 'If Player 2 Has Midoriya

                    Else 'If Midoriya is not There
                        FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(51)) 'Lida Removed from P1 list
                        FrmActualGame.lstP2_Chara_Dist.Items.Add(strChara(51)) 'Lida Added To P1 List
                        FrmActualGame.lstP1_Chara_Dist.Items.Remove(strChara(4)) 'Stain Removed from p1 List
                        FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(4)) 'Stain added to P1 List
                    End If
                End If


            Case strChara(34) 'If moonfish is selected
                PlayChara(34) = 1
                If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(10)) Then 'P1 has Tokoyami

                    If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(29)) Then 'P1 has Mezo

                        If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(20)) Then 'p1 has Bakugo
                            If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(47)) Then 'Todoroki in p1 list
                                If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(18)) Then ' Midoriya in p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(18)) Then 'Midoriya in p2 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                Else
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(10)) ' Tokoyami removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(10)) 'Tokoyami added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(29)) 'Mezo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(29)) ' Mezo added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(47)) 'Todoroki removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(47)) ' Todoroki added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(20)) 'Bakugo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(20)) 'Bakugo added to p1 list
                                End If

                            ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(47)) Then 'Todoroki in p2 list
                                If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(18)) Then ' Midoriya in p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(18)) Then 'Midoriya in p2 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                Else
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(10)) ' Tokoyami removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(10)) 'Tokoyami added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(29)) 'Mezo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(29)) ' Mezo added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(47)) 'Todoroki removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(47)) ' Todoroki added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(20)) 'Bakugo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(20)) 'Bakugo added to p1 list
                                End If
                            End If

                        ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(20)) Then 'P2 has Bakugo
                            If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(47)) Then 'Todoroki in p1 list
                                If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(18)) Then ' Midoriya in p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(18)) Then 'Midoriya in p2 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                Else
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(10)) ' Tokoyami removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(10)) 'Tokoyami added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(29)) 'Mezo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(29)) ' Mezo added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(47)) 'Todoroki removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(47)) ' Todoroki added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(20)) 'Bakugo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(20)) 'Bakugo added to p1 list
                                End If

                            ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(47)) Then 'Todoroki in p2 list
                                If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(18)) Then ' Midoriya in p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(18)) Then 'Midoriya in p2 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                Else
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(10)) ' Tokoyami removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(10)) 'Tokoyami added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(29)) 'Mezo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(29)) ' Mezo added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(47)) 'Todoroki removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(47)) ' Todoroki added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(20)) 'Bakugo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(20)) 'Bakugo added to p1 list
                                End If
                            End If
                        Else 'If Bakugo is not there
                            FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(10)) ' Tokoyami removed from p1 list
                            FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(10)) 'Tokoyami added to p1 list
                            FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(29)) 'Mezo removed from p1 list
                            FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(29)) ' Mezo added to p1 list
                            FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                            FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                        End If
                    ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(29)) Then 'P2 has Mezo
                        If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(20)) Then 'p1 has Bakugo
                            If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(47)) Then 'Todoroki in p1 list
                                If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(18)) Then ' Midoriya in p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(18)) Then 'Midoriya in p2 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                Else
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(10)) ' Tokoyami removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(10)) 'Tokoyami added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(29)) 'Mezo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(29)) ' Mezo added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(47)) 'Todoroki removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(47)) ' Todoroki added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(20)) 'Bakugo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(20)) 'Bakugo added to p1 list
                                End If

                            ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(47)) Then 'Todoroki in p2 list
                                If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(18)) Then ' Midoriya in p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(18)) Then 'Midoriya in p2 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                Else
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(10)) ' Tokoyami removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(10)) 'Tokoyami added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(29)) 'Mezo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(29)) ' Mezo added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(47)) 'Todoroki removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(47)) ' Todoroki added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(20)) 'Bakugo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(20)) 'Bakugo added to p1 list
                                End If
                            End If

                        ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(20)) Then 'P2 has Bakugo
                            If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(47)) Then 'Todoroki in p1 list
                                If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(18)) Then ' Midoriya in p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(18)) Then 'Midoriya in p2 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                Else
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(10)) ' Tokoyami removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(10)) 'Tokoyami added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(29)) 'Mezo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(29)) ' Mezo added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(47)) 'Todoroki removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(47)) ' Todoroki added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(20)) 'Bakugo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(20)) 'Bakugo added to p1 list
                                End If

                            ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(47)) Then 'Todoroki in p2 list
                                If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(18)) Then ' Midoriya in p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(18)) Then 'Midoriya in p2 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                Else
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(10)) ' Tokoyami removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(10)) 'Tokoyami added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(29)) 'Mezo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(29)) ' Mezo added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(47)) 'Todoroki removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(47)) ' Todoroki added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(20)) 'Bakugo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(20)) 'Bakugo added to p1 list
                                End If
                            End If
                        Else 'If Bakugo is not there
                            FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(10)) ' Tokoyami removed from p1 list
                            FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(10)) 'Tokoyami added to p1 list
                            FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(29)) 'Mezo removed from p1 list
                            FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(29)) ' Mezo added to p1 list
                            FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                            FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                        End If
                    End If
                ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(10)) Then 'P2 has Tokoyami

                    If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(29)) Then 'P1 has Mezo

                        If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(20)) Then 'p1 has Bakugo
                            If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(47)) Then 'Todoroki in p1 list
                                If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(18)) Then ' Midoriya in p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(18)) Then 'Midoriya in p2 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                Else
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(10)) ' Tokoyami removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(10)) 'Tokoyami added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(29)) 'Mezo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(29)) ' Mezo added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(47)) 'Todoroki removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(47)) ' Todoroki added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(20)) 'Bakugo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(20)) 'Bakugo added to p1 list
                                End If

                            ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(47)) Then 'Todoroki in p2 list
                                If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(18)) Then ' Midoriya in p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(18)) Then 'Midoriya in p2 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                Else
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(10)) ' Tokoyami removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(10)) 'Tokoyami added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(29)) 'Mezo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(29)) ' Mezo added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(47)) 'Todoroki removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(47)) ' Todoroki added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(20)) 'Bakugo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(20)) 'Bakugo added to p1 list
                                End If
                            End If

                        ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(20)) Then 'P2 has Bakugo
                            If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(47)) Then 'Todoroki in p1 list
                                If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(18)) Then ' Midoriya in p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(18)) Then 'Midoriya in p2 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                Else
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(10)) ' Tokoyami removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(10)) 'Tokoyami added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(29)) 'Mezo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(29)) ' Mezo added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(47)) 'Todoroki removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(47)) ' Todoroki added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(20)) 'Bakugo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(20)) 'Bakugo added to p1 list
                                End If

                            ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(47)) Then 'Todoroki in p2 list
                                If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(18)) Then ' Midoriya in p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(18)) Then 'Midoriya in p2 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                Else
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(10)) ' Tokoyami removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(10)) 'Tokoyami added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(29)) 'Mezo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(29)) ' Mezo added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(47)) 'Todoroki removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(47)) ' Todoroki added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(20)) 'Bakugo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(20)) 'Bakugo added to p1 list
                                End If
                            End If
                        Else 'If Bakugo is not there
                            FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(10)) ' Tokoyami removed from p1 list
                            FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(10)) 'Tokoyami added to p1 list
                            FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(29)) 'Mezo removed from p1 list
                            FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(29)) ' Mezo added to p1 list
                            FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                            FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                        End If
                    ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(29)) Then 'P2 has Mezo
                        If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(20)) Then 'p1 has Bakugo
                            If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(47)) Then 'Todoroki in p1 list
                                If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(18)) Then ' Midoriya in p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(18)) Then 'Midoriya in p2 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                Else
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(10)) ' Tokoyami removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(10)) 'Tokoyami added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(29)) 'Mezo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(29)) ' Mezo added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(47)) 'Todoroki removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(47)) ' Todoroki added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(20)) 'Bakugo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(20)) 'Bakugo added to p1 list
                                End If

                            ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(47)) Then 'Todoroki in p2 list
                                If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(18)) Then ' Midoriya in p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(18)) Then 'Midoriya in p2 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                Else
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(10)) ' Tokoyami removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(10)) 'Tokoyami added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(29)) 'Mezo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(29)) ' Mezo added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(47)) 'Todoroki removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(47)) ' Todoroki added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(20)) 'Bakugo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(20)) 'Bakugo added to p1 list
                                End If
                            End If

                        ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(20)) Then 'P2 has Bakugo
                            If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(47)) Then 'Todoroki in p1 list
                                If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(18)) Then ' Midoriya in p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(18)) Then 'Midoriya in p2 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                Else
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(10)) ' Tokoyami removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(10)) 'Tokoyami added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(29)) 'Mezo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(29)) ' Mezo added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(47)) 'Todoroki removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(47)) ' Todoroki added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(20)) 'Bakugo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(20)) 'Bakugo added to p1 list
                                End If

                            ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(47)) Then 'Todoroki in p2 list
                                If FrmActualGame.lstP1_Chara_Idle.Items.Contains(strChara(18)) Then ' Midoriya in p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                ElseIf FrmActualGame.lstP2_Chara_Idle.Items.Contains(strChara(18)) Then 'Midoriya in p2 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                Else
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(10)) ' Tokoyami removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(10)) 'Tokoyami added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(29)) 'Mezo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(29)) ' Mezo added to p1 list
                                    FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(47)) 'Todoroki removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(47)) ' Todoroki added to p1 list
                                    FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(20)) 'Bakugo removed from p1 list
                                    FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(20)) 'Bakugo added to p1 list
                                End If
                            End If
                        Else 'If Bakugo is not there
                            FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(10)) ' Tokoyami removed from p1 list
                            FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(10)) 'Tokoyami added to p1 list
                            FrmActualGame.lstP2_Chara_Idle.Items.Remove(strChara(29)) 'Mezo removed from p1 list
                            FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(29)) ' Mezo added to p1 list
                            FrmActualGame.lstP1_Chara_Idle.Items.Remove(strChara(34)) 'Moonfish removed from p1 list
                            FrmActualGame.lstP1_Chara_Dist.Items.Add(strChara(34)) ' Moonfish added to p1 list
                        End If
                    End If
                End If
            Case strChara(36) 'They Pick Mustard


        End Select

    End Sub
    Sub Check()
        If ET(0) = 0 Then
            If "" Then
            End If
        End If
    End Sub


End Class