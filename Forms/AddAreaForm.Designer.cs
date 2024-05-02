namespace SpectrometerMeasurementsApplication.Forms
{
    partial class AddAreaForm
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
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            textBoxName = new TextBox();
            launchText = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(120, 97);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(621, 28);
            comboBox1.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 98);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 26;
            label2.Text = "Проект:";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 59);
            label1.Name = "label1";
            label1.Size = new Size(90, 23);
            label1.TabIndex = 25;
            label1.Text = "Название:";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(119, 59);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Введите название площади...";
            textBoxName.RightToLeft = RightToLeft.No;
            textBoxName.Size = new Size(621, 27);
            textBoxName.TabIndex = 24;
            // 
            // launchText
            // 
            launchText.AutoSize = true;
            launchText.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            launchText.Location = new Point(321, 12);
            launchText.Name = "launchText";
            launchText.Size = new Size(183, 23);
            launchText.TabIndex = 23;
            launchText.Text = "Добавление площади";
            launchText.TextAlign = ContentAlignment.TopCenter;
            launchText.UseMnemonic = false;
            // 
            // button1
            // 
            button1.Location = new Point(233, 149);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(371, 33);
            button1.TabIndex = 22;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddAreaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 216);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(launchText);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddAreaForm";
            Text = "Добавить площадь";
            FormClosed += AddAreaForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        public TextBox textBoxName;
        private Label launchText;
        private Button button1;
    }
}