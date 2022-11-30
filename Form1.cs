using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace EmployeeRecordSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        SqlConnection conn = new SqlConnection("Data Source=BGB-PC\\SQLEXPRESS;Initial Catalog=PersonelKayıt;Integrated Security=True");
        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelKayıtDataSet.PersonalRegister' table. You can move, or remove it, as needed.
            this.personalRegisterTableAdapter.Fill(this.personelKayıtDataSet.PersonalRegister);
            if(txtID.Text == "")
            {
                //txtID.ForeColor = Color.Gray;
                //txtID.Text = "Type id here.";   
            }

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.personalRegisterTableAdapter.Fill(this.personelKayıtDataSet.PersonalRegister);
            SqlConnection cnn = new SqlConnection("Data Source=BGB-PC\\SQLEXPRESS;Initial Catalog=PersonelKayıt;Integrated Security=True");
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.PersonalRegister;", cnn);
            cmd.ExecuteNonQuery();
            int numberOfRecordedEmployees = (int)cmd.ExecuteScalar();
            this.lblNumOfRecordedEmployees.Text = "Number of Currently Recorded Employees: " + Convert.ToString(numberOfRecordedEmployees);
            cnn.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtFirstName.Text == "")
            {
                MessageBox.Show("You must enter a name.");
            }
            else
            {
                conn.Open();
                SqlCommand command = new SqlCommand("insert into PersonalRegister (EmployeeID, EmployeeFirstName, EmployeeLastName, EmployeeAge, EmployeeCity, EmployeeSalary, EmployeeProfession, EmployeeMaritialStatus) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", conn);
                command.Parameters.AddWithValue("@p1", txtID.Text);
                command.Parameters.AddWithValue("@p2", txtFirstName.Text);
                command.Parameters.AddWithValue("@p3", txtLastName.Text);
                command.Parameters.AddWithValue("@p4", txtAge.Text);
                command.Parameters.AddWithValue("@p5", comboBoxCity.Text);
                command.Parameters.AddWithValue("@p6", maskedtxtSalary.Text);
                command.Parameters.AddWithValue("@p7", txtProfession.Text);
                
                if(rdMarried.Checked)
                {
                    lblMarriedOrNot.Text = "Married";
                } else
                {
                    lblMarriedOrNot.Text = "Single";
                }
                command.Parameters.AddWithValue("@p8", lblMarriedOrNot.Text);
                //command.Parameters.AddWithValue("@p8",txtID.Text);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Employee added succesfully.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand delete = new SqlCommand("Delete from PersonalRegister where EmployeeID=@p1", conn);
            delete.Parameters.AddWithValue("@p1", txtID.Text);
            delete.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record deleted successfully.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand update = new SqlCommand("update PersonalRegister set EmployeeFirstName=@p2, EmployeeLastName=@p3, EmployeeAge=@p4, EmployeeCity=@p5, EmployeeMaritialStatus=@p6,EmployeeSalary=@p7, EmployeeProfession=@p8 where EmployeeId=@p9", conn);
            update.Parameters.AddWithValue("p2", txtFirstName.Text);
            update.Parameters.AddWithValue("p3", txtLastName.Text);
            update.Parameters.AddWithValue("p4", txtAge.Text);
            update.Parameters.AddWithValue("p5", comboBoxCity.Text);
            update.Parameters.AddWithValue("p6", rdMarried.Text);
            update.Parameters.AddWithValue("p7", maskedtxtSalary.Text);
            update.Parameters.AddWithValue("p8", txtProfession.Text);
            update.Parameters.AddWithValue("p9", txtID.Text);
            update.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Employee information updated successfully.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAge.Text = "";
            comboBoxCity.Text = "";
            rdMarried.Checked = false;
            rdSingle.Checked = false;   
            maskedtxtSalary.Text = "";
            txtProfession.Text = "";
            txtID.Focus();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selection = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[selection].Cells[0].Value.ToString();
            txtFirstName.Text = dataGridView1.Rows[selection].Cells[1].Value.ToString();
            txtLastName.Text = dataGridView1.Rows[selection].Cells[2].Value.ToString();
            txtAge.Text = dataGridView1.Rows[selection].Cells[3].Value.ToString();
            comboBoxCity.Text = dataGridView1.Rows[selection].Cells[4].Value.ToString();
            lblMarriedOrNot.Text = dataGridView1.Rows[selection].Cells[5].Value.ToString();
            maskedtxtSalary.Text = dataGridView1.Rows[selection].Cells[6].Value.ToString();
            txtProfession.Text = dataGridView1.Rows[selection].Cells[7].Value.ToString();


                                
        }

        //private void label1_Click(object sender, EventArgs e)
        //{
        //    if(lblMarriedOrNot.Text == "True")
        //    {
        //        rdSingle.Checked = true;    
        //    } 
        //    if (lblMarriedOrNot.Text == "False")
        //    {
        //        rdMarried.Checked = true;
        //    }
        //}

        //private void rdSingle_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rdSingle.Checked)
        //    {
        //        lblMarriedOrNot.Text = "True";
        //    }
        //}

        //private void rdMarried_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rdMarried.Checked)
        //    {
        //        lblMarriedOrNot.Text = "False";
        //    }
        //}

        private void lblMarriedOrNot_TextChanged(object sender, EventArgs e)
        {
            if (lblMarriedOrNot.Text == "Married")
            {
                rdMarried.Checked = true;   
            }

            if(lblMarriedOrNot.Text == "Single")
            {
                rdSingle.Checked = true;
            }
        }

        private void btnList_MouseEnter(object sender, EventArgs e)
        {
            btnList.BackColor = Color.FromArgb(200,200, 200); 
        }

        private void btnList_MouseLeave(object sender, EventArgs e)
        {
            btnList.BackColor = Color.WhiteSmoke;
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.WhiteSmoke;
        }


        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.WhiteSmoke;
        }

        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.WhiteSmoke;
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.WhiteSmoke;
        }

        
    }
}
