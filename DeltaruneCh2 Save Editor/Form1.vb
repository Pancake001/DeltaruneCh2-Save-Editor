﻿Imports System.IO
Imports System.Text
Public Class Form1



    Private Sub Openfile_Click(sender As Object, e As EventArgs) Handles Openfile.Click


        Dim appdataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
        Dim Delfol As String = appdataPath + "\DELTARUNE"
        OpenFileDialog1.Filter = "Deltarune Chapter 2 Save File |*2_0; *2_1; *2_2; *2_9;"
        OpenFileDialog1.InitialDirectory = Delfol
        OpenFileDialog1.Title = "Please Open Deltarune Save File"
        OpenFileDialog1.FileName = "Filech2_0"   ''
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim filedialog As New OpenFileDialog
            Title.Text = OpenFileDialog1.FileName
            Dim lines() As String = IO.File.ReadAllLines(OpenFileDialog1.FileName)
            ListBox1.Items.AddRange(lines)

            KrisName.Text = ListBox1.Items(0)
            Darkcash.Text = ListBox1.Items(10)
            Krismaxhp.Text = ListBox1.Items(79)
            Krishp.Text = ListBox1.Items(78)    ''Makes everything match the save file
            Krisatk.Text = ListBox1.Items(80)   ''When you open it.
            Krisdef.Text = ListBox1.Items(81)
            Krisman.Text = ListBox1.Items(82)

            Susiehp.Text = ListBox1.Items(140) ''im
            Susiemaxhp.Text = ListBox1.Items(141)
            Susieatk.Text = ListBox1.Items(142)
            Susiedef.Text = ListBox1.Items(143)
            Susieman.Text = ListBox1.Items(144) ''im

            Ralshp.Text = ListBox1.Items(202) ''im
            Ralsmaxhp.Text = ListBox1.Items(203)
            Ralsatk.Text = ListBox1.Items(204)  ''stats fhaij
            Ralsdef.Text = ListBox1.Items(205)
            Ralsman.Text = ListBox1.Items(206) ''im

            Noehp.Text = ListBox1.Items(264) ''im
            Noemaxhp.Text = ListBox1.Items(265)
            Noeatk.Text = ListBox1.Items(266)  ''stats fhaij
            Noedef.Text = ListBox1.Items(267)
            Noeman.Text = ListBox1.Items(268)

            Lhp.Text = ListBox1.Items(530) ''im
            Lmaxhp.Text = ListBox1.Items(531)
            Latk.Text = ListBox1.Items(532)  ''stats fhaij
            Ldef.Text = ListBox1.Items(533)
            Lexp.Text = ListBox1.Items(527)
            Lcash.Text = ListBox1.Items(529)
            Llvl.Text = ListBox1.Items(528)



            roomchanger.Text = ListBox1.Items(3053)


            If ListBox1.Items(806) = 1 Then '' Checks if Starwalk box is on.
                Starwalk.Checked = True
            Else
                Starwalk.Checked = False
            End If

            ''bed inspect
            If ListBox1.Items(804) = 1 Then '' Checks if Starwalk box is on.
                Bedinsp.Checked = True
            Else
                Bedinsp.Checked = False
            End If


            ''Checks If Lightworld kris Is on.
            If ListBox1.Items(15) = 1 Then
                darkkrisbox.Checked = True
            Else
                darkkrisbox.Checked = False
            End If
            If ListBox1.Items(7) = 1 Then
                Part1.SelectedItem = "Kris"
            End If
            If ListBox1.Items(7) = 2 Then
                Part1.SelectedItem = "Susie"
            End If
            If ListBox1.Items(7) = 3 Then
                Part1.SelectedItem = "Ralsei"
            End If
            If ListBox1.Items(7) = 4 Then
                Part1.SelectedItem = "Noelle"
            End If
            If ListBox1.Items(7) = 0 Then
                Part1.SelectedItem = "None"
            End If
            If ListBox1.Items(8) = 0 Then
                Part2.SelectedItem = "None"
            End If
            If ListBox1.Items(9) = 0 Then
                Part3.SelectedItem = "None"
            End If
            If ListBox1.Items(8) = 1 Then
                Part2.SelectedItem = "Kris"
            End If
            If ListBox1.Items(8) = 2 Then
                Part2.SelectedItem = "Susie"
            End If
            If ListBox1.Items(8) = 3 Then
                Part2.SelectedItem = "Ralsei"
            End If
            If ListBox1.Items(8) = 4 Then
                Part2.SelectedItem = "Noelle"
            End If
            If ListBox1.Items(9) = 1 Then
                Part3.SelectedItem = "Kris"
            End If
            If ListBox1.Items(9) = 2 Then
                Part3.SelectedItem = "Susie"
            End If
            If ListBox1.Items(9) = 3 Then
                Part3.SelectedItem = "Ralsei"
            End If
            If ListBox1.Items(9) = 4 Then
                Part3.SelectedItem = "Noelle"
            End If
        End If

        Dim Tempfol As String = My.Computer.FileSystem.SpecialDirectories.Temp

        Dim bakpat As String = (Tempfol + "\DeltaruneSaveBackup") ''Creates backup of the file.

        File.Create(bakpat).Dispose()

        Dim SW As IO.StreamWriter = IO.File.CreateText(bakpat)
        For Each S As String In ListBox1.Items
            SW.WriteLine(S)
        Next
        SW.Close()



    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click '' Save button.
        Dim answer As DialogResult
        answer = MessageBox.Show("Are you sure you want to save?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = vbYes Then

            Dim SW As IO.StreamWriter = IO.File.CreateText(OpenFileDialog1.FileName)
            For Each S As String In ListBox1.Items
                SW.WriteLine(S)
            Next
            SW.Close()
        End If
    End Sub


    Private Sub Apply_Click(sender As Object, e As EventArgs) Handles Apply.Click

        ''If Not ListBox1.Items(3051) = 0 Then
        ''MessageBox.Show("Broken Save File", "Error.", MessageBoxButtons.OK)
        ''Else


        If roomchanger.Text = "" Then               ''Puts everything into the list box.
            roomchanger.Text = "11"
        End If ''h
        Dim room As String
        room = roomchanger.Text
        ListBox1.Items(3053) = room
        ListBox1.Items(0) = KrisName.Text
        ListBox1.Items(10) = Darkcash.Text
        If Part1.SelectedItem = "Kris" Then
            ListBox1.Items(7) = 1
        End If
        If Part1.SelectedItem = "Susie" Then
            ListBox1.Items(7) = 2
        End If
        If Part1.SelectedItem = "Ralsei" Then
            ListBox1.Items(7) = 3
        End If
        If Part1.SelectedItem = "Noelle" Then
            ListBox1.Items(7) = 4
        End If
        If Part1.SelectedItem = "None" Then
            ListBox1.Items(7) = 0
        End If
        If Part2.SelectedItem = "None" Then
            ListBox1.Items(8) = 0
        End If
        If Part3.SelectedItem = "None" Then
            ListBox1.Items(9) = 0
        End If
        If Part2.SelectedItem = "Kris" Then
            ListBox1.Items(8) = 1
        End If
        If Part2.SelectedItem = "Susie" Then
            ListBox1.Items(8) = 2
        End If
        If Part2.SelectedItem = "Ralsei" Then
            ListBox1.Items(8) = 3
        End If
        If Part2.SelectedItem = "Noelle" Then
            ListBox1.Items(8) = 4
        End If
        If Part3.SelectedItem = "Kris" Then
            ListBox1.Items(9) = 1
        End If
        If Part3.SelectedItem = "Susie" Then
            ListBox1.Items(9) = 2
        End If
        If Part3.SelectedItem = "Ralsei" Then
            ListBox1.Items(9) = 3
        End If
        If Part3.SelectedItem = "Noelle" Then
            ListBox1.Items(9) = 4
        End If

        If darkkrisbox.Checked = True Then
            ListBox1.Items(15) = 1 ''Changes Kris to be in Dark World form.
        End If
        If darkkrisbox.Checked = False Then
            ListBox1.Items(15) = 0 ''Changes Kris to be in Light World form.
        End If

        If Starwalk.Checked = True Then
            ListBox1.Items(806) = 1 '' Talked to Starwalker
        End If
        If Starwalk.Checked = False Then
            ListBox1.Items(806) = 0 ''
        End If

        If Bedinsp.Checked = True Then
            ListBox1.Items(804) = 1 '' Bed Inspector
        End If
        If Bedinsp.Checked = False Then
            ListBox1.Items(804) = 0 ''
        End If


        ListBox1.Items(79) = Krismaxhp.Text
        ListBox1.Items(78) = Krishp.Text
        ListBox1.Items(80) = Krisatk.Text
        ListBox1.Items(81) = Krisdef.Text
        ListBox1.Items(82) = Krisman.Text

        ''im22222
        ListBox1.Items(140) = Susiehp.Text
        ListBox1.Items(141) = Susiemaxhp.Text
        ListBox1.Items(142) = Susieatk.Text
        ListBox1.Items(143) = Susiedef.Text
        ListBox1.Items(144) = Susieman.Text

        ListBox1.Items(202) = Ralshp.Text
        ListBox1.Items(203) = Ralsmaxhp.Text
        ListBox1.Items(204) = Ralsatk.Text
        ListBox1.Items(205) = Ralsdef.Text
        ListBox1.Items(206) = Ralsman.Text

        ListBox1.Items(264) = Noehp.Text
        ListBox1.Items(265) = Noemaxhp.Text
        ListBox1.Items(266) = Noeatk.Text
        ListBox1.Items(267) = Noedef.Text
        ListBox1.Items(268) = Noeman.Text

        ListBox1.Items(530) = Lhp.Text ''im
        ListBox1.Items(531) = Lmaxhp.Text
        ListBox1.Items(532) = Latk.Text ''stats fhaij
        ListBox1.Items(533) = Ldef.Text
        ListBox1.Items(527) = Lexp.Text
        ListBox1.Items(529) = Lcash.Text
        ListBox1.Items(528) = Llvl.Text


        ''End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Part1.Items.Add("Kris")         ''
        Part1.Items.Add("Susie")
        Part1.Items.Add("Ralsei")
        Part1.Items.Add("Noelle")
        Part2.Items.Add("Kris")
        Part2.Items.Add("Susie")
        Part2.Items.Add("Ralsei")
        Part2.Items.Add("Noelle")
        Part3.Items.Add("Kris")
        Part3.Items.Add("Susie")
        Part3.Items.Add("Ralsei")
        Part3.Items.Add("Noelle")
        Part1.Items.Add("None")
        Part2.Items.Add("None")
        Part3.Items.Add("None")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Loadbakbutton.Click
        '' Loads backup. I will implement this later lol
    End Sub




    '' Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    ''My.Computer.Audio.Play("C:\Users\chris\Downloads\My-Audio12.wav")
    ''End Sub
End Class