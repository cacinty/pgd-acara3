<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlLegend = New System.Windows.Forms.Panel()
        Me.legend1 = New DotSpatial.Controls.Legend()
        Me.pnlMap = New System.Windows.Forms.Panel()
        Me.map1 = New DotSpatial.Controls.Map()
        Me.pnlAttribute = New System.Windows.Forms.Panel()
        Me.dgvAttributeTable = New System.Windows.Forms.DataGridView()
        Me.pnlOperations = New System.Windows.Forms.Panel()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.loadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.clearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.shapefileOperationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pointToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.createPointShapefileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.savePointShapefileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.polylineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.createPolylineShapefileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.savePolylineShapefileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.polygonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.createPolygonShapefileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.savePolygonShapefileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mapOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.defaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.informationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.measurementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.zoomInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.zoomOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.zoomToExtendToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.printMapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.attributeTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewAttributeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.addAColumnInTheAttributeTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.deleteAColumnInTheAttributeTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.updateAttributeTableInShapefileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exportAttributeTableToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlLegend.SuspendLayout()
        Me.pnlMap.SuspendLayout()
        Me.pnlAttribute.SuspendLayout()
        CType(Me.dgvAttributeTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOperations.SuspendLayout()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLegend
        '
        Me.pnlLegend.Controls.Add(Me.legend1)
        Me.pnlLegend.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLegend.Location = New System.Drawing.Point(0, 36)
        Me.pnlLegend.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlLegend.Name = "pnlLegend"
        Me.pnlLegend.Size = New System.Drawing.Size(178, 283)
        Me.pnlLegend.TabIndex = 3
        '
        'legend1
        '
        Me.legend1.BackColor = System.Drawing.Color.White
        Me.legend1.ControlRectangle = New System.Drawing.Rectangle(0, 0, 166, 283)
        Me.legend1.Dock = System.Windows.Forms.DockStyle.Left
        Me.legend1.DocumentRectangle = New System.Drawing.Rectangle(0, 0, 187, 428)
        Me.legend1.HorizontalScrollEnabled = True
        Me.legend1.Indentation = 30
        Me.legend1.IsInitialized = False
        Me.legend1.Location = New System.Drawing.Point(0, 0)
        Me.legend1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.legend1.MinimumSize = New System.Drawing.Size(4, 4)
        Me.legend1.Name = "legend1"
        Me.legend1.ProgressHandler = Nothing
        Me.legend1.ResetOnResize = False
        Me.legend1.SelectionFontColor = System.Drawing.Color.Black
        Me.legend1.SelectionHighlight = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.legend1.Size = New System.Drawing.Size(166, 283)
        Me.legend1.TabIndex = 0
        Me.legend1.Text = "legend1"
        Me.legend1.VerticalScrollEnabled = True
        '
        'pnlMap
        '
        Me.pnlMap.Controls.Add(Me.map1)
        Me.pnlMap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMap.Location = New System.Drawing.Point(0, 36)
        Me.pnlMap.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlMap.Name = "pnlMap"
        Me.pnlMap.Size = New System.Drawing.Size(800, 283)
        Me.pnlMap.TabIndex = 4
        '
        'map1
        '
        Me.map1.AllowDrop = True
        Me.map1.BackColor = System.Drawing.Color.White
        Me.map1.CollectAfterDraw = False
        Me.map1.CollisionDetection = False
        Me.map1.Dock = System.Windows.Forms.DockStyle.Right
        Me.map1.ExtendBuffer = False
        Me.map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        Me.map1.IsBusy = False
        Me.map1.Legend = Me.legend1
        Me.map1.Location = New System.Drawing.Point(184, 0)
        Me.map1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.map1.Name = "map1"
        Me.map1.ProgressHandler = Nothing
        Me.map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt
        Me.map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt
        Me.map1.RedrawLayersWhileResizing = False
        Me.map1.SelectionEnabled = True
        Me.map1.Size = New System.Drawing.Size(616, 283)
        Me.map1.TabIndex = 0
        '
        'pnlAttribute
        '
        Me.pnlAttribute.Controls.Add(Me.dgvAttributeTable)
        Me.pnlAttribute.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlAttribute.Location = New System.Drawing.Point(0, 319)
        Me.pnlAttribute.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlAttribute.Name = "pnlAttribute"
        Me.pnlAttribute.Size = New System.Drawing.Size(800, 131)
        Me.pnlAttribute.TabIndex = 5
        '
        'dgvAttributeTable
        '
        Me.dgvAttributeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAttributeTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAttributeTable.Location = New System.Drawing.Point(0, 0)
        Me.dgvAttributeTable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvAttributeTable.Name = "dgvAttributeTable"
        Me.dgvAttributeTable.RowHeadersWidth = 62
        Me.dgvAttributeTable.RowTemplate.Height = 28
        Me.dgvAttributeTable.Size = New System.Drawing.Size(800, 131)
        Me.dgvAttributeTable.TabIndex = 0
        '
        'pnlOperations
        '
        Me.pnlOperations.Controls.Add(Me.menuStrip1)
        Me.pnlOperations.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlOperations.Location = New System.Drawing.Point(0, 0)
        Me.pnlOperations.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlOperations.Name = "pnlOperations"
        Me.pnlOperations.Size = New System.Drawing.Size(800, 36)
        Me.pnlOperations.TabIndex = 2
        '
        'menuStrip1
        '
        Me.menuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.shapefileOperationsToolStripMenuItem, Me.mapOptionsToolStripMenuItem, Me.attributeTableToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.menuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.menuStrip1.TabIndex = 0
        Me.menuStrip1.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.loadToolStripMenuItem, Me.clearToolStripMenuItem, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.fileToolStripMenuItem.Text = "File"
        '
        'loadToolStripMenuItem
        '
        Me.loadToolStripMenuItem.Name = "loadToolStripMenuItem"
        Me.loadToolStripMenuItem.Size = New System.Drawing.Size(126, 26)
        Me.loadToolStripMenuItem.Text = "Load"
        '
        'clearToolStripMenuItem
        '
        Me.clearToolStripMenuItem.Name = "clearToolStripMenuItem"
        Me.clearToolStripMenuItem.Size = New System.Drawing.Size(126, 26)
        Me.clearToolStripMenuItem.Text = "Clear"
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(126, 26)
        Me.exitToolStripMenuItem.Text = "Exit"
        '
        'shapefileOperationsToolStripMenuItem
        '
        Me.shapefileOperationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pointToolStripMenuItem, Me.polylineToolStripMenuItem, Me.polygonToolStripMenuItem})
        Me.shapefileOperationsToolStripMenuItem.Name = "shapefileOperationsToolStripMenuItem"
        Me.shapefileOperationsToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.shapefileOperationsToolStripMenuItem.Text = "Shapefile Operations"
        '
        'pointToolStripMenuItem
        '
        Me.pointToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.createPointShapefileToolStripMenuItem, Me.savePointShapefileToolStripMenuItem})
        Me.pointToolStripMenuItem.Name = "pointToolStripMenuItem"
        Me.pointToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.pointToolStripMenuItem.Text = "Point"
        '
        'createPointShapefileToolStripMenuItem
        '
        Me.createPointShapefileToolStripMenuItem.Name = "createPointShapefileToolStripMenuItem"
        Me.createPointShapefileToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.createPointShapefileToolStripMenuItem.Text = "Create Point Shapefile"
        '
        'savePointShapefileToolStripMenuItem
        '
        Me.savePointShapefileToolStripMenuItem.Name = "savePointShapefileToolStripMenuItem"
        Me.savePointShapefileToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.savePointShapefileToolStripMenuItem.Text = "Save Point Shapefile"
        '
        'polylineToolStripMenuItem
        '
        Me.polylineToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.createPolylineShapefileToolStripMenuItem, Me.savePolylineShapefileToolStripMenuItem})
        Me.polylineToolStripMenuItem.Name = "polylineToolStripMenuItem"
        Me.polylineToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.polylineToolStripMenuItem.Text = "Polyline"
        '
        'createPolylineShapefileToolStripMenuItem
        '
        Me.createPolylineShapefileToolStripMenuItem.Name = "createPolylineShapefileToolStripMenuItem"
        Me.createPolylineShapefileToolStripMenuItem.Size = New System.Drawing.Size(256, 26)
        Me.createPolylineShapefileToolStripMenuItem.Text = "Create Polyline Shapefile"
        '
        'savePolylineShapefileToolStripMenuItem
        '
        Me.savePolylineShapefileToolStripMenuItem.Name = "savePolylineShapefileToolStripMenuItem"
        Me.savePolylineShapefileToolStripMenuItem.Size = New System.Drawing.Size(256, 26)
        Me.savePolylineShapefileToolStripMenuItem.Text = "Save Polyline Shapefile"
        '
        'polygonToolStripMenuItem
        '
        Me.polygonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.createPolygonShapefileToolStripMenuItem, Me.savePolygonShapefileToolStripMenuItem})
        Me.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem"
        Me.polygonToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.polygonToolStripMenuItem.Text = "Polygon"
        '
        'createPolygonShapefileToolStripMenuItem
        '
        Me.createPolygonShapefileToolStripMenuItem.Name = "createPolygonShapefileToolStripMenuItem"
        Me.createPolygonShapefileToolStripMenuItem.Size = New System.Drawing.Size(258, 26)
        Me.createPolygonShapefileToolStripMenuItem.Text = "Create Polygon Shapefile"
        '
        'savePolygonShapefileToolStripMenuItem
        '
        Me.savePolygonShapefileToolStripMenuItem.Name = "savePolygonShapefileToolStripMenuItem"
        Me.savePolygonShapefileToolStripMenuItem.Size = New System.Drawing.Size(258, 26)
        Me.savePolygonShapefileToolStripMenuItem.Text = "Save Polygon Shapefile"
        '
        'mapOptionsToolStripMenuItem
        '
        Me.mapOptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.defaultToolStripMenuItem, Me.informationToolStripMenuItem, Me.measurementToolStripMenuItem, Me.zoomInToolStripMenuItem, Me.zoomOutToolStripMenuItem, Me.zoomToExtendToolStripMenuItem, Me.panToolStripMenuItem, Me.printMapToolStripMenuItem})
        Me.mapOptionsToolStripMenuItem.Name = "mapOptionsToolStripMenuItem"
        Me.mapOptionsToolStripMenuItem.Size = New System.Drawing.Size(109, 24)
        Me.mapOptionsToolStripMenuItem.Text = "Map Options"
        '
        'defaultToolStripMenuItem
        '
        Me.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem"
        Me.defaultToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.defaultToolStripMenuItem.Text = "Default"
        '
        'informationToolStripMenuItem
        '
        Me.informationToolStripMenuItem.Name = "informationToolStripMenuItem"
        Me.informationToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.informationToolStripMenuItem.Text = "Information"
        '
        'measurementToolStripMenuItem
        '
        Me.measurementToolStripMenuItem.Name = "measurementToolStripMenuItem"
        Me.measurementToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.measurementToolStripMenuItem.Text = "Measurement"
        '
        'zoomInToolStripMenuItem
        '
        Me.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem"
        Me.zoomInToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.zoomInToolStripMenuItem.Text = "Zoom In"
        '
        'zoomOutToolStripMenuItem
        '
        Me.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem"
        Me.zoomOutToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.zoomOutToolStripMenuItem.Text = "Zoom Out"
        '
        'zoomToExtendToolStripMenuItem
        '
        Me.zoomToExtendToolStripMenuItem.Name = "zoomToExtendToolStripMenuItem"
        Me.zoomToExtendToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.zoomToExtendToolStripMenuItem.Text = "Zoom To Extend"
        '
        'panToolStripMenuItem
        '
        Me.panToolStripMenuItem.Name = "panToolStripMenuItem"
        Me.panToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.panToolStripMenuItem.Text = "Pan"
        '
        'printMapToolStripMenuItem
        '
        Me.printMapToolStripMenuItem.Name = "printMapToolStripMenuItem"
        Me.printMapToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.printMapToolStripMenuItem.Text = "Print Map"
        '
        'attributeTableToolStripMenuItem
        '
        Me.attributeTableToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.viewAttributeToolStripMenuItem, Me.addAColumnInTheAttributeTableToolStripMenuItem, Me.deleteAColumnInTheAttributeTableToolStripMenuItem, Me.updateAttributeTableInShapefileToolStripMenuItem, Me.exportAttributeTableToExcelToolStripMenuItem})
        Me.attributeTableToolStripMenuItem.Name = "attributeTableToolStripMenuItem"
        Me.attributeTableToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.attributeTableToolStripMenuItem.Text = "Attribute Table Operation"
        '
        'viewAttributeToolStripMenuItem
        '
        Me.viewAttributeToolStripMenuItem.Name = "viewAttributeToolStripMenuItem"
        Me.viewAttributeToolStripMenuItem.Size = New System.Drawing.Size(341, 26)
        Me.viewAttributeToolStripMenuItem.Text = "View Attribute Table"
        '
        'addAColumnInTheAttributeTableToolStripMenuItem
        '
        Me.addAColumnInTheAttributeTableToolStripMenuItem.Name = "addAColumnInTheAttributeTableToolStripMenuItem"
        Me.addAColumnInTheAttributeTableToolStripMenuItem.Size = New System.Drawing.Size(341, 26)
        Me.addAColumnInTheAttributeTableToolStripMenuItem.Text = "Add a column in the attribute table"
        '
        'deleteAColumnInTheAttributeTableToolStripMenuItem
        '
        Me.deleteAColumnInTheAttributeTableToolStripMenuItem.Name = "deleteAColumnInTheAttributeTableToolStripMenuItem"
        Me.deleteAColumnInTheAttributeTableToolStripMenuItem.Size = New System.Drawing.Size(341, 26)
        Me.deleteAColumnInTheAttributeTableToolStripMenuItem.Text = "Delete a column in the attribute table"
        '
        'updateAttributeTableInShapefileToolStripMenuItem
        '
        Me.updateAttributeTableInShapefileToolStripMenuItem.Name = "updateAttributeTableInShapefileToolStripMenuItem"
        Me.updateAttributeTableInShapefileToolStripMenuItem.Size = New System.Drawing.Size(341, 26)
        Me.updateAttributeTableInShapefileToolStripMenuItem.Text = "Update attribute table in Shapefile"
        '
        'exportAttributeTableToExcelToolStripMenuItem
        '
        Me.exportAttributeTableToExcelToolStripMenuItem.Name = "exportAttributeTableToExcelToolStripMenuItem"
        Me.exportAttributeTableToExcelToolStripMenuItem.Size = New System.Drawing.Size(341, 26)
        Me.exportAttributeTableToExcelToolStripMenuItem.Text = "Export Attribute table to Excel"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlLegend)
        Me.Controls.Add(Me.pnlMap)
        Me.Controls.Add(Me.pnlAttribute)
        Me.Controls.Add(Me.pnlOperations)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnlLegend.ResumeLayout(False)
        Me.pnlMap.ResumeLayout(False)
        Me.pnlAttribute.ResumeLayout(False)
        CType(Me.dgvAttributeTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOperations.ResumeLayout(False)
        Me.pnlOperations.PerformLayout()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlLegend As Panel
    Private WithEvents legend1 As DotSpatial.Controls.Legend
    Private WithEvents pnlMap As Panel
    Private WithEvents map1 As DotSpatial.Controls.Map
    Private WithEvents pnlAttribute As Panel
    Private WithEvents dgvAttributeTable As DataGridView
    Private WithEvents pnlOperations As Panel
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents fileToolStripMenuItem As ToolStripMenuItem
    Private WithEvents loadToolStripMenuItem As ToolStripMenuItem
    Private WithEvents clearToolStripMenuItem As ToolStripMenuItem
    Private WithEvents exitToolStripMenuItem As ToolStripMenuItem
    Private WithEvents shapefileOperationsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents pointToolStripMenuItem As ToolStripMenuItem
    Private WithEvents createPointShapefileToolStripMenuItem As ToolStripMenuItem
    Private WithEvents savePointShapefileToolStripMenuItem As ToolStripMenuItem
    Private WithEvents polylineToolStripMenuItem As ToolStripMenuItem
    Private WithEvents createPolylineShapefileToolStripMenuItem As ToolStripMenuItem
    Private WithEvents savePolylineShapefileToolStripMenuItem As ToolStripMenuItem
    Private WithEvents polygonToolStripMenuItem As ToolStripMenuItem
    Private WithEvents createPolygonShapefileToolStripMenuItem As ToolStripMenuItem
    Private WithEvents savePolygonShapefileToolStripMenuItem As ToolStripMenuItem
    Private WithEvents mapOptionsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents defaultToolStripMenuItem As ToolStripMenuItem
    Private WithEvents informationToolStripMenuItem As ToolStripMenuItem
    Private WithEvents measurementToolStripMenuItem As ToolStripMenuItem
    Private WithEvents zoomInToolStripMenuItem As ToolStripMenuItem
    Private WithEvents zoomOutToolStripMenuItem As ToolStripMenuItem
    Private WithEvents zoomToExtendToolStripMenuItem As ToolStripMenuItem
    Private WithEvents panToolStripMenuItem As ToolStripMenuItem
    Private WithEvents printMapToolStripMenuItem As ToolStripMenuItem
    Private WithEvents attributeTableToolStripMenuItem As ToolStripMenuItem
    Private WithEvents viewAttributeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents addAColumnInTheAttributeTableToolStripMenuItem As ToolStripMenuItem
    Private WithEvents deleteAColumnInTheAttributeTableToolStripMenuItem As ToolStripMenuItem
    Private WithEvents updateAttributeTableInShapefileToolStripMenuItem As ToolStripMenuItem
    Private WithEvents exportAttributeTableToExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
