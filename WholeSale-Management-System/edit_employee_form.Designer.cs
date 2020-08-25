namespace WholeSale_Management_System
{
    partial class edit_employee_form
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
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.contact_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cnic_box = new System.Windows.Forms.TextBox();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.id_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.employee_table = new System.Windows.Forms.DataGridView();
            this.employeeID_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeename_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnic_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_button = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.salary_box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.address_box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.email_box = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.designation_box = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.employee_table)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.delete_button.FlatAppearance.BorderSize = 0;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.ForeColor = System.Drawing.Color.White;
            this.delete_button.Location = new System.Drawing.Point(495, 481);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(101, 35);
            this.delete_button.TabIndex = 15;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.edit_button.FlatAppearance.BorderSize = 0;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.ForeColor = System.Drawing.Color.White;
            this.edit_button.Location = new System.Drawing.Point(387, 481);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(101, 35);
            this.edit_button.TabIndex = 14;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(303, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Contact";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // contact_box
            // 
            this.contact_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_box.ForeColor = System.Drawing.Color.Black;
            this.contact_box.Location = new System.Drawing.Point(387, 301);
            this.contact_box.Name = "contact_box";
            this.contact_box.Size = new System.Drawing.Size(209, 29);
            this.contact_box.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(325, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "CNIC";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(291, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(275, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "User Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(307, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "User ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cnic_box
            // 
            this.cnic_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnic_box.ForeColor = System.Drawing.Color.Black;
            this.cnic_box.Location = new System.Drawing.Point(387, 268);
            this.cnic_box.Name = "cnic_box";
            this.cnic_box.Size = new System.Drawing.Size(209, 29);
            this.cnic_box.TabIndex = 4;
            // 
            // pass_box
            // 
            this.pass_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_box.ForeColor = System.Drawing.Color.Black;
            this.pass_box.Location = new System.Drawing.Point(387, 235);
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(209, 29);
            this.pass_box.TabIndex = 3;
            // 
            // name_box
            // 
            this.name_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_box.ForeColor = System.Drawing.Color.Black;
            this.name_box.Location = new System.Drawing.Point(387, 202);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(209, 29);
            this.name_box.TabIndex = 2;
            // 
            // id_box
            // 
            this.id_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_box.ForeColor = System.Drawing.Color.Black;
            this.id_box.Location = new System.Drawing.Point(387, 169);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(209, 29);
            this.id_box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(52, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 35);
            this.label1.TabIndex = 28;
            this.label1.Text = "Edit Users";
            // 
            // employee_table
            // 
            this.employee_table.AllowUserToAddRows = false;
            this.employee_table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            this.employee_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeID_Col,
            this.employeename_col,
            this.pass_col,
            this.cnic_col,
            this.contact_col,
            this.salary_col,
            this.address_col,
            this.email_col,
            this.designation_col});
            this.employee_table.Location = new System.Drawing.Point(613, 168);
            this.employee_table.Name = "employee_table";
            this.employee_table.Size = new System.Drawing.Size(567, 307);
            this.employee_table.TabIndex = 31;
            this.employee_table.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.employee_table_CellEnter);
            // 
            // employeeID_Col
            // 
            this.employeeID_Col.HeaderText = "User ID";
            this.employeeID_Col.Name = "employeeID_Col";
            this.employeeID_Col.Width = 70;
            // 
            // employeename_col
            // 
            this.employeename_col.HeaderText = "User Name";
            this.employeename_col.Name = "employeename_col";
            // 
            // pass_col
            // 
            this.pass_col.HeaderText = "Password";
            this.pass_col.Name = "pass_col";
            this.pass_col.Width = 70;
            // 
            // cnic_col
            // 
            this.cnic_col.HeaderText = "CNIC";
            this.cnic_col.Name = "cnic_col";
            this.cnic_col.Width = 80;
            // 
            // contact_col
            // 
            this.contact_col.HeaderText = "Contact";
            this.contact_col.Name = "contact_col";
            // 
            // salary_col
            // 
            this.salary_col.HeaderText = "Salary";
            this.salary_col.Name = "salary_col";
            // 
            // address_col
            // 
            this.address_col.HeaderText = "Address";
            this.address_col.Name = "address_col";
            // 
            // email_col
            // 
            this.email_col.HeaderText = "Email";
            this.email_col.Name = "email_col";
            // 
            // designation_col
            // 
            this.designation_col.HeaderText = "Designation";
            this.designation_col.Name = "designation_col";
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.search_button.FlatAppearance.BorderSize = 0;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.ForeColor = System.Drawing.Color.White;
            this.search_button.Location = new System.Drawing.Point(1092, 135);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(88, 27);
            this.search_button.TabIndex = 1;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // search_box
            // 
            this.search_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box.ForeColor = System.Drawing.Color.Black;
            this.search_box.Location = new System.Drawing.Point(862, 135);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(224, 29);
            this.search_box.TabIndex = 0;
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // back_button
            // 
            this.back_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.back_button.FlatAppearance.BorderSize = 2;
            this.back_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(387, 522);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(209, 35);
            this.back_button.TabIndex = 16;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(317, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "Salary";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // salary_box
            // 
            this.salary_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_box.ForeColor = System.Drawing.Color.Black;
            this.salary_box.Location = new System.Drawing.Point(387, 334);
            this.salary_box.Name = "salary_box";
            this.salary_box.Size = new System.Drawing.Size(209, 29);
            this.salary_box.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(302, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 35;
            this.label8.Text = "Address";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // address_box
            // 
            this.address_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_box.ForeColor = System.Drawing.Color.Black;
            this.address_box.Location = new System.Drawing.Point(387, 367);
            this.address_box.Name = "address_box";
            this.address_box.Size = new System.Drawing.Size(209, 29);
            this.address_box.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(250, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 25);
            this.label9.TabIndex = 37;
            this.label9.Text = "Email Address";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // email_box
            // 
            this.email_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_box.ForeColor = System.Drawing.Color.Black;
            this.email_box.Location = new System.Drawing.Point(387, 400);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(209, 29);
            this.email_box.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(267, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 25);
            this.label10.TabIndex = 39;
            this.label10.Text = "Designation";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // designation_box
            // 
            this.designation_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designation_box.ForeColor = System.Drawing.Color.Black;
            this.designation_box.FormattingEnabled = true;
            this.designation_box.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.designation_box.Location = new System.Drawing.Point(387, 434);
            this.designation_box.Name = "designation_box";
            this.designation_box.Size = new System.Drawing.Size(209, 29);
            this.designation_box.TabIndex = 10;
            // 
            // edit_employee_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1350, 699);
            this.Controls.Add(this.designation_box);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.address_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.salary_box);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.employee_table);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.contact_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cnic_box);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.id_box);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.Name = "edit_employee_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Users";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.employee_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox contact_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cnic_box;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView employee_table;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox salary_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox address_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox designation_box;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeename_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnic_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation_col;
    }
}