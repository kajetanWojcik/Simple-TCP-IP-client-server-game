namespace Client
{
    partial class frmClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.lstClients = new System.Windows.Forms.ListBox();
            this.txtMsgs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.klik = new System.Windows.Forms.Label();
            this.labelKlik = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.klik2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelLose = new System.Windows.Forms.Label();
            this.labelWin = new System.Windows.Forms.Label();
            this.labelCzas = new System.Windows.Forms.Label();
            this.buttonReady = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelOdliczanie = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lstClients
            // 
            this.lstClients.FormattingEnabled = true;
            this.lstClients.Location = new System.Drawing.Point(292, 57);
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(120, 173);
            this.lstClients.TabIndex = 0;
            this.lstClients.SelectedIndexChanged += new System.EventHandler(this.lstClients_SelectedIndexChanged);
            // 
            // txtMsgs
            // 
            this.txtMsgs.Location = new System.Drawing.Point(162, 31);
            this.txtMsgs.Multiline = true;
            this.txtMsgs.Name = "txtMsgs";
            this.txtMsgs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsgs.Size = new System.Drawing.Size(124, 199);
            this.txtMsgs.TabIndex = 3;
            this.txtMsgs.TextChanged += new System.EventHandler(this.txtMsgs_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nazwa gracza:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(79, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(181, 20);
            this.txtUserName.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(269, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(126, 21);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(417, 31);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(126, 324);
            this.PictureBox1.TabIndex = 20;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // klik
            // 
            this.klik.AutoSize = true;
            this.klik.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.klik.Location = new System.Drawing.Point(550, 356);
            this.klik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.klik.Name = "klik";
            this.klik.Size = new System.Drawing.Size(22, 26);
            this.klik.TabIndex = 19;
            this.klik.Text = "0";
            this.klik.Click += new System.EventHandler(this.klik_Click);
            // 
            // labelKlik
            // 
            this.labelKlik.AutoSize = true;
            this.labelKlik.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKlik.Location = new System.Drawing.Point(389, 356);
            this.labelKlik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKlik.Name = "labelKlik";
            this.labelKlik.Size = new System.Drawing.Size(154, 26);
            this.labelKlik.TabIndex = 18;
            this.labelKlik.Text = "Kliknięć Twoich:";
            this.labelKlik.Click += new System.EventHandler(this.labelKlik_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "l1.jpg");
            this.imageList1.Images.SetKeyName(1, "l2.jpg");
            this.imageList1.Images.SetKeyName(2, "l3.jpg");
            this.imageList1.Images.SetKeyName(3, "l4.jpg");
            this.imageList1.Images.SetKeyName(4, "l5.jpg");
            this.imageList1.Images.SetKeyName(5, "l6.jpg");
            this.imageList1.Images.SetKeyName(6, "l7.jpg");
            this.imageList1.Images.SetKeyName(7, "l8.jpg");
            this.imageList1.Images.SetKeyName(8, "l9.jpg");
            this.imageList1.Images.SetKeyName(9, "l10.jpg");
            this.imageList1.Images.SetKeyName(10, "l11.jpg");
            this.imageList1.Images.SetKeyName(11, "l12.jpg");
            this.imageList1.Images.SetKeyName(12, "l13.jpg");
            this.imageList1.Images.SetKeyName(13, "l14.jpg");
            this.imageList1.Images.SetKeyName(14, "l15.jpg");
            this.imageList1.Images.SetKeyName(15, "l16.jpg");
            this.imageList1.Images.SetKeyName(16, "l17.jpg");
            this.imageList1.Images.SetKeyName(17, "l18.jpg");
            this.imageList1.Images.SetKeyName(18, "l19.jpg");
            this.imageList1.Images.SetKeyName(19, "l20.jpg");
            this.imageList1.Images.SetKeyName(20, "l21.jpg");
            this.imageList1.Images.SetKeyName(21, "l22.jpg");
            this.imageList1.Images.SetKeyName(22, "l23.jpg");
            this.imageList1.Images.SetKeyName(23, "l24.jpg");
            this.imageList1.Images.SetKeyName(24, "l25.jpg");
            this.imageList1.Images.SetKeyName(25, "l26.jpg");
            this.imageList1.Images.SetKeyName(26, "l27.jpg");
            this.imageList1.Images.SetKeyName(27, "l28.jpg");
            this.imageList1.Images.SetKeyName(28, "l29.jpg");
            this.imageList1.Images.SetKeyName(29, "l30.jpg");
            this.imageList1.Images.SetKeyName(30, "l31.jpg");
            this.imageList1.Images.SetKeyName(31, "l32.jpg");
            this.imageList1.Images.SetKeyName(32, "l33.jpg");
            // 
            // klik2
            // 
            this.klik2.AutoSize = true;
            this.klik2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.klik2.Location = new System.Drawing.Point(191, 356);
            this.klik2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.klik2.Name = "klik2";
            this.klik2.Size = new System.Drawing.Size(22, 26);
            this.klik2.TabIndex = 22;
            this.klik2.Text = "0";
            this.klik2.Click += new System.EventHandler(this.klik2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(-1, 356);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "Kliknięć przeciwnika:";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "p1.jpg");
            this.imageList2.Images.SetKeyName(1, "p2.jpg");
            this.imageList2.Images.SetKeyName(2, "p3.jpg");
            this.imageList2.Images.SetKeyName(3, "p4.jpg");
            this.imageList2.Images.SetKeyName(4, "p5.jpg");
            this.imageList2.Images.SetKeyName(5, "p6.jpg");
            this.imageList2.Images.SetKeyName(6, "p7.jpg");
            this.imageList2.Images.SetKeyName(7, "p8.jpg");
            this.imageList2.Images.SetKeyName(8, "p9.jpg");
            this.imageList2.Images.SetKeyName(9, "p10.jpg");
            this.imageList2.Images.SetKeyName(10, "p11.jpg");
            this.imageList2.Images.SetKeyName(11, "p12.jpg");
            this.imageList2.Images.SetKeyName(12, "p13.jpg");
            this.imageList2.Images.SetKeyName(13, "p14.jpg");
            this.imageList2.Images.SetKeyName(14, "p15.jpg");
            this.imageList2.Images.SetKeyName(15, "p16.jpg");
            this.imageList2.Images.SetKeyName(16, "p17.jpg");
            this.imageList2.Images.SetKeyName(17, "p18.jpg");
            this.imageList2.Images.SetKeyName(18, "p19.jpg");
            this.imageList2.Images.SetKeyName(19, "p20.jpg");
            this.imageList2.Images.SetKeyName(20, "p21.jpg");
            this.imageList2.Images.SetKeyName(21, "p22.jpg");
            this.imageList2.Images.SetKeyName(22, "p23.jpg");
            this.imageList2.Images.SetKeyName(23, "p24.jpg");
            this.imageList2.Images.SetKeyName(24, "p25.jpg");
            this.imageList2.Images.SetKeyName(25, "p26.jpg");
            this.imageList2.Images.SetKeyName(26, "p27.jpg");
            this.imageList2.Images.SetKeyName(27, "p28.jpg");
            this.imageList2.Images.SetKeyName(28, "p29.jpg");
            this.imageList2.Images.SetKeyName(29, "p30.jpg");
            this.imageList2.Images.SetKeyName(30, "p31.jpg");
            this.imageList2.Images.SetKeyName(31, "p32.jpg");
            this.imageList2.Images.SetKeyName(32, "p33.jpg");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 30);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 324);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(236, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "To Twoja żyrafa! ->";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(207, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 26);
            this.label4.TabIndex = 25;
            this.label4.Text = "Klikaj w nią, by pomóc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(215, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 26);
            this.label5.TabIndex = 26;
            this.label5.Text = "jej sięgnąć chmur! ->";
            // 
            // labelLose
            // 
            this.labelLose.AutoSize = true;
            this.labelLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLose.ForeColor = System.Drawing.Color.Red;
            this.labelLose.Location = new System.Drawing.Point(30, 122);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(529, 108);
            this.labelLose.TabIndex = 27;
            this.labelLose.Text = "Przegrałeś!";
            this.labelLose.Click += new System.EventHandler(this.labelLose_Click);
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWin.ForeColor = System.Drawing.Color.Red;
            this.labelWin.Location = new System.Drawing.Point(61, 122);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(471, 108);
            this.labelWin.TabIndex = 28;
            this.labelWin.Text = "Wygrałeś!";
            this.labelWin.Click += new System.EventHandler(this.labelWin_Click);
            // 
            // labelCzas
            // 
            this.labelCzas.AutoSize = true;
            this.labelCzas.Location = new System.Drawing.Point(453, 9);
            this.labelCzas.Name = "labelCzas";
            this.labelCzas.Size = new System.Drawing.Size(0, 13);
            this.labelCzas.TabIndex = 29;
            this.labelCzas.Click += new System.EventHandler(this.labelCzas_Click);
            // 
            // buttonReady
            // 
            this.buttonReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReady.Location = new System.Drawing.Point(241, 334);
            this.buttonReady.Name = "buttonReady";
            this.buttonReady.Size = new System.Drawing.Size(126, 48);
            this.buttonReady.TabIndex = 30;
            this.buttonReady.Text = "GOTOWY!";
            this.buttonReady.UseVisualStyleBackColor = true;
            this.buttonReady.Click += new System.EventHandler(this.buttonReady_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Czas:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelOdliczanie
            // 
            this.labelOdliczanie.AutoSize = true;
            this.labelOdliczanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdliczanie.ForeColor = System.Drawing.Color.Red;
            this.labelOdliczanie.Location = new System.Drawing.Point(213, 122);
            this.labelOdliczanie.Name = "labelOdliczanie";
            this.labelOdliczanie.Size = new System.Drawing.Size(172, 108);
            this.labelOdliczanie.TabIndex = 32;
            this.labelOdliczanie.Text = "odl";
            this.labelOdliczanie.Click += new System.EventHandler(this.labelOdliczanie_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Przeciwnik:";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 392);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelOdliczanie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonReady);
            this.Controls.Add(this.labelCzas);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.labelLose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.klik2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.klik);
            this.Controls.Add(this.labelKlik);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMsgs);
            this.Controls.Add(this.lstClients);
            this.Name = "frmClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.frmClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstClients;
        private System.Windows.Forms.TextBox txtMsgs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnLogin;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label klik;
        internal System.Windows.Forms.Label labelKlik;
        private System.Windows.Forms.ImageList imageList1;
        internal System.Windows.Forms.Label klik2;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList2;
        internal System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelLose;
        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Label labelCzas;
        private System.Windows.Forms.Button buttonReady;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelOdliczanie;
        private System.Windows.Forms.Label label7;
    }
}

