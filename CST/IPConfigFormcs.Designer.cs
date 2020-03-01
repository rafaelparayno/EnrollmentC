namespace CST
{
    partial class IPConfigFormcs { 


        private System.ComponentModel.IContainer components = null;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IPConfigFormcs));
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnConnect = new System.Windows.Forms.Button();
			this.txtLastname = new System.Windows.Forms.TextBox();
			this.txtServername = new System.Windows.Forms.TextBox();
			this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDatabase = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Location = new System.Drawing.Point(-1, 37);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(540, 5);
			this.panel4.TabIndex = 210;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.panel5.Location = new System.Drawing.Point(273, 192);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(236, 5);
			this.panel5.TabIndex = 144;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 16);
			this.label1.TabIndex = 209;
			this.label1.Text = "IP Configuration";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// btnConnect
			// 
			this.btnConnect.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConnect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnConnect.Location = new System.Drawing.Point(260, 370);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(132, 35);
			this.btnConnect.TabIndex = 4;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = false;
			this.btnConnect.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtLastname
			// 
			this.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLastname.Enabled = false;
			this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLastname.ForeColor = System.Drawing.Color.Black;
			this.txtLastname.Location = new System.Drawing.Point(13, -258);
			this.txtLastname.Multiline = true;
			this.txtLastname.Name = "txtLastname";
			this.txtLastname.Size = new System.Drawing.Size(260, 28);
			this.txtLastname.TabIndex = 211;
			this.txtLastname.TextChanged += new System.EventHandler(this.txtLastname_TextChanged);
			// 
			// txtServername
			// 
			this.txtServername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtServername.Enabled = false;
			this.txtServername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtServername.ForeColor = System.Drawing.Color.DarkGray;
			this.txtServername.Location = new System.Drawing.Point(136, 82);
			this.txtServername.Multiline = true;
			this.txtServername.Name = "txtServername";
			this.txtServername.Size = new System.Drawing.Size(260, 28);
			this.txtServername.TabIndex = 0;
			this.txtServername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtServername.TextChanged += new System.EventHandler(this.textBox1_);
			this.txtServername.Enter += new System.EventHandler(this.textBox1_);
			// 
			// ep1
			// 
			this.ep1.ContainerControl = this;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new System.Drawing.Point(231, 45);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(65, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "Server";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label3.Location = new System.Drawing.Point(192, 124);
			this.label3.Name = "label3";
			this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label3.Size = new System.Drawing.Size(144, 24);
			this.label3.TabIndex = 216;
			this.label3.Text = "Database Name";
			// 
			// txtDatabase
			// 
			this.txtDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDatabase.ForeColor = System.Drawing.Color.DarkGray;
			this.txtDatabase.Location = new System.Drawing.Point(136, 162);
			this.txtDatabase.Multiline = true;
			this.txtDatabase.Name = "txtDatabase";
			this.txtDatabase.Size = new System.Drawing.Size(260, 28);
			this.txtDatabase.TabIndex = 1;
			this.txtDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label4.Location = new System.Drawing.Point(216, 279);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label4.Size = new System.Drawing.Size(91, 24);
			this.label4.TabIndex = 218;
			this.label4.Text = "password";
			// 
			// txtPassword
			// 
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.ForeColor = System.Drawing.Color.DarkGray;
			this.txtPassword.Location = new System.Drawing.Point(132, 315);
			this.txtPassword.Multiline = true;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(260, 28);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label5.Location = new System.Drawing.Point(214, 202);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label5.Size = new System.Drawing.Size(97, 24);
			this.label5.TabIndex = 220;
			this.label5.Text = "Username";
			// 
			// txtUsername
			// 
			this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.ForeColor = System.Drawing.Color.DarkGray;
			this.txtUsername.Location = new System.Drawing.Point(132, 233);
			this.txtUsername.Multiline = true;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(260, 28);
			this.txtUsername.TabIndex = 2;
			this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnLogin.Location = new System.Drawing.Point(132, 371);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(106, 34);
			this.btnLogin.TabIndex = 221;
			this.btnLogin.Text = "Cancel";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// IPConfigFormcs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(539, 417);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDatabase);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtServername);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.txtLastname);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "IPConfigFormcs";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IPConfigFormcs";
			this.Load += new System.EventHandler(this.IPConfigFormcs_Load);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.IPConfigFormcs_KeyUp);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        public System.Windows.Forms.TextBox txtLastname;
        public System.Windows.Forms.TextBox txtServername;
        private System.Windows.Forms.ErrorProvider ep1;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox txtDatabase;
		private System.Windows.Forms.Button btnLogin;
	}
 }

