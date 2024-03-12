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
        Me.BtnLaunch.Size = New System.Drawing.Size(162, 23)
        Me.BtnLaunch.TabIndex = 78
        Me.BtnLaunch.Text = "Launch SE-FIT"
        Me.BtnLaunch.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(197, 22)
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
        'Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 451)
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
        Me.Text = "SE-FIT Manager"
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
End Class
