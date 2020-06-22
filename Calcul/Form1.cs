using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ComplexNum c1 = new ComplexNum(0, 0);
        int i = 0;
        bool f = false;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

            //textBox1.Text += "/";
            i = 4;
          
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            if(f) textBox2.Text += "i";
            else textBox1.Text += "i";
            f = true;

        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            if (f) textBox2.Text += "1";
            else textBox1.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (f) textBox2.Text += "2";
            else textBox1.Text += "2";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            f = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if(f) textBox2.Text += "3";
            else textBox1.Text += "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (f) textBox2.Text += "4";
            else textBox1.Text += "4";

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (f) textBox2.Text += "5";
            else textBox1.Text += "5";

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (f) textBox2.Text += "6";
            else textBox1.Text += "6";

        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (f) textBox2.Text += "7";
            else textBox1.Text += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (f) textBox2.Text += "8";
            else textBox1.Text += "8";


        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (f) textBox2.Text += "9";
            else textBox1.Text += "9";

        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (f) textBox2.Text += "0";
            else textBox1.Text += "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (f) textBox2.Text += "+";
            else textBox1.Text += "+";
            i = 1;
      
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (f) textBox2.Text += "-";
            else textBox1.Text += "-";
            i = 2;
           
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
            i = 3;
           
        }

       private void button11_Click(object sender, EventArgs e)
        {
           
            var cmp1 = new ComplexNum();
            cmp1.Convert(textBox1.Text);
            var cmp2 = new ComplexNum();
            cmp2.Convert(textBox2.Text);
           
            switch (comboBox1.SelectedItem.ToString())
            {
                case "+": cmp1 += cmp2;
                    break;
                case "-":cmp1-=cmp2;
                    break;
                case "*":cmp1 *=cmp2;
                    break;
                case "/":cmp1/=cmp2;
                    break;
                default:
                    MessageBox.Show("Вы не выбрали операцию!");
                    break;
            }
            textBox3.Text = cmp1.BackConvert();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
