namespace WholeSale_Management_System
{
    partial class edit_company
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.email_box = new System.Windows.Forms.TextBox();
            this.contact_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.id_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.product_table = new System.Windows.Forms.DataGridView();
            this.search_button = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wholeSale_DBDataSet = new WholeSale_Management_System.WholeSale_DBDataSet();
            this.companiesTableAdapter = new WholeSale_Management_System.WholeSale_DBDataSetTableAdapters.companiesTableAdapter();
            this.CompanyID_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.product_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSale_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.delete_button.FlatAppearance.BorderSize = 0;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.ForeColor = System.Drawing.Color.White;
            this.delete_button.Location = new System.Drawing.Point(489, 361);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(101, 35);
            this.delete_button.TabIndex = 27;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.edit_button.FlatAppearance.BorderSize = 0;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.ForeColor = System.Drawing.Color.White;
            this.edit_button.Location = new System.Drawing.Point(381, 361);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(101, 35);
            this.edit_button.TabIndex = 26;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(313, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(298, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Contact";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(229, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Supplier Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(255, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Company ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // email_box
            // 
            this.email_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_box.ForeColor = System.Drawing.Color.Black;
            this.email_box.Location = new System.Drawing.Point(381, 287);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(209, 29);
            this.email_box.TabIndex = 19;
            // 
            // contact_box
            // 
            this.contact_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_box.ForeColor = System.Drawing.Color.Black;
            this.contact_box.Location = new System.Drawing.Point(381, 252);
            this.contact_box.Name = "contact_box";
            this.contact_box.Size = new System.Drawing.Size(209, 29);
            this.contact_box.TabIndex = 18;
            // 
            // name_box
            // 
            this.name_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_box.ForeColor = System.Drawing.Color.Black;
            this.name_box.Location = new System.Drawing.Point(381, 217);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(209, 29);
            this.name_box.TabIndex = 17;
            // 
            // id_box
            // 
            this.id_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_box.ForeColor = System.Drawing.Color.Black;
            this.id_box.Location = new System.Drawing.Point(381, 182);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(209, 29);
            this.id_box.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(52, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 35);
            this.label1.TabIndex = 28;
            this.label1.Text = "Edit Companies";
            // 
            // product_table
            // 
            this.product_table.AllowUserToAddRows = false;
            this.product_table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.product_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyID_Col,
            this.supplier_col,
            this.contact_col,
            this.email_col});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.product_table.DefaultCellStyle = dataGridViewCellStyle2;
            this.product_table.Location = new System.Drawing.Point(678, 182);
            this.product_table.Name = "product_table";
            this.product_table.Size = new System.Drawing.Size(504, 261);
            this.product_table.TabIndex = 31;
            this.product_table.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_table_CellEnter);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.search_button.FlatAppearance.BorderSize = 0;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.ForeColor = System.Drawing.Color.White;
            this.search_button.Location = new System.Drawing.Point(1094, 149);
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
            this.search_box.Location = new System.Drawing.Point(864, 149);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(224, 29);
            this.search_box.TabIndex = 0;
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // back_button
            // 
            this.back_button.FlatAppearance.BorderSize = 2;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.Transparent;
            this.back_button.Location = new System.Drawing.Point(381, 402);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(209, 35);
            this.back_button.TabIndex = 28;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click_1);
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataMember = "companies";
            this.companiesBindingSource.DataSource = this.wholeSale_DBDataSet;
            // 
            // wholeSale_DBDataSet
            // 
            this.wholeSale_DBDataSet.DataSetName = "WholeSale_DBDataSet";
            this.wholeSale_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companiesTableAdapter
            // 
            this.companiesTableAdapter.ClearBeforeFill = true;
            // 
            // CompanyID_Col
            // 
            this.CompanyID_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CompanyID_Col.HeaderText = "Company ID";
            this.CompanyID_Col.Name = "CompanyID_Col";
            // 
            // supplier_col
            // 
            this.supplier_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.supplier_col.HeaderText = "Supplier Name";
            this.supplier_col.Name = "supplier_col";
            // 
            // contact_col
            // 
            this.contact_col.HeaderText = "Contact";
            this.contact_col.Name = "contact_col";
            this.contact_col.Width = 70;
            // 
            // email_col
            // 
            this.email_col.HeaderText = "Email";
            this.email_col.Name = "email_col";
            this.email_col.Width = 60;
            // 
            // edit_company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1350, 699);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.product_table);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.contact_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.id_box);
            this.Name = "edit_company";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.edit_product_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSale_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.TextBox contact_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView product_table;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button back_button;
        private WholeSale_DBDataSet wholeSale_DBDataSet;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private WholeSale_DBDataSetTableAdapters.companiesTableAdapter companiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyID_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_col;
    }
}