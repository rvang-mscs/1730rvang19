namespace rvang17302B
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalUSD = new System.Windows.Forms.TextBox();
            this.txtUSDRussia = new System.Windows.Forms.TextBox();
            this.txtUSDFrance = new System.Windows.Forms.TextBox();
            this.txtUSDMexico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRateMexico = new System.Windows.Forms.TextBox();
            this.txtRateFrance = new System.Windows.Forms.TextBox();
            this.txtRateRussia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRussia = new System.Windows.Forms.TextBox();
            this.txtFrance = new System.Windows.Forms.TextBox();
            this.txtMexico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(510, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 27);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(338, 308);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 27);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(744, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "$US";
            // 
            // txtTotalUSD
            // 
            this.txtTotalUSD.Location = new System.Drawing.Point(780, 264);
            this.txtTotalUSD.Name = "txtTotalUSD";
            this.txtTotalUSD.ReadOnly = true;
            this.txtTotalUSD.Size = new System.Drawing.Size(213, 22);
            this.txtTotalUSD.TabIndex = 42;
            this.txtTotalUSD.TabStop = false;
            this.txtTotalUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDRussia
            // 
            this.txtUSDRussia.Location = new System.Drawing.Point(512, 264);
            this.txtUSDRussia.Name = "txtUSDRussia";
            this.txtUSDRussia.ReadOnly = true;
            this.txtUSDRussia.Size = new System.Drawing.Size(213, 22);
            this.txtUSDRussia.TabIndex = 41;
            this.txtUSDRussia.TabStop = false;
            this.txtUSDRussia.Text = "0.00";
            this.txtUSDRussia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDRussia.TextChanged += new System.EventHandler(this.USDChanged);
            // 
            // txtUSDFrance
            // 
            this.txtUSDFrance.Location = new System.Drawing.Point(292, 264);
            this.txtUSDFrance.Name = "txtUSDFrance";
            this.txtUSDFrance.ReadOnly = true;
            this.txtUSDFrance.Size = new System.Drawing.Size(213, 22);
            this.txtUSDFrance.TabIndex = 40;
            this.txtUSDFrance.TabStop = false;
            this.txtUSDFrance.Text = "0.00";
            this.txtUSDFrance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDFrance.TextChanged += new System.EventHandler(this.USDChanged);
            // 
            // txtUSDMexico
            // 
            this.txtUSDMexico.Location = new System.Drawing.Point(71, 264);
            this.txtUSDMexico.Name = "txtUSDMexico";
            this.txtUSDMexico.ReadOnly = true;
            this.txtUSDMexico.Size = new System.Drawing.Size(213, 22);
            this.txtUSDMexico.TabIndex = 39;
            this.txtUSDMexico.TabStop = false;
            this.txtUSDMexico.Text = "0.00";
            this.txtUSDMexico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDMexico.TextChanged += new System.EventHandler(this.USDChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Rate:";
            // 
            // txtRateMexico
            // 
            this.txtRateMexico.Location = new System.Drawing.Point(72, 217);
            this.txtRateMexico.Name = "txtRateMexico";
            this.txtRateMexico.Size = new System.Drawing.Size(213, 22);
            this.txtRateMexico.TabIndex = 29;
            this.txtRateMexico.Text = "0.0511047";
            this.txtRateMexico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateMexico.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateFrance
            // 
            this.txtRateFrance.Location = new System.Drawing.Point(291, 217);
            this.txtRateFrance.Name = "txtRateFrance";
            this.txtRateFrance.Size = new System.Drawing.Size(213, 22);
            this.txtRateFrance.TabIndex = 30;
            this.txtRateFrance.Text = "1.10449";
            this.txtRateFrance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateFrance.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateRussia
            // 
            this.txtRateRussia.Location = new System.Drawing.Point(510, 217);
            this.txtRateRussia.Name = "txtRateRussia";
            this.txtRateRussia.Size = new System.Drawing.Size(213, 22);
            this.txtRateRussia.TabIndex = 31;
            this.txtRateRussia.Text = "0.0152555";
            this.txtRateRussia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateRussia.TextChanged += new System.EventHandler(this.calculate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Amount:";
            // 
            // txtRussia
            // 
            this.txtRussia.Location = new System.Drawing.Point(511, 189);
            this.txtRussia.Name = "txtRussia";
            this.txtRussia.Size = new System.Drawing.Size(213, 22);
            this.txtRussia.TabIndex = 24;
            this.txtRussia.Text = "0.00";
            this.txtRussia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRussia.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtFrance
            // 
            this.txtFrance.Location = new System.Drawing.Point(292, 189);
            this.txtFrance.Name = "txtFrance";
            this.txtFrance.Size = new System.Drawing.Size(213, 22);
            this.txtFrance.TabIndex = 22;
            this.txtFrance.Text = "0.00";
            this.txtFrance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFrance.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtMexico
            // 
            this.txtMexico.Location = new System.Drawing.Point(72, 189);
            this.txtMexico.Name = "txtMexico";
            this.txtMexico.Size = new System.Drawing.Size(213, 22);
            this.txtMexico.TabIndex = 21;
            this.txtMexico.Text = "0.00";
            this.txtMexico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMexico.TextChanged += new System.EventHandler(this.calculate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(891, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "US Dollar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Russia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "France";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(780, 37);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(214, 123);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(511, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(214, 123);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(291, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mexico";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(71, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 123);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 371);
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
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalUSD;
        private System.Windows.Forms.TextBox txtUSDRussia;
        private System.Windows.Forms.TextBox txtUSDFrance;
        private System.Windows.Forms.TextBox txtUSDMexico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRateMexico;
        private System.Windows.Forms.TextBox txtRateFrance;
        private System.Windows.Forms.TextBox txtRateRussia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRussia;
        private System.Windows.Forms.TextBox txtFrance;
        private System.Windows.Forms.TextBox txtMexico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

