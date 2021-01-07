<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConvert
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConvert))
        Me.LblDrop = New System.Windows.Forms.Label()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.TxtFilePath = New System.Windows.Forms.TextBox()
        Me.LblEntityName = New System.Windows.Forms.Label()
        Me.TxtEntityName = New System.Windows.Forms.TextBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblDrop
        '
        Me.LblDrop.AllowDrop = True
        Me.LblDrop.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblDrop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDrop.Image = CType(resources.GetObject("LblDrop.Image"), System.Drawing.Image)
        Me.LblDrop.Location = New System.Drawing.Point(16, 33)
        Me.LblDrop.Name = "LblDrop"
        Me.LblDrop.Size = New System.Drawing.Size(295, 251)
        Me.LblDrop.TabIndex = 0
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(330, 36)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(188, 46)
        Me.BtnConvert.TabIndex = 1
        Me.BtnConvert.Text = "XMLコンバート開始"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'BtnQuit
        '
        Me.BtnQuit.ForeColor = System.Drawing.Color.Red
        Me.BtnQuit.Image = CType(resources.GetObject("BtnQuit.Image"), System.Drawing.Image)
        Me.BtnQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnQuit.Location = New System.Drawing.Point(330, 238)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(188, 46)
        Me.BtnQuit.TabIndex = 2
        Me.BtnQuit.Text = "終　了"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'TxtFilePath
        '
        Me.TxtFilePath.Location = New System.Drawing.Point(15, 292)
        Me.TxtFilePath.Name = "TxtFilePath"
        Me.TxtFilePath.Size = New System.Drawing.Size(502, 19)
        Me.TxtFilePath.TabIndex = 3
        '
        'LblEntityName
        '
        Me.LblEntityName.AutoSize = True
        Me.LblEntityName.Location = New System.Drawing.Point(332, 97)
        Me.LblEntityName.Name = "LblEntityName"
        Me.LblEntityName.Size = New System.Drawing.Size(67, 12)
        Me.LblEntityName.TabIndex = 4
        Me.LblEntityName.Text = "エンティティ名"
        '
        'TxtEntityName
        '
        Me.TxtEntityName.Location = New System.Drawing.Point(334, 119)
        Me.TxtEntityName.Name = "TxtEntityName"
        Me.TxtEntityName.Size = New System.Drawing.Size(183, 19)
        Me.TxtEntityName.TabIndex = 5
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblTitle.Location = New System.Drawing.Point(22, 9)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(273, 16)
        Me.LblTitle.TabIndex = 6
        Me.LblTitle.Text = "concrete5 Express用 XMLコンバータ"
        '
        'FrmConvert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 317)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.TxtEntityName)
        Me.Controls.Add(Me.LblEntityName)
        Me.Controls.Add(Me.TxtFilePath)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.LblDrop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmConvert"
        Me.Text = "Excel←→Xmlコンバータ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblDrop As Label
    Friend WithEvents BtnConvert As Button
    Friend WithEvents BtnQuit As Button
    Friend WithEvents TxtFilePath As TextBox
    Friend WithEvents LblEntityName As Label
    Friend WithEvents TxtEntityName As TextBox
    Friend WithEvents LblTitle As Label
End Class
