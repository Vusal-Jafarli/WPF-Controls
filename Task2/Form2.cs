using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form2 : Form
    {
        string number_1;
        string number_2;
        bool first_number = true;
        bool comma_check = true;
        string operation;
        bool operation_procces = false;
        public Form2()
        {
            InitializeComponent();
        }
        private void for_all_button(object sender, EventArgs e)
        {
            Button? button = sender as Button;
            if (operation_procces)
            {
                if (first_number)
                {
                    label3.Location = new Point(229, 86);
                    number_2 += button.Name.ToString()[6];
                    label3.Text = number_2;
                    first_number = false;
                }
                else
                {
                    number_2 += button.Name.ToString()[6];
                    label3.Text = number_2;
                    label3.Location = new Point(label3.Location.X - 27, label3.Location.Y);
                }
            }
            else
            {
                if (first_number)
                {
                    label3.Location = new Point(229, 86);
                    number_1 += button.Name.ToString()[6];
                    label3.Text = number_1;
                    first_number = false;
                }
                else
                {
                    number_1 += button.Name.ToString()[6];
                    label3.Text = number_1;
                    label3.Location = new Point(label3.Location.X - 27, label3.Location.Y);
                }
            }
        }
        private void button_ac_Click(object sender, EventArgs e)
        {

            number_1 = "";
            number_2 = "";
            label3.Text = "0";
            first_number = true;
            label3.Location = new Point(229, 86);
            operation = "";
            operation_procces = false;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            number_1 = "";
            number_2 = "";
            label3.Text = "0";
            first_number = true;
            label3.Location = new Point(229, 86);
            operation = "";
            operation_procces = false;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            operation_procces = true;
            operation = "%";
            label3.Text = "0";
            first_number = true;
            label3.Location = new Point(229, 86);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            operation_procces = true;
            operation = "/";
            label3.Text = "0";
            first_number = true;
            label3.Location = new Point(229, 86);
        }
        private void button_x_Click(object sender, EventArgs e)
        {
            operation_procces = true;
            operation = "x";
            label3.Text = "0";
            first_number = true;
            label3.Location = new Point(229, 86);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            operation_procces = true;
            operation = "-";
            label3.Text = "0";
            first_number = true;
            label3.Location = new Point(229, 86);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            operation_procces = true;
            operation = "+";
            label3.Text = "0";
            first_number = true;
            label3.Location = new Point(229, 86);
        }
        private void button_11_Click(object sender, EventArgs e)
        {
            operation_procces = true;
            if (operation == "+")
            {
                label3.Text = Convert.ToString(Convert.ToInt32(number_1) + Convert.ToInt32(number_2));
            }
            else if (operation == "-")
            {
                label3.Text = Convert.ToString(Convert.ToInt32(number_1) - Convert.ToInt32(number_2));
            }
            else if (operation == "/")
            {
                if (number_2 == "0") { label3.Text = "None"; }
                else
                    label3.Text = Convert.ToString(Convert.ToInt32(number_1) / Convert.ToInt32(number_2));

            }
            else if (operation == "x")
            {
                label3.Text = Convert.ToString(Convert.ToInt32(number_1) * Convert.ToInt32(number_2));
            }
            else if (operation == "%")
            {
                //label3.Text = Convert.ToString(Convert.ToInt32(number_1) *(float)0.1 * Convert.ToInt32(number_2));
            }

            label3.Location = new Point(229, 86); for (int i = 0; i < label3.Text.Length - 1; i++) { label3.Location = new Point(label3.Location.X - 27, label3.Location.Y); }

            number_1 = "";
            number_2 = "";
            operation = "";
            operation_procces = false;
        }


    }
}
