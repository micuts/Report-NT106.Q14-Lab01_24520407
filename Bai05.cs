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
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }
        private void Bai05_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Bảng cửu chương B - A");
            comboBox1.Items.Add("Tính (A - B)!");
            comboBox1.Items.Add("Tính tổng S = A1 + A2 + ... + AB");
            comboBox1.SelectedIndex = 0; // mặc định cho phep dau tien
        }
        private long GiaiThua(int n)
        {
            if (n < 0) return -1; // Không tính giai thua so am
            long result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }
        private long TongLuyThua(int A, int B)
        {
            long sum = 0;
            long pow = 1;
            for (int i = 1; i <= B; i++)
            {
                pow *= A;
                sum += pow;
            }
            return sum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();

            if (!int.TryParse(textBox1.Text.Trim(), out int A))
            {
                MessageBox.Show("Giá trị A không hợp lệ, hãy nhập số nguyên!");
                textBox1.Focus();
                return;
            }

            if (!int.TryParse(textBox2.Text.Trim(), out int B))
            {
                MessageBox.Show("Giá trị B không hợp lệ, hãy nhập số nguyên!");
                textBox2.Focus();
                return;
            }

            string phepTinh = comboBox1.SelectedItem.ToString();

            int idx = comboBox1.SelectedIndex;
            if (idx == 0)
            {
                int n = B - A;
                textBox3.Clear();


                for (int i = 1; i <= 10; i++)
                {
                    textBox3.AppendText($"{n} x {i} = {n * i}\r\n");
                }
            }
            else if (idx == 1)
            {
                int n = A - B;
                textBox3.Clear();
                if (n < 0)
                {
                    MessageBox.Show($"Không thể tính giai thừa của số âm ({n})!");
                    return;
                }

                else
                {
                    long kq = GiaiThua(n);
                    textBox3.AppendText($"({A} - {B})! = {n}! = {kq}");
                }
            }
            else if (idx == 2)
            {
                if (B <= 0)
                {
                    MessageBox.Show("B phải lớn hơn 0 để tính tổng S = A^1 + ... + A^B");
                    return;
                }

                long sum = TongLuyThua(A, B);
                textBox3.AppendText($"S = {A}^1 + {A}^2 + ... + {A}^{B} = {sum}");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
