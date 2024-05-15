<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCurrent = New System.Windows.Forms.Button()
        Me.tbPath = New System.Windows.Forms.TextBox()
        Me.btnSetPath = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BtnLaunch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RBTimeDescend = New System.Windows.Forms.RadioButton()
        Me.RBTimeAscend = New System.Windows.Forms.RadioButton()
        Me.BtnGenScr = New System.Windows.Forms.Button()
        Me.TbScrCor = New System.Windows.Forms.TextBox()
        Me.tbDumpFNameSuffix = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumCounter = New System.Windows.Forms.NumericUpDown()
        Me.PSFScopeSetUp = New System.Windows.Forms.Button()
        Me.TBParName1 = New System.Windows.Forms.TextBox()
        Me.TBParValue1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBParValue2 = New System.Windows.Forms.TextBox()
        Me.TBParName2 = New System.Windows.Forms.TextBox()
        Me.TBParRange3 = New System.Windows.Forms.TextBox()
        Me.TBParName3 = New System.Windows.Forms.TextBox()
        Me.TBParRange4 = New System.Windows.Forms.TextBox()
        Me.TBParName4 = New System.Windows.Forms.TextBox()
        Me.TBFEPath = New System.Windows.Forms.TextBox()
        Me.BtnFEPath = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.NumCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCurrent
        '
        Me.btnCurrent.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurrent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCurrent.Location = New System.Drawing.Point(383, 418)
        Me.btnCurrent.Name = "btnCurrent"
        Me.btnCurrent.Size = New System.Drawing.Size(90, 20)
        Me.btnCurrent.TabIndex = 77
        Me.btnCurrent.Text = "Current Path"
        Me.btnCurrent.UseVisualStyleBackColor = False
        Me.btnCurrent.Visible = False
        '
        'tbPath
        '
        Me.tbPath.Location = New System.Drawing.Point(29, 277)
        Me.tbPath.Name = "tbPath"
        Me.tbPath.Size = New System.Drawing.Size(433, 20)
        Me.tbPath.TabIndex = 76
        Me.tbPath.Text = "C:\Evolver\fe"
        Me.tbPath.WordWrap = False
        '
        'btnSetPath
        '
        Me.btnSetPath.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSetPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSetPath.Location = New System.Drawing.Point(29, 251)
        Me.btnSetPath.Name = "btnSetPath"
        Me.btnSetPath.Size = New System.Drawing.Size(90, 20)
        Me.btnSetPath.TabIndex = 75
        Me.btnSetPath.Text = "Browse"
        Me.btnSetPath.UseVisualStyleBackColor = False
        '
        'BtnLaunch
        '
        Me.BtnLaunch.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnLaunch.Location = New System.Drawing.Point(29, 12)
        Me.BtnLaunch.Name = "BtnLaunch"
        Me.BtnLaunch.Size = New System.Drawing.Size(103, 23)
        Me.BtnLaunch.TabIndex = 78
        Me.BtnLaunch.Text = "Launch SE-FIT"
        Me.BtnLaunch.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 79
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(29, 41)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(433, 197)
        Me.RichTextBox1.TabIndex = 80
        Me.RichTextBox1.Text = ""
        '
        'RBTimeDescend
        '
        Me.RBTimeDescend.AutoSize = True
        Me.RBTimeDescend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTimeDescend.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RBTimeDescend.Location = New System.Drawing.Point(291, 254)
        Me.RBTimeDescend.Name = "RBTimeDescend"
        Me.RBTimeDescend.Size = New System.Drawing.Size(123, 17)
        Me.RBTimeDescend.TabIndex = 86
        Me.RBTimeDescend.Text = "Time Descending"
        Me.RBTimeDescend.UseVisualStyleBackColor = True
        '
        'RBTimeAscend
        '
        Me.RBTimeAscend.AutoSize = True
        Me.RBTimeAscend.Checked = True
        Me.RBTimeAscend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTimeAscend.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RBTimeAscend.Location = New System.Drawing.Point(170, 254)
        Me.RBTimeAscend.Name = "RBTimeAscend"
        Me.RBTimeAscend.Size = New System.Drawing.Size(115, 17)
        Me.RBTimeAscend.TabIndex = 85
        Me.RBTimeAscend.TabStop = True
        Me.RBTimeAscend.Text = "Time Ascending"
        Me.RBTimeAscend.UseVisualStyleBackColor = True
        '
        'BtnGenScr
        '
        Me.BtnGenScr.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnGenScr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenScr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnGenScr.Location = New System.Drawing.Point(29, 422)
        Me.BtnGenScr.Name = "BtnGenScr"
        Me.BtnGenScr.Size = New System.Drawing.Size(90, 20)
        Me.BtnGenScr.TabIndex = 87
        Me.BtnGenScr.Text = "Generate Script"
        Me.BtnGenScr.UseVisualStyleBackColor = False
        '
        'TbScrCor
        '
        Me.TbScrCor.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TbScrCor.Location = New System.Drawing.Point(29, 326)
        Me.TbScrCor.Multiline = True
        Me.TbScrCor.Name = "TbScrCor"
        Me.TbScrCor.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TbScrCor.Size = New System.Drawing.Size(433, 90)
        Me.TbScrCor.TabIndex = 88
        Me.TbScrCor.Text = "{g 5; V; u}100" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TbScrCor.WordWrap = False
        '
        'tbDumpFNameSuffix
        '
        Me.tbDumpFNameSuffix.Location = New System.Drawing.Point(165, 301)
        Me.tbDumpFNameSuffix.Name = "tbDumpFNameSuffix"
        Me.tbDumpFNameSuffix.Size = New System.Drawing.Size(88, 20)
        Me.tbDumpFNameSuffix.TabIndex = 90
        Me.tbDumpFNameSuffix.Text = "_n"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(35, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Dump filename suffix"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(292, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Number of sessions"
        '
        'NumCounter
        '
        Me.NumCounter.Location = New System.Drawing.Point(415, 17)
        Me.NumCounter.Name = "NumCounter"
        Me.NumCounter.Size = New System.Drawing.Size(45, 20)
        Me.NumCounter.TabIndex = 94
        '
        'PSFScopeSetUp
        '
        Me.PSFScopeSetUp.BackColor = System.Drawing.Color.CornflowerBlue
        Me.PSFScopeSetUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PSFScopeSetUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PSFScopeSetUp.Location = New System.Drawing.Point(739, 197)
        Me.PSFScopeSetUp.Name = "PSFScopeSetUp"
        Me.PSFScopeSetUp.Size = New System.Drawing.Size(90, 20)
        Me.PSFScopeSetUp.TabIndex = 95
        Me.PSFScopeSetUp.Text = "PSF Scope Setup"
        Me.PSFScopeSetUp.UseVisualStyleBackColor = False
        '
        'TBParName1
        '
        Me.TBParName1.Location = New System.Drawing.Point(588, 84)
        Me.TBParName1.Name = "TBParName1"
        Me.TBParName1.Size = New System.Drawing.Size(88, 20)
        Me.TBParName1.TabIndex = 96
        '
        'TBParValue1
        '
        Me.TBParValue1.Location = New System.Drawing.Point(700, 84)
        Me.TBParValue1.Name = "TBParValue1"
        Me.TBParValue1.Size = New System.Drawing.Size(129, 20)
        Me.TBParValue1.TabIndex = 97
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(581, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Parameter Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(712, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Parameter Values"
        '
        'TBParValue2
        '
        Me.TBParValue2.Location = New System.Drawing.Point(700, 110)
        Me.TBParValue2.Name = "TBParValue2"
        Me.TBParValue2.Size = New System.Drawing.Size(129, 20)
        Me.TBParValue2.TabIndex = 101
        '
        'TBParName2
        '
        Me.TBParName2.Location = New System.Drawing.Point(588, 110)
        Me.TBParName2.Name = "TBParName2"
        Me.TBParName2.Size = New System.Drawing.Size(88, 20)
        Me.TBParName2.TabIndex = 100
        '
        'TBParRange3
        '
        Me.TBParRange3.Location = New System.Drawing.Point(700, 136)
        Me.TBParRange3.Name = "TBParRange3"
        Me.TBParRange3.Size = New System.Drawing.Size(129, 20)
        Me.TBParRange3.TabIndex = 103
        Me.TBParRange3.Visible = False
        '
        'TBParName3
        '
        Me.TBParName3.Location = New System.Drawing.Point(588, 136)
        Me.TBParName3.Name = "TBParName3"
        Me.TBParName3.Size = New System.Drawing.Size(88, 20)
        Me.TBParName3.TabIndex = 102
        Me.TBParName3.Visible = False
        '
        'TBParRange4
        '
        Me.TBParRange4.Location = New System.Drawing.Point(700, 162)
        Me.TBParRange4.Name = "TBParRange4"
        Me.TBParRange4.Size = New System.Drawing.Size(129, 20)
        Me.TBParRange4.TabIndex = 105
        Me.TBParRange4.Visible = False
        '
        'TBParName4
        '
        Me.TBParName4.Location = New System.Drawing.Point(588, 162)
        Me.TBParName4.Name = "TBParName4"
        Me.TBParName4.Size = New System.Drawing.Size(88, 20)
        Me.TBParName4.TabIndex = 104
        Me.TBParName4.Visible = False
        '
        'TBFEPath
        '
        Me.TBFEPath.Location = New System.Drawing.Point(497, 41)
        Me.TBFEPath.Name = "TBFEPath"
        Me.TBFEPath.Size = New System.Drawing.Size(433, 20)
        Me.TBFEPath.TabIndex = 106
        Me.TBFEPath.Text = "C:\Evolver\"
        Me.TBFEPath.WordWrap = False
        '
        'BtnFEPath
        '
        Me.BtnFEPath.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnFEPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFEPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnFEPath.Location = New System.Drawing.Point(497, 19)
        Me.BtnFEPath.Name = "BtnFEPath"
        Me.BtnFEPath.Size = New System.Drawing.Size(90, 20)
        Me.BtnFEPath.TabIndex = 107
        Me.BtnFEPath.Text = "Browse"
        Me.BtnFEPath.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 455)
        Me.Controls.Add(Me.BtnFEPath)
        Me.Controls.Add(Me.TBFEPath)
        Me.Controls.Add(Me.TBParRange4)
        Me.Controls.Add(Me.TBParName4)
        Me.Controls.Add(Me.TBParRange3)
        Me.Controls.Add(Me.TBParName3)
        Me.Controls.Add(Me.TBParValue2)
        Me.Controls.Add(Me.TBParName2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBParValue1)
        Me.Controls.Add(Me.TBParName1)
        Me.Controls.Add(Me.PSFScopeSetUp)
        Me.Controls.Add(Me.NumCounter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbDumpFNameSuffix)
        Me.Controls.Add(Me.TbScrCor)
        Me.Controls.Add(Me.BtnGenScr)
        Me.Controls.Add(Me.RBTimeDescend)
        Me.Controls.Add(Me.RBTimeAscend)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnLaunch)
        Me.Controls.Add(Me.btnCurrent)
        Me.Controls.Add(Me.tbPath)
        Me.Controls.Add(Me.btnSetPath)
        Me.MaximizeBox = False
        Me.Name = "Manager"
        Me.Text = "SE-FIT Multi-Session Manager"
        CType(Me.NumCounter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCurrent As Button
    Friend WithEvents tbPath As TextBox
    Friend WithEvents btnSetPath As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BtnLaunch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RBTimeDescend As RadioButton
    Friend WithEvents RBTimeAscend As RadioButton
    Friend WithEvents BtnGenScr As Button
    Friend WithEvents TbScrCor As TextBox
    Friend WithEvents tbDumpFNameSuffix As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NumCounter As NumericUpDown
    Friend WithEvents PSFScopeSetUp As Button
    Friend WithEvents TBParName1 As TextBox
    Friend WithEvents TBParValue1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TBParValue2 As TextBox
    Friend WithEvents TBParName2 As TextBox
    Friend WithEvents TBParRange3 As TextBox
    Friend WithEvents TBParName3 As TextBox
    Friend WithEvents TBParRange4 As TextBox
    Friend WithEvents TBParName4 As TextBox
    Friend WithEvents TBFEPath As TextBox
    Friend WithEvents BtnFEPath As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
