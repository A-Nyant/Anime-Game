Public Class ChangePlace
    Dim list1, list2 As Object 'variable for the list
    Dim Turn As Integer 'variable for the turn


    Public Sub add(list1 As Object, list2 As Object, item1 As Object)
        list1.items.Add(item1)
        list2.items.Remove(item1)
    End Sub

    Public Sub add_2C_1D(list1 As Object, List2 As Object, list3 As Object, item1 As Object, item2 As Object)
        list3.items.add(item1) : list3.items.add(item2) 'Add the Character to the list
        List2.items.Remove(item2) : list1.items.Remove(item1) 'Removes the Characters of their original list
    End Sub

    Public Sub Buttons(Item As Object, anime As Form)
        Turn = FrmActualGame.intk

        If Turn = 1 Then
            FrmActualGame.lstP2_Chara_Idle.Items.Add(Item)
            gamePlay(anime, FrmActualGame.lstP2_Chara_Idle, FrmActualGame.lstP2_Chara_Dist, FrmActualGame.lstP1_Chara_Idle, FrmActualGame.lstP1_Chara_Dist, 1)
        ElseIf Turn = 0 Then
            FrmActualGame.lstP1_Chara_Idle.Items.Add(Item)
            gamePlay(anime, FrmActualGame.lstP1_Chara_Idle, FrmActualGame.lstP1_Chara_Dist, FrmActualGame.lstP2_Chara_Idle, FrmActualGame.lstP2_Chara_Dist, 2)
        End If
        FrmActualGame.Players_Turn()
        Debug.Print(Turn)
    End Sub
    Public Sub gamePlay(anime As Form, Now_Idle As Object, Now_Dist As Object, Opp_Idle As Object, Opp_Dist As Object, Optional ByRef num As Integer = 0)
        If anime.Equals(FrmHetalia) Then
            FrmHetalia.GamePlay(Now_Idle, Now_Dist, Opp_Idle, Opp_Dist, num)
        ElseIf anime.Equals(frmDGM) Then
            frmDGM.GamePlay(Now_Idle, Now_Dist, Opp_Idle, Opp_Dist, num)
        End If
    End Sub


    Public Sub Team_Check(now_idle As Object, now_dist As Object, num_Chara As Integer, num_player As Integer, characters() As String)
        Dim count As Integer
        For k = 0 To num_Chara - 1
            If now_idle.items.contains(characters(k)) Or now_dist.items.contains(characters(k)) Then
                count += 1
            End If
        Next
        If (count > 2) Then
            FrmActualGame.Team_Point(num_player) += ((count - 2) * 2.5)
        End If
        count = 0
    End Sub
End Class
