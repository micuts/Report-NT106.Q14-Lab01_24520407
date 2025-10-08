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
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { try
            {
                int num1, num2;
                long sum = 0;
                num1 = Int32.Parse(textBox1.Text.Trim());
                num2 = Int32.Parse(textBox2.Text.Trim());
                sum = num1 + num2;
                textBox3.Text = sum.ToString();
            }
            catch
            {
                textBox3.Clear();
                MessageBox.Show(this, "Vui lòng nhập số nguyên!", "Lỗi nhập liệu",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
