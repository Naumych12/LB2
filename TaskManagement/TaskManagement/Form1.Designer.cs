namespace TaskManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            employeesListView = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            tasksListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            projectsListView = new ListView();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            addBtn = new Button();
            delBtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // employeesListView
            // 
            employeesListView.Activation = ItemActivation.TwoClick;
            employeesListView.BackColor = Color.FromArgb(88, 158, 227);
            employeesListView.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader2, columnHeader4, columnHeader5 });
            employeesListView.FullRowSelect = true;
            employeesListView.Location = new Point(21, 491);
            employeesListView.Name = "employeesListView";
            employeesListView.Size = new Size(454, 242);
            employeesListView.TabIndex = 24;
            employeesListView.UseCompatibleStateImageBehavior = false;
            employeesListView.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Width = 0;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Email";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Phone";
            columnHeader5.Width = 150;
            // 
            // tasksListView
            // 
            tasksListView.Activation = ItemActivation.TwoClick;
            tasksListView.BackColor = Color.FromArgb(88, 158, 227);
            tasksListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            tasksListView.FullRowSelect = true;
            tasksListView.Location = new Point(218, 76);
            tasksListView.Name = "tasksListView";
            tasksListView.Size = new Size(754, 346);
            tasksListView.TabIndex = 25;
            tasksListView.UseCompatibleStateImageBehavior = false;
            tasksListView.View = View.Details;
            tasksListView.ItemActivate += tasksListView_ItemActivate;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 0;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Summary";
            columnHeader3.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Description";
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Priority";
            columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Employee";
            columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Project";
            columnHeader10.Width = 150;
            // 
            // projectsListView
            // 
            projectsListView.Activation = ItemActivation.TwoClick;
            projectsListView.BackColor = Color.FromArgb(88, 158, 227);
            projectsListView.Columns.AddRange(new ColumnHeader[] { columnHeader11, columnHeader12, columnHeader13, columnHeader14 });
            projectsListView.FullRowSelect = true;
            projectsListView.Location = new Point(516, 491);
            projectsListView.Name = "projectsListView";
            projectsListView.Size = new Size(456, 242);
            projectsListView.TabIndex = 26;
            projectsListView.UseCompatibleStateImageBehavior = false;
            projectsListView.View = View.Details;
            // 
            // columnHeader11
            // 
            columnHeader11.Width = 0;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Name";
            columnHeader12.Width = 150;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Client";
            columnHeader13.Width = 150;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Budget";
            columnHeader14.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(570, 36);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 27;
            label1.Text = "Tasks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(191, 451);
            label2.Name = "label2";
            label2.Size = new Size(120, 28);
            label2.TabIndex = 28;
            label2.Text = "Employees";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(694, 451);
            label3.Name = "label3";
            label3.Size = new Size(95, 28);
            label3.TabIndex = 29;
            label3.Text = "Projects";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(12, 100, 228);
            addBtn.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.ForeColor = SystemColors.ButtonFace;
            addBtn.Location = new Point(21, 76);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(182, 57);
            addBtn.TabIndex = 30;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // delBtn
            // 
            delBtn.BackColor = Color.FromArgb(12, 100, 228);
            delBtn.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            delBtn.ForeColor = SystemColors.ButtonFace;
            delBtn.Location = new Point(21, 150);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(182, 57);
            delBtn.TabIndex = 31;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = false;
            delBtn.Click += delBtn_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(21, 228);
            button1.Name = "button1";
            button1.Size = new Size(182, 194);
            button1.TabIndex = 32;
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 750);
            Controls.Add(button1);
            Controls.Add(delBtn);
            Controls.Add(addBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(projectsListView);
            Controls.Add(tasksListView);
            Controls.Add(employeesListView);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView employeesListView;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ListView tasksListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ListView projectsListView;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button addBtn;
        private Button delBtn;
        private Button button1;
    }
}