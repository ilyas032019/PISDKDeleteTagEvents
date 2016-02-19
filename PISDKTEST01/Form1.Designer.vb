<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Connect2 = New System.Windows.Forms.Button()
        Me.TagSearchDialog = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Tag = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Descriptor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompressedValue = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.TagName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Value = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ConnectionManager = New System.Windows.Forms.Button()
        Me.Disconnect = New System.Windows.Forms.Button()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TagListClear = New System.Windows.Forms.Button()
        Me.ListClear = New System.Windows.Forms.Button()
        Me.DeleteValueTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PiServerPickList1 = New OSIsoft.PISDKControls.PIServerPickList()
        Me.SuspendLayout()
        '
        'Connect2
        '
        Me.Connect2.Location = New System.Drawing.Point(144, 5)
        Me.Connect2.Name = "Connect2"
        Me.Connect2.Size = New System.Drawing.Size(75, 21)
        Me.Connect2.TabIndex = 0
        Me.Connect2.Text = "Connect"
        Me.Connect2.UseVisualStyleBackColor = True
        '
        'TagSearchDialog
        '
        Me.TagSearchDialog.Location = New System.Drawing.Point(6, 62)
        Me.TagSearchDialog.Name = "TagSearchDialog"
        Me.TagSearchDialog.Size = New System.Drawing.Size(215, 21)
        Me.TagSearchDialog.TabIndex = 2
        Me.TagSearchDialog.Text = "TagSearch Dialog"
        Me.TagSearchDialog.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Tag, Me.Descriptor})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(4, 87)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(433, 111)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Tag
        '
        Me.Tag.Text = "Tag"
        Me.Tag.Width = 170
        '
        'Descriptor
        '
        Me.Descriptor.Text = "Descriptor"
        Me.Descriptor.Width = 250
        '
        'CompressedValue
        '
        Me.CompressedValue.Location = New System.Drawing.Point(12, 280)
        Me.CompressedValue.Name = "CompressedValue"
        Me.CompressedValue.Size = New System.Drawing.Size(147, 21)
        Me.CompressedValue.TabIndex = 9
        Me.CompressedValue.Text = "Delete Values"
        Me.CompressedValue.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(191, 285)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 19)
        Me.TextBox3.TabIndex = 10
        Me.TextBox3.Text = "*-2h"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(297, 285)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 19)
        Me.TextBox4.TabIndex = 11
        Me.TextBox4.Text = "*"
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.TagName, Me.Time, Me.Value})
        Me.ListView2.Location = New System.Drawing.Point(4, 307)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(433, 142)
        Me.ListView2.TabIndex = 12
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'TagName
        '
        Me.TagName.Text = "TagName"
        Me.TagName.Width = 131
        '
        'Time
        '
        Me.Time.Text = "Time"
        Me.Time.Width = 162
        '
        'Value
        '
        Me.Value.Text = "Value"
        Me.Value.Width = 78
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(190, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 12)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Start time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(307, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 12)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "End time"
        '
        'ConnectionManager
        '
        Me.ConnectionManager.Location = New System.Drawing.Point(251, 17)
        Me.ConnectionManager.Name = "ConnectionManager"
        Me.ConnectionManager.Size = New System.Drawing.Size(153, 21)
        Me.ConnectionManager.TabIndex = 31
        Me.ConnectionManager.Text = "Connection Manager"
        Me.ConnectionManager.UseVisualStyleBackColor = True
        '
        'Disconnect
        '
        Me.Disconnect.Location = New System.Drawing.Point(144, 28)
        Me.Disconnect.Name = "Disconnect"
        Me.Disconnect.Size = New System.Drawing.Size(75, 21)
        Me.Disconnect.TabIndex = 32
        Me.Disconnect.Text = "Disconnect"
        Me.Disconnect.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 12)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Select multiple tags"
        '
        'TagListClear
        '
        Me.TagListClear.Location = New System.Drawing.Point(251, 60)
        Me.TagListClear.Name = "TagListClear"
        Me.TagListClear.Size = New System.Drawing.Size(114, 21)
        Me.TagListClear.TabIndex = 34
        Me.TagListClear.Text = "Tag List Clear"
        Me.TagListClear.UseVisualStyleBackColor = True
        '
        'ListClear
        '
        Me.ListClear.Location = New System.Drawing.Point(362, 453)
        Me.ListClear.Name = "ListClear"
        Me.ListClear.Size = New System.Drawing.Size(75, 21)
        Me.ListClear.TabIndex = 35
        Me.ListClear.Text = "List Clear"
        Me.ListClear.UseVisualStyleBackColor = True
        '
        'DeleteValueTextBox
        '
        Me.DeleteValueTextBox.Location = New System.Drawing.Point(12, 227)
        Me.DeleteValueTextBox.Name = "DeleteValueTextBox"
        Me.DeleteValueTextBox.Size = New System.Drawing.Size(132, 19)
        Me.DeleteValueTextBox.TabIndex = 36
        Me.DeleteValueTextBox.Text = "Shutdown"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 12)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Delete following value"
        '
        'PiServerPickList1
        '
        Me.PiServerPickList1.BackColor = System.Drawing.SystemColors.Control
        Me.PiServerPickList1.Location = New System.Drawing.Point(4, 17)
        Me.PiServerPickList1.Name = "PiServerPickList1"
        Me.PiServerPickList1.ReadOnly = True
        Me.PiServerPickList1.SelectedServerNames = New String(-1) {}
        Me.PiServerPickList1.Size = New System.Drawing.Size(134, 20)
        Me.PiServerPickList1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 477)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DeleteValueTextBox)
        Me.Controls.Add(Me.ListClear)
        Me.Controls.Add(Me.TagListClear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Disconnect)
        Me.Controls.Add(Me.ConnectionManager)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.CompressedValue)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TagSearchDialog)
        Me.Controls.Add(Me.PiServerPickList1)
        Me.Controls.Add(Me.Connect2)
        Me.Name = "Form1"
        Me.Text = "Delete Specific Events"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Connect2 As System.Windows.Forms.Button
    Friend WithEvents PiServerPickList1 As OSIsoft.PISDKControls.PIServerPickList
    Friend WithEvents TagSearchDialog As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Tag As System.Windows.Forms.ColumnHeader
    Friend WithEvents CompressedValue As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents TagName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Time As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ConnectionManager As System.Windows.Forms.Button
    Friend WithEvents Disconnect As System.Windows.Forms.Button
    Friend WithEvents DirectoryEntry1 As System.DirectoryServices.DirectoryEntry
    Friend WithEvents Descriptor As System.Windows.Forms.ColumnHeader
    Friend WithEvents Value As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TagListClear As System.Windows.Forms.Button
    Friend WithEvents ListClear As System.Windows.Forms.Button
    Friend WithEvents DeleteValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
