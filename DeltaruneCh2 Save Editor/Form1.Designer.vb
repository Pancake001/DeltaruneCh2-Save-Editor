﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.roomchanger = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Apply = New System.Windows.Forms.Button()
        Me.Part1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Part2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Part3 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Krisman = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Krisatk = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Krisdef = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Krishp = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Krismaxhp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Susieman = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Susiemaxhp = New System.Windows.Forms.TextBox()
        Me.Susieatk = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Susiehp = New System.Windows.Forms.TextBox()
        Me.Susiedef = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.KrisName = New System.Windows.Forms.TextBox()
        Me.Darkcash = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Loadbakbutton = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
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
        Me.darkkrisbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.darkkrisbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.darkkrisbox.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.darkkrisbox.Location = New System.Drawing.Point(8, 382)
        Me.darkkrisbox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.darkkrisbox.Name = "darkkrisbox"
        Me.darkkrisbox.Size = New System.Drawing.Size(182, 28)
        Me.darkkrisbox.TabIndex = 1
        Me.darkkrisbox.Text = "Dark World Toggle"
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
        Me.roomchanger.Location = New System.Drawing.Point(8, 440)
        Me.roomchanger.Name = "roomchanger"
        Me.roomchanger.Size = New System.Drawing.Size(125, 41)
        Me.roomchanger.TabIndex = 6
        Me.roomchanger.Text = "12"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(8, 413)
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
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(265, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 367)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Party Editor"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TabControl1.Location = New System.Drawing.Point(265, 103)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(487, 276)
        Me.TabControl1.TabIndex = 21
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Black
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Krisman)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Krisatk)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Krisdef)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Krishp)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Krismaxhp)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(479, 242)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Kris Stats"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(0, 224)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 18)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Kris Stats"
        '
        'Krisman
        '
        Me.Krisman.Location = New System.Drawing.Point(30, 176)
        Me.Krisman.Name = "Krisman"
        Me.Krisman.Size = New System.Drawing.Size(86, 26)
        Me.Krisman.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(9, 145)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 24)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Magic (Unused)"
        '
        'Krisatk
        '
        Me.Krisatk.Location = New System.Drawing.Point(8, 111)
        Me.Krisatk.Name = "Krisatk"
        Me.Krisatk.Size = New System.Drawing.Size(61, 26)
        Me.Krisatk.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(3, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 24)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Attack"
        '
        'Krisdef
        '
        Me.Krisdef.Location = New System.Drawing.Point(80, 111)
        Me.Krisdef.Name = "Krisdef"
        Me.Krisdef.Size = New System.Drawing.Size(61, 26)
        Me.Krisdef.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(75, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 24)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Def"
        '
        'Krishp
        '
        Me.Krishp.Location = New System.Drawing.Point(8, 44)
        Me.Krishp.Name = "Krishp"
        Me.Krishp.Size = New System.Drawing.Size(61, 26)
        Me.Krishp.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(74, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 24)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Max HP"
        '
        'Krismaxhp
        '
        Me.Krismaxhp.Location = New System.Drawing.Point(80, 44)
        Me.Krismaxhp.Name = "Krismaxhp"
        Me.Krismaxhp.Size = New System.Drawing.Size(61, 26)
        Me.Krismaxhp.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 24)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "HP"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Black
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Susieman)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Susiemaxhp)
        Me.TabPage1.Controls.Add(Me.Susieatk)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Susiehp)
        Me.TabPage1.Controls.Add(Me.Susiedef)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.ForeColor = System.Drawing.Color.White
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(479, 242)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Susie Stats"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(2, 224)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 18)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Kris Stats"
        '
        'Susieman
        '
        Me.Susieman.Location = New System.Drawing.Point(32, 176)
        Me.Susieman.Name = "Susieman"
        Me.Susieman.Size = New System.Drawing.Size(86, 26)
        Me.Susieman.TabIndex = 42
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(5, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 24)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "HP"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(47, 149)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 24)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Magic"
        '
        'Susiemaxhp
        '
        Me.Susiemaxhp.Location = New System.Drawing.Point(82, 44)
        Me.Susiemaxhp.Name = "Susiemaxhp"
        Me.Susiemaxhp.Size = New System.Drawing.Size(61, 26)
        Me.Susiemaxhp.TabIndex = 34
        '
        'Susieatk
        '
        Me.Susieatk.Location = New System.Drawing.Point(10, 111)
        Me.Susieatk.Name = "Susieatk"
        Me.Susieatk.Size = New System.Drawing.Size(61, 26)
        Me.Susieatk.TabIndex = 40
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(76, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 24)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Max HP"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(5, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 24)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Attack"
        '
        'Susiehp
        '
        Me.Susiehp.Location = New System.Drawing.Point(10, 44)
        Me.Susiehp.Name = "Susiehp"
        Me.Susiehp.Size = New System.Drawing.Size(61, 26)
        Me.Susiehp.TabIndex = 36
        '
        'Susiedef
        '
        Me.Susiedef.Location = New System.Drawing.Point(82, 111)
        Me.Susiedef.Name = "Susiedef"
        Me.Susiedef.Size = New System.Drawing.Size(61, 26)
        Me.Susiedef.TabIndex = 38
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(77, 84)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 24)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Def"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 24)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Name"
        '
        'KrisName
        '
        Me.KrisName.Location = New System.Drawing.Point(12, 90)
        Me.KrisName.Name = "KrisName"
        Me.KrisName.Size = New System.Drawing.Size(125, 41)
        Me.KrisName.TabIndex = 14
        '
        'Darkcash
        '
        Me.Darkcash.Location = New System.Drawing.Point(12, 161)
        Me.Darkcash.Name = "Darkcash"
        Me.Darkcash.Size = New System.Drawing.Size(125, 41)
        Me.Darkcash.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 24)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Kromer"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1134, 229)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 30)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Lancer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Loadbakbutton
        '
        Me.Loadbakbutton.BackColor = System.Drawing.Color.Black
        Me.Loadbakbutton.Cursor = System.Windows.Forms.Cursors.No
        Me.Loadbakbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Loadbakbutton.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Loadbakbutton.ForeColor = System.Drawing.Color.White
        Me.Loadbakbutton.Location = New System.Drawing.Point(745, 451)
        Me.Loadbakbutton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Loadbakbutton.Name = "Loadbakbutton"
        Me.Loadbakbutton.Size = New System.Drawing.Size(112, 30)
        Me.Loadbakbutton.TabIndex = 23
        Me.Loadbakbutton.Text = "Load Backup"
        Me.Loadbakbutton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1082, 493)
        Me.Controls.Add(Me.Loadbakbutton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.KrisName)
        Me.Controls.Add(Me.Darkcash)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Part3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Part2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Part1)
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
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents darkkrisbox As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Openfile As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents roomchanger As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Apply As Button
    Friend WithEvents Part1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Part2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Part3 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents KrisName As TextBox
    Friend WithEvents Darkcash As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Krismaxhp As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Krisdef As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Krishp As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Krisatk As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Krisman As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Loadbakbutton As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Susieman As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Susiemaxhp As TextBox
    Friend WithEvents Susieatk As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Susiehp As TextBox
    Friend WithEvents Susiedef As TextBox
    Friend WithEvents Label15 As Label
End Class
