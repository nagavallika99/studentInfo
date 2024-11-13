using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sbacklogs_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stuname = sname.Text;
            string stuno =  sno.Text;
            string cy = syear.SelectedItem.ToString();
            string cs = csem.SelectedItem.ToString();
            string sfna = sfname.Text;
            string smna = smname.Text;
            string sfn = sfno.Text;
            string spo = spno.Text;
            string sbg = sbgp.Text;
            string smail = smailid.Text;
            string ge = "";
            if (male.Checked)
            {
                ge = "Male";
            }
            else if (female.Checked)
            {
                ge = "Female";
            }
            string sgpa = scgpa.Text;
            string sblogs = sbacklogs.Text;
            List<string> interestsList = new List<string>();
            if (checkBox1.Checked)
            {
                interestsList.Add("Descipline");
            }
            if (checkBox2.Checked)
            {
                interestsList.Add("Clubs");
            }
            if (checkBox3.Checked)
            {
                interestsList.Add("Food and Transport");
            }
            if (checkBox4.Checked)
            {
                interestsList.Add("Spotrs");
            }
            if (checkBox5.Checked)
            {
                interestsList.Add("Others");
            }
            string interests = string.Join(", ", interestsList);
            string message = $"Student Roll No : {stuno}\n" + $"Student Name : {stuname}\n" + $"Current Year : {cy}\n" + $"Current semester : {cs}\n" + $"Student Father Name : {sfna}\n" +
                $"Student Mother Name : {smna}\n" + $" Student Father phno : {sfn}\n" + $"Student Phno : {spo}\n" + $"Student Boold Group : {sbg}\n" + $"Student MailID : {smail}\n" +
                $"Student Gender : {ge}\n" + $"Student Previous CGPA : {sgpa}\n" + $"Student Backlogs  : {sblogs}\n" + $"Student SAC member : {interests}";
            MessageBox.Show(message, "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
