using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly ProductDal _productDal = new ProductDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductDal productDal = new ProductDal();
            productDal.Add(new Product()
            {
                Name = txtNameAdd.Text,
                StockAmount = Convert.ToInt32(txtStockAmountAdd.Text),
                UnitPrice = Convert.ToDecimal(txtUnitPriceAdd.Text)
            });

            LoadProducts();

            MessageBox.Show("Product added");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            txtUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            txtStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = txtNameUpdate.Text,
                StockAmount = Convert.ToInt32(txtStockAmountUpdate.Text),
                UnitPrice = Convert.ToDecimal(txtUnitPriceUpdate.Text)
            };

            _productDal.Update(product);

            LoadProducts();

            MessageBox.Show("Product updated");

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            _productDal.Delete(Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value));

            LoadProducts();

            MessageBox.Show("Product deleted");
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            dgwProducts.DataSource = _productDal.SearchProductsByName(txtSearchProduct.Text);
        }
    }
}
