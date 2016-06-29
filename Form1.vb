Public Class Main_Form
    '##################################
    '#宣言
    Friend Nextable As Boolean


    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Initialize()
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

        Dim strDropPath As String() = CType(e.Data.GetData(DataFormats.FileDrop, False), String())
        'ファルダを１つづつ取り出して、メイン処理に回す
        For Each folderPath As String In strDropPath

            '処理中のフォルダのフルパスをFolderNameに変更する。
            lbl_FolderName.Text = folderPath
            'メイン処理に移行
            MainChangeName(folderPath)
            ''Nextボタン押下まで(Nextable がtrueになるまで)待機
            'While (Nextable)

            'End While

        Next

    End Sub

    Private Sub Initialize()

        lbl_FolderName.Text = "ここに画像や動画の入ったフォルダーをドロップしてください。"
        'リストの項目をクリア
        ListView1.Items.Clear()
        ListView2.Items.Clear()

        'lbl_FolderNameのフォルダ名をクリア
        lbl_FolderName.Text = ""

        'ファイル数の表記をクリア
        lbl_filenum_pre.Text = "ファイル数　：　"
        lbl_filenum_pro.Text = "ファイル数　：　"

    End Sub


    Private Sub MainChangeName(ByVal folderPath As String)
        'ファイル名変更のメイン関数
        Dim preFilesList As List(Of String)     'フォルダ内の変換前ファイルを格納するリスト
        Dim proFilesList As List(Of String)     'フォルダ内の変換後ファイルを格納するリスト

        Dim fileName As String

        'フォルダ配下の対象ファイル（jpg、mov、mtsに限定して）をリストとして取得（完全パスとして）
        Dim allFiles = IO.Directory.EnumerateFiles(folderPath)          ' １、フォルダ以下の全ファイル取得
        Dim selectedFiles = From files In allFiles Where files Like "*.JPG" Or files Like "*.MOV" Or files Like "*.MTS" ' ２、Linqにて対象ファイルを絞り込み






        'ファイル名変換候補を作成


        'ListViewに表示
        For Each f In selectedFiles

            ListView1.Items.Add(New ListViewItem(f))

        Next



        '対象ファイルの作成日時を修正確認する
        'modifyCreateDay(files)



    End Sub

    Private Sub modifyCreateDay(files As String())

        For Each eachFile As String In files
            '拡張子で処理を分岐するため拡張子取得
            Dim extention As String = IO.Path.GetExtension(eachFile)

            '
            Select Case (extention)
                Case ".jpg" Or ".JPG"

                Case ".mts" Or ".MTS"

                Case ".mov" Or ".MOV"


            End Select

        Next


    End Sub
    ' ListViewコントロールのデータを更新します。

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Btn_Next_Click(sender As Object, e As EventArgs) Handles Btn_Next.Click

        Nextable = True
    End Sub


    Private Sub Btn_Initialize_Click(sender As Object, e As EventArgs) Handles Btn_Initialize.Click
        '終了ボタンを押下時は初期化処理
        Call Initialize()

    End Sub
End Class
