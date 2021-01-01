
namespace DiscordWebhookEmbedTutorialForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webhookurl = new System.Windows.Forms.TextBox();
            this.json = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webhookurl
            // 
            this.webhookurl.BackColor = System.Drawing.Color.White;
            this.webhookurl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.webhookurl.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webhookurl.ForeColor = System.Drawing.Color.Black;
            this.webhookurl.Location = new System.Drawing.Point(125, 48);
            this.webhookurl.Multiline = true;
            this.webhookurl.Name = "webhookurl";
            this.webhookurl.Size = new System.Drawing.Size(454, 62);
            this.webhookurl.TabIndex = 0;
            this.webhookurl.Text = "https://discord.com/api/webhooks/xxxxxx";
            // 
            // json
            // 
            this.json.BackColor = System.Drawing.Color.White;
            this.json.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.json.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.json.ForeColor = System.Drawing.Color.Black;
            this.json.Location = new System.Drawing.Point(125, 116);
            this.json.Multiline = true;
            this.json.Name = "json";
            this.json.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.json.Size = new System.Drawing.Size(454, 268);
            this.json.TabIndex = 1;
            this.json.Text = "{\r\n  \"username\": \"Username Placeholder\",\r\n  \"embeds\": [\r\n    {\r\n      \"descriptio" +
    "n\": \"Webhook Description\",\r\n      \"title\": \"Webhook Title\",\r\n      \"color\": 1018" +
    "364\r\n    }\r\n  ]\r\n}";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(194)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(125, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(454, 72);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send Webhook";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Webhook URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "JSON:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(721, 502);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.json);
            this.Controls.Add(this.webhookurl);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discord Webhook Sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox webhookurl;
        private System.Windows.Forms.TextBox json;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

