
namespace Task2_A3
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
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomExtentCtrlZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splcMapLegend = new System.Windows.Forms.SplitContainer();
            this.legend1 = new DotSpatial.Controls.Legend();
            this.map1 = new DotSpatial.Controls.Map();
            this.splcDataOperation = new System.Windows.Forms.SplitContainer();
            this.gbOperations = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPopulation = new System.Windows.Forms.TextBox();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.btnFilterByPopulation = new System.Windows.Forms.Button();
            this.btnViewAttributes = new System.Windows.Forms.Button();
            this.btnRandomColors = new System.Windows.Forms.Button();
            this.btnFilterByPopState = new System.Windows.Forms.Button();
            this.btnFilterByStateName = new System.Windows.Forms.Button();
            this.btnDisplayStateName = new System.Windows.Forms.Button();
            this.dgvAttributeTable = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splcMapLegend)).BeginInit();
            this.splcMapLegend.Panel1.SuspendLayout();
            this.splcMapLegend.Panel2.SuspendLayout();
            this.splcMapLegend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splcDataOperation)).BeginInit();
            this.splcDataOperation.Panel1.SuspendLayout();
            this.splcDataOperation.Panel2.SuspendLayout();
            this.splcDataOperation.SuspendLayout();
            this.gbOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttributeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.mapOperationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lToolStripMenuItem,
            this.clearMapToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fILEToolStripMenuItem.Text = "&File";
            // 
            // lToolStripMenuItem
            // 
            this.lToolStripMenuItem.Name = "lToolStripMenuItem";
            this.lToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lToolStripMenuItem.Text = "&Load Map     Ctrl+L";
            this.lToolStripMenuItem.Click += new System.EventHandler(this.lToolStripMenuItem_Click);
            // 
            // clearMapToolStripMenuItem
            // 
            this.clearMapToolStripMenuItem.Name = "clearMapToolStripMenuItem";
            this.clearMapToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearMapToolStripMenuItem.Text = "&Clear Map     Ctrl+C";
            this.clearMapToolStripMenuItem.Click += new System.EventHandler(this.clearMapToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exitToolStripMenuItem.Text = "&Exit                Ctrl+E";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mapOperationToolStripMenuItem
            // 
            this.mapOperationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.zoomExtentCtrlZToolStripMenuItem});
            this.mapOperationToolStripMenuItem.Name = "mapOperationToolStripMenuItem";
            this.mapOperationToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.mapOperationToolStripMenuItem.Text = "&Map Operation";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom &In       Ctrl+Up";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom &Out    Ctrl+Down";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // zoomExtentCtrlZToolStripMenuItem
            // 
            this.zoomExtentCtrlZToolStripMenuItem.Name = "zoomExtentCtrlZToolStripMenuItem";
            this.zoomExtentCtrlZToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.zoomExtentCtrlZToolStripMenuItem.Text = "Zoom &Extent   Ctrl+Z";
            this.zoomExtentCtrlZToolStripMenuItem.Click += new System.EventHandler(this.zoomExtentCtrlZToolStripMenuItem_Click);
            // 
            // splcMapLegend
            // 
            this.splcMapLegend.Dock = System.Windows.Forms.DockStyle.Top;
            this.splcMapLegend.Location = new System.Drawing.Point(0, 24);
            this.splcMapLegend.Name = "splcMapLegend";
            // 
            // splcMapLegend.Panel1
            // 
            this.splcMapLegend.Panel1.Controls.Add(this.legend1);
            // 
            // splcMapLegend.Panel2
            // 
            this.splcMapLegend.Panel2.Controls.Add(this.map1);
            this.splcMapLegend.Size = new System.Drawing.Size(672, 166);
            this.splcMapLegend.SplitterDistance = 188;
            this.splcMapLegend.TabIndex = 1;
            // 
            // legend1
            // 
            this.legend1.BackColor = System.Drawing.Color.White;
            this.legend1.ControlRectangle = new System.Drawing.Rectangle(0, 0, 188, 166);
            this.legend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legend1.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
            this.legend1.HorizontalScrollEnabled = true;
            this.legend1.Indentation = 30;
            this.legend1.IsInitialized = false;
            this.legend1.Location = new System.Drawing.Point(0, 0);
            this.legend1.MinimumSize = new System.Drawing.Size(5, 5);
            this.legend1.Name = "legend1";
            this.legend1.ProgressHandler = null;
            this.legend1.ResetOnResize = false;
            this.legend1.SelectionFontColor = System.Drawing.Color.Black;
            this.legend1.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.legend1.Size = new System.Drawing.Size(188, 166);
            this.legend1.TabIndex = 0;
            this.legend1.Text = "legend1";
            this.legend1.VerticalScrollEnabled = true;
            // 
            // map1
            // 
            this.map1.AllowDrop = true;
            this.map1.BackColor = System.Drawing.Color.White;
            this.map1.CollectAfterDraw = false;
            this.map1.CollisionDetection = false;
            this.map1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map1.ExtendBuffer = false;
            this.map1.FunctionMode = DotSpatial.Controls.FunctionMode.Pan;
            this.map1.IsBusy = false;
            this.map1.Legend = this.legend1;
            this.map1.Location = new System.Drawing.Point(0, 0);
            this.map1.Name = "map1";
            this.map1.ProgressHandler = null;
            this.map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.RedrawLayersWhileResizing = false;
            this.map1.SelectionEnabled = true;
            this.map1.Size = new System.Drawing.Size(480, 166);
            this.map1.TabIndex = 0;
            // 
            // splcDataOperation
            // 
            this.splcDataOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splcDataOperation.Location = new System.Drawing.Point(0, 190);
            this.splcDataOperation.Name = "splcDataOperation";
            this.splcDataOperation.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splcDataOperation.Panel1
            // 
            this.splcDataOperation.Panel1.Controls.Add(this.gbOperations);
            // 
            // splcDataOperation.Panel2
            // 
            this.splcDataOperation.Panel2.Controls.Add(this.dgvAttributeTable);
            this.splcDataOperation.Size = new System.Drawing.Size(672, 179);
            this.splcDataOperation.SplitterDistance = 92;
            this.splcDataOperation.TabIndex = 2;
            // 
            // gbOperations
            // 
            this.gbOperations.Controls.Add(this.lblTitle);
            this.gbOperations.Controls.Add(this.txtPopulation);
            this.gbOperations.Controls.Add(this.lblPopulation);
            this.gbOperations.Controls.Add(this.btnFilterByPopulation);
            this.gbOperations.Controls.Add(this.btnViewAttributes);
            this.gbOperations.Controls.Add(this.btnRandomColors);
            this.gbOperations.Controls.Add(this.btnFilterByPopState);
            this.gbOperations.Controls.Add(this.btnFilterByStateName);
            this.gbOperations.Controls.Add(this.btnDisplayStateName);
            this.gbOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOperations.Location = new System.Drawing.Point(0, 0);
            this.gbOperations.Name = "gbOperations";
            this.gbOperations.Size = new System.Drawing.Size(672, 92);
            this.gbOperations.TabIndex = 0;
            this.gbOperations.TabStop = false;
            this.gbOperations.Text = "Operations";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(26, 74);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(76, 13);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Attribute Table";
            // 
            // txtPopulation
            // 
            this.txtPopulation.Location = new System.Drawing.Point(329, 51);
            this.txtPopulation.Name = "txtPopulation";
            this.txtPopulation.Size = new System.Drawing.Size(115, 20);
            this.txtPopulation.TabIndex = 7;
            this.txtPopulation.TextChanged += new System.EventHandler(this.txtPopulation_TextChanged);
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Location = new System.Drawing.Point(133, 57);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(190, 13);
            this.lblPopulation.TabIndex = 6;
            this.lblPopulation.Text = "Enter the amount of population in 1990";
            // 
            // btnFilterByPopulation
            // 
            this.btnFilterByPopulation.Location = new System.Drawing.Point(450, 47);
            this.btnFilterByPopulation.Name = "btnFilterByPopulation";
            this.btnFilterByPopulation.Size = new System.Drawing.Size(179, 23);
            this.btnFilterByPopulation.TabIndex = 5;
            this.btnFilterByPopulation.Text = "Filter by amount of &population";
            this.btnFilterByPopulation.UseVisualStyleBackColor = true;
            this.btnFilterByPopulation.Click += new System.EventHandler(this.btnFilterByPopulation_Click);
            // 
            // btnViewAttributes
            // 
            this.btnViewAttributes.Location = new System.Drawing.Point(12, 48);
            this.btnViewAttributes.Name = "btnViewAttributes";
            this.btnViewAttributes.Size = new System.Drawing.Size(104, 23);
            this.btnViewAttributes.TabIndex = 4;
            this.btnViewAttributes.Text = "View &Attributes";
            this.btnViewAttributes.UseVisualStyleBackColor = true;
            this.btnViewAttributes.Click += new System.EventHandler(this.btnViewAttributes_Click);
            // 
            // btnRandomColors
            // 
            this.btnRandomColors.Location = new System.Drawing.Point(450, 19);
            this.btnRandomColors.Name = "btnRandomColors";
            this.btnRandomColors.Size = new System.Drawing.Size(194, 23);
            this.btnRandomColors.TabIndex = 3;
            this.btnRandomColors.Text = "&Random colors based on State Name";
            this.btnRandomColors.UseVisualStyleBackColor = true;
            this.btnRandomColors.Click += new System.EventHandler(this.btnRandomColors_Click);
            // 
            // btnFilterByPopState
            // 
            this.btnFilterByPopState.Location = new System.Drawing.Point(255, 19);
            this.btnFilterByPopState.Name = "btnFilterByPopState";
            this.btnFilterByPopState.Size = new System.Drawing.Size(189, 23);
            this.btnFilterByPopState.TabIndex = 2;
            this.btnFilterByPopState.Text = "Filter by &Population and State Name";
            this.btnFilterByPopState.UseVisualStyleBackColor = true;
            this.btnFilterByPopState.Click += new System.EventHandler(this.btnFilterByPopState_Click);
            // 
            // btnFilterByStateName
            // 
            this.btnFilterByStateName.Location = new System.Drawing.Point(133, 19);
            this.btnFilterByStateName.Name = "btnFilterByStateName";
            this.btnFilterByStateName.Size = new System.Drawing.Size(116, 23);
            this.btnFilterByStateName.TabIndex = 1;
            this.btnFilterByStateName.Text = "Filter by &State Name";
            this.btnFilterByStateName.UseVisualStyleBackColor = true;
            this.btnFilterByStateName.Click += new System.EventHandler(this.btnFilterByStateName_Click);
            // 
            // btnDisplayStateName
            // 
            this.btnDisplayStateName.Location = new System.Drawing.Point(12, 19);
            this.btnDisplayStateName.Name = "btnDisplayStateName";
            this.btnDisplayStateName.Size = new System.Drawing.Size(115, 23);
            this.btnDisplayStateName.TabIndex = 0;
            this.btnDisplayStateName.Text = "&Display State Name";
            this.btnDisplayStateName.UseVisualStyleBackColor = true;
            this.btnDisplayStateName.Click += new System.EventHandler(this.btnDisplayStateName_Click);
            // 
            // dgvAttributeTable
            // 
            this.dgvAttributeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttributeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttributeTable.Location = new System.Drawing.Point(0, 0);
            this.dgvAttributeTable.Name = "dgvAttributeTable";
            this.dgvAttributeTable.Size = new System.Drawing.Size(672, 83);
            this.dgvAttributeTable.TabIndex = 0;
            this.dgvAttributeTable.SelectionChanged += new System.EventHandler(this.dgvAttributeTable_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 369);
            this.Controls.Add(this.splcDataOperation);
            this.Controls.Add(this.splcMapLegend);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splcMapLegend.Panel1.ResumeLayout(false);
            this.splcMapLegend.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splcMapLegend)).EndInit();
            this.splcMapLegend.ResumeLayout(false);
            this.splcDataOperation.Panel1.ResumeLayout(false);
            this.splcDataOperation.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splcDataOperation)).EndInit();
            this.splcDataOperation.ResumeLayout(false);
            this.gbOperations.ResumeLayout(false);
            this.gbOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttributeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomExtentCtrlZToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splcMapLegend;
        private DotSpatial.Controls.Legend legend1;
        private DotSpatial.Controls.Map map1;
        private System.Windows.Forms.SplitContainer splcDataOperation;
        private System.Windows.Forms.GroupBox gbOperations;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPopulation;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.Button btnFilterByPopulation;
        private System.Windows.Forms.Button btnViewAttributes;
        private System.Windows.Forms.Button btnRandomColors;
        private System.Windows.Forms.Button btnFilterByPopState;
        private System.Windows.Forms.Button btnFilterByStateName;
        private System.Windows.Forms.Button btnDisplayStateName;
        private System.Windows.Forms.DataGridView dgvAttributeTable;
    }
}

