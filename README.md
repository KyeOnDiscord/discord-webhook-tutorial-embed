
# Discord Webhook Tutorial with Embeds

C# Discord Webhook Tutorial

Make sure you're using these namespaces:

```csharp
using System.Net; //To upload the webhook to Discord
using System.IO; //For StreamWriter to write the WebRequest
```
Paste this method into your .cs file. 
```csharp
public static void sendDiscordWebhook(string URL, string escapedjson)
        {
            var wr = WebRequest.Create(URL);
            wr.ContentType = "application/json";
            wr.Method = "POST";
            using (var sw = new StreamWriter(wr.GetRequestStream()))
                sw.Write(escapedjson);
            wr.GetResponse();
        }
```

<h3>How To Use</h3>
First we need to get the Webhook URL

![](https://i.imgur.com/uyU3ms8.png)
After making the webhook, get the URL.

Now put it in an event like this:
(let's use a button click event)

There are 2 pieces of data we need to parse into `sendDiscordWebhhok` first is the url and the next one is the `json` for the webhook which holds all the information we want to send.

```csharp
private void button1_Click(object sender, EventArgs e)
        {
	     sendDiscordWebhook("https://discordapp.com/api/webhooks/749445508849860740/b_6Xv2hnhyqnWahXiAPefSv_s5cNXPZ8mg4sw4dnvrX5PUVaqjHY9Rqglfc9v5WFOLfM",
	      "{\"username\": \"Username Placeholder\",\"embeds\":[    {\"description\":\"Webhook Description\", \"title\":\"Webhook Title\", \"color\":1018364}]  }");
        }
```
The json looks confusing but I'll explain it here;
So the json for the webhook is this (as a normal json webhook looks like):
```json
{
  "username": "Username Placeholder",
  "embeds": [
    {
      "description": "Webhook Description",
      "title": "Webhook Title",
      "color": 1018364
    }
  ]
}
```
We can't just directly put that as a string because we'll get errors for not escaping (if you're using like a user input like a textbox, from an external source like a text file or an api you don't have to worry about this just chuck your string in there)

To fix this problem just use this website and paste your json into it and it'll give you back a string you can paste in safely without errors. http://easyonlineconverter.com/converters/dot-net-string-escape.html

Then it'll look like this which you can paste in to the method:
```csharp
"{\"username\": \"Username Placeholder\",\"embeds\":[    {\"description\":\"Webhook Description\", \"title\":\"Webhook Title\", \"color\":1018364}]  }"
```
Then we have the method we had from earlier
```csharp
sendDiscordWebhook("https://discordapp.com/api/webhooks/749445508849860740/b_6Xv2hnhyqnWahXiAPefSv_s5cNXPZ8mg4sw4dnvrX5PUVaqjHY9Rqglfc9v5WFOLfM",
	      "{\"username\": \"Username Placeholder\",\"embeds\":[    {\"description\":\"Webhook Description\", \"title\":\"Webhook Title\", \"color\":1018364}]  }");
        }
```
Then it'll result in this: <br>![](https://i.imgur.com/rqxT65E.png)


Simple, right?

For more embed options read Birdie0's doc [here](https://gist.github.com/Birdie0/78ee79402a4301b1faf412ab5f1cdcf9)


I also uploaded some example projects in this repo so check those out if you need help.
