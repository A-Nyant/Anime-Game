
Public Class FrmActualGame

    Dim intk As Integer
    Dim sngTotal(2) As Single
    Dim this As New ChangePlace


    Public Ex_Point(2), Team_Point(2) As Single
    Dim w As Integer = 0

    Dim C_anime, C_tab As Object
    Dim Battle_Time As Boolean
    Dim C_message As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstP1_Chara_Idle.Items.Clear() : lstP1_Chara_Dist.Items.Clear()
        lstP2_Chara_Idle.Items.Clear() : lstP2_Chara_Dist.Items.Clear()
    End Sub



    Sub Calc(Now_idle As Object, Now_dist As Object, score As Object, num As Integer)
        Dim sngIdleTotal, sngDistTotal As Single
        If Now_idle.items.Count <> 0 Then
            sngIdleTotal = Now_idle.Items.Count * 3

            sngDistTotal = Now_dist.Items.Count * 1.5
        End If
        sngTotal(num) = sngIdleTotal + sngDistTotal + Ex_Point(num) + Team_Point(num)
        score.Text = sngTotal(num).ToString
    End Sub



    Private Sub tmrCal_Tick(sender As Object, e As EventArgs) Handles tmrCal.Tick
        Calc(lstP1_Chara_Idle, lstP1_Chara_Dist, lblTotal_P1, 1)
        Calc(lstP2_Chara_Idle, lstP2_Chara_Dist, lblTotal_P2, 2)
    End Sub

    Public Sub ChangeTurn(value As Integer)
        intk = value
        Debug.Print("Start value is " & intk)
    End Sub

    Public Sub GetTurn(Value As Integer)
        Value = intk
        Debug.Print("End value is " & Value)
    End Sub

    Private Sub FrmActualGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrCal.Enabled = True
        Dim randomizer As New Random()
        intk = randomizer.Next(0, 2)
        'this.start(intk)
        If intk = 1 Then
            MessageBox.Show("A player was picked randomly to go first, " & frmMainP1.txtNameP1.Text & " will be first")
        Else
            MessageBox.Show("A player was picked randomly to go first, " & frmMainP1.txtNameP2.Text & " will be first")
        End If
        GroupBox1.Text = frmMainP1.txtNameP1.Text & "'s Characters"
        GroupBox2.Text = frmMainP1.txtNameP2.Text & "'s Characters"
    End Sub



    Private Sub mnuHetalia_Click(sender As Object, e As EventArgs) Handles mnuHetalia.Click
        FrmHetalia.Show()
    End Sub
    Private Sub mnuBokuNoHeroAcademia_Click(sender As Object, e As EventArgs) Handles mnuBokuNoHeroAcademia.Click
        FrmBNHA.Show()
    End Sub


    Private Sub tmrTravel_Tick(sender As Object, e As EventArgs) Handles tmrTravel.Tick

        travel()
    End Sub
    Sub travel()
        'If lstP2_Chara_Idle.Items.Contains(FrmHetalia.strAPHCharaList(7)) Or lstP2_Chara_Dist.Items.Contains(FrmHetalia.strAPHCharaList(7)) Then 'p1 has China
        'If lstP1_Chara_Idle.Items.Contains(FrmHetalia.strAPHCharaList(18)) Then 'p1 has Hong Kong
        'this.add(lstP2_Chara_Idle, lstP1_Chara_Idle, FrmHetalia.strAPHCharaList(18))
        'End If
        'ElseIf lstP1_Chara_Idle.Items.Contains(FrmHetalia.strAPHCharaList(7)) Or lstP1_Chara_Dist.Items.Contains(FrmHetalia.strAPHCharaList(7)) Then 'p1 has China
        'If lstP2_Chara_Idle.Items.Contains(FrmHetalia.strAPHCharaList(18)) Then 'p1 has Hong Kong
        'this.add(lstP1_Chara_Idle, lstP2_Chara_Idle, FrmHetalia.strAPHCharaList(18))
        'End If
        'ElseIf lstP1_Chara_Idle.Items.Contains(FrmHetalia.strAPHCharaList(10)) Or lstP1_Chara_Dist.Items.Contains(FrmHetalia.strAPHCharaList(10)) Then 'p1 has England
        'If lstP2_Chara_Idle.Items.Contains(FrmHetalia.strAPHCharaList(18)) Then 'p1 has Hong Kong
        'this.add(lstP1_Chara_Idle, lstP2_Chara_Idle, FrmHetalia.strAPHCharaList(18))
        'End If
        'ElseIf lstP2_Chara_Idle.Items.Contains(FrmHetalia.sCharaList(10)) Or lstP2_Chara_Dist.Items.Contains(FrmHetalia.strAPHCharaList(10)) Then 'p1 has England
        'If lstP1_Chara_Idle.Items.Contains(FrmHetalia.strAPHCharaList(18)) Then 'p1 has Hong Kong
        'this.add(lstP2_Chara_Idle, lstP1_Chara_Idle, FrmHetalia.strAPHCharaList(18))
        'End If
        'End If
    End Sub

    Private Sub mnuDGrayMan_Click(sender As Object, e As EventArgs) Handles mnuDGrayMan.Click
        frmDGM.Show()
    End Sub


    Private Sub tmrBattle_Tick(sender As Object, e As EventArgs) Handles tmrBattle.Tick
        tmrBattle.Enabled = False
        Battle_Time = True
        battle(C_anime, C_tab, C_message)
    End Sub

    Public Sub battle(Anime As Object, tab As Object, Message As String)
        If Not Battle_Time Then
            tmrBattle.Enabled = True
            tab.visible = False
        Else
            Battle_Time = False
            tab.Visible = True
            tmrBattle.Enabled = False
            MessageBox.Show(Message)
        End If

        C_anime = Anime
        C_tab = tab
        C_message = Message

    End Sub
End Class


