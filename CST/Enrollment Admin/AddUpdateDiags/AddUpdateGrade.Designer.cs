namespace CST.Enrollment_Admin.AddUpdateDiags
{
    partial class AddUpdateGrade
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
            this.cbGradeLevel = new System.Windows.Forms.ComboBox();
            this.labelGradeLevel = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.gradelevelno = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbGradeLevel
            // 
            this.cbGradeLevel.DropDownHeight = 150;
            this.cbGradeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGradeLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbGradeLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbGradeLevel.FormattingEnabled = true;
            this.cbGradeLevel.IntegralHeight = false;
            this.cbGradeLevel.ItemHeight = 20;
            this.cbGradeLevel.Items.AddRange(new object[] {
            "Pre-School",
            "Primary Education",
            "Secondary Education"});
            this.cbGradeLevel.Location = new System.Drawing.Point(62, 49);
            this.cbGradeLevel.Name = "cbGradeLevel";
            this.cbGradeLevel.Size = new System.Drawing.Size(157, 28);
            this.cbGradeLevel.TabIndex = 271;
            this.cbGradeLevel.SelectedIndexChanged += new System.EventHandler(this.cbGradeLevel_SelectedIndexChanged);
            // 
            // labelGradeLevel
            // 
            this.labelGradeLevel.AutoSize = true;
            this.labelGradeLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelGradeLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradeLevel.ForeColor = System.Drawing.Color.Black;
            this.labelGradeLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelGradeLevel.Location = new System.Drawing.Point(80, 96);
            this.labelGradeLevel.Name = "labelGradeLevel";
            this.labelGradeLevel.Size = new System.Drawing.Size(121, 16);
            this.labelGradeLevel.TabIndex = 270;
            this.labelGradeLevel.Text = "Grade Level No.";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label23.Location = new System.Drawing.Point(68, 30);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(133, 16);
            this.label23.TabIndex = 269;
            this.label23.Text = "Grade Level Type";
            // 
            // gradelevelno
            // 
            this.gradelevelno.DropDownHeight = 150;
            this.gradelevelno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradelevelno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gradelevelno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gradelevelno.FormattingEnabled = true;
            this.gradelevelno.IntegralHeight = false;
            this.gradelevelno.ItemHeight = 20;
            this.gradelevelno.Location = new System.Drawing.Point(62, 127);
            this.gradelevelno.Name = "gradelevelno";
            this.gradelevelno.Size = new System.Drawing.Size(157, 28);
            this.gradelevelno.TabIndex = 272;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(83, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 35);
            this.button1.TabIndex = 273;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddUpdateGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CST.Properties.Resources.b;
            this.ClientSize = new System.Drawing.Size(277, 223);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbGradeLevel);
            this.Controls.Add(this.labelGradeLevel);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.gradelevelno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddUpdateGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbGradeLevel;
        private System.Windows.Forms.Label labelGradeLevel;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.ComboBox gradelevelno;
        private System.Windows.Forms.Button button1;
    }
}