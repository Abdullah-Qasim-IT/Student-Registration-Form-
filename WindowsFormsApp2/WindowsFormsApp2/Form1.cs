using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			comboBox1.Items.AddRange(new String[] { "yemen", "Saudi Arabia", "Egypt", "Iraq", "Syria","Algaria" });
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
		
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtEmail_Click(object sender, EventArgs e)
		{
		
		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{

		}
	

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			string email = txtEmail.Text;
			string password = txtPassword.Text;
			string favoriteColor = colorDialog1.Color.Name;

			string gender = "";
			if (rdMale.Checked) gender = "Male";
			else if (rdFemale.Checked) gender = "Female";
			else if (rdOther.Checked) gender = "other ";

			if (gender == "")
			{
				MessageBox.Show("Please select a gender", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string birthday = dateTimePicker1.Value.ToLongDateString();

			string country = comboBox1.SelectedItem?.ToString() ?? "Not selected";
			lblResult.Text = $"\n -your name is : {name}, \n - your email is : {email} , \n - your password is : {password} , \n - your favorite color is : {favoriteColor} , \n - your gender is : {gender} , \n - your birthday is : {birthday} , \n - your country is : {country}";
		}
		
	

		private void btnChooseColor_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				btnChooseColor.Text=$"The Favorite Color: {colorDialog1.Color.Name}";
				btnChooseColor.ForeColor = colorDialog1.Color;
			}
		
		}

		

		private void lblResult_Click(object sender, EventArgs e)
		{
		
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cmbCountry_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void rdMale_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
