<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.ButtonFileLoad = New System.Windows.Forms.Button()
        Me.ButtonSelectFolder = New System.Windows.Forms.Button()
        Me.TextBoxSelectFolder = New System.Windows.Forms.TextBox()
        Me.LabelSelectFolder = New System.Windows.Forms.Label()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.PanelLeftTotal = New System.Windows.Forms.Panel()
        Me.LabelTotalFilesOriginalCounter = New System.Windows.Forms.Label()
        Me.LabelTotalFilesOriginal = New System.Windows.Forms.Label()
        Me.DataGridViewFileNamesOriginal = New System.Windows.Forms.DataGridView()
        Me.PanelRight = New System.Windows.Forms.Panel()
        Me.PanelRightTotal = New System.Windows.Forms.Panel()
        Me.LabelTotalFilesReplacedCounter = New System.Windows.Forms.Label()
        Me.LabelTotalFilesReplaced = New System.Windows.Forms.Label()
        Me.DataGridViewFileNamesReplacement = New System.Windows.Forms.DataGridView()
        Me.PanelFileNames = New System.Windows.Forms.Panel()
        Me.TextBoxExtension = New System.Windows.Forms.TextBox()
        Me.RadioButtonDocuments = New System.Windows.Forms.RadioButton()
        Me.RadioButtonVideos = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAudio = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPhotos = New System.Windows.Forms.RadioButton()
        Me.PanelSearch = New System.Windows.Forms.Panel()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.LabelSearch = New System.Windows.Forms.Label()
        Me.ButtonReplaceFileNames = New System.Windows.Forms.Button()
        Me.TextBoxFileNameReplacement = New System.Windows.Forms.TextBox()
        Me.LabelFileReplaceName = New System.Windows.Forms.Label()
        Me.TextBoxFileNameOriginal = New System.Windows.Forms.TextBox()
        Me.LabelFileName = New System.Windows.Forms.Label()
        Me.FolderBrowserDialogFileNames = New System.Windows.Forms.FolderBrowserDialog()
        Me.PanelTop.SuspendLayout()
        Me.PanelMain.SuspendLayout()
        Me.PanelLeft.SuspendLayout()
        Me.PanelLeftTotal.SuspendLayout()
        CType(Me.DataGridViewFileNamesOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRight.SuspendLayout()
        Me.PanelRightTotal.SuspendLayout()
        CType(Me.DataGridViewFileNamesReplacement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFileNames.SuspendLayout()
        Me.PanelSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelTop.Controls.Add(Me.ButtonFileLoad)
        Me.PanelTop.Controls.Add(Me.ButtonSelectFolder)
        Me.PanelTop.Controls.Add(Me.TextBoxSelectFolder)
        Me.PanelTop.Controls.Add(Me.LabelSelectFolder)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1774, 137)
        Me.PanelTop.TabIndex = 3
        '
        'ButtonFileLoad
        '
        Me.ButtonFileLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonFileLoad.Font = New System.Drawing.Font("Calibri", 20.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFileLoad.Location = New System.Drawing.Point(1563, 34)
        Me.ButtonFileLoad.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonFileLoad.Name = "ButtonFileLoad"
        Me.ButtonFileLoad.Size = New System.Drawing.Size(194, 74)
        Me.ButtonFileLoad.TabIndex = 6
        Me.ButtonFileLoad.Text = "Load"
        Me.ButtonFileLoad.UseVisualStyleBackColor = True
        '
        'ButtonSelectFolder
        '
        Me.ButtonSelectFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSelectFolder.Font = New System.Drawing.Font("Calibri", 20.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSelectFolder.Location = New System.Drawing.Point(1434, 34)
        Me.ButtonSelectFolder.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonSelectFolder.Name = "ButtonSelectFolder"
        Me.ButtonSelectFolder.Size = New System.Drawing.Size(115, 74)
        Me.ButtonSelectFolder.TabIndex = 5
        Me.ButtonSelectFolder.Text = "..."
        Me.ButtonSelectFolder.UseVisualStyleBackColor = True
        '
        'TextBoxSelectFolder
        '
        Me.TextBoxSelectFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSelectFolder.Font = New System.Drawing.Font("Calibri", 20.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSelectFolder.Location = New System.Drawing.Point(335, 35)
        Me.TextBoxSelectFolder.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxSelectFolder.Name = "TextBoxSelectFolder"
        Me.TextBoxSelectFolder.Size = New System.Drawing.Size(1081, 73)
        Me.TextBoxSelectFolder.TabIndex = 4
        '
        'LabelSelectFolder
        '
        Me.LabelSelectFolder.Font = New System.Drawing.Font("Calibri", 20.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSelectFolder.ForeColor = System.Drawing.Color.Gray
        Me.LabelSelectFolder.Location = New System.Drawing.Point(9, 29)
        Me.LabelSelectFolder.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelSelectFolder.Name = "LabelSelectFolder"
        Me.LabelSelectFolder.Size = New System.Drawing.Size(314, 85)
        Me.LabelSelectFolder.TabIndex = 3
        Me.LabelSelectFolder.Text = "Select Folder"
        Me.LabelSelectFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelMain
        '
        Me.PanelMain.Controls.Add(Me.PanelLeft)
        Me.PanelMain.Controls.Add(Me.PanelRight)
        Me.PanelMain.Controls.Add(Me.PanelFileNames)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(0, 137)
        Me.PanelMain.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(1774, 992)
        Me.PanelMain.TabIndex = 4
        '
        'PanelLeft
        '
        Me.PanelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelLeft.Controls.Add(Me.PanelLeftTotal)
        Me.PanelLeft.Controls.Add(Me.DataGridViewFileNamesOriginal)
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLeft.Location = New System.Drawing.Point(0, 301)
        Me.PanelLeft.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Padding = New System.Windows.Forms.Padding(11, 12, 11, 81)
        Me.PanelLeft.Size = New System.Drawing.Size(1764, 691)
        Me.PanelLeft.TabIndex = 12
        '
        'PanelLeftTotal
        '
        Me.PanelLeftTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelLeftTotal.Controls.Add(Me.LabelTotalFilesOriginalCounter)
        Me.PanelLeftTotal.Controls.Add(Me.LabelTotalFilesOriginal)
        Me.PanelLeftTotal.Location = New System.Drawing.Point(8, 621)
        Me.PanelLeftTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelLeftTotal.Name = "PanelLeftTotal"
        Me.PanelLeftTotal.Size = New System.Drawing.Size(884, 56)
        Me.PanelLeftTotal.TabIndex = 1
        '
        'LabelTotalFilesOriginalCounter
        '
        Me.LabelTotalFilesOriginalCounter.Font = New System.Drawing.Font("Calibri", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalFilesOriginalCounter.ForeColor = System.Drawing.Color.Gray
        Me.LabelTotalFilesOriginalCounter.Location = New System.Drawing.Point(195, 10)
        Me.LabelTotalFilesOriginalCounter.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTotalFilesOriginalCounter.Name = "LabelTotalFilesOriginalCounter"
        Me.LabelTotalFilesOriginalCounter.Size = New System.Drawing.Size(70, 41)
        Me.LabelTotalFilesOriginalCounter.TabIndex = 11
        Me.LabelTotalFilesOriginalCounter.Text = "0"
        Me.LabelTotalFilesOriginalCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelTotalFilesOriginal
        '
        Me.LabelTotalFilesOriginal.Font = New System.Drawing.Font("Calibri", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalFilesOriginal.ForeColor = System.Drawing.Color.Gray
        Me.LabelTotalFilesOriginal.Location = New System.Drawing.Point(8, 10)
        Me.LabelTotalFilesOriginal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTotalFilesOriginal.Name = "LabelTotalFilesOriginal"
        Me.LabelTotalFilesOriginal.Size = New System.Drawing.Size(182, 41)
        Me.LabelTotalFilesOriginal.TabIndex = 10
        Me.LabelTotalFilesOriginal.Text = "Total Files:"
        Me.LabelTotalFilesOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridViewFileNamesOriginal
        '
        Me.DataGridViewFileNamesOriginal.AllowUserToAddRows = False
        Me.DataGridViewFileNamesOriginal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFileNamesOriginal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewFileNamesOriginal.Location = New System.Drawing.Point(11, 12)
        Me.DataGridViewFileNamesOriginal.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewFileNamesOriginal.Name = "DataGridViewFileNamesOriginal"
        Me.DataGridViewFileNamesOriginal.RowTemplate.Height = 40
        Me.DataGridViewFileNamesOriginal.Size = New System.Drawing.Size(1740, 596)
        Me.DataGridViewFileNamesOriginal.TabIndex = 0
        '
        'PanelRight
        '
        Me.PanelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelRight.Controls.Add(Me.PanelRightTotal)
        Me.PanelRight.Controls.Add(Me.DataGridViewFileNamesReplacement)
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelRight.Location = New System.Drawing.Point(1764, 301)
        Me.PanelRight.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Padding = New System.Windows.Forms.Padding(11, 12, 11, 81)
        Me.PanelRight.Size = New System.Drawing.Size(10, 691)
        Me.PanelRight.TabIndex = 11
        '
        'PanelRightTotal
        '
        Me.PanelRightTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelRightTotal.Controls.Add(Me.LabelTotalFilesReplacedCounter)
        Me.PanelRightTotal.Controls.Add(Me.LabelTotalFilesReplaced)
        Me.PanelRightTotal.Location = New System.Drawing.Point(20, 621)
        Me.PanelRightTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelRightTotal.Name = "PanelRightTotal"
        Me.PanelRightTotal.Size = New System.Drawing.Size(884, 56)
        Me.PanelRightTotal.TabIndex = 2
        '
        'LabelTotalFilesReplacedCounter
        '
        Me.LabelTotalFilesReplacedCounter.Font = New System.Drawing.Font("Calibri", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalFilesReplacedCounter.ForeColor = System.Drawing.Color.Gray
        Me.LabelTotalFilesReplacedCounter.Location = New System.Drawing.Point(195, 10)
        Me.LabelTotalFilesReplacedCounter.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTotalFilesReplacedCounter.Name = "LabelTotalFilesReplacedCounter"
        Me.LabelTotalFilesReplacedCounter.Size = New System.Drawing.Size(70, 41)
        Me.LabelTotalFilesReplacedCounter.TabIndex = 11
        Me.LabelTotalFilesReplacedCounter.Text = "0"
        Me.LabelTotalFilesReplacedCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelTotalFilesReplaced
        '
        Me.LabelTotalFilesReplaced.Font = New System.Drawing.Font("Calibri", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalFilesReplaced.ForeColor = System.Drawing.Color.Gray
        Me.LabelTotalFilesReplaced.Location = New System.Drawing.Point(8, 10)
        Me.LabelTotalFilesReplaced.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTotalFilesReplaced.Name = "LabelTotalFilesReplaced"
        Me.LabelTotalFilesReplaced.Size = New System.Drawing.Size(182, 41)
        Me.LabelTotalFilesReplaced.TabIndex = 10
        Me.LabelTotalFilesReplaced.Text = "Total Files:"
        Me.LabelTotalFilesReplaced.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridViewFileNamesReplacement
        '
        Me.DataGridViewFileNamesReplacement.AllowUserToAddRows = False
        Me.DataGridViewFileNamesReplacement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFileNamesReplacement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewFileNamesReplacement.Location = New System.Drawing.Point(11, 12)
        Me.DataGridViewFileNamesReplacement.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewFileNamesReplacement.Name = "DataGridViewFileNamesReplacement"
        Me.DataGridViewFileNamesReplacement.RowTemplate.Height = 40
        Me.DataGridViewFileNamesReplacement.Size = New System.Drawing.Size(0, 596)
        Me.DataGridViewFileNamesReplacement.TabIndex = 1
        '
        'PanelFileNames
        '
        Me.PanelFileNames.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PanelFileNames.Controls.Add(Me.TextBoxExtension)
        Me.PanelFileNames.Controls.Add(Me.RadioButtonDocuments)
        Me.PanelFileNames.Controls.Add(Me.RadioButtonVideos)
        Me.PanelFileNames.Controls.Add(Me.RadioButtonAudio)
        Me.PanelFileNames.Controls.Add(Me.RadioButtonPhotos)
        Me.PanelFileNames.Controls.Add(Me.PanelSearch)
        Me.PanelFileNames.Controls.Add(Me.ButtonReplaceFileNames)
        Me.PanelFileNames.Controls.Add(Me.TextBoxFileNameReplacement)
        Me.PanelFileNames.Controls.Add(Me.LabelFileReplaceName)
        Me.PanelFileNames.Controls.Add(Me.TextBoxFileNameOriginal)
        Me.PanelFileNames.Controls.Add(Me.LabelFileName)
        Me.PanelFileNames.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFileNames.Location = New System.Drawing.Point(0, 0)
        Me.PanelFileNames.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelFileNames.Name = "PanelFileNames"
        Me.PanelFileNames.Size = New System.Drawing.Size(1774, 301)
        Me.PanelFileNames.TabIndex = 9
        '
        'TextBoxExtension
        '
        Me.TextBoxExtension.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxExtension.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxExtension.Location = New System.Drawing.Point(1545, 235)
        Me.TextBoxExtension.Name = "TextBoxExtension"
        Me.TextBoxExtension.Size = New System.Drawing.Size(179, 44)
        Me.TextBoxExtension.TabIndex = 19
        '
        'RadioButtonDocuments
        '
        Me.RadioButtonDocuments.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButtonDocuments.AutoSize = True
        Me.RadioButtonDocuments.Font = New System.Drawing.Font("Calibri", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonDocuments.Location = New System.Drawing.Point(1545, 168)
        Me.RadioButtonDocuments.Name = "RadioButtonDocuments"
        Me.RadioButtonDocuments.Size = New System.Drawing.Size(179, 40)
        Me.RadioButtonDocuments.TabIndex = 18
        Me.RadioButtonDocuments.Text = "Documents"
        Me.RadioButtonDocuments.UseVisualStyleBackColor = True
        '
        'RadioButtonVideos
        '
        Me.RadioButtonVideos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButtonVideos.AutoSize = True
        Me.RadioButtonVideos.Font = New System.Drawing.Font("Calibri", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonVideos.Location = New System.Drawing.Point(1545, 121)
        Me.RadioButtonVideos.Name = "RadioButtonVideos"
        Me.RadioButtonVideos.Size = New System.Drawing.Size(113, 40)
        Me.RadioButtonVideos.TabIndex = 17
        Me.RadioButtonVideos.Text = "Video"
        Me.RadioButtonVideos.UseVisualStyleBackColor = True
        '
        'RadioButtonAudio
        '
        Me.RadioButtonAudio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButtonAudio.AutoSize = True
        Me.RadioButtonAudio.Font = New System.Drawing.Font("Calibri", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonAudio.Location = New System.Drawing.Point(1545, 74)
        Me.RadioButtonAudio.Name = "RadioButtonAudio"
        Me.RadioButtonAudio.Size = New System.Drawing.Size(115, 40)
        Me.RadioButtonAudio.TabIndex = 16
        Me.RadioButtonAudio.Text = "Audio"
        Me.RadioButtonAudio.UseVisualStyleBackColor = True
        '
        'RadioButtonPhotos
        '
        Me.RadioButtonPhotos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButtonPhotos.AutoSize = True
        Me.RadioButtonPhotos.Font = New System.Drawing.Font("Calibri", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonPhotos.Location = New System.Drawing.Point(1545, 27)
        Me.RadioButtonPhotos.Name = "RadioButtonPhotos"
        Me.RadioButtonPhotos.Size = New System.Drawing.Size(127, 40)
        Me.RadioButtonPhotos.TabIndex = 15
        Me.RadioButtonPhotos.Text = "Photos"
        Me.RadioButtonPhotos.UseVisualStyleBackColor = True
        '
        'PanelSearch
        '
        Me.PanelSearch.BackColor = System.Drawing.Color.White
        Me.PanelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelSearch.Controls.Add(Me.ButtonReset)
        Me.PanelSearch.Controls.Add(Me.ButtonSearch)
        Me.PanelSearch.Controls.Add(Me.TextBoxSearch)
        Me.PanelSearch.Controls.Add(Me.LabelSearch)
        Me.PanelSearch.Location = New System.Drawing.Point(9, 25)
        Me.PanelSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Size = New System.Drawing.Size(1474, 112)
        Me.PanelSearch.TabIndex = 14
        '
        'ButtonReset
        '
        Me.ButtonReset.Font = New System.Drawing.Font("Calibri", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReset.Location = New System.Drawing.Point(1320, 14)
        Me.ButtonReset.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(142, 74)
        Me.ButtonReset.TabIndex = 10
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Font = New System.Drawing.Font("Calibri", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearch.Location = New System.Drawing.Point(1132, 14)
        Me.ButtonSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(180, 74)
        Me.ButtonSearch.TabIndex = 9
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Font = New System.Drawing.Font("Calibri", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(320, 22)
        Me.TextBoxSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(787, 59)
        Me.TextBoxSearch.TabIndex = 8
        '
        'LabelSearch
        '
        Me.LabelSearch.Font = New System.Drawing.Font("Calibri", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSearch.ForeColor = System.Drawing.Color.Gray
        Me.LabelSearch.Location = New System.Drawing.Point(4, 24)
        Me.LabelSearch.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelSearch.Name = "LabelSearch"
        Me.LabelSearch.Size = New System.Drawing.Size(314, 54)
        Me.LabelSearch.TabIndex = 7
        Me.LabelSearch.Text = "Search Files"
        Me.LabelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonReplaceFileNames
        '
        Me.ButtonReplaceFileNames.AutoSize = True
        Me.ButtonReplaceFileNames.BackColor = System.Drawing.Color.LightGray
        Me.ButtonReplaceFileNames.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonReplaceFileNames.Font = New System.Drawing.Font("Calibri", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReplaceFileNames.Location = New System.Drawing.Point(1142, 149)
        Me.ButtonReplaceFileNames.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonReplaceFileNames.Name = "ButtonReplaceFileNames"
        Me.ButtonReplaceFileNames.Size = New System.Drawing.Size(330, 130)
        Me.ButtonReplaceFileNames.TabIndex = 13
        Me.ButtonReplaceFileNames.Text = "Replace File Names"
        Me.ButtonReplaceFileNames.UseVisualStyleBackColor = False
        '
        'TextBoxFileNameReplacement
        '
        Me.TextBoxFileNameReplacement.Font = New System.Drawing.Font("Calibri", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFileNameReplacement.Location = New System.Drawing.Point(328, 220)
        Me.TextBoxFileNameReplacement.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxFileNameReplacement.Name = "TextBoxFileNameReplacement"
        Me.TextBoxFileNameReplacement.Size = New System.Drawing.Size(792, 59)
        Me.TextBoxFileNameReplacement.TabIndex = 12
        '
        'LabelFileReplaceName
        '
        Me.LabelFileReplaceName.Font = New System.Drawing.Font("Calibri", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFileReplaceName.ForeColor = System.Drawing.Color.Gray
        Me.LabelFileReplaceName.Location = New System.Drawing.Point(4, 207)
        Me.LabelFileReplaceName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelFileReplaceName.Name = "LabelFileReplaceName"
        Me.LabelFileReplaceName.Size = New System.Drawing.Size(314, 85)
        Me.LabelFileReplaceName.TabIndex = 11
        Me.LabelFileReplaceName.Text = "Replace With"
        Me.LabelFileReplaceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxFileNameOriginal
        '
        Me.TextBoxFileNameOriginal.Font = New System.Drawing.Font("Calibri", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFileNameOriginal.Location = New System.Drawing.Point(328, 149)
        Me.TextBoxFileNameOriginal.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxFileNameOriginal.Name = "TextBoxFileNameOriginal"
        Me.TextBoxFileNameOriginal.Size = New System.Drawing.Size(788, 59)
        Me.TextBoxFileNameOriginal.TabIndex = 10
        '
        'LabelFileName
        '
        Me.LabelFileName.Font = New System.Drawing.Font("Calibri", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFileName.ForeColor = System.Drawing.Color.Gray
        Me.LabelFileName.Location = New System.Drawing.Point(4, 136)
        Me.LabelFileName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelFileName.Name = "LabelFileName"
        Me.LabelFileName.Size = New System.Drawing.Size(314, 85)
        Me.LabelFileName.TabIndex = 9
        Me.LabelFileName.Text = "File Name"
        Me.LabelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1774, 1129)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FileX"
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.PanelMain.ResumeLayout(False)
        Me.PanelLeft.ResumeLayout(False)
        Me.PanelLeftTotal.ResumeLayout(False)
        CType(Me.DataGridViewFileNamesOriginal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRight.ResumeLayout(False)
        Me.PanelRightTotal.ResumeLayout(False)
        CType(Me.DataGridViewFileNamesReplacement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFileNames.ResumeLayout(False)
        Me.PanelFileNames.PerformLayout()
        Me.PanelSearch.ResumeLayout(False)
        Me.PanelSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents ButtonSelectFolder As Button
    Friend WithEvents TextBoxSelectFolder As TextBox
    Friend WithEvents LabelSelectFolder As Label
    Friend WithEvents PanelMain As Panel
    Friend WithEvents PanelRight As Panel
    Friend WithEvents PanelFileNames As Panel
    Friend WithEvents TextBoxFileNameReplacement As TextBox
    Friend WithEvents LabelFileReplaceName As Label
    Friend WithEvents TextBoxFileNameOriginal As TextBox
    Friend WithEvents LabelFileName As Label
    Friend WithEvents FolderBrowserDialogFileNames As FolderBrowserDialog
    Friend WithEvents DataGridViewFileNamesReplacement As DataGridView
    Friend WithEvents ButtonFileLoad As Button
    Friend WithEvents ButtonReplaceFileNames As Button
    Friend WithEvents PanelSearch As Panel
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents LabelSearch As Label
    Friend WithEvents ButtonReset As Button
    Friend WithEvents PanelRightTotal As Panel
    Friend WithEvents LabelTotalFilesReplacedCounter As Label
    Friend WithEvents LabelTotalFilesReplaced As Label
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents PanelLeftTotal As Panel
    Friend WithEvents LabelTotalFilesOriginalCounter As Label
    Friend WithEvents LabelTotalFilesOriginal As Label
    Friend WithEvents DataGridViewFileNamesOriginal As DataGridView
    Friend WithEvents RadioButtonDocuments As RadioButton
    Friend WithEvents RadioButtonVideos As RadioButton
    Friend WithEvents RadioButtonAudio As RadioButton
    Friend WithEvents RadioButtonPhotos As RadioButton
    Friend WithEvents TextBoxExtension As TextBox
End Class
