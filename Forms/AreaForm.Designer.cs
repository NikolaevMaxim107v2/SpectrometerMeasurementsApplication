﻿namespace SpectrometerMeasurementsApplication
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
            launchText = new Label();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            button6 = new Button();
            label2 = new Label();
            button7 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // launchText
            // 
            launchText.AutoSize = true;
            launchText.Location = new Point(85, 70);
            launchText.Name = "launchText";
            launchText.Size = new Size(59, 15);
            launchText.TabIndex = 22;
            launchText.Text = "Площадь";
            launchText.TextAlign = ContentAlignment.TopCenter;
            launchText.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 256);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 23;
            label1.Text = "Профили";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            // 
            // button3
            // 
            button3.Location = new Point(116, 303);
            button3.Name = "button3";
            button3.Size = new Size(102, 26);
            button3.TabIndex = 27;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 303);
            button4.Name = "button4";
            button4.Size = new Size(102, 26);
            button4.TabIndex = 26;
            button4.Text = "Добавить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
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
            button1.Location = new Point(116, 188);
            button1.Name = "button1";
            button1.Size = new Size(102, 26);
            button1.TabIndex = 30;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 188);
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
            button6.Location = new Point(12, 12);
            button6.Name = "button6";
            button6.Size = new Size(206, 29);
            button6.TabIndex = 32;
            button6.Text = "Назад";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 141);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 22;
            label2.Text = "Точки площади";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.UseMnemonic = false;
            // 
            // button7
            // 
            button7.Location = new Point(12, 188);
            button7.Name = "button7";
            button7.Size = new Size(102, 26);
            button7.TabIndex = 29;
            button7.Text = "Добавить";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 23);
            comboBox1.TabIndex = 33;
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 159);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(206, 23);
            comboBox2.TabIndex = 34;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(12, 274);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(206, 23);
            comboBox3.TabIndex = 35;
            // 
            // AreaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
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
            Name = "AreaForm";
            Text = "Данные площади";
            FormClosed += AreaForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label launchText;
        private Label label1;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button5;
        private Button button6;
        private Label label2;
        private Button button7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}