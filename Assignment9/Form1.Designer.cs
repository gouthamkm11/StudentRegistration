namespace Assignment9
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.initializeDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addDepartmentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computerScienceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.computerEngineeringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.electricalEngineeringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.technologyManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initializeDBToolStripMenuItem,
            this.studentManagementToolStripMenuItem,
            this.registrationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // initializeDBToolStripMenuItem
            // 
            this.initializeDBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addDepartmentDetailsToolStripMenuItem});
            this.initializeDBToolStripMenuItem.Name = "initializeDBToolStripMenuItem";
            this.initializeDBToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.initializeDBToolStripMenuItem.Text = "Initialize DB";
            // 
            // addStudentDetailsToolStripMenuItem
            // 
            this.addStudentDetailsToolStripMenuItem.Name = "addStudentDetailsToolStripMenuItem";
            this.addStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.addStudentDetailsToolStripMenuItem.Text = "Add Student Details";
            this.addStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.addStudentDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(197, 6);
            // 
            // addDepartmentDetailsToolStripMenuItem
            // 
            this.addDepartmentDetailsToolStripMenuItem.Name = "addDepartmentDetailsToolStripMenuItem";
            this.addDepartmentDetailsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.addDepartmentDetailsToolStripMenuItem.Text = "Add Department Details";
            this.addDepartmentDetailsToolStripMenuItem.Click += new System.EventHandler(this.addDepartmentDetailsToolStripMenuItem_Click);
            // 
            // studentManagementToolStripMenuItem
            // 
            this.studentManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentsToolStripMenuItem});
            this.studentManagementToolStripMenuItem.Name = "studentManagementToolStripMenuItem";
            this.studentManagementToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.studentManagementToolStripMenuItem.Text = "Student Management";
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computerScienceToolStripMenuItem,
            this.toolStripMenuItem2,
            this.computerEngineeringToolStripMenuItem,
            this.toolStripMenuItem3,
            this.electricalEngineeringToolStripMenuItem,
            this.toolStripMenuItem4,
            this.mathToolStripMenuItem,
            this.toolStripMenuItem5,
            this.technologyManagementToolStripMenuItem});
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.departmentsToolStripMenuItem.Text = "Departments";
            // 
            // computerScienceToolStripMenuItem
            // 
            this.computerScienceToolStripMenuItem.Name = "computerScienceToolStripMenuItem";
            this.computerScienceToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.computerScienceToolStripMenuItem.Text = "Computer Science";
            this.computerScienceToolStripMenuItem.Click += new System.EventHandler(this.computerScienceToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(208, 6);
            // 
            // computerEngineeringToolStripMenuItem
            // 
            this.computerEngineeringToolStripMenuItem.Name = "computerEngineeringToolStripMenuItem";
            this.computerEngineeringToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.computerEngineeringToolStripMenuItem.Text = "Computer Engineering";
            this.computerEngineeringToolStripMenuItem.Click += new System.EventHandler(this.computerEngineeringToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(208, 6);
            // 
            // electricalEngineeringToolStripMenuItem
            // 
            this.electricalEngineeringToolStripMenuItem.Name = "electricalEngineeringToolStripMenuItem";
            this.electricalEngineeringToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.electricalEngineeringToolStripMenuItem.Text = "Electrical Engineering";
            this.electricalEngineeringToolStripMenuItem.Click += new System.EventHandler(this.electricalEngineeringToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(208, 6);
            // 
            // mathToolStripMenuItem
            // 
            this.mathToolStripMenuItem.Name = "mathToolStripMenuItem";
            this.mathToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.mathToolStripMenuItem.Text = "Math";
            this.mathToolStripMenuItem.Click += new System.EventHandler(this.mathToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(208, 6);
            // 
            // technologyManagementToolStripMenuItem
            // 
            this.technologyManagementToolStripMenuItem.Name = "technologyManagementToolStripMenuItem";
            this.technologyManagementToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.technologyManagementToolStripMenuItem.Text = "Technology Management";
            this.technologyManagementToolStripMenuItem.Click += new System.EventHandler(this.technologyManagementToolStripMenuItem_Click);
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem});
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.registrationToolStripMenuItem.Text = "Registration";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 210);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 299);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Student Management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem initializeDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addDepartmentDetailsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem studentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computerScienceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem computerEngineeringToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem electricalEngineeringToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mathToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem technologyManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
    }
}

