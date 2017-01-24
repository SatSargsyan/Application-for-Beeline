namespace Beeline_proj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button990 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2500 = new System.Windows.Forms.Button();
            this.button1500 = new System.Windows.Forms.Button();
            this.button3500 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // button990
            // 
            this.button990.BackColor = System.Drawing.Color.Yellow;
            this.button990.Location = new System.Drawing.Point(12, 12);
            this.button990.Margin = new System.Windows.Forms.Padding(2);
            this.button990.Name = "button990";
            this.button990.Size = new System.Drawing.Size(151, 70);
            this.button990.TabIndex = 0;
            this.button990.Text = "1500 դրամ";
            this.button990.UseVisualStyleBackColor = false;
            this.button990.Click += new System.EventHandler(this.button990_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(188, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(8, 8);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2500
            // 
            this.button2500.BackColor = System.Drawing.Color.Yellow;
            this.button2500.Location = new System.Drawing.Point(12, 100);
            this.button2500.Name = "button2500";
            this.button2500.Size = new System.Drawing.Size(151, 70);
            this.button2500.TabIndex = 3;
            this.button2500.Text = "3500 դրամ";
            this.button2500.UseVisualStyleBackColor = false;
            this.button2500.Click += new System.EventHandler(this.button2500_Click_1);
            // 
            // button1500
            // 
            this.button1500.BackColor = System.Drawing.Color.Yellow;
            this.button1500.Location = new System.Drawing.Point(181, 12);
            this.button1500.Name = "button1500";
            this.button1500.Size = new System.Drawing.Size(151, 70);
            this.button1500.TabIndex = 4;
            this.button1500.Text = "2500 դրամ";
            this.button1500.UseVisualStyleBackColor = false;
            this.button1500.Click += new System.EventHandler(this.button1500_Click);
            // 
            // button3500
            // 
            this.button3500.BackColor = System.Drawing.Color.Yellow;
            this.button3500.Location = new System.Drawing.Point(181, 100);
            this.button3500.Name = "button3500";
            this.button3500.Size = new System.Drawing.Size(151, 70);
            this.button3500.TabIndex = 5;
            this.button3500.Text = "990 դրամ";
            this.button3500.UseVisualStyleBackColor = false;
            this.button3500.Click += new System.EventHandler(this.button3500_Click_1);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(341, 392);
            this.Controls.Add(this.button3500);
            this.Controls.Add(this.button1500);
            this.Controls.Add(this.button2500);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button990);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button990;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2500;
        private System.Windows.Forms.Button button1500;
        private System.Windows.Forms.Button button3500;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}