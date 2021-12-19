namespace ForBetterHealth
{
    partial class Notification
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mainLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainLabel.Location = new System.Drawing.Point(12, 20);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(110, 29);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "쉬는 시간!";
            this.mainLabel.Click += new System.EventHandler(this.mainLabel_Click);
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Font = new System.Drawing.Font("AppleSDGothicNeoR00", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.descLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.descLabel.Location = new System.Drawing.Point(12, 54);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(165, 19);
            this.descLabel.TabIndex = 1;
            this.descLabel.Text = "눈 깜빡이고 스트레칭 쭉!";
            this.descLabel.Click += new System.EventHandler(this.descLabel_Click);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(223, 92);
            this.ControlBox = false;
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.mainLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notification";
            this.Text = "Notification";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Notification_Load);
            this.Click += new System.EventHandler(this.Notification_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label descLabel;
    }
}