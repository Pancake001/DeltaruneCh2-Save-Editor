
Public Class Form1

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Openfile_Click(sender As Object, e As EventArgs) Handles Openfile.Click


        Dim appdataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
        Dim Delfol As String = appdataPath + "\DELTARUNE"
        OpenFileDialog1.Filter = "Deltarune Chapter 2 Save File |*2_0; *2_1; *2_2; *2_9; | Text Files |*.txt"
        OpenFileDialog1.InitialDirectory = Delfol
        OpenFileDialog1.Title = "Please Open Deltarune Save File"
        OpenFileDialog1.FileName = "Filech2_0"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Title.Text = DialogResult.OK
            ListBox1.Items.Add(DialogResult)


        End If

    End Sub
End Class