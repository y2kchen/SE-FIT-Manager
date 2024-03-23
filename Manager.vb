Imports System.Threading.Tasks
Imports System
Imports System.Diagnostics
Imports System.ComponentModel
Imports System.IO
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Manager
    Dim cores As Integer = 0
    Dim bwdpath As String = ""
    Dim fwdpath As String = ""

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        bwdpath = Path.GetDirectoryName(Application.ExecutablePath) + "\"
        fwdpath = bwdpath.Replace("\", "/")

        'Static Dim n As Integer = 0
        Static Dim maxProcessorAffinity As Integer = 0
        Dim i, id, core64(64) As Integer
        BtnLaunch.Enabled = True
        Try
            If maxProcessorAffinity = 0 Then
                'n += 1
                ' Get all processes running on the local computer. 
                Dim localAll As Process() = Process.GetProcesses()

                For Each p As Process In localAll
                    Try
                        If maxProcessorAffinity < p.ProcessorAffinity.ToInt64 Then
                            maxProcessorAffinity = p.ProcessorAffinity.ToInt64
                        End If
                    Catch ex As Exception

                    End Try
                Next

                Dim temp = maxProcessorAffinity
                While temp > 0
                    temp \= 2
                    cores += 1
                End While
                Me.Text = "SE-FIT Launcher detects " + cores.ToString + " cores."
                NumCounter.Maximum = cores - 1
                Label2.Text = "(0 - " + (cores - 1).ToString + ")"
                'NumericUpDown1.Maximum = cores - 1
            End If
            RichTextBox1.Clear()
            For id = 0 To cores - 1
                core64(id) = 0
            Next
            Dim localByName As Process() = Process.GetProcessesByName("SE-FIT")
            If localByName.Length > 0 Then
                For Each p As Process In localByName
                    RichTextBox1.AppendText("SE-FIT process " + p.Id.ToString + ", affinity: " + p.ProcessorAffinity.ToString() + ", core: ")
                    i = 1
                    id = 0
                    While id < cores
                        If p.ProcessorAffinity.ToInt64 And i Then
                            RichTextBox1.AppendText(id.ToString + "  ")
                            core64(id) += 1
                        End If
                        i *= 2
                        id += 1
                    End While
                    RichTextBox1.AppendText(vbNewLine)
                Next
            Else

            End If
            id = 0
            For i = 1 To cores - 1 Step 1
                If core64(id) > core64(i) Then
                    id = i
                End If
            Next


            'NumericUpDown1.Value = id
            'RichTextBox1.AppendText("Target core # " + id.ToString + vbNewLine)

        Catch ex As Exception
            BtnLaunch.Enabled = False
            MessageBox.Show("Could not access process list.", "Error!")
        End Try
    End Sub

    Dim fileList As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
    Dim orderedFilesByCreationTime As New System.Collections.Generic.List(Of String)
    Private Sub btnSetPath_Click(sender As Object, e As EventArgs) Handles btnSetPath.Click
        FolderBrowserDialog1.SelectedPath = tbPath.Text
        Dim result As DialogResult = FolderBrowserDialog1.ShowDialog()

        If (result = Windows.Forms.DialogResult.OK) Then
            tbPath.Text = FolderBrowserDialog1.SelectedPath
        End If
        get_files()

    End Sub

    Private Sub get_files()
        fileList = My.Computer.FileSystem.GetFiles(
                    tbPath.Text,
                    FileIO.SearchOption.SearchTopLevelOnly, "*.dmp")
        If RBTimeAscend.Checked Then
            orderedFilesByCreationTime = fileList.ToList().OrderBy(Function(file) New FileInfo(file).CreationTime).ToList()
        ElseIf RBTimeDescend.Checked Then
            orderedFilesByCreationTime = fileList.ToList().OrderByDescending(Function(file) New FileInfo(file).CreationTime).ToList()
        End If

    End Sub


    'Private Sub BtnLaunch_Click(sender As Object, e As EventArgs) Handles BtnLaunch.Click
    '    For Each foundFile As String In orderedFilesByCreationTime 'fileList

    '    Next
    '    For i = 1 To cores - 1 Step 2
    '        RunSEFITSession(i)
    '    Next
    '    Form1_Activated(sender, e)


    'End Sub

    Async Sub BtnLaunch_Click(sender As Object, e As EventArgs) Handles BtnLaunch.Click
        '        For i = 1 To cores - 1 Step 2
        Dim i As Integer
        For i = 1 To NumCounter.Value Step 1
            RunSEFITSession(i)
            Await Task.Delay(4000)
        Next
        Form1_Activated(sender, e)


    End Sub


    ' In an asynchronous method


    'Async Function RunSEFITSessionAsync(sessionParams As Integer) As Task(Of String)


    '    Return Task.Run(Function()
    '                        ' Code to start and run the SE-FIT session using sessionParams
    '                        Dim result As SEFITResult = RunSEFITSession(sessionParams) ' Placeholder for actual SE-FIT execution
    '                        Return result
    '                    End Function)
    'End Function
    'where do I put the following code?

    '    Dim sessions As New List(Of Task(Of SEFITResult))
    '    For Each param In listOfParameters ' listOfParameters contains the parameters for each session
    '    sessions.Add(RunSEFITSessionAsync(param))
    '    Next

    '' Wait for all sessions to complete
    '    Task.WaitAll(sessions.ToArray())

    '' Or process results as they complete
    '    For Each session In sessions
    '    Dim result = Await session
    '    ' Process result
    '    Next

    Private Sub RunSEFITSession(x As Integer)
        Dim a As String = ""
        'Dim z, x As Integer
        Dim z As Integer
        Dim executable As String = "SE-FIT.exe"
        z = 0
        'x = NumericUpDown1.Value
        While x > 3
            x -= 4
            z += 1
        End While
        Select Case x
            Case 0
                a = "1"
            Case 1
                a = "2"
            Case 2
                a = "4"
            Case 3
                a = "8"
        End Select
        While z > 0
            z -= 1
            a += "0"
        End While
        'Me.Text = a
        'System.Diagnostics.Process.Start()
        '"C:\Windows\System32\cmd.exe /C START /high /affinity 1 SE-FIT.exe"
        If Not File.Exists(executable) Then
            MessageBox.Show("Could not find " + executable + " in the current directory.", "Error!")
            Return
        End If
        Try
            Dim gSEProcess As New Process()
            With gSEProcess.StartInfo
                .FileName = "cmd.exe"
                '.FileName = "C:\Windows\System32\cmd.exe"
                '.Arguments = "/C START /high /affinity " + a + " SE-FIT.exe"
                .Arguments = "/C START /affinity " + a + " " + executable
                .UseShellExecute = False
                .CreateNoWindow = True
                '.RedirectStandardOutput = True
                '.RedirectStandardError = True
                '.RedirectStandardInput = True
                '.WorkingDirectory = bwdpath
                '.WindowStyle = ProcessWindowStyle.Hidden
                'If 1 Then
                '  gSEProcess.ProcessorAffinity = Marshal.ReadInt64(gProcessorAffinity)
                'End If
                '.Arguments = ""
                '.CreateNoWindow = False
                '.RedirectStandardOutput = False ' WITHOUT THIS LEVOLVER FREEZES AFTER REPEATED DUMP COMMANDS!
                '.RedirectStandardError = False
                '.RedirectStandardInput = False
                '.WindowStyle = ProcessWindowStyle.Normal
            End With
            'Start evolver.exe in the background
            gSEProcess.Start()
        Catch ex As Exception
            MessageBox.Show("Could not find " + executable + " in the current directory.", "Error!")
        End Try

    End Sub

    Private Sub BtnGenScr_Click(sender As Object, e As EventArgs) Handles BtnGenScr.Click
        Dim dataFileName As String
        Dim DMPfile As String
        Dim prefix As String = Now().ToString("yyyyMMdd_HHmmss") + "_"
        Dim commandBlocks As New List(Of String)()
        Dim currentBlock As New Text.StringBuilder()

        Dim dbHelper As New DatabaseHelper()

        Dim filenameAppenndix As String = "_new"
        filenameAppenndix = tbDumpFNameSuffix.Text

        If File.Exists(bwdpath + "communication\history\" + "Batch_Proc_Setup.txt") Then
            File.Delete(bwdpath + "communication\history\" + "Batch_Proc_Setup.txt")
        End If

        Using sw As StreamWriter = New StreamWriter(bwdpath + "communication\history\" + "Batch_Proc_Setup.txt")

            sw.WriteLine(tbPath.Text + "\" + prefix + "batch_script.ses")
        End Using

        get_files()

        dbHelper.ClearDatabaseData()

        Using sw As StreamWriter = New StreamWriter(tbPath.Text + "\" + prefix + "batch_script.ses")

            For Each foundFile As String In orderedFilesByCreationTime 'fileList
                dataFileName = foundFile.Substring(foundFile.LastIndexOf("\") + 1)
                sw.WriteLine("chdir " + """" + tbPath.Text.Replace("\", "/") + """")
                sw.WriteLine("quietload on ")
                sw.WriteLine("load " + """" + dataFileName + """")
                sw.WriteLine("quietload off ")
                sw.WriteLine("if is_defined(" + """" + "get_all_update" + """" + ") == 0 then {read " + """" + fwdpath + "lib/get_all_update.ses" + """" + "}")
                'sw.WriteLine("get_all_update") 'this one causes trouble to the scripts with iterations
                sw.WriteLine("get_stats")
                currentBlock.AppendLine("chdir " + """" + tbPath.Text.Replace("\", "/") + """" + ",")
                currentBlock.AppendLine("quietload on, ")
                currentBlock.AppendLine("load " + """" + dataFileName + """" + ",")
                currentBlock.AppendLine("quietload off, ")
                currentBlock.AppendLine("if is_defined(" + """" + "get_all_update" + """" + ") == 0 then {read " + """" + fwdpath + "lib/get_all_update.ses" + """" + "},")
                currentBlock.AppendLine("get_stats,")

                For i = 0 To TbScrCor.Lines.Length - 1
                    If TbScrCor.Lines(i).Length > 0 Then
                        sw.WriteLine(TbScrCor.Lines(i) + ",")
                        currentBlock.AppendLine(TbScrCor.Lines(i) + ",")
                    End If
                Next
                DMPfile = dataFileName.Substring(0, dataFileName.LastIndexOf("."c))
                DMPfile = DMPfile + filenameAppenndix + ".dmp"
                sw.WriteLine("dump " + """" + DMPfile + """" + vbNewLine)
                currentBlock.AppendLine("dump " + """" + DMPfile + """" + ",")
                currentBlock.AppendLine("printf " + """" + "current_block_of_batch_script_2_complete\n" + """")
                commandBlocks.Add(currentBlock.ToString())
                currentBlock.Clear()
            Next
        End Using

        For Each block As String In commandBlocks
            dbHelper.AddCommandBlock(block)
        Next

    End Sub
End Class
