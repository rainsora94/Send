using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Send
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FOPG83K;Initial Catalog=TableDependencyDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        int ID = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("  Select * from Customers", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void ClearData()
        {
            txtMachineName.Text = "";
            txtType.Text = "";
            ID = 0;
        }
        private void txtSend_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtMachineName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtType.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMachineName.Text != "" && txtType.Text != "")
            {
                //Test broker
                var sendCmd = @"
    BEGIN TRANSACTION; 

    DECLARE @cid UNIQUEIDENTIFIER;
    DECLARE @xml XML = @message;

/* Begin dialog the conversation id into this variable. */
    BEGIN DIALOG @cid FROM SERVICE [/AVAILH/xml/InitService] 
        TO SERVICE N'/AVAILH/xml/CreateFile' 
        ON CONTRACT [/AVAILH/xml/Contract] 
        WITH ENCRYPTION = OFF; 

    SEND ON CONVERSATION @cid 
        MESSAGE TYPE [/AVAILH/xml/CreateFile] (@xml); 

/* if you don't do this you will have converations open forever unless 
   you clean them up later */
    END CONVERSATION @cid; 

    COMMIT TRANSACTION;
";

                cmd = new SqlCommand("insert into Customers(MachineName,Type,MachineStatus) values(@MachineName,@Type,@MachineStatus)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@MachineName", txtMachineName.Text);
                cmd.Parameters.AddWithValue("@Type", txtType.Text);

                //Test Broker
                cmd.Parameters.AddWithValue("@message", sendCmd);

                string value = "";
                bool OnHoldCheck = radOnHold.Checked;
                bool StopCheck = radStop.Checked;
                bool WorkingCheck = radWorking.Checked;

                

                if (OnHoldCheck)    value = radOnHold.Text;               
                if (StopCheck) value = radStop.Text;                   
                else if (WorkingCheck) value = radWorking.Text;

                cmd.Parameters.AddWithValue("@MachineStatus", value);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void radWorking_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radOnHold_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radStop_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
