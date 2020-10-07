<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAnimeP1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnAddP1 = New System.Windows.Forms.Button()
        Me.btnDeleteP1 = New System.Windows.Forms.Button()
        Me.btnDoneP1 = New System.Windows.Forms.Button()
        Me.lstWant = New System.Windows.Forms.ListBox()
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.cboShow = New System.Windows.Forms.ComboBox()
        Me.btnAddAll = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAddP1
        '
        Me.BtnAddP1.Location = New System.Drawing.Point(131, 286)
        Me.BtnAddP1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAddP1.Name = "BtnAddP1"
        Me.BtnAddP1.Size = New System.Drawing.Size(100, 28)
        Me.BtnAddP1.TabIndex = 3
        Me.BtnAddP1.Text = "Add"
        Me.BtnAddP1.UseVisualStyleBackColor = True
        '
        'btnDeleteP1
        '
        Me.btnDeleteP1.Location = New System.Drawing.Point(469, 235)
        Me.btnDeleteP1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDeleteP1.Name = "btnDeleteP1"
        Me.btnDeleteP1.Size = New System.Drawing.Size(100, 32)
        Me.btnDeleteP1.TabIndex = 4
        Me.btnDeleteP1.Text = "Remove"
        Me.btnDeleteP1.UseVisualStyleBackColor = True
        '
        'btnDoneP1
        '
        Me.btnDoneP1.Location = New System.Drawing.Point(469, 286)
        Me.btnDoneP1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDoneP1.Name = "btnDoneP1"
        Me.btnDoneP1.Size = New System.Drawing.Size(100, 28)
        Me.btnDoneP1.TabIndex = 5
        Me.btnDoneP1.Text = "Done"
        Me.btnDoneP1.UseVisualStyleBackColor = True
        '
        'lstWant
        '
        Me.lstWant.FormattingEnabled = True
        Me.lstWant.ItemHeight = 16
        Me.lstWant.Location = New System.Drawing.Point(347, 47)
        Me.lstWant.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstWant.Name = "lstWant"
        Me.lstWant.Size = New System.Drawing.Size(228, 180)
        Me.lstWant.TabIndex = 8
        '
        'lblPlayer1
        '
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.Location = New System.Drawing.Point(12, 18)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(108, 17)
        Me.lblPlayer1.TabIndex = 14
        Me.lblPlayer1.Text = "                         "
        '
        'cboShow
        '
        Me.cboShow.FormattingEnabled = True
        Me.cboShow.Items.AddRange(New Object() {"Aldnoah.Zero", "Black Butler", "Blue Exorcist", "Boku No Hero Academia", "Bungou Stray Dogs", "D.Gray-Man", "Dangan Ronpa The Series", "Dragonball", "Durarara", "Fairy Tail", "Fruit Basket", "Fullmetal Alchemist", "Gintama", "Hetalia", "Higurashi No Naku Koro NI", "Hitman Reborn", "Hunter x Hunter", "Inuyasha", "Kuroko No Basketball", "Maid-Sama", "Naruto", "No.6", "Noragami", "Pandora Hearts", "Re:Zero Kara Hajimeru Isekai Seikatsu", "Senyuu", "Seraph Of The End", "Soul Eater"})
        Me.cboShow.Location = New System.Drawing.Point(12, 47)
        Me.cboShow.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboShow.Name = "cboShow"
        Me.cboShow.Size = New System.Drawing.Size(296, 24)
        Me.cboShow.Sorted = True
        Me.cboShow.TabIndex = 15
        '
        'btnAddAll
        '
        Me.btnAddAll.Location = New System.Drawing.Point(12, 282)
        Me.btnAddAll.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddAll.Name = "btnAddAll"
        Me.btnAddAll.Size = New System.Drawing.Size(100, 32)
        Me.btnAddAll.TabIndex = 16
        Me.btnAddAll.Text = "Add All"
        Me.btnAddAll.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(347, 286)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 28)
        Me.btnBack.TabIndex = 17
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(239, 284)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 28)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmAnimeP1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 327)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAddAll)
        Me.Controls.Add(Me.cboShow)
        Me.Controls.Add(Me.lblPlayer1)
        Me.Controls.Add(Me.lstWant)
        Me.Controls.Add(Me.btnDoneP1)
        Me.Controls.Add(Me.btnDeleteP1)
        Me.Controls.Add(Me.BtnAddP1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmAnimeP1"
        Me.Text = "Anime Shows"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAddP1 As Button
    Friend WithEvents btnDeleteP1 As Button
    Friend WithEvents btnDoneP1 As Button
    Friend WithEvents lstWant As ListBox
    Friend WithEvents lblPlayer1 As Label
    Friend WithEvents cboShow As ComboBox
    Friend WithEvents btnAddAll As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClear As Button
End Class
