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
            this.button1 = new System.Windows.Forms.Button();
            this.streamName = new System.Windows.Forms.TextBox();
            this.debug = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dotaList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // streamName
            // 
            this.streamName.Location = new System.Drawing.Point(13, 137);
            this.streamName.Name = "streamName";
            this.streamName.Size = new System.Drawing.Size(129, 22);
            this.streamName.TabIndex = 1;
            // 
            // debug
            // 
            this.debug.Location = new System.Drawing.Point(13, 185);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(257, 22);
            this.debug.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stream name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Debug";
            // 
            // dotaList
            // 
            this.dotaList.FormattingEnabled = true;
            this.dotaList.ItemHeight = 16;
            this.dotaList.Items.AddRange(new object[] {
            "moonducktv"});
            this.dotaList.Location = new System.Drawing.Point(12, 222);
            this.dotaList.Name = "dotaList";
            this.dotaList.Size = new System.Drawing.Size(244, 84);
            this.dotaList.TabIndex = 5;
            this.dotaList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 356);
            this.Controls.Add(this.dotaList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.streamName);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox streamName;
        private System.Windows.Forms.TextBox debug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox dotaList;
    }
}

