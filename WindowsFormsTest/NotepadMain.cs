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
    public partial class NotepadMain : Form
    {
        public NotepadMain()
        {
            InitializeComponent();
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.Font = textBox.Font;
            fontDialog.ShowDialog( this );
            textBox.Font = fontDialog.Font;
        }
    }
}
