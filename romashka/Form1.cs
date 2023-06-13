using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace romashka
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        private bool v;
        private EventHandler comboBox1_SelectedIndexChanged;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Form2 form2, bool v)
        {
            this.form2 = form2;
            this.v = v;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/+oFbOXECd_ddlN2Vi");

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/public216422374");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная функция в процессе разработки", "Кредиты");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная функция в процессе разработки", "Инвестиции");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная функция в процессе разработки", "Premium Bank");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная функция в процессе разработки", "Меню-список");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Банк Ромашка – системообразующий универсальный российский банк, один из лидеров рынка финансовых услуг.Банк работает со всеми категориями клиентов – крупным, средним и малым бизнесом, индивидуальными предпринимателями, самозанятыми и физическими лицами", "О банке");
            MessageBox.Show("Основная информация на данный момент в процессе разработки", "О банке");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
            this.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.ShowDialog();
            this.Show();
        }
    }
}

