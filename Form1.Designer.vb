<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Form
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Me.Btn_Initialize = New System.Windows.Forms.Button()
        Me.FolderNameHead = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_SetRenban = New System.Windows.Forms.Button()
        Me.Btn_Next = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_FolderName = New System.Windows.Forms.Label()
        Me.lbl_filenum_pre = New System.Windows.Forms.Label()
        Me.lbl_filenum_pro = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Initialize
        '
        Me.Btn_Initialize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Initialize.Location = New System.Drawing.Point(1058, 422)
        Me.Btn_Initialize.Name = "Btn_Initialize"
        Me.Btn_Initialize.Size = New System.Drawing.Size(117, 23)
        Me.Btn_Initialize.TabIndex = 0
        Me.Btn_Initialize.Text = "終了"
        Me.Btn_Initialize.UseVisualStyleBackColor = True
        Me.Btn_Initialize.Visible = False
        '
        'FolderNameHead
        '
        Me.FolderNameHead.AutoSize = True
        Me.FolderNameHead.Location = New System.Drawing.Point(13, 13)
        Me.FolderNameHead.Name = "FolderNameHead"
        Me.FolderNameHead.Size = New System.Drawing.Size(66, 12)
        Me.FolderNameHead.TabIndex = 2
        Me.FolderNameHead.Text = "フォルダ名　："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "変更前ファイル名"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(661, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(481, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "変更後ファイル名(下記は候補です。実際に変更するには「ファイル名変更処理」ボタンを押してください)"
        '
        'Btn_SetRenban
        '
        Me.Btn_SetRenban.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_SetRenban.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.Btn_SetRenban.Location = New System.Drawing.Point(744, 422)
        Me.Btn_SetRenban.Name = "Btn_SetRenban"
        Me.Btn_SetRenban.Size = New System.Drawing.Size(117, 23)
        Me.Btn_SetRenban.TabIndex = 5
        Me.Btn_SetRenban.Text = "ファイル名変更処理"
        Me.Btn_SetRenban.UseVisualStyleBackColor = True
        '
        'Btn_Next
        '
        Me.Btn_Next.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Next.Location = New System.Drawing.Point(901, 422)
        Me.Btn_Next.Name = "Btn_Next"
        Me.Btn_Next.Size = New System.Drawing.Size(117, 23)
        Me.Btn_Next.TabIndex = 6
        Me.Btn_Next.Text = "NEXT"
        Me.Btn_Next.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ListView1.Location = New System.Drawing.Point(15, 67)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(565, 349)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ファイル名"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "作成日時"
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "撮影日時"
        Me.ColumnHeader3.Width = 180
        '
        'ListView2
        '
        Me.ListView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView2.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(610, 67)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(565, 349)
        Me.ListView2.TabIndex = 8
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ファイル名"
        Me.ColumnHeader4.Width = 200
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "作成日時"
        Me.ColumnHeader5.Width = 180
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "撮影日時"
        Me.ColumnHeader6.Width = 180
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 12)
        Me.Label1.TabIndex = 9
        '
        'lbl_FolderName
        '
        Me.lbl_FolderName.AutoSize = True
        Me.lbl_FolderName.Location = New System.Drawing.Point(85, 13)
        Me.lbl_FolderName.Name = "lbl_FolderName"
        Me.lbl_FolderName.Size = New System.Drawing.Size(82, 12)
        Me.lbl_FolderName.TabIndex = 10
        Me.lbl_FolderName.Text = "lbl_FolderName"
        '
        'lbl_filenum_pre
        '
        Me.lbl_filenum_pre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_filenum_pre.AutoSize = True
        Me.lbl_filenum_pre.Location = New System.Drawing.Point(13, 427)
        Me.lbl_filenum_pre.Name = "lbl_filenum_pre"
        Me.lbl_filenum_pre.Size = New System.Drawing.Size(78, 12)
        Me.lbl_filenum_pre.TabIndex = 11
        Me.lbl_filenum_pre.Text = "lbl_filenum_pre"
        '
        'lbl_filenum_pro
        '
        Me.lbl_filenum_pro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_filenum_pro.AutoSize = True
        Me.lbl_filenum_pro.Location = New System.Drawing.Point(608, 427)
        Me.lbl_filenum_pro.Name = "lbl_filenum_pro"
        Me.lbl_filenum_pro.Size = New System.Drawing.Size(78, 12)
        Me.lbl_filenum_pro.TabIndex = 12
        Me.lbl_filenum_pro.Text = "lbl_filenum_pro"
        '
        'Main_Form
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 457)
        Me.Controls.Add(Me.lbl_filenum_pro)
        Me.Controls.Add(Me.lbl_filenum_pre)
        Me.Controls.Add(Me.lbl_FolderName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Btn_Next)
        Me.Controls.Add(Me.Btn_SetRenban)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FolderNameHead)
        Me.Controls.Add(Me.Btn_Initialize)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Name = "Main_Form"
        Me.Text = "写真ファイル名変更ソフト"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Initialize As Button
    Friend WithEvents FolderNameHead As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_SetRenban As Button
    Friend WithEvents Btn_Next As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_FolderName As Label
    Friend WithEvents lbl_filenum_pre As Label
    Friend WithEvents lbl_filenum_pro As Label
End Class
