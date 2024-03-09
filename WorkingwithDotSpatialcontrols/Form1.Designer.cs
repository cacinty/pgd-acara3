
namespace WorkingwithDotSpatialcontrols
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
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.pnlMap = new System.Windows.Forms.FlowLayoutPanel();
            this.grbOperations = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomToExtend = new System.Windows.Forms.Button();
            this.btnPan = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnMeasure = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.map1 = new DotSpatial.Controls.Map();
            this.pnlOperations.SuspendLayout();
            this.pnlMap.SuspendLayout();
            this.grbOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOperations
            // 
            this.pnlOperations.Controls.Add(this.lblTitle);
            this.pnlOperations.Controls.Add(this.grbOperations);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperations.Location = new System.Drawing.Point(0, 0);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(800, 222);
            this.pnlOperations.TabIndex = 0;
            // 
            // pnlMap
            // 
            this.pnlMap.Controls.Add(this.map1);
            this.pnlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMap.Location = new System.Drawing.Point(0, 222);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(800, 474);
            this.pnlMap.TabIndex = 1;
            this.pnlMap.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMap_Paint);
            // 
            // grbOperations
            // 
            this.grbOperations.Controls.Add(this.btnNone);
            this.grbOperations.Controls.Add(this.btnSelect);
            this.grbOperations.Controls.Add(this.btnMeasure);
            this.grbOperations.Controls.Add(this.btnInfo);
            this.grbOperations.Controls.Add(this.btnPan);
            this.grbOperations.Controls.Add(this.btnZoomToExtend);
            this.grbOperations.Controls.Add(this.btnZoomOut);
            this.grbOperations.Controls.Add(this.btnZoomIn);
            this.grbOperations.Controls.Add(this.btnClear);
            this.grbOperations.Controls.Add(this.btnLoad);
            this.grbOperations.Location = new System.Drawing.Point(12, 58);
            this.grbOperations.Name = "grbOperations";
            this.grbOperations.Size = new System.Drawing.Size(776, 154);
            this.grbOperations.TabIndex = 0;
            this.grbOperations.TabStop = false;
            this.grbOperations.Text = "groupBox1";
            this.grbOperations.Enter += new System.EventHandler(this.grbOperations_Enter);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(44, 43);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(95, 36);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "&Load Map";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(142, 43);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 36);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "&Clear Map";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Location = new System.Drawing.Point(255, 44);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(103, 36);
            this.btnZoomIn.TabIndex = 2;
            this.btnZoomIn.Text = "Zoom &In";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(361, 43);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(101, 35);
            this.btnZoomOut.TabIndex = 3;
            this.btnZoomOut.Text = "Zoom &Out";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomToExtend
            // 
            this.btnZoomToExtend.Location = new System.Drawing.Point(465, 43);
            this.btnZoomToExtend.Name = "btnZoomToExtend";
            this.btnZoomToExtend.Size = new System.Drawing.Size(135, 35);
            this.btnZoomToExtend.TabIndex = 4;
            this.btnZoomToExtend.Text = "Zoom to &Extent";
            this.btnZoomToExtend.UseVisualStyleBackColor = true;
            this.btnZoomToExtend.Click += new System.EventHandler(this.btnZoomToExtend_Click);
            // 
            // btnPan
            // 
            this.btnPan.Location = new System.Drawing.Point(603, 43);
            this.btnPan.Name = "btnPan";
            this.btnPan.Size = new System.Drawing.Size(98, 35);
            this.btnPan.TabIndex = 5;
            this.btnPan.Text = "&Pan";
            this.btnPan.UseVisualStyleBackColor = true;
            this.btnPan.Click += new System.EventHandler(this.btnPan_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(139, 99);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(110, 31);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.Text = "In&fo";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnMeasure
            // 
            this.btnMeasure.Location = new System.Drawing.Point(255, 99);
            this.btnMeasure.Name = "btnMeasure";
            this.btnMeasure.Size = new System.Drawing.Size(111, 31);
            this.btnMeasure.TabIndex = 7;
            this.btnMeasure.Text = "&Measure";
            this.btnMeasure.UseVisualStyleBackColor = true;
            this.btnMeasure.Click += new System.EventHandler(this.btnMeasure_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(372, 99);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(113, 31);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "&Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnNone
            // 
            this.btnNone.Location = new System.Drawing.Point(491, 99);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(117, 31);
            this.btnNone.TabIndex = 9;
            this.btnNone.Text = "&None";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Stencil", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(143, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(475, 46);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Basic Map Operations";
            // 
            // map1
            // 
            this.map1.AllowDrop = true;
            this.map1.BackColor = System.Drawing.Color.White;
            this.map1.CollisionDetection = false;
            this.map1.ExtendBuffer = false;
            this.map1.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.map1.IsBusy = false;
            this.map1.IsZoomedToMaxExtent = false;
            this.map1.Legend = null;
            this.map1.Location = new System.Drawing.Point(3, 3);
            this.map1.Name = "map1";
            this.map1.ProgressHandler = null;
            this.map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.RedrawLayersWhileResizing = false;
            this.map1.SelectionEnabled = true;
            this.map1.Size = new System.Drawing.Size(797, 471);
            this.map1.TabIndex = 0;
            this.map1.ZoomOutFartherThanMaxExtent = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 696);
            this.Controls.Add(this.pnlMap);
            this.Controls.Add(this.pnlOperations);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlOperations.ResumeLayout(false);
            this.pnlOperations.PerformLayout();
            this.pnlMap.ResumeLayout(false);
            this.grbOperations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.FlowLayoutPanel pnlMap;
        private System.Windows.Forms.GroupBox grbOperations;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnMeasure;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnPan;
        private System.Windows.Forms.Button btnZoomToExtend;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblTitle;
        private DotSpatial.Controls.Map map1;
    }
}

