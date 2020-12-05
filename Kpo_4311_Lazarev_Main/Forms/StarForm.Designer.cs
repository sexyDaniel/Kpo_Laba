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
            this.MassOfSunTextBox = new System.Windows.Forms.TextBox();
            this.PartTextBox = new System.Windows.Forms.TextBox();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.SpectralNameLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PartLable = new System.Windows.Forms.Label();
            this.CountLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddStar = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SpectralClassTextBox
            // 
            this.SpectralClassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpectralClassTextBox.Location = new System.Drawing.Point(17, 34);
            this.SpectralClassTextBox.Name = "SpectralClassTextBox";
            this.SpectralClassTextBox.Size = new System.Drawing.Size(304, 30);
            this.SpectralClassTextBox.TabIndex = 0;
            this.SpectralClassTextBox.TextChanged += new System.EventHandler(this.SpectralClassTextBox_TextChanged);
            // 
            // MassOfSunTextBox
            // 
            this.MassOfSunTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MassOfSunTextBox.Location = new System.Drawing.Point(17, 95);
            this.MassOfSunTextBox.Name = "MassOfSunTextBox";
            this.MassOfSunTextBox.Size = new System.Drawing.Size(304, 30);
            this.MassOfSunTextBox.TabIndex = 1;
            // 
            // PartTextBox
            // 
            this.PartTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PartTextBox.Location = new System.Drawing.Point(17, 156);
            this.PartTextBox.Name = "PartTextBox";
            this.PartTextBox.Size = new System.Drawing.Size(304, 30);
            this.PartTextBox.TabIndex = 2;
            // 
            // CountTextBox
            // 
            this.CountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountTextBox.Location = new System.Drawing.Point(17, 222);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(304, 30);
            this.CountTextBox.TabIndex = 3;
            // 
            // SpectralNameLable
            // 
            this.SpectralNameLable.AutoSize = true;
            this.SpectralNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpectralNameLable.Location = new System.Drawing.Point(12, 11);
            this.SpectralNameLable.Name = "SpectralNameLable";
            this.SpectralNameLable.Size = new System.Drawing.Size(0, 25);
            this.SpectralNameLable.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(54, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 5;
            // 
            // PartLable
            // 
            this.PartLable.AutoSize = true;
            this.PartLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PartLable.Location = new System.Drawing.Point(12, 128);
            this.PartLable.Name = "PartLable";
            this.PartLable.Size = new System.Drawing.Size(47, 25);
            this.PartLable.TabIndex = 6;
            this.PartLable.Text = "Part";
            // 
            // CountLable
            // 
            this.CountLable.AutoSize = true;
            this.CountLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountLable.Location = new System.Drawing.Point(12, 194);
            this.CountLable.Name = "CountLable";
            this.CountLable.Size = new System.Drawing.Size(65, 25);
            this.CountLable.TabIndex = 7;
            this.CountLable.Text = "Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "CLass Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mass of Sun";
            // 
            // AddStar
            // 
            this.AddStar.Location = new System.Drawing.Point(17, 258);
            this.AddStar.Name = "AddStar";
            this.AddStar.Size = new System.Drawing.Size(75, 23);
            this.AddStar.TabIndex = 10;
            this.AddStar.Text = "Add";
            this.AddStar.UseVisualStyleBackColor = true;
            this.AddStar.Click += new System.EventHandler(this.AddStar_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(98, 258);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 11;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(179, 258);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // StarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 415);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.AddStar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountLable);
            this.Controls.Add(this.PartLable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpectralNameLable);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.PartTextBox);
            this.Controls.Add(this.MassOfSunTextBox);
            this.Controls.Add(this.SpectralClassTextBox);
            this.Name = "StarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MassOfSunTextBox;
        private System.Windows.Forms.TextBox PartTextBox;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.Label SpectralNameLable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PartLable;
        private System.Windows.Forms.Label CountLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.TextBox SpectralClassTextBox;
        public System.Windows.Forms.Button Delete;
        public System.Windows.Forms.Button AddStar;
        public System.Windows.Forms.Button Edit;
    }
}