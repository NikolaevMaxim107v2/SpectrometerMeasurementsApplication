﻿namespace SpectrometerMeasurementsApplication.Forms
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
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(121, 71);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Введите название проекта...";
            textBoxName.RightToLeft = RightToLeft.No;
            textBoxName.Size = new Size(289, 27);
            textBoxName.TabIndex = 8;
            // 
            // launchText
            // 
            launchText.AutoSize = true;
            launchText.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            launchText.Location = new Point(152, 24);
            launchText.Name = "launchText";
            launchText.Size = new Size(175, 23);
            launchText.TabIndex = 7;
            launchText.Text = "Добавление проекта";
            launchText.TextAlign = ContentAlignment.TopCenter;
            launchText.UseMnemonic = false;
            // 
            // button1
            // 
            button1.Location = new Point(82, 160);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(289, 29);
            button1.TabIndex = 6;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 71);
            label1.Name = "label1";
            label1.Size = new Size(90, 23);
            label1.TabIndex = 9;
            label1.Text = "Название:";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 109);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 11;
            label2.Text = "Заказчик:";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.UseMnemonic = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(121, 109);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(290, 28);
            comboBox1.TabIndex = 21;
            // 
            // AddProjectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 220);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(launchText);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
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
        private ComboBox comboBox1;
    }
}