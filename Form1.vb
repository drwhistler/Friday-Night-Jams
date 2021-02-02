Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, ex As EventArgs) Handles MyBase.Load

        If Not File.ReadAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\participants_in.txt").Length = 0 Then

            Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\participants_in.txt")
            While Not rdr.EndOfStream
                Dim line As String = rdr.ReadLine()
                ListBox_ArenaIn.Items.Add(line)
                ListBox_Challengers.Items.Add(line)

                'Read Challengers profile
                Dim rdr2 As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\profiles\" + line + ".txt")
                Dim profile = rdr2.ReadLine().Split(","c)
                rdr2.Close()

                'Read Challengers session file
                If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\session\" + line + ".txt") Then
                    Dim rdr3 As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\session\" + line + ".txt")
                    Dim session = rdr3.ReadLine().Split(","c)
                    rdr3.Close()

                    DataGridView1.Rows.Add(New String() {line, profile(4), session(1)})
                Else
                    DataGridView1.Rows.Add(New String() {line, profile(4)})
                End If
            End While
            rdr.Close()

        End If

        Dim rdr4 As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\participants_out.txt")
        While Not rdr4.EndOfStream
            Dim line As String = rdr4.ReadLine()
            ListBox_ArenaOut.Items.Add(line)
        End While
        rdr4.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        'Save all Session results and empty DataGrid
        For j = DataGridView1.RowCount - 1 To 0 Step -1
            Dim SW2 As IO.StreamWriter = New StreamWriter("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\session\" + DataGridView1(0, j).Value + ".txt", False)
            SW2.WriteLine(DataGridView1(0, j).Value + "," + DataGridView1(2, j).Value)
            SW2.Close()
        Next
        DataGridView1.Rows.Clear()

        'Empty ArenaIn Listbox
        ListBox_ArenaIn.Items.Clear()

        'Read and add from current participants list
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\participants_in.txt")

        While Not rdr.EndOfStream
            Dim line As String = rdr.ReadLine()

            ListBox_ArenaIn.Items.Add(line)

            If ListBox_Challengers.Items.Contains(line) Or ListBox_CompletedChallenges.Items.Contains(line) Then
            Else
                ListBox_Challengers.Items.Add(line)
            End If

            'Read Challengers profile
            Dim rdr2 As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\profiles\" + line + ".txt")
            Dim profile = rdr2.ReadLine().Split(","c)
            rdr2.Close()

            'Read Challengers session file
            If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\session\" + line + ".txt") Then
                rdr2 = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\session\" + line + ".txt")
                Dim session = rdr2.ReadLine().Split(","c)
                rdr2.Close()

                DataGridView1.Rows.Add(New String() {line, profile(4), session(1)})
            Else
                DataGridView1.Rows.Add(New String() {line, profile(4)})
            End If

        End While
        rdr.Close()

        'Read and add from participants out list
        ListBox_ArenaOut.Items.Clear()
        rdr = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\participants_out.txt")
        While Not rdr.EndOfStream
            Dim line As String = rdr.ReadLine()
            ListBox_ArenaOut.Items.Add(line)
        End While
        rdr.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Clear Challenger and Opponent Text Boxes
        TextBox_Challenger.Text = ""
        TextBox_Opponent1.Text = ""
        TextBox_Opponent2.Text = ""
        TextBox_Opponent3.Text = ""

        'Clear Challenger Preferred Court Label
        Label4.Text = "Court:"

        'Clear Challengers and Opponents Preferred Region Labels
        Label5.Text = "Region: "
        Label_Opponent1Region.Text = "Region: "
        Label_Opponent2Region.Text = "Region: "
        Label_Opponent3Region.Text = "Region: "

        'Refresh participatns list
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\participants_in.txt")
        ListBox_ArenaIn.Items.Clear()
        While Not rdr.EndOfStream
            Dim line As String = rdr.ReadLine()
            ListBox_ArenaIn.Items.Add(line)
        End While
        rdr.Close()

        'Reset Round, Challenger, ChallengeMaster, and Opponent text files
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\round.txt", "1")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\challengerName.txt", "")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\challengerPoints.txt", "")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\challengeMaster.txt", "")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\opponent1.txt", "")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\opponent2.txt", "")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\opponent3.txt", "")

        'Remove Challenger Splat and Image
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\challengerSplatB.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\challengerSpaltB.png")
        End If
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\challenger.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\challenger.png")
        End If

        'Remove Opponent Splat Images
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\opponentSplat1B.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\opponentSplat1B.png")
        End If
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\opponentSplat2B.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\opponentSplat2B.png")
        End If
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\opponentSplat3B.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\opponentSplat3B.png")
        End If

        'Remove Opponent Images
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\opponent1.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\opponent1.png")
        End If
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\opponent2.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\opponent2.png")
        End If
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\opponent3.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\opponent3.png")
        End If

    End Sub

    Private Sub Listbox_Arena_Mousedown(ByVal Sender As Object,
                                   ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox_ArenaIn.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Me.ListBox_ArenaIn.SelectedIndex >= 0 Then
                ListBox_ArenaIn.DoDragDrop(ListBox_ArenaIn.SelectedItem, DragDropEffects.Copy Or DragDropEffects.Move)
            End If
        End If

        'If e.Button = Windows.Forms.MouseButtons.Right Then
        '       ContextMenuStrip1.Show(MousePosition)
        'End If

    End Sub

    Private Sub TextBox1_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox_Challenger.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub TextBox1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox_Challenger.DragDrop

        TextBox_Challenger.Text = e.Data.GetData(DataFormats.Text).ToString
        'ListBox1.Items.Remove(e.Data.GetData(DataFormats.Text).ToString)

        'Set Challengers name
        Dim inputString As String = e.Data.GetData(DataFormats.Text).ToString
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\challengerName.txt", inputString)

        'Read Challengers profile
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\profiles\" + e.Data.GetData(DataFormats.Text) + ".txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        'Set Challengers Main and Skin
        Dim profile As String() = line.Split(","c)
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\challenger.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\challenger.png")
        End If
        My.Computer.FileSystem.CopyFile(
            "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\" + profile(2) + "-" + profile(3) + ".png",
            "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\challenger.png")

        'Set Challengers Preferred Court and Region
        If (profile(1) = "random") Then
            Label4.Text = "Court: Random"
        End If
        If (profile(1) = "stadium") Then
            Label4.Text = "Court: Stadium"
        End If
        If (profile(1) = "penthouse") Then
            Label4.Text = "Court: Penthouse"
        End If

        If (profile(0) = "e") Then
            Label5.Text = "Region: US East"
        End If
        If (profile(0) = "w") Then
            Label5.Text = "Region: US West"
        End If
        If (profile(0) = "eu") Then
            Label5.Text = "Region: Europe"
        End If
        If (profile(0) = "s") Then
            Label5.Text = "Region: South America"
        End If
        If (profile(0) = "o") Then
            Label5.Text = "Region: Oceania"
        End If
        If (profile(0) = "a") Then
            Label5.Text = "Region: Southeast Asia"
        End If

        'Read and set Challengers Session Score
        Dim score As String
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\scoreSession\" + e.Data.GetData(DataFormats.Text) + ".txt") Then
            rdr = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\scoreSession\" + e.Data.GetData(DataFormats.Text) + ".txt")
            score = rdr.ReadLine()
            rdr.Close()
        Else
            score = "0"
        End If

        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\challengerPoints.txt", score)

        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\introductions\" + e.Data.GetData(DataFormats.Text) + ".mp3") Then
            Dim Wave2 As New NAudio.Wave.WaveOut
            Dim soundFile2 As String = "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\introductions\" + e.Data.GetData(DataFormats.Text) + ".mp3"
            Dim data2 As New NAudio.Wave.Mp3FileReader(soundFile2)
            Wave2.Init(data2)
            Wave2.Volume = 0.5 'Sets the Volume to 50%
            Wave2.Play()
            'Wave2.Dispose()
        Else
            Dim Wave1 As New NAudio.Wave.WaveOut
            Dim soundFile As String = "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\introductions\newchallenger.mp3"
            Dim data As New NAudio.Wave.Mp3FileReader(soundFile)
            Wave1.Init(data)
            Wave1.Volume = 0.3 'Sets the Volume to 50%
            Wave1.Play()
            'Wave1.Dispose()
        End If

    End Sub

    Private Sub TextBox2_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox_Opponent1.DragEnter
        e.Effect = DragDropEffects.Move

    End Sub

    Private Sub TextBox2_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox_Opponent1.DragDrop
        TextBox_Opponent1.Text = e.Data.GetData(DataFormats.Text).ToString
        'ListBox1.Items.Remove(e.Data.GetData(DataFormats.Text).ToString)

        Dim inputString As String = e.Data.GetData(DataFormats.Text).ToString
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\opponent1.txt", inputString)

        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\profiles\" + e.Data.GetData(DataFormats.Text) + ".txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        Dim profile As String() = line.Split(","c)

        'Set Challengers Preferred Court and Region
        If (profile(0) = "e") Then
            Label_Opponent1Region.Text = "Region: US East"
        End If
        If (profile(0) = "w") Then
            Label_Opponent1Region.Text = "Region: US West"
        End If
        If (profile(0) = "eu") Then
            Label_Opponent1Region.Text = "Region: Europe"
        End If
        If (profile(0) = "s") Then
            Label_Opponent1Region.Text = "Region: South America"
        End If
        If (profile(0) = "o") Then
            Label_Opponent1Region.Text = "Region: Oceania"
        End If
        If (profile(0) = "a") Then
            Label_Opponent1Region.Text = "Region: Southeast Asia"
        End If

        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\opponent1.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\opponent1.png")
        End If

        My.Computer.FileSystem.CopyFile(
          "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\" + profile(2) + "-" + profile(3) + ".png",
          "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\opponent1.png")

    End Sub

    Private Sub TextBox3_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox_Opponent2.DragEnter
        e.Effect = DragDropEffects.Move

    End Sub

    Private Sub TextBox3_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox_Opponent2.DragDrop
        TextBox_Opponent2.Text = e.Data.GetData(DataFormats.Text).ToString
        'ListBox1.Items.Remove(e.Data.GetData(DataFormats.Text).ToString)

        Dim inputString As String = e.Data.GetData(DataFormats.Text).ToString
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\opponent2.txt", inputString)

        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\profiles\" + e.Data.GetData(DataFormats.Text) + ".txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        Dim profile As String() = line.Split(","c)

        'Set Challengers Preferred Court and Region
        If (profile(0) = "e") Then
            Label_Opponent2Region.Text = "Region: US East"
        End If
        If (profile(0) = "w") Then
            Label_Opponent2Region.Text = "Region: US West"
        End If
        If (profile(0) = "eu") Then
            Label_Opponent2Region.Text = "Region: Europe"
        End If
        If (profile(0) = "s") Then
            Label_Opponent2Region.Text = "Region: South America"
        End If
        If (profile(0) = "o") Then
            Label_Opponent2Region.Text = "Region: Oceania"
        End If
        If (profile(0) = "a") Then
            Label_Opponent2Region.Text = "Region: Southeast Asia"
        End If

        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\opponent2.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\opponent2.png")
        End If

        My.Computer.FileSystem.CopyFile(
            "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\" + profile(2) + "-" + profile(3) + ".png",
            "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\opponent2.png")

    End Sub

    Private Sub TextBox4_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox_Opponent3.DragEnter
        e.Effect = DragDropEffects.Move

    End Sub

    Private Sub TextBox4_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox_Opponent3.DragDrop
        TextBox_Opponent3.Text = e.Data.GetData(DataFormats.Text).ToString
        'ListBox1.Items.Remove(e.Data.GetData(DataFormats.Text).ToString)

        Dim inputString As String = e.Data.GetData(DataFormats.Text).ToString
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\opponent3.txt", inputString)

        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\profiles\" + e.Data.GetData(DataFormats.Text) + ".txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        Dim profile As String() = line.Split(","c)


        'Set Challengers Preferred Court and Region
        If (profile(0) = "e") Then
            Label_Opponent3Region.Text = "Region: US East"
        End If
        If (profile(0) = "w") Then
            Label_Opponent3Region.Text = "Region: US West"
        End If
        If (profile(0) = "eu") Then
            Label_Opponent3Region.Text = "Region: Europe"
        End If
        If (profile(0) = "s") Then
            Label_Opponent3Region.Text = "Region: South America"
        End If
        If (profile(0) = "o") Then
            Label_Opponent3Region.Text = "Region: Oceania"
        End If
        If (profile(0) = "a") Then
            Label_Opponent3Region.Text = "Region: Southeast Asia"
        End If

        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\opponent3.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\opponent3.png")
        End If
        My.Computer.FileSystem.CopyFile(
            "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\" + profile(2) + "-" + profile(3) + ".png",
            "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamFNJ\images\opponent3.png")
    End Sub

    Private Sub Listbox_Challengers_Mousedown(ByVal Sender As Object,
                                   ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox_Challengers.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Me.ListBox_Challengers.SelectedIndex >= 0 Then
                ListBox_Challengers.DoDragDrop(ListBox_Challengers.SelectedItem, DragDropEffects.Copy Or DragDropEffects.Move)
            End If
        End If


    End Sub

    Private Sub ListBox_CompletedChallenges_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBox_CompletedChallenges.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub ListBox_CompletedChallenges_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBox_CompletedChallenges.DragDrop
        ListBox_CompletedChallenges.Items.Add(e.Data.GetData(DataFormats.Text).ToString)
        ListBox_Challengers.Items.Remove(e.Data.GetData(DataFormats.Text).ToString)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If Me.ListBox_CompletedChallenges.SelectedIndex >= 0 Then
            If ListBox_ArenaIn.Items.Contains(ListBox_CompletedChallenges.SelectedItem) Then
                ListBox_Challengers.Items.Add(ListBox_CompletedChallenges.SelectedItem)
            End If
            ListBox_CompletedChallenges.Items.Remove(ListBox_CompletedChallenges.SelectedItem)
        End If
    End Sub

    Private Sub RemoveArenaParticipant_Click(sender As Object, e As EventArgs) Handles RemoveFromArenaToolStripMenuItem.Click

        If Me.ListBox_ArenaIn.SelectedIndex >= 0 Then

            For j = DataGridView1.RowCount - 1 To 0 Step -1
                If DataGridView1(0, j).Value = ListBox_ArenaIn.SelectedItem.ToString Then
                    Dim SW2 As IO.StreamWriter = New StreamWriter("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\session\" + DataGridView1(0, j).Value + ".txt", False)
                    SW2.WriteLine(DataGridView1(0, j).Value + "," + DataGridView1(2, j).Value)
                    SW2.Close()

                    DataGridView1.Rows.RemoveAt(j)
                End If
            Next

            ListBox_Challengers.Items.Remove(ListBox_ArenaIn.SelectedItem)
            ListBox_ArenaOut.Items.Add(ListBox_ArenaIn.SelectedItem)
            ListBox_ArenaIn.Items.Remove(ListBox_ArenaIn.SelectedItem)

            Dim SW As IO.StreamWriter = New StreamWriter("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\participants_in.txt", False)
            For Each S As String In ListBox_ArenaIn.Items
                SW.WriteLine(S)
            Next
            SW.Close()

            SW = New StreamWriter("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\participants_out.txt", False)
            For Each S As String In ListBox_ArenaOut.Items
                SW.WriteLine(S)
            Next
            SW.Close()


        End If

    End Sub

    Private Sub AddToArenaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToArenaToolStripMenuItem.Click

        If Me.ListBox_ArenaOut.SelectedIndex >= 0 Then


            'Read Challengers profile
            Dim rdr2 As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\profiles\" + ListBox_ArenaOut.SelectedItem.ToString + ".txt")
            Dim profile = rdr2.ReadLine().Split(","c)
            rdr2.Close()

            'Read Challengers session file
            rdr2 = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\session\" + ListBox_ArenaOut.SelectedItem.ToString + ".txt")
            Dim session = rdr2.ReadLine().Split(","c)
            rdr2.Close()

            DataGridView1.Rows.Add(New String() {ListBox_ArenaOut.SelectedItem.ToString, profile(4), session(1)})

            If ListBox_Challengers.Items.Contains(ListBox_ArenaOut.SelectedItem) Or ListBox_CompletedChallenges.Items.Contains(ListBox_ArenaOut.SelectedItem) Then
            Else
                ListBox_Challengers.Items.Add(ListBox_ArenaOut.SelectedItem)
            End If

            ListBox_ArenaIn.Items.Add(ListBox_ArenaOut.SelectedItem)
            ListBox_ArenaOut.Items.Remove(ListBox_ArenaOut.SelectedItem)

            Dim SW As IO.StreamWriter = New StreamWriter("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\participants_in.txt", False)
            For Each S As String In ListBox_ArenaIn.Items
                SW.WriteLine(S)
            Next
            SW.Close()

            SW = New StreamWriter("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\participants_out.txt", False)
            For Each S As String In ListBox_ArenaOut.Items
                SW.WriteLine(S)
            Next
            SW.Close()

        End If

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click

        'Save all Session results and empty DataGrid
        For j = DataGridView1.RowCount - 1 To 0 Step -1
            Dim SW2 As IO.StreamWriter = New StreamWriter("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\session\" + DataGridView1(0, j).Value + ".txt", False)
            SW2.WriteLine(DataGridView1(0, j).Value + "," + DataGridView1(2, j).Value)
            SW2.Close()
        Next
        DataGridView1.Rows.Clear()

        'Empty ArenaIn Listbox
        ListBox_ArenaIn.Items.Clear()

        'Read and add from current participants list
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\participants_in.txt")

        While Not rdr.EndOfStream
            Dim line As String = rdr.ReadLine()

            ListBox_ArenaIn.Items.Add(line)

            If ListBox_Challengers.Items.Contains(line) Or ListBox_CompletedChallenges.Items.Contains(line) Then
            Else
                ListBox_Challengers.Items.Add(line)
            End If

            'Read Challengers profile
            Dim rdr2 As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\profiles\" + line + ".txt")
            Dim profile = rdr2.ReadLine().Split(","c)
            rdr2.Close()

            'Read Challengers session file
            If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\session\" + line + ".txt") Then
                rdr2 = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\session\" + line + ".txt")
                Dim session = rdr2.ReadLine().Split(","c)
                rdr2.Close()

                DataGridView1.Rows.Add(New String() {line, profile(4), session(1)})
            Else
                DataGridView1.Rows.Add(New String() {line, profile(4)})
            End If

        End While
        rdr.Close()

        'Read and add from participants out list
        ListBox_ArenaOut.Items.Clear()
        rdr = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\participants_out.txt")
        While Not rdr.EndOfStream
            Dim line As String = rdr.ReadLine()
            ListBox_ArenaOut.Items.Add(line)
        End While
        rdr.Close()
    End Sub

    Private Sub ClearArenaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearArenaToolStripMenuItem.Click

        For j = DataGridView1.RowCount - 1 To 0 Step -1
            Dim SW2 As IO.StreamWriter = New StreamWriter("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\session\" + DataGridView1(0, j).Value + ".txt", False)
            SW2.WriteLine(DataGridView1(0, j).Value + ",0")
            SW2.Close()
        Next

        ListBox_CompletedChallenges.Items.Clear()
        ListBox_Challengers.Items.Clear()
        ListBox_ArenaOut.Items.Clear()
        ListBox_ArenaIn.Items.Clear()
        DataGridView1.Rows.Clear()

        Dim SW As IO.StreamWriter = New StreamWriter("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\participants_in.txt", False)
        SW.WriteLine("")
        SW.Close()

        SW = New StreamWriter("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\participants_out.txt", False)
        SW.WriteLine("")
        SW.Close()

    End Sub

    Private Sub EnterSelfIntoArenaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterSelfIntoArenaToolStripMenuItem.Click

        'Read Challengers profile
        Dim rdr2 As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\profiles\drwhistler.txt")
        Dim profile = rdr2.ReadLine().Split(","c)
        rdr2.Close()

        'Read Challengers session file
        rdr2 = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\session\drwhistler.txt")
        Dim session = rdr2.ReadLine().Split(","c)
        rdr2.Close()

        DataGridView1.Rows.Add(New String() {"drwhistler", profile(4), session(1)})

        If ListBox_Challengers.Items.Contains("drwhistler") Or ListBox_CompletedChallenges.Items.Contains("drwhistler") Then
        Else
            ListBox_Challengers.Items.Add("drwhistler")
        End If

        ListBox_ArenaIn.Items.Add("drwhistler")
        ListBox_ArenaOut.Items.Remove("drwhistler")

        Dim SW As IO.StreamWriter = New StreamWriter("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\participants_in.txt", False)
        For Each S As String In ListBox_ArenaIn.Items
            SW.WriteLine(S)
        Next
        SW.Close()

        SW = New StreamWriter("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\participants_out.txt", False)
        For Each S As String In ListBox_ArenaOut.Items
            SW.WriteLine(S)
        Next
        SW.Close()

    End Sub

End Class
