namespace HW8
{
    partial class SearchForm
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
            this.FilesListBox = new System.Windows.Forms.ListBox();
            this.MaskLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilesListBox
            // 
            this.FilesListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.FilesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.ItemHeight = 16;
            this.FilesListBox.Location = new System.Drawing.Point(364, 0);
            this.FilesListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(720, 561);
            this.FilesListBox.TabIndex = 0;
            // 
            // MaskLabel
            // 
            this.MaskLabel.AutoSize = true;
            this.MaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaskLabel.Location = new System.Drawing.Point(43, 114);
            this.MaskLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaskLabel.Name = "MaskLabel";
            this.MaskLabel.Size = new System.Drawing.Size(202, 17);
            this.MaskLabel.TabIndex = 3;
            this.MaskLabel.Text = "Введіть маску пошуку файла:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(47, 202);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 23);
            this.textBox1.TabIndex = 4;
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindButton.Location = new System.Drawing.Point(47, 340);
            this.FindButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(264, 128);
            this.FindButton.TabIndex = 5;
            this.FindButton.Text = "Шукати";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.MaskLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FilesListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FilesListBox;
        private System.Windows.Forms.Label MaskLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button FindButton;
    }
}