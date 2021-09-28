
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
            If ListBox1.Items(16) = 1 Then
                darkkrisbox.Checked = False
            End If

            If ListBox1.Items(16) = 0 Then
                darkkrisbox.Checked = True
            End If


        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


    End Sub
End Class