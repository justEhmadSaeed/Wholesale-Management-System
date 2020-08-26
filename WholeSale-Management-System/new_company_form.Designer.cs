namespace WholeSale_Management_System
{
    partial class new_company_form
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
            this.supplier_box = new System.Windows.Forms.TextBox();
            this.contact_box = new System.Windows.Forms.TextBox();
            this.email_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wholeSaleDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wholeSale_DBDataSet = new WholeSale_Management_System.WholeSale_DBDataSet();
            this.companiesTableAdapter = new WholeSale_Management_System.WholeSale_DBDataSetTableAdapters.companiesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSale_DBDataSet)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(234, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Company";
            // 
            // supplier_box
            // 
            this.supplier_box.BackColor = System.Drawing.Color.White;
            this.supplier_box.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_box.ForeColor = System.Drawing.Color.Black;
            this.supplier_box.Location = new System.Drawing.Point(625, 226);
            this.supplier_box.Name = "supplier_box";
            this.supplier_box.Size = new System.Drawing.Size(243, 31);
            this.supplier_box.TabIndex = 5;
            this.supplier_box.KeyUp += new System.Windows.Forms.KeyEventHandler(this.supplier_box_KeyUp);
            // 
            // contact_box
            // 
            this.contact_box.BackColor = System.Drawing.Color.White;
            this.contact_box.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_box.ForeColor = System.Drawing.Color.Black;
            this.contact_box.Location = new System.Drawing.Point(625, 271);
            this.contact_box.Name = "contact_box";
            this.contact_box.Size = new System.Drawing.Size(243, 31);
            this.contact_box.TabIndex = 6;
            this.contact_box.KeyUp += new System.Windows.Forms.KeyEventHandler(this.contact_box_KeyUp);
            // 
            // email_box
            // 
            this.email_box.BackColor = System.Drawing.Color.White;
            this.email_box.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_box.ForeColor = System.Drawing.Color.Black;
            this.email_box.Location = new System.Drawing.Point(625, 316);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(243, 31);
            this.email_box.TabIndex = 7;
            this.email_box.KeyUp += new System.Windows.Forms.KeyEventHandler(this.email_box_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(500, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Company ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(483, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Supplier Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(540, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Contact";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(560, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(78)))));
            this.add_button.FlatAppearance.BorderSize = 0;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(625, 365);
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
            this.back_button.Location = new System.Drawing.Point(755, 365);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(113, 40);
            this.back_button.TabIndex = 10;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
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
            // new_company_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1350, 699);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.contact_box);
            this.Controls.Add(this.supplier_box);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.label1);
            this.Name = "new_company_form";
            this.Text = "Add Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.new_product_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSale_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox supplier_box;
        private System.Windows.Forms.TextBox contact_box;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.BindingSource wholeSaleDBDataSetBindingSource;
        private WholeSale_DBDataSet wholeSale_DBDataSet;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private WholeSale_DBDataSetTableAdapters.companiesTableAdapter companiesTableAdapter;
    }
}