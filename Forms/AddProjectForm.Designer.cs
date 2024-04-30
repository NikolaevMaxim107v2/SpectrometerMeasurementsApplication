namespace SpectrometerMeasurementsApplication.Forms
{
    partial class AddProjectForm
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
            textBoxName = new TextBox();
            launchText = new Label();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxAddress = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(103, 41);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Введите название проекта...";
            textBoxName.RightToLeft = RightToLeft.No;
            textBoxName.Size = new Size(253, 23);
            textBoxName.TabIndex = 8;
            // 
            // launchText
            // 
            launchText.AutoSize = true;
            launchText.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            launchText.Location = new Point(133, 9);
            launchText.Name = "launchText";
            launchText.Size = new Size(141, 19);
            launchText.TabIndex = 7;
            launchText.Text = "Добавление проекта";
            launchText.TextAlign = ContentAlignment.TopCenter;
            launchText.UseMnemonic = false;
            // 
            // button1
            // 
            button1.Location = new Point(69, 137);
            button1.Name = "button1";
            button1.Size = new Size(253, 22);
            button1.TabIndex = 6;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 41);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 9;
            label1.Text = "Название:";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 70);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 11;
            label2.Text = "Заказчик:";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.UseMnemonic = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 99);
            label3.Name = "label3";
            label3.Size = new Size(50, 19);
            label3.TabIndex = 13;
            label3.Text = "Адрес:";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.UseMnemonic = false;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(103, 99);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.PlaceholderText = "Введите место проводения работ...";
            textBoxAddress.RightToLeft = RightToLeft.No;
            textBoxAddress.Size = new Size(253, 23);
            textBoxAddress.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(103, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(254, 23);
            comboBox1.TabIndex = 21;
            // 
            // AddProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 179);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBoxAddress);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(launchText);
            Controls.Add(button1);
            Name = "AddProjectForm";
            Text = "Добавить проект";
            FormClosed += AddProjectForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBoxName;
        private Label launchText;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox textBoxAddress;
        private ComboBox comboBox1;
    }
}