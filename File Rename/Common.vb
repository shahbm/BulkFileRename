Public Class Common

    Public Shared AudioFileExtensions As New List(Of String)(New String() {
        ".AIF", ".IFF", ".M3U", ".M4A", ".MID", ".MP3", ".MP4", ".MPA", ".WAV", ".WMA", ".WMV"})
    Public Shared VideoFileExtensions As New List(Of String)(New String() {
        ".3G2", ".3GP", ".ASF", ".AVI", ".FLV", ".M4V", ".MOV", ".MP4", ".MPG", ".RM", ".SRT", ".SWF", ".VOB", ".WMV"})
    Public Shared PhotoFileExtensions As New List(Of String)(New String() {
        ".BMP", ".DDS", ".GIF", ".JPG", ".PNG", ".PSD", ".PSPIMAGE", ".TGA", ".THM", ".TIF", ".TIFF", ".YUV"})
    Public Shared DocumentFileExtensions As New List(Of String)(New String() {
        ".DOC", ".DOCX", ".LOG", ".MSG", ".ODT", ".PAGES", ".RTF", ".TEX", ".TXT", ".WPD", ".WPS", ".CSV", ".DAT", ".GED", ".KEY", ".KEYCHAIN",
        ".PPS", ".PPT", ".PPTX", ".SDF", ".TAR", ".TAX2016", ".TAX2017", ".VCF", ".XML"})

    Public Enum FileTypeFilter
        Audio
        Video
        Photos
        Documents
        Other
        None
    End Enum

End Class
