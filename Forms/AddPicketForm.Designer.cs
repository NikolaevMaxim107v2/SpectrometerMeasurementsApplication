namespace SpectrometerMeasurementsApplication.Forms
{
    partial class AddPicketForm
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
            label4 = new Label();
            textBoxY = new TextBox();
            label2 = new Label();
            label1 = new Label();
            launchText = new Label();
            button1 = new Button();
            textBoxX = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(67, 70);
            label4.Name = "label4";
            label4.Size = new Size(100, 19);
            label4.TabIndex = 49;
            label4.Text = "Координата X:";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.UseMnemonic = false;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(178, 99);
            textBoxY.Name = "textBoxY";
            textBoxY.PlaceholderText = "Введите координаты Y...";
            textBoxY.RightToLeft = RightToLeft.No;
            textBoxY.Size = new Size(425, 23);
            textBoxY.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(67, 100);
            label2.Name = "label2";
            label2.Size = new Size(100, 19);
            label2.TabIndex = 44;
            label2.Text = "Координата Y:";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(92, 41);
            label1.Name = "label1";
            label1.Size = new Size(75, 19);
            label1.TabIndex = 43;
            label1.Text = "Оператор:";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            // 
            // launchText
            // 
            launchText.AutoSize = true;
            launchText.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            launchText.Location = new Point(257, 11);
            launchText.Name = "launchText";
            launchText.Size = new Size(133, 19);
            launchText.TabIndex = 41;
            launchText.Text = "Добавление пикета";
            launchText.TextAlign = ContentAlignment.TopCenter;
            launchText.UseMnemonic = false;
            // 
            // button1
            // 
            button1.Location = new Point(214, 143);
            button1.Name = "button1";
            button1.Size = new Size(253, 22);
            button1.TabIndex = 40;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(178, 70);
            textBoxX.Name = "textBoxX";
            textBoxX.PlaceholderText = "Введите координаты Х...";
            textBoxX.RightToLeft = RightToLeft.No;
            textBoxX.Size = new Size(425, 23);
            textBoxX.TabIndex = 48;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(178, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(425, 23);
            comboBox1.TabIndex = 50;
            // 
            // AddPicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 190);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(textBoxX);
            Controls.Add(textBoxY);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(launchText);
            Controls.Add(button1);
            Name = "AddPicketForm";
            Text = "Добавление пикета";
            FormClosed += AddPicketForm_FormClosed;
            Load += AddPicketForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        public TextBox textBoxY;
        private Label label2;
        private Label label1;
        private Label launchText;
        private Button button1;
        public TextBox textBoxX;
        private ComboBox comboBox1;
    }
}