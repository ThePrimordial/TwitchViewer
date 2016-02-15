namespace TwitchViewer
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
            this.button_start = new System.Windows.Forms.Button();
            this.qualityPanel = new System.Windows.Forms.Panel();
            this.label_streamquality = new System.Windows.Forms.Label();
            this.source = new System.Windows.Forms.RadioButton();
            this.high = new System.Windows.Forms.RadioButton();
            this.medium = new System.Windows.Forms.RadioButton();
            this.low = new System.Windows.Forms.RadioButton();
            this.qualityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_gameList
            // 
            this.lb_gameList.FormattingEnabled = true;
            this.lb_gameList.ItemHeight = 16;
            this.lb_gameList.Location = new System.Drawing.Point(12, 21);
            this.lb_gameList.Name = "lb_gameList";
            this.lb_gameList.Size = new System.Drawing.Size(354, 308);
            this.lb_gameList.TabIndex = 5;
            this.lb_gameList.SelectedIndexChanged += new System.EventHandler(this.lb_gameList_SelectedIndexChanged);
            // 
            // lb_channelList
            // 
            this.lb_channelList.FormattingEnabled = true;
            this.lb_channelList.ItemHeight = 16;
            this.lb_channelList.Location = new System.Drawing.Point(372, 21);
            this.lb_channelList.Name = "lb_channelList";
            this.lb_channelList.Size = new System.Drawing.Size(379, 308);
            this.lb_channelList.TabIndex = 7;
            this.lb_channelList.SelectedIndexChanged += new System.EventHandler(this.lb_channelList_SelectedIndexChanged);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(774, 21);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(46, 17);
            this.label_info.TabIndex = 8;
            this.label_info.Text = "label1";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(311, 377);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(196, 59);
            this.button_start.TabIndex = 9;
            this.button_start.Text = "Start Selected Stream";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // qualityPanel
            // 
            this.qualityPanel.Controls.Add(this.label_streamquality);
            this.qualityPanel.Controls.Add(this.source);
            this.qualityPanel.Controls.Add(this.high);
            this.qualityPanel.Controls.Add(this.medium);
            this.qualityPanel.Controls.Add(this.low);
            this.qualityPanel.Location = new System.Drawing.Point(575, 336);
            this.qualityPanel.Name = "qualityPanel";
            this.qualityPanel.Size = new System.Drawing.Size(222, 151);
            this.qualityPanel.TabIndex = 10;
            // 
            // label_streamquality
            // 
            this.label_streamquality.AutoSize = true;
            this.label_streamquality.Location = new System.Drawing.Point(55, 13);
            this.label_streamquality.Name = "label_streamquality";
            this.label_streamquality.Size = new System.Drawing.Size(101, 17);
            this.label_streamquality.TabIndex = 11;
            this.label_streamquality.Text = "Stream Quality";
            // 
            // source
            // 
            this.source.AutoSize = true;
            this.source.Checked = true;
            this.source.Location = new System.Drawing.Point(4, 114);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(127, 21);
            this.source.TabIndex = 3;
            this.source.TabStop = true;
            this.source.Text = "Source(default)";
            this.source.UseVisualStyleBackColor = true;
            // 
            // high
            // 
            this.high.AutoSize = true;
            this.high.Location = new System.Drawing.Point(4, 87);
            this.high.Name = "high";
            this.high.Size = new System.Drawing.Size(58, 21);
            this.high.TabIndex = 2;
            this.high.Text = "High";
            this.high.UseVisualStyleBackColor = true;
            // 
            // medium
            // 
            this.medium.AutoSize = true;
            this.medium.Location = new System.Drawing.Point(4, 60);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(78, 21);
            this.medium.TabIndex = 1;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = true;
            // 
            // low
            // 
            this.low.AutoSize = true;
            this.low.Location = new System.Drawing.Point(4, 33);
            this.low.Name = "low";
            this.low.Size = new System.Drawing.Size(54, 21);
            this.low.TabIndex = 0;
            this.low.Text = "Low";
            this.low.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 535);
            this.Controls.Add(this.qualityPanel);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.lb_channelList);
            this.Controls.Add(this.lb_gameList);
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
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Panel qualityPanel;
        private System.Windows.Forms.Label label_streamquality;
        private System.Windows.Forms.RadioButton source;
        private System.Windows.Forms.RadioButton high;
        private System.Windows.Forms.RadioButton medium;
        private System.Windows.Forms.RadioButton low;
    }
}

