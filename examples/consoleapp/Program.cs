using System.Net;
using System.IO;

namespace DiscordWebhookEmbedTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Webhook URL
            string url = "https://discord.com/api/webhooks/xxxxxx";
            //Escape the json http://easyonlineconverter.com/converters/dot-net-string-escape.html
            string json = "{\"username\": \"Username Placeholder\",\"embeds\":[    {\"description\":\"Webhook Description\", \"title\":\"Webhook Title\", \"color\":1018364}]  }";
            sendDiscordWebhook(url, json);
        }

        //https://github.com/kyeondiscord/discord-webhook-tutorial-embed
        public static void sendDiscordWebhook(string URL, string escapedjson)
        {
            var wr = WebRequest.Create(URL);
            wr.ContentType = "application/json";
            wr.Method = "POST";
            using (var sw = new StreamWriter(wr.GetRequestStream()))
                sw.Write(escapedjson);
            wr.GetResponse();
        }
    }
}
