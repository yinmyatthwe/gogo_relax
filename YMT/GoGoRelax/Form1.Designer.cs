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
            this.searchBtn = new System.Windows.Forms.Button();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cafeCheckBox = new System.Windows.Forms.CheckBox();
            this.parkCheckBox = new System.Windows.Forms.CheckBox();
            this.onsenCheckBox = new System.Windows.Forms.CheckBox();
            this.seaCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("MS PMincho", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(289, 19);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(93, 36);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "検索";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // cityTxt
            // 
            this.cityTxt.Location = new System.Drawing.Point(89, 24);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(183, 26);
            this.cityTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PMincho", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "県、市";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 5;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PMincho", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "地図";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cafeCheckBox
            // 
            this.cafeCheckBox.AutoSize = true;
            this.cafeCheckBox.Font = new System.Drawing.Font("MS PMincho", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cafeCheckBox.Location = new System.Drawing.Point(12, 63);
            this.cafeCheckBox.Name = "cafeCheckBox";
            this.cafeCheckBox.Size = new System.Drawing.Size(82, 22);
            this.cafeCheckBox.TabIndex = 7;
            this.cafeCheckBox.Text = "カフェ";
            this.cafeCheckBox.UseVisualStyleBackColor = true;
            this.cafeCheckBox.CheckedChanged += new System.EventHandler(this.cafeCheckBox_CheckedChanged);
            // 
            // parkCheckBox
            // 
            this.parkCheckBox.AutoSize = true;
            this.parkCheckBox.Font = new System.Drawing.Font("MS PMincho", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkCheckBox.Location = new System.Drawing.Point(93, 63);
            this.parkCheckBox.Name = "parkCheckBox";
            this.parkCheckBox.Size = new System.Drawing.Size(72, 22);
            this.parkCheckBox.TabIndex = 8;
            this.parkCheckBox.Text = "公園";
            this.parkCheckBox.UseVisualStyleBackColor = true;
            // 
            // onsenCheckBox
            // 
            this.onsenCheckBox.AutoSize = true;
            this.onsenCheckBox.Font = new System.Drawing.Font("MS PMincho", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onsenCheckBox.Location = new System.Drawing.Point(234, 63);
            this.onsenCheckBox.Name = "onsenCheckBox";
            this.onsenCheckBox.Size = new System.Drawing.Size(72, 22);
            this.onsenCheckBox.TabIndex = 9;
            this.onsenCheckBox.Text = "温泉";
            this.onsenCheckBox.UseVisualStyleBackColor = true;
            // 
            // seaCheckBox
            // 
            this.seaCheckBox.AutoSize = true;
            this.seaCheckBox.Font = new System.Drawing.Font("MS PMincho", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seaCheckBox.Location = new System.Drawing.Point(173, 63);
            this.seaCheckBox.Name = "seaCheckBox";
            this.seaCheckBox.Size = new System.Drawing.Size(53, 22);
            this.seaCheckBox.TabIndex = 10;
            this.seaCheckBox.Text = "海";
            this.seaCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-2, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 335);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS PMincho", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "結果";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.webView);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(395, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 457);
            this.panel2.TabIndex = 12;
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(0, 30);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(650, 424);
            this.webView.TabIndex = 1;
            this.webView.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 639);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.seaCheckBox);
            this.Controls.Add(this.onsenCheckBox);
            this.Controls.Add(this.parkCheckBox);
            this.Controls.Add(this.cafeCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityTxt);
            this.Controls.Add(this.searchBtn);
            this.Name = "Form1";
            this.Text = "GoGoRelax";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox cityTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cafeCheckBox;
        private System.Windows.Forms.CheckBox parkCheckBox;
        private System.Windows.Forms.CheckBox onsenCheckBox;
        private System.Windows.Forms.CheckBox seaCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}

