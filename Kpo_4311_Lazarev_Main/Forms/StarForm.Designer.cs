namespace SpectralClassOfStars
{
    partial class StarForm
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
            this.SpectralClassTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SpectralClassTextBox
            // 
            this.SpectralClassTextBox.Location = new System.Drawing.Point(96, 24);
            this.SpectralClassTextBox.Name = "SpectralClassTextBox";
            this.SpectralClassTextBox.Size = new System.Drawing.Size(304, 22);
            this.SpectralClassTextBox.TabIndex = 0;
            this.SpectralClassTextBox.TextChanged += new System.EventHandler(this.SpectralClassTextBox_TextChanged);
            // 
            // StarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SpectralClassTextBox);
            this.Name = "StarForm";
            this.Text = "StarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SpectralClassTextBox;
    }
}