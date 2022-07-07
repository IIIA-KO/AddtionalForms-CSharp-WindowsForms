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
    public partial class Task2Form : Form
    {
        private double TotalPrice = 0;

        private static List<Product> products = new List<Product>
        {
            new Product("Материнська плата", 2500, "Опис можна додати потім"),
            new Product("Процесор", 5000, "Опис можна додати потім"),
            new Product("ОЗП", 1800, "Опис можна додати потім"),
            new Product("Відеокарта", 15000, "Опис можна додати потім"),
            new Product("HDD", 1500, "Опис можна додати потім"),
            new Product("SSD", 2000, "Опис можна додати потім"),
            new Product("Блок живлення", 2500, "Опис можна додати потім")
        };

        public Task2Form()
        {
            InitializeComponent();
        }

        private void Task2Form_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in products)
                    ProductsComboBox.Items.Add(item);

                AddButton.Enabled = false;
                EditButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void ProductsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ProductsComboBox.SelectedIndex == -1)
                {
                    AddButton.Enabled = false;
                    EditButton.Enabled = false;
                }
                else
                {
                    AddButton.Enabled = true;
                    EditButton.Enabled = true;
                }

                Product pr = (Product)ProductsComboBox.SelectedItem;
                textBox1.Text = pr.Price.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                TotalPrice = double.Parse(TotalPriceTextBox.Text);

                Product pr = ProductsComboBox.SelectedItem as Product;
                TotalPrice += pr.Price;

                listBox1.Items.Add($"{pr.Name} | {pr.Price} | {pr.Description}");

                TotalPriceTextBox.Text = TotalPrice.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                EditForm editForm = new EditForm(false);

                if (editForm.ShowDialog() == DialogResult.Yes)
                {
                    Product pr = editForm.product;
                    products.Add(pr);

                    ProductsComboBox.Items.Clear();
                    foreach (Product p in products)
                        ProductsComboBox.Items.Add(p);
                }
                ProductsComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductsComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Елемент не вибраний");
                    return;
                }

                EditForm editForm = new EditForm(true);

                Product selectedPr = ProductsComboBox.SelectedItem as Product;

                editForm.product = selectedPr;

                if (editForm.ShowDialog() == DialogResult.Yes)
                {
                    Product pr = editForm.product;
                    products[ProductsComboBox.SelectedIndex] = pr;
                }
                ProductsComboBox.Items.Clear();
                foreach (Product pr in products)
                    ProductsComboBox.Items.Add(pr);

                ProductsComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
