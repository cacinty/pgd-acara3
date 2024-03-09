
namespace Task_04
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMapCtrlLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMapCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitCtrlEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInCtrlUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutCtrlDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToMapExtentCtrlZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.measureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.gbCustomAttribute = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCustomAttribute = new System.Windows.Forms.TextBox();
            this.lblLabelName = new System.Windows.Forms.Label();
            this.gbShapeAttribute = new System.Windows.Forms.GroupBox();
            this.cmbFiledName = new System.Windows.Forms.ComboBox();
            this.btnDisplayLabel = new System.Windows.Forms.Button();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.gbCustom = new System.Windows.Forms.GroupBox();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.btnSetFont = new System.Windows.Forms.Button();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.map1 = new DotSpatial.Controls.Map();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.pnlOperations.SuspendLayout();
            this.gbCustomAttribute.SuspendLayout();
            this.gbShapeAttribute.SuspendLayout();
            this.gbCustom.SuspendLayout();
            this.pnlMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mapOptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1223, 42);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMapCtrlLToolStripMenuItem,
            this.clearMapCtrlCToolStripMenuItem,
            this.exitCtrlEToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 38);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadMapCtrlLToolStripMenuItem
            // 
            this.loadMapCtrlLToolStripMenuItem.Name = "loadMapCtrlLToolStripMenuItem";
            this.loadMapCtrlLToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.loadMapCtrlLToolStripMenuItem.Text = "&Load Map     Ctrl+L";
            this.loadMapCtrlLToolStripMenuItem.Click += new System.EventHandler(this.loadMapCtrlLToolStripMenuItem_Click);
            // 
            // clearMapCtrlCToolStripMenuItem
            // 
            this.clearMapCtrlCToolStripMenuItem.Name = "clearMapCtrlCToolStripMenuItem";
            this.clearMapCtrlCToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.clearMapCtrlCToolStripMenuItem.Text = "&Clear Map    Ctrl+C";
            this.clearMapCtrlCToolStripMenuItem.Click += new System.EventHandler(this.clearMapCtrlCToolStripMenuItem_Click);
            // 
            // exitCtrlEToolStripMenuItem
            // 
            this.exitCtrlEToolStripMenuItem.Name = "exitCtrlEToolStripMenuItem";
            this.exitCtrlEToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exitCtrlEToolStripMenuItem.Text = "&Exit             Ctrl+E";
            this.exitCtrlEToolStripMenuItem.Click += new System.EventHandler(this.exitCtrlEToolStripMenuItem_Click);
            // 
            // mapOptionsToolStripMenuItem
            // 
            this.mapOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInCtrlUpToolStripMenuItem,
            this.zoomOutCtrlDownToolStripMenuItem,
            this.zoomToMapExtentCtrlZToolStripMenuItem,
            this.panToolStripMenuItem,
            this.measureToolStripMenuItem,
            this.defaultToolStripMenuItem});
            this.mapOptionsToolStripMenuItem.Name = "mapOptionsToolStripMenuItem";
            this.mapOptionsToolStripMenuItem.Size = new System.Drawing.Size(174, 38);
            this.mapOptionsToolStripMenuItem.Text = "&Map Options";
            // 
            // zoomInCtrlUpToolStripMenuItem
            // 
            this.zoomInCtrlUpToolStripMenuItem.Name = "zoomInCtrlUpToolStripMenuItem";
            this.zoomInCtrlUpToolStripMenuItem.Size = new System.Drawing.Size(440, 44);
            this.zoomInCtrlUpToolStripMenuItem.Text = "&Zoom In        Ctrl+Up";
            this.zoomInCtrlUpToolStripMenuItem.Click += new System.EventHandler(this.zoomInCtrlUpToolStripMenuItem_Click);
            // 
            // zoomOutCtrlDownToolStripMenuItem
            // 
            this.zoomOutCtrlDownToolStripMenuItem.Name = "zoomOutCtrlDownToolStripMenuItem";
            this.zoomOutCtrlDownToolStripMenuItem.Size = new System.Drawing.Size(440, 44);
            this.zoomOutCtrlDownToolStripMenuItem.Text = "&Zoom Out     Ctrl+Down";
            this.zoomOutCtrlDownToolStripMenuItem.Click += new System.EventHandler(this.zoomOutCtrlDownToolStripMenuItem_Click);
            // 
            // zoomToMapExtentCtrlZToolStripMenuItem
            // 
            this.zoomToMapExtentCtrlZToolStripMenuItem.Name = "zoomToMapExtentCtrlZToolStripMenuItem";
            this.zoomToMapExtentCtrlZToolStripMenuItem.Size = new System.Drawing.Size(440, 44);
            this.zoomToMapExtentCtrlZToolStripMenuItem.Text = "&Zoom to MaxExtent  Ctrl+Z";
            this.zoomToMapExtentCtrlZToolStripMenuItem.Click += new System.EventHandler(this.zoomToMapExtentCtrlZToolStripMenuItem_Click);
            // 
            // panToolStripMenuItem
            // 
            this.panToolStripMenuItem.Name = "panToolStripMenuItem";
            this.panToolStripMenuItem.Size = new System.Drawing.Size(440, 44);
            this.panToolStripMenuItem.Text = "&Pan";
            this.panToolStripMenuItem.Click += new System.EventHandler(this.panToolStripMenuItem_Click);
            // 
            // measureToolStripMenuItem
            // 
            this.measureToolStripMenuItem.Name = "measureToolStripMenuItem";
            this.measureToolStripMenuItem.Size = new System.Drawing.Size(440, 44);
            this.measureToolStripMenuItem.Text = "&Measure";
            this.measureToolStripMenuItem.Click += new System.EventHandler(this.measureToolStripMenuItem_Click);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(440, 44);
            this.defaultToolStripMenuItem.Text = "&Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // pnlOperations
            // 
            this.pnlOperations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOperations.Controls.Add(this.gbCustomAttribute);
            this.pnlOperations.Controls.Add(this.gbShapeAttribute);
            this.pnlOperations.Controls.Add(this.gbCustom);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOperations.Location = new System.Drawing.Point(0, 42);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(443, 873);
            this.pnlOperations.TabIndex = 3;
            // 
            // gbCustomAttribute
            // 
            this.gbCustomAttribute.Controls.Add(this.btnDelete);
            this.gbCustomAttribute.Controls.Add(this.btnSave);
            this.gbCustomAttribute.Controls.Add(this.btnAdd);
            this.gbCustomAttribute.Controls.Add(this.txtCustomAttribute);
            this.gbCustomAttribute.Controls.Add(this.lblLabelName);
            this.gbCustomAttribute.Location = new System.Drawing.Point(11, 514);
            this.gbCustomAttribute.Name = "gbCustomAttribute";
            this.gbCustomAttribute.Size = new System.Drawing.Size(405, 224);
            this.gbCustomAttribute.TabIndex = 1;
            this.gbCustomAttribute.TabStop = false;
            this.gbCustomAttribute.Text = "Custom Attributes for existing shape file";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(249, 142);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 44);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(135, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 44);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 44);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCustomAttribute
            // 
            this.txtCustomAttribute.Location = new System.Drawing.Point(169, 83);
            this.txtCustomAttribute.Name = "txtCustomAttribute";
            this.txtCustomAttribute.Size = new System.Drawing.Size(190, 31);
            this.txtCustomAttribute.TabIndex = 1;
            this.txtCustomAttribute.TextChanged += new System.EventHandler(this.txtCustomAttribute_TextChanged);
            // 
            // lblLabelName
            // 
            this.lblLabelName.AutoSize = true;
            this.lblLabelName.Location = new System.Drawing.Point(23, 83);
            this.lblLabelName.Name = "lblLabelName";
            this.lblLabelName.Size = new System.Drawing.Size(127, 25);
            this.lblLabelName.TabIndex = 0;
            this.lblLabelName.Text = "Label Name";
            // 
            // gbShapeAttribute
            // 
            this.gbShapeAttribute.Controls.Add(this.cmbFiledName);
            this.gbShapeAttribute.Controls.Add(this.btnDisplayLabel);
            this.gbShapeAttribute.Controls.Add(this.lblFieldName);
            this.gbShapeAttribute.Location = new System.Drawing.Point(11, 268);
            this.gbShapeAttribute.Name = "gbShapeAttribute";
            this.gbShapeAttribute.Size = new System.Drawing.Size(405, 224);
            this.gbShapeAttribute.TabIndex = 1;
            this.gbShapeAttribute.TabStop = false;
            this.gbShapeAttribute.Text = "Display label from Attribute table";
            // 
            // cmbFiledName
            // 
            this.cmbFiledName.FormattingEnabled = true;
            this.cmbFiledName.Location = new System.Drawing.Point(119, 50);
            this.cmbFiledName.Name = "cmbFiledName";
            this.cmbFiledName.Size = new System.Drawing.Size(240, 33);
            this.cmbFiledName.TabIndex = 3;
            // 
            // btnDisplayLabel
            // 
            this.btnDisplayLabel.Location = new System.Drawing.Point(23, 113);
            this.btnDisplayLabel.Name = "btnDisplayLabel";
            this.btnDisplayLabel.Size = new System.Drawing.Size(336, 50);
            this.btnDisplayLabel.TabIndex = 2;
            this.btnDisplayLabel.Text = "Display Labels";
            this.btnDisplayLabel.UseVisualStyleBackColor = true;
            this.btnDisplayLabel.Click += new System.EventHandler(this.btnDisplayLabel_Click);
            // 
            // lblFieldName
            // 
            this.lblFieldName.AutoSize = true;
            this.lblFieldName.Location = new System.Drawing.Point(23, 50);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(70, 25);
            this.lblFieldName.TabIndex = 0;
            this.lblFieldName.Text = "Fields";
            // 
            // gbCustom
            // 
            this.gbCustom.Controls.Add(this.btnSetColor);
            this.gbCustom.Controls.Add(this.btnSetFont);
            this.gbCustom.Location = new System.Drawing.Point(11, 14);
            this.gbCustom.Name = "gbCustom";
            this.gbCustom.Size = new System.Drawing.Size(405, 224);
            this.gbCustom.TabIndex = 0;
            this.gbCustom.TabStop = false;
            this.gbCustom.Text = "Set the label properties";
            // 
            // btnSetColor
            // 
            this.btnSetColor.Location = new System.Drawing.Point(23, 120);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(336, 50);
            this.btnSetColor.TabIndex = 1;
            this.btnSetColor.Text = "Set Color";
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColor_Click);
            // 
            // btnSetFont
            // 
            this.btnSetFont.Location = new System.Drawing.Point(23, 55);
            this.btnSetFont.Name = "btnSetFont";
            this.btnSetFont.Size = new System.Drawing.Size(336, 50);
            this.btnSetFont.TabIndex = 0;
            this.btnSetFont.Text = "Set Font Style and Size";
            this.btnSetFont.UseVisualStyleBackColor = true;
            this.btnSetFont.Click += new System.EventHandler(this.btnSetFont_Click);
            // 
            // pnlMap
            // 
            this.pnlMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMap.Controls.Add(this.map1);
            this.pnlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMap.Location = new System.Drawing.Point(443, 42);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(780, 873);
            this.pnlMap.TabIndex = 4;
            // 
            // map1
            // 
            this.map1.AllowDrop = true;
            this.map1.BackColor = System.Drawing.Color.White;
            this.map1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.map1.CollectAfterDraw = false;
            this.map1.CollisionDetection = false;
            this.map1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map1.ExtendBuffer = false;
            this.map1.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.map1.IsBusy = false;
            this.map1.Legend = null;
            this.map1.Location = new System.Drawing.Point(0, 0);
            this.map1.Name = "map1";
            this.map1.ProgressHandler = null;
            this.map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.RedrawLayersWhileResizing = false;
            this.map1.SelectionEnabled = true;
            this.map1.Size = new System.Drawing.Size(776, 869);
            this.map1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 915);
            this.Controls.Add(this.pnlMap);
            this.Controls.Add(this.pnlOperations);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlOperations.ResumeLayout(false);
            this.gbCustomAttribute.ResumeLayout(false);
            this.gbCustomAttribute.PerformLayout();
            this.gbShapeAttribute.ResumeLayout(false);
            this.gbShapeAttribute.PerformLayout();
            this.gbCustom.ResumeLayout(false);
            this.pnlMap.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMapCtrlLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMapCtrlCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitCtrlEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInCtrlUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutCtrlDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToMapExtentCtrlZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem measureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.GroupBox gbCustomAttribute;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCustomAttribute;
        private System.Windows.Forms.Label lblLabelName;
        private System.Windows.Forms.GroupBox gbShapeAttribute;
        private System.Windows.Forms.ComboBox cmbFiledName;
        private System.Windows.Forms.Button btnDisplayLabel;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.GroupBox gbCustom;
        private System.Windows.Forms.Button btnSetColor;
        private System.Windows.Forms.Button btnSetFont;
        private System.Windows.Forms.Panel pnlMap;
        private DotSpatial.Controls.Map map1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

