﻿namespace SpectrometerMeasurementsApplication
{
    partial class MainForm
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
            listView1 = new ListView();
            button1 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            comboBox2 = new ComboBox();
            launchText = new Label();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            textBoxArea = new TextBox();
            textBoxCustomer = new TextBox();
            button6 = new Button();
            textBoxUser = new TextBox();
            groupBox1 = new GroupBox();
            button7 = new Button();
            button8 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(402, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(384, 387);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(402, 404);
            button1.Name = "button1";
            button1.Size = new Size(384, 34);
            button1.TabIndex = 1;
            button1.Text = "Перейти к выбранному проекту";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(377, 23);
            comboBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(12, 155);
            button2.Name = "button2";
            button2.Size = new Size(178, 34);
            button2.TabIndex = 4;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(211, 154);
            button3.Name = "button3";
            button3.Size = new Size(178, 34);
            button3.TabIndex = 5;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 224);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(377, 23);
            comboBox2.TabIndex = 6;
            // 
            // launchText
            // 
            launchText.AutoSize = true;
            launchText.Location = new Point(144, 68);
            launchText.Name = "launchText";
            launchText.Size = new Size(112, 15);
            launchText.TabIndex = 7;
            launchText.Text = "Список заказчиков";
            launchText.TextAlign = ContentAlignment.TopCenter;
            launchText.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 205);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 8;
            label1.Text = "Список площадей";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            // 
            // button4
            // 
            button4.Location = new Point(211, 287);
            button4.Name = "button4";
            button4.Size = new Size(178, 34);
            button4.TabIndex = 10;
            button4.Text = "Удалить";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(12, 288);
            button5.Name = "button5";
            button5.Size = new Size(178, 34);
            button5.TabIndex = 9;
            button5.Text = "Добавить";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBoxArea
            // 
            textBoxArea.Location = new Point(12, 253);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.ReadOnly = true;
            textBoxArea.Size = new Size(376, 23);
            textBoxArea.TabIndex = 11;
            // 
            // textBoxCustomer
            // 
            textBoxCustomer.Location = new Point(12, 119);
            textBoxCustomer.Name = "textBoxCustomer";
            textBoxCustomer.ReadOnly = true;
            textBoxCustomer.Size = new Size(376, 23);
            textBoxCustomer.TabIndex = 12;
            // 
            // button6
            // 
            button6.Location = new Point(12, 18);
            button6.Name = "button6";
            button6.Size = new Size(150, 34);
            button6.TabIndex = 13;
            button6.Text = "Выйти из аккаунта";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(168, 19);
            textBoxUser.Multiline = true;
            textBoxUser.Name = "textBoxUser";
            textBoxUser.ReadOnly = true;
            textBoxUser.Size = new Size(220, 33);
            textBoxUser.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button8);
            groupBox1.Location = new Point(11, 338);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(377, 100);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Проекты";
            // 
            // button7
            // 
            button7.Location = new Point(208, 36);
            button7.Name = "button7";
            button7.Size = new Size(160, 34);
            button7.TabIndex = 17;
            button7.Text = "Удалить";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(9, 37);
            button8.Name = "button8";
            button8.Size = new Size(160, 34);
            button8.TabIndex = 16;
            button8.Text = "Добавить";
            button8.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(textBoxUser);
            Controls.Add(button6);
            Controls.Add(textBoxCustomer);
            Controls.Add(textBoxArea);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(launchText);
            Controls.Add(comboBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "MainForm";
            Text = "Основное окно";
            FormClosed += MainForm_FormClosed;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
        private ComboBox comboBox2;
        private Label launchText;
        private Label label1;
        private Button button4;
        private Button button5;
        private TextBox textBoxArea;
        private TextBox textBoxCustomer;
        private Button button6;
        private TextBox textBoxUser;
        private GroupBox groupBox1;
        private Button button7;
        private Button button8;
    }
}