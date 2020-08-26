namespace WholeSale_Management_System
{
    partial class company
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.search_box = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.new_button = new System.Windows.Forms.Button();
            this.company_table = new System.Windows.Forms.DataGridView();
            this.company_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactno_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit_button = new System.Windows.Forms.Button();
            this.back_button = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.company_table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(74, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMPANIES";
            // 
            // search_box
            // 
            this.search_box.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box.Location = new System.Drawing.Point(332, 132);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(289, 29);
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
            this.search_button.Location = new System.Drawing.Point(627, 130);
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
            this.new_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_button.ForeColor = System.Drawing.Color.White;
            this.new_button.Location = new System.Drawing.Point(773, 129);
            this.new_button.Name = "new_button";
            this.new_button.Size = new System.Drawing.Size(88, 31);
            this.new_button.TabIndex = 3;
            this.new_button.Text = "New +";
            this.new_button.UseVisualStyleBackColor = false;
            this.new_button.Click += new System.EventHandler(this.new_button_Click);
            // 
            // company_table
            // 
            this.company_table.AllowUserToAddRows = false;
            this.company_table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.company_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.company_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.company_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.company_col,
            this.supplier_col,
            this.contactno_col,
            this.email_col});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.company_table.DefaultCellStyle = dataGridViewCellStyle2;
            this.company_table.Location = new System.Drawing.Point(332, 166);
            this.company_table.Name = "company_table";
            this.company_table.Size = new System.Drawing.Size(671, 437);
            this.company_table.TabIndex = 5;
            // 
            // company_col
            // 
            this.company_col.HeaderText = "Company Name";
            this.company_col.Name = "company_col";
            this.company_col.Width = 200;
            // 
            // supplier_col
            // 
            this.supplier_col.HeaderText = "Supplier Name";
            this.supplier_col.Name = "supplier_col";
            this.supplier_col.Width = 160;
            // 
            // contactno_col
            // 
            this.contactno_col.HeaderText = "Contact No";
            this.contactno_col.Name = "contactno_col";
            this.contactno_col.Width = 120;
            // 
            // email_col
            // 
            this.email_col.HeaderText = "Email Address";
            this.email_col.Name = "email_col";
            this.email_col.Width = 150;
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.edit_button.FlatAppearance.BorderSize = 0;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.ForeColor = System.Drawing.Color.White;
            this.edit_button.Location = new System.Drawing.Point(867, 129);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(136, 31);
            this.edit_button.TabIndex = 4;
            this.edit_button.Text = "Edit/ Delete";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // back_button
            // 
            this.back_button.BorderColor = System.Drawing.Color.White;
            this.back_button.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(78)))));
            this.back_button.FlatAppearance.BorderSize = 0;
            this.back_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(68)))));
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(883, 618);
            this.back_button.Name = "back_button";
            this.back_button.OnHoverBorderColor = System.Drawing.Color.White;
            this.back_button.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(43)))), ((int)(((byte)(85)))));
            this.back_button.OnHoverTextColor = System.Drawing.Color.White;
            this.back_button.Size = new System.Drawing.Size(120, 44);
            this.back_button.TabIndex = 8;
            this.back_button.Text = "Back";
            this.back_button.TextColor = System.Drawing.Color.White;
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click_1);
            // 
            // company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1350, 699);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.company_table);
            this.Controls.Add(this.new_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.label1);
            this.Name = "company";
            this.Text = "Products";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.company_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button new_button;
        private System.Windows.Forms.DataGridView company_table;
        private System.Windows.Forms.Button edit_button;
        private ePOSOne.btnProduct.Button_WOC back_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactno_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_col;
    }
}