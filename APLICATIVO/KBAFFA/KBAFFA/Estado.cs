using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBAFFA
{
    public partial class Estado : Form
    {
        public Estado()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMenu frmmenu = new frmMenu();
            frmmenu.Show();
            this.Hide();
        }
    }
}
