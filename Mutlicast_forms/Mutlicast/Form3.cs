using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Mutlicast
{
    public partial class Form3 : Form
    {
        bool changed = false;
        OpenFileDialog openDlg = new OpenFileDialog();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = (openDlg.ShowDialog() == DialogResult.OK) ? openDlg.FileName : null;
            if (filename != null)
            {
                StreamReader rend = new StreamReader(filename);
                rend.Close();
                changed = false;
                Form2 f2 = new Form2();
                f2.Show();
            }
        }
    }
}
