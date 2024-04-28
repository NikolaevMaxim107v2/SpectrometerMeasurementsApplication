namespace SpectrometerMeasurementsApplication
{
    partial class ProfileForm
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
            button6 = new Button();
            button1 = new Button();
            button7 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            launchText = new Label();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Location = new Point(284, 386);
            button6.Name = "button6";
            button6.Size = new Size(491, 24);
            button6.TabIndex = 47;
            button6.Text = "Назад";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.Location = new Point(116, 203);
            button1.Name = "button1";
            button1.Size = new Size(102, 26);
            button1.TabIndex = 45;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(12, 203);
            button7.Name = "button7";
            button7.Size = new Size(102, 26);
            button7.TabIndex = 43;
            button7.Text = "Добавить";
            button7.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 203);
            button2.Name = "button2";
            button2.Size = new Size(102, 26);
            button2.TabIndex = 44;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(116, 384);
            button3.Name = "button3";
            button3.Size = new Size(102, 26);
            button3.TabIndex = 41;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 384);
            button4.Name = "button4";
            button4.Size = new Size(102, 26);
            button4.TabIndex = 40;
            button4.Text = "Добавить";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 236);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 39;
            label1.Text = "Пикеты";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 55);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 37;
            label2.Text = "Точки профиля";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.UseMnemonic = false;
            // 
            // launchText
            // 
            launchText.AutoSize = true;
            launchText.Location = new Point(65, 55);
            launchText.Name = "launchText";
            launchText.Size = new Size(94, 15);
            launchText.TabIndex = 38;
            launchText.Text = "Точки площади";
            launchText.TextAlign = ContentAlignment.TopCenter;
            launchText.UseMnemonic = false;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(12, 254);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(206, 124);
            listBox2.TabIndex = 36;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(12, 73);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(206, 124);
            listBox3.TabIndex = 34;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(206, 124);
            listBox1.TabIndex = 35;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 24);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 23);
            comboBox1.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 6);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 49;
            label3.Text = "Операторы";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.UseMnemonic = false;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(button7);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(launchText);
            Controls.Add(listBox2);
            Controls.Add(listBox3);
            Controls.Add(listBox1);
            Name = "ProfileForm";
            Text = "Данные профиля";
            FormClosed += ProfileForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Button button1;
        private Button button7;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label launchText;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private Label label3;
    }
}