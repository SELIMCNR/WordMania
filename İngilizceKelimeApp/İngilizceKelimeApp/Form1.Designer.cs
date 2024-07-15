namespace İngilizceKelimeApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtİngilizce = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTürkce = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblSüre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbldoğru = new System.Windows.Forms.Label();
            this.lblCevab = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblYanlış = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblboş = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce";
            this.label1.Visible = false;
            // 
            // Txtİngilizce
            // 
            this.Txtİngilizce.Location = new System.Drawing.Point(104, 29);
            this.Txtİngilizce.Name = "Txtİngilizce";
            this.Txtİngilizce.Size = new System.Drawing.Size(100, 26);
            this.Txtİngilizce.TabIndex = 10;
            this.Txtİngilizce.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Türkçe";
            this.label2.Visible = false;
            // 
            // TxtTürkce
            // 
            this.TxtTürkce.Location = new System.Drawing.Point(104, 62);
            this.TxtTürkce.Name = "TxtTürkce";
            this.TxtTürkce.Size = new System.Drawing.Size(100, 26);
            this.TxtTürkce.TabIndex = 1;
            this.TxtTürkce.Visible = false;
            this.TxtTürkce.TextChanged += new System.EventHandler(this.TxtTürkce_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Süre:";
            this.label3.Visible = false;
            // 
            // LblSüre
            // 
            this.LblSüre.AutoSize = true;
            this.LblSüre.Location = new System.Drawing.Point(426, 44);
            this.LblSüre.Name = "LblSüre";
            this.LblSüre.Size = new System.Drawing.Size(27, 18);
            this.LblSüre.TabIndex = 0;
            this.LblSüre.Text = "90";
            this.LblSüre.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Doğru:";
            this.label5.Visible = false;
            // 
            // Lbldoğru
            // 
            this.Lbldoğru.AutoSize = true;
            this.Lbldoğru.Location = new System.Drawing.Point(426, 62);
            this.Lbldoğru.Name = "Lbldoğru";
            this.Lbldoğru.Size = new System.Drawing.Size(18, 18);
            this.Lbldoğru.TabIndex = 0;
            this.Lbldoğru.Text = "0";
            this.Lbldoğru.Visible = false;
            // 
            // lblCevab
            // 
            this.lblCevab.AutoSize = true;
            this.lblCevab.Location = new System.Drawing.Point(357, 133);
            this.lblCevab.Name = "lblCevab";
            this.lblCevab.Size = new System.Drawing.Size(49, 18);
            this.lblCevab.TabIndex = 0;
            this.lblCevab.Text = "label1";
            this.lblCevab.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Location = new System.Drawing.Point(121, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 58);
            this.button1.TabIndex = 11;
            this.button1.Text = "Oyuna başla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yanlış:";
            this.label4.Visible = false;
            // 
            // lblYanlış
            // 
            this.lblYanlış.AutoSize = true;
            this.lblYanlış.Location = new System.Drawing.Point(426, 91);
            this.lblYanlış.Name = "lblYanlış";
            this.lblYanlış.Size = new System.Drawing.Size(18, 18);
            this.lblYanlış.TabIndex = 0;
            this.lblYanlış.Text = "0";
            this.lblYanlış.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Boş:";
            this.label7.Visible = false;
            // 
            // lblboş
            // 
            this.lblboş.AutoSize = true;
            this.lblboş.Location = new System.Drawing.Point(426, 109);
            this.lblboş.Name = "lblboş";
            this.lblboş.Size = new System.Drawing.Size(18, 18);
            this.lblboş.TabIndex = 0;
            this.lblboş.Text = "0";
            this.lblboş.Visible = false;
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(357, 26);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(59, 18);
            this.lblPuan.TabIndex = 12;
            this.lblPuan.Text = "Puan:0";
            this.lblPuan.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(153, -5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "World Mania";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.Location = new System.Drawing.Point(38, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 43);
            this.button2.TabIndex = 14;
            this.button2.Text = "Submit Answer ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MistyRose;
            this.button3.Location = new System.Drawing.Point(179, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 43);
            this.button3.TabIndex = 15;
            this.button3.Text = "Pass";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(586, 202);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtTürkce);
            this.Controls.Add(this.Lbldoğru);
            this.Controls.Add(this.lblboş);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblYanlış);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCevab);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblSüre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtİngilizce);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtİngilizce;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTürkce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblSüre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbldoğru;
        private System.Windows.Forms.Label lblCevab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblYanlış;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblboş;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

