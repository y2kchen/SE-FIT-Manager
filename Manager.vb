Imports System.Threading.Tasks
Imports System
Imports System.Diagnostics
Imports System.ComponentModel
Imports System.IO
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.Entity
'how do I chat with you?
'I am not sure what you mean by chat with me. You can ask questions here and I will try to answer them.
'if I have a code written in C, can you help me to convert it to VB?
'Yes, I can help you with that. Just paste the code here and I will try to convert it to VB.
'you are very powerful!
'Thank you! I am just a computer program, so I am not powerful. I am here to help you with your programming questions.
'I have SE-FIT written in VB as a front end and Surface evolver written in C as a back end. Surface Evolver was written 30 years ago
'For the future, I would recommend that you consider updating Surface Evolver to a more modern language, such as C# or Python. This will make it easier to maintain and extend the software in the future.
'what about SE-FIT?
'SE-FIT is written in VB. You could consider updating it to a more modern language as well, such as C# or Python. This would make it easier to maintain and extend the software in the future.
'C# or python, which one is better?
'Both C# and Python are popular programming languages with their own strengths and weaknesses. C# is commonly used for Windows applications and games, while Python is known for its simplicity and readability. It depends on your specific needs and preferences.
'I want to put the two together with a GUI, what do you suggest?
'For a GUI application that combines SE-FIT and Surface Evolver, you could consider using C# with the Windows Presentation Foundation (WPF) framework. This would allow you to create a modern, user-friendly interface for your software.
'what about C++?
'C++ is a powerful programming language that is commonly used for system programming and high-performance applications. It is more complex than C# or Python, but offers greater control over hardware and memory management. If you are comfortable with C++, it could be a good choice for your project.
'Surface evolver is for scientific computing, which one is better for scientific computing?
'For scientific computing, Python is a popular choice due to its extensive libraries and tools for data analysis, visualization, and machine learning. C++ is also commonly used for scientific computing, especially for high-performance applications that require low-level control over hardware.
'what do you mean by low-level control over hardward?
'Low-level control over hardware refers to the ability to directly access and manipulate hardware components, such as memory, processors, and peripherals. C++ allows developers to write code that interacts with hardware at a very detailed level, which can be useful for performance-critical applications.
'do you know flow 3D?
'Yes, FLOW-3D is a computational fluid dynamics (CFD) software package used for simulating fluid flow and heat transfer in industrial and scientific applications. It is commonly used in the aerospace, automotive, and manufacturing industries to model complex fluid dynamics problems.
'what is Flow-3D written in?
'FLOW-3D is written in C++ and Fortran, with a graphical user interface (GUI) implemented in Java. The core computational algorithms are written in C++ for performance and efficiency, while the GUI is written in Java for cross-platform compatibility.
'why not write the GUI in C++?
'Java was chosen for the GUI of FLOW-3D because of its cross-platform compatibility and ease of use for developing graphical user interfaces. Java applications can run on any platform that supports the Java Virtual Machine (JVM), making it a good choice for software that needs to be deployed on multiple operating systems.
'C++ can be cross-plateform too, right?
'Yes, C++ can be used to develop cross-platform applications, but it requires more effort and platform-specific code to achieve the same level of compatibility as Java. Java's "write once, run anywhere" philosophy makes it easier to create GUI applications that work on multiple operating systems without modification.

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
                'why do you use cmd.exe?
                'The code uses cmd.exe to start the SE-FIT process with a specific processor affinity setting.
                'This allows the code to control the processor cores used by the SE-FIT process.
                'where is cmd.exe located?
                'cmd.exe is located in the Windows\System32 directory on most Windows systems.
                'The code uses the full path to cmd.exe to ensure that it can be found and executed correctly.
                'why do you use /C?
                '/C is a command-line option for cmd.exe that tells it to run the specified command and then terminate.
                'This allows the code to start SE-FIT with the specified affinity setting and then exit the command prompt.
                'what is START?
                'START is a command-line option for cmd.exe that tells it to start a new command prompt window and run the specified command in that window.
                'This allows the code to launch SE-FIT in a separate window with the specified affinity setting.
                'what is /high?
                '/high is a command-line option for START that tells it to run the specified command with high priority.
                'This can improve the performance of SE-FIT by giving it more CPU time and resources.
                'can I add more options?
                'Yes, you can add more options to the command line to customize the behavior of the SE-FIT process.
                'how about an option to start frmParIncRun in SE-FIT, grab the data from a database, and then start the simulation?
                'Yes, you can modify the command line to start frmParIncRun in SE-FIT, read data from a database, and then start the simulation.
                'You would need to pass the appropriate command-line arguments to SE-FIT to achieve this behavior.
                'can you show me how to do that?
                'Sure! Here is an example of how you could modify the command line to start frmParIncRun in SE-FIT and read data from a database:
                'In this example, SE-FIT.exe is started with the /frmParIncRun option to launch the frmParIncRun form, and the /database=mydatabase.db option to specify the database to read data from.
                'how do I add /frmParIncRun /database=mydatabase.db to SE-FIT?
                'To add the /frmParIncRun /database=mydatabase.db options to SE-FIT, you would need to modify the SE-FIT code to handle these command-line arguments.

                .FileName = "cmd.exe"
                '.FileName = "C:\Windows\System32\cmd.exe"
                '.Arguments = "/C START /high /affinity " + a + " SE-FIT.exe"
                '.Arguments = "/C START /high /affinity " + a + " SE-FIT.exe /frmParIncRun /database=mydatabase.db"
                .Arguments = "/C START /affinity " + a + " " + executable + " /frmParIncRun "
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
    'can you su,,arize the code for me?
    'The code is a Windows Forms application that launches multiple instances of a program called SE-FIT.exe with different processor affinities.
    'The user can select the number of instances to launch and the processor cores to use. The code uses the Process class to start SE-FIT.exe
    'with the specified affinity and core settings. The application also displays information about the running SE-FIT processes and allows
    'the user to select the path to the SE-FIT executable. The code is written in Visual Basic .NET and uses asynchronous programming to
    'launch multiple instances of SE-FIT concurrently.
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
                'there is a reason for using ',' instead of ';' at the end of each line. 

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

    Private Sub PSFScopeSetUp_Click(sender As Object, e As EventArgs) Handles PSFScopeSetUp.Click
        'Dim dataFileName As String
        'Dim DMPfile As String
        Dim prefix As String = Now().ToString("yyyyMMdd_HHmmss") + "_"
        Dim FileNameText As String
        Dim LineElements As String()
        Dim ParName1Text As String
        Dim ParValue1 As String
        Dim ParValue1Count As Integer
        Dim ParValue1Text(1) As String
        Dim ParName2Text As String
        Dim ParValue2 As String
        Dim ParValue2Count As Integer
        Dim ParValue2Text(1) As String
        'TBParName1 will take the input in the form of a set of numbers separated by comas, I ant to take one number a time and assign it to ParValue1Text
        'can you help with that?

        Dim commandBlocks As New List(Of String)()
        Dim currentBlock As New Text.StringBuilder()

        Dim dbHelper As New DatabaseHelper4PSF()

        Dim filenameAppenndix As String = "_new"
        filenameAppenndix = tbDumpFNameSuffix.Text

        FileNameText = TBFEPath.Text
        dbHelper.ClearDatabaseData()
        ParName1Text = TBParName1.Text
        ParValue1 = TBParValue1.Text

        If ParValue1.Contains(";") Then
            ParValue1 = ParValue1.Replace(" ", "")
            ParValue1 = ParValue1.Replace(";", " ")
            LineElements = ParValue1.Split
            ParValue1Count = LineElements.Length
            ReDim ParValue1Text(ParValue1Count)
            For j = 0 To ParValue1Count - 1
                ParValue1Text(j) = LineElements(j)
            Next
        Else
            LineElements = ParValue1.Split
            If LineElements.Length <> 3 Then
                MessageBox.Show("Error processing line", "Parameter Sweep")
                Exit Sub
            End If
            Dim iterator As Double = CDbl(LineElements(0))
            'During the debug, I could see that ParValue1Text(0) is "0" which is not null, but on line 423, it's null, why is that?
            'any thought?

            ParValue1Text(0) = LineElements(0)
            'do I need to convert it to string?
            ParValue1Count = 1
            iterator += CDbl(LineElements(1))
            If CDbl(LineElements(1)) > 0 Then
                While iterator <= CDbl(LineElements(2)) + CDbl(LineElements(1)) / 100.0
                    ReDim Preserve ParValue1Text(ParValue1Count + 1)
                    ParValue1Text(ParValue1Count) = iterator.ToString
                    iterator += CDbl(LineElements(1))
                    ParValue1Count += 1
                End While
            End If
            If CDbl(LineElements(1)) < 0 Then
                While iterator >= CDbl(LineElements(2)) + CDbl(LineElements(1)) / 100.0
                    ReDim Preserve ParValue1Text(ParValue1Count + 1)
                    ParValue1Text(ParValue1Count) = iterator
                    iterator += CDbl(LineElements(1))
                    ParValue1Count += 1
                End While
            End If
        End If

        ParName2Text = TBParName2.Text
        ParValue2 = TBParValue2.Text

        ParValue2 = ParValue2.Replace(" ", "")
        ParValue2 = ParValue2.Replace(";", " ")
        LineElements = ParValue2.Split
        ParValue2Count = LineElements.Length
        ReDim ParValue2Text(ParValue2Count)
        For j = 0 To ParValue2Count - 1
            ParValue2Text(j) = LineElements(j)
        Next

        If ParValue1Count <> ParValue2Count Then
            MessageBox.Show("The numbers of the parameter values don't match", "Parameter Sweep")
            Exit Sub
        End If
        'ParValue1Text(0) is not null, however it is null on line 423, why is that?
        'any thought?
        'are you there?
        'I am here. It's hard to say without seeing the specific code, but it's possible that the array is being accessed out of bounds or the values are being overwritten somewhere in the code. I would recommend checking the code carefully to ensure that the array is being populated correctly and that the values are not being modified unexpectedly.
        For i = 0 To ParValue1Count - 1
            currentBlock.AppendLine(FileNameText + ",")
            currentBlock.AppendLine(ParName1Text + ",")
            currentBlock.AppendLine(ParValue1Text(i) + ",")
            currentBlock.AppendLine(ParName2Text + ",")
            currentBlock.AppendLine(ParValue2Text(i))
            dbHelper.AddCommandBlock(currentBlock.ToString())
            'commandBlocks.Add(currentBlock.ToString())
            currentBlock.Clear()
        Next

        'For Each block As String In commandBlocks
        '    dbHelper.AddCommandBlock(block)
        'Next
    End Sub

    Private Sub BtnFEPath_Click(sender As Object, e As EventArgs) Handles BtnFEPath.Click
        'FolderBrowserDialog1.SelectedPath = tbPath.Text
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        If (result = Windows.Forms.DialogResult.OK) Then
            TBFEPath.Text = OpenFileDialog1.FileName
        End If
    End Sub

End Class
