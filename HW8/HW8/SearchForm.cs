using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace HW8
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            try
            {
                string text = textBox1.Text;
                string mask_pattern = @"^(\*{1}\.{1}\w+)$";

                if (string.IsNullOrWhiteSpace(text) || !Regex.IsMatch(text, mask_pattern))
                {
                    MessageBox.Show("Маска пошуку введена неправильно.\nПриклад маски файлу: *.txt");
                    return;
                }

                if (FilesListBox.Items.Count > 0) FilesListBox.Items.Clear();


                FolderBrowserDialog browse = new FolderBrowserDialog();
                string path = "";
                if (browse.ShowDialog() == DialogResult.OK)
                {
                    path = browse.SelectedPath;
                }

                foreach (var file in Directory.GetFiles(path, text))
                {
                    FilesListBox.Items.Add(file.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
