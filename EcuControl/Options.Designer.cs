namespace EcuControl
{
    partial class Options
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cancelB = new System.Windows.Forms.Button();
            this.saveB = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.currentBar = new System.Windows.Forms.ProgressBar();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.fullBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.fullText = new System.Windows.Forms.TextBox();
            this.zeroText = new System.Windows.Forms.TextBox();
            this.currentText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(349, 190);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cancelB);
            this.tabPage1.Controls.Add(this.saveB);
            this.tabPage1.Controls.Add(this.portBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(341, 164);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(257, 129);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(75, 23);
            this.cancelB.TabIndex = 3;
            this.cancelB.Text = "Close";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(176, 129);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(75, 23);
            this.saveB.TabIndex = 2;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // portBox
            // 
            this.portBox.FormattingEnabled = true;
            this.portBox.Location = new System.Drawing.Point(193, 28);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(119, 21);
            this.portBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Serial Port";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.startBtn);
            this.tabPage2.Controls.Add(this.stopBtn);
            this.tabPage2.Controls.Add(this.currentBar);
            this.tabPage2.Controls.Add(this.cancelBtn);
            this.tabPage2.Controls.Add(this.saveBtn);
            this.tabPage2.Controls.Add(this.fullBtn);
            this.tabPage2.Controls.Add(this.zeroBtn);
            this.tabPage2.Controls.Add(this.fullText);
            this.tabPage2.Controls.Add(this.zeroText);
            this.tabPage2.Controls.Add(this.currentText);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(341, 164);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calibrate";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // currentBar
            // 
            this.currentBar.Location = new System.Drawing.Point(269, 27);
            this.currentBar.Name = "currentBar";
            this.currentBar.Size = new System.Drawing.Size(59, 20);
            this.currentBar.TabIndex = 10;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(269, 135);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(59, 23);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Close";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(208, 135);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(55, 23);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // fullBtn
            // 
            this.fullBtn.Location = new System.Drawing.Point(269, 101);
            this.fullBtn.Name = "fullBtn";
            this.fullBtn.Size = new System.Drawing.Size(59, 20);
            this.fullBtn.TabIndex = 7;
            this.fullBtn.Text = "Set";
            this.fullBtn.UseVisualStyleBackColor = true;
            this.fullBtn.Click += new System.EventHandler(this.fullBtn_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.Location = new System.Drawing.Point(269, 75);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(59, 20);
            this.zeroBtn.TabIndex = 6;
            this.zeroBtn.Text = "Set";
            this.zeroBtn.UseVisualStyleBackColor = true;
            this.zeroBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // fullText
            // 
            this.fullText.Location = new System.Drawing.Point(163, 101);
            this.fullText.Name = "fullText";
            this.fullText.ReadOnly = true;
            this.fullText.Size = new System.Drawing.Size(100, 20);
            this.fullText.TabIndex = 5;
            this.fullText.Text = "0";
            this.fullText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zeroText
            // 
            this.zeroText.Location = new System.Drawing.Point(163, 75);
            this.zeroText.Name = "zeroText";
            this.zeroText.ReadOnly = true;
            this.zeroText.Size = new System.Drawing.Size(100, 20);
            this.zeroText.TabIndex = 4;
            this.zeroText.Text = "0";
            this.zeroText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // currentText
            // 
            this.currentText.Location = new System.Drawing.Point(163, 27);
            this.currentText.Name = "currentText";
            this.currentText.ReadOnly = true;
            this.currentText.Size = new System.Drawing.Size(100, 20);
            this.currentText.TabIndex = 3;
            this.currentText.Text = "0";
            this.currentText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "0% Voltage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "100% Voltage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current TPS value";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(11, 135);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 12;
            this.startBtn.Text = "Start Serial";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(92, 135);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 11;
            this.stopBtn.Text = "Stop Serial";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 186);
            this.Controls.Add(this.tabControl1);
            this.Name = "Options";
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.Load += new System.EventHandler(this.Options_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ProgressBar currentBar;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button fullBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.TextBox fullText;
        private System.Windows.Forms.TextBox zeroText;
        private System.Windows.Forms.TextBox currentText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox portBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
    }
}