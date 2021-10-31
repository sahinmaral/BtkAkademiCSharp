
namespace Northwind.WindowsFormUI
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.gbxSearchByProductName = new System.Windows.Forms.GroupBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxCategories = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.gbxAddProduct = new System.Windows.Forms.GroupBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cbxCategoryAddProduct = new System.Windows.Forms.ComboBox();
            this.txtUnitPriceAddProduct = new System.Windows.Forms.TextBox();
            this.lblUnitPriceAddProduct = new System.Windows.Forms.Label();
            this.txtQuantityPerUnitAddProduct = new System.Windows.Forms.TextBox();
            this.txtUnitsInStockAddProduct = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnitAddProduct = new System.Windows.Forms.Label();
            this.lblUnitsInStockAddProduct = new System.Windows.Forms.Label();
            this.lblCategoryAddProduct = new System.Windows.Forms.Label();
            this.lblProductNameAddProduct = new System.Windows.Forms.Label();
            this.txtProductNameAddProduct = new System.Windows.Forms.TextBox();
            this.gbxProductUpdate = new System.Windows.Forms.GroupBox();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.cbxCategoryUpdateProduct = new System.Windows.Forms.ComboBox();
            this.txtUnitPriceUpdateProduct = new System.Windows.Forms.TextBox();
            this.lblUnitPriceUpdateProduct = new System.Windows.Forms.Label();
            this.txtQuantityPerUnitUpdateProduct = new System.Windows.Forms.TextBox();
            this.txtUnitsInStockUpdateProduct = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnitUpdateProduct = new System.Windows.Forms.Label();
            this.lblUnitsInStockUpdateProduct = new System.Windows.Forms.Label();
            this.lblCategoryUpdateProduct = new System.Windows.Forms.Label();
            this.lblProductNameProductUpdate = new System.Windows.Forms.Label();
            this.txtProductNameUpdateProduct = new System.Windows.Forms.TextBox();
            this.gbxProductDelete = new System.Windows.Forms.GroupBox();
            this.btnProductDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.gbxSearchByProductName.SuspendLayout();
            this.gbxCategories.SuspendLayout();
            this.gbxAddProduct.SuspendLayout();
            this.gbxProductUpdate.SuspendLayout();
            this.gbxProductDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(8, 8);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(1208, 272);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // gbxSearchByProductName
            // 
            this.gbxSearchByProductName.Controls.Add(this.txtProductName);
            this.gbxSearchByProductName.Controls.Add(this.lblProductName);
            this.gbxSearchByProductName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSearchByProductName.Location = new System.Drawing.Point(8, 400);
            this.gbxSearchByProductName.Name = "gbxSearchByProductName";
            this.gbxSearchByProductName.Size = new System.Drawing.Size(360, 64);
            this.gbxSearchByProductName.TabIndex = 4;
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
            // gbxCategories
            // 
            this.gbxCategories.Controls.Add(this.lblCategory);
            this.gbxCategories.Controls.Add(this.cbxCategory);
            this.gbxCategories.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCategories.Location = new System.Drawing.Point(8, 288);
            this.gbxCategories.Name = "gbxCategories";
            this.gbxCategories.Size = new System.Drawing.Size(360, 88);
            this.gbxCategories.TabIndex = 3;
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
            // gbxAddProduct
            // 
            this.gbxAddProduct.Controls.Add(this.btnAddProduct);
            this.gbxAddProduct.Controls.Add(this.cbxCategoryAddProduct);
            this.gbxAddProduct.Controls.Add(this.txtUnitPriceAddProduct);
            this.gbxAddProduct.Controls.Add(this.lblUnitPriceAddProduct);
            this.gbxAddProduct.Controls.Add(this.txtQuantityPerUnitAddProduct);
            this.gbxAddProduct.Controls.Add(this.txtUnitsInStockAddProduct);
            this.gbxAddProduct.Controls.Add(this.lblQuantityPerUnitAddProduct);
            this.gbxAddProduct.Controls.Add(this.lblUnitsInStockAddProduct);
            this.gbxAddProduct.Controls.Add(this.lblCategoryAddProduct);
            this.gbxAddProduct.Controls.Add(this.lblProductNameAddProduct);
            this.gbxAddProduct.Controls.Add(this.txtProductNameAddProduct);
            this.gbxAddProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddProduct.Location = new System.Drawing.Point(376, 288);
            this.gbxAddProduct.Name = "gbxAddProduct";
            this.gbxAddProduct.Size = new System.Drawing.Size(416, 288);
            this.gbxAddProduct.TabIndex = 5;
            this.gbxAddProduct.TabStop = false;
            this.gbxAddProduct.Text = "Ürün Ekle";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddProduct.Location = new System.Drawing.Point(144, 248);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(264, 32);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.Text = "Ürün Ekle";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cbxCategoryAddProduct
            // 
            this.cbxCategoryAddProduct.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbxCategoryAddProduct.FormattingEnabled = true;
            this.cbxCategoryAddProduct.Location = new System.Drawing.Point(144, 64);
            this.cbxCategoryAddProduct.Name = "cbxCategoryAddProduct";
            this.cbxCategoryAddProduct.Size = new System.Drawing.Size(264, 27);
            this.cbxCategoryAddProduct.TabIndex = 2;
            // 
            // txtUnitPriceAddProduct
            // 
            this.txtUnitPriceAddProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPriceAddProduct.Location = new System.Drawing.Point(144, 208);
            this.txtUnitPriceAddProduct.Name = "txtUnitPriceAddProduct";
            this.txtUnitPriceAddProduct.Size = new System.Drawing.Size(264, 27);
            this.txtUnitPriceAddProduct.TabIndex = 9;
            this.txtUnitPriceAddProduct.Text = "0";
            // 
            // lblUnitPriceAddProduct
            // 
            this.lblUnitPriceAddProduct.AutoSize = true;
            this.lblUnitPriceAddProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPriceAddProduct.Location = new System.Drawing.Point(16, 216);
            this.lblUnitPriceAddProduct.Name = "lblUnitPriceAddProduct";
            this.lblUnitPriceAddProduct.Size = new System.Drawing.Size(42, 19);
            this.lblUnitPriceAddProduct.TabIndex = 8;
            this.lblUnitPriceAddProduct.Text = "Fiyat";
            // 
            // txtQuantityPerUnitAddProduct
            // 
            this.txtQuantityPerUnitAddProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityPerUnitAddProduct.Location = new System.Drawing.Point(144, 160);
            this.txtQuantityPerUnitAddProduct.Name = "txtQuantityPerUnitAddProduct";
            this.txtQuantityPerUnitAddProduct.Size = new System.Drawing.Size(264, 27);
            this.txtQuantityPerUnitAddProduct.TabIndex = 7;
            // 
            // txtUnitsInStockAddProduct
            // 
            this.txtUnitsInStockAddProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitsInStockAddProduct.Location = new System.Drawing.Point(144, 112);
            this.txtUnitsInStockAddProduct.Name = "txtUnitsInStockAddProduct";
            this.txtUnitsInStockAddProduct.Size = new System.Drawing.Size(264, 27);
            this.txtUnitsInStockAddProduct.TabIndex = 6;
            this.txtUnitsInStockAddProduct.Text = "0";
            // 
            // lblQuantityPerUnitAddProduct
            // 
            this.lblQuantityPerUnitAddProduct.AutoSize = true;
            this.lblQuantityPerUnitAddProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityPerUnitAddProduct.Location = new System.Drawing.Point(16, 168);
            this.lblQuantityPerUnitAddProduct.Name = "lblQuantityPerUnitAddProduct";
            this.lblQuantityPerUnitAddProduct.Size = new System.Drawing.Size(92, 19);
            this.lblQuantityPerUnitAddProduct.TabIndex = 5;
            this.lblQuantityPerUnitAddProduct.Text = "Birim Adedi";
            // 
            // lblUnitsInStockAddProduct
            // 
            this.lblUnitsInStockAddProduct.AutoSize = true;
            this.lblUnitsInStockAddProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitsInStockAddProduct.Location = new System.Drawing.Point(16, 120);
            this.lblUnitsInStockAddProduct.Name = "lblUnitsInStockAddProduct";
            this.lblUnitsInStockAddProduct.Size = new System.Drawing.Size(86, 19);
            this.lblUnitsInStockAddProduct.TabIndex = 4;
            this.lblUnitsInStockAddProduct.Text = "Stok Adedi";
            // 
            // lblCategoryAddProduct
            // 
            this.lblCategoryAddProduct.AutoSize = true;
            this.lblCategoryAddProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryAddProduct.Location = new System.Drawing.Point(16, 72);
            this.lblCategoryAddProduct.Name = "lblCategoryAddProduct";
            this.lblCategoryAddProduct.Size = new System.Drawing.Size(67, 19);
            this.lblCategoryAddProduct.TabIndex = 2;
            this.lblCategoryAddProduct.Text = "Kategori";
            // 
            // lblProductNameAddProduct
            // 
            this.lblProductNameAddProduct.AutoSize = true;
            this.lblProductNameAddProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNameAddProduct.Location = new System.Drawing.Point(16, 24);
            this.lblProductNameAddProduct.Name = "lblProductNameAddProduct";
            this.lblProductNameAddProduct.Size = new System.Drawing.Size(73, 19);
            this.lblProductNameAddProduct.TabIndex = 1;
            this.lblProductNameAddProduct.Text = "Ürün Adı";
            // 
            // txtProductNameAddProduct
            // 
            this.txtProductNameAddProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductNameAddProduct.Location = new System.Drawing.Point(144, 16);
            this.txtProductNameAddProduct.Name = "txtProductNameAddProduct";
            this.txtProductNameAddProduct.Size = new System.Drawing.Size(264, 27);
            this.txtProductNameAddProduct.TabIndex = 0;
            // 
            // gbxProductUpdate
            // 
            this.gbxProductUpdate.Controls.Add(this.btnProductUpdate);
            this.gbxProductUpdate.Controls.Add(this.cbxCategoryUpdateProduct);
            this.gbxProductUpdate.Controls.Add(this.txtUnitPriceUpdateProduct);
            this.gbxProductUpdate.Controls.Add(this.lblUnitPriceUpdateProduct);
            this.gbxProductUpdate.Controls.Add(this.txtQuantityPerUnitUpdateProduct);
            this.gbxProductUpdate.Controls.Add(this.txtUnitsInStockUpdateProduct);
            this.gbxProductUpdate.Controls.Add(this.lblQuantityPerUnitUpdateProduct);
            this.gbxProductUpdate.Controls.Add(this.lblUnitsInStockUpdateProduct);
            this.gbxProductUpdate.Controls.Add(this.lblCategoryUpdateProduct);
            this.gbxProductUpdate.Controls.Add(this.lblProductNameProductUpdate);
            this.gbxProductUpdate.Controls.Add(this.txtProductNameUpdateProduct);
            this.gbxProductUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxProductUpdate.Location = new System.Drawing.Point(800, 288);
            this.gbxProductUpdate.Name = "gbxProductUpdate";
            this.gbxProductUpdate.Size = new System.Drawing.Size(416, 288);
            this.gbxProductUpdate.TabIndex = 11;
            this.gbxProductUpdate.TabStop = false;
            this.gbxProductUpdate.Text = "Ürün Güncelle";
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnProductUpdate.Location = new System.Drawing.Point(144, 248);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(264, 32);
            this.btnProductUpdate.TabIndex = 10;
            this.btnProductUpdate.Text = "Ürün Güncelle";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // cbxCategoryUpdateProduct
            // 
            this.cbxCategoryUpdateProduct.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbxCategoryUpdateProduct.FormattingEnabled = true;
            this.cbxCategoryUpdateProduct.Location = new System.Drawing.Point(144, 64);
            this.cbxCategoryUpdateProduct.Name = "cbxCategoryUpdateProduct";
            this.cbxCategoryUpdateProduct.Size = new System.Drawing.Size(264, 27);
            this.cbxCategoryUpdateProduct.TabIndex = 2;
            // 
            // txtUnitPriceUpdateProduct
            // 
            this.txtUnitPriceUpdateProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPriceUpdateProduct.Location = new System.Drawing.Point(144, 208);
            this.txtUnitPriceUpdateProduct.Name = "txtUnitPriceUpdateProduct";
            this.txtUnitPriceUpdateProduct.Size = new System.Drawing.Size(264, 27);
            this.txtUnitPriceUpdateProduct.TabIndex = 9;
            // 
            // lblUnitPriceUpdateProduct
            // 
            this.lblUnitPriceUpdateProduct.AutoSize = true;
            this.lblUnitPriceUpdateProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPriceUpdateProduct.Location = new System.Drawing.Point(16, 216);
            this.lblUnitPriceUpdateProduct.Name = "lblUnitPriceUpdateProduct";
            this.lblUnitPriceUpdateProduct.Size = new System.Drawing.Size(42, 19);
            this.lblUnitPriceUpdateProduct.TabIndex = 8;
            this.lblUnitPriceUpdateProduct.Text = "Fiyat";
            // 
            // txtQuantityPerUnitUpdateProduct
            // 
            this.txtQuantityPerUnitUpdateProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityPerUnitUpdateProduct.Location = new System.Drawing.Point(144, 160);
            this.txtQuantityPerUnitUpdateProduct.Name = "txtQuantityPerUnitUpdateProduct";
            this.txtQuantityPerUnitUpdateProduct.Size = new System.Drawing.Size(264, 27);
            this.txtQuantityPerUnitUpdateProduct.TabIndex = 7;
            // 
            // txtUnitsInStockUpdateProduct
            // 
            this.txtUnitsInStockUpdateProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitsInStockUpdateProduct.Location = new System.Drawing.Point(144, 112);
            this.txtUnitsInStockUpdateProduct.Name = "txtUnitsInStockUpdateProduct";
            this.txtUnitsInStockUpdateProduct.Size = new System.Drawing.Size(264, 27);
            this.txtUnitsInStockUpdateProduct.TabIndex = 6;
            // 
            // lblQuantityPerUnitUpdateProduct
            // 
            this.lblQuantityPerUnitUpdateProduct.AutoSize = true;
            this.lblQuantityPerUnitUpdateProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityPerUnitUpdateProduct.Location = new System.Drawing.Point(16, 168);
            this.lblQuantityPerUnitUpdateProduct.Name = "lblQuantityPerUnitUpdateProduct";
            this.lblQuantityPerUnitUpdateProduct.Size = new System.Drawing.Size(92, 19);
            this.lblQuantityPerUnitUpdateProduct.TabIndex = 5;
            this.lblQuantityPerUnitUpdateProduct.Text = "Birim Adedi";
            // 
            // lblUnitsInStockUpdateProduct
            // 
            this.lblUnitsInStockUpdateProduct.AutoSize = true;
            this.lblUnitsInStockUpdateProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitsInStockUpdateProduct.Location = new System.Drawing.Point(16, 120);
            this.lblUnitsInStockUpdateProduct.Name = "lblUnitsInStockUpdateProduct";
            this.lblUnitsInStockUpdateProduct.Size = new System.Drawing.Size(86, 19);
            this.lblUnitsInStockUpdateProduct.TabIndex = 4;
            this.lblUnitsInStockUpdateProduct.Text = "Stok Adedi";
            // 
            // lblCategoryUpdateProduct
            // 
            this.lblCategoryUpdateProduct.AutoSize = true;
            this.lblCategoryUpdateProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryUpdateProduct.Location = new System.Drawing.Point(16, 72);
            this.lblCategoryUpdateProduct.Name = "lblCategoryUpdateProduct";
            this.lblCategoryUpdateProduct.Size = new System.Drawing.Size(67, 19);
            this.lblCategoryUpdateProduct.TabIndex = 2;
            this.lblCategoryUpdateProduct.Text = "Kategori";
            // 
            // lblProductNameProductUpdate
            // 
            this.lblProductNameProductUpdate.AutoSize = true;
            this.lblProductNameProductUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNameProductUpdate.Location = new System.Drawing.Point(16, 24);
            this.lblProductNameProductUpdate.Name = "lblProductNameProductUpdate";
            this.lblProductNameProductUpdate.Size = new System.Drawing.Size(73, 19);
            this.lblProductNameProductUpdate.TabIndex = 1;
            this.lblProductNameProductUpdate.Text = "Ürün Adı";
            // 
            // txtProductNameUpdateProduct
            // 
            this.txtProductNameUpdateProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductNameUpdateProduct.Location = new System.Drawing.Point(144, 16);
            this.txtProductNameUpdateProduct.Name = "txtProductNameUpdateProduct";
            this.txtProductNameUpdateProduct.Size = new System.Drawing.Size(264, 27);
            this.txtProductNameUpdateProduct.TabIndex = 0;
            // 
            // gbxProductDelete
            // 
            this.gbxProductDelete.Controls.Add(this.btnProductDelete);
            this.gbxProductDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxProductDelete.Location = new System.Drawing.Point(8, 472);
            this.gbxProductDelete.Name = "gbxProductDelete";
            this.gbxProductDelete.Size = new System.Drawing.Size(360, 104);
            this.gbxProductDelete.TabIndex = 5;
            this.gbxProductDelete.TabStop = false;
            this.gbxProductDelete.Text = "Ürün Silme";
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnProductDelete.Location = new System.Drawing.Point(16, 40);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(336, 48);
            this.btnProductDelete.TabIndex = 11;
            this.btnProductDelete.Text = "Seçilmiş Ürünü Sil";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 587);
            this.Controls.Add(this.gbxProductDelete);
            this.Controls.Add(this.gbxProductUpdate);
            this.Controls.Add(this.gbxAddProduct);
            this.Controls.Add(this.gbxSearchByProductName);
            this.Controls.Add(this.gbxCategories);
            this.Controls.Add(this.dgvProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.gbxSearchByProductName.ResumeLayout(false);
            this.gbxSearchByProductName.PerformLayout();
            this.gbxCategories.ResumeLayout(false);
            this.gbxCategories.PerformLayout();
            this.gbxAddProduct.ResumeLayout(false);
            this.gbxAddProduct.PerformLayout();
            this.gbxProductUpdate.ResumeLayout(false);
            this.gbxProductUpdate.PerformLayout();
            this.gbxProductDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox gbxSearchByProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxCategories;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.GroupBox gbxAddProduct;
        private System.Windows.Forms.Label lblCategoryAddProduct;
        private System.Windows.Forms.Label lblProductNameAddProduct;
        private System.Windows.Forms.TextBox txtProductNameAddProduct;
        private System.Windows.Forms.Label lblUnitPriceAddProduct;
        private System.Windows.Forms.TextBox txtQuantityPerUnitAddProduct;
        private System.Windows.Forms.TextBox txtUnitsInStockAddProduct;
        private System.Windows.Forms.Label lblQuantityPerUnitAddProduct;
        private System.Windows.Forms.Label lblUnitsInStockAddProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cbxCategoryAddProduct;
        private System.Windows.Forms.TextBox txtUnitPriceAddProduct;
        private System.Windows.Forms.GroupBox gbxProductUpdate;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.ComboBox cbxCategoryUpdateProduct;
        private System.Windows.Forms.TextBox txtUnitPriceUpdateProduct;
        private System.Windows.Forms.Label lblUnitPriceUpdateProduct;
        private System.Windows.Forms.TextBox txtUnitsInStockUpdateProduct;
        private System.Windows.Forms.Label lblQuantityPerUnitUpdateProduct;
        private System.Windows.Forms.Label lblUnitsInStockUpdateProduct;
        private System.Windows.Forms.Label lblCategoryUpdateProduct;
        private System.Windows.Forms.Label lblProductNameProductUpdate;
        private System.Windows.Forms.TextBox txtProductNameUpdateProduct;
        private System.Windows.Forms.GroupBox gbxProductDelete;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.TextBox txtQuantityPerUnitUpdateProduct;
    }
}

