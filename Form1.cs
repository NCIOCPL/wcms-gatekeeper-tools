using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace StatusChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string source = comboSource.Text;
            string jobID = txtJobID.Text;
            string requestType = comboReportType.Text;

            GKWebService.GateKeeperSoapClient client = new StatusChecker.GKWebService.GateKeeperSoapClient();
            XmlElement result = client.RequestStatus(source, jobID, requestType);
            txtResult.Text = result.OuterXml;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
