namespace LamportPass
{
    partial class AuthForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.numSession = new System.Windows.Forms.NumericUpDown();
            this.rtbServerLog = new System.Windows.Forms.RichTextBox();
            this.btnDoAuth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSession)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::LamportPass.Properties.Resources.Close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(698, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // numSession
            // 
            this.numSession.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.numSession.Location = new System.Drawing.Point(291, 61);
            this.numSession.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSession.Name = "numSession";
            this.numSession.Size = new System.Drawing.Size(152, 26);
            this.numSession.TabIndex = 2;
            this.numSession.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rtbServerLog
            // 
            this.rtbServerLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbServerLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.rtbServerLog.Location = new System.Drawing.Point(12, 92);
            this.rtbServerLog.Name = "rtbServerLog";
            this.rtbServerLog.ReadOnly = true;
            this.rtbServerLog.Size = new System.Drawing.Size(726, 296);
            this.rtbServerLog.TabIndex = 6;
            this.rtbServerLog.Text = "";
            this.rtbServerLog.WordWrap = false;
            // 
            // btnDoAuth
            // 
            this.btnDoAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoAuth.Location = new System.Drawing.Point(457, 60);
            this.btnDoAuth.Name = "btnDoAuth";
            this.btnDoAuth.Size = new System.Drawing.Size(251, 28);
            this.btnDoAuth.TabIndex = 7;
            this.btnDoAuth.Text = "Произвести";
            this.btnDoAuth.UseVisualStyleBackColor = true;
            this.btnDoAuth.Click += new System.EventHandler(this.btnDoAuth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выберите сеанс аутентификации:";
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoAuth);
            this.Controls.Add(this.rtbServerLog);
            this.Controls.Add(this.numSession);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AuthForm";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSession)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NumericUpDown numSession;
        private System.Windows.Forms.RichTextBox rtbServerLog;
        private System.Windows.Forms.Button btnDoAuth;
        private System.Windows.Forms.Label label1;
    }
}