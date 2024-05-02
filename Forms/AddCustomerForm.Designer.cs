namespace SpectrometerMeasurementsApplication.Forms
{
    partial class AddCustomerForm
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
            label3 = new Label();
            textBoxAddress = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBoxName = new TextBox();
            launchText = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 129);
            label3.Name = "label3";
            label3.Size = new Size(169, 23);
            label3.TabIndex = 28;
            label3.Text = "Электронный адрес:";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.UseMnemonic = false;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(194, 129);
            textBoxAddress.Margin = new Padding(3, 4, 3, 4);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.PlaceholderText = "Введите email...";
            textBoxAddress.RightToLeft = RightToLeft.No;
            textBoxAddress.Size = new Size(485, 27);
            textBoxAddress.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 91);
            label2.Name = "label2";
            label2.Size = new Size(147, 23);
            label2.TabIndex = 26;
            label2.Text = "Номер телефона:";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 53);
            label1.Name = "label1";
            label1.Size = new Size(178, 23);
            label1.TabIndex = 25;
            label1.Text = "ФИО/Наименование:";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(194, 52);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Введите ФИО/Название...";
            textBoxName.RightToLeft = RightToLeft.No;
            textBoxName.Size = new Size(485, 27);
            textBoxName.TabIndex = 24;
            // 
            // launchText
            // 
            launchText.AutoSize = true;
            launchText.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            launchText.Location = new Point(285, 12);
            launchText.Name = "launchText";
            launchText.Size = new Size(191, 23);
            launchText.TabIndex = 23;
            launchText.Text = "Добавление заказчика";
            launchText.TextAlign = ContentAlignment.TopCenter;
            launchText.UseMnemonic = false;
            // 
            // button1
            // 
            button1.Location = new Point(230, 187);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(289, 29);
            button1.TabIndex = 22;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 91);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Введите номер телефона...";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(485, 27);
            textBox1.TabIndex = 29;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 245);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(textBoxAddress);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(launchText);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddCustomerForm";
            Text = "Добавление заказчика";
            FormClosed += AddCustomerForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        public TextBox textBoxAddress;
        private Label label2;
        private Label label1;
        public TextBox textBoxName;
        private Label launchText;
        private Button button1;
        public TextBox textBox1;
    }
}