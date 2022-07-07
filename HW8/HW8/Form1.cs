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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Task1Button_Click(object sender, EventArgs e)
        {
            try
            {
                Task1Form task1Form = new Task1Form();

                this.Hide();
                task1Form.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void Task2Button_Click(object sender, EventArgs e)
        {
            try
            {
                Task2Form task2Form = new Task2Form();

                this.Hide();
                task2Form.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void Task3Button_Click(object sender, EventArgs e)
        {
            try
            {
                Task3Form task3Form = new Task3Form();

                this.Hide();
                task3Form.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
