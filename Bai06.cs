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
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime birthdate = dateTimePicker1.Value;
            int day = birthdate.Day;
            int month = birthdate.Month;
            string zodiac = "";

            switch ( month )
            {
                case 1:
                    zodiac = (day <= 20) ? "Ma Kết " : "Bảo Bình";
                    break;
                    case 2:
                    zodiac = (day <= 19) ? "Bảo Bình" : "Song Ngư";
                    break;
                    case 3:
                    zodiac = (day <= 20) ? "Song Ngư" : " Bạch Dương";
                    break;
                    case 4:
                    zodiac = (day <= 20) ? "Bạch Dương" : "Kim Ngưu";
                    break;
                    case 5:
                    zodiac = (day <= 21) ? "Kim Ngưu" : "Song Tử";
                    break;
                    case 6:
                    zodiac = (day <= 21) ? "Song Tử" : "Cự Giải";
                    break;
                    case 7:
                    zodiac = (day <= 22) ? "Cự Giải " : "Sư Tử";
                    break;
                    case 8:
                    zodiac = (day <= 23) ? "Sư Tử" : "Xử nữ";
                    break;
                    case 9:
                    zodiac = (day <= 23) ? "Xử Nữ" : "Thiên Bình";
                    break;
                    case 10:
                    zodiac = (day <= 23) ? "Thiên Bình" : "Thần Nông";
                    break;
                    case 11:
                    zodiac = (day <= 22) ? "Thần Nông " : "Nhân Mã";
                    break;
                    case 12:
                    zodiac = (day <= 21) ? "Nhân Mã" : " Ma Kết";
                    break;
                
            }
            MessageBox.Show("Cung hoàng đạo của bạn là: " + zodiac, "Kết quả");
        
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
