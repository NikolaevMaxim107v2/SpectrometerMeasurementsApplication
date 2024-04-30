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
            textBoxProjectDateEnd = new TextBox();
            textBoxProjectDateAccept = new TextBox();
            textBoxProjectArea = new TextBox();
            textBoxProjectCustomer = new TextBox();
            textBoxProjectName = new TextBox();
            button7 = new Button();
            textBoxProjectID = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxProjectDateEnd);
            groupBox1.Controls.Add(textBoxProjectDateAccept);
            groupBox1.Controls.Add(textBoxProjectArea);
            groupBox1.Controls.Add(textBoxProjectCustomer);
            groupBox1.Controls.Add(textBoxProjectName);
            groupBox1.Location = new Point(212, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(377, 349);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Проект ________________________________";
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
            textBoxProjectDateAccept.Location = new Point(27, 232);
            textBoxProjectDateAccept.Name = "textBoxProjectDateAccept";
            textBoxProjectDateAccept.ReadOnly = true;
            textBoxProjectDateAccept.Size = new Size(308, 23);
            textBoxProjectDateAccept.TabIndex = 20;
            // 
            // textBoxProjectArea
            // 
            textBoxProjectArea.Location = new Point(27, 189);
            textBoxProjectArea.Name = "textBoxProjectArea";
            textBoxProjectArea.ReadOnly = true;
            textBoxProjectArea.Size = new Size(308, 23);
            textBoxProjectArea.TabIndex = 21;
            // 
            // textBoxProjectCustomer
            // 
            textBoxProjectCustomer.Location = new Point(27, 146);
            textBoxProjectCustomer.Name = "textBoxProjectCustomer";
            textBoxProjectCustomer.ReadOnly = true;
            textBoxProjectCustomer.Size = new Size(308, 23);
            textBoxProjectCustomer.TabIndex = 20;
            // 
            // textBoxProjectName
            // 
            textBoxProjectName.Location = new Point(27, 106);
            textBoxProjectName.Name = "textBoxProjectName";
            textBoxProjectName.ReadOnly = true;
            textBoxProjectName.Size = new Size(308, 23);
            textBoxProjectName.TabIndex = 19;
            // 
            // button7
            // 
            button7.Location = new Point(290, 381);
            button7.Name = "button7";
            button7.Size = new Size(299, 34);
            button7.TabIndex = 17;
            button7.Text = "Перейти к площади";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBoxProjectID
            // 
            textBoxProjectID.Location = new Point(239, 75);
            textBoxProjectID.Name = "textBoxProjectID";
            textBoxProjectID.ReadOnly = true;
            textBoxProjectID.Size = new Size(308, 23);
            textBoxProjectID.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(212, 381);
            button1.Name = "button1";
            button1.Size = new Size(72, 34);
            button1.TabIndex = 19;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ProjectDataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private TextBox textBoxProjectArea;
        private TextBox textBoxProjectCustomer;
        private TextBox textBoxProjectName;
        private TextBox textBoxProjectID;
        private Button button1;
    }
}