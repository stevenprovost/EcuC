namespace EcuControl
{
    partial class Main
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
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToECUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadFromECUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realtimeDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ignitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.liveToolStripMenuItem,
            this.mapsToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(374, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.uploadToECUToolStripMenuItem,
            this.downloadFromECUToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.openToolStripMenuItem.Text = "Open..";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.saveAsToolStripMenuItem.Text = "Save As..";
            // 
            // uploadToECUToolStripMenuItem
            // 
            this.uploadToECUToolStripMenuItem.Name = "uploadToECUToolStripMenuItem";
            this.uploadToECUToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.uploadToECUToolStripMenuItem.Text = "Upload to ECU";
            // 
            // downloadFromECUToolStripMenuItem
            // 
            this.downloadFromECUToolStripMenuItem.Name = "downloadFromECUToolStripMenuItem";
            this.downloadFromECUToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.downloadFromECUToolStripMenuItem.Text = "Download from ECU";
            // 
            // liveToolStripMenuItem
            // 
            this.liveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realtimeDataToolStripMenuItem});
            this.liveToolStripMenuItem.Name = "liveToolStripMenuItem";
            this.liveToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.liveToolStripMenuItem.Text = "Live";
            // 
            // realtimeDataToolStripMenuItem
            // 
            this.realtimeDataToolStripMenuItem.Name = "realtimeDataToolStripMenuItem";
            this.realtimeDataToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.realtimeDataToolStripMenuItem.Text = "Realtime Data";
            this.realtimeDataToolStripMenuItem.Click += new System.EventHandler(this.realtimeDataToolStripMenuItem_Click);
            // 
            // mapsToolStripMenuItem
            // 
            this.mapsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fuelToolStripMenuItem,
            this.ignitionToolStripMenuItem});
            this.mapsToolStripMenuItem.Name = "mapsToolStripMenuItem";
            this.mapsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.mapsToolStripMenuItem.Text = "Maps";
            // 
            // fuelToolStripMenuItem
            // 
            this.fuelToolStripMenuItem.Name = "fuelToolStripMenuItem";
            this.fuelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fuelToolStripMenuItem.Text = "Fuel";
            this.fuelToolStripMenuItem.Click += new System.EventHandler(this.fuelToolStripMenuItem_Click);
            // 
            // ignitionToolStripMenuItem
            // 
            this.ignitionToolStripMenuItem.Name = "ignitionToolStripMenuItem";
            this.ignitionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ignitionToolStripMenuItem.Text = "Ignition";
            this.ignitionToolStripMenuItem.Click += new System.EventHandler(this.ignitionToolStripMenuItem_Click_1);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Settings";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingToolStripMenuItem.Text = "Options";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 154);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadToECUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadFromECUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realtimeDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ignitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
    }
}