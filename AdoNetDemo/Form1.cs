using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
           
            dgwProducts.DataSource = productDal.GetList();
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxPrice.Text),
                 UnitInStock=Convert.ToInt32(tbxStock.Text)
            }) ;
            MessageBox.Show("Ürün eklendi");
        }

        private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Cell content");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxPriceUpdate.Text),
                UnitInStock = Convert.ToInt32(tbxStockUpdate.Text)
            };
            productDal.Add(product);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            productDal.Delete(id);
            MessageBox.Show("Product is delete");
        }
    }
}
