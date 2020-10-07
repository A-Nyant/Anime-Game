
Public Class FrmActualGame

    'Keep track of who's turn it is
    Public intk As Integer

    'Variable for keeping track of the points for each player
    Dim sngTotal(2) As Single

    'Class that has methods.
    Dim this As New ChangePlace

    'Variable to show points for certain features.
    'Ex_Point - Points for killed characters
    'Team_Point - Characters on the same team in the anime are in the same list box.
    Public Ex_Point(2), Team_Point(2) As Single

    'Holds the form and the menu tab
    Dim C_anime, C_tab As Object

    'Boolean to check if characters are fighting
    Dim Battle_Time As Boolean

    'Alerts player, that characters are fighting and tab is unusable for now.
    Dim C_message As String

    'Debug problems; Clears the listboxes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstP1_Chara_Idle.Items.Clear() : lstP1_Chara_Dist.Items.Clear()
        lstP2_Chara_Idle.Items.Clear() : lstP2_Chara_Dist.Items.Clear()
    End Sub


    'Used to calculate who won. Points are award as such
    '*3 points for every character that is not fighting/distracted.
    '*1.5 points for every character that is fighting/distracted.
    Sub Calc(Now_idle As Object, Now_dist As Object, score As Object, num As Integer)
        Dim sngIdleTotal, sngDistTotal As Single
        If Now_idle.items.Count <> 0 Then
            sngIdleTotal = Now_idle.Items.Count * 3

            sngDistTotal = Now_dist.Items.Count * 1.5
        End If
        sngTotal(num) = sngIdleTotal + sngDistTotal + Ex_Point(num) + Team_Point(num)
        score.Text = sngTotal(num).ToString
    End Sub


    'Timer to show the current points for each player. Calls on another method, "Calc", to calculate the points.
    Private Sub tmrCal_Tick(sender As Object, e As EventArgs) Handles tmrCal.Tick
        Calc(lstP1_Chara_Idle, lstP1_Chara_Dist, lblTotal_P1, 1)
        Calc(lstP2_Chara_Idle, lstP2_Chara_Dist, lblTotal_P2, 2)
    End Sub

    'Method to change whose turn it is.
    Public Sub Players_Turn()
        If intk > 0 Then
            intk -= 1

        Else
            intk += 1
        End If
    End Sub


    'Sets up the game
    Private Sub FrmActualGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'turns on the time
        tmrCal.Enabled = True

        'Pick the player who goes first.
        Dim randomizer As New Random()
        intk = randomizer.Next(0, 2)

        'Tells who is going first
        If intk = 1 Then
            MessageBox.Show("A player was picked randomly to go first, " & frmMainP1.txtNameP1.Text & " will be first")
        Else
            MessageBox.Show("A player was picked randomly to go first, " & frmMainP1.txtNameP2.Text & " will be first")
        End If

        'Name the groupboxes to show which listboxes belong to who.
        GroupBox1.Text = frmMainP1.txtNameP1.Text & "'s Characters"
        GroupBox2.Text = frmMainP1.txtNameP2.Text & "'s Characters"
    End Sub


    'if Hetalia menu was clicked, then the player pick characters that are from Hetalia
    Private Sub mnuHetalia_Click(sender As Object, e As EventArgs) Handles mnuHetalia.Click
        FrmHetalia.Show()
    End Sub

    'if Boku No Hero Academia was picked, then the player will pick characters from BNHA.
    Private Sub mnuBokuNoHeroAcademia_Click(sender As Object, e As EventArgs) Handles mnuBokuNoHeroAcademia.Click
        FrmBNHA.Show()
    End Sub

    'if D.Gray-man was picked, then the player will pick characters from D. Gray-Man.
    Private Sub mnuDGrayMan_Click(sender As Object, e As EventArgs) Handles mnuDGrayMan.Click
        frmDGM.Show()
    End Sub

    'Used to simulate that the two characters had a battle in the anime. Calls on another method to help.
    Private Sub tmrBattle_Tick(sender As Object, e As EventArgs) Handles tmrBattle.Tick
        tmrBattle.Enabled = False
        Battle_Time = True
        battle(C_anime, C_tab, C_message)
    End Sub

    'Used in tmrBattle_tick, to show that there is a battle.
    Public Sub battle(Anime As Object, tab As Object, Message As String)

        'If the characters have not battled yet,
        If Not Battle_Time Then
            'Set the timer to true
            tmrBattle.Enabled = True
            'Hides the tab, so the player can not access it again.
            tab.visible = False

            'The characters are in a battle and timer has run out
        Else

            'Changes the battle boolean to false, so that it can be used for another character.
            Battle_Time = False
            'Tab is shown again
            tab.Visible = True
            'Timer is set to false
            tmrBattle.Enabled = False
            MessageBox.Show(Message)
        End If

        'Used to send the anime, tab and message back to the timer, so check whether the battle was done.
        C_anime = Anime
        C_tab = tab
        C_message = Message

    End Sub
End Class


