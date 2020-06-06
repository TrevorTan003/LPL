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


namespace anticheatsoftware
{

    public partial class Form1 : Form
    {
        string message = "Process Found\nWould you like to terminate process?";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtProcess.Text = Form2.ToTextBox;
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
                while (detected == false && txtProcess.Text != "")
                {
                    Process.GetProcessesByName(txtProcess.Text);
                    Process[] pname = Process.GetProcessesByName(txtProcess.Text);
                    this.Hide();
                    this.ShowInTaskbar = false;

                    if (pname.Length != 0)
                    {
                        detected = true;
                        DialogResult r = MessageBox.Show("You have been permanently banned", "Anti Cheat", MessageBoxButtons.OK);

                        if (r == System.Windows.Forms.DialogResult.OK)
                        {
                            foreach (var p in Process.GetProcessesByName(txtProcess.Text))
                            {
                                p.Kill();
                                this.Show();
                                this.ShowInTaskbar = true;
                                checkBox2.Checked = false;
                            }

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

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
