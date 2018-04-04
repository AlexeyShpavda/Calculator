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

        Double results = 0;
        String operation = "";
        bool enter_value = false;
        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_dysplay.Text == "0") || (enter_value)) 
            {
                textBox_dysplay.Text = "";
            }
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox_dysplay.Text.Contains("."))
                {
                    textBox_dysplay.Text += num.Text;
                }
            }
            else
            {
                textBox_dysplay.Text += num.Text;
            }
        }

        private void button_undoLastAction_Click(object sender, EventArgs e)
        {
            textBox_dysplay.Text = "0";
            label_dysplay.Text = "";
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_dysplay.Text = "0";
            label_dysplay.Text = "";
        }

        private void button_deleteLastCharacter_Click(object sender, EventArgs e)
        {
            if (textBox_dysplay.Text.Length > 0)
            {
                textBox_dysplay.Text = textBox_dysplay.Text.Remove
                    (textBox_dysplay.Text.Length - 1, 1); 
            }
            if (textBox_dysplay.Text == "")
            {
                textBox_dysplay.Text = "0";
            }
        }

        private void arithmetic_operation(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(textBox_dysplay.Text);
            textBox_dysplay.Text = "";
            label_dysplay.Text = Convert.ToString(results) + " " + operation;
        }

        private void button_equally_Click(object sender, EventArgs e)
        {
            label_dysplay.Text = "";
            switch (operation)
            {
                case "+": textBox_dysplay.Text = (results + Double.Parse(textBox_dysplay.Text)).ToString();
                        break;
                case "-":
                    textBox_dysplay.Text = (results - Double.Parse(textBox_dysplay.Text)).ToString();
                    break;
                case "×":
                    textBox_dysplay.Text = (results * Double.Parse(textBox_dysplay.Text)).ToString();
                    break;
                case "÷":
                    textBox_dysplay.Text = (results / Double.Parse(textBox_dysplay.Text)).ToString();
                    break;
            }
        }

        private void button_Pi_Click(object sender, EventArgs e)
        {
            textBox_dysplay.Text = "3.14159265358979";
        }

        private void button_log_Click(object sender, EventArgs e)
        {
            double log = Double.Parse(textBox_dysplay.Text);
            label_dysplay.Text = Convert.ToString("log" + "(" + (textBox_dysplay.Text) + ")");
            log = Math.Log10(log);
            textBox_dysplay.Text = Convert.ToString(log);
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(textBox_dysplay.Text);
            label_dysplay.Text = Convert.ToString("sqrt" + "(" + (textBox_dysplay.Text) + ")");
            sq = Math.Sqrt(sq);
            textBox_dysplay.Text = Convert.ToString(sq);
        }

        private void button_sin_Click(object sender, EventArgs e)
        {
            double sinus = Double.Parse(textBox_dysplay.Text);
            label_dysplay.Text = Convert.ToString("sin" + "(" + (textBox_dysplay.Text) + ")");
            sinus = Math.Sin(sinus);
            textBox_dysplay.Text = Convert.ToString(sinus);
        }

        private void button_cos_Click(object sender, EventArgs e)
        {
            double cosine = Double.Parse(textBox_dysplay.Text);
            label_dysplay.Text = Convert.ToString("cos" + "(" + (textBox_dysplay.Text) + ")");
            cosine = Math.Cos(cosine);
            textBox_dysplay.Text = Convert.ToString(cosine);
        }

        private void button_tg_Click(object sender, EventArgs e)
        {
            double tangent = Double.Parse(textBox_dysplay.Text);
            label_dysplay.Text = Convert.ToString("tg" + "(" + (textBox_dysplay.Text) + ")");
            tangent = Math.Tan(tangent);
            textBox_dysplay.Text = Convert.ToString(tangent);
        }

        private void button_ctg_Click(object sender, EventArgs e)
        {
            double cotangent = Double.Parse(textBox_dysplay.Text);
            label_dysplay.Text = Convert.ToString("ctg" + "(" + (textBox_dysplay.Text) + ")");
            cotangent = 1f / Math.Tan(cotangent);
            textBox_dysplay.Text = Convert.ToString(cotangent);
        }
    }
}
