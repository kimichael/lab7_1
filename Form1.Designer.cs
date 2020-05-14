namespace Lab7_1
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
            this.main_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // main_button
            // 
            this.main_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.main_button.AutoSize = true;
            this.main_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.main_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.main_button.Location = new System.Drawing.Point(276, 177);
            this.main_button.Name = "main_button";
            this.main_button.Size = new System.Drawing.Size(57, 23);
            this.main_button.TabIndex = 0;
            this.main_button.Text = "Click me";
            this.main_button.UseVisualStyleBackColor = true;
            this.main_button.Click += new System.EventHandler(this.main_button_Click);
            this.main_button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.main_button_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 415);
            this.Controls.Add(this.main_button);
            this.Name = "Form1";
            this.Text = "Running button";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button main_button;
    }
}

