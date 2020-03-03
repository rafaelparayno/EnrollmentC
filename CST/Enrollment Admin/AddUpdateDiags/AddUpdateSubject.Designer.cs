namespace CST.Enrollment_Admin.AddUpdateDiags
{
    partial class AddUpdateSubject
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbGradeLevel = new System.Windows.Forms.ComboBox();
            this.labelGradeLevel = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 28);
            this.textBox1.TabIndex = 268;
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
            this.cbGradeLevel.Location = new System.Drawing.Point(20, 51);
            this.cbGradeLevel.Name = "cbGradeLevel";
            this.cbGradeLevel.Size = new System.Drawing.Size(157, 28);
            this.cbGradeLevel.TabIndex = 267;
            // 
            // labelGradeLevel
            // 
            this.labelGradeLevel.AutoSize = true;
            this.labelGradeLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelGradeLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradeLevel.ForeColor = System.Drawing.Color.Black;
            this.labelGradeLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelGradeLevel.Location = new System.Drawing.Point(183, 28);
            this.labelGradeLevel.Name = "labelGradeLevel";
            this.labelGradeLevel.Size = new System.Drawing.Size(60, 16);
            this.labelGradeLevel.TabIndex = 266;
            this.labelGradeLevel.Text = "Subject";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label23.Location = new System.Drawing.Point(17, 28);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(97, 16);
            this.label23.TabIndex = 265;
            this.label23.Text = "Grade Level ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(125, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 35);
            this.button1.TabIndex = 289;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddUpdateSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CST.Properties.Resources.b;
            this.ClientSize = new System.Drawing.Size(355, 166);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbGradeLevel);
            this.Controls.Add(this.labelGradeLevel);
            this.Controls.Add(this.label23);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddUpdateSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add or Update Section";
            this.Load += new System.EventHandler(this.AddUpdateSection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ComboBox cbGradeLevel;
        private System.Windows.Forms.Label labelGradeLevel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button1;
    }
}