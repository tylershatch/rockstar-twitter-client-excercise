using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetSharp;
using System.Diagnostics;

namespace RockstarExcerciseTwitterClient
{
    public partial class Main : Form
    {
        public const string ConsumerKey = "tUitLCoAeRPXTQ9QujmxMjvI2";
        public const string ConsumerSecret = "lLvZNB4ihc5ZJJCWOB3X33ySMHwn5WJ0f0NmvH9gkNIkTTaD8W";

        public static TwitterService service;

        public long newestID;
        public long oldestID;

        bool loggedIn = false;
        bool gotInitialTweets = false;

        public Main()
        {
            InitializeComponent();

            service = new TwitterService(ConsumerKey, ConsumerSecret);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            using (var loginForm = new Login())
                result = loginForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                loggedIn = true;
                incomingTweetsTextBox.Text = "";
                getInitialTweets();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loggedIn = false;
            incomingTweetsTextBox.Text = "";

            // this is the best option I could come up with for logout
            // this assignment orphans the original TwitterService object, which contained the authentication details, garbage collection will delete it later
            // (i couldn't find an accepted way in C# to "zero out" the structure before orphaning it)
            service = new TwitterService(ConsumerKey, ConsumerSecret);
        }

        private void getNewTweetsButton_Click(object sender, EventArgs e)
        {
            if (!loggedIn)
            {
                printNotLoggedInError();
            }
            else
            {
                // if we never got initial tweets (prolly because rate limiting prevented it right after we logged in), get them now
                if (!gotInitialTweets)
                {
                    getInitialTweets();
                }

                // get new tweets
                ListTweetsOnHomeTimelineOptions options = new ListTweetsOnHomeTimelineOptions();
                options.SinceId = newestID;
                IEnumerable<TwitterStatus> tweets = service.ListTweetsOnHomeTimeline(options);

                if (tweets == null)
                {
                    // internal twitter error
                    printTwitterError();
                }
                else
                {
                    if (tweets.Count() > 0)
                    {
                        // update newestID so the next call to this function only grabs even newer tweets
                        newestID = tweets.First().Id;

                        // build a string for all of the new tweets
                        String newerTweets = "";
                        foreach (var tweet in tweets)
                        {
                            newerTweets += buildTweetString(tweet);
                        }

                        // prepend the new tweets string to the existing string of tweets
                        incomingTweetsTextBox.Text = newerTweets + incomingTweetsTextBox.Text;
                    }

                    appStatusLabel.Text = "OK";
                }
            }
        }

        private void getOlderTweetsButton_Click(object sender, EventArgs e)
        {
            if (!loggedIn)
            {
                printNotLoggedInError();
            }
            else
            {
                // If we never got initial tweets (prolly because rate limiting prevented it right after we logged in), get them now
                if (!gotInitialTweets)
                {
                    getInitialTweets();
                }

                // get older tweets
                ListTweetsOnHomeTimelineOptions options = new ListTweetsOnHomeTimelineOptions();
                options.MaxId = oldestID - 1;
                IEnumerable<TwitterStatus> tweets = service.ListTweetsOnHomeTimeline(options);

                if (tweets == null)
                {
                    // internal twitter error
                    printTwitterError();
                }
                else
                {
                    if (tweets.Count() > 0)
                    {
                        // update oldestID so the next call to this function only grabs even older tweets
                        oldestID = tweets.Last().Id;

                        // append all of the older tweets to the existing string of tweets
                        foreach (var tweet in tweets)
                        {
                            incomingTweetsTextBox.Text += buildTweetString(tweet);
                        }
                    }

                    appStatusLabel.Text = "OK";
                }
            }
        }

        private void postTweetButton_Click(object sender, EventArgs e)
        {
            if (!loggedIn)
            {
                printNotLoggedInError();
            }
            else
            {
                service.SendTweet(new SendTweetOptions { Status = outgoingTweetTextBox.Text });
                getNewTweetsButton_Click(null, null);
                appStatusLabel.Text = "OK";
            }
        }

        string buildTweetString(TweetSharp.TwitterStatus tweet)
        {
            return
                String.Format("{0}", tweet.CreatedDate) +
                Environment.NewLine +
                String.Format("{0} tweeted:", tweet.User.ScreenName) +
                Environment.NewLine +
                tweet.Text +
                Environment.NewLine + Environment.NewLine;
        }

        private void printNotLoggedInError()
        {
            appStatusLabel.Text = "Must Login to do this (File->Login)" + Environment.NewLine;
        }

        private void printTwitterError()
        {
            appStatusLabel.Text = "Twitter Error - " + service.Response.Error.ToString();
        }

        private void getInitialTweets()
        {
            // this method mainly exists as the entry point for initially setting newestID and oldestID

            ListTweetsOnHomeTimelineOptions options = new ListTweetsOnHomeTimelineOptions();

            IEnumerable<TwitterStatus> tweets = service.ListTweetsOnHomeTimeline(options);

            if (tweets == null)
            {
                printTwitterError();
            }
            else
            {
                gotInitialTweets = true;

                newestID = tweets.First().Id;
                oldestID = tweets.Last().Id;

                foreach (var tweet in tweets)
                {
                    incomingTweetsTextBox.Text += buildTweetString(tweet);
                }

                appStatusLabel.Text = "OK";
            }
        }
    }
}
