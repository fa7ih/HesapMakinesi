using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
        }

        double result;
        double firstsgt;
        string Operator;
        bool isOperator = false;

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            minimize(this);
        }

        public static void minimize(Form form)
        {
            if (form.WindowState == FormWindowState.Minimized)
                form.WindowState = FormWindowState.Normal;
            else if (form.WindowState == FormWindowState.Normal)
                form.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            standart.Visible = true;
            bilimsel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            standart.Visible = true;
            bilimsel.Visible = false;
            textBox1.Text = "0";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="0" || isOperator )
                textBox1.Clear();
            isOperator = false;
            Button button=(Button)sender;
            if(button.Text == ",")
            {
                if(!textBox1.Text.Contains(","))
                {
                    textBox1.Text += button.Text;
                }
                
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            btn0_Click(sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int index = textBox1.Text.Length;
            index--;
            textBox1.Text=textBox1.Text.Remove(index);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text="0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            firstsgt=double.Parse(textBox1.Text);
            Button optr= (Button)sender;
            Operator = optr.Text;
            isOperator = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            switch (Operator)
            {
                case "+":
                    textBox1.Text = (firstsgt + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (firstsgt - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (firstsgt * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (firstsgt / double.Parse(textBox1.Text)).ToString();
                    break;
            }    
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button8_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Sqrt(result);
            textBox1.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            standart.Visible = false;
            bilimsel.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result= double.Parse(textBox1.Text);
            result = Math.Log10(result);
            textBox1.Text=result.ToString();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Sin(result);
            textBox1.Text = result.ToString();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Cos(result);
            textBox1.Text = result.ToString();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Tan(result);
            textBox1.Text = result.ToString();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Ceiling(result);
            textBox1.Text = result.ToString();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Exp(result);
            textBox1.Text = result.ToString();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            result = Math.PI;
            textBox1.Text = result.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Pow(result, 2);
            textBox1.Text = result.ToString();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Pow(result, 3);
            textBox1.Text = result.ToString();
        }


        private void btnClean_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = 1/result;
            textBox1.Text = result.ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = (firstsgt%double.Parse(textBox1.Text));
            textBox1.Text = result.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Log(result);
            textBox1.Text = result.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = result / 100;
            textBox1.Text = result.ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Floor(result);
            textBox1.Text = result.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = result / 2;
            textBox1.Text = result.ToString();
        }
    }
}
