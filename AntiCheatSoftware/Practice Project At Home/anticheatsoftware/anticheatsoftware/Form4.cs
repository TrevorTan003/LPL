using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anticheatsoftware
{
    public partial class Form4 : Form
    {
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\School\L3 TPI\Anticheat practice\anticheatsoftware\anticheatsoftware\Database.mdf;Integrated Security=True";


        public Form4()
        {
            InitializeComponent();
            FillList();
        }

        private void FillList()
        {
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("qryTimeline", sqlCon);
                SqlDataReader dr;
                sqlCmd.CommandText = "select * from tblTimeline";
                sqlCmd.Connection = sqlCon;
                dr = sqlCmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[1].ToString());
                    item.SubItems.Add(dr[2].ToString());

                    listHistory.Items.Add(item);
                }
                

                
            }
                
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void Form4_Shown(object sender, EventArgs e)
        {

        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            FillList();
        }

        private void listHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.formHistory -= 1;
        }
    }
}
