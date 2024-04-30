namespace SpectrometerMeasurementsApplication
{
    partial class LoginForm
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
            button1 = new Button();
            launchText = new Label();
            textBoxUsername = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(296, 255);
            button1.Name = "button1";
            button1.Size = new Size(253, 28);
            button1.TabIndex = 0;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // launchText
            // 
            launchText.AutoSize = true;
            launchText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            launchText.Location = new Point(372, 156);
            launchText.Name = "launchText";
            launchText.Size = new Size(104, 21);
            launchText.TabIndex = 1;
            launchText.Text = "Авторизация";
            launchText.TextAlign = ContentAlignment.TopCenter;
            launchText.UseMnemonic = false;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(296, 203);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "Введите имя пользователя...";
            textBoxUsername.RightToLeft = RightToLeft.No;
            textBoxUsername.Size = new Size(253, 23);
            textBoxUsername.TabIndex = 2;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxUsername);
            Controls.Add(launchText);
            Controls.Add(button1);
            Name = "LoginForm";
            Text = "Авторизация";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label launchText;
        public TextBox textBoxUsername;
    }
}