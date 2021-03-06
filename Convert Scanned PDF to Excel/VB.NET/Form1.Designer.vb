Partial Class Form1
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pdfViewerControl1 = New Bytescout.PDFViewer.PDFViewerControl()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbOpen = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbExportToCSV = New System.Windows.Forms.ToolStripButton()
        Me.tsbExportToXLSX = New System.Windows.Forms.ToolStripButton()
        Me.toolStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'pdfViewerControl1
        '
        Me.pdfViewerControl1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.pdfViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pdfViewerControl1.Location = New System.Drawing.Point(0, 25)
        Me.pdfViewerControl1.MouseMode = Bytescout.PDFViewer.MouseMode.Selection
        Me.pdfViewerControl1.Name = "pdfViewerControl1"
        Me.pdfViewerControl1.RegistrationKey = Nothing
        Me.pdfViewerControl1.RegistrationName = Nothing
        Me.pdfViewerControl1.ResetRotationOnPageChange = false
        Me.pdfViewerControl1.Scale = 100
        Me.pdfViewerControl1.SelectionColor = System.Drawing.Color.Red
        Me.pdfViewerControl1.ShowImageObjects = true
        Me.pdfViewerControl1.ShowTextObjects = true
        Me.pdfViewerControl1.ShowVectorObjects = true
        Me.pdfViewerControl1.Size = New System.Drawing.Size(842, 514)
        Me.pdfViewerControl1.TabIndex = 0
        '
        'toolStrip1
        '
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbOpen, Me.ToolStripSeparator1, Me.tsbExportToCSV, Me.tsbExportToXLSX})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(842, 25)
        Me.toolStrip1.TabIndex = 1
        Me.toolStrip1.Text = "toolStrip1"
        '
        'tsbOpen
        '
        Me.tsbOpen.Image = Global.Sample_UI_Application.My.Resources.Resources.folder_page
        Me.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOpen.Name = "tsbOpen"
        Me.tsbOpen.Size = New System.Drawing.Size(80, 22)
        Me.tsbOpen.Text = "&Open PDF"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbExportToCSV
        '
        Me.tsbExportToCSV.Image = CType(resources.GetObject("tsbExportToCSV.Image"),System.Drawing.Image)
        Me.tsbExportToCSV.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportToCSV.Name = "tsbExportToCSV"
        Me.tsbExportToCSV.Size = New System.Drawing.Size(100, 22)
        Me.tsbExportToCSV.Text = "Export To CSV"
        '
        'tsbExportToXLSX
        '
        Me.tsbExportToXLSX.Image = CType(resources.GetObject("tsbExportToXLSX.Image"),System.Drawing.Image)
        Me.tsbExportToXLSX.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportToXLSX.Name = "tsbExportToXLSX"
        Me.tsbExportToXLSX.Size = New System.Drawing.Size(105, 22)
        Me.tsbExportToXLSX.Text = "Export To XLSX"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 539)
        Me.Controls.Add(Me.pdfViewerControl1)
        Me.Controls.Add(Me.toolStrip1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.toolStrip1.ResumeLayout(false)
        Me.toolStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

	#End Region

	Private pdfViewerControl1 As Bytescout.PDFViewer.PDFViewerControl
	Private toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents tsbOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbExportToCSV As Windows.Forms.ToolStripButton
    Friend WithEvents tsbExportToXLSX As Windows.Forms.ToolStripButton
End Class

