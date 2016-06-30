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
        'Dim selectedFiles = From files In allFiles Where files Like "*.JPG" Or files Like "*.MOV"





        'ファイル名変換候補を作成


        'ListViewに表示
        For Each f In selectedFiles

            Dim fname = IO.Path.GetFileName(f)  'ファイル名を取得
            Dim fmakeday = IO.File.GetCreationTime(f)   '作成日時を取得

            'JPGファイルの場合は撮影日時（DateTimeOriginal）を取得
            Dim str_fShootTime As String = ""
            If (IO.Path.GetExtension(f) = ".JPG") Then

                Dim fShootTime = getDateCreateOriginal(f)
                str_fShootTime = fShootTime.ToString

            End If

            Dim farray As String() = {fname, fmakeday.ToString, str_fShootTime}


            ListView1.Items.Add(New ListViewItem(farray))

        Next



        '対象ファイルの作成日時を修正確認する
        'modifyCreateDay(files)



    End Sub

    'JPGファイルのPathを受け取り、詳細プロパティの撮影日時（DateCreateOriginal）DateTime型を返す関数
    Private Function getDateCreateOriginal(ByVal filePath As String)

        Dim bmp = New System.Drawing.Bitmap(filePath)
        Dim byte_fshootday = bmp.GetPropertyItem(&H9003).Value   '&Hは１６進数の事。Key0x9003はDateTimeOriginal（撮影日時）Excelデータ参照。
        Dim str_fShootDay = System.Text.Encoding.ASCII.GetString(byte_fshootday)    'valueはバイト配列のアスキー文字なので通常の文字列にデコード

        str_fShootDay = str_fShootDay.Trim(New Char() {ControlChars.NullChar})  ' 文末についている空白文字を削除   "2015:12:23 21:38:02" & vbNullChar
        Dim date_fShootTime As DateTime = DateTime.ParseExact(str_fShootDay, "yyyy:MM:dd HH:mm:ss", Nothing)    'Stringの時間をDateTime型に変換

        bmp.Dispose()
        Return date_fShootTime
    End Function



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

    Private Sub Btn_Next_Click(sender As Object, e As EventArgs) Handles Btn_Next.Click

        Nextable = True
    End Sub


    Private Sub Btn_Initialize_Click(sender As Object, e As EventArgs) Handles Btn_Initialize.Click
        '終了ボタンを押下時は初期化処理
        Call Initialize()

    End Sub
End Class
