namespace SpectrometerMeasurementsApplication
{
    partial class AreaForm
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
            textBoxAreaName = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            launchText = new Label();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            button6 = new Button();
            listBox3 = new ListBox();
            label2 = new Label();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxAreaName
            // 
            textBoxAreaName.Location = new Point(12, 12);
            textBoxAreaName.Name = "textBoxAreaName";
            textBoxAreaName.ReadOnly = true;
            textBoxAreaName.Size = new Size(206, 23);
            textBoxAreaName.TabIndex = 19;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 68);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(206, 124);
            listBox1.TabIndex = 20;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(12, 249);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(206, 124);
            listBox2.TabIndex = 21;
            // 
            // launchText
            // 
            launchText.AutoSize = true;
            launchText.Location = new Point(65, 50);
            launchText.Name = "launchText";
            launchText.Size = new Size(94, 15);
            launchText.TabIndex = 22;
            launchText.Text = "Точки площади";
            launchText.TextAlign = ContentAlignment.TopCenter;
            launchText.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 231);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 23;
            label1.Text = "Профили";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            // 
            // button3
            // 
            button3.Location = new Point(116, 379);
            button3.Name = "button3";
            button3.Size = new Size(102, 26);
            button3.TabIndex = 27;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 379);
            button4.Name = "button4";
            button4.Size = new Size(102, 26);
            button4.TabIndex = 26;
            button4.Text = "Добавить";
            button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(258, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(530, 380);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(116, 198);
            button1.Name = "button1";
            button1.Size = new Size(102, 26);
            button1.TabIndex = 30;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 198);
            button2.Name = "button2";
            button2.Size = new Size(102, 26);
            button2.TabIndex = 29;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(258, 403);
            button5.Name = "button5";
            button5.Size = new Size(530, 31);
            button5.TabIndex = 31;
            button5.Text = "Перейти к выбранному профилю";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 419);
            button6.Name = "button6";
            button6.Size = new Size(206, 24);
            button6.TabIndex = 32;
            button6.Text = "Назад";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(12, 68);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(206, 124);
            listBox3.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 50);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 22;
            label2.Text = "Точки площади";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.UseMnemonic = false;
            // 
            // button7
            // 
            button7.Location = new Point(12, 198);
            button7.Name = "button7";
            button7.Size = new Size(102, 26);
            button7.TabIndex = 29;
            button7.Text = "Добавить";
            button7.UseVisualStyleBackColor = true;
            // 
            // AreaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(button7);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(launchText);
            Controls.Add(listBox2);
            Controls.Add(listBox3);
            Controls.Add(listBox1);
            Controls.Add(textBoxAreaName);
            Name = "AreaForm";
            Text = "Данные площади";
            FormClosed += AreaForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAreaName;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label launchText;
        private Label label1;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button5;
        private Button button6;
        private ListBox listBox3;
        private Label label2;
        private Button button7;
    }
}