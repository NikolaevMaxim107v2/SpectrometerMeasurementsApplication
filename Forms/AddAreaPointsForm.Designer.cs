namespace SpectrometerMeasurementsApplication.Forms
{
    partial class AddAreaPointsForm
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
            textBoxY = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxX = new TextBox();
            launchText = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(154, 97);
            textBoxY.Margin = new Padding(3, 4, 3, 4);
            textBoxY.Name = "textBoxY";
            textBoxY.PlaceholderText = "Введите координату Y...";
            textBoxY.RightToLeft = RightToLeft.No;
            textBoxY.Size = new Size(521, 27);
            textBoxY.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 135);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 36;
            label3.Text = "Площадь:";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 97);
            label2.Name = "label2";
            label2.Size = new Size(122, 23);
            label2.TabIndex = 34;
            label2.Text = "Координата Y:";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 59);
            label1.Name = "label1";
            label1.Size = new Size(123, 23);
            label1.TabIndex = 33;
            label1.Text = "Координата X:";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(154, 59);
            textBoxX.Margin = new Padding(3, 4, 3, 4);
            textBoxX.Name = "textBoxX";
            textBoxX.PlaceholderText = "Введите координату X...";
            textBoxX.RightToLeft = RightToLeft.No;
            textBoxX.Size = new Size(521, 27);
            textBoxX.TabIndex = 32;
            // 
            // launchText
            // 
            launchText.AutoSize = true;
            launchText.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            launchText.Location = new Point(289, 12);
            launchText.Name = "launchText";
            launchText.Size = new Size(233, 23);
            launchText.TabIndex = 31;
            launchText.Text = "Добавление точки площади";
            launchText.TextAlign = ContentAlignment.TopCenter;
            launchText.UseMnemonic = false;
            // 
            // button1
            // 
            button1.Location = new Point(230, 200);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(289, 29);
            button1.TabIndex = 30;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(154, 136);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(521, 28);
            comboBox1.TabIndex = 38;
            // 
            // AddAreaPointsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 269);
            Controls.Add(comboBox1);
            Controls.Add(textBoxY);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxX);
            Controls.Add(launchText);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddAreaPointsForm";
            Text = "Добавление точки площади";
            FormClosed += AddAreaPointsForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBoxY;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox textBoxX;
        private Label launchText;
        private Button button1;
        private ComboBox comboBox1;
    }
}