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
        Me.darkkrisbox.Location = New System.Drawing.Point(10, 69)
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
        Me.roomchanger.Location = New System.Drawing.Point(26, 164)
        Me.roomchanger.Name = "roomchanger"
        Me.roomchanger.Size = New System.Drawing.Size(125, 41)
        Me.roomchanger.TabIndex = 6
        Me.roomchanger.Text = "12"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 33)
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
        'Form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1082, 493)
        Me.Controls.Add(Me.Apply)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.roomchanger)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Openfile)
        Me.Controls.Add(Me.darkkrisbox)
        Me.Controls.Add(Me.Title)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deltarune Chapter 2 Save Tool"
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
End Class
