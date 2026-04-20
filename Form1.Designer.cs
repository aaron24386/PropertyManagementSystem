namespace PropertyManagementSystem
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
            this.communityOptions = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.addResidentGroupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.residenceDropDown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.personListBox = new System.Windows.Forms.ListBox();
            this.residenceListBox = new System.Windows.Forms.ListBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.addPropertyGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.garageCheckBox = new System.Windows.Forms.CheckBox();
            this.bedroomInput = new System.Windows.Forms.NumericUpDown();
            this.bathInput = new System.Windows.Forms.NumericUpDown();
            this.floorInput = new System.Windows.Forms.NumericUpDown();
            this.squareFootInput = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.addResidentGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.addPropertyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bedroomInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bathInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareFootInput)).BeginInit();
            this.SuspendLayout();
            // 
            // communityOptions
            // 
            this.communityOptions.FormattingEnabled = true;
            this.communityOptions.Items.AddRange(new object[] {
            "Dekalb",
            "Sycamore"});
            this.communityOptions.Location = new System.Drawing.Point(8, 31);
            this.communityOptions.Name = "communityOptions";
            this.communityOptions.Size = new System.Drawing.Size(121, 24);
            this.communityOptions.TabIndex = 0;
            this.communityOptions.SelectedIndexChanged += new System.EventHandler(this.communityOptionsChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.communityOptions);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 72);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Communities";
            // 
            // addResidentGroupBox1
            // 
            this.addResidentGroupBox1.Controls.Add(this.label5);
            this.addResidentGroupBox1.Controls.Add(this.label4);
            this.addResidentGroupBox1.Controls.Add(this.residenceDropDown);
            this.addResidentGroupBox1.Controls.Add(this.dateTimePicker1);
            this.addResidentGroupBox1.Controls.Add(this.label2);
            this.addResidentGroupBox1.Controls.Add(this.label3);
            this.addResidentGroupBox1.Controls.Add(this.textBox1);
            this.addResidentGroupBox1.Controls.Add(this.textBox2);
            this.addResidentGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addResidentGroupBox1.Location = new System.Drawing.Point(12, 114);
            this.addResidentGroupBox1.Name = "addResidentGroupBox1";
            this.addResidentGroupBox1.Size = new System.Drawing.Size(283, 271);
            this.addResidentGroupBox1.TabIndex = 5;
            this.addResidentGroupBox1.TabStop = false;
            this.addResidentGroupBox1.Text = "Add New Resident";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(9, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 23);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox2.Location = new System.Drawing.Point(9, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(261, 23);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(8, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Occupation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 23);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // residenceDropDown
            // 
            this.residenceDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.residenceDropDown.FormattingEnabled = true;
            this.residenceDropDown.Location = new System.Drawing.Point(11, 198);
            this.residenceDropDown.Name = "residenceDropDown";
            this.residenceDropDown.Size = new System.Drawing.Size(259, 24);
            this.residenceDropDown.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Birthday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Residence";
            // 
            // personListBox
            // 
            this.personListBox.FormattingEnabled = true;
            this.personListBox.ItemHeight = 16;
            this.personListBox.Location = new System.Drawing.Point(594, 43);
            this.personListBox.Name = "personListBox";
            this.personListBox.Size = new System.Drawing.Size(277, 404);
            this.personListBox.TabIndex = 6;
            // 
            // residenceListBox
            // 
            this.residenceListBox.FormattingEnabled = true;
            this.residenceListBox.ItemHeight = 16;
            this.residenceListBox.Location = new System.Drawing.Point(881, 43);
            this.residenceListBox.Name = "residenceListBox";
            this.residenceListBox.Size = new System.Drawing.Size(321, 404);
            this.residenceListBox.TabIndex = 7;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // addPropertyGroupBox
            // 
            this.addPropertyGroupBox.Controls.Add(this.label6);
            this.addPropertyGroupBox.Controls.Add(this.textBox3);
            this.addPropertyGroupBox.Controls.Add(this.squareFootInput);
            this.addPropertyGroupBox.Controls.Add(this.floorInput);
            this.addPropertyGroupBox.Controls.Add(this.bathInput);
            this.addPropertyGroupBox.Controls.Add(this.bedroomInput);
            this.addPropertyGroupBox.Controls.Add(this.garageCheckBox);
            this.addPropertyGroupBox.Controls.Add(this.label11);
            this.addPropertyGroupBox.Controls.Add(this.label10);
            this.addPropertyGroupBox.Controls.Add(this.label7);
            this.addPropertyGroupBox.Controls.Add(this.label8);
            this.addPropertyGroupBox.Controls.Add(this.label9);
            this.addPropertyGroupBox.Controls.Add(this.textBox4);
            this.addPropertyGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPropertyGroupBox.Location = new System.Drawing.Point(301, 114);
            this.addPropertyGroupBox.Name = "addPropertyGroupBox";
            this.addPropertyGroupBox.Size = new System.Drawing.Size(287, 271);
            this.addPropertyGroupBox.TabIndex = 13;
            this.addPropertyGroupBox.TabStop = false;
            this.addPropertyGroupBox.Text = "Add Property";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Bedrooms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label8.Location = new System.Drawing.Point(8, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Square Footage";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Street Address";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox4.Location = new System.Drawing.Point(9, 54);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(211, 23);
            this.textBox4.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(95, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Baths";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(185, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Floors";
            // 
            // garageCheckBox
            // 
            this.garageCheckBox.AutoSize = true;
            this.garageCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.garageCheckBox.Location = new System.Drawing.Point(11, 201);
            this.garageCheckBox.Name = "garageCheckBox";
            this.garageCheckBox.Size = new System.Drawing.Size(86, 21);
            this.garageCheckBox.TabIndex = 13;
            this.garageCheckBox.Text = "Garage?";
            this.garageCheckBox.UseVisualStyleBackColor = true;
            // 
            // bedroomInput
            // 
            this.bedroomInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.bedroomInput.Location = new System.Drawing.Point(11, 159);
            this.bedroomInput.Name = "bedroomInput";
            this.bedroomInput.Size = new System.Drawing.Size(54, 23);
            this.bedroomInput.TabIndex = 10;
            // 
            // bathInput
            // 
            this.bathInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.bathInput.Location = new System.Drawing.Point(98, 159);
            this.bathInput.Name = "bathInput";
            this.bathInput.Size = new System.Drawing.Size(50, 23);
            this.bathInput.TabIndex = 11;
            // 
            // floorInput
            // 
            this.floorInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.floorInput.Location = new System.Drawing.Point(188, 159);
            this.floorInput.Name = "floorInput";
            this.floorInput.Size = new System.Drawing.Size(50, 23);
            this.floorInput.TabIndex = 12;
            // 
            // squareFootInput
            // 
            this.squareFootInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.squareFootInput.Location = new System.Drawing.Point(11, 104);
            this.squareFootInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.squareFootInput.Name = "squareFootInput";
            this.squareFootInput.Size = new System.Drawing.Size(107, 23);
            this.squareFootInput.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox3.Location = new System.Drawing.Point(226, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(55, 23);
            this.textBox3.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(228, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Apt. #";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 512);
            this.Controls.Add(this.addPropertyGroupBox);
            this.Controls.Add(this.residenceListBox);
            this.Controls.Add(this.personListBox);
            this.Controls.Add(this.addResidentGroupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.addResidentGroupBox1.ResumeLayout(false);
            this.addResidentGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.addPropertyGroupBox.ResumeLayout(false);
            this.addPropertyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bedroomInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bathInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareFootInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox communityOptions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox addResidentGroupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox residenceDropDown;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox personListBox;
        private System.Windows.Forms.ListBox residenceListBox;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox addPropertyGroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox garageCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown squareFootInput;
        private System.Windows.Forms.NumericUpDown floorInput;
        private System.Windows.Forms.NumericUpDown bathInput;
        private System.Windows.Forms.NumericUpDown bedroomInput;
    }
}