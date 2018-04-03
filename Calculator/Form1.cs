using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 303;
            textBox_dysplay.Width = 284;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 473;
            textBox_dysplay.Width = 454;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Width = 303;
            textBox_dysplay.Width = 284;
        }
    }
}
