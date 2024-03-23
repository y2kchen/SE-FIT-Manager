Imports System.Data.SQLite
Imports System.IO
Imports System.Reflection

Public Class DatabaseHelper

    Dim assemblyPath As String = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
    Dim dbPath As String = Path.Combine(assemblyPath, "communication\database\BatchRun.db")
    Dim connectionString As String = $"Data Source={dbPath}; Version=3;"

    'Private ReadOnly Property ConnectionString As String
    '    Get
    '        Return "Data Source=\bin\communication\database\BatchRun.db; Version=3;"
    '    End Get
    'End Property

    Public Sub New()
        ' Optionally, create the database table when the helper is initialized
        CreateTable()
    End Sub

    Public Sub CreateTable()
        Dim createTableSql As String = "CREATE TABLE IF NOT EXISTS CommandBlocks (Id INTEGER PRIMARY KEY AUTOINCREMENT, Commands TEXT NOT NULL, Processed BOOLEAN NOT NULL DEFAULT 0);"
        Using conn As New SQLiteConnection(ConnectionString)
            conn.Open()
            Using cmd As New SQLiteCommand(createTableSql, conn)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub AddCommandBlock(commandBlock As String)
        Dim insertSql As String = "INSERT INTO CommandBlocks (Commands, Processed) VALUES (@Commands, 0)"
        Using conn As New SQLiteConnection(ConnectionString)
            conn.Open()
            Using cmd As New SQLiteCommand(insertSql, conn)
                cmd.Parameters.AddWithValue("@Commands", commandBlock)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    'If you want to remove all data from the database but keep the structure (tables, indexes, etc.),
    'you can execute DELETE statements for each table.
    'This approach allows you to start fresh with empty tables without changing the database schema.
    Public Sub ClearDatabaseData() '(connectionString As String)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()

            ' List all tables you want to clear
            Dim tables As New List(Of String) From {"CommandBlocks"}

            For Each table In tables
                Dim sql As String = $"DELETE FROM {table}"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                End Using
            Next
        End Using
    End Sub

    'If you want to completely remove the tables and perhaps recreate them with a different schema,
    'you can use DROP TABLE statements followed by your CREATE TABLE statements.
    Sub ResetDatabaseSchema(connectionString As String)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()

            ' SQL to drop a table
            Dim dropTableSql As String = "DROP TABLE IF EXISTS CommandBlocks;"

            ' Execute DROP TABLE command
            Using cmd As New SQLiteCommand(dropTableSql, conn)
                cmd.ExecuteNonQuery()
            End Using

            ' Recreate the table or tables as needed
            Dim createTableSql As String = "CREATE TABLE CommandBlocks (Id INTEGER PRIMARY KEY AUTOINCREMENT, Commands TEXT NOT NULL, Processed BOOLEAN NOT NULL DEFAULT 0);"
            Using cmd As New SQLiteCommand(createTableSql, conn)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    'For a complete reset, you might choose to delete the SQLite database file itself and then recreate it by opening a new connection.
    'This approach removes all data and schema, essentially giving you a brand-new database.
    Sub RecreateDatabaseFile(databasePath As String)
        ' Close any existing connections to the database here

        If File.Exists(databasePath) Then
            File.Delete(databasePath)
        End If

        ' The next time you connect to this path, SQLite will create a new database file
        Dim connectionString As String = $"Data Source={databasePath}; Version=3;"

        ' Optionally, immediately create a new database file with the initial schema
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()

            ' Create tables as needed
            Dim createTableSql As String = "CREATE TABLE CommandBlocks (Id INTEGER PRIMARY KEY AUTOINCREMENT, Commands TEXT NOT NULL, Processed BOOLEAN NOT NULL DEFAULT 0);"
            Using cmd As New SQLiteCommand(createTableSql, conn)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Additional methods for updating, deleting, and querying data can be added here

End Class
