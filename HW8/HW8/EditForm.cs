using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8
{
    public partial class EditForm : Form
    {
        public Product product { get; set; }
        private bool IsEdit { get; set; }

        public EditForm(bool isEdit)
        {
            InitializeComponent();

            IsEdit = isEdit;
            if (isEdit) this.Text = "Редагування";
            else this.Text = "Створення";
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            if (product != null && IsEdit)
            {
                ProductNameTextBox.Text = product.Name;
                ProductPriceTextBox.Text = product.Price.ToString();
                ProductDescriptionTextBox.Text = product.Description;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductNameTextBox.Text))
            {
                MessageBox.Show("Ім'я товару не введено");
                return;
            }
            if (!double.TryParse(ProductPriceTextBox.Text, out double price))
            {
                MessageBox.Show("Ціна введена некоректно");
                return;
            }
            if (price < 0)
            {
                MessageBox.Show("Ціна не може бути менше 0");
                return;
            }
            if (string.IsNullOrWhiteSpace(ProductDescriptionTextBox.Text))
            {
                MessageBox.Show("Опис товару не введений");
                return;
            }

            if (!IsEdit)
            {
                product = new Product
                    (ProductNameTextBox.Text,
                    double.Parse(ProductPriceTextBox.Text),
                    ProductDescriptionTextBox.Text);
            }
            else
            {
                product = new Product(ProductNameTextBox.Text, price, ProductDescriptionTextBox.Text);
            }

            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
