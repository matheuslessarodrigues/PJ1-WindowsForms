using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void Form1_Load( object sender, EventArgs e )
		{
			checkBox1.Enabled = false;
			checkBox2.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
        {
			checkBox1.Enabled = !checkBox1.Enabled;
			checkBox2.Enabled = !checkBox2.Enabled;
	
			bigTextbox.AppendText( "Clicou no botao ne?\n" );
		}

		private void smallButton_Click( object sender, EventArgs e )
		{
			bigTextbox.AppendText( "Clicou no botaozin ne?\n" );
		}

		private void bigTextbox_TextChanged( object sender, EventArgs e )
		{
		}
	}
}
