namespace HW8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Task1Button = new System.Windows.Forms.Button();
            this.Task2Button = new System.Windows.Forms.Button();
            this.Task3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Task1Button
            // 
            this.Task1Button.Location = new System.Drawing.Point(154, 47);
            this.Task1Button.Name = "Task1Button";
            this.Task1Button.Size = new System.Drawing.Size(148, 92);
            this.Task1Button.TabIndex = 0;
            this.Task1Button.Text = "Завдання 1";
            this.Task1Button.UseVisualStyleBackColor = true;
            this.Task1Button.Click += new System.EventHandler(this.Task1Button_Click);
            // 
            // Task2Button
            // 
            this.Task2Button.Location = new System.Drawing.Point(154, 155);
            this.Task2Button.Name = "Task2Button";
            this.Task2Button.Size = new System.Drawing.Size(148, 92);
            this.Task2Button.TabIndex = 1;
            this.Task2Button.Text = "Завдання 2";
            this.Task2Button.UseVisualStyleBackColor = true;
            this.Task2Button.Click += new System.EventHandler(this.Task2Button_Click);
            // 
            // Task3Button
            // 
            this.Task3Button.Location = new System.Drawing.Point(154, 264);
            this.Task3Button.Name = "Task3Button";
            this.Task3Button.Size = new System.Drawing.Size(148, 92);
            this.Task3Button.TabIndex = 2;
            this.Task3Button.Text = "Завдання 3";
            this.Task3Button.UseVisualStyleBackColor = true;
            this.Task3Button.Click += new System.EventHandler(this.Task3Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 398);
            this.Controls.Add(this.Task3Button);
            this.Controls.Add(this.Task2Button);
            this.Controls.Add(this.Task1Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Task1Button;
        private System.Windows.Forms.Button Task2Button;
        private System.Windows.Forms.Button Task3Button;
    }
}

