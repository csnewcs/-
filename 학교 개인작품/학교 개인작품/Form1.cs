using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace 학교_개인작품
{
    public partial class Form1 : Form
    {
        public static string name;
        Stopwatch sw = Form2.sw;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            if (name == "")
            {

            }
            else
            {
                button1.Text = name;
                Form form = new Form2();
                Hide();
                form.ShowDialog();
            }
        }

        private async void Form1_LoadAsync(object sender, EventArgs e)
        {
            label3.Hide();
            Size = new Size(334,92);
            Form form2 = new Form2();
            label1.Hide();
            label2.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            await Task.Delay(1000);
            int op = Form2.op;
            for (; ; )
            {
                op = Form2.op;
                await Task.Delay(100);
                if (op <= 0)
                {
                    break;
                }
            }
            form2.Hide();
            //form2가 닫힌 후
            label3.Show();
            this.Show();
            sw.Stop();
            int score = Form2.score;
            Size = new Size(400, 300);
            Text = "결과";
            pictureBox1.Show();
            button1.Hide();
            pictureBox2.Show();
            textBox1.Hide();
            string label = name + ":";
            label1.Text = "0";
            label2.Show();
            label1.Show();
            label3.Text = "게임 시간:" + sw.Elapsed.ToString();

            //if 노가다
            pictureBox2.Location = new Point(5, 214); label1.Text = label + "0" + "점" + "(도전 안함)";
            if (score >= 1)
            { pictureBox2.Location = new Point(10, 214); label1.Text = label + "1" + "점" + "(10등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 2)
            { pictureBox2.Location = new Point(15, 214); label1.Text = label + "2" + "점"+"(10등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 3)
            { pictureBox2.Location = new Point(20, 214); label1.Text = label + "3" + "점" + "(10등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 4)
            { pictureBox2.Location = new Point(25, 214); label1.Text = label + "4" + "점" + "(10등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 5)
            { pictureBox2.Location = new Point(30, 214); label1.Text = label + "5" + "점" + "(10등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 6)
            { pictureBox2.Location = new Point(35, 214); label1.Text = label + "6" + "점" + "(10등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 7)
            { pictureBox2.Location = new Point(40, 214); label1.Text = label + "7" + "점" + "(10등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 8)
            { pictureBox2.Location = new Point(45, 214); label1.Text = label + "8" + "점" + "(9등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 9)
            { pictureBox2.Location = new Point(50, 214); label1.Text = label + "9" + "점" + "(9등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 10)
            { pictureBox2.Location = new Point(55, 214); label1.Text = label + "10" + "점" + "(9등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 11)
            { pictureBox2.Location = new Point(60, 214); label1.Text = label + "11" + "점" + "(9등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 12)
            { pictureBox2.Location = new Point(65, 214); label1.Text = label + "12" + "점" + "(9등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 13)
            { pictureBox2.Location = new Point(70, 214); label1.Text = label + "13" + "점" + "(9등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 14)
            { pictureBox2.Location = new Point(75, 214); label1.Text = label + "14" + "점" + "(9등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 15)
            { pictureBox2.Location = new Point(80, 214); label1.Text = label + "15" + "점" + "(8등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 16)
            { pictureBox2.Location = new Point(85, 214); label1.Text = label + "16" + "점" + "(8등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 17)
            { pictureBox2.Location = new Point(90, 214); label1.Text = label + "17" + "점" + "(8등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 18)
            { pictureBox2.Location = new Point(95, 214); label1.Text = label + "18" + "점" + "(8등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 19)
            { pictureBox2.Location = new Point(100, 214); label1.Text = label + "19" + "점" + "(8등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 20)
            { pictureBox2.Location = new Point(105, 214); label1.Text = label + "20" + "점" + "(8등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 21)
            { pictureBox2.Location = new Point(110, 214); label1.Text = label + "21" + "점" + "(8등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 22)
            { pictureBox2.Location = new Point(115, 214); label1.Text = label + "22" + "점" + "(7등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 23)
            { pictureBox2.Location = new Point(120, 214); label1.Text = label + "23" + "점" + "(7등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 24)
            { pictureBox2.Location = new Point(125, 214); label1.Text = label + "24" + "점" + "(7등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 25)
            { pictureBox2.Location = new Point(130, 214); label1.Text = label + "25" + "점" + "(7등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 26)
            { pictureBox2.Location = new Point(135, 214); label1.Text = label + "26" + "점" + "(7등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 27)
            { pictureBox2.Location = new Point(140, 214); label1.Text = label + "27" + "점" + "(7등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 28)
            { pictureBox2.Location = new Point(145, 214); label1.Text = label + "28" + "점" + "(7등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 29)
            { pictureBox2.Location = new Point(150, 214); label1.Text = label + "29" + "점" + "(6등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 30)
            { pictureBox2.Location = new Point(155, 214); label1.Text = label + "30" + "점" + "(6등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 31)
            { pictureBox2.Location = new Point(160, 214); label1.Text = label + "31" + "점" + "(6등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 32)
            { pictureBox2.Location = new Point(165, 214); label1.Text = label + "32" + "점" + "(6등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 33)
            { pictureBox2.Location = new Point(170, 214); label1.Text = label + "33" + "점" + "(6등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 34)
            { pictureBox2.Location = new Point(175, 214); label1.Text = label + "34" + "점" + "(6등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 35)
            { pictureBox2.Location = new Point(180, 214); label1.Text = label + "35" + "점" + "(6등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 36)
            { pictureBox2.Location = new Point(185, 214); label1.Text = label + "36" + "점" + "(5등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 37)
            { pictureBox2.Location = new Point(190, 214); label1.Text = label + "37" + "점" + "(5등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 38)
            { pictureBox2.Location = new Point(195, 214); label1.Text = label + "38" + "점" + "(5등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 39)
            { pictureBox2.Location = new Point(200, 214); label1.Text = label + "39" + "점" + "(5등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 40)
            { pictureBox2.Location = new Point(205, 214); label1.Text = label + "40" + "점" + "(5등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 41)
            { pictureBox2.Location = new Point(210, 214); label1.Text = label + "41" + "점" + "(5등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 42)
            { pictureBox2.Location = new Point(215, 214); label1.Text = label + "42" + "점" + "(5등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 43)
            { pictureBox2.Location = new Point(220, 214); label1.Text = label + "43" + "점" + "(5등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 44)
            { pictureBox2.Location = new Point(225, 214); label1.Text = label + "44" + "점" + "(4등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 45)
            { pictureBox2.Location = new Point(230, 214); label1.Text = label + "45" + "점" + "(4등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 46)
            { pictureBox2.Location = new Point(235, 214); label1.Text = label + "46" + "점" + "(4등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 47)
            { pictureBox2.Location = new Point(240, 214); label1.Text = label + "47" + "점" + "(4등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 48)
            { pictureBox2.Location = new Point(245, 214); label1.Text = label + "48" + "점" + "(4등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 49)
            { pictureBox2.Location = new Point(250, 214); label1.Text = label + "49" + "점" + "(4등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 50)
            { pictureBox2.Location = new Point(255, 214); label1.Text = label + "50" + "점" + "(4등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 51)
            { pictureBox2.Location = new Point(260, 214); label1.Text = label + "51" + "점" + "(3등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 52)
            { pictureBox2.Location = new Point(265, 214); label1.Text = label + "52" + "점" + "(3등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 53)
            { pictureBox2.Location = new Point(270, 214); label1.Text = label + "53" + "점" + "(3등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 54)
            { pictureBox2.Location = new Point(275, 214); label1.Text = label + "54" + "점" + "(3등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 55)
            { pictureBox2.Location = new Point(280, 214); label1.Text = label + "55" + "점" + "(3등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 56)
            { pictureBox2.Location = new Point(285, 214); label1.Text = label + "56" + "점" + "(3등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 57)
            { pictureBox2.Location = new Point(290, 214); label1.Text = label + "57" + "점" + "(3등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 58)
            { pictureBox2.Location = new Point(295, 214); label1.Text = label + "58" + "점" + "(3등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 59)
            { pictureBox2.Location = new Point(300, 214); label1.Text = label + "59" + "점" + "(2등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 60)
            { pictureBox2.Location = new Point(305, 214); label1.Text = label + "60" + "점" + "(2등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 61)
            { pictureBox2.Location = new Point(310, 214); label1.Text = label + "61" + "점" + "(2등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 62)
            { pictureBox2.Location = new Point(315, 214); label1.Text = label + "62" + "점" + "(2등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 63)
            { pictureBox2.Location = new Point(320, 214); label1.Text = label + "63" + "점" + "(2등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 64)
            { pictureBox2.Location = new Point(325, 214); label1.Text = label + "64" + "점" + "(2등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 65)
            { pictureBox2.Location = new Point(330, 214); label1.Text = label + "65" + "점" + "(2등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 66)
            { pictureBox2.Location = new Point(335, 214); label1.Text = label + "66" + "점" + "(1등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 67)
            { pictureBox2.Location = new Point(340, 214); label1.Text = label + "67" + "점" + "(1등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 68)
            { pictureBox2.Location = new Point(345, 214); label1.Text = label + "68" + "점" + "(1등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 69)
            { pictureBox2.Location = new Point(350, 214); label1.Text = label + "69" + "점" + "(1등급)"; }
            else { goto finish; }
            await Task.Delay(62);
            if (score >= 70)
            { pictureBox2.Location = new Point(355, 214); label1.Text = label + score.ToString() + "점" + "(0등급)"; }
            await Task.Delay(62);
            if (score >= 77)
            { label1.Text = label + score.ToString() + "점" + "(0등급)" + Environment.NewLine + "(이스터에그: 개발자는 배재현이지만 사진작업은 PMH이 해줬습니다."; }
        finish:;
            //if 노가다가 끝난 후
            
        }
    }
}
