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
        private Rectangle headerOriginalRectangle;
        private Rectangle checkBoxOriginalRectangle;
        private Rectangle inputOriginalRectangle;
        private Rectangle r1OriginalRectangle;
        private Rectangle r2OriginalRectangle;
        private Rectangle r3OriginalRectangle;
        private Rectangle buttonOriginalRectangle;
        private Rectangle labelOriginalRectangle;
        private Rectangle originalFormSize;
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
        public Form1(){
            InitializeComponent();}
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
        private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            buttonOriginalRectangle = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            headerOriginalRectangle = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            checkBoxOriginalRectangle = new Rectangle(CheckBox.Location.X, CheckBox.Location.Y, CheckBox.Width, CheckBox.Height);
            inputOriginalRectangle = new Rectangle(textField1.Location.X, textField1.Location.Y, textField1.Width, textField1.Height); 
            r1OriginalRectangle = new Rectangle(RadioButton1.Location.X, RadioButton1.Location.Y, RadioButton1.Width, RadioButton1.Height);
            r2OriginalRectangle = new Rectangle(RadioButton2.Location.X, RadioButton2.Location.Y, RadioButton2.Width, RadioButton2.Height);
            r3OriginalRectangle = new Rectangle(RadioButton3.Location.X, RadioButton3.Location.Y, RadioButton3.Width, RadioButton3.Height);
            labelOriginalRectangle = new Rectangle(label.Location.X, label.Location.Y, label.Width, label.Height);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeControl(buttonOriginalRectangle, button1);
            resizeControl(headerOriginalRectangle, label1);
            resizeControl(checkBoxOriginalRectangle, CheckBox);
            resizeControl(inputOriginalRectangle, textField1);
            resizeControl(r1OriginalRectangle, RadioButton1);
            resizeControl(r2OriginalRectangle, RadioButton2);
            resizeControl(r3OriginalRectangle, RadioButton3);
            resizeControl(labelOriginalRectangle, label);
        }
    }

}
