using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetSharp;

namespace RockstarExcerciseTwitterClient
{
    public partial class Login : Form
    {
        OAuthRequestToken requestToken;

        public Login()
        {
            InitializeComponent();
            openAuthorizationUri();
        }

        private void openAuthorizationUri()
        {
            requestToken = Main.service.GetRequestToken();
            Uri uri = Main.service.GetAuthorizationUri(requestToken);
            Process.Start(uri.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pin = pinTextBox.Text;

            OAuthAccessToken access = Main.service.GetAccessToken(requestToken, pin);
            Main.service.AuthenticateWith(access.Token, access.TokenSecret);
            
            if (Main.service.VerifyCredentials(new VerifyCredentialsOptions()) != null)
            { 
                DialogResult = DialogResult.OK;
            }
            else
            {
                loginErrorLabel.Visible = true;
                openAuthorizationUri();
            }
        }
    }
}
