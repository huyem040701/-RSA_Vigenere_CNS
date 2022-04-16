using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA1710900
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

    

        private void btVigener_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Show();
        }

        private void btRSA_Click(object sender, EventArgs e)
        {
            RSACryptosystem frm = new RSACryptosystem();
            frm.Show();
            this.Show();
        }

        private void btthanhvien_Click(object sender, EventArgs e)
        {
            ThanhVien frm = new ThanhVien();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
