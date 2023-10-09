using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class AnketMain : Form
    {
        public AnketMain()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {


            string gender;
            if (radio_button_male == null)
                gender = radio_button_female.Text;
            else
                gender = radio_button_male.Text;


            AnketObject new_anket = new AnketObject(name_text.Text, surname_text.Text, middle_name_text.Text, country_text.Text, city_text.Text, phone_text.Text, dateTimePicker1.Text, gender);

            string? anketler_json = File.ReadAllText("..\\..\\..\\Json\\Anketler.json");
            List<AnketObject>? anketler = JsonSerializer.Deserialize<List<AnketObject>>(anketler_json);

            anketler?.Add(new_anket);

            string? json = JsonSerializer.Serialize(anketler);
            File.WriteAllText("..\\..\\..\\Json\\Anketler.json", json);

        }

        private void load_button_Click(object sender, EventArgs e)
        {

            string? anketler_json = File.ReadAllText("..\\..\\..\\Json\\Anketler.json");
            List<AnketObject>? anketler = JsonSerializer.Deserialize<List<AnketObject>>(anketler_json);

            foreach (var item in anketler)
            {
                if (item.Name == Load_name.Text)
                {
                    name_text.Text = item.Name;
                    surname_text.Text = item.Surname;
                    middle_name_text.Text = item.Middle_Name;
                    country_text.Text = item.Country;
                    city_text.Text = item.City;
                    phone_text.Text = item.Number;
                    dateTimePicker1.Text = item.Birthday;
                    string gender = item.Gender;
                    if (gender == "Male")
                        radio_button_male.Checked = true;
                    else
                        radio_button_female.Checked = true;
                }
            }
        }

    }
}

