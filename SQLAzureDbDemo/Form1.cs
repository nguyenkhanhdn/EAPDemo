using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLAzureDbDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankServicesDataSet.t1' table. You can move, or remove it, as needed.
            this.t1TableAdapter.Fill(this.bankServicesDataSet.t1);
            // TODO: This line of code loads data into the 'bankServicesDataSet.t1' table. You can move, or remove it, as needed.
            this.t1TableAdapter.Fill(this.bankServicesDataSet.t1);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.t1TableAdapter.Update(bankServicesDataSet.t1);
            MessageBox.Show("Saved.");
        }
    }
}
