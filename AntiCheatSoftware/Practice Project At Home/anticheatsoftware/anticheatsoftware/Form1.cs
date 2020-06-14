using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace anticheatsoftware
{

    public partial class Form1 : Form
    {
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\School\L3 TPI\Anticheat practice\anticheatsoftware\anticheatsoftware\Database.mdf;Integrated Security=True";
        string message = "Process Found\nWould you like to terminate process?";

        public Form1()
        {
            InitializeComponent();
            lblTime.Text = DateTime.Now.ToString("dddd,MMM dd yyyy,hh:mm:ss");
            timer1.Start();
        }


        void conceal()
        {
            this.Hide();
            this.ShowInTaskbar = false;
            ShowIcon = true;
            notifyIcon.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtProcess.Text = Form2.ToTextBox;
        }

        private void ToDatabase()
        {
                using (SqlConnection sqlCon = new SqlConnection(conString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("qryTimeline", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ProcessName", txtProcess.Text.Trim());
                    sqlCmd.Parameters.AddWithValue(@"DateClosed", DateTime.Now.ToOADate());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully added to database");
                }
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            Process.GetProcessesByName(txtProcess.Text);
            Process[] pname = Process.GetProcessesByName(txtProcess.Text);
            if (pname.Length == 0)
            {
                MessageBox.Show("Process Not Found");
            }
            else
            {
                DialogResult r = MessageBox.Show(message, "confirm", MessageBoxButtons.YesNo);

                if (r == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (var p in Process.GetProcessesByName(txtProcess.Text))
                    {
                        p.Kill();                       
                    }
                    ToDatabase();
                }
            }
        }


        private void btnTransfer_Click(object sender, EventArgs e)
        {

        }

        private void txtProcess_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Will continously scan", checkBox2);
        }

        private void checkBox2_MouseClick(object sender, MouseEventArgs e)
        {
            bool detected = false;

            if (checkBox2.Checked)
            {
                conceal();
                notifyIcon.ShowBalloonTip(1000, "Anti Cheat", "Stealth Mode is now active", ToolTipIcon.Info);
                while (detected == false && txtProcess.Text != "")
                {
                    Process.GetProcessesByName(txtProcess.Text);
                    Process[] pname = Process.GetProcessesByName(txtProcess.Text);
                    
                        if (pname.Length != 0)
                        {
                            detected = true;
                            DialogResult r = MessageBox.Show("You have been permanently banned", "Anti Cheat", MessageBoxButtons.OK);

                            if (r == System.Windows.Forms.DialogResult.OK)
                            {
                                foreach (var p in Process.GetProcessesByName(txtProcess.Text))
                                {
                                    p.Kill();
                                reveal();

                                } 
                            ToDatabase();
                            }
                        }
                }
            }
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.F10))
            {

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static int formStatus = 0;
        public static int formHelp = 0;
        public static int formHistory = 0;
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (formStatus == 0)
            {
                form2.Show();
                formStatus += 1;
            }
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            if (formHelp == 0)
            {
                form3.Show();
                formHelp += 1;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
            timer1.Start();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            if (formHistory == 0)
            {
                form4.Show();
                formHistory += 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("notepad");
        }

        void reveal()
        {
            this.Show();
        }


        private void Form1_Resize(object sender, EventArgs e)
        {

        }


        private void toolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            reveal();
            MessageBox.Show("OK");
        }
    }
}
