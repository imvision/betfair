using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_api_call_2.TO;
using test_api_call_2.Json;

namespace test_api_call_2
{
    public partial class Form1 : Form
    {
        private static string Url = "https://api.betfair.com/exchange/betting";
        private static string key = "RRAy2ZiLvI9Mqyoe";
        private static string tok = "Err6jG623XOtEf6BdPQv/YCLSYsI5zUB9Y5XgLqOdeA=";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadEventTypes_Click(object sender, EventArgs e)
        {
            IClient client = null;

            client = new JsonRpcClient(Url, key, tok);

            try
            {
                var marketFilter = new MarketFilter();

                var eventTypes = client.listEventTypes(marketFilter);

                // forming a eventype id set for the eventype id extracted from the result
                ISet<string> eventypeIds = new HashSet<string>();

                foreach (EventTypeResult eventType in eventTypes)
                {
                    lbEventTypes.Items.Add(eventType.EventType.Name);
                    eventypeIds.Add(eventType.EventType.Id);
                }
            }
            catch (APINGException apiException)
            {
                tbException.Text = "Got an exception from Api-NG: " + apiException.ErrorCode;
            }
            catch (System.Exception se)
            {
                tbException.Text = "Unknown exception from application: " + se.Message;
            }
        }
    }
}
