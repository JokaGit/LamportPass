namespace LamportPass
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbSecret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRandomSecret = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbKeys = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumOfKeys = new System.Windows.Forms.TextBox();
            this.btnSendToServer = new System.Windows.Forms.Button();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numSession = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnManualAuth = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbClientKey = new System.Windows.Forms.TextBox();
            this.btnAuth = new System.Windows.Forms.Button();
            this.rtbServerLog = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSession)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSecret
            // 
            this.tbSecret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSecret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbSecret.Location = new System.Drawing.Point(96, 83);
            this.tbSecret.Name = "tbSecret";
            this.tbSecret.Size = new System.Drawing.Size(383, 26);
            this.tbSecret.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.label1.Location = new System.Drawing.Point(21, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Секрет:";
            // 
            // btnRandomSecret
            // 
            this.btnRandomSecret.BackColor = System.Drawing.Color.Transparent;
            this.btnRandomSecret.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnRandomSecret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomSecret.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRandomSecret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btnRandomSecret.Location = new System.Drawing.Point(96, 114);
            this.btnRandomSecret.Margin = new System.Windows.Forms.Padding(2);
            this.btnRandomSecret.Name = "btnRandomSecret";
            this.btnRandomSecret.Size = new System.Drawing.Size(383, 30);
            this.btnRandomSecret.TabIndex = 3;
            this.btnRandomSecret.Text = "Сгенерировать случайный секрет";
            this.btnRandomSecret.UseVisualStyleBackColor = false;
            this.btnRandomSecret.Click += new System.EventHandler(this.btnRandomSecret_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.rtbKeys);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbNumOfKeys);
            this.panel1.Controls.Add(this.tbSecret);
            this.panel1.Controls.Add(this.btnSendToServer);
            this.panel1.Controls.Add(this.btnGenerateKeys);
            this.panel1.Controls.Add(this.btnRandomSecret);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(18);
            this.panel1.Size = new System.Drawing.Size(500, 550);
            this.panel1.TabIndex = 4;
            // 
            // rtbKeys
            // 
            this.rtbKeys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbKeys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.rtbKeys.Location = new System.Drawing.Point(25, 287);
            this.rtbKeys.Name = "rtbKeys";
            this.rtbKeys.ReadOnly = true;
            this.rtbKeys.Size = new System.Drawing.Size(328, 242);
            this.rtbKeys.TabIndex = 5;
            this.rtbKeys.Text = "";
            this.rtbKeys.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Клиентская часть";
            // 
            // tbNumOfKeys
            // 
            this.tbNumOfKeys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNumOfKeys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbNumOfKeys.Location = new System.Drawing.Point(272, 159);
            this.tbNumOfKeys.Name = "tbNumOfKeys";
            this.tbNumOfKeys.Size = new System.Drawing.Size(207, 26);
            this.tbNumOfKeys.TabIndex = 1;
            this.tbNumOfKeys.Text = "10";
            // 
            // btnSendToServer
            // 
            this.btnSendToServer.BackColor = System.Drawing.Color.Transparent;
            this.btnSendToServer.FlatAppearance.BorderSize = 0;
            this.btnSendToServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnSendToServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendToServer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendToServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btnSendToServer.Image = global::LamportPass.Properties.Resources.Arrow_Right;
            this.btnSendToServer.Location = new System.Drawing.Point(358, 287);
            this.btnSendToServer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendToServer.Name = "btnSendToServer";
            this.btnSendToServer.Size = new System.Drawing.Size(121, 242);
            this.btnSendToServer.TabIndex = 3;
            this.btnSendToServer.Text = "Отправить на сервер";
            this.btnSendToServer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSendToServer.UseVisualStyleBackColor = false;
            this.btnSendToServer.Click += new System.EventHandler(this.btnSendToServer_Click);
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateKeys.Enabled = false;
            this.btnGenerateKeys.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnGenerateKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateKeys.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerateKeys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btnGenerateKeys.Location = new System.Drawing.Point(25, 208);
            this.btnGenerateKeys.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(454, 64);
            this.btnGenerateKeys.TabIndex = 3;
            this.btnGenerateKeys.Text = "Произвести генерацию ключей\r\n";
            this.btnGenerateKeys.UseVisualStyleBackColor = false;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.label4.Location = new System.Drawing.Point(21, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Количество сеансовых ключей:\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnAuth);
            this.panel2.Controls.Add(this.rtbServerLog);
            this.panel2.Controls.Add(this.label3);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel2.Location = new System.Drawing.Point(500, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(18);
            this.panel2.Size = new System.Drawing.Size(500, 550);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.numSession);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnManualAuth);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tbClientKey);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(27, 356);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(452, 182);
            this.panel3.TabIndex = 7;
            // 
            // numSession
            // 
            this.numSession.Location = new System.Drawing.Point(134, 9);
            this.numSession.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSession.Name = "numSession";
            this.numSession.Size = new System.Drawing.Size(120, 26);
            this.numSession.TabIndex = 7;
            this.numSession.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSession.ValueChanged += new System.EventHandler(this.numSession_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ключ клиента";
            // 
            // btnManualAuth
            // 
            this.btnManualAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManualAuth.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnManualAuth.Location = new System.Drawing.Point(7, 98);
            this.btnManualAuth.Name = "btnManualAuth";
            this.btnManualAuth.Size = new System.Drawing.Size(435, 48);
            this.btnManualAuth.TabIndex = 6;
            this.btnManualAuth.Text = "Ручная аутентификация";
            this.btnManualAuth.UseVisualStyleBackColor = true;
            this.btnManualAuth.Click += new System.EventHandler(this.btnManualAuth_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Номер сеанса";
            // 
            // tbClientKey
            // 
            this.tbClientKey.Location = new System.Drawing.Point(134, 41);
            this.tbClientKey.Name = "tbClientKey";
            this.tbClientKey.Size = new System.Drawing.Size(308, 26);
            this.tbClientKey.TabIndex = 0;
            this.tbClientKey.Enter += new System.EventHandler(this.tbClientKey_Enter);
            // 
            // btnAuth
            // 
            this.btnAuth.Enabled = false;
            this.btnAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuth.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAuth.Location = new System.Drawing.Point(27, 282);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(452, 65);
            this.btnAuth.TabIndex = 6;
            this.btnAuth.Text = "Произвести аутентификацию";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // rtbServerLog
            // 
            this.rtbServerLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbServerLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.rtbServerLog.Location = new System.Drawing.Point(27, 83);
            this.rtbServerLog.Name = "rtbServerLog";
            this.rtbServerLog.ReadOnly = true;
            this.rtbServerLog.Size = new System.Drawing.Size(452, 189);
            this.rtbServerLog.TabIndex = 5;
            this.rtbServerLog.Text = "";
            this.rtbServerLog.TextChanged += new System.EventHandler(this.rtbServerLog_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Серверная часть";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btnInfo);
            this.panel4.Controls.Add(this.label7);
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1000, 65);
            this.panel4.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::LamportPass.Properties.Resources.Close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(948, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::LamportPass.Properties.Resources.Book_Help;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(856, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BackgroundImage = global::LamportPass.Properties.Resources.Info_Circle;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ForeColor = System.Drawing.Color.Transparent;
            this.btnInfo.Location = new System.Drawing.Point(902, 12);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(40, 40);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(19, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(809, 30);
            this.label7.TabIndex = 4;
            this.label7.Text = "Реализация удаленной аутентификации по протоколу Лампорта";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 615);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSession)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbSecret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRandomSecret;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumOfKeys;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbKeys;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.Button btnSendToServer;
        private System.Windows.Forms.RichTextBox rtbServerLog;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnManualAuth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbClientKey;
        private System.Windows.Forms.NumericUpDown numSession;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

