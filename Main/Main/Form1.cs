using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giao_Vien gv = new Giao_Vien();
            gv.Show();
        }

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hoc_Sinh hs = new Hoc_Sinh();
            hs.Show();
        }
    }
}
