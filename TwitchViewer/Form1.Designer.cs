﻿namespace TwitchViewer
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
            this.lb_gameList = new System.Windows.Forms.ListBox();
            this.lb_channelList = new System.Windows.Forms.ListBox();
            this.label_info = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.qualityPanel = new System.Windows.Forms.Panel();
            this.label_streamquality = new System.Windows.Forms.Label();
            this.source = new System.Windows.Forms.RadioButton();
            this.high = new System.Windows.Forms.RadioButton();
            this.medium = new System.Windows.Forms.RadioButton();
            this.low = new System.Windows.Forms.RadioButton();
            this.tb_searchInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.qualityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_gameList
            // 
            this.lb_gameList.FormattingEnabled = true;
            this.lb_gameList.Location = new System.Drawing.Point(9, 17);
            this.lb_gameList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_gameList.Name = "lb_gameList";
            this.lb_gameList.Size = new System.Drawing.Size(266, 251);
            this.lb_gameList.TabIndex = 5;
            this.lb_gameList.SelectedIndexChanged += new System.EventHandler(this.lb_gameList_SelectedIndexChanged);
            // 
            // lb_channelList
            // 
            this.lb_channelList.FormattingEnabled = true;
            this.lb_channelList.Location = new System.Drawing.Point(279, 17);
            this.lb_channelList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_channelList.Name = "lb_channelList";
            this.lb_channelList.Size = new System.Drawing.Size(285, 251);
            this.lb_channelList.TabIndex = 7;
            this.lb_channelList.SelectedIndexChanged += new System.EventHandler(this.lb_channelList_SelectedIndexChanged);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(580, 17);
            this.label_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(35, 13);
            this.label_info.TabIndex = 8;
            this.label_info.Text = "label1";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(279, 306);
            this.btn_start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(147, 48);
            this.btn_start.TabIndex = 9;
            this.btn_start.Text = "Start Selected Stream";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // qualityPanel
            // 
            this.qualityPanel.Controls.Add(this.label_streamquality);
            this.qualityPanel.Controls.Add(this.source);
            this.qualityPanel.Controls.Add(this.high);
            this.qualityPanel.Controls.Add(this.medium);
            this.qualityPanel.Controls.Add(this.low);
            this.qualityPanel.Location = new System.Drawing.Point(431, 273);
            this.qualityPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.qualityPanel.Name = "qualityPanel";
            this.qualityPanel.Size = new System.Drawing.Size(132, 123);
            this.qualityPanel.TabIndex = 10;
            // 
            // label_streamquality
            // 
            this.label_streamquality.AutoSize = true;
            this.label_streamquality.Location = new System.Drawing.Point(41, 11);
            this.label_streamquality.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_streamquality.Name = "label_streamquality";
            this.label_streamquality.Size = new System.Drawing.Size(75, 13);
            this.label_streamquality.TabIndex = 11;
            this.label_streamquality.Text = "Stream Quality";
            // 
            // source
            // 
            this.source.AutoSize = true;
            this.source.Checked = true;
            this.source.Location = new System.Drawing.Point(3, 93);
            this.source.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(97, 17);
            this.source.TabIndex = 3;
            this.source.TabStop = true;
            this.source.Text = "Source(default)";
            this.source.UseVisualStyleBackColor = true;
            // 
            // high
            // 
            this.high.AutoSize = true;
            this.high.Location = new System.Drawing.Point(3, 71);
            this.high.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.high.Name = "high";
            this.high.Size = new System.Drawing.Size(47, 17);
            this.high.TabIndex = 2;
            this.high.Text = "High";
            this.high.UseVisualStyleBackColor = true;
            // 
            // medium
            // 
            this.medium.AutoSize = true;
            this.medium.Location = new System.Drawing.Point(3, 49);
            this.medium.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(62, 17);
            this.medium.TabIndex = 1;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = true;
            // 
            // low
            // 
            this.low.AutoSize = true;
            this.low.Location = new System.Drawing.Point(3, 27);
            this.low.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.low.Name = "low";
            this.low.Size = new System.Drawing.Size(45, 17);
            this.low.TabIndex = 0;
            this.low.Text = "Low";
            this.low.UseVisualStyleBackColor = true;
            // 
            // tb_searchInput
            // 
            this.tb_searchInput.Location = new System.Drawing.Point(11, 306);
            this.tb_searchInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_searchInput.Name = "tb_searchInput";
            this.tb_searchInput.Size = new System.Drawing.Size(134, 20);
            this.tb_searchInput.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 284);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search for channel";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(11, 330);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(134, 24);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 435);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_searchInput);
            this.Controls.Add(this.qualityPanel);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.lb_channelList);
            this.Controls.Add(this.lb_gameList);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.qualityPanel.ResumeLayout(false);
            this.qualityPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lb_channelList_MouseDoubleClick(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ListBox lb_gameList;
        private System.Windows.Forms.ListBox lb_channelList;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Panel qualityPanel;
        private System.Windows.Forms.Label label_streamquality;
        private System.Windows.Forms.RadioButton source;
        private System.Windows.Forms.RadioButton high;
        private System.Windows.Forms.RadioButton medium;
        private System.Windows.Forms.RadioButton low;
        private System.Windows.Forms.TextBox tb_searchInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
    }
}

