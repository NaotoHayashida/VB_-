Public Class Main_Form
    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FolderName.Text = "写真の入ったフォルダーをここにドロップする。"
    End Sub





    Private Sub Main_Form_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        'ドロップされてきたファイルやフォルダー（複数可）に対する扱いを規定する関数。
        '今回はフォルダーのみドロップ出来るように、フォルダー以外はドロップエフェクトを禁止する。
        'ドロップフォルダーのパスをstring配列で受け取る
        Dim strDropPath As String() = CType(e.Data.GetData(DataFormats.FileDrop, False), String())

        '複数ドロップの全てがフォルダーか判別
        Dim isAllFoleder As Boolean = True

        For i As Integer = 0 To (strDropPath.Count - 1)
            If IO.Directory.Exists(strDropPath(i).ToString) = False Then
                isAllFoleder = False
                Exit For
            End If
        Next

        '複数ドロップの全てがフォルダーである場合はドロップ受け入れ
        If isAllFoleder = True Then
            e.Effect = DragDropEffects.All
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub Main_Form_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        'ファルダ毎にオブジェクトを取り出して、処理に回す
        'Dim folder As Object

    End Sub
End Class
