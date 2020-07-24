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
    public partial class supplierreg : Form
    {
        public supplierreg()
        {
            InitializeComponent();
        }

        private void supplierreg_Load(object sender, EventArgs e)
        {

        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=god;Initial Catalog=Life Line Project;Integrated Security=True");
            SqlCommand command = new SqlCommand();
        }
    }
}
