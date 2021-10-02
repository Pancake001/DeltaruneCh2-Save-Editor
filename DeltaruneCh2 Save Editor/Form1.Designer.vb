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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Title = New System.Windows.Forms.Label()
        Me.darkkrisbox = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Openfile = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.roomchanger = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Apply = New System.Windows.Forms.Button()
        Me.KrisName = New System.Windows.Forms.TextBox()
        Me.Darkcash = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Part1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Part2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Part3 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Title.Location = New System.Drawing.Point(-1, -3)
        Me.Title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(259, 24)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Deltarune Chapter 2 Save Tool"
        '
        'darkkrisbox
        '
        Me.darkkrisbox.AutoSize = True
        Me.darkkrisbox.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.darkkrisbox.Location = New System.Drawing.Point(13, 373)
        Me.darkkrisbox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.darkkrisbox.Name = "darkkrisbox"
        Me.darkkrisbox.Size = New System.Drawing.Size(161, 28)
        Me.darkkrisbox.TabIndex = 1
        Me.darkkrisbox.Text = "Dark World Kris"
        Me.darkkrisbox.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFile"
        '
        'Openfile
        '
        Me.Openfile.BackColor = System.Drawing.Color.Black
        Me.Openfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Openfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Openfile.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Openfile.ForeColor = System.Drawing.Color.White
        Me.Openfile.Location = New System.Drawing.Point(8, 22)
        Me.Openfile.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Openfile.Name = "Openfile"
        Me.Openfile.Size = New System.Drawing.Size(151, 30)
        Me.Openfile.TabIndex = 2
        Me.Openfile.Text = "Open Save File"
        Me.Openfile.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Black
        Me.ListBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 23
        Me.ListBox1.Location = New System.Drawing.Point(880, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(188, 418)
        Me.ListBox1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(996, 451)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 30)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'roomchanger
        '
        Me.roomchanger.Location = New System.Drawing.Point(12, 440)
        Me.roomchanger.Name = "roomchanger"
        Me.roomchanger.Size = New System.Drawing.Size(125, 41)
        Me.roomchanger.TabIndex = 6
        Me.roomchanger.Text = "12"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(8, 404)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Room # (11 - 213)"
        '
        'Apply
        '
        Me.Apply.BackColor = System.Drawing.Color.Black
        Me.Apply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Apply.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Apply.ForeColor = System.Drawing.Color.White
        Me.Apply.Location = New System.Drawing.Point(880, 451)
        Me.Apply.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Apply.Name = "Apply"
        Me.Apply.Size = New System.Drawing.Size(74, 30)
        Me.Apply.TabIndex = 8
        Me.Apply.Text = "Apply"
        Me.Apply.UseVisualStyleBackColor = False
        '
        'KrisName
        '
        Me.KrisName.Location = New System.Drawing.Point(8, 80)
        Me.KrisName.Name = "KrisName"
        Me.KrisName.Size = New System.Drawing.Size(125, 41)
        Me.KrisName.TabIndex = 9
        '
        'Darkcash
        '
        Me.Darkcash.Location = New System.Drawing.Point(8, 151)
        Me.Darkcash.Name = "Darkcash"
        Me.Darkcash.Size = New System.Drawing.Size(125, 41)
        Me.Darkcash.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(8, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(8, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 24)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Kromer"
        '
        'Part1
        '
        Me.Part1.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Part1.FormattingEnabled = True
        Me.Part1.Location = New System.Drawing.Point(277, 59)
        Me.Part1.Name = "Part1"
        Me.Part1.Size = New System.Drawing.Size(151, 32)
        Me.Part1.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(277, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Party Member 1"
        '
        'Part2
        '
        Me.Part2.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Part2.FormattingEnabled = True
        Me.Part2.Location = New System.Drawing.Point(434, 59)
        Me.Part2.Name = "Part2"
        Me.Part2.Size = New System.Drawing.Size(151, 32)
        Me.Part2.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(434, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 24)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Party Member 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(591, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 24)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Party Member 3"
        '
        'Part3
        '
        Me.Part3.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Part3.FormattingEnabled = True
        Me.Part3.Location = New System.Drawing.Point(591, 59)
        Me.Part3.Name = "Part3"
        Me.Part3.Size = New System.Drawing.Size(151, 32)
        Me.Part3.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(265, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 85)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Party Editor"
        '
        'Form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1082, 493)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Part3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Part2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Part1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Darkcash)
        Me.Controls.Add(Me.KrisName)
        Me.Controls.Add(Me.Apply)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.roomchanger)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Openfile)
        Me.Controls.Add(Me.darkkrisbox)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[[hyperlink blocked]]"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents darkkrisbox As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Openfile As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents roomchanger As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Apply As Button
    Friend WithEvents KrisName As TextBox
    Friend WithEvents Darkcash As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Part1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Part2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Part3 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
