namespace RockstarExcerciseTwitterClient
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.incomingTweetsTextBox = new System.Windows.Forms.RichTextBox();
            this.getNewTweetsButton = new System.Windows.Forms.Button();
            this.getOlderTweetsButton = new System.Windows.Forms.Button();
            this.appStatusLabel = new System.Windows.Forms.Label();
            this.outgoingTweetTextBox = new System.Windows.Forms.RichTextBox();
            this.postTweetButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 36);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.incomingTweetsTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.getNewTweetsButton);
            this.splitContainer1.Panel1.Controls.Add(this.getOlderTweetsButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.appStatusLabel);
            this.splitContainer1.Panel2.Controls.Add(this.outgoingTweetTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.postTweetButton);
            this.splitContainer1.Size = new System.Drawing.Size(891, 958);
            this.splitContainer1.SplitterDistance = 479;
            this.splitContainer1.TabIndex = 7;
            // 
            // incomingTweetsTextBox
            // 
            this.incomingTweetsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.incomingTweetsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.incomingTweetsTextBox.DetectUrls = false;
            this.incomingTweetsTextBox.Location = new System.Drawing.Point(4, 3);
            this.incomingTweetsTextBox.Name = "incomingTweetsTextBox";
            this.incomingTweetsTextBox.ReadOnly = true;
            this.incomingTweetsTextBox.Size = new System.Drawing.Size(722, 471);
            this.incomingTweetsTextBox.TabIndex = 4;
            this.incomingTweetsTextBox.Text = "";
            // 
            // getNewTweetsButton
            // 
            this.getNewTweetsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getNewTweetsButton.Location = new System.Drawing.Point(732, 3);
            this.getNewTweetsButton.Name = "getNewTweetsButton";
            this.getNewTweetsButton.Size = new System.Drawing.Size(156, 37);
            this.getNewTweetsButton.TabIndex = 3;
            this.getNewTweetsButton.Text = "Get New Tweets";
            this.getNewTweetsButton.UseVisualStyleBackColor = true;
            this.getNewTweetsButton.Click += new System.EventHandler(this.getNewTweetsButton_Click);
            // 
            // getOlderTweetsButton
            // 
            this.getOlderTweetsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getOlderTweetsButton.Location = new System.Drawing.Point(732, 46);
            this.getOlderTweetsButton.Name = "getOlderTweetsButton";
            this.getOlderTweetsButton.Size = new System.Drawing.Size(156, 37);
            this.getOlderTweetsButton.TabIndex = 2;
            this.getOlderTweetsButton.Text = "Get Older Tweets";
            this.getOlderTweetsButton.UseVisualStyleBackColor = true;
            this.getOlderTweetsButton.Click += new System.EventHandler(this.getOlderTweetsButton_Click);
            // 
            // appStatusLabel
            // 
            this.appStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.appStatusLabel.AutoSize = true;
            this.appStatusLabel.Location = new System.Drawing.Point(13, 439);
            this.appStatusLabel.Name = "appStatusLabel";
            this.appStatusLabel.Size = new System.Drawing.Size(31, 20);
            this.appStatusLabel.TabIndex = 3;
            this.appStatusLabel.Text = "OK";
            // 
            // outgoingTweetTextBox
            // 
            this.outgoingTweetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outgoingTweetTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outgoingTweetTextBox.Location = new System.Drawing.Point(5, 3);
            this.outgoingTweetTextBox.Name = "outgoingTweetTextBox";
            this.outgoingTweetTextBox.Size = new System.Drawing.Size(721, 425);
            this.outgoingTweetTextBox.TabIndex = 2;
            this.outgoingTweetTextBox.Text = "";
            // 
            // postTweetButton
            // 
            this.postTweetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.postTweetButton.Location = new System.Drawing.Point(732, 3);
            this.postTweetButton.Name = "postTweetButton";
            this.postTweetButton.Size = new System.Drawing.Size(156, 37);
            this.postTweetButton.TabIndex = 1;
            this.postTweetButton.Text = "Post Tweet";
            this.postTweetButton.UseVisualStyleBackColor = true;
            this.postTweetButton.Click += new System.EventHandler(this.postTweetButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(891, 990);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Twitter Client";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox incomingTweetsTextBox;
        private System.Windows.Forms.Button getNewTweetsButton;
        private System.Windows.Forms.Button getOlderTweetsButton;
        private System.Windows.Forms.RichTextBox outgoingTweetTextBox;
        private System.Windows.Forms.Button postTweetButton;
        private System.Windows.Forms.Label appStatusLabel;
    }
}