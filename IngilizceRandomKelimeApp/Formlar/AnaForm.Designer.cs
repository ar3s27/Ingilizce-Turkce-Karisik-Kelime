namespace IngilizceRandomKelimeApp.Formlar
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.lblKelime = new System.Windows.Forms.Label();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.brnDigerSoru = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDogruSayisi = new System.Windows.Forms.Label();
            this.lblYanlisSayisi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(641, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce Random Kelime";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.BackColor = System.Drawing.Color.Black;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(600, 5);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(29, 34);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lblKelime
            // 
            this.lblKelime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblKelime.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelime.Location = new System.Drawing.Point(63, 91);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(515, 87);
            this.lblKelime.TabIndex = 2;
            this.lblKelime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCevap
            // 
            this.txtCevap.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCevap.Location = new System.Drawing.Point(70, 201);
            this.txtCevap.Multiline = true;
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(501, 52);
            this.txtCevap.TabIndex = 4;
            this.txtCevap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCevap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCevap_KeyDown);
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.Transparent;
            this.btnOnayla.FlatAppearance.BorderSize = 2;
            this.btnOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnayla.Location = new System.Drawing.Point(292, 259);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(72, 52);
            this.btnOnayla.TabIndex = 5;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Visible = false;
            // 
            // brnDigerSoru
            // 
            this.brnDigerSoru.BackColor = System.Drawing.Color.Transparent;
            this.brnDigerSoru.FlatAppearance.BorderSize = 2;
            this.brnDigerSoru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnDigerSoru.Location = new System.Drawing.Point(70, 259);
            this.brnDigerSoru.Name = "brnDigerSoru";
            this.brnDigerSoru.Size = new System.Drawing.Size(216, 33);
            this.brnDigerSoru.TabIndex = 6;
            this.brnDigerSoru.Text = "Diğer Soru >";
            this.brnDigerSoru.UseVisualStyleBackColor = false;
            this.brnDigerSoru.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 302);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(641, 49);
            this.label3.TabIndex = 7;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Doğru : ";
            // 
            // lblDogruSayisi
            // 
            this.lblDogruSayisi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDogruSayisi.AutoSize = true;
            this.lblDogruSayisi.BackColor = System.Drawing.Color.Black;
            this.lblDogruSayisi.ForeColor = System.Drawing.Color.White;
            this.lblDogruSayisi.Location = new System.Drawing.Point(76, 316);
            this.lblDogruSayisi.Name = "lblDogruSayisi";
            this.lblDogruSayisi.Size = new System.Drawing.Size(19, 21);
            this.lblDogruSayisi.TabIndex = 9;
            this.lblDogruSayisi.Text = "0";
            // 
            // lblYanlisSayisi
            // 
            this.lblYanlisSayisi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblYanlisSayisi.AutoSize = true;
            this.lblYanlisSayisi.BackColor = System.Drawing.Color.Black;
            this.lblYanlisSayisi.ForeColor = System.Drawing.Color.White;
            this.lblYanlisSayisi.Location = new System.Drawing.Point(186, 316);
            this.lblYanlisSayisi.Name = "lblYanlisSayisi";
            this.lblYanlisSayisi.Size = new System.Drawing.Size(19, 21);
            this.lblYanlisSayisi.TabIndex = 11;
            this.lblYanlisSayisi.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(122, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Yanlış : ";
            // 
            // btnBasla
            // 
            this.btnBasla.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBasla.BackColor = System.Drawing.Color.Transparent;
            this.btnBasla.FlatAppearance.BorderSize = 2;
            this.btnBasla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasla.Location = new System.Drawing.Point(506, 309);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(79, 35);
            this.btnBasla.TabIndex = 12;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSifirla.BackColor = System.Drawing.Color.Transparent;
            this.btnSifirla.FlatAppearance.BorderSize = 2;
            this.btnSifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifirla.Location = new System.Drawing.Point(421, 309);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(79, 35);
            this.btnSifirla.TabIndex = 13;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = false;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IngilizceRandomKelimeApp.Properties.Resources.White_Brick_Wallpaper_HD_Computer;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 351);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.lblYanlisSayisi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDogruSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.brnDigerSoru);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDogruSayisi;
        private System.Windows.Forms.Label lblYanlisSayisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBasla;
        public System.Windows.Forms.Label lblKelime;
        public System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button brnDigerSoru;
        private System.Windows.Forms.Button btnSifirla;
    }
}