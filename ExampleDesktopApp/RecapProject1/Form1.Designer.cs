
namespace RecapProject1
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
            this.gbxCategories = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.gbxSearchByProductName = new System.Windows.Forms.GroupBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.gbxCategories.SuspendLayout();
            this.gbxSearchByProductName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCategories
            // 
            this.gbxCategories.Controls.Add(this.lblCategory);
            this.gbxCategories.Controls.Add(this.cbxCategory);
            this.gbxCategories.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCategories.Location = new System.Drawing.Point(8, 8);
            this.gbxCategories.Name = "gbxCategories";
            this.gbxCategories.Size = new System.Drawing.Size(760, 88);
            this.gbxCategories.TabIndex = 0;
            this.gbxCategories.TabStop = false;
            this.gbxCategories.Text = "Kategoriye Göre Listele";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblCategory.Location = new System.Drawing.Point(8, 40);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(83, 19);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Kategori : ";
            // 
            // cbxCategory
            // 
            this.cbxCategory.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(120, 32);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(224, 27);
            this.cbxCategory.TabIndex = 0;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // gbxSearchByProductName
            // 
            this.gbxSearchByProductName.Controls.Add(this.txtProductName);
            this.gbxSearchByProductName.Controls.Add(this.lblProductName);
            this.gbxSearchByProductName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSearchByProductName.Location = new System.Drawing.Point(8, 120);
            this.gbxSearchByProductName.Name = "gbxSearchByProductName";
            this.gbxSearchByProductName.Size = new System.Drawing.Size(760, 64);
            this.gbxSearchByProductName.TabIndex = 2;
            this.gbxSearchByProductName.TabStop = false;
            this.gbxSearchByProductName.Text = "Ürün ismine göre ara";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtProductName.Location = new System.Drawing.Point(120, 24);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(224, 27);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblProductName.Location = new System.Drawing.Point(8, 24);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(96, 19);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Ürün İsmi : ";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(8, 200);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(760, 280);
            this.dgvProducts.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 492);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.gbxSearchByProductName);
            this.Controls.Add(this.gbxCategories);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxCategories.ResumeLayout(false);
            this.gbxCategories.PerformLayout();
            this.gbxSearchByProductName.ResumeLayout(false);
            this.gbxSearchByProductName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCategories;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.GroupBox gbxSearchByProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}

