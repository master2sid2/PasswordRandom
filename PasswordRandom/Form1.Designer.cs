namespace PasswordRandom
{
    partial class MainForm
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
            this.genButton = new System.Windows.Forms.Button();
            this.passTextBox1 = new System.Windows.Forms.TextBox();
            this.passLenghtTrackBar = new System.Windows.Forms.TrackBar();
            this.passLenghtLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passLenghtTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // genButton
            // 
            this.genButton.Location = new System.Drawing.Point(12, 93);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(225, 23);
            this.genButton.TabIndex = 0;
            this.genButton.Text = "Generate";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // passTextBox1
            // 
            this.passTextBox1.Location = new System.Drawing.Point(12, 12);
            this.passTextBox1.Multiline = true;
            this.passTextBox1.Name = "passTextBox1";
            this.passTextBox1.Size = new System.Drawing.Size(225, 24);
            this.passTextBox1.TabIndex = 1;
            // 
            // passLenghtTrackBar
            // 
            this.passLenghtTrackBar.LargeChange = 1;
            this.passLenghtTrackBar.Location = new System.Drawing.Point(12, 42);
            this.passLenghtTrackBar.Maximum = 32;
            this.passLenghtTrackBar.Minimum = 8;
            this.passLenghtTrackBar.Name = "passLenghtTrackBar";
            this.passLenghtTrackBar.Size = new System.Drawing.Size(206, 45);
            this.passLenghtTrackBar.TabIndex = 2;
            this.passLenghtTrackBar.Value = 8;
            this.passLenghtTrackBar.Scroll += new System.EventHandler(this.passLenghtTrackBar_Scroll);
            // 
            // passLenghtLabel
            // 
            this.passLenghtLabel.AutoSize = true;
            this.passLenghtLabel.Location = new System.Drawing.Point(224, 52);
            this.passLenghtLabel.Name = "passLenghtLabel";
            this.passLenghtLabel.Size = new System.Drawing.Size(13, 13);
            this.passLenghtLabel.TabIndex = 3;
            this.passLenghtLabel.Text = "8";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 124);
            this.Controls.Add(this.passLenghtLabel);
            this.Controls.Add(this.passLenghtTrackBar);
            this.Controls.Add(this.passTextBox1);
            this.Controls.Add(this.genButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.passLenghtTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.TextBox passTextBox1;
        private System.Windows.Forms.TrackBar passLenghtTrackBar;
        private System.Windows.Forms.Label passLenghtLabel;
    }
}

