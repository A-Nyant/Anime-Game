Public Class FrmHetalia
    Dim K, j, l As Integer
    Public CharaList(40), strChara As String
    Dim CharaNum(10) As Integer '0 - America, 1,- Austria
    Dim This As New ChangePlace
    Public player1_idle As Object = FrmActualGame.lstP1_Chara_Idle : Public player1_dist As Object = FrmActualGame.lstP1_Chara_Dist
    Public player2_idle As Object = FrmActualGame.lstP2_Chara_Idle : Public player2_dist As Object = FrmActualGame.lstP2_Chara_Dist

    'When the player clicks on a name, the character's picture will show up.
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHetaliaChara.SelectedIndexChanged
        showChara()
    End Sub

    'When the player picks the character, it sets up some events.
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGoP1.Click
        'hides the form if there are still characters.
        Me.Hide()

        'Calls a method in ChangePlace class to handle the moving of characters.
        This.Buttons(lstHetaliaChara.SelectedItem, Me)

        'Removes the character from the list
        lstHetaliaChara.Items.Remove(lstHetaliaChara.SelectedItem)

        'If there are no characters in the listbox, then the form will close and the tab for the show will disappear.
        If lstHetaliaChara.Items.Count = 0 Then
            FrmActualGame.mnuHetalia.Visible = False
            If FrmActualGame.mnuHetalia.Visible = False And FrmActualGame.mnuHigurashi.Visible = False And FrmActualGame.mnuHitmanReborn.Visible = False And FrmActualGame.mnuHunterxHunter.Visible = False Then
                FrmActualGame.mnuH.Visible = False
            End If
            Me.Close()
        End If
    End Sub

    'puts the characters into an array.
    Private Sub FrmHetalia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For K = 0 To CharaList.Length - 1
            CharaList(K) = lstHetaliaChara.Items(K)
        Next
    End Sub

    'Gameplay for when the characters are picked.
    'Now_idle is the current player's listbox for their idle characters, while Now_dist is the listbox for their distracted characters.
    'Opp_idle is the other's listbox for their idle character while opp_num is the listbox for their distracted characters.
    'num is ???????????????
    Public Sub GamePlay(Now_idle As Object, Now_Dist As Object, Opp_Idle As Object, Opp_Dist As Object, num As Integer)
        Select Case lstHetaliaChara.SelectedItem
            Case CharaList(0) 'America
                CharaNum(0) = num
                If Now_idle.Items.Contains(CharaList(8)) Then 'player 1 has Cuba
                    This.add(Now_Dist, Now_idle, CharaList(8))
                ElseIf Opp_Idle.Items.Contains(CharaList(8)) Then 'player 1 has Cuba
                    This.add(Now_Dist, Opp_Idle, CharaList(8))
                End If

                If Now_idle.Items.Contains(CharaList(31)) Then 'p1 has Russia
                    This.add_2C_1D(Now_idle, Now_idle, Now_Dist, CharaList(0), CharaList(31)) 'America and Russia moves
                ElseIf Opp_Idle.Items.Contains(CharaList(31)) Then 'p2 has Russia
                    This.add_2C_1D(Now_idle, Opp_Idle, Now_Dist, CharaList(0), CharaList(31)) 'America and Russia moves
                ElseIf Now_idle.Items.Contains(CharaList(10)) Then 'P1 has England
                    This.add_2C_1D(Now_idle, Now_idle, Now_Dist, CharaList(0), CharaList(10)) 'America and England Moves
                ElseIf Opp_Idle.Items.Contains(CharaList(10)) Then 'P2 has England
                    This.add_2C_1D(Now_idle, Opp_Idle, Now_Dist, CharaList(0), CharaList(10)) 'America and England Moves
                ElseIf Now_Dist.Items.Contains(CharaList(10)) Then 'P1 has England
                    This.add(Now_Dist, Now_idle, CharaList(0)) 'America Moves
                ElseIf Opp_Dist.Items.Contains(CharaList(10)) Then
                    This.add(Now_Dist, Now_idle, CharaList(0)) 'America Moves
                    This.add_2C_1D(Opp_Dist, Opp_Dist, Now_Dist, CharaList(10), CharaList(13)) 'England and France Moves.
                End If



            Case CharaList(1) 'Ancient Rome
                If Now_idle.Items.Contains(CharaList(14)) Then 'player 1 has Germania
                    This.add_2C_1D(Now_idle, Now_idle, Now_Dist, CharaList(1), CharaList(14))
                ElseIf Opp_Idle.Items.Contains(CharaList(14)) Then 'player 1 has Germania
                    This.add_2C_1D(Now_idle, Opp_Idle, Now_Dist, CharaList(1), CharaList(14))
                End If


            Case (CharaList(2)) 'Has Austria
                CharaNum(1) = num
                If Opp_Idle.Items.Contains(CharaList(19)) Then 'p1 has Hungary
                    This.add(Now_idle, Opp_Idle, CharaList(19)) 'Hungary moves
                ElseIf Now_idle.Items.Contains(CharaList(29)) Then 'p1 has Prussia
                    This.add_2C_1D(Now_idle, Now_idle, Now_Dist, CharaList(2), CharaList(29))
                ElseIf Opp_Idle.Items.Contains(CharaList(29)) Then 'p2 has Prussia
                    This.add_2C_1D(Now_idle, Opp_Idle, Now_Dist, CharaList(2), CharaList(29))
                ElseIf Now_idle.items.contains(CharaList(15)) Then 'They have germany on the same side
                    This.add(Now_Dist, Now_idle, CharaList(15)) 'Germany is distracted
                End If


            Case (CharaList(3)) 'Has Belarus
                If Now_idle.Items.Contains(CharaList(31)) Then 'p1 has Russia
                    This.add_2C_1D(Now_idle, Now_idle, Now_Dist, CharaList(3), CharaList(31)) 'Belarus and Russia moves
                ElseIf Opp_Idle.Items.Contains(CharaList(31)) Then 'p2 has Russia
                    This.add_2C_1D(Now_idle, Opp_Idle, Now_Dist, CharaList(3), CharaList(31)) 'Belarus and Russia moves
                ElseIf Now_Dist.Items.Contains(CharaList(31)) Then 'p1 has Russia
                    This.add(Now_Dist, Now_idle, CharaList(3))
                    If Now_idle.Items.Contains(CharaList(10)) Then 'Player has England
                        This.add_2C_1D(Now_Dist, Now_idle, Now_Dist, CharaList(0), CharaList(10))
                    ElseIf Opp_Idle.Items.Contains(CharaList(10)) Then 'Player has England
                        This.add_2C_1D(Now_Dist, Opp_Idle, Opp_Dist, CharaList(0), CharaList(10))
                    ElseIf Opp_Dist.Items.Contains(CharaList(10)) Then 'Player Has England
                        This.add(Opp_Dist, Now_Dist, CharaList(0))
                    ElseIf CharaNum(0) = 1 Then 'p1 had America
                        This.add(player1_idle, Now_Dist, CharaList(0)) 'America return to player
                    ElseIf CharaNum(0) = 2 Then
                        This.add(player2_idle, Now_Dist, CharaList(0)) 'America return to player
                    End If
                ElseIf Opp_Dist.Items.Contains(CharaList(31)) Then 'p1 has Russia
                    This.add_2C_1D(Now_idle, Opp_Dist, Now_Dist, CharaList(3), CharaList(31))
                    If Now_idle.Items.Contains(CharaList(10)) Then 'Player has England
                        This.add_2C_1D(Opp_Dist, Now_idle, Now_Dist, CharaList(0), CharaList(10))
                    ElseIf Opp_Idle.Items.Contains(CharaList(10)) Then 'Player has England
                        This.add_2C_1D(Opp_Dist, Opp_Idle, Opp_Dist, CharaList(0), CharaList(10))
                    ElseIf Opp_Dist.Items.Contains(CharaList(10)) Then
                        This.add(Opp_Dist, Opp_Dist, CharaList(10))
                    ElseIf CharaNum(0) = 1 Then 'p1 had America
                        This.add(player1_idle, Opp_Dist, CharaList(0)) 'America return to player
                    ElseIf CharaNum(0) = 2 Then
                        This.add(player2_idle, Opp_Dist, CharaList(0)) 'America return to player
                    End If
                End If


            Case CharaList(6) 'Chibitalia
                If Opp_Idle.Items.Contains(CharaList(17)) Then 'player 2 has HRE
                    This.add(Opp_Idle, Now_idle, CharaList(6)) 'Chibitalia change place
                End If


            Case (CharaList(7)) 'Has China
                If Now_idle.Items.Contains(CharaList(34)) Then 'p1 has South Korea
                    This.add_2C_1D(Now_idle, Now_idle, Now_Dist, CharaList(7), CharaList(34)) 'China and South Korea moves
                ElseIf Opp_Idle.Items.Contains(CharaList(34)) Then 'p2 has South Korea
                    This.add_2C_1D(Now_idle, Opp_Idle, Now_Dist, CharaList(7), CharaList(34)) 'China and South Korea moves
                End If


            Case CharaList(8) 'Cuba
                If Now_idle.Items.Contains(CharaList(0)) Then 'player 1 has America
                    This.add(Now_Dist, Now_idle, CharaList(8)) 'Cuba moves
                ElseIf Opp_Idle.Items.Contains(CharaList(0)) Then 'player 1 has America
                    This.add(Now_Dist, Now_idle, CharaList(8)) 'Cuba moves
                End If


            Case CharaList(10) 'England
                If Now_idle.Items.Contains(CharaList(32)) Then 'player 1 has Sealand
                    This.add(Now_Dist, Now_idle, CharaList(32)) 'Sealand moves
                ElseIf Opp_Idle.Items.Contains(CharaList(32)) Then 'player 1 has Sealand
                    This.add(Now_Dist, Opp_Idle, CharaList(32)) 'Sealand moves1
                End If

                If Now_idle.Items.Contains(CharaList(13)) Then 'p1 has France
                    If Now_idle.items.contains(CharaList(0)) Then
                        This.add(Now_Dist, Now_idle, CharaList(0))
                    ElseIf Opp_Idle.items.contains(CharaList(0)) Then
                        This.add(Now_Dist, Opp_Idle, CharaList(0))
                    End If
                    This.add_2C_1D(Now_idle, Now_idle, Now_Dist, CharaList(10), CharaList(13)) 'England and France
                ElseIf Opp_Idle.Items.Contains(CharaList(13)) Then 'p2 has France
                    If Now_idle.items.contains(CharaList(0)) Then
                        This.add(Now_Dist, Now_idle, CharaList(0))
                    ElseIf Opp_Idle.items.contains(CharaList(0)) Then
                        This.add(Now_Dist, Opp_Idle, CharaList(0))
                    End If
                    This.add_2C_1D(Now_idle, Opp_Idle, Now_Dist, CharaList(10), CharaList(13))
                ElseIf Now_idle.Items.Contains(CharaList(0)) Then 'P1 has America
                    This.add_2C_1D(Now_idle, Now_idle, Now_Dist, CharaList(10), CharaList(0)) 'England and America
                ElseIf Opp_Idle.Items.Contains(CharaList(0)) Then 'P2 has America
                    This.add_2C_1D(Now_idle, Opp_Idle, Now_Dist, CharaList(10), CharaList(0)) 'England and America
                End If


            Case CharaList(11) 'Estonia
                If Opp_Idle.Items.Contains(CharaList(31)) Or Opp_Dist.Items.Contains(CharaList(31)) Then 'player 2 has Russia
                    This.add(Opp_Dist, Now_idle, CharaList(11)) 'Estonia
                ElseIf Now_idle.Items.Contains(CharaList(31)) Or Now_Dist.Items.Contains(CharaList(31)) Then 'player 2 has Russia
                    This.add(Now_Dist, Now_idle, CharaList(11)) 'Estonia
                End If


            Case CharaList(12) 'They have finland
                If Opp_Idle.items.contains(CharaList(36)) Then 'other has swedent
                    This.add(Opp_Idle, Now_idle, CharaList(12)) 'Finland moves
                    If Now_idle.items.contains(CharaList(32)) Then
                        This.add(Opp_Idle, Now_idle, CharaList(32))
                    End If
                End If


            Case (CharaList(13)) 'Has France
                If Now_idle.Items.Contains(CharaList(10)) Then 'p1 has England
                    This.add_2C_1D(Now_idle, Now_idle, Now_Dist, CharaList(13), CharaList(10)) 'England and France moves
                ElseIf Opp_Idle.Items.Contains(CharaList(10)) Then 'p2 has England
                    This.add_2C_1D(Now_idle, Opp_Idle, Now_Dist, CharaList(13), CharaList(10)) 'England and France moves
                ElseIf Now_Dist.Items.Contains(CharaList(10)) Then 'p1 has England
                    This.add(Now_Dist, Now_idle, CharaList(13))
                ElseIf Opp_Dist.Items.Contains(CharaList(10)) Then 'p2 has England
                    This.add(Now_Dist, Now_idle, CharaList(13)) 'France moves
                    This.add_2C_1D(Opp_Dist, Opp_Dist, Now_Dist, CharaList(0), CharaList(10)) 'England and America moves
                End If

                If Now_idle.Items.Contains(CharaList(17)) Then
                    Now_idle.items.remove(CharaList(17))
                    MessageBox.Show("Holy Roman Empire has Died")
                ElseIf Opp_Idle.items.Contains(CharaList(17)) Then
                    Opp_Idle.items.remove(CharaList(17))
                    MessageBox.Show("Holy Roman Empire has Died")
                Else
                    lstHetaliaChara.Items.Remove(CharaList(17))
                    MessageBox.Show("Holy Roman Empire has Died")
                End If

            Case CharaList(14) 'Germania
                If Now_idle.Items.Contains(CharaList(1)) Then 'player 1 has Ancient Rome
                    This.add_2C_1D(Now_idle, Now_idle, Now_Dist, CharaList(14), CharaList(1))
                ElseIf Opp_Idle.Items.Contains(CharaList(1)) Then 'player 1 has Germania
                    This.add_2C_1D(Now_idle, Opp_Idle, Now_Dist, CharaList(14), CharaList(1))
                End If


            Case (CharaList(15)) 'Has Germany

                If Now_idle.items.contains(CharaList(2)) Then 'they have Austria
                    This.add(Now_Dist, Now_idle, CharaList(15))
                End If

                If Opp_Idle.Items.Contains(CharaList(26)) Then 'p2 has North Italy
                    This.add(Now_idle, Opp_Idle, CharaList(26)) 'North Italy goes to his side
                End If

                If Now_idle.items.Contains(CharaList(33)) Then
                    This.add(Opp_Idle, Now_idle, CharaList(33))
                End If


            Case CharaList(16) 'Greece
                If Now_idle.Items.Contains(CharaList(38)) Then 'player 1 has Turkey
                    This.add_2C_1D(Now_idle, Now_idle, Now_Dist, CharaList(38), CharaList(16)) 'Greece on same side
                ElseIf Opp_Idle.Items.Contains(CharaList(38)) Then 'player 1 has Turkey
                    This.add_2C_1D(Now_idle, Opp_Idle, Now_Dist, CharaList(16), CharaList(38)) 'Greece on different side
                End If


            Case CharaList(17) 'HRE
                If Opp_Idle.Items.Contains(CharaList(6)) Then 'player 2 has Chibitlalia
                    This.add(Now_idle, Opp_Idle, CharaList(6)) 'Chibitalia change place
                End If


            Case (CharaList(18)) 'has hong Kong
                Dim place As Integer

                If Now_idle.items.contains(CharaList(7)) Or Now_Dist.items.contains(CharaList(7)) Then
                    If Opp_Idle.items.contains(CharaList(10)) Or Opp_Dist.items.contains(CharaList(10)) Then
                        Dim randomizer As New Random()
                        place = randomizer.Next(1, 3)
                    End If
                ElseIf Opp_Idle.items.contains(CharaList(7)) Or Opp_Dist.items.contains(CharaList(7)) Then
                    If Now_idle.items.contains(CharaList(10)) Or Now_Dist.items.contains(CharaList(10)) Then
                        Dim randomizer As New Random()
                        place = randomizer.Next(1, 3)
                    Else
                        This.add(Opp_Idle, Now_idle, CharaList(18))
                    End If
                End If

                If place = 2 Then
                    This.add(Opp_Idle, Now_idle, CharaList(18))
                End If

                place = 0


            Case (CharaList(19)) 'Has Hungary
                    Select Case True
                        Case Now_idle.Items.Contains(CharaList(29))  'p1 has Prussia
                            This.add_2C_1D(Now_idle, Now_idle, Now_Dist, CharaList(19), CharaList(29))'Hungary and Prussia moves
                        Case Opp_Idle.Items.Contains(CharaList(29)) 'p2 has Prussia
                            This.add_2C_1D(Now_idle, Opp_Idle, Now_Dist, CharaList(19), CharaList(29))'Hungary and Prussia moves
                        Case Now_Dist.Items.Contains(CharaList(29)) 'p1 has Prussia
                            This.add(Now_Dist, Now_idle, CharaList(19))
                            If CharaNum(1) = 1 Then
                                This.add(player1_idle, Now_Dist, CharaList(2))
                            ElseIf CharaNum(1) = 2 Then
                                This.add(player2_idle, Now_Dist, CharaList(2))
                            End If
                        Case Opp_Dist.Items.Contains(CharaList(29)) 'p2 has Prussia
                            This.add_2C_1D(Now_idle, Opp_Dist, Now_Dist, CharaList(19), CharaList(29))
                            If CharaNum(1) = 1 Then
                                This.add(player1_idle, Opp_Dist, CharaList(2))
                            ElseIf CharaNum(1) = 2 Then
                                This.add(player2_idle, Opp_Dist, CharaList(2))
                            End If
                    End Select


            Case CharaList(22) 'Lativa
                If Opp_Idle.Items.Contains(CharaList(31)) Or Opp_Dist.Items.Contains(CharaList(31)) Then 'player 2 has Russia
                    This.add(Opp_Dist, Now_idle, CharaList(22)) 'Lativa
                ElseIf Now_idle.Items.Contains(CharaList(31)) Or Now_Dist.Items.Contains(CharaList(31)) Then 'player 2 has Russia
                    This.add(Now_Dist, Now_idle, CharaList(22)) 'Lativa
                End If


            Case CharaList(23) 'liech is picked
                If Opp_Idle.Items.Contains(CharaList(37)) Then 'player 2 has swiss
                    This.add(Opp_Idle, Now_idle, CharaList(23))
                End If


            Case CharaList(24) 'Lithunia
                If Opp_Idle.Items.Contains(CharaList(31)) Or Opp_Dist.Items.Contains(CharaList(31)) Then 'player 2 has Russia
                    This.add(Opp_Dist, Now_idle, CharaList(24)) 'Lithunia
                ElseIf Now_idle.Items.Contains(CharaList(31)) Or Now_Dist.Items.Contains(CharaList(31)) Then 'player 2 has Russia
                    This.add(Now_Dist, Now_idle, CharaList(24)) 'Lithunia
                    Else
                    If Opp_Idle.Items.Contains(CharaList(28)) Then 'p2 has chara Poland
                        This.add(Now_idle, Opp_Idle, CharaList(28))
                    End If
                End If


            Case CharaList(25) 'They picked netherland
                If Now_idle.Items.contains(CharaList(35)) Then 'we have spain
                    This.add(Opp_Idle, Now_idle, CharaList(25)) 'Netherland moves
                End If


            Case (CharaList(26)) 'Has North Italy
                If Opp_Idle.Items.Contains(CharaList(15)) Then 'p2 has chara North Italy
                    This.add(Opp_Idle, Now_idle, CharaList(26))
                End If



            Case (CharaList(28)) 'Has Poland
                If Opp_Idle.Items.Contains(CharaList(24)) Or Opp_Dist.Items.Contains(CharaList(24)) Then 'p2 has Lithunia
                    This.add(Opp_Idle, Now_idle, CharaList(28)) 'Poland moves
                End If

            Case (CharaList(29)) 'Has Prussia
                If Now_idle.Items.Contains(CharaList(19)) Then 'p1 has Hungary
                    This.add_2C_1D(Now_idle, Now_idle, Now_Dist, CharaList(29), CharaList(19)) 'Hungary and Prussia moves
                ElseIf Opp_Idle.Items.Contains(CharaList(19)) Then 'p2 has Hungary
                    This.add_2C_1D(Now_idle, Opp_Idle, Now_Dist, CharaList(29), CharaList(19)) 'Hungary and Prussia moves
                ElseIf Now_idle.Items.Contains(CharaList(2)) Then 'p1 has Austria
                    This.add_2C_1D(Now_idle, Now_idle, Now_Dist, CharaList(29), CharaList(2)) 'Austria and Prussia moves
                ElseIf Opp_Idle.Items.Contains(CharaList(2)) Then 'p2 has Austria
                    This.add_2C_1D(Now_idle, Opp_Idle, Now_Dist, CharaList(29), CharaList(2)) 'Austria and Prussia moves
                End If

            Case CharaList(31) 'Russia
                If Opp_Idle.Items.Contains(CharaList(11)) Then 'player 2 has Estonia
                    This.add(Now_Dist, Opp_Idle, CharaList(11)) 'Estonia moves
                ElseIf Now_idle.Items.Contains(CharaList(11)) Then 'player 2 has Estonia
                    This.add(Now_Dist, Now_idle, CharaList(11)) 'Estonia moves 
                End If

                If Opp_Idle.Items.Contains(CharaList(22)) Then 'player 2 has Lativa
                    This.add(Now_Dist, Opp_Idle, CharaList(22)) 'Lativa moves
                ElseIf Now_idle.Items.Contains(CharaList(22)) Then 'player 2 has Lativa
                    This.add(Now_Dist, Now_idle, CharaList(22)) 'Lativa moves
                End If

                If Opp_Idle.Items.Contains(CharaList(24)) Then 'player 2 has Lithunia
                    This.add(Now_Dist, Opp_Idle, CharaList(24)) 'Lithunia moves
                ElseIf Now_idle.Items.Contains(CharaList(24)) Then 'player 2 has Lithunia
                    This.add(Now_Dist, Now_idle, CharaList(24)) 'Lithunia moves
                    End If

                If Now_idle.Items.Contains(CharaList(3)) Then 'p1 has Belarus
                    This.add_2C_1D(Now_idle, Now_idle, Now_Dist, CharaList(31), CharaList(3)) 'Belarus and Russia Moves
                ElseIf Opp_Idle.Items.Contains(CharaList(3)) Then 'p2 has Belarus
                    This.add_2C_1D(Now_idle, Opp_Idle, Now_Dist, CharaList(31), CharaList(3)) 'Belarus and Russia Moves
                ElseIf Now_idle.Items.Contains(CharaList(0)) Then 'p1 has America
                    This.add_2C_1D(Now_idle, Now_idle, Now_Dist, CharaList(31), CharaList(0)) 'America and Russia Moves
                ElseIf Opp_Idle.Items.Contains(CharaList(0)) Then 'p2 has America
                    This.add_2C_1D(Now_idle, Opp_Idle, Now_Dist, CharaList(31), CharaList(0)) 'America and Russia Moves
                    End If

                If Now_idle.items.Contains(CharaList(39)) Then 'They picked Urkraine
                    This.add(Opp_Idle, Now_idle, CharaList(39))
                End If


            Case CharaList(32) 'Sealand
                If Now_idle.Items.Contains(CharaList(10)) Or Now_Dist.Items.Contains(CharaList(10)) Then 'player 1 has England
                    This.add(Now_Dist, Now_idle, CharaList(32)) 'Sealand moves
                ElseIf Opp_Idle.Items.Contains(CharaList(10)) Or Opp_Dist.Items.Contains(CharaList(10)) Then 'player 1 has England
                    This.add(Now_Dist, Now_idle, CharaList(32)) 'Sealand moves
                ElseIf Opp_Idle.Items.Contains(CharaList(12)) Then 'Other has finland
                    This.add(Opp_Idle, Now_idle, CharaList(32)) 'Sealands moves
                End If


            Case CharaList(33) 'South Italy
                If Now_idle.items.contains(CharaList(15)) Or Now_Dist.items.contains(CharaList(15)) Then 'germany is on the same side
                    This.add(Opp_Idle, Now_idle, CharaList(33)) 'Moves South italy
                End If

            Case (CharaList(34)) 'Has South Korea
                If Now_idle.Items.Contains(CharaList(7)) Then 'p1 has China
                    This.add_2C_1D(Now_idle, Now_idle, Now_Dist, CharaList(34), CharaList(7)) 'China and South Korea moves
                ElseIf Opp_Idle.Items.Contains(CharaList(7)) Then 'p2 has China
                    This.add_2C_1D(Now_idle, Opp_Idle, Now_Dist, CharaList(34), CharaList(7)) 'China and South Korea moves
                End If


            Case CharaList(35) 'Spain
                If Opp_Idle.Items.Contains(CharaList(40)) Then 'player 2 has chibi romano
                    This.add(Now_idle, Opp_Idle, CharaList(40)) 'Chibi Romano change place
                End If

                If Now_idle.items.contains(CharaList(25)) Then 'We have netherlands
                    This.add(Opp_Idle, Now_idle, CharaList(25)) 'Netherland moves to opposite
                End If

            Case CharaList(36) 'Sweden
                If Opp_Idle.Items.contains(CharaList(12)) Then 'other has Finland
                    This.add(Now_idle, Opp_Idle, CharaList(12))
                    If Opp_Idle.items.contains(CharaList(32)) Then
                        This.add(Now_idle, Opp_Idle, CharaList(32))
                    End If
                End If

            Case CharaList(37) 'swissland is picked
                If Opp_Idle.Items.Contains(CharaList(23)) Then 'player 1 has liech
                    This.add(Now_idle, Opp_Idle, CharaList(23))
                End If


            Case CharaList(38) 'Turkey
                If Now_idle.Items.Contains(CharaList(16)) Then 'player 1 has Greece
                    This.add_2C_1D(Now_idle, Now_idle, Now_Dist, CharaList(16), CharaList(38)) 'Turkey by same side
                ElseIf Opp_Idle.Items.Contains(CharaList(16)) Then 'player 1 has Greece
                    This.add_2C_1D(Now_idle, Opp_Idle, Now_Dist, CharaList(38), CharaList(16)) 'Turkey on different side
                End If


            Case CharaList(39) 'Urkraine
                If Now_idle.items.Contains(CharaList(31)) Or Now_Dist.items.contains(CharaList(31)) Then 'we have Russia
                    This.add(Opp_Idle, Now_idle, CharaList(39)) 'Urkraine moves
                End If


            Case CharaList(40) 'Chibi Romania
                If Opp_Idle.Items.Contains(CharaList(35)) Then 'player 2 has spain
                    This.add(Opp_Idle, Now_idle, CharaList(40)) 'Chibi Romano is from other player
                End If
        End Select
    End Sub
    Sub showChara()
        strChara = lstHetaliaChara.SelectedItem
        Select Case strChara
            Case "America"
                picMain.Image = picAmerica.Image
                picMain.SizeMode = picAmerica.SizeMode
            Case "Ancient Rome"
                picMain.Image = picAntRome.Image
                picMain.SizeMode = picAntRome.SizeMode
            Case "Austria"
                picMain.Image = picAustria.Image
                picMain.SizeMode = picAustria.SizeMode
            Case "Belarus"
                picMain.Image = picBelarus.Image
                picMain.SizeMode = picBelarus.SizeMode
            Case "Belgium"
                picMain.Image = picBelgium.Image
                picMain.SizeMode = picBelgium.SizeMode
            Case "Canada"
                picMain.Image = picCanada.Image
                picMain.SizeMode = picCanada.SizeMode
            Case "Chibitalia"
                picMain.Image = picChibItaly.Image
                picMain.SizeMode = picChibItaly.SizeMode
            Case "China"
                picMain.Image = picChina.Image
                picMain.SizeMode = picChina.SizeMode
            Case "Cuba"
                picMain.Image = picCuba.Image
                picMain.SizeMode = picCuba.SizeMode
            Case "Denmark"
                picMain.Image = picDenmark.Image
                picMain.SizeMode = picDenmark.SizeMode
            Case "England"
                picMain.Image = picEngland.Image
                picMain.SizeMode = picEngland.SizeMode
            Case "Estonia"
                picMain.Image = picEstonia.Image
                picMain.SizeMode = picEstonia.SizeMode
            Case "Finland"
                picMain.Image = picFinland.Image
                picMain.SizeMode = picFinland.SizeMode
            Case "France"
                picMain.Image = picFrance.Image
                picMain.SizeMode = picFrance.SizeMode
            Case "Germania"
                picMain.Image = picGermania.Image
                picMain.SizeMode = picGermania.SizeMode
            Case "Germany"
                picMain.Image = picGermany.Image
                picMain.SizeMode = picGermany.SizeMode
            Case "Greece"
                picMain.Image = picGreece.Image
                picMain.SizeMode = picGreece.SizeMode
            Case "Holy Roman Empire"
                picMain.Image = picHRE.Image
                picMain.SizeMode = picHRE.SizeMode
            Case "Hong Kong"
                picMain.Image = picHongKong.Image
                picMain.SizeMode = picHongKong.SizeMode
            Case "Hungary"
                picMain.Image = picHungary.Image
                picMain.SizeMode = picHungary.SizeMode
            Case "Iceland"
                picMain.Image = picIceland.Image
                picMain.SizeMode = picIceland.SizeMode
            Case "Japan"
                picMain.Image = picJapan.Image
                picMain.SizeMode = picJapan.SizeMode
            Case "Latvia"
                picMain.Image = picLatvia.Image
                picMain.SizeMode = picLatvia.SizeMode
            Case "Liechtenstein"
                picMain.Image = picLiech.Image
                picMain.SizeMode = picLiech.SizeMode
            Case "Lithuania"
                picMain.Image = picLithuania.Image
                picMain.SizeMode = picLithuania.SizeMode
            Case "Netherland"
                picMain.Image = picNetherland.Image
                picMain.SizeMode = picNetherland.SizeMode
            Case "North Italy"
                picMain.Image = picN_Italy.Image
                picMain.SizeMode = picN_Italy.SizeMode
            Case "Norway"
                picMain.Image = picNorway.Image
                picMain.SizeMode = picNorway.SizeMode
            Case "Poland"
                picMain.Image = picPoland.Image
                picMain.SizeMode = picPoland.SizeMode
            Case "Prussia"
                picMain.Image = picPrussia.Image
                picMain.SizeMode = picPrussia.SizeMode
            Case "Romania"
                picMain.Image = picRomania.Image
                picMain.SizeMode = picRomania.SizeMode
            Case "Russia"
                picMain.Image = picRussia.Image
                picMain.SizeMode = picRussia.SizeMode
            Case "Sealand"
                picMain.Image = picSealand.Image
                picMain.SizeMode = picSealand.SizeMode
            Case "South Italy"
                picMain.Image = picS_Italy.Image
                picMain.SizeMode = picS_Italy.SizeMode
            Case "South Korea"
                picMain.Image = picKorea.Image
                picMain.SizeMode = picKorea.SizeMode
            Case "Spain"
                picMain.Image = picSpain.Image
                picMain.SizeMode = picSpain.SizeMode
            Case "Sweden"
                picMain.Image = picSweden.Image
                picMain.SizeMode = picSweden.SizeMode
            Case "Switzerland"
                picMain.Image = picSwiss.Image
                picMain.SizeMode = picSwiss.SizeMode
            Case "Turkey"
                picMain.Image = picTurkey.Image
                picMain.SizeMode = picTurkey.SizeMode
            Case "Ukraine"
                picMain.Image = picUkraine.Image
                picMain.SizeMode = picUkraine.SizeMode
            Case "Chibi Romano"
                picMain.Image = picChibiRomano.Image
                picMain.SizeMode = picChibiRomano.SizeMode
        End Select
    End Sub
End Class