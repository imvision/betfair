using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_api_call_2
{
    public partial class Form1 : Form
    {
        private static string Url = "https://api.betfair.com/exchange/betting";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadEventTypes_Click(object sender, EventArgs e)
        {

        }
    }
}
