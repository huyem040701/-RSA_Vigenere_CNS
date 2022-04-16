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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập chuỗi cần mã hóa");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập từ khóa");
            }
            else
            {
                Vigenere vigenere = new Vigenere(textBox2.Text.Trim());
                vigenere.plainText = textBox1.Text.Trim();
                textBox3.Text = vigenere.MaHoa();
                textBox4.Text = vigenere.GiaiMa();
                if (textBox1.Text == textBox4.Text)
                {
                    label5.Text = "Kết quả: Thành công. Bản rõ trùng khớp với chuỗi cần mã hóa.";
                }
                else
                {
                    label5.Text = "Kết quả: Thất bại. Bản rõ không trùng khớp với chuỗi cần mã hóa.";
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.ToUpper();
        }
    }
}
