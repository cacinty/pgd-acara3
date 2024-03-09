
namespace Task_05
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.txtElevation = new System.Windows.Forms.TextBox();
            this.chbRasterValue = new System.Windows.Forms.CheckBox();
            this.lblRasterValue = new System.Windows.Forms.Label();
            this.lblElevation = new System.Windows.Forms.Label();
            this.btnReclassify = new System.Windows.Forms.Button();
            this.btnMultiplyRaster = new System.Windows.Forms.Button();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.btnHillshade = new System.Windows.Forms.Button();
            this.btnLoadRaster = new System.Windows.Forms.Button();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.Legend1 = new DotSpatial.Controls.Legend();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.Map1 = new DotSpatial.Controls.Map();
            this.appManager1 = new DotSpatial.Controls.AppManager();
            this.pnlOperations.SuspendLayout();
            this.pnlLegend.SuspendLayout();
            this.pnlMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOperations
            // 
            this.pnlOperations.Controls.Add(this.txtElevation);
            this.pnlOperations.Controls.Add(this.chbRasterValue);
            this.pnlOperations.Controls.Add(this.lblRasterValue);
            this.pnlOperations.Controls.Add(this.lblElevation);
            this.pnlOperations.Controls.Add(this.btnReclassify);
            this.pnlOperations.Controls.Add(this.btnMultiplyRaster);
            this.pnlOperations.Controls.Add(this.btnChangeColor);
            this.pnlOperations.Controls.Add(this.btnHillshade);
            this.pnlOperations.Controls.Add(this.btnLoadRaster);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperations.Location = new System.Drawing.Point(0, 0);
            this.pnlOperations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(860, 116);
            this.pnlOperations.TabIndex = 0;
            // 
            // txtElevation
            // 
            this.txtElevation.Location = new System.Drawing.Point(444, 61);
            this.txtElevation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtElevation.Name = "txtElevation";
            this.txtElevation.Size = new System.Drawing.Size(68, 20);
            this.txtElevation.TabIndex = 17;
            this.txtElevation.Text = "3000";
            // 
            // chbRasterValue
            // 
            this.chbRasterValue.AutoSize = true;
            this.chbRasterValue.Location = new System.Drawing.Point(630, 43);
            this.chbRasterValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbRasterValue.Name = "chbRasterValue";
            this.chbRasterValue.Size = new System.Drawing.Size(161, 17);
            this.chbRasterValue.TabIndex = 16;
            this.chbRasterValue.Text = "Raster value at clicked point";
            this.chbRasterValue.UseVisualStyleBackColor = true;
            this.chbRasterValue.CheckedChanged += new System.EventHandler(this.chbRasterValue_CheckedChanged);
            // 
            // lblRasterValue
            // 
            this.lblRasterValue.AutoSize = true;
            this.lblRasterValue.Location = new System.Drawing.Point(632, 66);
            this.lblRasterValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRasterValue.Name = "lblRasterValue";
            this.lblRasterValue.Size = new System.Drawing.Size(103, 13);
            this.lblRasterValue.TabIndex = 15;
            this.lblRasterValue.Text = "Row :Column :Value";
            // 
            // lblElevation
            // 
            this.lblElevation.AutoSize = true;
            this.lblElevation.Location = new System.Drawing.Point(442, 43);
            this.lblElevation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElevation.Name = "lblElevation";
            this.lblElevation.Size = new System.Drawing.Size(51, 13);
            this.lblElevation.TabIndex = 14;
            this.lblElevation.Text = "Elevation";
            // 
            // btnReclassify
            // 
            this.btnReclassify.Location = new System.Drawing.Point(528, 37);
            this.btnReclassify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReclassify.Name = "btnReclassify";
            this.btnReclassify.Size = new System.Drawing.Size(98, 25);
            this.btnReclassify.TabIndex = 13;
            this.btnReclassify.Text = "Reclassify &Raster";
            this.btnReclassify.UseVisualStyleBackColor = true;
            this.btnReclassify.Click += new System.EventHandler(this.btnReclassify_Click);
            // 
            // btnMultiplyRaster
            // 
            this.btnMultiplyRaster.Location = new System.Drawing.Point(339, 37);
            this.btnMultiplyRaster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMultiplyRaster.Name = "btnMultiplyRaster";
            this.btnMultiplyRaster.Size = new System.Drawing.Size(98, 25);
            this.btnMultiplyRaster.TabIndex = 12;
            this.btnMultiplyRaster.Text = "&Multiply Raster";
            this.btnMultiplyRaster.UseVisualStyleBackColor = true;
            this.btnMultiplyRaster.Click += new System.EventHandler(this.btnMultiplyRaster_Click);
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(236, 37);
            this.btnChangeColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(98, 25);
            this.btnChangeColor.TabIndex = 11;
            this.btnChangeColor.Text = "Change &Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // btnHillshade
            // 
            this.btnHillshade.Location = new System.Drawing.Point(134, 37);
            this.btnHillshade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHillshade.Name = "btnHillshade";
            this.btnHillshade.Size = new System.Drawing.Size(98, 25);
            this.btnHillshade.TabIndex = 10;
            this.btnHillshade.Text = "&Hillshade";
            this.btnHillshade.UseVisualStyleBackColor = true;
            this.btnHillshade.Click += new System.EventHandler(this.btnHillshade_Click);
            // 
            // btnLoadRaster
            // 
            this.btnLoadRaster.Location = new System.Drawing.Point(31, 37);
            this.btnLoadRaster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadRaster.Name = "btnLoadRaster";
            this.btnLoadRaster.Size = new System.Drawing.Size(98, 25);
            this.btnLoadRaster.TabIndex = 9;
            this.btnLoadRaster.Text = "&Load Raster";
            this.btnLoadRaster.UseVisualStyleBackColor = true;
            this.btnLoadRaster.Click += new System.EventHandler(this.btnLoadRaster_Click);
            // 
            // pnlLegend
            // 
            this.pnlLegend.Controls.Add(this.Legend1);
            this.pnlLegend.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLegend.Location = new System.Drawing.Point(0, 116);
            this.pnlLegend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(195, 273);
            this.pnlLegend.TabIndex = 1;
            // 
            // Legend1
            // 
            this.Legend1.BackColor = System.Drawing.Color.White;
            this.Legend1.ControlRectangle = new System.Drawing.Rectangle(0, 0, 195, 273);
            this.Legend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Legend1.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
            this.Legend1.HorizontalScrollEnabled = true;
            this.Legend1.Indentation = 30;
            this.Legend1.IsInitialized = false;
            this.Legend1.Location = new System.Drawing.Point(0, 0);
            this.Legend1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Legend1.MinimumSize = new System.Drawing.Size(4, 3);
            this.Legend1.Name = "Legend1";
            this.Legend1.ProgressHandler = null;
            this.Legend1.ResetOnResize = false;
            this.Legend1.SelectionFontColor = System.Drawing.Color.Black;
            this.Legend1.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.Legend1.Size = new System.Drawing.Size(195, 273);
            this.Legend1.TabIndex = 1;
            this.Legend1.Text = "legend1";
            this.Legend1.VerticalScrollEnabled = true;
            this.Legend1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Map1_MouseUp);
            // 
            // pnlMap
            // 
            this.pnlMap.Controls.Add(this.Map1);
            this.pnlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMap.Location = new System.Drawing.Point(195, 116);
            this.pnlMap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(665, 273);
            this.pnlMap.TabIndex = 2;
            // 
            // Map1
            // 
            this.Map1.AllowDrop = true;
            this.Map1.BackColor = System.Drawing.Color.White;
            this.Map1.CollectAfterDraw = false;
            this.Map1.CollisionDetection = false;
            this.Map1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Map1.ExtendBuffer = false;
            this.Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.Map1.IsBusy = false;
            this.Map1.Legend = null;
            this.Map1.Location = new System.Drawing.Point(0, 0);
            this.Map1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Map1.Name = "Map1";
            this.Map1.ProgressHandler = null;
            this.Map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.Map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.Map1.RedrawLayersWhileResizing = false;
            this.Map1.SelectionEnabled = true;
            this.Map1.Size = new System.Drawing.Size(665, 273);
            this.Map1.TabIndex = 1;
            // 
            // appManager1
            // 
            this.appManager1.CompositionContainer = null;
            this.appManager1.Directories = ((System.Collections.Generic.List<string>)(resources.GetObject("appManager1.Directories")));
            this.appManager1.DockManager = null;
            this.appManager1.HeaderControl = null;
            this.appManager1.Legend = null;
            this.appManager1.Map = null;
            this.appManager1.ProgressHandler = null;
            this.appManager1.ShowExtensionsDialog = DotSpatial.Controls.ShowExtensionsDialog.Default;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 389);
            this.Controls.Add(this.pnlMap);
            this.Controls.Add(this.pnlLegend);
            this.Controls.Add(this.pnlOperations);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlOperations.ResumeLayout(false);
            this.pnlOperations.PerformLayout();
            this.pnlLegend.ResumeLayout(false);
            this.pnlMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.TextBox txtElevation;
        private System.Windows.Forms.CheckBox chbRasterValue;
        private System.Windows.Forms.Label lblRasterValue;
        private System.Windows.Forms.Label lblElevation;
        private System.Windows.Forms.Button btnReclassify;
        private System.Windows.Forms.Button btnMultiplyRaster;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button btnHillshade;
        private System.Windows.Forms.Button btnLoadRaster;
        private System.Windows.Forms.Panel pnlLegend;
        private DotSpatial.Controls.Legend Legend1;
        private System.Windows.Forms.Panel pnlMap;
        private DotSpatial.Controls.Map Map1;
        private DotSpatial.Controls.AppManager appManager1;
    }
}

