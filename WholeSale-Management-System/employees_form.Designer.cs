namespace WholeSale_Management_System
{
    partial class employees_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.search_box = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.new_button = new System.Windows.Forms.Button();
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
            this.edit_button = new System.Windows.Forms.Button();
            this.back_button = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.employee_table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(245, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users";
            // 
            // search_box
            // 
            this.search_box.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box.Location = new System.Drawing.Point(252, 155);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(389, 29);
            this.search_box.TabIndex = 1;
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.search_button.FlatAppearance.BorderSize = 0;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.ForeColor = System.Drawing.Color.White;
            this.search_button.Location = new System.Drawing.Point(647, 153);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(88, 31);
            this.search_button.TabIndex = 2;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // new_button
            // 
            this.new_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(132)))), ((int)(((byte)(110)))));
            this.new_button.FlatAppearance.BorderSize = 0;
            this.new_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_button.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_button.ForeColor = System.Drawing.Color.White;
            this.new_button.Location = new System.Drawing.Point(869, 153);
            this.new_button.Name = "new_button";
            this.new_button.Size = new System.Drawing.Size(88, 31);
            this.new_button.TabIndex = 3;
            this.new_button.Text = "New +";
            this.new_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.new_button.UseVisualStyleBackColor = false;
            this.new_button.Click += new System.EventHandler(this.new_button_Click);
            // 
            // employee_table
            // 
            this.employee_table.AllowUserToAddRows = false;
            this.employee_table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employee_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.employee_table.Location = new System.Drawing.Point(252, 190);
            this.employee_table.Name = "employee_table";
            this.employee_table.Size = new System.Drawing.Size(847, 241);
            this.employee_table.TabIndex = 5;
            // 
            // employeeID_Col
            // 
            this.employeeID_Col.HeaderText = "User ID";
            this.employeeID_Col.Name = "employeeID_Col";
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
            // 
            // cnic_col
            // 
            this.cnic_col.HeaderText = "CNIC";
            this.cnic_col.Name = "cnic_col";
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
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.edit_button.FlatAppearance.BorderSize = 0;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.ForeColor = System.Drawing.Color.White;
            this.edit_button.Location = new System.Drawing.Point(963, 153);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(136, 31);
            this.edit_button.TabIndex = 4;
            this.edit_button.Text = "Edit/ Delete";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // back_button
            // 
            this.back_button.BorderColor = System.Drawing.Color.Silver;
            this.back_button.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            this.back_button.FlatAppearance.BorderSize = 0;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(979, 453);
            this.back_button.Name = "back_button";
            this.back_button.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.back_button.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.back_button.OnHoverTextColor = System.Drawing.Color.White;
            this.back_button.Size = new System.Drawing.Size(120, 44);
            this.back_button.TabIndex = 7;
            this.back_button.Text = "Back";
            this.back_button.TextColor = System.Drawing.Color.White;
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click_1);
            // 
            // employees_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1350, 522);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.employee_table);
            this.Controls.Add(this.new_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.Name = "employees_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.employee_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button new_button;
        private System.Windows.Forms.DataGridView employee_table;
        private System.Windows.Forms.Button edit_button;
        private ePOSOne.btnProduct.Button_WOC back_button;
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