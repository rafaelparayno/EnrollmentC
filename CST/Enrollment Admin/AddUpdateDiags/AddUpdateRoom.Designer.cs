namespace CST.Enrollment_Admin.AddUpdateDiags
{
    partial class AddUpdateRoom
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
            this.txtRoomNo = new System.Windows.Forms.NumericUpDown();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomNo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRoomNo.Location = new System.Drawing.Point(30, 103);
            this.txtRoomNo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtRoomNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(221, 26);
            this.txtRoomNo.TabIndex = 279;
            this.txtRoomNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtRoomNo.ValueChanged += new System.EventHandler(this.txtRoomNo_ValueChanged);
            // 
            // cbRoom
            // 
            this.cbRoom.DropDownHeight = 150;
            this.cbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbRoom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.IntegralHeight = false;
            this.cbRoom.ItemHeight = 20;
            this.cbRoom.Location = new System.Drawing.Point(27, 34);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(224, 28);
            this.cbRoom.TabIndex = 278;
            this.cbRoom.SelectedIndexChanged += new System.EventHandler(this.cbRoom_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label22.Location = new System.Drawing.Point(27, 81);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(120, 16);
            this.label22.TabIndex = 277;
            this.label22.Text = "Class Room No.";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label23.Location = new System.Drawing.Point(27, 13);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(132, 16);
            this.label23.TabIndex = 276;
            this.label23.Text = "Class Room Type";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(48, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 35);
            this.button1.TabIndex = 285;
            this.button1.Text = " Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddUpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CST.Properties.Resources.b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(278, 210);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.cbRoom);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddUpdateRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdateRoom";
            this.Load += new System.EventHandler(this.AddUpdateRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtRoomNo;
        public System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button1;
    }
}