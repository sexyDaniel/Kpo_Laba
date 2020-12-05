namespace SpectralClassOfStars
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.starsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openStar = new System.Windows.Forms.ToolStripMenuItem();
            this.AddStarClass = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteStarClass = new System.Windows.Forms.ToolStripMenuItem();
            this.EditStarClass = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchSpectralClass = new System.Windows.Forms.ToolStripMenuItem();
            this.SStrip = new System.Windows.Forms.StatusStrip();
            this.dvgSpectralClass = new System.Windows.Forms.DataGridView();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSpectralClass)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.starsToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1032, 28);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile,
            this.ExitFile,
            this.SaveMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // OpenFile
            // 
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(120, 26);
            this.OpenFile.Text = "Open";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // ExitFile
            // 
            this.ExitFile.Name = "ExitFile";
            this.ExitFile.Size = new System.Drawing.Size(120, 26);
            this.ExitFile.Text = "Exit";
            this.ExitFile.Click += new System.EventHandler(this.ExitFile_Click);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(120, 26);
            this.SaveMenuItem.Text = "Save";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // starsToolStripMenuItem
            // 
            this.starsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openStar,
            this.AddStarClass,
            this.DeleteStarClass,
            this.EditStarClass,
            this.SearchSpectralClass});
            this.starsToolStripMenuItem.Name = "starsToolStripMenuItem";
            this.starsToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.starsToolStripMenuItem.Text = "Stars";
            // 
            // openStar
            // 
            this.openStar.Name = "openStar";
            this.openStar.Size = new System.Drawing.Size(216, 26);
            this.openStar.Text = "Open Data Of Star";
            this.openStar.Click += new System.EventHandler(this.openStar_Click_1);
            // 
            // AddStarClass
            // 
            this.AddStarClass.Name = "AddStarClass";
            this.AddStarClass.Size = new System.Drawing.Size(216, 26);
            this.AddStarClass.Text = "Add StarClass";
            this.AddStarClass.Click += new System.EventHandler(this.AddStarClass_Click);
            // 
            // DeleteStarClass
            // 
            this.DeleteStarClass.Name = "DeleteStarClass";
            this.DeleteStarClass.Size = new System.Drawing.Size(216, 26);
            this.DeleteStarClass.Text = "Delete StarClass";
            this.DeleteStarClass.Click += new System.EventHandler(this.DeleteStarClass_Click);
            // 
            // EditStarClass
            // 
            this.EditStarClass.Name = "EditStarClass";
            this.EditStarClass.Size = new System.Drawing.Size(216, 26);
            this.EditStarClass.Text = "Edit StarClass";
            this.EditStarClass.Click += new System.EventHandler(this.EditStarClass_Click);
            // 
            // SearchSpectralClass
            // 
            this.SearchSpectralClass.Name = "SearchSpectralClass";
            this.SearchSpectralClass.Size = new System.Drawing.Size(216, 26);
            this.SearchSpectralClass.Text = "Search StarClass";
            this.SearchSpectralClass.Click += new System.EventHandler(this.SearchSpectralClass_Click);
            // 
            // SStrip
            // 
            this.SStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SStrip.Location = new System.Drawing.Point(0, 472);
            this.SStrip.Name = "SStrip";
            this.SStrip.Size = new System.Drawing.Size(1032, 22);
            this.SStrip.TabIndex = 1;
            this.SStrip.Text = "statusStrip1";
            // 
            // dvgSpectralClass
            // 
            this.dvgSpectralClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgSpectralClass.Location = new System.Drawing.Point(12, 302);
            this.dvgSpectralClass.Name = "dvgSpectralClass";
            this.dvgSpectralClass.RowTemplate.Height = 24;
            this.dvgSpectralClass.Size = new System.Drawing.Size(648, 167);
            this.dvgSpectralClass.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 494);
            this.Controls.Add(this.dvgSpectralClass);
            this.Controls.Add(this.SStrip);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSpectralClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem ExitFile;
        private System.Windows.Forms.ToolStripMenuItem starsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openStar;
        private System.Windows.Forms.StatusStrip SStrip;
        private System.Windows.Forms.DataGridView dvgSpectralClass;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddStarClass;
        private System.Windows.Forms.ToolStripMenuItem DeleteStarClass;
        private System.Windows.Forms.ToolStripMenuItem EditStarClass;
        private System.Windows.Forms.ToolStripMenuItem SearchSpectralClass;
    }
}