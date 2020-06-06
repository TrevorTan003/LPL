using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anticheatsoftware
{
    public partial class Form2 : Form
    {

        public System.Windows.Forms.ListView listView;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listProcess();
        }

        public void listProcess()
        {
            viewProcess.Items.Clear();
            Process[] processList = Process.GetProcesses();
            foreach (Process process in processList)
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                item.Tag = process;
                viewProcess.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static string ToTextBox = "";

        private void viewProcess_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (viewProcess.SelectedItems.Count > 0)
            {
                ListViewItem item = viewProcess.SelectedItems[0];
                    var processId = item.SubItems[0].Text;
                    ToTextBox = processId;

                Form1 form1 = new Form1();
                form1.Show();
            }
        }



        private void viewProcess_ItemActivate(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.viewProcess.Refresh();
        }
    }
}
