namespace CST.Registrar
{
    partial class reqattachment
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
            this.panelParam = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelParam
            // 
            this.panelParam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelParam.AutoScroll = true;
            this.panelParam.Location = new System.Drawing.Point(12, 12);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(776, 397);
            this.panelParam.TabIndex = 22;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(12, 415);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(293, 48);
            this.button5.TabIndex = 19;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // reqattachment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panelParam);
            this.Name = "reqattachment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reqattachment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.Button button5;
    }
}