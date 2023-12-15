namespace TaskManagement
{
    partial class IssueForm
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
            saveBtn = new Button();
            label1 = new Label();
            this.summaryTb = new TextBox();
            this.descriptionTb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            priorityTb = new TextBox();
            label5 = new Label();
            projectsCb = new ComboBox();
            employeesCb = new ComboBox();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(12, 100, 228);
            saveBtn.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.ForeColor = SystemColors.ButtonFace;
            saveBtn.Location = new Point(12, 346);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(696, 57);
            saveBtn.TabIndex = 31;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(131, 41);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 32;
            label1.Text = "Summary";
            // 
            // summaryTb
            // 
            this.summaryTb.Location = new Point(12, 81);
            this.summaryTb.Name = "summaryTb";
            this.summaryTb.Size = new Size(334, 27);
            this.summaryTb.TabIndex = 33;
            // 
            // descriptionTb
            // 
            this.descriptionTb.Location = new Point(12, 174);
            this.descriptionTb.Multiline = true;
            this.descriptionTb.Name = "descriptionTb";
            this.descriptionTb.Size = new Size(334, 126);
            this.descriptionTb.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(119, 132);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 34;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(493, 41);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 36;
            label3.Text = "Project";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(484, 133);
            label4.Name = "label4";
            label4.Size = new Size(111, 28);
            label4.TabIndex = 38;
            label4.Text = "Employee";
            // 
            // priorityTb
            // 
            priorityTb.Location = new Point(374, 273);
            priorityTb.Name = "priorityTb";
            priorityTb.Size = new Size(334, 27);
            priorityTb.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(493, 233);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 40;
            label5.Text = "Priority";
            // 
            // projectsCb
            // 
            projectsCb.FormattingEnabled = true;
            projectsCb.Location = new Point(374, 81);
            projectsCb.Name = "projectsCb";
            projectsCb.Size = new Size(334, 28);
            projectsCb.TabIndex = 42;
            // 
            // employeesCb
            // 
            employeesCb.FormattingEnabled = true;
            employeesCb.Location = new Point(374, 174);
            employeesCb.Name = "employeesCb";
            employeesCb.Size = new Size(334, 28);
            employeesCb.TabIndex = 43;
            // 
            // IssueForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 416);
            Controls.Add(employeesCb);
            Controls.Add(projectsCb);
            Controls.Add(priorityTb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(this.descriptionTb);
            Controls.Add(label2);
            Controls.Add(this.summaryTb);
            Controls.Add(label1);
            Controls.Add(saveBtn);
            Name = "IssueForm";
            Text = "IssueForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveBtn;
        private Label label1;
        private TextBox summaryTb;
        private TextBox descriptionTb;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox priorityTb;
        private Label label5;
        private ComboBox projectsCb;
        private ComboBox employeesCb;
    }
}