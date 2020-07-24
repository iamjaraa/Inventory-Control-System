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

namespace Csharp_Project
{
    public partial class FormSupplier : Form
    {
        public FormSupplier()
        {
            InitializeComponent();
        }
        SqlConnection con;
      
        
        
        

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SHOLABASH\Music\Csharp_inventory_management_system\Csharp_Project\Csharp_Project\MY_DB.mdf;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select * from suppliers ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



  




            

            
        }

        private void FormSupplier_Click(object sender, EventArgs e)
        {
            
        }

        private void BTN_NEW_USER_Click(object sender, EventArgs e)
        {
          
           
        
        
        }

        private void PANEL_MIN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PANEL_MIN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PANEL_MIN_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void PANEL_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SHOLABASH\Music\Csharp_inventory_management_system\Csharp_Project\Csharp_Project\MY_DB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("insert into suppliers values ('" + TB_ID.Text + "','" + TB_USERNAME.Text + "','" + TB_FULLNAME.Text + "','" + TB_PASSWORD.Text + "','" + TB_good.Text + "','" + textBox1.Text + "','" + TB_TEL.Text + "');", con);
            object o = sc.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("You have  Successfully Submitted", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TB_ID.Clear();
            TB_USERNAME.Clear();
            TB_FULLNAME.Clear();
            TB_PASSWORD.Clear();
            TB_good.Clear();
            textBox1.Clear();
            TB_TEL.Clear();
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SHOLABASH\Music\Csharp_inventory_management_system\Csharp_Project\Csharp_Project\MY_DB.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * From suppliers ", con);
            DataTable dt = new DataTable();
            sda.Update(dt);
            MessageBox.Show("You have  Successfully Updated your Status", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
      


            }
    }
}
