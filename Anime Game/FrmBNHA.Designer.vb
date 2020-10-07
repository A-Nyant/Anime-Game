<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBNHA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstBNHA_Chara = New System.Windows.Forms.ListBox()
        Me.btnGo_P1 = New System.Windows.Forms.Button()
        Me.btnGo_P2 = New System.Windows.Forms.Button()
        Me.tmrDekuvTodo = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 0
        '
        'lstBNHA_Chara
        '
        Me.lstBNHA_Chara.FormattingEnabled = True
        Me.lstBNHA_Chara.ItemHeight = 16
        Me.lstBNHA_Chara.Items.AddRange(New Object() {"All For One", "All Might/Toshinori Yagi", "Atsuhiro Sako/Mr. Compress", "Chiyo Shuuzenji/Recovery Girl", "Chizome Akaguro/Stain, The Hero Killer", "Dabi", "Denki Kaminari", "Ectoplasm", "Eijiro Kirishima", "Enji Todoroki/Endeavor", "Fumikage Torkoyami", "Hanto Sero", "Himiko Toga", "Hitoshi Shinso", "Hizashi Yamada/Present Mic", "Ibara Shiozaki", "Inasa Yoarashi", "Itsuka Kendo", "Izuku ""Deku"" Midoriya", "Jin Bubaigawara/Twice", "Katsuki Bakugo/Kacchan", "Kenji Hikiishi/Magne", "Koji Koda", "Kota Izumi", "Kugo Sakamata/Gang Orca", "Kurogiri", "Kyoka Jiro", "Mashirao Ojiro", "Mei Hatsume", "Mezo Shoji", "Mino Ashido", "Minoru Mineta", "Mirio Togata", "Momo Yaoyorozu", "Moonfish", "Muscular", "Mustard", "Nana Shimura", "Neito Monoma", "Nemuri Kayama/Midnight", "Nezu", "Noumu", "Ochaku Uraraku", "Rikido Sato", "Seiji Shishikura", "Shinji Nishiya/Kamui Woods", "Shota Aizawa/Eraser Head", "Shoto Todoroki", "Shuichi Iguchi/Spinner", "Sorahiko/Gran Torino", "Tensei Lida/Ingenium", "Tenya Lida", "Tetsutetsu Tetsutetsu", "Thirteen", "Tomoko Shiretoko/Ragdoll", "Tomura Shigaraki", "Toru Hagakure", "Tsunagu Hakamada/Beat Jeanist", "Tsuyu Asui", "Yosetsu Awase", "Yu Takeyama/Mt. Lady", "Yuga Aoyama"})
        Me.lstBNHA_Chara.Location = New System.Drawing.Point(23, 38)
        Me.lstBNHA_Chara.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstBNHA_Chara.Name = "lstBNHA_Chara"
        Me.lstBNHA_Chara.Size = New System.Drawing.Size(289, 276)
        Me.lstBNHA_Chara.TabIndex = 1
        '
        'btnGo_P1
        '
        Me.btnGo_P1.Location = New System.Drawing.Point(241, 350)
        Me.btnGo_P1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGo_P1.Name = "btnGo_P1"
        Me.btnGo_P1.Size = New System.Drawing.Size(100, 43)
        Me.btnGo_P1.TabIndex = 2
        Me.btnGo_P1.Text = "Pick"
        Me.btnGo_P1.UseVisualStyleBackColor = True
        '
        'btnGo_P2
        '
        Me.btnGo_P2.Location = New System.Drawing.Point(241, 350)
        Me.btnGo_P2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGo_P2.Name = "btnGo_P2"
        Me.btnGo_P2.Size = New System.Drawing.Size(100, 43)
        Me.btnGo_P2.TabIndex = 3
        Me.btnGo_P2.Text = "Pick"
        Me.btnGo_P2.UseVisualStyleBackColor = True
        '
        'tmrDekuvTodo
        '
        '
        'FrmBNHA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 428)
        Me.Controls.Add(Me.btnGo_P2)
        Me.Controls.Add(Me.btnGo_P1)
        Me.Controls.Add(Me.lstBNHA_Chara)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmBNHA"
        Me.Text = "FrmBNHA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstBNHA_Chara As ListBox
    Friend WithEvents btnGo_P1 As Button
    Friend WithEvents btnGo_P2 As Button
    Friend WithEvents tmrDekuvTodo As Timer
End Class
