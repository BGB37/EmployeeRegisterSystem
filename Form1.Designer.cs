using System;
using System.Data.SqlClient;

namespace EmployeeRecordSystem
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxEmployeeRegister = new System.Windows.Forms.GroupBox();
            this.txtProfession = new System.Windows.Forms.TextBox();
            this.maskedtxtSalary = new System.Windows.Forms.MaskedTextBox();
            this.rdMarried = new System.Windows.Forms.RadioButton();
            this.rdSingle = new System.Windows.Forms.RadioButton();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblProfession = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblMaritialStatus = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.groupBoxDataBase = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeMaritialStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeProfessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelKayıtDataSet = new EmployeeRecordSystem.PersonelKayıtDataSet();
            this.personalRegisterTableAdapter = new EmployeeRecordSystem.PersonelKayıtDataSetTableAdapters.PersonalRegisterTableAdapter();
            this.lblMarriedOrNot = new System.Windows.Forms.Label();
            this.lblNumOfRecordedEmployees = new System.Windows.Forms.Label();
            this.groupBoxEmployeeRegister.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.groupBoxDataBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalRegisterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelKayıtDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEmployeeRegister
            // 
            this.groupBoxEmployeeRegister.Controls.Add(this.txtProfession);
            this.groupBoxEmployeeRegister.Controls.Add(this.maskedtxtSalary);
            this.groupBoxEmployeeRegister.Controls.Add(this.rdMarried);
            this.groupBoxEmployeeRegister.Controls.Add(this.rdSingle);
            this.groupBoxEmployeeRegister.Controls.Add(this.comboBoxCity);
            this.groupBoxEmployeeRegister.Controls.Add(this.textBox5);
            this.groupBoxEmployeeRegister.Controls.Add(this.txtAge);
            this.groupBoxEmployeeRegister.Controls.Add(this.txtLastName);
            this.groupBoxEmployeeRegister.Controls.Add(this.txtFirstName);
            this.groupBoxEmployeeRegister.Controls.Add(this.txtID);
            this.groupBoxEmployeeRegister.Controls.Add(this.lblProfession);
            this.groupBoxEmployeeRegister.Controls.Add(this.lblSalary);
            this.groupBoxEmployeeRegister.Controls.Add(this.lblMaritialStatus);
            this.groupBoxEmployeeRegister.Controls.Add(this.lblCity);
            this.groupBoxEmployeeRegister.Controls.Add(this.lblAge);
            this.groupBoxEmployeeRegister.Controls.Add(this.lblLastName);
            this.groupBoxEmployeeRegister.Controls.Add(this.label2);
            this.groupBoxEmployeeRegister.Controls.Add(this.lblID);
            this.groupBoxEmployeeRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxEmployeeRegister.Location = new System.Drawing.Point(29, 31);
            this.groupBoxEmployeeRegister.Name = "groupBoxEmployeeRegister";
            this.groupBoxEmployeeRegister.Size = new System.Drawing.Size(200, 231);
            this.groupBoxEmployeeRegister.TabIndex = 0;
            this.groupBoxEmployeeRegister.TabStop = false;
            this.groupBoxEmployeeRegister.Text = "Employee Register";
            // 
            // txtProfession
            // 
            this.txtProfession.Location = new System.Drawing.Point(72, 197);
            this.txtProfession.Name = "txtProfession";
            this.txtProfession.Size = new System.Drawing.Size(100, 21);
            this.txtProfession.TabIndex = 8;
            // 
            // maskedtxtSalary
            // 
            this.maskedtxtSalary.Location = new System.Drawing.Point(50, 167);
            this.maskedtxtSalary.Mask = "00000";
            this.maskedtxtSalary.Name = "maskedtxtSalary";
            this.maskedtxtSalary.Size = new System.Drawing.Size(100, 21);
            this.maskedtxtSalary.TabIndex = 7;
            this.maskedtxtSalary.ValidatingType = typeof(int);
            // 
            // rdMarried
            // 
            this.rdMarried.AutoSize = true;
            this.rdMarried.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdMarried.Location = new System.Drawing.Point(139, 142);
            this.rdMarried.Name = "rdMarried";
            this.rdMarried.Size = new System.Drawing.Size(55, 16);
            this.rdMarried.TabIndex = 6;
            this.rdMarried.TabStop = true;
            this.rdMarried.Text = "Married";
            this.rdMarried.UseVisualStyleBackColor = true;
            // 
            // rdSingle
            // 
            this.rdSingle.AutoSize = true;
            this.rdSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdSingle.Location = new System.Drawing.Point(85, 142);
            this.rdSingle.Name = "rdSingle";
            this.rdSingle.Size = new System.Drawing.Size(48, 16);
            this.rdSingle.TabIndex = 5;
            this.rdSingle.TabStop = true;
            this.rdSingle.Text = "Single";
            this.rdSingle.UseVisualStyleBackColor = true;
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.ItemHeight = 15;
            this.comboBoxCity.Items.AddRange(new object[] {
            "Texas",
            "Indianapolis",
            "Chicago",
            "California",
            "New York",
            "Montana"});
            this.comboBoxCity.Location = new System.Drawing.Point(40, 115);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(115, 23);
            this.comboBoxCity.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(40, 115);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(0, 21);
            this.textBox5.TabIndex = 14;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(42, 92);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(37, 21);
            this.txtAge.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(71, 70);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(123, 21);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(50, 48);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(144, 21);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(34, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(160, 21);
            this.txtID.TabIndex = 0;
            // 
            // lblProfession
            // 
            this.lblProfession.AutoSize = true;
            this.lblProfession.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProfession.Location = new System.Drawing.Point(8, 200);
            this.lblProfession.Name = "lblProfession";
            this.lblProfession.Size = new System.Drawing.Size(59, 13);
            this.lblProfession.TabIndex = 9;
            this.lblProfession.Text = "Profession:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalary.Location = new System.Drawing.Point(8, 170);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(39, 13);
            this.lblSalary.TabIndex = 8;
            this.lblSalary.Text = "Salary:";
            // 
            // lblMaritialStatus
            // 
            this.lblMaritialStatus.AutoSize = true;
            this.lblMaritialStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaritialStatus.Location = new System.Drawing.Point(6, 142);
            this.lblMaritialStatus.Name = "lblMaritialStatus";
            this.lblMaritialStatus.Size = new System.Drawing.Size(73, 13);
            this.lblMaritialStatus.TabIndex = 7;
            this.lblMaritialStatus.Text = "MaritialStatus:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCity.Location = new System.Drawing.Point(8, 118);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City:";
            this.lblCity.Click += new System.EventHandler(this.lblCity_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAge.Location = new System.Drawing.Point(6, 95);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Age:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastName.Location = new System.Drawing.Point(6, 70);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.Location = new System.Drawing.Point(6, 27);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID:";
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.btnClear);
            this.groupBoxOptions.Controls.Add(this.btnUpdate);
            this.groupBoxOptions.Controls.Add(this.btnDelete);
            this.groupBoxOptions.Controls.Add(this.btnSave);
            this.groupBoxOptions.Controls.Add(this.btnList);
            this.groupBoxOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxOptions.Location = new System.Drawing.Point(289, 31);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(174, 231);
            this.groupBoxOptions.TabIndex = 1;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(40, 170);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(40, 132);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.btnUpdate_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(40, 95);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(40, 56);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnList.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(40, 19);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(98, 23);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            this.btnList.MouseEnter += new System.EventHandler(this.btnList_MouseEnter);
            this.btnList.MouseLeave += new System.EventHandler(this.btnList_MouseLeave);
            // 
            // groupBoxDataBase
            // 
            this.groupBoxDataBase.Controls.Add(this.dataGridView1);
            this.groupBoxDataBase.Location = new System.Drawing.Point(29, 269);
            this.groupBoxDataBase.Name = "groupBoxDataBase";
            this.groupBoxDataBase.Size = new System.Drawing.Size(854, 169);
            this.groupBoxDataBase.TabIndex = 2;
            this.groupBoxDataBase.TabStop = false;
            this.groupBoxDataBase.Text = "Records";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.employeeFirstNameDataGridViewTextBoxColumn,
            this.employeeLastNameDataGridViewTextBoxColumn,
            this.employeeAgeDataGridViewTextBoxColumn,
            this.employeeCityDataGridViewTextBoxColumn,
            this.employeeMaritialStatusDataGridViewTextBoxColumn,
            this.employeeSalaryDataGridViewTextBoxColumn,
            this.employeeProfessionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personalRegisterBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(848, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            // 
            // employeeFirstNameDataGridViewTextBoxColumn
            // 
            this.employeeFirstNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeFirstName";
            this.employeeFirstNameDataGridViewTextBoxColumn.HeaderText = "EmployeeFirstName";
            this.employeeFirstNameDataGridViewTextBoxColumn.Name = "employeeFirstNameDataGridViewTextBoxColumn";
            // 
            // employeeLastNameDataGridViewTextBoxColumn
            // 
            this.employeeLastNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeLastName";
            this.employeeLastNameDataGridViewTextBoxColumn.HeaderText = "EmployeeLastName";
            this.employeeLastNameDataGridViewTextBoxColumn.Name = "employeeLastNameDataGridViewTextBoxColumn";
            // 
            // employeeAgeDataGridViewTextBoxColumn
            // 
            this.employeeAgeDataGridViewTextBoxColumn.DataPropertyName = "EmployeeAge";
            this.employeeAgeDataGridViewTextBoxColumn.HeaderText = "EmployeeAge";
            this.employeeAgeDataGridViewTextBoxColumn.Name = "employeeAgeDataGridViewTextBoxColumn";
            // 
            // employeeCityDataGridViewTextBoxColumn
            // 
            this.employeeCityDataGridViewTextBoxColumn.DataPropertyName = "EmployeeCity";
            this.employeeCityDataGridViewTextBoxColumn.HeaderText = "EmployeeCity";
            this.employeeCityDataGridViewTextBoxColumn.Name = "employeeCityDataGridViewTextBoxColumn";
            // 
            // employeeMaritialStatusDataGridViewTextBoxColumn
            // 
            this.employeeMaritialStatusDataGridViewTextBoxColumn.DataPropertyName = "EmployeeMaritialStatus";
            this.employeeMaritialStatusDataGridViewTextBoxColumn.HeaderText = "EmployeeMaritialStatus";
            this.employeeMaritialStatusDataGridViewTextBoxColumn.Name = "employeeMaritialStatusDataGridViewTextBoxColumn";
            // 
            // employeeSalaryDataGridViewTextBoxColumn
            // 
            this.employeeSalaryDataGridViewTextBoxColumn.DataPropertyName = "EmployeeSalary";
            this.employeeSalaryDataGridViewTextBoxColumn.HeaderText = "EmployeeSalary";
            this.employeeSalaryDataGridViewTextBoxColumn.Name = "employeeSalaryDataGridViewTextBoxColumn";
            // 
            // employeeProfessionDataGridViewTextBoxColumn
            // 
            this.employeeProfessionDataGridViewTextBoxColumn.DataPropertyName = "EmployeeProfession";
            this.employeeProfessionDataGridViewTextBoxColumn.HeaderText = "EmployeeProfession";
            this.employeeProfessionDataGridViewTextBoxColumn.Name = "employeeProfessionDataGridViewTextBoxColumn";
            // 
            // personalRegisterBindingSource
            // 
            this.personalRegisterBindingSource.DataMember = "PersonalRegister";
            this.personalRegisterBindingSource.DataSource = this.personelKayıtDataSet;
            // 
            // personelKayıtDataSet
            // 
            this.personelKayıtDataSet.DataSetName = "PersonelKayıtDataSet";
            this.personelKayıtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalRegisterTableAdapter
            // 
            this.personalRegisterTableAdapter.ClearBeforeFill = true;
            // 
            // lblMarriedOrNot
            // 
            this.lblMarriedOrNot.AutoSize = true;
            this.lblMarriedOrNot.Location = new System.Drawing.Point(576, 50);
            this.lblMarriedOrNot.Name = "lblMarriedOrNot";
            this.lblMarriedOrNot.Size = new System.Drawing.Size(35, 13);
            this.lblMarriedOrNot.TabIndex = 3;
            this.lblMarriedOrNot.Text = "label1";
            this.lblMarriedOrNot.Visible = false;
            this.lblMarriedOrNot.TextChanged += new System.EventHandler(this.lblMarriedOrNot_TextChanged);
            // 
            // lblNumOfRecordedEmployees
            // 
            this.lblNumOfRecordedEmployees.AutoSize = true;
            this.lblNumOfRecordedEmployees.Location = new System.Drawing.Point(718, 49);
            this.lblNumOfRecordedEmployees.Name = "lblNumOfRecordedEmployees";
            this.lblNumOfRecordedEmployees.Size = new System.Drawing.Size(154, 13);
            this.lblNumOfRecordedEmployees.TabIndex = 4;
            //SqlConnection cnn = new SqlConnection("Data Source=BGB-PC\\SQLEXPRESS;Initial Catalog=PersonelKayıt;Integrated Security=True");
            //cnn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.PersonalRegister;", cnn);
            //cmd.ExecuteNonQuery();
            //int numberOfRecordedEmployees = (int)cmd.ExecuteScalar();
            //this.lblNumOfRecordedEmployees.Text = "Number of Currently Recorded Employees: " + Convert.ToString(numberOfRecordedEmployees);
            //cnn.Close();

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.lblNumOfRecordedEmployees);
            this.Controls.Add(this.lblMarriedOrNot);
            this.Controls.Add(this.groupBoxDataBase);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.groupBoxEmployeeRegister);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxEmployeeRegister.ResumeLayout(false);
            this.groupBoxEmployeeRegister.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxDataBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalRegisterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelKayıtDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEmployeeRegister;
        private System.Windows.Forms.Label lblProfession;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblMaritialStatus;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton rdMarried;
        private System.Windows.Forms.RadioButton rdSingle;
        private System.Windows.Forms.MaskedTextBox maskedtxtSalary;
        private System.Windows.Forms.TextBox txtProfession;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.GroupBox groupBoxDataBase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelKayıtDataSet personelKayıtDataSet;
        private System.Windows.Forms.BindingSource personalRegisterBindingSource;
        private PersonelKayıtDataSetTableAdapters.PersonalRegisterTableAdapter personalRegisterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeMaritialStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeProfessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblMarriedOrNot;
        private System.Windows.Forms.Label lblNumOfRecordedEmployees;
    }
}

