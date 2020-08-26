namespace WholeSale_Management_System
{
    partial class new_product_form
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
            this.id_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.companyid_box = new System.Windows.Forms.ComboBox();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wholeSaleDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wholeSale_DBDataSet = new WholeSale_Management_System.WholeSale_DBDataSet();
            this.companiesTableAdapter = new WholeSale_Management_System.WholeSale_DBDataSetTableAdapters.companiesTableAdapter();
            this.error_msg = new System.Windows.Forms.Label();
            this.quantity_box = new System.Windows.Forms.NumericUpDown();
            this.price_box = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSale_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_box)).BeginInit();
            this.SuspendLayout();
            // 
            // id_box
            // 
            this.id_box.BackColor = System.Drawing.Color.White;
            this.id_box.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_box.ForeColor = System.Drawing.Color.Black;
            this.id_box.Location = new System.Drawing.Point(625, 181);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(243, 31);
            this.id_box.TabIndex = 4;
            this.id_box.KeyUp += new System.Windows.Forms.KeyEventHandler(this.id_box_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(570, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Product";
            // 
            // name_box
            // 
            this.name_box.BackColor = System.Drawing.Color.White;
            this.name_box.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_box.ForeColor = System.Drawing.Color.Black;
            this.name_box.Location = new System.Drawing.Point(625, 226);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(243, 31);
            this.name_box.TabIndex = 5;
            this.name_box.KeyUp += new System.Windows.Forms.KeyEventHandler(this.name_box_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(515, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Product ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(483, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Product Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(488, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Price Per Item";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(532, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(500, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Company ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(78)))));
            this.add_button.FlatAppearance.BorderSize = 0;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(625, 409);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(113, 40);
            this.add_button.TabIndex = 9;
            this.add_button.Text = "ADD";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // back_button
            // 
            this.back_button.FlatAppearance.BorderSize = 0;
            this.back_button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.Black;
            this.back_button.Location = new System.Drawing.Point(755, 409);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(113, 40);
            this.back_button.TabIndex = 10;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // companyid_box
            // 
            this.companyid_box.DataSource = this.companiesBindingSource;
            this.companyid_box.DisplayMember = "company_id";
            this.companyid_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companyid_box.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.companyid_box.FormattingEnabled = true;
            this.companyid_box.Location = new System.Drawing.Point(625, 359);
            this.companyid_box.Name = "companyid_box";
            this.companyid_box.Size = new System.Drawing.Size(243, 31);
            this.companyid_box.TabIndex = 8;
            this.companyid_box.KeyUp += new System.Windows.Forms.KeyEventHandler(this.companyid_box_KeyUp_1);
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataMember = "companies";
            this.companiesBindingSource.DataSource = this.wholeSaleDBDataSetBindingSource;
            // 
            // wholeSaleDBDataSetBindingSource
            // 
            this.wholeSaleDBDataSetBindingSource.DataSource = this.wholeSale_DBDataSet;
            this.wholeSaleDBDataSetBindingSource.Position = 0;
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
            // error_msg
            // 
            this.error_msg.AutoSize = true;
            this.error_msg.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_msg.ForeColor = System.Drawing.Color.White;
            this.error_msg.Location = new System.Drawing.Point(874, 318);
            this.error_msg.Name = "error_msg";
            this.error_msg.Size = new System.Drawing.Size(0, 25);
            this.error_msg.TabIndex = 14;
            // 
            // quantity_box
            // 
            this.quantity_box.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_box.ForeColor = System.Drawing.Color.Black;
            this.quantity_box.Location = new System.Drawing.Point(625, 316);
            this.quantity_box.Name = "quantity_box";
            this.quantity_box.Size = new System.Drawing.Size(243, 32);
            this.quantity_box.TabIndex = 7;
            this.quantity_box.KeyUp += new System.Windows.Forms.KeyEventHandler(this.quantity_box_KeyUp_1);
            // 
            // price_box
            // 
            this.price_box.DecimalPlaces = 2;
            this.price_box.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_box.ForeColor = System.Drawing.Color.Black;
            this.price_box.Location = new System.Drawing.Point(625, 271);
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(243, 32);
            this.price_box.TabIndex = 6;
            this.price_box.KeyUp += new System.Windows.Forms.KeyEventHandler(this.price_box_KeyUp_1);
            // 
            // new_product_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1350, 699);
            this.Controls.Add(this.price_box);
            this.Controls.Add(this.quantity_box);
            this.Controls.Add(this.error_msg);
            this.Controls.Add(this.companyid_box);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "new_product_form";
            this.Text = "Add Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.new_product_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSale_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.ComboBox companyid_box;
        private System.Windows.Forms.BindingSource wholeSaleDBDataSetBindingSource;
        private WholeSale_DBDataSet wholeSale_DBDataSet;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private WholeSale_DBDataSetTableAdapters.companiesTableAdapter companiesTableAdapter;
        private System.Windows.Forms.Label error_msg;
        private System.Windows.Forms.NumericUpDown quantity_box;
        private System.Windows.Forms.NumericUpDown price_box;
    }
}