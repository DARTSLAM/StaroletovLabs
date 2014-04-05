using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityLab
{
    public partial class Form1 : Form
    {

        int timerCounter = 60;                     
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Hide();
            textBox2.Hide();
            label3.Hide();
            textBox3.Hide();
            label1.Hide();
            textBox1.Hide();
            button1.Hide();
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //В текстбокс выводим значение timerCounter уменьшаемое на 1
            this.textBox3.Text = (--timerCounter).ToString();
            if (timerCounter == 0)
            {
                timer.Stop();
                MessageBox.Show("Время истекло! \nВы проиграли!");
                
                this.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer = new Timer();
            timer.Interval = 1000;
            timerCounter = 60;
            timer.Tick += new EventHandler(timer1_Tick_1); //подписываемся на события Tick
            timer.Start();
            label2.Show();
            textBox2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timerCounter = 60;
            button3.Hide();
            timer.Tick += new EventHandler(timer1_Tick_1); //подписываемся на события Tick
            timer.Start();
            label3.Show();
            textBox3.Show();
            label1.Show();
            textBox1.Show();
            button1.Show();
        }
    }
}
