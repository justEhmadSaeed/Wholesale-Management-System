namespace WholeSale_Management_System
{
    partial class edit_product_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.companyid_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quantity_box = new System.Windows.Forms.TextBox();
            this.price_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.id_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.product_table = new System.Windows.Forms.DataGridView();
            this.ProductID_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyid_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_button = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.product_table)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            this.delete_button.Location = new System.Drawing.Point(340, 355);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(101, 35);
            this.delete_button.TabIndex = 27;
            this.delete_button.Text = "DELETE";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(12)))), ((int)(((byte)(36)))));
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.edit_button.Location = new System.Drawing.Point(232, 355);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(101, 35);
            this.edit_button.TabIndex = 26;
            this.edit_button.Text = "EDIT";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(106, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Company ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // companyid_box
            // 
            this.companyid_box.Font = new System.Drawing.Font("Arial", 13F);
            this.companyid_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.companyid_box.Location = new System.Drawing.Point(232, 310);
            this.companyid_box.Name = "companyid_box";
            this.companyid_box.Size = new System.Drawing.Size(209, 27);
            this.companyid_box.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(143, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Quantity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(88, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Price Per Item";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(86, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Product Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(122, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Product ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // quantity_box
            // 
            this.quantity_box.Font = new System.Drawing.Font("Arial", 13F);
            this.quantity_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.quantity_box.Location = new System.Drawing.Point(232, 275);
            this.quantity_box.Name = "quantity_box";
            this.quantity_box.Size = new System.Drawing.Size(209, 27);
            this.quantity_box.TabIndex = 19;
            // 
            // price_box
            // 
            this.price_box.Font = new System.Drawing.Font("Arial", 13F);
            this.price_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.price_box.Location = new System.Drawing.Point(232, 240);
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(209, 27);
            this.price_box.TabIndex = 18;
            // 
            // name_box
            // 
            this.name_box.Font = new System.Drawing.Font("Arial", 13F);
            this.name_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.name_box.Location = new System.Drawing.Point(232, 205);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(209, 27);
            this.name_box.TabIndex = 17;
            // 
            // id_box
            // 
            this.id_box.Font = new System.Drawing.Font("Arial", 13F);
            this.id_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.id_box.Location = new System.Drawing.Point(232, 170);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(209, 27);
            this.id_box.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(52, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 35);
            this.label1.TabIndex = 28;
            this.label1.Text = "Edit Products";
            // 
            // product_table
            // 
            this.product_table.AllowUserToAddRows = false;
            this.product_table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.product_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID_Col,
            this.productname_col,
            this.quantity_col,
            this.price_col,
            this.companyid_col});
            this.product_table.Location = new System.Drawing.Point(529, 170);
            this.product_table.Name = "product_table";
            this.product_table.Size = new System.Drawing.Size(437, 261);
            this.product_table.TabIndex = 31;
            this.product_table.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_table_CellEnter);
            // 
            // ProductID_Col
            // 
            this.ProductID_Col.HeaderText = "Product ID";
            this.ProductID_Col.Name = "ProductID_Col";
            this.ProductID_Col.Width = 70;
            // 
            // productname_col
            // 
            this.productname_col.HeaderText = "Product Name";
            this.productname_col.Name = "productname_col";
            // 
            // quantity_col
            // 
            this.quantity_col.HeaderText = "Quantity";
            this.quantity_col.Name = "quantity_col";
            this.quantity_col.Width = 70;
            // 
            // price_col
            // 
            this.price_col.HeaderText = "Price/-";
            this.price_col.Name = "price_col";
            this.price_col.Width = 60;
            // 
            // companyid_col
            // 
            this.companyid_col.HeaderText = "Company ID";
            this.companyid_col.Name = "companyid_col";
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(12)))), ((int)(((byte)(36)))));
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.search_button.Location = new System.Drawing.Point(866, 128);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(88, 27);
            this.search_button.TabIndex = 1;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // search_box
            // 
            this.search_box.Font = new System.Drawing.Font("Arial", 13F);
            this.search_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.search_box.Location = new System.Drawing.Point(636, 128);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(224, 27);
            this.search_box.TabIndex = 0;
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(232, 396);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(209, 35);
            this.back_button.TabIndex = 28;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click_1);
            // 
            // edit_product_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1023, 511);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.product_table);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.companyid_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantity_box);
            this.Controls.Add(this.price_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.id_box);
            this.Name = "edit_product_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.product_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox companyid_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantity_box;
        private System.Windows.Forms.TextBox price_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView product_table;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyid_col;
        private System.Windows.Forms.Button back_button;
    }
}