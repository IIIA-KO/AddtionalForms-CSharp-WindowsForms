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
    public partial class EditFileForm : Form
    {
        private Task3Form task3Form;

        public EditFileForm(Task3Form task3Form)
        {
            InitializeComponent();
            this.task3Form = task3Form;
            this.textBox1.Text = this.task3Form.FileText;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            task3Form.FileText = textBox1.Text;
            DialogResult = DialogResult.Yes;
            this.Close();
        }
        private void NoButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
