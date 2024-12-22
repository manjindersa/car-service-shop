namespace Car_Service_Shop
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPhone = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            groupBox2 = new GroupBox();
            numYear = new NumericUpDown();
            label9 = new Label();
            label8 = new Label();
            txtCost = new TextBox();
            chkAirFilter = new CheckBox();
            chkTransmission = new CheckBox();
            chkEngineOil = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtColour = new TextBox();
            txtModel = new TextBox();
            cboMake = new ComboBox();
            btnAdd = new Button();
            btnNew = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnRemoveAll = new Button();
            btnExit = new Button();
            groupBox3 = new GroupBox();
            lstServices = new ListView();
            no = new ColumnHeader();
            firstName = new ColumnHeader();
            lastName = new ColumnHeader();
            phone = new ColumnHeader();
            make = new ColumnHeader();
            model = new ColumnHeader();
            year = new ColumnHeader();
            colour = new ColumnHeader();
            col_services = new ColumnHeader();
            cost = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 195);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 53);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 1;
            label1.Text = "&First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 95);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 2;
            label2.Text = "&Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 137);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 3;
            label3.Text = "&Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(126, 134);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(206, 31);
            txtPhone.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(126, 92);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(206, 31);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(126, 50);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(206, 31);
            txtFirstName.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numYear);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtCost);
            groupBox2.Controls.Add(chkAirFilter);
            groupBox2.Controls.Add(chkTransmission);
            groupBox2.Controls.Add(chkEngineOil);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtColour);
            groupBox2.Controls.Add(txtModel);
            groupBox2.Controls.Add(cboMake);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(359, 401);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Car Information";
            // 
            // numYear
            // 
            numYear.Location = new Point(126, 137);
            numYear.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(206, 31);
            numYear.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 338);
            label9.Name = "label9";
            label9.Size = new Size(52, 25);
            label9.TabIndex = 12;
            label9.Text = "Co&st:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 223);
            label8.Name = "label8";
            label8.Size = new Size(79, 25);
            label8.TabIndex = 11;
            label8.Text = "&Services:";
            // 
            // txtCost
            // 
            txtCost.Enabled = false;
            txtCost.Location = new Point(126, 335);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(206, 31);
            txtCost.TabIndex = 17;
            // 
            // chkAirFilter
            // 
            chkAirFilter.AutoSize = true;
            chkAirFilter.Location = new Point(126, 290);
            chkAirFilter.Name = "chkAirFilter";
            chkAirFilter.Size = new Size(164, 29);
            chkAirFilter.TabIndex = 9;
            chkAirFilter.Text = "Air &Filter Change";
            chkAirFilter.UseVisualStyleBackColor = true;
            // 
            // chkTransmission
            // 
            chkTransmission.AutoSize = true;
            chkTransmission.Location = new Point(126, 255);
            chkTransmission.Name = "chkTransmission";
            chkTransmission.Size = new Size(227, 29);
            chkTransmission.TabIndex = 8;
            chkTransmission.Text = "&Transmission Oil Change";
            chkTransmission.UseVisualStyleBackColor = true;
            // 
            // chkEngineOil
            // 
            chkEngineOil.AutoSize = true;
            chkEngineOil.Location = new Point(126, 222);
            chkEngineOil.Name = "chkEngineOil";
            chkEngineOil.Size = new Size(179, 29);
            chkEngineOil.TabIndex = 7;
            chkEngineOil.Text = "Engine &Oil Change";
            chkEngineOil.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 183);
            label7.Name = "label7";
            label7.Size = new Size(69, 25);
            label7.TabIndex = 7;
            label7.Text = "C&olour:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 139);
            label6.Name = "label6";
            label6.Size = new Size(48, 25);
            label6.TabIndex = 6;
            label6.Text = "&Year:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 97);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 5;
            label5.Text = "M&odel:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 53);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 4;
            label4.Text = "&Make:";
            // 
            // txtColour
            // 
            txtColour.Location = new Point(126, 180);
            txtColour.Name = "txtColour";
            txtColour.Size = new Size(206, 31);
            txtColour.TabIndex = 6;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(126, 94);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(206, 31);
            txtModel.TabIndex = 4;
            // 
            // cboMake
            // 
            cboMake.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMake.FormattingEnabled = true;
            cboMake.Location = new Point(127, 51);
            cboMake.Name = "cboMake";
            cboMake.Size = new Size(206, 33);
            cboMake.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(402, 661);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 38);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(528, 661);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(120, 38);
            btnNew.TabIndex = 11;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(654, 661);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 38);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemove.Location = new Point(780, 661);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(120, 38);
            btnRemove.TabIndex = 13;
            btnRemove.Text = "&Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnRemoveAll
            // 
            btnRemoveAll.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveAll.Location = new Point(906, 661);
            btnRemoveAll.Name = "btnRemoveAll";
            btnRemoveAll.Size = new Size(120, 38);
            btnRemoveAll.TabIndex = 14;
            btnRemoveAll.Text = "Re&move All";
            btnRemoveAll.UseVisualStyleBackColor = true;
            btnRemoveAll.Click += btnRemoveAll_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(1032, 661);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 38);
            btnExit.TabIndex = 15;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lstServices);
            groupBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(397, 13);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1191, 627);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Car Service Summary";
            // 
            // lstServices
            // 
            lstServices.Columns.AddRange(new ColumnHeader[] { no, firstName, lastName, phone, make, model, year, colour, col_services, cost });
            lstServices.FullRowSelect = true;
            lstServices.GridLines = true;
            lstServices.HoverSelection = true;
            lstServices.Location = new Point(6, 50);
            lstServices.Name = "lstServices";
            lstServices.Size = new Size(1180, 559);
            lstServices.TabIndex = 16;
            lstServices.UseCompatibleStateImageBehavior = false;
            lstServices.View = View.Details;
            lstServices.SelectedIndexChanged += lstServices_SelectedIndexChanged;
            // 
            // no
            // 
            no.Text = "No.";
            no.Width = 50;
            // 
            // firstName
            // 
            firstName.Text = "First Name";
            firstName.Width = 130;
            // 
            // lastName
            // 
            lastName.Text = "Last Name";
            lastName.Width = 130;
            // 
            // phone
            // 
            phone.Text = "Phone";
            phone.Width = 130;
            // 
            // make
            // 
            make.Text = "Make";
            make.Width = 130;
            // 
            // model
            // 
            model.Text = "Model";
            model.Width = 100;
            // 
            // year
            // 
            year.Text = "Year";
            year.Width = 65;
            // 
            // colour
            // 
            colour.Text = "Colour";
            colour.Width = 70;
            // 
            // col_services
            // 
            col_services.Text = "Services";
            col_services.Width = 280;
            // 
            // cost
            // 
            cost.Text = "Cost";
            cost.Width = 90;
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            CancelButton = btnExit;
            ClientSize = new Size(1600, 716);
            Controls.Add(groupBox3);
            Controls.Add(btnExit);
            Controls.Add(btnRemoveAll);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(btnAdd);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Service Shop Management System";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPhone;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private GroupBox groupBox2;
        private TextBox txtColour;
        private TextBox txtModel;
        private ComboBox cboMake;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private CheckBox chkAirFilter;
        private CheckBox chkTransmission;
        private CheckBox chkEngineOil;
        private TextBox txtCost;
        private Label label9;
        private Label label8;
        private Button btnAdd;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnRemoveAll;
        private Button btnExit;
        private GroupBox groupBox3;
        private ListView lstServices;
        private ColumnHeader no;
        private ColumnHeader firstName;
        private ColumnHeader lastName;
        private ColumnHeader phone;
        private ColumnHeader make;
        private ColumnHeader model;
        private ColumnHeader year;
        private ColumnHeader colour;
        private ColumnHeader col_services;
        private ColumnHeader cost;
        private NumericUpDown numYear;
    }
}
