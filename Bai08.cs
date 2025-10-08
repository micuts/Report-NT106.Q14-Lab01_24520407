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
    public partial class Bai08 : Form
    {
        public Bai08()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Không có gì để ăn  cả ! ");
                return;

            }
            Random rnd = new Random();
            int index = rnd.Next(0, listBox1.Items.Count);
            //chon ngau nhien tu 0
            string MonAn = listBox1.Items[index].ToString();
            MessageBox.Show($"Vậy hôm nay chúng ta ăn {MonAn} nha cục cưng");
            listBox1.SelectedIndex = index;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string MonMoi = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(MonMoi))
            {
                MessageBox.Show("Nhập thêm i");

                textBox1.Focus();
                return;
            }
            if (listBox1.Items.Contains(MonMoi))
            {
                MessageBox.Show("Đã có nhập lại đi");
                textBox1.Clear();
                textBox1.Focus();
            }
            listBox1.Items.Add(MonMoi);
            textBox1.Clear();
            textBox1.Focus();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
