
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

            '' Checks if Lightworld kris is on.
            ''If ListBox1.Items(16) = 1 Then
            ''darkkrisbox.Checked = True
            ''Else
            ''  darkkrisbox.Checked = False
            ''End If



        End If
    End Sub

    Private Sub darkkrisbox_CheckedChanged(sender As Object, e As EventArgs) Handles darkkrisbox.CheckedChanged
        If darkkrisbox.Checked = True Then
            ListBox1.Items(16) = 1 ''Changes Kris to be in Dark World form.
        End If
        If darkkrisbox.Checked = False Then
            ListBox1.Items(16) = 0 ''Changes Kris to be in Light World form.
        End If
    End Sub
End Class