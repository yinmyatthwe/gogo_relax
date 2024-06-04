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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelcity = new System.Windows.Forms.Label();
            this.textcity = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.buttoncafe = new System.Windows.Forms.Button();
            this.buttonspa = new System.Windows.Forms.Button();
            this.buttonpark = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonpark);
            this.panel1.Controls.Add(this.buttonspa);
            this.panel1.Controls.Add(this.buttoncafe);
            this.panel1.Controls.Add(this.buttonsearch);
            this.panel1.Controls.Add(this.labelcity);
            this.panel1.Controls.Add(this.textcity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 450);
            this.panel1.TabIndex = 0;
            // 
            // labelcity
            // 
            this.labelcity.AutoSize = true;
            this.labelcity.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelcity.Location = new System.Drawing.Point(34, 46);
            this.labelcity.Name = "labelcity";
            this.labelcity.Size = new System.Drawing.Size(50, 24);
            this.labelcity.TabIndex = 2;
            this.labelcity.Text = "都市";
            // 
            // textcity
            // 
            this.textcity.Location = new System.Drawing.Point(90, 48);
            this.textcity.Name = "textcity";
            this.textcity.Size = new System.Drawing.Size(100, 25);
            this.textcity.TabIndex = 2;
            this.textcity.TextChanged += new System.EventHandler(this.textcity_TextChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(370, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(430, 450);
            this.webBrowser1.TabIndex = 1;
            // 
            // buttonsearch
            // 
            this.buttonsearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonsearch.FlatAppearance.BorderSize = 0;
            this.buttonsearch.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonsearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonsearch.Image")));
            this.buttonsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsearch.Location = new System.Drawing.Point(236, 42);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(114, 36);
            this.buttonsearch.TabIndex = 2;
            this.buttonsearch.Text = "検索";
            this.buttonsearch.UseVisualStyleBackColor = false;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // buttoncafe
            // 
            this.buttoncafe.FlatAppearance.BorderSize = 0;
            this.buttoncafe.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttoncafe.Location = new System.Drawing.Point(21, 117);
            this.buttoncafe.Name = "buttoncafe";
            this.buttoncafe.Size = new System.Drawing.Size(91, 36);
            this.buttoncafe.TabIndex = 2;
            this.buttoncafe.Text = "カフェ";
            this.buttoncafe.UseVisualStyleBackColor = true;
            // 
            // buttonspa
            // 
            this.buttonspa.FlatAppearance.BorderSize = 0;
            this.buttonspa.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonspa.Location = new System.Drawing.Point(131, 117);
            this.buttonspa.Name = "buttonspa";
            this.buttonspa.Size = new System.Drawing.Size(102, 36);
            this.buttonspa.TabIndex = 2;
            this.buttonspa.Text = "スパ";
            this.buttonspa.UseVisualStyleBackColor = true;
            // 
            // buttonpark
            // 
            this.buttonpark.FlatAppearance.BorderSize = 0;
            this.buttonpark.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonpark.Location = new System.Drawing.Point(249, 117);
            this.buttonpark.Name = "buttonpark";
            this.buttonpark.Size = new System.Drawing.Size(101, 36);
            this.buttonpark.TabIndex = 2;
            this.buttonpark.Text = "公園";
            this.buttonpark.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textcity;
        private System.Windows.Forms.Label labelcity;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.Button buttonpark;
        private System.Windows.Forms.Button buttonspa;
        private System.Windows.Forms.Button buttoncafe;
    }
}

