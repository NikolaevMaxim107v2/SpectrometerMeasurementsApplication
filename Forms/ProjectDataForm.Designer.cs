namespace SpectrometerMeasurementsApplication
{
    partial class ProjectDataForm
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
            groupBox1 = new GroupBox();
            button3 = new Button();
            textBoxProjectCustomer = new TextBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            textBoxProjectDateEnd = new TextBox();
            textBoxProjectDateAccept = new TextBox();
            textBoxProjectName = new TextBox();
            button7 = new Button();
            textBoxProjectID = new TextBox();
            button1 = new Button();
            buttonChange = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(textBoxProjectCustomer);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBoxProjectDateEnd);
            groupBox1.Controls.Add(textBoxProjectDateAccept);
            groupBox1.Controls.Add(textBoxProjectName);
            groupBox1.Location = new Point(212, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(377, 349);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Проект ________________________________";
            // 
            // button3
            // 
            button3.Location = new Point(27, 310);
            button3.Name = "button3";
            button3.Size = new Size(148, 25);
            button3.TabIndex = 31;
            button3.Text = "Отменить изменения";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // textBoxProjectCustomer
            // 
            textBoxProjectCustomer.Location = new Point(27, 140);
            textBoxProjectCustomer.Name = "textBoxProjectCustomer";
            textBoxProjectCustomer.ReadOnly = true;
            textBoxProjectCustomer.Size = new Size(308, 23);
            textBoxProjectCustomer.TabIndex = 30;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(27, 184);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(308, 23);
            comboBox1.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(144, 253);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 28;
            label6.Text = "Дата конца";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(141, 209);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 27;
            label5.Text = "Дата начала";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 166);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 26;
            label4.Text = "Площади";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 122);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 25;
            label3.Text = "Заказчик";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 79);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 24;
            label2.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 35);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 23;
            label1.Text = "ID проекта";
            // 
            // button2
            // 
            button2.Location = new Point(187, 310);
            button2.Name = "button2";
            button2.Size = new Size(148, 25);
            button2.TabIndex = 21;
            button2.Text = "Подтвердить изменения";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // textBoxProjectDateEnd
            // 
            textBoxProjectDateEnd.Location = new Point(27, 271);
            textBoxProjectDateEnd.Name = "textBoxProjectDateEnd";
            textBoxProjectDateEnd.ReadOnly = true;
            textBoxProjectDateEnd.Size = new Size(308, 23);
            textBoxProjectDateEnd.TabIndex = 22;
            // 
            // textBoxProjectDateAccept
            // 
            textBoxProjectDateAccept.Location = new Point(27, 227);
            textBoxProjectDateAccept.Name = "textBoxProjectDateAccept";
            textBoxProjectDateAccept.ReadOnly = true;
            textBoxProjectDateAccept.Size = new Size(308, 23);
            textBoxProjectDateAccept.TabIndex = 20;
            // 
            // textBoxProjectName
            // 
            textBoxProjectName.Location = new Point(27, 97);
            textBoxProjectName.Name = "textBoxProjectName";
            textBoxProjectName.ReadOnly = true;
            textBoxProjectName.Size = new Size(308, 23);
            textBoxProjectName.TabIndex = 19;
            // 
            // button7
            // 
            button7.Location = new Point(461, 381);
            button7.Name = "button7";
            button7.Size = new Size(134, 34);
            button7.TabIndex = 17;
            button7.Text = "Перейти к площадям";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBoxProjectID
            // 
            textBoxProjectID.Location = new Point(239, 65);
            textBoxProjectID.Name = "textBoxProjectID";
            textBoxProjectID.ReadOnly = true;
            textBoxProjectID.Size = new Size(308, 23);
            textBoxProjectID.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(210, 381);
            button1.Name = "button1";
            button1.Size = new Size(113, 34);
            button1.TabIndex = 19;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonChange
            // 
            buttonChange.Location = new Point(330, 381);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new Size(125, 34);
            buttonChange.TabIndex = 20;
            buttonChange.Text = "Изменить";
            buttonChange.UseVisualStyleBackColor = true;
            buttonChange.Click += buttonChange_Click;
            // 
            // ProjectDataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonChange);
            Controls.Add(button1);
            Controls.Add(textBoxProjectID);
            Controls.Add(button7);
            Controls.Add(groupBox1);
            Name = "ProjectDataForm";
            Text = "Данные проекта";
            FormClosed += ProjectDataForm_FormClosed;
            Load += ProjectDataForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button7;
        private TextBox textBoxProjectDateEnd;
        private TextBox textBoxProjectDateAccept;
        private TextBox textBoxProjectName;
        private TextBox textBoxProjectID;
        private Button button1;
        private Button buttonChange;
        private Button button2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBoxProjectCustomer;
        private Button button3;
    }
}