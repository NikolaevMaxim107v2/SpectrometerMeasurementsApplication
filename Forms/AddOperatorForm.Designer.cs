namespace SpectrometerMeasurementsApplication.Forms
{
    partial class AddOperatorForm
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
            textBoxPhone = new TextBox();
            label3 = new Label();
            textBoxAddress = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBoxName = new TextBox();
            launchText = new Label();
            button1 = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(170, 99);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.PlaceholderText = "Введите номер телефона...";
            textBoxPhone.RightToLeft = RightToLeft.No;
            textBoxPhone.Size = new Size(425, 23);
            textBoxPhone.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 128);
            label3.Name = "label3";
            label3.Size = new Size(138, 19);
            label3.TabIndex = 36;
            label3.Text = "Электронный адрес:";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.UseMnemonic = false;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(170, 128);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.PlaceholderText = "Введите email...";
            textBoxAddress.RightToLeft = RightToLeft.No;
            textBoxAddress.Size = new Size(425, 23);
            textBoxAddress.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 99);
            label2.Name = "label2";
            label2.Size = new Size(119, 19);
            label2.TabIndex = 34;
            label2.Text = "Номер телефона:";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(120, 41);
            label1.Name = "label1";
            label1.Size = new Size(39, 19);
            label1.TabIndex = 33;
            label1.Text = "Имя:";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(170, 41);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Введите имя...";
            textBoxName.RightToLeft = RightToLeft.No;
            textBoxName.Size = new Size(425, 23);
            textBoxName.TabIndex = 32;
            // 
            // launchText
            // 
            launchText.AutoSize = true;
            launchText.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            launchText.Location = new Point(249, 11);
            launchText.Name = "launchText";
            launchText.Size = new Size(157, 19);
            launchText.TabIndex = 31;
            launchText.Text = "Добавление оператора";
            launchText.TextAlign = ContentAlignment.TopCenter;
            launchText.UseMnemonic = false;
            // 
            // button1
            // 
            button1.Location = new Point(208, 174);
            button1.Name = "button1";
            button1.Size = new Size(253, 22);
            button1.TabIndex = 30;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(90, 70);
            label4.Name = "label4";
            label4.Size = new Size(69, 19);
            label4.TabIndex = 39;
            label4.Text = "Фамилия:";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.UseMnemonic = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 70);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Введите фамилию...";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(425, 23);
            textBox1.TabIndex = 38;
            // 
            // AddOperatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 228);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(textBoxPhone);
            Controls.Add(label3);
            Controls.Add(textBoxAddress);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(launchText);
            Controls.Add(button1);
            Name = "AddOperatorForm";
            Text = "Добавить оператора";
            FormClosed += AddOperatorForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBoxPhone;
        private Label label3;
        public TextBox textBoxAddress;
        private Label label2;
        private Label label1;
        public TextBox textBoxName;
        private Label launchText;
        private Button button1;
        private Label label4;
        public TextBox textBox1;
    }
}