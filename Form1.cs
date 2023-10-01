using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace lab2SH
{
    public partial class Form1 : Form
    {
        public static bool isNumeric(String str)
        {
            
            return int.TryParse(str, out _);
        }
        public void Calculate(int choice)
        {
            double result = 1;
            try
            {

                double x = Convert.ToDouble(textField1.Text);
                if (!isNumeric(textField1.Text)) throw new Exception("Use numeric format");

                switch (choice)
                {
                    case 1:
                        result = x * Math.Sin(x);
                        RadioButton3.Checked = false;
                        RadioButton2.Checked = false;
                        RadioButton1.Select();
                        break;
                    case 2:
                        result = Math.Sqrt(x) / x;
                        RadioButton1.Checked = false;
                        RadioButton3.Checked = false;
                        RadioButton2.Select();
                        break;
                    case 3:
                        result = x * x + 2;
                        RadioButton1.Checked = false;
                        RadioButton2.Checked = false;
                        RadioButton3.Select();
                        break;
                    default:
                        if (x <= 0)
                        {
                            result = x * Math.Sin(x);
                            RadioButton3.Checked = false;
                            RadioButton2.Checked = false;
                            RadioButton1.Select();
                        }
                        if ((x > 0 && x < 3))
                        {
                            result = Math.Sqrt(x) / x;
                            RadioButton1.Checked = false;
                            RadioButton3.Checked = false;
                            RadioButton2.Select();
                        }
                        if (x >= 3)
                        {
                            result = x * x + 2;
                            RadioButton1.Checked = false;
                            RadioButton2.Checked = false;
                            RadioButton3.Select();
                        }
                        break;
                }
                if (CheckBox.Checked) result *= 2;
                label.Text = result.ToString();
                

            }
            catch (Exception ex)
            {
               
                label.Text = "Некорректные данные";
                RadioButton1.Checked = false;
                RadioButton2.Checked = false;
                RadioButton3.Checked = false;
                
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate(0);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int choice = 0;
            if (RadioButton1.Checked) choice = 1;
            if (RadioButton2.Checked) choice = 2;
            if (RadioButton3.Checked) choice = 3;
            Calculate(choice);
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int choice = 0;
            Console.WriteLine(e.ToString());
            if(sender.Equals(RadioButton1)) choice = 1;
            if(sender.Equals(RadioButton2)) choice = 2;
            if(sender.Equals(RadioButton3)) choice = 3;

            Calculate(choice);
        }
    }

}
