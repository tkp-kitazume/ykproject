Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Windows.Forms

Public Class ClassCode
    Public Const stringHedder As String = "<?xml version=""1.0"" encoding=""UTF-8""?><concrete5-cif version=""1.0""><expressentries>"
    Public Const stringFooter As String = "</expressentries></concrete5-cif>"

    '************************************************************************
    'concrete5 cif xmlへの変換
    'Excelファイルを読込、cif形式のXMLファイル形式へ変換
    '************************************************************************
    Public Function fConvert(strPath As String, entityname As String) As Boolean
        '初期値を設定
        fConvert = False
        Dim ExApp As New Excel.Application
        Dim Ebs As Excel.Workbooks = Nothing
        Dim Eb As Excel.Workbook = Nothing
        Dim Ess As Excel.Sheets = Nothing
        Dim Es As Excel.Worksheet = Nothing
        Dim clmCnt As Integer = 1
        Dim rwCnt As Integer = 2
        Dim saveXmlFilePath As String = ""
        saveXmlFilePath = My.Application.Info.DirectoryPath.ToString()

        Ebs = ExApp.Workbooks
        Eb = Ebs.Open(strPath)
        Ess = Eb.Worksheets
        Es = Ess(1)

        'Excelシートの2行目から最終行までを登録
        '1行目はフィールド名であること
        With Es
            'ColumnとRowのカウント
            Do Until .Cells(1, clmCnt).Value = Nothing
                clmCnt += 1
            Loop
            Do Until .Cells(rwCnt, 1).Value = Nothing
                rwCnt += 1
            Loop

            Dim atb(rwCnt - 1) As String '配列の初期化
            '*********************************************************
            'XMLファイルを新規作成・保存
            '*********************************************************
            Dim sw As New StreamWriter(saveXmlFilePath & Date.Now.ToString("yyyyMMdd") & entityname & ".xml", True)
            sw.Write(stringHedder)

            For i = 2 To rwCnt - 1
                Dim strxmlcode As String = "" 'XMLコードの初期化
                strxmlcode &= "<entry id="""""
                strxmlcode &= " label ="
                strxmlcode &= """" & .Cells(i, 1).Value & """"
                strxmlcode &= " entity="
                strxmlcode &= """" & entityname & """"
                strxmlcode &= " display-order=""0""><attributes>"
                For j = 1 To clmCnt - 1
                    strxmlcode &= "<attributekey handle="
                    strxmlcode &= """" & .Cells(1, j).Value & """" & ">"
                    strxmlcode &= "<value><![CDATA[" & .Cells(i, j).Value & "]]></value></attributekey>"
                Next
                strxmlcode &= "</attributes></entry>"
                atb(i) = strxmlcode
                sw.Write(atb(i))
            Next
            sw.Write(stringFooter)
            sw.Close()

        End With

        'プロセスの解放
        Call MRComObject(Es)
        Call MRComObject(Ess)
        Eb.Close()
        Call MRComObject(Eb)
        Call MRComObject(Ebs)

        ExApp.Quit()
        Call MRComObject(ExApp)

        'プロセスチェック
        Call ProcessCheck()
        Return True
    End Function

    Public Sub MRComObject(Of T As Class)(ByRef objCom As T, Optional ByVal force As Boolean = False)
        Dim IDEEnvironment As Boolean = False
        Try
            If System.Runtime.InteropServices.Marshal.IsComObject(objCom) Then
                Dim count As Integer
                If force Then
                    count = System.Runtime.InteropServices.Marshal.FinalReleaseComObject(objCom)
                Else
                    count = System.Runtime.InteropServices.Marshal.ReleaseComObject(objCom)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            objCom = Nothing
        End Try
    End Sub

    Public Sub ProcessCheck()
        'タスクマネージャにExcel.exeの残留がないかチェック
        Dim st As Integer = System.Environment.TickCount

        System.Threading.Thread.Sleep(500)

        If Process.GetProcessesByName("Excel").Length >= 1 Then
            Dim localByName As Process() = Process.GetProcessesByName("Excel")
            Dim p As Process

            For Each p In localByName
                If System.String.Compare(p.MainWindowTitle, "", True) = 0 Then
                    p.Kill()
                End If
            Next
        End If
    End Sub

End Class
