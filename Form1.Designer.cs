
namespace AccountRegistration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentNo = new System.Windows.Forms.Label();
            this.program = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.middleName = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.contactNo = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.middleNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.contactBox = new System.Windows.Forms.TextBox();
            this.studentNoBox = new System.Windows.Forms.TextBox();
            this.programBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();


            this.SuspendLayout();


            this.studentNo.AutoSize = true;
            this.studentNo.Location = new System.Drawing.Point(44, 29);
            this.studentNo.Name = "Student No";
            this.studentNo.Size = new System.Drawing.Size(38, 15);
            this.studentNo.TabIndex = 0;
            this.studentNo.Text = "Student No";


            this.program.AutoSize = true;
            this.program.Location = new System.Drawing.Point(257, 29);
            this.program.Name = "Program";
            this.program.Size = new System.Drawing.Size(38, 15);
            this.program.TabIndex = 1;
            this.program.Text = "Program";


            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(44, 92);
            this.lastName.Name = "Last Name";
            this.lastName.Size = new System.Drawing.Size(38, 15);
            this.lastName.TabIndex = 3;
            this.lastName.Text = "Last Name";


            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(257, 92);
            this.firstName.Name = "First Name";
            this.firstName.Size = new System.Drawing.Size(38, 15);
            this.firstName.TabIndex = 2;
            this.firstName.Text = "First Name";


            this.middleName.AutoSize = true;
            this.middleName.Location = new System.Drawing.Point(469, 92);
            this.middleName.Name = "Middle Name";
            this.middleName.Size = new System.Drawing.Size(38, 15);
            this.middleName.TabIndex = 4;
            this.middleName.Text = "Middle Name";


            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(44, 159);
            this.age.Name = "Age";
            this.age.Size = new System.Drawing.Size(38, 15);
            this.age.TabIndex = 5;
            this.age.Text = "Age";


            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(44, 225);
            this.address.Name = "Address";
            this.address.Size = new System.Drawing.Size(38, 15);
            this.address.TabIndex = 6;
            this.address.Text = "Address";


            this.contactNo.AutoSize = true;
            this.contactNo.Location = new System.Drawing.Point(257, 159);
            this.contactNo.Name = "Contact No";
            this.contactNo.Size = new System.Drawing.Size(38, 15);
            this.contactNo.TabIndex = 7;
            this.contactNo.Text = "Contact No";
             
             
            this.studentNoBox.Location = new System.Drawing.Point(44, 47);
            this.studentNoBox.Name = "textBox6";
            this.studentNoBox.Size = new System.Drawing.Size(207, 23);
            this.studentNoBox.TabIndex = 14;
            
             
            this.programBox.Location = new System.Drawing.Point(257, 47);
            this.programBox.Name = "textBox7";
            this.programBox.Size = new System.Drawing.Size(313, 23);
            this.programBox.TabIndex = 15;


            this.lastNameBox.Location = new System.Drawing.Point(44, 110);
            this.lastNameBox.Name = "textBox2";
            this.lastNameBox.Size = new System.Drawing.Size(207, 23);
            this.lastNameBox.TabIndex = 11;
            

            this.firstNameBox.Location = new System.Drawing.Point(257, 110);
            this.firstNameBox.Name = "textBox3";
            this.firstNameBox.Size = new System.Drawing.Size(207, 23);
            this.firstNameBox.TabIndex = 10;


            this.middleNameBox.Location = new System.Drawing.Point(469, 110);
            this.middleNameBox.Name = "textBox1";
            this.middleNameBox.Size = new System.Drawing.Size(207, 23);
            this.middleNameBox.TabIndex = 8;


            this.ageBox.Location = new System.Drawing.Point(44, 177);
            this.ageBox.Name = "textBox4";
            this.ageBox.Size = new System.Drawing.Size(207, 23);
            this.ageBox.TabIndex = 12;
            
             
            this.contactBox.Location = new System.Drawing.Point(257, 177);
            this.contactBox.Name = "textBox5";
            this.contactBox.Size = new System.Drawing.Size(207, 23);
            this.contactBox.TabIndex = 13;


            this.addressBox.Location = new System.Drawing.Point(44, 243);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "textBox8";
            this.addressBox.Size = new System.Drawing.Size(708, 153);
            this.addressBox.TabIndex = 16;


            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.programBox);
            this.Controls.Add(this.studentNoBox);
            this.Controls.Add(this.contactBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.middleNameBox);
            this.Controls.Add(this.address);
            this.Controls.Add(this.contactNo);
            this.Controls.Add(this.age);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.program);
            this.Controls.Add(this.studentNo);
            this.Name = "FrmRegistration";
            this.Text = "FrmRegistration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentNo;
        private System.Windows.Forms.Label program;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label middleName;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label contactNo;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox middleNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox contactBox;
        private System.Windows.Forms.TextBox studentNoBox;
        private System.Windows.Forms.TextBox programBox;
        private System.Windows.Forms.TextBox addressBox;
    }
}

