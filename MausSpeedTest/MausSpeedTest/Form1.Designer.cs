namespace MausSpeedTest
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
            this.components = new System.ComponentModel.Container();
            this.mouse_pos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.speed = new System.Windows.Forms.Label();
            this.range = new System.Windows.Forms.Label();
            this.speedms = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.range_stat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.max_speed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.average_speed_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.save_checkbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mouse_pos
            // 
            this.mouse_pos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mouse_pos.AutoSize = true;
            this.mouse_pos.Location = new System.Drawing.Point(12, 300);
            this.mouse_pos.Name = "mouse_pos";
            this.mouse_pos.Size = new System.Drawing.Size(0, 13);
            this.mouse_pos.TabIndex = 0;
            this.mouse_pos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mouse_pos.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "dpi/ppi";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.FloralWhite;
            this.textBox1.Location = new System.Drawing.Point(83, 63);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox1.MaxLength = 32;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 13);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.speed.Location = new System.Drawing.Point(80, 108);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(32, 13);
            this.speed.TabIndex = 3;
            this.speed.Text = "km/h";
            // 
            // range
            // 
            this.range.AutoSize = true;
            this.range.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.range.Location = new System.Drawing.Point(80, 135);
            this.range.Name = "range";
            this.range.Size = new System.Drawing.Size(34, 13);
            this.range.TabIndex = 4;
            this.range.Text = "range";
            // 
            // speedms
            // 
            this.speedms.AutoSize = true;
            this.speedms.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.speedms.Location = new System.Drawing.Point(80, 83);
            this.speedms.Name = "speedms";
            this.speedms.Size = new System.Drawing.Size(25, 13);
            this.speedms.TabIndex = 5;
            this.speedms.Text = "m/s";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "m/s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "km/h";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(9, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Distance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(6, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Stats";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(12, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total distance";
            // 
            // range_stat
            // 
            this.range_stat.AutoSize = true;
            this.range_stat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.range_stat.Location = new System.Drawing.Point(163, 191);
            this.range_stat.Name = "range_stat";
            this.range_stat.Size = new System.Drawing.Size(57, 13);
            this.range_stat.TabIndex = 11;
            this.range_stat.Text = "range_stat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(12, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Best Speed (km/h | m/s)";
            // 
            // max_speed
            // 
            this.max_speed.AutoSize = true;
            this.max_speed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.max_speed.Location = new System.Drawing.Point(163, 216);
            this.max_speed.Name = "max_speed";
            this.max_speed.Size = new System.Drawing.Size(61, 13);
            this.max_speed.TabIndex = 13;
            this.max_speed.Text = "max_speed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(12, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Average Speed (km/h | m/s)";
            // 
            // average_speed_label
            // 
            this.average_speed_label.AutoSize = true;
            this.average_speed_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.average_speed_label.Location = new System.Drawing.Point(163, 239);
            this.average_speed_label.Name = "average_speed_label";
            this.average_speed_label.Size = new System.Drawing.Size(81, 13);
            this.average_speed_label.TabIndex = 15;
            this.average_speed_label.Text = "average_speed";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.pictureBox1.Location = new System.Drawing.Point(-25, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 30);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Brown;
            this.button1.Location = new System.Drawing.Point(215, 158);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "RESET";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(9, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(266, 29);
            this.label9.TabIndex = 18;
            this.label9.Text = "MouseSpeedTest";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Brown;
            this.button2.Location = new System.Drawing.Point(255, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 19;
            this.button2.Text = "X";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.LightGray;
            this.button3.Location = new System.Drawing.Point(230, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 20);
            this.button3.TabIndex = 20;
            this.button3.Text = "-";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label10.ForeColor = System.Drawing.Color.LightGreen;
            this.label10.Location = new System.Drawing.Point(213, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "@by DaniGTA";
            // 
            // save_checkbox
            // 
            this.save_checkbox.AutoSize = true;
            this.save_checkbox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.save_checkbox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.save_checkbox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.save_checkbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_checkbox.ForeColor = System.Drawing.Color.OrangeRed;
            this.save_checkbox.Location = new System.Drawing.Point(15, 267);
            this.save_checkbox.Name = "save_checkbox";
            this.save_checkbox.Size = new System.Drawing.Size(75, 17);
            this.save_checkbox.TabIndex = 22;
            this.save_checkbox.Text = "Save Stats";
            this.save_checkbox.UseVisualStyleBackColor = true;
            this.save_checkbox.CheckedChanged += new System.EventHandler(this.save_checkbox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(284, 332);
            this.Controls.Add(this.save_checkbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.average_speed_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.max_speed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.range_stat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.speedms);
            this.Controls.Add(this.range);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mouse_pos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mouse_pos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Label range;
        private System.Windows.Forms.Label speedms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label range_stat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label average_speed_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label max_speed;
        private System.Windows.Forms.CheckBox save_checkbox;
    }
}

