using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProducts();
            ListCategories();
        }

        private void ListProducts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgvProducts.DataSource = context.Products.ToList();
            }
        }

        private void ListCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cbxCategory.DataSource = context.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryId";
            }
        }

        private void ListProductsByCategoryId(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgvProducts.DataSource =
                    context.Products.Where(x => x.CategoryId == categoryId).ToList();
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                ListProductsByCategoryId(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch 
            {
                
            }
            
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
                using (NorthwindContext context = new NorthwindContext())
                {
                    dgvProducts.DataSource = context.Products.Where(x => x.ProductName.ToLower().Contains(productName.ToLower())).ToList();
                }
            }
            

        }
    }
}
