using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorWSClient
{
    public partial class Form1 : Form
    {
        private CalculatorWS.CalculatorSoapClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            client = new CalculatorWSClient.CalculatorWS.CalculatorSoapClient();
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int result = client.Add(a, b);
            this.label3.Text = "Result: " + result.ToString();
        }
        CalculatorClient obj = new CalculatorClient();
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
