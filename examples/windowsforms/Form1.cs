using System;
using System.Windows.Forms;
using System.Net; //To upload the webhook to Discord
using System.IO; //For StreamWriter to write the WebRequest
namespace DiscordWebhookEmbedTutorialForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static void sendDiscordWebhook(string URL, string escapedjson)
        {
            var wr = WebRequest.Create(URL);
            wr.ContentType = "application/json";
            wr.Method = "POST";
            using (var sw = new StreamWriter(wr.GetRequestStream()))
                sw.Write(escapedjson);
            wr.GetResponse();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sendDiscordWebhook(webhookurl.Text, json.Text);
            MessageBox.Show("Webhook Sent!", "Discord Webhook Sender", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
