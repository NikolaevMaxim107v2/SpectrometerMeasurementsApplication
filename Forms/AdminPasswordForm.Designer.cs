namespace SpectrometerMeasurementsApplication.Forms
{
    partial class AdminPasswordForm
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
            textBoxUsername = new TextBox();
            launchText = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(72, 82);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "Введите пароль...";
            textBoxUsername.RightToLeft = RightToLeft.No;
            textBoxUsername.Size = new Size(253, 23);
            textBoxUsername.TabIndex = 5;
            // 
            // launchText
            // 
            launchText.AutoSize = true;
            launchText.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            launchText.Location = new Point(40, 46);
            launchText.Name = "launchText";
            launchText.Size = new Size(303, 19);
            launchText.TabIndex = 4;
            launchText.Text = "Подтвердите вход с правами администратора";
            launchText.TextAlign = ContentAlignment.TopCenter;
            launchText.UseMnemonic = false;
            // 
            // button1
            // 
            button1.Location = new Point(72, 125);
            button1.Name = "button1";
            button1.Size = new Size(253, 22);
            button1.TabIndex = 3;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AdminPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 204);
            Controls.Add(textBoxUsername);
            Controls.Add(launchText);
            Controls.Add(button1);
            Name = "AdminPasswordForm";
            Text = "Подтвердите вход";
            FormClosed += AdminPasswordForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBoxUsername;
        private Label launchText;
        private Button button1;
    }
}