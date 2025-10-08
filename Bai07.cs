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
    public partial class Bai07 : Form
    {
        public Bai07()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            string input = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Dữ liệu không hợp lệ, Hãy nhập lại!");
                return;

            }
           

            string[] part = input.Split(',');// tach chuoi bang dau ","
            if (part.Length < 2)
            {
                MessageBox.Show("Dữ liệu không hợp lệ, Hãy nhập lại ít nhất Họ tên + điểm 1 môn");
                return;
            }
            string HoTen = part[0].Trim();
            Double[] Diem = new Double[part.Length-1];
            for (int i = 1; i < part.Length; i++)
            {
                string s = part[i].Trim();

                double d;
                if (!double.TryParse(s, out d))
                {
                    MessageBox.Show($"Điểm môn {i} không hợp lệ: '{s}'");
                    return;
                }

                if (d < 0 || d > 10)
                {
                    MessageBox.Show($"Điểm môn {i} phải nằm trong khoảng 0–10!");
                    return;
                }

                Diem[i - 1] = d;
            }
            Double TB = Diem.Average();
            Double DieuKien = Diem.Min();
            int MonTb = Diem.Count(d => d < 5);
            string xeploai;

            if (TB >= 8 && DieuKien >= 6.5) xeploai = "Giỏi";
            else if (TB >= 6.5 && DieuKien >= 5) xeploai = "Khá";
            else if (TB >= 5 && DieuKien >= 3.5) xeploai = "Trung bình";
            else xeploai = "Yếu";
            textBox2.AppendText($"Họ và tên học sinh : {HoTen}\r\n");
            textBox2.AppendText("Danh sách điểm : \r\n");
            for (int i = 0; i < Diem.Length; i++)
            {
                textBox2.AppendText($"Môn{i + 1} : {Diem[i]}\r\n ");
            }
            textBox2.AppendText($"Điểm trung bình : {TB}\r\n");
            textBox2.AppendText($"Xếp loại : {xeploai}");


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
