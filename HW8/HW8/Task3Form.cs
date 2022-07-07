using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HW8
{
    public partial class Task3Form : Form
    {
        private string Path { get; set; }
        public string FileText {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            } 
        }

        public Task3Form()
        {
            InitializeComponent();
        }

        private void Task3Form_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            EditButton.Enabled = false;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string txt = File.ReadAllText(Path);

            EditFileForm editFileForm = new EditFileForm(this);
            editFileForm.Show();
            File.AppendAllText(Path, FileText);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Path = ofd.FileName;
                FileText = File.ReadAllText(Path, Encoding.Default);
                EditButton.Enabled = true;
            }
        }
    }
}
