namespace GoGoRelax
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelcity = new System.Windows.Forms.Label();
            this.labelstate = new System.Windows.Forms.Label();
            this.labelzip = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelzip);
            this.panel1.Controls.Add(this.labelstate);
            this.panel1.Controls.Add(this.labelcity);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBoxsearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(200, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(600, 450);
            this.webBrowser1.TabIndex = 1;
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBoxsearch.Location = new System.Drawing.Point(46, 32);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(100, 25);
            this.textBoxsearch.TabIndex = 2;
            this.textBoxsearch.Text = "search";
            this.textBoxsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(82, 228);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 2;
            // 
            // labelcity
            // 
            this.labelcity.AutoSize = true;
            this.labelcity.Location = new System.Drawing.Point(24, 115);
            this.labelcity.Name = "labelcity";
            this.labelcity.Size = new System.Drawing.Size(39, 18);
            this.labelcity.TabIndex = 2;
            this.labelcity.Text = "City";
            // 
            // labelstate
            // 
            this.labelstate.AutoSize = true;
            this.labelstate.Location = new System.Drawing.Point(24, 172);
            this.labelstate.Name = "labelstate";
            this.labelstate.Size = new System.Drawing.Size(49, 18);
            this.labelstate.TabIndex = 2;
            this.labelstate.Text = "State";
            // 
            // labelzip
            // 
            this.labelzip.AutoSize = true;
            this.labelzip.Location = new System.Drawing.Point(24, 231);
            this.labelzip.Name = "labelzip";
            this.labelzip.Size = new System.Drawing.Size(31, 18);
            this.labelzip.TabIndex = 2;
            this.labelzip.Text = "Zip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelzip;
        private System.Windows.Forms.Label labelstate;
        private System.Windows.Forms.Label labelcity;
    }
}

