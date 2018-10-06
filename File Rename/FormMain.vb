Imports System.IO

Public Class FormMain
    Dim formLoaded As Boolean = False
    Dim folderPath As String = ""
    Dim myOriginalDataTable As DataTable = Nothing
    Dim mySearchDataTable As DataTable = Nothing
    Dim myReplacementDataTable As DataTable = Nothing
    Dim myFileNameList As New List(Of FileNames)
    Dim mySearchList As New List(Of FileNames)
    Dim myFileTypeFilter As Common.FileTypeFilter

    Private Sub FormFileRename_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'datagridview
        Me.DataGridViewFileNamesOriginal.DefaultCellStyle.Font = New Font("Tahoma", 14)
        myFileTypeFilter = Common.FileTypeFilter.None
        formLoaded = True
    End Sub

    Private Sub ButtonSelectFolder_Click(sender As Object, e As EventArgs) Handles ButtonSelectFolder.Click
        FolderBrowserDialogFileNames.SelectedPath = My.Settings.ModFolder
        If (FolderBrowserDialogFileNames.ShowDialog() = DialogResult.OK) Then
            TextBoxSelectFolder.Text = FolderBrowserDialogFileNames.SelectedPath
            folderPath = TextBoxSelectFolder.Text
            My.Settings.ModFolder = FolderBrowserDialogFileNames.SelectedPath
            My.Settings.Save()
        End If
    End Sub

#Region "Load Files"

    Private Sub ButtonFileLoad_Click(sender As Object, e As EventArgs) Handles ButtonFileLoad.Click
        Dim folderPathName As String = TextBoxSelectFolder.Text
        If folderPathName <> String.Empty AndAlso Directory.Exists(folderPathName) Then
            LoadFiles(folderPathName, True)
        Else
            MsgBox("Please enter folder path!")
        End If
    End Sub

    Private Sub LoadFiles(folderPathName As String, refreshGrid As Boolean)
        If folderPathName <> String.Empty AndAlso Directory.Exists(folderPathName) Then
            'get file names
            myFileNameList = New List(Of FileNames)
            GetAllFiles(myFileNameList, folderPathName, True)
            'load grid
            If refreshGrid Then
                myOriginalDataTable = Nothing
                myOriginalDataTable = CreateDataTable()
            End If
            LoadGrid(myOriginalDataTable, myFileNameList)
        End If
    End Sub

    Private Sub GetAllFiles(ByRef myFileNameList As List(Of FileNames), rootPath As String, recursiveSearch As Boolean)
        Dim objRoot As New DirectoryInfo(rootPath)
        Dim objSubDir As DirectoryInfo
        Dim objFile As FileInfo

        If objRoot.Exists Then
            'if recursive search then loop subdirectories
            If recursiveSearch Then
                Dim myDirectories = objRoot.GetDirectories.Where(Function(file) ((file.Attributes And FileAttributes.Hidden) <> FileAttributes.Hidden) _
                                                                         AndAlso (file.Attributes And FileAttributes.System) <> FileAttributes.System)
                For Each objSubDir In myDirectories
                    'add to list
                    GetAllFiles(myFileNameList, objSubDir.FullName, True)
                Next
            End If
            'keep this for loop
            For Each objFile In objRoot.GetFiles
                FillFileNameList(myFileNameList, objFile.FullName, objFile.Name, objFile.Extension, myFileTypeFilter)
            Next
        End If
    End Sub

    Private Sub FillFileNameList(ByRef fileNameList As List(Of FileNames), ByVal fullFileName As String, ByVal fileName As String,
                                 ByVal fileExtension As String, ByVal fileTypeFilter As Common.FileTypeFilter)
        Dim fileCollection As New FileNames
        If fileTypeFilter = Common.FileTypeFilter.Audio Then
            'Audio
            If Common.AudioFileExtensions.Where(Function(x) x.Contains(fileExtension.ToUpper)).Count > 0 Then
                'only add audio files
                fileCollection.FileFullName = fullFileName
                fileCollection.FileName = fileName
                fileNameList.Add(fileCollection)
            End If
        ElseIf fileTypeFilter = Common.FileTypeFilter.Video Then
            'Video
            If Common.VideoFileExtensions.Where(Function(x) x.Contains(fileExtension.ToUpper)).Count > 0 Then
                'only add audio files
                fileCollection.FileFullName = fullFileName
                fileCollection.FileName = fileName
                fileNameList.Add(fileCollection)
            End If
        ElseIf fileTypeFilter = Common.FileTypeFilter.Photos Then
            'Photos
            If Common.PhotoFileExtensions.Where(Function(x) x.Contains(fileExtension.ToUpper)).Count > 0 Then
                'only add audio files
                fileCollection.FileFullName = fullFileName
                fileCollection.FileName = fileName
                fileNameList.Add(fileCollection)
            End If
        ElseIf fileTypeFilter = Common.FileTypeFilter.Documents Then
            'Documents
            If Common.DocumentFileExtensions.Where(Function(x) x.Contains(fileExtension.ToUpper)).Count > 0 Then
                'only add audio files
                fileCollection.FileFullName = fullFileName
                fileCollection.FileName = fileName
                fileNameList.Add(fileCollection)
            End If
        ElseIf fileTypeFilter = Common.FileTypeFilter.Other Then
            If fileExtension = TextBoxExtension.Text Then
                'Other
                fileCollection.FileFullName = fullFileName
                fileCollection.FileName = fileName
                fileNameList.Add(fileCollection)
            End If
        Else
            'only add audio files
            fileCollection.FileFullName = fullFileName
            fileCollection.FileName = fileName
            fileNameList.Add(fileCollection)
        End If
    End Sub

    Private Function CreateDataTable() As DataTable
        Dim dt As New DataTable("DataTableFileNames")
        'Add the following columns: Name. Length Last Write Time, Creation Time
        dt.Columns.AddRange({New DataColumn("FullName"),
                             New DataColumn("FileName")})
        Return dt
    End Function

    Private Sub FillDataTable(ByRef dt As DataTable, ByVal fileNamesList As List(Of FileNames))
        Try
            'Loop through each file in the list
            For Each file As FileNames In fileNamesList
                'Create a new row
                Dim dr As DataRow = dt.NewRow
                'Set the data
                dr(0) = file.FileFullName
                dr(1) = file.FileName
                'Add the row to the data table
                dt.Rows.Add(dr)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadGrid(dtTable As DataTable, fileList As List(Of FileNames))
        'fill datatable
        FillDataTable(dtTable, fileList)
        DataGridViewFileNamesOriginal.DataSource = dtTable
        If dtTable Is Nothing Then Exit Sub
        LabelTotalFilesOriginalCounter.Text = CStr(dtTable.Rows.Count)
        'populate data in the grid
        If DataGridViewFileNamesOriginal.Columns.Count > 0 Then
            DataGridViewFileNamesOriginal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DataGridViewFileNamesOriginal.AutoResizeColumns()
            DataGridViewFileNamesOriginal.Columns(0).Visible = False
        Else
            MsgBox("No files found!")
        End If
    End Sub

#End Region

#Region "Search FileNames"

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        Dim searchText As String
        searchText = TextBoxSearch.Text
        SearchFiles(DataGridViewFileNamesOriginal, searchText)
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        TextBoxSearch.Text = ""
        SearchFiles(DataGridViewFileNamesOriginal, String.Empty)
    End Sub

    Private Sub TextBoxSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxSearch.KeyUp
        SearchFiles(DataGridViewFileNamesOriginal, TextBoxSearch.Text)
    End Sub

    Private Sub SearchFiles(myDataGrid As DataGridView, searchString As String)
        If myOriginalDataTable IsNot Nothing AndAlso myOriginalDataTable.Rows.Count > 0 Then
            Dim myDataView As New DataView
            myDataView = myOriginalDataTable.DefaultView
            myDataView.RowFilter = "[FileName] Like '%" & searchString & "%'"
            myDataGrid.DataSource = myDataView
            LabelTotalFilesOriginalCounter.Text = CStr(myDataView.Count)
        End If
    End Sub

#End Region

#Region "Replace FileNames"

    Private Sub ButtonReplaceFileNames_Click(sender As Object, e As EventArgs) Handles ButtonReplaceFileNames.Click
        Dim oldSting As String = ""
        Dim newString As String = ""
        If TextBoxFileNameOriginal.Text = "" Then
            MsgBox("Enter file text to replace")
            TextBoxFileNameOriginal.Focus()
            Exit Sub
        Else
            oldSting = TextBoxFileNameOriginal.Text
        End If
        newString = TextBoxFileNameReplacement.Text
        If DataGridViewFileNamesOriginal.Rows.Count = 0 Then
            MsgBox("No files found for selected folder or Files are not loaded!")
            Exit Sub
        End If
        'get the file name collection
        Dim fileNameCollection As List(Of String)
        fileNameCollection = GetFileNameCollection()
        'replace file names
        If fileNameCollection.Count > 0 Then
            ReplaceFileNames(fileNameCollection, oldSting, newString)
        Else
            MsgBox("No files to replace")
        End If
    End Sub

    Private Function GetFileNameCollection() As List(Of String)
        Dim value As String = String.Empty
        Dim selectedFileNameCollection As New List(Of String)
        If myOriginalDataTable.Rows.Count > 0 Then
            For Each SelectedRow As DataGridViewRow In DataGridViewFileNamesOriginal.Rows
                value = (SelectedRow.Cells("FullName").Value.ToString.Trim)
                If value <> String.Empty Then
                    selectedFileNameCollection.Add(value)
                End If
            Next
        Else
            MsgBox("No files in the grid, pls load files")
        End If
        Return selectedFileNameCollection
    End Function

    Private Sub ReplaceFileNames(filesCollection As List(Of String), oldCharacters As String, newCharacters As String)
        Dim folderPathName As String = TextBoxSelectFolder.Text
        If folderPathName = String.Empty OrElse Not Directory.Exists(folderPathName) Then
            MsgBox("Please enter folder path!")
            Exit Sub
        End If
        Dim rootFilePath As String = ""
        Dim originalFileName As String = ""
        Dim newFileName As String = ""
        Dim replacementCount As Integer = 0
        For Each fullFileName As String In filesCollection
            originalFileName = Path.GetFileName(fullFileName)
            If originalFileName.Contains(oldCharacters) Then
                rootFilePath = Path.GetDirectoryName(fullFileName)
                newFileName = originalFileName.Replace(oldCharacters, newCharacters)
                Try
                    System.IO.File.Move(fullFileName, rootFilePath & "\" & newFileName)
                    replacementCount += 1
                Catch ex As Exception
                    'do not handle access denied
                End Try
            End If
        Next
        myFileTypeFilter = Common.FileTypeFilter.Other
        DataGridViewFileNamesOriginal.DataSource = Nothing
        LoadFiles(folderPathName, True)
        If replacementCount > 0 Then
            MsgBox("File names replaced = " & replacementCount)
            SearchFiles(DataGridViewFileNamesOriginal, TextBoxSearch.Text)
        End If
    End Sub

#End Region

#Region "Filter File Types by Extension"

    Private Sub RadioButtonPhotos_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPhotos.CheckedChanged
        If Not formLoaded Then Exit Sub
        DataGridViewFileNamesOriginal.DataSource = Nothing
        myFileTypeFilter = Common.FileTypeFilter.Photos
        Dim folderPathName As String = TextBoxSelectFolder.Text
        If folderPathName <> String.Empty AndAlso Directory.Exists(folderPathName) Then
            LoadFiles(folderPathName, True)
        Else
            MsgBox("Please enter folder path!")
        End If
    End Sub

    Private Sub RadioButtonAudio_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAudio.CheckedChanged
        If Not formLoaded Then Exit Sub
        myFileTypeFilter = Common.FileTypeFilter.Audio
        DataGridViewFileNamesOriginal.DataSource = Nothing
        Dim folderPathName As String = TextBoxSelectFolder.Text
        If folderPathName <> String.Empty AndAlso Directory.Exists(folderPathName) Then
            LoadFiles(folderPathName, True)
        Else
            MsgBox("Please enter folder path!")
        End If
    End Sub

    Private Sub RadioButtonVideos_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonVideos.CheckedChanged
        If Not formLoaded Then Exit Sub
        myFileTypeFilter = Common.FileTypeFilter.Video
        DataGridViewFileNamesOriginal.DataSource = Nothing
        Dim folderPathName As String = TextBoxSelectFolder.Text
        If folderPathName <> String.Empty AndAlso Directory.Exists(folderPathName) Then
            LoadFiles(folderPathName, True)
        Else
            MsgBox("Please enter folder path!")
        End If
    End Sub

    Private Sub RadioButtonDocuments_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDocuments.CheckedChanged
        If Not formLoaded Then Exit Sub
        myFileTypeFilter = Common.FileTypeFilter.Documents
        DataGridViewFileNamesOriginal.DataSource = Nothing
        Dim folderPathName As String = TextBoxSelectFolder.Text
        If folderPathName <> String.Empty AndAlso Directory.Exists(folderPathName) Then
            LoadFiles(folderPathName, True)
        Else
            MsgBox("Please enter folder path!")
        End If
    End Sub

    Private Sub TextBoxExtension_TextChanged(sender As Object, e As EventArgs) Handles TextBoxExtension.TextChanged
        If TextBoxExtension.Text.Length < 3 Then Exit Sub
        RadioButtonAudio.Checked = False
        RadioButtonVideos.Checked = False
        RadioButtonPhotos.Checked = False
        RadioButtonDocuments.Checked = False
        myFileTypeFilter = Common.FileTypeFilter.Other
        DataGridViewFileNamesOriginal.DataSource = Nothing
        Dim folderPathName As String = TextBoxSelectFolder.Text
        If folderPathName <> String.Empty AndAlso Directory.Exists(folderPathName) Then
            LoadFiles(folderPathName, True)
        Else
            MsgBox("Please enter folder path!")
        End If
    End Sub

#End Region

End Class
