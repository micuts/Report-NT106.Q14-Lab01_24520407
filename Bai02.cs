using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaiLab01
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();

            double num1, num2, num3;
            double min, max;
            int invalidCount = 0;

           
            if (!double.TryParse(maskedTextBox1.Text.Trim(), out num1))
            {
                MessageBox.Show("Số 1 không hợp lệ! Vui lòng nhập lại số.");
                maskedTextBox1.Focus();
                invalidCount++;
            }

           
            if (!double.TryParse(textBox1.Text.Trim(), out num2))
            {
                MessageBox.Show("Số 2 không hợp lệ! Vui lòng nhập lại số.");
                textBox1.Focus();
                invalidCount++;
            }

           
            if (!double.TryParse(textBox2.Text.Trim(), out num3))
            {
                MessageBox.Show("Số 3 không hợp lệ! Vui lòng nhập lại số.");
                textBox2.Focus();
                invalidCount++;
            }

            
            if (invalidCount == 3)
            {
                MessageBox.Show("Cả ba số đều không hợp lệ! Vui lòng nhập lại.");
                return;
            }

           
            if (invalidCount == 0)
            {
                max = num1;
                if (num2 > max) max = num2;
                if (num3 > max) max = num3;

                min = num1;
                if (num2 < min) min = num2;
                if (num3 < min) min = num3;

                textBox3.Text = max.ToString();
                textBox4.Text = min.ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
