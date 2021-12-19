using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Vorname";
            label2.Text = "Nachname";
            label3.Text = "Geschlecht";
            label4.Text = "Postleitzahl";
            label5.Text = "Straße";
            label6.Text = "Ort";
            label7.Text = "Benutzername";
            label8.Text = "Passwort";

            comboBox1.Items.Add("Männlich");
            comboBox1.Items.Add("Weiblich");
            comboBox1.Items.Add("Diverse");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = textBox2.Text+textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (checkBox1.Checked == true)
                {
                    button1.Enabled = true;
                    MessageBox.Show("AGB's wurden akzeptiert");
                }
                if (checkBox1.Checked == false)
                {
                    MessageBox.Show("AGB's wurden nicht akzeptiert!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void clearTextboxes(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
