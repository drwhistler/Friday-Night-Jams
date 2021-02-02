<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListBox_ArenaIn = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveFromArenaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToArenaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox_Challenger = New System.Windows.Forms.TextBox()
        Me.TextBox_Opponent1 = New System.Windows.Forms.TextBox()
        Me.TextBox_Opponent2 = New System.Windows.Forms.TextBox()
        Me.TextBox_Opponent3 = New System.Windows.Forms.TextBox()
        Me.Label_Challenger = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label_Opponent1Region = New System.Windows.Forms.Label()
        Me.Label_Opponent2Region = New System.Windows.Forms.Label()
        Me.Label_Opponent3Region = New System.Windows.Forms.Label()
        Me.Label_CompletedChallenges = New System.Windows.Forms.Label()
        Me.Label_Opponents = New System.Windows.Forms.Label()
        Me.Label_Challengers = New System.Windows.Forms.Label()
        Me.ListBox_Challengers = New System.Windows.Forms.ListBox()
        Me.ListBox_CompletedChallenges = New System.Windows.Forms.ListBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Participant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Matches = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListBox_ArenaOut = New System.Windows.Forms.ListBox()
        Me.Button_Knockout = New System.Windows.Forms.Button()
        Me.Button_AdvRndBonus = New System.Windows.Forms.Button()
        Me.Button_AdvRnd = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArenaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearArenaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterSelfIntoArenaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox_ArenaIn
        '
        Me.ListBox_ArenaIn.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListBox_ArenaIn.FormattingEnabled = True
        Me.ListBox_ArenaIn.Location = New System.Drawing.Point(30, 64)
        Me.ListBox_ArenaIn.Name = "ListBox_ArenaIn"
        Me.ListBox_ArenaIn.Size = New System.Drawing.Size(162, 95)
        Me.ListBox_ArenaIn.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.ToolStripSeparator1, Me.RemoveFromArenaToolStripMenuItem, Me.AddToArenaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(183, 76)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(179, 6)
        '
        'RemoveFromArenaToolStripMenuItem
        '
        Me.RemoveFromArenaToolStripMenuItem.Name = "RemoveFromArenaToolStripMenuItem"
        Me.RemoveFromArenaToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.RemoveFromArenaToolStripMenuItem.Text = "Remove From Arena"
        '
        'AddToArenaToolStripMenuItem
        '
        Me.AddToArenaToolStripMenuItem.Name = "AddToArenaToolStripMenuItem"
        Me.AddToArenaToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.AddToArenaToolStripMenuItem.Text = "Return To Arena"
        '
        'TextBox_Challenger
        '
        Me.TextBox_Challenger.AllowDrop = True
        Me.TextBox_Challenger.Location = New System.Drawing.Point(208, 63)
        Me.TextBox_Challenger.Name = "TextBox_Challenger"
        Me.TextBox_Challenger.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Challenger.TabIndex = 2
        '
        'TextBox_Opponent1
        '
        Me.TextBox_Opponent1.AllowDrop = True
        Me.TextBox_Opponent1.HideSelection = False
        Me.TextBox_Opponent1.Location = New System.Drawing.Point(321, 115)
        Me.TextBox_Opponent1.Name = "TextBox_Opponent1"
        Me.TextBox_Opponent1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Opponent1.TabIndex = 3
        '
        'TextBox_Opponent2
        '
        Me.TextBox_Opponent2.AllowDrop = True
        Me.TextBox_Opponent2.Location = New System.Drawing.Point(321, 89)
        Me.TextBox_Opponent2.Name = "TextBox_Opponent2"
        Me.TextBox_Opponent2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Opponent2.TabIndex = 4
        '
        'TextBox_Opponent3
        '
        Me.TextBox_Opponent3.AllowDrop = True
        Me.TextBox_Opponent3.Location = New System.Drawing.Point(321, 63)
        Me.TextBox_Opponent3.Name = "TextBox_Opponent3"
        Me.TextBox_Opponent3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Opponent3.TabIndex = 5
        '
        'Label_Challenger
        '
        Me.Label_Challenger.AutoSize = True
        Me.Label_Challenger.Location = New System.Drawing.Point(205, 47)
        Me.Label_Challenger.Name = "Label_Challenger"
        Me.Label_Challenger.Size = New System.Drawing.Size(57, 13)
        Me.Label_Challenger.TabIndex = 6
        Me.Label_Challenger.Text = "Challenger"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(398, 155)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 22)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Reset Tower"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Participants"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(205, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Court: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(205, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Region: "
        '
        'Label_Opponent1Region
        '
        Me.Label_Opponent1Region.AutoSize = True
        Me.Label_Opponent1Region.Location = New System.Drawing.Point(424, 118)
        Me.Label_Opponent1Region.Name = "Label_Opponent1Region"
        Me.Label_Opponent1Region.Size = New System.Drawing.Size(44, 13)
        Me.Label_Opponent1Region.TabIndex = 12
        Me.Label_Opponent1Region.Text = "Region:"
        '
        'Label_Opponent2Region
        '
        Me.Label_Opponent2Region.AutoSize = True
        Me.Label_Opponent2Region.Location = New System.Drawing.Point(424, 92)
        Me.Label_Opponent2Region.Name = "Label_Opponent2Region"
        Me.Label_Opponent2Region.Size = New System.Drawing.Size(44, 13)
        Me.Label_Opponent2Region.TabIndex = 13
        Me.Label_Opponent2Region.Text = "Region:"
        '
        'Label_Opponent3Region
        '
        Me.Label_Opponent3Region.AutoSize = True
        Me.Label_Opponent3Region.Location = New System.Drawing.Point(424, 66)
        Me.Label_Opponent3Region.Name = "Label_Opponent3Region"
        Me.Label_Opponent3Region.Size = New System.Drawing.Size(47, 13)
        Me.Label_Opponent3Region.TabIndex = 14
        Me.Label_Opponent3Region.Text = "Region: "
        '
        'Label_CompletedChallenges
        '
        Me.Label_CompletedChallenges.AutoSize = True
        Me.Label_CompletedChallenges.Location = New System.Drawing.Point(371, 185)
        Me.Label_CompletedChallenges.Name = "Label_CompletedChallenges"
        Me.Label_CompletedChallenges.Size = New System.Drawing.Size(112, 13)
        Me.Label_CompletedChallenges.TabIndex = 17
        Me.Label_CompletedChallenges.Text = "Completed Challenges"
        '
        'Label_Opponents
        '
        Me.Label_Opponents.AutoSize = True
        Me.Label_Opponents.Location = New System.Drawing.Point(329, 47)
        Me.Label_Opponents.Name = "Label_Opponents"
        Me.Label_Opponents.Size = New System.Drawing.Size(59, 13)
        Me.Label_Opponents.TabIndex = 18
        Me.Label_Opponents.Text = "Opponents"
        '
        'Label_Challengers
        '
        Me.Label_Challengers.AutoSize = True
        Me.Label_Challengers.Location = New System.Drawing.Point(205, 188)
        Me.Label_Challengers.Name = "Label_Challengers"
        Me.Label_Challengers.Size = New System.Drawing.Size(88, 13)
        Me.Label_Challengers.TabIndex = 20
        Me.Label_Challengers.Text = "Open Challenges"
        '
        'ListBox_Challengers
        '
        Me.ListBox_Challengers.FormattingEnabled = True
        Me.ListBox_Challengers.Location = New System.Drawing.Point(206, 204)
        Me.ListBox_Challengers.Name = "ListBox_Challengers"
        Me.ListBox_Challengers.Size = New System.Drawing.Size(162, 69)
        Me.ListBox_Challengers.TabIndex = 19
        '
        'ListBox_CompletedChallenges
        '
        Me.ListBox_CompletedChallenges.AllowDrop = True
        Me.ListBox_CompletedChallenges.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListBox_CompletedChallenges.FormattingEnabled = True
        Me.ListBox_CompletedChallenges.Location = New System.Drawing.Point(374, 204)
        Me.ListBox_CompletedChallenges.Name = "ListBox_CompletedChallenges"
        Me.ListBox_CompletedChallenges.Size = New System.Drawing.Size(162, 69)
        Me.ListBox_CompletedChallenges.TabIndex = 15
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Participant, Me.SR, Me.Matches, Me.Timer})
        Me.DataGridView1.Location = New System.Drawing.Point(30, 279)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.Size = New System.Drawing.Size(506, 199)
        Me.DataGridView1.TabIndex = 21
        '
        'Participant
        '
        Me.Participant.HeaderText = "Participant"
        Me.Participant.Name = "Participant"
        '
        'SR
        '
        Me.SR.HeaderText = "Skill Rating"
        Me.SR.Name = "SR"
        '
        'Matches
        '
        Me.Matches.HeaderText = "Matches"
        Me.Matches.Name = "Matches"
        '
        'Timer
        '
        Me.Timer.HeaderText = "Timer"
        Me.Timer.Name = "Timer"
        '
        'ListBox_ArenaOut
        '
        Me.ListBox_ArenaOut.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListBox_ArenaOut.FormattingEnabled = True
        Me.ListBox_ArenaOut.Location = New System.Drawing.Point(30, 165)
        Me.ListBox_ArenaOut.Name = "ListBox_ArenaOut"
        Me.ListBox_ArenaOut.Size = New System.Drawing.Size(162, 108)
        Me.ListBox_ArenaOut.TabIndex = 22
        '
        'Button_Knockout
        '
        Me.Button_Knockout.Location = New System.Drawing.Point(317, 155)
        Me.Button_Knockout.Name = "Button_Knockout"
        Me.Button_Knockout.Size = New System.Drawing.Size(75, 21)
        Me.Button_Knockout.TabIndex = 23
        Me.Button_Knockout.Text = "Knockout"
        Me.Button_Knockout.UseVisualStyleBackColor = True
        '
        'Button_AdvRndBonus
        '
        Me.Button_AdvRndBonus.Location = New System.Drawing.Point(218, 155)
        Me.Button_AdvRndBonus.Name = "Button_AdvRndBonus"
        Me.Button_AdvRndBonus.Size = New System.Drawing.Size(75, 21)
        Me.Button_AdvRndBonus.TabIndex = 25
        Me.Button_AdvRndBonus.Text = "Adv Bonus"
        Me.Button_AdvRndBonus.UseVisualStyleBackColor = True
        '
        'Button_AdvRnd
        '
        Me.Button_AdvRnd.Location = New System.Drawing.Point(218, 128)
        Me.Button_AdvRnd.Name = "Button_AdvRnd"
        Me.Button_AdvRnd.Size = New System.Drawing.Size(75, 21)
        Me.Button_AdvRnd.TabIndex = 27
        Me.Button_AdvRnd.Text = "Advance"
        Me.Button_AdvRnd.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArenaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(554, 24)
        Me.MenuStrip1.TabIndex = 28
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArenaToolStripMenuItem
        '
        Me.ArenaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.ClearArenaToolStripMenuItem, Me.EnterSelfIntoArenaToolStripMenuItem})
        Me.ArenaToolStripMenuItem.Name = "ArenaToolStripMenuItem"
        Me.ArenaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ArenaToolStripMenuItem.Text = "Arena"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ClearArenaToolStripMenuItem
        '
        Me.ClearArenaToolStripMenuItem.Name = "ClearArenaToolStripMenuItem"
        Me.ClearArenaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ClearArenaToolStripMenuItem.Text = "Clear Arena"
        '
        'EnterSelfIntoArenaToolStripMenuItem
        '
        Me.EnterSelfIntoArenaToolStripMenuItem.Name = "EnterSelfIntoArenaToolStripMenuItem"
        Me.EnterSelfIntoArenaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.EnterSelfIntoArenaToolStripMenuItem.Text = "Enter Self Into Arena"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 490)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button_AdvRnd)
        Me.Controls.Add(Me.Button_AdvRndBonus)
        Me.Controls.Add(Me.Button_Knockout)
        Me.Controls.Add(Me.ListBox_ArenaOut)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label_Challengers)
        Me.Controls.Add(Me.ListBox_Challengers)
        Me.Controls.Add(Me.Label_Opponents)
        Me.Controls.Add(Me.Label_CompletedChallenges)
        Me.Controls.Add(Me.ListBox_CompletedChallenges)
        Me.Controls.Add(Me.Label_Opponent3Region)
        Me.Controls.Add(Me.Label_Opponent2Region)
        Me.Controls.Add(Me.Label_Opponent1Region)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label_Challenger)
        Me.Controls.Add(Me.TextBox_Opponent3)
        Me.Controls.Add(Me.TextBox_Opponent2)
        Me.Controls.Add(Me.TextBox_Opponent1)
        Me.Controls.Add(Me.TextBox_Challenger)
        Me.Controls.Add(Me.ListBox_ArenaIn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Friday Night Jams"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox_ArenaIn As ListBox
    Friend WithEvents TextBox_Challenger As TextBox
    Friend WithEvents TextBox_Opponent1 As TextBox
    Friend WithEvents TextBox_Opponent2 As TextBox
    Friend WithEvents TextBox_Opponent3 As TextBox
    Friend WithEvents Label_Challenger As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label_Opponent1Region As Label
    Friend WithEvents Label_Opponent2Region As Label
    Friend WithEvents Label_Opponent3Region As Label
    Friend WithEvents Label_CompletedChallenges As Label
    Friend WithEvents Label_Opponents As Label
    Friend WithEvents Label_Challengers As Label
    Friend WithEvents ListBox_Challengers As ListBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox_CompletedChallenges As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents RemoveFromArenaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox_ArenaOut As ListBox
    Friend WithEvents AddToArenaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Participant As DataGridViewTextBoxColumn
    Friend WithEvents SR As DataGridViewTextBoxColumn
    Friend WithEvents Matches As DataGridViewTextBoxColumn
    Friend WithEvents Timer As DataGridViewTextBoxColumn
    Friend WithEvents Button_Knockout As Button
    Friend WithEvents Button_AdvRndBonus As Button
    Friend WithEvents Button_AdvRnd As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArenaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearArenaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnterSelfIntoArenaToolStripMenuItem As ToolStripMenuItem
End Class

