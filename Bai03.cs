using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiLab01
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            int num1;
            if (!int.TryParse(textBox1.Text.Trim(), out num1))
            {
                MessageBox.Show("Vui lòng nhập số nguyên 0–9");
                return;
            }
            switch (num1)
            {
                case 0:
                    textBox2.Text = "Không";
                    break;
                case 1:
                    textBox2.Text = "Một";
                    break;
                case 2:
                    textBox2.Text = "Hai";
                    break;  
                case 3:
                    textBox2.Text = "Ba";
                    break;
                case 4:
                    textBox2.Text = "Bốn";
                    break;
                case 5:
                    textBox2.Text = "Năm";
                    break;
                case 6:
                    textBox2.Text = "Sáu";
                    break;
                case 7:
                    textBox2.Text = "Bảy";
                    break;
                case 8:
                    textBox2.Text = "Tám";
                    break;
                case 9:
                    textBox2.Text = "Chín";
                    break;
                default: MessageBox.Show("Chỉ hỗ trợ 0–9 thôi hihi"); break;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
