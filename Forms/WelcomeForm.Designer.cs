namespace SpectrometerMeasurementsApplication
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            launchText = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // launchText
            // 
            launchText.AutoSize = true;
            launchText.Location = new Point(317, 175);
            launchText.Name = "launchText";
            launchText.Size = new Size(266, 15);
            launchText.TabIndex = 0;
            launchText.Text = "Здравствуйте! Пожалуйста, войдите в профиль";
            launchText.TextAlign = ContentAlignment.TopCenter;
            launchText.UseMnemonic = false;
            // 
            // button1
            // 
            button1.Location = new Point(335, 223);
            button1.Name = "button1";
            button1.Size = new Size(156, 40);
            button1.TabIndex = 1;
            button1.Text = "Авторизация";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(launchText);
            Name = "Form1";
            Text = "Здравствуйте!";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label launchText;
        private Button button1;
    }
}
