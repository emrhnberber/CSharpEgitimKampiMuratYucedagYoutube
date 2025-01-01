using CSharpEgitimKampi301.BusinessLayer.Abstruct;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntitiyLayer.Concrate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public FrmProduct()
        {
            InitializeComponent();
            _productService= new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource= values;
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductsWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id =int.Parse(txtProductId.Text);
            var value=_productService.TGetById(id);
            _productService.TDelete(value);
            MessageBox.Show("İşlem Başarılı!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            product.ProductPrice=decimal.Parse(txtProductPrice.Text);
            product.ProductDescription=txtProductDescription.Text;
            product.ProductStock= int.Parse(txtProductStock.Text);
            product.ProductName=txtProductIName.Text;
            _productService.TInsert(product);
            MessageBox.Show("Ekleme İşlemi Başarılı!");
        }

        private void btnId_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var value = _productService.TGetById(id);
            dataGridView1 .DataSource = value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse (txtProductId.Text);
            var value = _productService.TGetById (id);
            value.CategoryId = int.Parse(cmbCategory.SelectedIndex.ToString());
            value.ProductDescription=txtProductDescription.Text;
            value.ProductPrice= decimal.Parse(txtProductPrice.Text);
            value.ProductStock=int .Parse(txtProductStock.Text);
            value.ProductName=txtProductIName.Text;
            _productService.TUpdate(value);
            MessageBox.Show("Güncelleme Başarılı!");
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = _categoryService.TGetAll();
            cmbCategory.DataSource= values;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
        }
    }
}
