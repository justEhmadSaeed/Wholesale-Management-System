namespace WholeSale_Management_System
{
    partial class products_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.search_box = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.new_button = new System.Windows.Forms.Button();
            this.product_table = new System.Windows.Forms.DataGridView();
            this.edit_button = new System.Windows.Forms.Button();
            this.back_button = new ePOSOne.btnProduct.Button_WOC();
            this.ProductID_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyid_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.product_table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(74, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTS";
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
            this.new_button.Location = new System.Drawing.Point(785, 130);
            this.new_button.Name = "new_button";
            this.new_button.Size = new System.Drawing.Size(88, 31);
            this.new_button.TabIndex = 3;
            this.new_button.Text = "New +";
            this.new_button.UseVisualStyleBackColor = false;
            this.new_button.Click += new System.EventHandler(this.new_button_Click);
            // 
            // product_table
            // 
            this.product_table.AllowUserToAddRows = false;
            this.product_table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.product_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID_Col,
            this.productname_col,
            this.quantity_col,
            this.price_col,
            this.companyid_col});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.product_table.DefaultCellStyle = dataGridViewCellStyle4;
            this.product_table.Location = new System.Drawing.Point(332, 166);
            this.product_table.Name = "product_table";
            this.product_table.Size = new System.Drawing.Size(683, 437);
            this.product_table.TabIndex = 5;
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.edit_button.FlatAppearance.BorderSize = 0;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.ForeColor = System.Drawing.Color.White;
            this.edit_button.Location = new System.Drawing.Point(879, 130);
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
            this.back_button.Location = new System.Drawing.Point(895, 619);
            this.back_button.Name = "back_button";
            this.back_button.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.back_button.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.back_button.OnHoverTextColor = System.Drawing.Color.White;
            this.back_button.Size = new System.Drawing.Size(120, 44);
            this.back_button.TabIndex = 8;
            this.back_button.Text = "Back";
            this.back_button.TextColor = System.Drawing.Color.White;
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click_1);
            // 
            // ProductID_Col
            // 
            this.ProductID_Col.HeaderText = "Product ID";
            this.ProductID_Col.Name = "ProductID_Col";
            this.ProductID_Col.Width = 120;
            // 
            // productname_col
            // 
            this.productname_col.HeaderText = "Product Name";
            this.productname_col.Name = "productname_col";
            this.productname_col.Width = 200;
            // 
            // quantity_col
            // 
            this.quantity_col.HeaderText = "Quantity";
            this.quantity_col.Name = "quantity_col";
            // 
            // price_col
            // 
            this.price_col.HeaderText = "Price/-";
            this.price_col.Name = "price_col";
            // 
            // companyid_col
            // 
            this.companyid_col.HeaderText = "Company ID";
            this.companyid_col.Name = "companyid_col";
            this.companyid_col.Width = 120;
            // 
            // products_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1350, 699);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.product_table);
            this.Controls.Add(this.new_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.label1);
            this.Name = "products_form";
            this.Text = "Products";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.product_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button new_button;
        private System.Windows.Forms.DataGridView product_table;
        private System.Windows.Forms.Button edit_button;
        private ePOSOne.btnProduct.Button_WOC back_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyid_col;
    }
}