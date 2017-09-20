namespace FTPtoDisk
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ip_input = new System.Windows.Forms.TextBox();
            this.ip_text = new System.Windows.Forms.Label();
            this.port_text = new System.Windows.Forms.Label();
            this.port_input = new System.Windows.Forms.TextBox();
            this.name_text = new System.Windows.Forms.Label();
            this.name_input = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.Label();
            this.password_input = new System.Windows.Forms.TextBox();
            this.connect_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ip_input
            // 
            this.ip_input.Location = new System.Drawing.Point(105, 33);
            this.ip_input.Name = "ip_input";
            this.ip_input.Size = new System.Drawing.Size(167, 20);
            this.ip_input.TabIndex = 0;
            // 
            // ip_text
            // 
            this.ip_text.AutoSize = true;
            this.ip_text.Location = new System.Drawing.Point(12, 36);
            this.ip_text.Name = "ip_text";
            this.ip_text.Size = new System.Drawing.Size(17, 13);
            this.ip_text.TabIndex = 1;
            this.ip_text.Text = "IP";
            // 
            // port_text
            // 
            this.port_text.AutoSize = true;
            this.port_text.Location = new System.Drawing.Point(12, 62);
            this.port_text.Name = "port_text";
            this.port_text.Size = new System.Drawing.Size(37, 13);
            this.port_text.TabIndex = 3;
            this.port_text.Text = "PORT";
            // 
            // port_input
            // 
            this.port_input.Location = new System.Drawing.Point(105, 59);
            this.port_input.Name = "port_input";
            this.port_input.Size = new System.Drawing.Size(167, 20);
            this.port_input.TabIndex = 2;
            // 
            // name_text
            // 
            this.name_text.AutoSize = true;
            this.name_text.Location = new System.Drawing.Point(12, 88);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(38, 13);
            this.name_text.TabIndex = 5;
            this.name_text.Text = "NAME";
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(105, 85);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(167, 20);
            this.name_input.TabIndex = 4;
            // 
            // password_text
            // 
            this.password_text.AutoSize = true;
            this.password_text.Location = new System.Drawing.Point(12, 114);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(70, 13);
            this.password_text.TabIndex = 7;
            this.password_text.Text = "PASSWORD";
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(105, 111);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(167, 20);
            this.password_input.TabIndex = 6;
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(7, 145);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(265, 23);
            this.connect_btn.TabIndex = 8;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.port_text);
            this.Controls.Add(this.port_input);
            this.Controls.Add(this.ip_text);
            this.Controls.Add(this.ip_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ip_input;
        private System.Windows.Forms.Label ip_text;
        private System.Windows.Forms.Label port_text;
        private System.Windows.Forms.TextBox port_input;
        private System.Windows.Forms.Label name_text;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label password_text;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Button connect_btn;
    }
}

