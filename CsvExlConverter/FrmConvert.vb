Public Class FrmConvert
    Private Sub LblDrop_DragDrop(sender As Object, e As DragEventArgs) Handles LblDrop.DragDrop
        Dim FileName As String() = CType(e.Data.GetData(DataFormats.FileDrop, False), String())

        'ドラッグアンドドロップされるファイルは1つのため、配列の0番目を取得
        TxtFilePath.Text = FileName(0)
    End Sub

    Private Sub LblDrop_DragEnter(sender As Object, e As DragEventArgs) Handles LblDrop.DragEnter
        'ファイルがドロップエリアにドラッグされたときの処理
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            'ドラッグされたデータ形式を調べ、ファイルの時はコピーを行う
            e.Effect = DragDropEffects.Copy
        Else
            'ファイル以外は受付不可
            e.Effect = DragDropEffects.None
            MessageBox.Show("ファイルではありません！", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        If MessageBox.Show("プログラムを終了しますか？", "プログラム終了", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
            Me.Close()
            Me.Dispose()
        End If
    End Sub
    '************************************************************************
    'concrete5 cif xmlへの変換
    '************************************************************************
    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        Dim clsCode As New ClassCode
        Dim strPath As String = Trim(TxtFilePath.Text)

        Dim entityname As String = Trim(TxtEntityName.Text)

        If TxtEntityName.Text = Nothing Then
            MessageBox.Show("エンティティ(テーブル)名が入力されていません。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If TxtFilePath.Text = Nothing Then
            MessageBox.Show("読み込むファイルが指定されていません。", "ファイル選択エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Cursor.Current = Cursors.WaitCursor

        If clsCode.fConvert(strPath, entityname) = True Then
            MessageBox.Show("XMLファイルの作成が終了しました。")
        End If
        Cursor.Current = Cursors.Default
    End Sub
End Class
