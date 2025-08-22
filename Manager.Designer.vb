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
        Me.btnCurrent.Location = New System.Drawing.Point(985, 459)
        Me.btnCurrent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCurrent.Name = "btnCurrent"
        Me.btnCurrent.Size = New System.Drawing.Size(120, 25)
        Me.btnCurrent.TabIndex = 77
        Me.btnCurrent.Text = "Current Path"
        Me.btnCurrent.UseVisualStyleBackColor = False
        Me.btnCurrent.Visible = False
        '
        'tbPath
        '
        Me.tbPath.Location = New System.Drawing.Point(39, 341)
        Me.tbPath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbPath.Name = "tbPath"
        Me.tbPath.Size = New System.Drawing.Size(576, 22)
        Me.tbPath.TabIndex = 76
        Me.tbPath.Text = "C:\Evolver\fe"
        Me.tbPath.WordWrap = False
        '
        'btnSetPath
        '
        Me.btnSetPath.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSetPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSetPath.Location = New System.Drawing.Point(39, 309)
        Me.btnSetPath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSetPath.Name = "btnSetPath"
        Me.btnSetPath.Size = New System.Drawing.Size(120, 25)
        Me.btnSetPath.TabIndex = 75
        Me.btnSetPath.Text = "Browse"
        Me.btnSetPath.UseVisualStyleBackColor = False
        '
        'BtnLaunch
        '
        Me.BtnLaunch.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnLaunch.Location = New System.Drawing.Point(39, 15)
        Me.BtnLaunch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnLaunch.Name = "BtnLaunch"
        Me.BtnLaunch.Size = New System.Drawing.Size(137, 28)
        Me.BtnLaunch.TabIndex = 78
        Me.BtnLaunch.Text = "Launch SE-FIT"
        Me.BtnLaunch.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 79
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(39, 50)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(576, 242)
        Me.RichTextBox1.TabIndex = 80
        Me.RichTextBox1.Text = ""
        '
        'RBTimeDescend
        '
        Me.RBTimeDescend.AutoSize = True
        Me.RBTimeDescend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTimeDescend.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RBTimeDescend.Location = New System.Drawing.Point(388, 313)
        Me.RBTimeDescend.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RBTimeDescend.Name = "RBTimeDescend"
        Me.RBTimeDescend.Size = New System.Drawing.Size(154, 21)
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
        Me.RBTimeAscend.Location = New System.Drawing.Point(227, 313)
        Me.RBTimeAscend.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RBTimeAscend.Name = "RBTimeAscend"
        Me.RBTimeAscend.Size = New System.Drawing.Size(144, 21)
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
        Me.BtnGenScr.Location = New System.Drawing.Point(39, 519)
        Me.BtnGenScr.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnGenScr.Name = "BtnGenScr"
        Me.BtnGenScr.Size = New System.Drawing.Size(120, 25)
        Me.BtnGenScr.TabIndex = 87
        Me.BtnGenScr.Text = "Generate Script"
        Me.BtnGenScr.UseVisualStyleBackColor = False
        '
        'TbScrCor
        '
        Me.TbScrCor.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TbScrCor.Location = New System.Drawing.Point(39, 401)
        Me.TbScrCor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbScrCor.Multiline = True
        Me.TbScrCor.Name = "TbScrCor"
        Me.TbScrCor.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TbScrCor.Size = New System.Drawing.Size(576, 110)
        Me.TbScrCor.TabIndex = 88
        Me.TbScrCor.Text = "{g 5; V; u}100" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TbScrCor.WordWrap = False
        '
        'tbDumpFNameSuffix
        '
        Me.tbDumpFNameSuffix.Location = New System.Drawing.Point(220, 370)
        Me.tbDumpFNameSuffix.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbDumpFNameSuffix.Name = "tbDumpFNameSuffix"
        Me.tbDumpFNameSuffix.Size = New System.Drawing.Size(116, 22)
        Me.tbDumpFNameSuffix.TabIndex = 90
        Me.tbDumpFNameSuffix.Text = "_n"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(47, 374)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 17)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Dump filename suffix"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(389, 23)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 17)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Number of sessions"
        '
        'NumCounter
        '
        Me.NumCounter.Location = New System.Drawing.Point(553, 21)
        Me.NumCounter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NumCounter.Name = "NumCounter"
        Me.NumCounter.Size = New System.Drawing.Size(60, 22)
        Me.NumCounter.TabIndex = 94
        '
        'PSFScopeSetUp
        '
        Me.PSFScopeSetUp.BackColor = System.Drawing.Color.CornflowerBlue
        Me.PSFScopeSetUp.Enabled = False
        Me.PSFScopeSetUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PSFScopeSetUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PSFScopeSetUp.Location = New System.Drawing.Point(985, 242)
        Me.PSFScopeSetUp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PSFScopeSetUp.Name = "PSFScopeSetUp"
        Me.PSFScopeSetUp.Size = New System.Drawing.Size(120, 25)
        Me.PSFScopeSetUp.TabIndex = 95
        Me.PSFScopeSetUp.Text = "PSF Scope Setup"
        Me.PSFScopeSetUp.UseVisualStyleBackColor = False
        '
        'TBParName1
        '
        Me.TBParName1.Location = New System.Drawing.Point(784, 103)
        Me.TBParName1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBParName1.Name = "TBParName1"
        Me.TBParName1.Size = New System.Drawing.Size(116, 22)
        Me.TBParName1.TabIndex = 96
        '
        'TBParValue1
        '
        Me.TBParValue1.Location = New System.Drawing.Point(933, 103)
        Me.TBParValue1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBParValue1.Name = "TBParValue1"
        Me.TBParValue1.Size = New System.Drawing.Size(171, 22)
        Me.TBParValue1.TabIndex = 97
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(775, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 17)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Parameter Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(949, 84)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 17)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Parameter Values"
        '
        'TBParValue2
        '
        Me.TBParValue2.Location = New System.Drawing.Point(933, 135)
        Me.TBParValue2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBParValue2.Name = "TBParValue2"
        Me.TBParValue2.Size = New System.Drawing.Size(171, 22)
        Me.TBParValue2.TabIndex = 101
        '
        'TBParName2
        '
        Me.TBParName2.Location = New System.Drawing.Point(784, 135)
        Me.TBParName2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBParName2.Name = "TBParName2"
        Me.TBParName2.Size = New System.Drawing.Size(116, 22)
        Me.TBParName2.TabIndex = 100
        '
        'TBParRange3
        '
        Me.TBParRange3.Location = New System.Drawing.Point(933, 167)
        Me.TBParRange3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBParRange3.Name = "TBParRange3"
        Me.TBParRange3.Size = New System.Drawing.Size(171, 22)
        Me.TBParRange3.TabIndex = 103
        Me.TBParRange3.Visible = False
        '
        'TBParName3
        '
        Me.TBParName3.Location = New System.Drawing.Point(784, 167)
        Me.TBParName3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBParName3.Name = "TBParName3"
        Me.TBParName3.Size = New System.Drawing.Size(116, 22)
        Me.TBParName3.TabIndex = 102
        '
        'TBParRange4
        '
        Me.TBParRange4.Location = New System.Drawing.Point(933, 199)
        Me.TBParRange4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBParRange4.Name = "TBParRange4"
        Me.TBParRange4.Size = New System.Drawing.Size(171, 22)
        Me.TBParRange4.TabIndex = 105
        Me.TBParRange4.Visible = False
        '
        'TBParName4
        '
        Me.TBParName4.Location = New System.Drawing.Point(784, 199)
        Me.TBParName4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBParName4.Name = "TBParName4"
        Me.TBParName4.Size = New System.Drawing.Size(116, 22)
        Me.TBParName4.TabIndex = 104
        Me.TBParName4.Visible = False
        '
        'TBFEPath
        '
        Me.TBFEPath.Location = New System.Drawing.Point(663, 50)
        Me.TBFEPath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBFEPath.Name = "TBFEPath"
        Me.TBFEPath.Size = New System.Drawing.Size(576, 22)
        Me.TBFEPath.TabIndex = 106
        Me.TBFEPath.Text = "C:\Evolver\"
        Me.TBFEPath.WordWrap = False
        '
        'BtnFEPath
        '
        Me.BtnFEPath.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnFEPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFEPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnFEPath.Location = New System.Drawing.Point(663, 23)
        Me.BtnFEPath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnFEPath.Name = "BtnFEPath"
        Me.BtnFEPath.Size = New System.Drawing.Size(120, 25)
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 560)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
