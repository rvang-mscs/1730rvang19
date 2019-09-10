namespace rvang1730ex1d
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMexico = new System.Windows.Forms.TextBox();
            this.txtFrance = new System.Windows.Forms.TextBox();
            this.txtRussia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRateRussia = new System.Windows.Forms.TextBox();
            this.txtRateFrance = new System.Windows.Forms.TextBox();
            this.txtRateMexico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUSDMexico = new System.Windows.Forms.TextBox();
            this.txtUSDFrance = new System.Windows.Forms.TextBox();
            this.txtUSDRussia = new System.Windows.Forms.TextBox();
            this.txtTotalUSD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(96, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 123);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mexico";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(316, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(536, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(214, 123);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(805, 37);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(214, 123);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "France";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Russia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(916, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "US Dollar";
            // 
            // txtMexico
            // 
            this.txtMexico.Location = new System.Drawing.Point(97, 189);
            this.txtMexico.Name = "txtMexico";
            this.txtMexico.Size = new System.Drawing.Size(213, 22);
            this.txtMexico.TabIndex = 0;
            this.txtMexico.Text = "0.00";
            this.txtMexico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMexico.TextChanged += new System.EventHandler(this.mexicoTextChanged);
            // 
            // txtFrance
            // 
            this.txtFrance.Location = new System.Drawing.Point(317, 189);
            this.txtFrance.Name = "txtFrance";
            this.txtFrance.Size = new System.Drawing.Size(213, 22);
            this.txtFrance.TabIndex = 1;
            this.txtFrance.Text = "0.00";
            this.txtFrance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFrance.TextChanged += new System.EventHandler(this.franceTextChanged);
            // 
            // txtRussia
            // 
            this.txtRussia.Location = new System.Drawing.Point(536, 189);
            this.txtRussia.Name = "txtRussia";
            this.txtRussia.Size = new System.Drawing.Size(213, 22);
            this.txtRussia.TabIndex = 2;
            this.txtRussia.Text = "0.00";
            this.txtRussia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRussia.TextChanged += new System.EventHandler(this.russiaTextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Amount:";
            // 
            // txtRateRussia
            // 
            this.txtRateRussia.Location = new System.Drawing.Point(535, 217);
            this.txtRateRussia.Name = "txtRateRussia";
            this.txtRateRussia.Size = new System.Drawing.Size(213, 22);
            this.txtRateRussia.TabIndex = 7;
            this.txtRateRussia.Text = "0.0152555";
            this.txtRateRussia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateRussia.TextChanged += new System.EventHandler(this.russiaTextChanged);
            // 
            // txtRateFrance
            // 
            this.txtRateFrance.Location = new System.Drawing.Point(316, 217);
            this.txtRateFrance.Name = "txtRateFrance";
            this.txtRateFrance.Size = new System.Drawing.Size(213, 22);
            this.txtRateFrance.TabIndex = 6;
            this.txtRateFrance.Text = "1.10449";
            this.txtRateFrance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateFrance.TextChanged += new System.EventHandler(this.franceTextChanged);
            // 
            // txtRateMexico
            // 
            this.txtRateMexico.Location = new System.Drawing.Point(97, 217);
            this.txtRateMexico.Name = "txtRateMexico";
            this.txtRateMexico.Size = new System.Drawing.Size(213, 22);
            this.txtRateMexico.TabIndex = 5;
            this.txtRateMexico.Text = "0.0511047";
            this.txtRateMexico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateMexico.TextChanged += new System.EventHandler(this.mexicoTextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rate:";
            // 
            // txtUSDMexico
            // 
            this.txtUSDMexico.Location = new System.Drawing.Point(96, 264);
            this.txtUSDMexico.Name = "txtUSDMexico";
            this.txtUSDMexico.ReadOnly = true;
            this.txtUSDMexico.Size = new System.Drawing.Size(213, 22);
            this.txtUSDMexico.TabIndex = 15;
            this.txtUSDMexico.TabStop = false;
            this.txtUSDMexico.Text = "0.00";
            this.txtUSDMexico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDMexico.TextChanged += new System.EventHandler(this.USDTextChanged);
            // 
            // txtUSDFrance
            // 
            this.txtUSDFrance.Location = new System.Drawing.Point(317, 264);
            this.txtUSDFrance.Name = "txtUSDFrance";
            this.txtUSDFrance.ReadOnly = true;
            this.txtUSDFrance.Size = new System.Drawing.Size(213, 22);
            this.txtUSDFrance.TabIndex = 16;
            this.txtUSDFrance.TabStop = false;
            this.txtUSDFrance.Text = "0.00";
            this.txtUSDFrance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDFrance.TextChanged += new System.EventHandler(this.USDTextChanged);
            // 
            // txtUSDRussia
            // 
            this.txtUSDRussia.Location = new System.Drawing.Point(537, 264);
            this.txtUSDRussia.Name = "txtUSDRussia";
            this.txtUSDRussia.ReadOnly = true;
            this.txtUSDRussia.Size = new System.Drawing.Size(213, 22);
            this.txtUSDRussia.TabIndex = 17;
            this.txtUSDRussia.TabStop = false;
            this.txtUSDRussia.Text = "0.00";
            this.txtUSDRussia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDRussia.TextChanged += new System.EventHandler(this.USDTextChanged);
            // 
            // txtTotalUSD
            // 
            this.txtTotalUSD.Location = new System.Drawing.Point(805, 264);
            this.txtTotalUSD.Name = "txtTotalUSD";
            this.txtTotalUSD.ReadOnly = true;
            this.txtTotalUSD.Size = new System.Drawing.Size(213, 22);
            this.txtTotalUSD.TabIndex = 18;
            this.txtTotalUSD.TabStop = false;
            this.txtTotalUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalUSD.TextChanged += new System.EventHandler(this.TxtTotalUSD_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "$US";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(769, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "+";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(363, 308);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 27);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(535, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 27);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 399);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalUSD);
            this.Controls.Add(this.txtUSDRussia);
            this.Controls.Add(this.txtUSDFrance);
            this.Controls.Add(this.txtUSDMexico);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRateMexico);
            this.Controls.Add(this.txtRateFrance);
            this.Controls.Add(this.txtRateRussia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRussia);
            this.Controls.Add(this.txtFrance);
            this.Controls.Add(this.txtMexico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMexico;
        private System.Windows.Forms.TextBox txtFrance;
        private System.Windows.Forms.TextBox txtRussia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRateRussia;
        private System.Windows.Forms.TextBox txtRateFrance;
        private System.Windows.Forms.TextBox txtRateMexico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUSDMexico;
        private System.Windows.Forms.TextBox txtUSDFrance;
        private System.Windows.Forms.TextBox txtUSDRussia;
        private System.Windows.Forms.TextBox txtTotalUSD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

