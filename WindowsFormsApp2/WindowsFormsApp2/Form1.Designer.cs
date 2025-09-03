namespace WindowsFormsApp2
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.txtBox1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtEmail1 = new System.Windows.Forms.Label();
			this.txtPassword1 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.rdMale = new System.Windows.Forms.RadioButton();
			this.rdFemale = new System.Windows.Forms.RadioButton();
			this.rdOther = new System.Windows.Forms.RadioButton();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dtpBirthdate = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.lblResult = new System.Windows.Forms.Label();
			this.cmbCountry = new System.Windows.Forms.Label();
			this.btnChooseColor = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtBox1
			// 
			this.txtBox1.AutoSize = true;
			this.txtBox1.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
			this.txtBox1.ForeColor = System.Drawing.Color.Teal;
			this.txtBox1.Location = new System.Drawing.Point(476, 29);
			this.txtBox1.Name = "txtBox1";
			this.txtBox1.Size = new System.Drawing.Size(78, 38);
			this.txtBox1.TabIndex = 0;
			this.txtBox1.Text = "Name";
			this.txtBox1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
			this.txtName.Location = new System.Drawing.Point(593, 29);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(221, 34);
			this.txtName.TabIndex = 1;
			this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
			this.txtEmail.Location = new System.Drawing.Point(593, 85);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(221, 34);
			this.txtEmail.TabIndex = 2;
			this.txtEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// txtEmail1
			// 
			this.txtEmail1.AutoSize = true;
			this.txtEmail1.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
			this.txtEmail1.ForeColor = System.Drawing.Color.Teal;
			this.txtEmail1.Location = new System.Drawing.Point(476, 85);
			this.txtEmail1.Name = "txtEmail1";
			this.txtEmail1.Size = new System.Drawing.Size(78, 38);
			this.txtEmail1.TabIndex = 3;
			this.txtEmail1.Text = "Email";
			this.txtEmail1.Click += new System.EventHandler(this.txtEmail_Click);
			// 
			// txtPassword1
			// 
			this.txtPassword1.AutoSize = true;
			this.txtPassword1.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
			this.txtPassword1.ForeColor = System.Drawing.Color.Teal;
			this.txtPassword1.Location = new System.Drawing.Point(476, 136);
			this.txtPassword1.Name = "txtPassword1";
			this.txtPassword1.Size = new System.Drawing.Size(119, 38);
			this.txtPassword1.TabIndex = 4;
			this.txtPassword1.Text = "Password";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
			this.txtPassword.Location = new System.Drawing.Point(593, 135);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(221, 34);
			this.txtPassword.TabIndex = 5;
			this.txtPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// rdMale
			// 
			this.rdMale.AutoSize = true;
			this.rdMale.Font = new System.Drawing.Font("Andalus", 11F, System.Drawing.FontStyle.Bold);
			this.rdMale.ForeColor = System.Drawing.Color.Teal;
			this.rdMale.Location = new System.Drawing.Point(6, 25);
			this.rdMale.Name = "rdMale";
			this.rdMale.Size = new System.Drawing.Size(89, 38);
			this.rdMale.TabIndex = 6;
			this.rdMale.Text = "Male";
			this.rdMale.UseVisualStyleBackColor = true;
			this.rdMale.CheckedChanged += new System.EventHandler(this.rdMale_CheckedChanged);
			// 
			// rdFemale
			// 
			this.rdFemale.AutoSize = true;
			this.rdFemale.Font = new System.Drawing.Font("Andalus", 11F, System.Drawing.FontStyle.Bold);
			this.rdFemale.ForeColor = System.Drawing.Color.Teal;
			this.rdFemale.Location = new System.Drawing.Point(101, 25);
			this.rdFemale.Name = "rdFemale";
			this.rdFemale.Size = new System.Drawing.Size(109, 38);
			this.rdFemale.TabIndex = 7;
			this.rdFemale.Text = "Female";
			this.rdFemale.UseVisualStyleBackColor = true;
			// 
			// rdOther
			// 
			this.rdOther.AutoSize = true;
			this.rdOther.Font = new System.Drawing.Font("Andalus", 11F, System.Drawing.FontStyle.Bold);
			this.rdOther.ForeColor = System.Drawing.Color.Teal;
			this.rdOther.Location = new System.Drawing.Point(218, 25);
			this.rdOther.Name = "rdOther";
			this.rdOther.Size = new System.Drawing.Size(98, 38);
			this.rdOther.TabIndex = 8;
			this.rdOther.Text = "Other";
			this.rdOther.UseVisualStyleBackColor = true;
			this.rdOther.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
			this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(631, 324);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(212, 34);
			this.dateTimePicker1.TabIndex = 9;
			this.dateTimePicker1.Value = new System.DateTime(2025, 2, 18, 23, 13, 50, 0);
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// dtpBirthdate
			// 
			this.dtpBirthdate.AutoSize = true;
			this.dtpBirthdate.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
			this.dtpBirthdate.ForeColor = System.Drawing.Color.Teal;
			this.dtpBirthdate.Location = new System.Drawing.Point(477, 323);
			this.dtpBirthdate.Name = "dtpBirthdate";
			this.dtpBirthdate.Size = new System.Drawing.Size(118, 38);
			this.dtpBirthdate.TabIndex = 12;
			this.dtpBirthdate.Text = "Birthdate";
			this.dtpBirthdate.Click += new System.EventHandler(this.label4_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(631, 375);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(212, 35);
			this.comboBox1.TabIndex = 13;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// btnSubmit
			// 
			this.btnSubmit.BackColor = System.Drawing.Color.Teal;
			this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
			this.btnSubmit.FlatAppearance.BorderSize = 2;
			this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
			this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSubmit.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
			this.btnSubmit.ForeColor = System.Drawing.Color.White;
			this.btnSubmit.Location = new System.Drawing.Point(571, 433);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(105, 42);
			this.btnSubmit.TabIndex = 15;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = false;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Font = new System.Drawing.Font("Andalus", 10F, System.Drawing.FontStyle.Bold);
			this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.lblResult.Location = new System.Drawing.Point(42, 348);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(260, 31);
			this.lblResult.TabIndex = 17;
			this.lblResult.Text = "\"Result will be shown here\"";
			this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
			// 
			// cmbCountry
			// 
			this.cmbCountry.AutoSize = true;
			this.cmbCountry.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
			this.cmbCountry.ForeColor = System.Drawing.Color.Teal;
			this.cmbCountry.Location = new System.Drawing.Point(414, 371);
			this.cmbCountry.Name = "cmbCountry";
			this.cmbCountry.Size = new System.Drawing.Size(211, 38);
			this.cmbCountry.TabIndex = 14;
			this.cmbCountry.Text = "Country Selection";
			this.cmbCountry.Click += new System.EventHandler(this.cmbCountry_Click);
			// 
			// btnChooseColor
			// 
			this.btnChooseColor.BackColor = System.Drawing.Color.White;
			this.btnChooseColor.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
			this.btnChooseColor.ForeColor = System.Drawing.Color.Teal;
			this.btnChooseColor.Location = new System.Drawing.Point(481, 272);
			this.btnChooseColor.Name = "btnChooseColor";
			this.btnChooseColor.Size = new System.Drawing.Size(221, 46);
			this.btnChooseColor.TabIndex = 18;
			this.btnChooseColor.Text = "Choose Color ";
			this.btnChooseColor.UseVisualStyleBackColor = false;
			this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(1, -3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(411, 348);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 19;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdMale);
			this.groupBox1.Controls.Add(this.rdFemale);
			this.groupBox1.Controls.Add(this.rdOther);
			this.groupBox1.Font = new System.Drawing.Font("Andalus", 11F, System.Drawing.FontStyle.Bold);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.groupBox1.Location = new System.Drawing.Point(483, 188);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(331, 64);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Gender";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(860, 540);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnChooseColor);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.cmbCountry);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.dtpBirthdate);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtPassword1);
			this.Controls.Add(this.txtEmail1);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtBox1);
			this.ForeColor = System.Drawing.Color.Coral;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Student Registration";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label txtBox1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label txtEmail1;
		private System.Windows.Forms.Label txtPassword1;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.RadioButton rdMale;
		private System.Windows.Forms.RadioButton rdFemale;
		private System.Windows.Forms.RadioButton rdOther;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label dtpBirthdate;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.Label cmbCountry;
		private System.Windows.Forms.Button btnChooseColor;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

