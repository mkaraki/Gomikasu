namespace Gomikasu
{
    partial class GomikasuForm
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
            this.all = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.twitter = new System.Windows.Forms.LinkLabel();
            this.gomikasu = new System.Windows.Forms.Button();
            this.sine = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // all
            // 
            this.all.Dock = System.Windows.Forms.DockStyle.Fill;
            this.all.Location = new System.Drawing.Point(3, 3);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(394, 424);
            this.all.TabIndex = 0;
            this.all.Text = "ゴミカス　〇ね";
            this.all.UseVisualStyleBackColor = true;
            this.all.Click += new System.EventHandler(this.gomikasu_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.all, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.twitter, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gomikasu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sine, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.about, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // twitter
            // 
            this.twitter.AutoSize = true;
            this.twitter.Location = new System.Drawing.Point(3, 430);
            this.twitter.Name = "twitter";
            this.twitter.Size = new System.Drawing.Size(73, 13);
            this.twitter.TabIndex = 1;
            this.twitter.TabStop = true;
            this.twitter.Text = "本人のTwitter";
            this.twitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.twitter_LinkClicked);
            // 
            // gomikasu
            // 
            this.gomikasu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gomikasu.Location = new System.Drawing.Point(403, 3);
            this.gomikasu.Name = "gomikasu";
            this.gomikasu.Size = new System.Drawing.Size(194, 424);
            this.gomikasu.TabIndex = 2;
            this.gomikasu.Text = "ゴミカス";
            this.gomikasu.UseVisualStyleBackColor = true;
            this.gomikasu.Click += new System.EventHandler(this.gomikasu_Click);
            // 
            // sine
            // 
            this.sine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sine.Location = new System.Drawing.Point(603, 3);
            this.sine.Name = "sine";
            this.sine.Size = new System.Drawing.Size(194, 424);
            this.sine.TabIndex = 3;
            this.sine.Text = "〇ね";
            this.sine.UseVisualStyleBackColor = true;
            this.sine.Click += new System.EventHandler(this.gomikasu_Click);
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.Location = new System.Drawing.Point(403, 430);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(131, 13);
            this.about.TabIndex = 4;
            this.about.TabStop = true;
            this.about.Text = "このアプリケーションについて";
            this.about.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.about_LinkClicked);
            // 
            // GomikasuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GomikasuForm";
            this.Text = "ゴミカス　〇ね - このアプリケーションは第三者が趣味の範囲で作成したものです";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button all;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel twitter;
        private System.Windows.Forms.Button gomikasu;
        private System.Windows.Forms.Button sine;
        private System.Windows.Forms.LinkLabel about;
    }
}

