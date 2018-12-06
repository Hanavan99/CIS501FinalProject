namespace CIS501FinalProject
{
    partial class MainForm
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
            this.uxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxViewAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.uxLocalFilePath = new System.Windows.Forms.TextBox();
            this.uxKSISFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxReload = new System.Windows.Forms.Button();
            this.uxClear = new System.Windows.Forms.Button();
            this.uxResults = new System.Windows.Forms.TextBox();
            this.uxLoadLocalFile = new System.Windows.Forms.ToolStripMenuItem();
            this.uxLoadKSISFile = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMenuStrip
            // 
            this.uxMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.uxViewAbout});
            this.uxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.uxMenuStrip.Name = "uxMenuStrip";
            this.uxMenuStrip.Size = new System.Drawing.Size(705, 28);
            this.uxMenuStrip.TabIndex = 0;
            this.uxMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxLoadLocalFile,
            this.uxLoadKSISFile});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // uxViewAbout
            // 
            this.uxViewAbout.Name = "uxViewAbout";
            this.uxViewAbout.Size = new System.Drawing.Size(62, 24);
            this.uxViewAbout.Text = "About";
            this.uxViewAbout.Click += new System.EventHandler(this.uxViewAbout_Click);
            // 
            // uxLocalFilePath
            // 
            this.uxLocalFilePath.Location = new System.Drawing.Point(63, 31);
            this.uxLocalFilePath.Name = "uxLocalFilePath";
            this.uxLocalFilePath.Size = new System.Drawing.Size(215, 22);
            this.uxLocalFilePath.TabIndex = 1;
            // 
            // uxKSISFilePath
            // 
            this.uxKSISFilePath.Location = new System.Drawing.Point(332, 31);
            this.uxKSISFilePath.Name = "uxKSISFilePath";
            this.uxKSISFilePath.Size = new System.Drawing.Size(201, 22);
            this.uxKSISFilePath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Local:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "KSIS:";
            // 
            // uxReload
            // 
            this.uxReload.Location = new System.Drawing.Point(539, 31);
            this.uxReload.Name = "uxReload";
            this.uxReload.Size = new System.Drawing.Size(75, 23);
            this.uxReload.TabIndex = 5;
            this.uxReload.Text = "Reload";
            this.uxReload.UseVisualStyleBackColor = true;
            this.uxReload.Click += new System.EventHandler(this.uxReload_Click);
            // 
            // uxClear
            // 
            this.uxClear.Location = new System.Drawing.Point(620, 31);
            this.uxClear.Name = "uxClear";
            this.uxClear.Size = new System.Drawing.Size(75, 23);
            this.uxClear.TabIndex = 6;
            this.uxClear.Text = "Clear";
            this.uxClear.UseVisualStyleBackColor = true;
            // 
            // uxResults
            // 
            this.uxResults.Location = new System.Drawing.Point(12, 59);
            this.uxResults.Multiline = true;
            this.uxResults.Name = "uxResults";
            this.uxResults.ReadOnly = true;
            this.uxResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxResults.Size = new System.Drawing.Size(683, 358);
            this.uxResults.TabIndex = 7;
            // 
            // uxLoadLocalFile
            // 
            this.uxLoadLocalFile.Name = "uxLoadLocalFile";
            this.uxLoadLocalFile.Size = new System.Drawing.Size(216, 26);
            this.uxLoadLocalFile.Text = "Load Local File";
            // 
            // uxLoadKSISFile
            // 
            this.uxLoadKSISFile.Name = "uxLoadKSISFile";
            this.uxLoadKSISFile.Size = new System.Drawing.Size(216, 26);
            this.uxLoadKSISFile.Text = "Load KSIS File";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 429);
            this.Controls.Add(this.uxResults);
            this.Controls.Add(this.uxClear);
            this.Controls.Add(this.uxReload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxKSISFilePath);
            this.Controls.Add(this.uxLocalFilePath);
            this.Controls.Add(this.uxMenuStrip);
            this.MainMenuStrip = this.uxMenuStrip;
            this.Name = "MainForm";
            this.Text = "SVT";
            this.uxMenuStrip.ResumeLayout(false);
            this.uxMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxViewAbout;
        private System.Windows.Forms.TextBox uxLocalFilePath;
        private System.Windows.Forms.TextBox uxKSISFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uxReload;
        private System.Windows.Forms.Button uxClear;
        private System.Windows.Forms.TextBox uxResults;
        private System.Windows.Forms.ToolStripMenuItem uxLoadLocalFile;
        private System.Windows.Forms.ToolStripMenuItem uxLoadKSISFile;
    }
}

