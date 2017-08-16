using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
        }

        private void LogicaMina(Button button)
        {
            if (rand.Next(2) == 0)
                button.Text = "Mina";
            else
                button.Text = "Limpo";
            button.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogicaMina(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogicaMina(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogicaMina(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LogicaMina(button4);
        }
    }
}
