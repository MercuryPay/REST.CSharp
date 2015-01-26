using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using System.Web.Script.Serialization;

namespace REST.CSharp
{
    public partial class CSharpForm : Form
    {
        public CSharpForm()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //convert merchantid and password into base64 encoded data
            var dataByte = UTF8Encoding.ASCII.GetBytes(txtMerchantId.Text + ":" + txtPassword.Text);
            var merchantIdData = Convert.ToBase64String(dataByte);

            //use a somewhat unique string for invoice number below
            var dt = DateTime.Now.ToString("yyyyddMMHHmmss");

            //assume data from a swiped keyboard emulation device
            var swipedFields = ParseDynamagData("%B5499000090006781^TEST/MPS^15120000000000000?;5499000090006781=15120000000000000000?|0600|9A1F82EDFEADADA1F8C9CCC6B9A9C349A33FD9238FAD46082EB9B1E18EFF2A57722104F9149766A9B675D69A8DD7EEF8|425DDE3C92ECB491B6417E78725C9EAB62D0B4D8584A74F0B31945253B71617527051C3CDE595F90||61401000|B157C4CB5DED36E5E643C690F94B84C25571D0B9CA731CB64237AB6D6E185A83DF9F47E639DA3FD9A2C201D6273DF7A271DE2F33FA9F8C87|B047038101811AA|B2914BC9BCC1FAA4|9012090B0470380000B8|D1ED||1000");
            var encryptedBlock = string.Empty;
            var encryptedKey = string.Empty;
            var accountType = string.Empty;

            if (swipedFields.ContainsKey("3") && swipedFields.ContainsKey("9"))
            {
                encryptedBlock = swipedFields["3"];
                encryptedKey = swipedFields["9"];
                accountType = "Swiped";
            }

            //create the credit sale request
            dynamic data = new
            {
                InvoiceNo = dt,
                Memo = "Your POS Name and Version",
                Purchase = "1.09",
                Frequency = "OneTime",
                RecordNo = "RecordNumberRequested",
                RefNo = dt,
                EncryptedBlock = encryptedBlock,
                EncryptedFormat = "MagneSafe",
                EncryptedKey = encryptedKey,
                OperatorID = "Current OperatorId",
                AccountSource = accountType
            };

            txtRequest.Text = data.ToString();

            var client = new RestClient(txtEndPoint.Text);
            var request = new RestRequest("Credit/Sale", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Authorization", "Basic " + merchantIdData);
            request.AddBody(data);
            var response = client.Execute(request);

            txtResponse.Text = response.Content;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResponse.Text = string.Empty;
            txtRequest.Text = string.Empty;
        }

        private void btnProcessReturnFromResponse_Click(object sender, EventArgs e)
        {
            //convert merchantid and password into base64 encoded data
            var dataByte = UTF8Encoding.ASCII.GetBytes(txtMerchantId.Text + ":" + txtPassword.Text);
            var merchantIdData = Convert.ToBase64String(dataByte);

            //deserialize the text data returned from REST endpoint into a usable object
            var serializer = new JavaScriptSerializer();
            dynamic item = serializer.Deserialize<object>(txtResponse.Text);

            //create the Credit Return
            dynamic data = new
            {
                InvoiceNo = item["InvoiceNo"],
                Memo = "Your POS Name and Version",
                Purchase = item["Purchase"],
                Frequency = "OneTime",
                RecordNo = item["RecordNo"],
                RefNo = item["RefNo"],
                OperatorID = "Current OperatorId",
            };

            txtRequest.Text = data.ToString();

            var client = new RestClient(txtEndPoint.Text);
            var request = new RestRequest("Credit/ReturnByRecordNo", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Authorization", "Basic " + merchantIdData);
            request.AddBody(data);
            var response = client.Execute(request);

            txtResponse.Text = response.Content;

        }

        private Dictionary<string, string> ParseDynamagData(string swipeData)
        {
            try
            {
                Dictionary<string, string> fields = new Dictionary<string, string>();
                string[] firstSplit = swipeData.Split('|');
                for (int i = 0; i < firstSplit.Length; i++)
                {
                    fields.Add(Convert.ToString(i), firstSplit[i]);
                }
                return fields;
            }
            catch
            {
                return new Dictionary<string, string>();
            }
        }


    }
}
