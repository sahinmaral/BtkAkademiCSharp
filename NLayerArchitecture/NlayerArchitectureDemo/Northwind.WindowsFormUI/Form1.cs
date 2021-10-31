
using Northwind.Business.Abstract;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.Entities.Concrete;

using System;
using System.Windows.Forms;

namespace Northwind.WindowsFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProducts();

            ListCategories();
        }

        private void ListCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryAddProduct.DataSource = _categoryService.GetAll();
            cbxCategoryAddProduct.DisplayMember = "CategoryName";
            cbxCategoryAddProduct.ValueMember = "CategoryId";

            cbxCategoryUpdateProduct.DataSource = _categoryService.GetAll();
            cbxCategoryUpdateProduct.DisplayMember = "CategoryName";
            cbxCategoryUpdateProduct.ValueMember = "CategoryId";
        }

        private void ListProducts()
        {
            dgvProducts.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductsByCategoryId(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch(Exception exception)
            {

            }

        }

        private void ListProductsByCategoryId(int categoryId)
        {
            dgvProducts.DataSource = _productService.GetAll(x => x.CategoryId == categoryId);
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            ListProductsByProductName(txtProductName.Text);
        }

        private void ListProductsByProductName(string productName)
        {
            if (string.IsNullOrEmpty(productName))
            {
                ListProducts();
            }
            else
            {
                dgvProducts.DataSource =
                    _productService.GetAll(x => x.ProductName.ToLower().Contains(productName.ToLower()));
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            

            Product product = new Product()
            {
                ProductName = txtProductNameAddProduct.Text,
                CategoryId = Convert.ToInt32(cbxCategoryAddProduct.SelectedValue),
                QuantityPerUnit = txtQuantityPerUnitAddProduct.Text,
                UnitPrice = Convert.ToDecimal(txtUnitPriceAddProduct.Text),
                UnitsInStock = Convert.ToInt16(txtUnitsInStockAddProduct.Text)
            };


            _productService.Add(product);

            ListProducts();

            MessageBox.Show("Ürün eklendi");





        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                int productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value);

                Product searchedProduct = _productService.Get(x => x.ProductId == productId);

                try
                {
                    _productService.Delete(searchedProduct);

                    ListProducts();

                    MessageBox.Show("Ürün silindi");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }


            }


        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                int productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value);
                Product searchedProduct = _productService.Get(x => x.ProductId == productId);

                searchedProduct.ProductName = txtProductNameUpdateProduct.Text;
                searchedProduct.CategoryId = Convert.ToInt32(cbxCategoryUpdateProduct.SelectedValue);
                searchedProduct.QuantityPerUnit = txtQuantityPerUnitUpdateProduct.Text;
                searchedProduct.UnitPrice = Convert.ToDecimal(txtUnitPriceUpdateProduct.Text);
                searchedProduct.UnitsInStock = Convert.ToInt16(txtUnitsInStockUpdateProduct.Text);

                try
                {
                    _productService.Update(searchedProduct);
                    ListProducts();

                    MessageBox.Show("Ürün güncellendi");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }


            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = dgvProducts.CurrentRow;
            txtProductNameUpdateProduct.Text = currentRow.Cells[1].Value.ToString();
            cbxCategoryUpdateProduct.SelectedValue = currentRow.Cells[2].Value;
            txtQuantityPerUnitUpdateProduct.Text = currentRow.Cells[4].Value.ToString();
            txtUnitPriceUpdateProduct.Text = currentRow.Cells[3].Value.ToString();
            txtUnitsInStockUpdateProduct.Text = currentRow.Cells[5].Value.ToString();
        }
    }
}
