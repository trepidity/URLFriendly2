using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Win32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnClick_EncodeButton(object sender, EventArgs e)
        {
            var userInput = this.encodeDecodeTextBox.Text;
            var result = HttpUtility.UrlEncode(userInput, Encoding.UTF8);
            this.resultsTextBox.Text = result;
        }

        private void OnClick_DecodeButton(object sender, EventArgs e)
        {
            var userInput = this.encodeDecodeTextBox.Text;
            var result = HttpUtility.UrlDecode(userInput, Encoding.UTF8);
            this.resultsTextBox.Text = result;
        }

        private void OnClick_GenerateURL_Button(object sender, EventArgs e)
        {
            this.messagesTextBox.Text = "";
            var idpVal = this.identityProviderTextBox.Text;
            var spID = this.serviceProviderID.Text;
            var targetURL = this.targetURLTextBox.Text;
            var idpPort = this.portTextBox.Text;
            var idpProtocol = this.protocolTextBox.Text;

            // do we have a required IDP port
            if (String.IsNullOrEmpty(idpPort)) {
                Console.WriteLine("missing required IDP port");
                this.messagesTextBox.Text = "Missing required IDP port";
                return;
            }

            if (string.IsNullOrEmpty(idpVal)) {
                Console.WriteLine("Missing Identity Provider URL");
                this.messagesTextBox.Text = "Missing required IDP URL";
                return;
            }

            if (string.IsNullOrEmpty(spID)) {
                Console.WriteLine("Missing Service Provider ID");
                this.messagesTextBox.Text = "Missing Service Provider ID.";
                return;
            }

            if (string.IsNullOrEmpty(targetURL)) {
                Console.WriteLine("Missing target URL");
                this.messagesTextBox.Text = "Missing target URL.";
                return;
            }

            // do we have a required IDP port
            if (String.IsNullOrEmpty(idpProtocol)) {
                Console.WriteLine("missing required IDP protocol");
                this.messagesTextBox.Text = "Missing required IDP protocol";
                return;
            }

            Console.WriteLine(string.Format("Identity Provider URL {0}", idpVal));

            if (SAML1.Checked)
                Console.WriteLine("SAML1 enabled");

            if (SAML2.Checked)
                Console.WriteLine("SAML2 enabled");

            var sb = new StringBuilder();
            sb.Append(idpProtocol.Replace("://", ""));
            sb.Append("://");
            sb.Append(idpVal);
            if (Regex.IsMatch(idpVal, ":\\d{2,}") == false) {
                sb.Append(":");
                sb.Append(idpPort);
            }

            sb.Append("/nidp/");

            if (SAML1.Checked)
                sb.Append("saml");
            else
                sb.Append("saml2");
            sb.Append("/");

            if (spInitiated.Checked)
                sb.Append("spsend");
            else
                sb.Append("idpsend");

            sb.Append("?PID=");
            sb.Append(spID);
            sb.Append("&TARGET=");
            sb.Append(HttpUtility.UrlEncode(targetURL, Encoding.UTF8));

            Console.WriteLine(string.Format("Generated URL = {0}", sb.ToString()));
            this.resultsTextBox.Text = sb.ToString();
        }
    }
}
