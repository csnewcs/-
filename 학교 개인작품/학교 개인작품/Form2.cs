using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace 학교_개인작품
{
    
    public partial class Form2 : Form
    {
        string but1;
        string but2;
        string but3;
        public static int score;
        decimal count = 10m;
        public static int level = 0;
        public static int op = 5;
        const int MF_BYPOSITION = 0x400;
        [DllImport("User32")]
        private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("User32")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("User32")]
        private static extern int GetMenuItemCount(IntPtr hWnd);
        public static Stopwatch sw = new Stopwatch();

        int start = 15;



        public Form2()
        {
            InitializeComponent();
        }

        public async void Form2_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int menuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);
            label4.Hide();
            button4.Hide();
            label3.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            label5.Hide();
            pictureBox1.Hide();
            Random ra = new Random();
        a:
            label2.Text = start.ToString() + "초 후에 게임이 시작됩니다.";
            start--;
            await Task.Delay(1000);
            if (start == 0)
            { goto b; }
            goto a;
        b:
            sw.Start();
            button6.Hide();
            pictureBox1.Show();
            Text = "게임중...";
            label4.Show();
            label3.Show();
            label1.Location = new Point(label1.Location.X + 300);
            Width = 748;
            Height = 322;
            button1.Show();
            button2.Show();
            button3.Show();
            string mk;
            score = 0;
            int ia = ra.Next(1, 21);
            int ib = ra.Next(1, 21);
            int ic = ra.Next(1, 5);
            int ie;
            level = 0;
            if (ic == 1)
            {
                ie = ia + ib;
                mk = "+";
            }
            else if (ic == 2)
            {
                ie = ia - ib;
                mk = "-";
            }
            else if (ic == 3)
            {
                ie = ia * ib;
                mk = "×";
            }
            else
            {
                ie = ia / ib;
                mk = "÷";
            }
            int id = ra.Next(1, 4);
            int @if = ra.Next(1, 3);
            int ig = ra.Next(1, 13);
            op = 5;
            button4_ClickAsync();
        c:
            label5.Show();
            ia = ra.Next(1, 21);
            ib = ra.Next(1, 21);
            ic = ra.Next(1, 5);
            if (ic == 1)
            {
                ie = ia + ib;
                mk = "+";
            }
            else if (ic == 2)
            {
                ie = ia - ib;
                mk = "-";
            }
            else if (ic == 3)
            {
                ie = ia * ib;
                mk = "×";
            }
            else
            {
                ie = ia / ib;
                mk = "÷";
            }
            if (ic == 1)
            {
                ie = ia + ib;
            }
            else if (ic == 2)
            {
                ie = ia - ib;
            }
            else if (ic == 3)
            {
                ie = ia * ib;
            }
            else
            {
                ie = ia / ib;
            }
            id = ra.Next(1, 4);
            @if = ra.Next(1, 3);
            ig = ra.Next(1, 13);
            if (@if == 1)
            {
                ig = ie + ig;
            }
            else if (@if == 2)
            {
                ig = ie - ig;
            }
            if (id == 1)
            {
                button1.Text = ie.ToString();
                but1 = button1.Text;
                button2.Text = ig.ToString();
                but2 = button2.Text;
                ig = ra.Next(1, 13);
                if (id == 1)
                {
                    ig = ie + ig;
                    button3.Text = ig.ToString();
                    but3 = button3.Text;
                }
                else
                {
                    ig = ie - ig;
                    button3.Text = ig.ToString();
                    but3 = button3.Text;
                }
            }
            else if (id == 2)
            {
                button2.Text = ie.ToString();
                but2 = button2.Text;
                button1.Text = ig.ToString();
                but1 = button1.Text;
                ig = ra.Next(1, 21);
                if (@if == 1)
                {
                    ig = ie + ig;
                    button3.Text = ig.ToString();
                    but3 = button3.Text;
                }
                else
                {
                    ig = ie - ig;
                    button3.Text = ig.ToString();
                    but3 = button3.Text;
                }
            }
            else
            {
                button3.Text = ie.ToString();
                but3 = button3.Text;
                button1.Text = ig.ToString();
                but1 = button1.Text;
                ig = ra.Next(1, 13);
                if (id == 1)
                {
                    ig = ie + ig;
                    button2.Text = ig.ToString();
                    but2 = button2.Text;
                }
                else
                {
                    ig = ie - ig;
                    button2.Text = ig.ToString();
                    but2 = button2.Text;
                }
            }
            if (button1.Text == button2.Text)
            {
                ig = ra.Next(1, 13);
                if (id == 1)
                {
                    ig = ie + ig;
                    button2.Text = ig.ToString();
                    but2 = button2.Text;
                }
                else
                {
                    ig = ie - ig;
                    button2.Text = ig.ToString();
                    but2 = button2.Text;
                }
            }
            if (button2.Text == button3.Text)
            {
                ig = ra.Next(1, 13);
                if (id == 1)
                {
                    ig = ie + ig;
                    button3.Text = ig.ToString();
                    but2 = button2.Text;
                }
                else
                {
                    ig = ie - ig;
                    button3.Text = ig.ToString();
                    but2 = button2.Text;
                }
            }
            if (button3.Text == button1.Text)
            {
                ig = ra.Next(1, 13);
                if (id == 1)
                {
                    ig = ie + ig;
                    button1.Text = ig.ToString();
                    but2 = button2.Text;
                }
                else
                {
                    ig = ie - ig;
                    button1.Text = ig.ToString();
                    but2 = button2.Text;
                }
            }
            label1.Text = ia.ToString() + mk + ib.ToString();
           
            label2.Text = "남은기회:" + op.ToString();
            label3.Text = "현재 점수:" + score.ToString();
            for (; ; )
            {
                await Task.Delay(50);
                if (count <= 0)
                { break; }
            }
            await Task.Delay(100);
            string iet = ie.ToString();
            if(checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                op--;
                level++;
            }
            if (checkBox1.Checked == true)
            {
                if (checkBox1.Text == iet)
                {
                    score++;
                    level++;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                }
                else
                {
                    level++;
                    op--;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                }
            }
            if (checkBox2.Checked == true)
            {
                if (checkBox2.Text == iet)
                {
                    score++;
                    level++;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                }
                else
                {
                    level++;
                    op--;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                }
            }
            if (checkBox3.Checked == true)
            {
                if (checkBox3.Text == iet)
                {
                    score++;
                    level++;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                }
                else
                {
                    level++;
                    op--;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                }
            }
            label2.Text = "남은기회:" + op.ToString();
            label3.Text = "현재 점수:" + score.ToString();
            await Task.Delay(100);
            if (op == 5) { pictureBox1.Image = Image.FromFile(@"C:\Program Files (x86)\칠성\사칙연산\사진\5개.png"); }
            if (op == 4) { pictureBox1.Image = Image.FromFile(@"C:\Program Files (x86)\칠성\사칙연산\사진\4개.png"); }
            if (op == 3) { pictureBox1.Image = Image.FromFile(@"C:\Program Files (x86)\칠성\사칙연산\사진\3개.png"); }
            if (op == 2) { pictureBox1.Image = Image.FromFile(@"C:\Program Files (x86)\칠성\사칙연산\사진\2개.png"); }
            if (op == 1) { pictureBox1.Image = Image.FromFile(@"C:\Program Files (x86)\칠성\사칙연산\사진\1개.png"); }
            if (op <= 0) { goto d; }
            goto c;
        d:
            Hide();
        }

        private async void button4_ClickAsync()
        {
            ab:
            if (level >= 0) { count = 10m; }
            if (level >= 5) { count = 9.2m; }
            if (level >= 10) { count = 8.4m; }
            if (level >= 15) { count = 7.6m; }
            if (level >= 20) { count = 6.8m; }
            if (level >= 25) { count = 6.0m; }
            if (level >= 30) { count = 5.2m; }
            if (level >= 35) { count = 4.4m; }
            if (level >= 40) { count = 3.6m; }
            if (level >= 45) { count = 2.8m; }
            if (level >= 50) { count = 2m; }
            if (level >= 60) { count = 1.5m; }
            if (level == 77) { count = 777m; }
            for (; count >= 0; )
            {
                count = count - 0.1m;
                label4.Text = count.ToString();
                await Task.Delay(100);
            }
            goto ab;
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Text = button1.Text;
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            count = 0.1m;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox2.Text = button2.Text;
            checkBox2.Checked = true;
            checkBox3.Checked = false;
            checkBox1.Checked = false;
            count = 0.1m;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox3.Text = button3.Text;
            checkBox3.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            count = 0.1m;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            start = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            op = 0;
            count = 0.1m;
        }
    }
}
