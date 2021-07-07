namespace anticheatsoftware
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.listHistory = new System.Windows.Forms.ListView();
            this.cnProcessID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cnProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cnDateClosed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "History";
            // 
            // listHistory
            // 
            this.listHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cnProcessID,
            this.cnProcessName,
            this.cnDateClosed});
            this.listHistory.GridLines = true;
            this.listHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listHistory.HideSelection = false;
            this.listHistory.Location = new System.Drawing.Point(12, 76);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(443, 376);
            this.listHistory.TabIndex = 3;
            this.listHistory.UseCompatibleStateImageBehavior = false;
            this.listHistory.View = System.Windows.Forms.View.Details;
            this.listHistory.SelectedIndexChanged += new System.EventHandler(this.listHistory_SelectedIndexChanged);
            // 
            // cnProcessID
            // 
            this.cnProcessID.Text = "Process ID";
            this.cnProcessID.Width = 77;
            // 
            // cnProcessName
            // 
            this.cnProcessName.Text = "Process Name";
            this.cnProcessName.Width = 157;
            // 
            // cnDateClosed
            // 
            this.cnDateClosed.Text = "Date Closed";
            this.cnDateClosed.Width = 173;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 490);
            this.Controls.Add(this.listHistory);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.Shown += new System.EventHandler(this.Form4_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listHistory;
        private System.Windows.Forms.ColumnHeader cnProcessID;
        private System.Windows.Forms.ColumnHeader cnProcessName;
        private System.Windows.Forms.ColumnHeader cnDateClosed;
    }
}