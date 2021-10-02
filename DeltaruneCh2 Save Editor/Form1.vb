
Public Class Form1



    Private Sub Openfile_Click(sender As Object, e As EventArgs) Handles Openfile.Click


        Dim appdataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
        Dim Delfol As String = appdataPath + "\DELTARUNE"
        OpenFileDialog1.Filter = "Deltarune Chapter 2 Save File |*2_0; *2_1; *2_2; *2_9; | Text Files |*.txt"
        OpenFileDialog1.InitialDirectory = Delfol
        OpenFileDialog1.Title = "Please Open Deltarune Save File"
        OpenFileDialog1.FileName = "Filech2_0"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim filedialog As New OpenFileDialog


            Title.Text = OpenFileDialog1.FileName
            Dim lines() As String = IO.File.ReadAllLines(OpenFileDialog1.FileName)
            ListBox1.Items.AddRange(lines)

            KrisName.Text = ListBox1.Items(0)


            ''Checks If Lightworld kris Is on.
            If ListBox1.Items(15) = 1 Then
                darkkrisbox.Checked = True
            Else
                darkkrisbox.Checked = False
            End If



        End If
    End Sub

    Private Sub darkkrisbox_CheckedChanged(sender As Object, e As EventArgs) Handles darkkrisbox.CheckedChanged
        If darkkrisbox.Checked = True Then
            ListBox1.Items(15) = 1 ''Changes Kris to be in Dark World form.
        End If
        If darkkrisbox.Checked = False Then
            ListBox1.Items(15) = 0 ''Changes Kris to be in Light World form.
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim answer As DialogResult
        answer = MessageBox.Show("Are you sure you want to save?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = vbYes Then
            Dim SW As IO.StreamWriter = IO.File.CreateText(OpenFileDialog1.FileName)
            For Each S As String In ListBox1.Items
                SW.WriteLine(S)
            Next
            SW.Close()
        End If
        If answer = vbNo Then

        End If
    End Sub


    Private Sub Apply_Click(sender As Object, e As EventArgs) Handles Apply.Click
        If roomchanger.Text = "" Then
            roomchanger.Text = "11"
        End If ''h
        Dim room As String
        room = roomchanger.Text
        ListBox1.Items(3053) = room
        ListBox1.Items(0) = KrisName.Text
    End Sub

End Class