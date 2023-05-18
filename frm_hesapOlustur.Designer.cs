namespace loginOOP
{
    partial class frm_hesapOlustur
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
            this.lbl_kullaniciAdiOlustur = new System.Windows.Forms.Label();
            this.lbl_sifreOlustur = new System.Windows.Forms.Label();
            this.lbl_sifreTekrar = new System.Windows.Forms.Label();
            this.txtBox_kullaniciAdiOlustur = new System.Windows.Forms.TextBox();
            this.txtBox_sifreOlustur = new System.Windows.Forms.TextBox();
            this.txtBox_sifreTekrar = new System.Windows.Forms.TextBox();
            this.btn_hesapOlustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_kullaniciAdiOlustur
            // 
            this.lbl_kullaniciAdiOlustur.AutoSize = true;
            this.lbl_kullaniciAdiOlustur.Location = new System.Drawing.Point(79, 53);
            this.lbl_kullaniciAdiOlustur.Name = "lbl_kullaniciAdiOlustur";
            this.lbl_kullaniciAdiOlustur.Size = new System.Drawing.Size(79, 16);
            this.lbl_kullaniciAdiOlustur.TabIndex = 0;
            this.lbl_kullaniciAdiOlustur.Text = "Kullanıcı Adı";
            // 
            // lbl_sifreOlustur
            // 
            this.lbl_sifreOlustur.AutoSize = true;
            this.lbl_sifreOlustur.Location = new System.Drawing.Point(81, 107);
            this.lbl_sifreOlustur.Name = "lbl_sifreOlustur";
            this.lbl_sifreOlustur.Size = new System.Drawing.Size(34, 16);
            this.lbl_sifreOlustur.TabIndex = 1;
            this.lbl_sifreOlustur.Text = "Şifre";
            // 
            // lbl_sifreTekrar
            // 
            this.lbl_sifreTekrar.AutoSize = true;
            this.lbl_sifreTekrar.Location = new System.Drawing.Point(81, 169);
            this.lbl_sifreTekrar.Name = "lbl_sifreTekrar";
            this.lbl_sifreTekrar.Size = new System.Drawing.Size(77, 16);
            this.lbl_sifreTekrar.TabIndex = 2;
            this.lbl_sifreTekrar.Text = "Şifre Tekrar";
            // 
            // txtBox_kullaniciAdiOlustur
            // 
            this.txtBox_kullaniciAdiOlustur.Location = new System.Drawing.Point(202, 47);
            this.txtBox_kullaniciAdiOlustur.Name = "txtBox_kullaniciAdiOlustur";
            this.txtBox_kullaniciAdiOlustur.Size = new System.Drawing.Size(100, 22);
            this.txtBox_kullaniciAdiOlustur.TabIndex = 3;
            // 
            // txtBox_sifreOlustur
            // 
            this.txtBox_sifreOlustur.Location = new System.Drawing.Point(202, 101);
            this.txtBox_sifreOlustur.Name = "txtBox_sifreOlustur";
            this.txtBox_sifreOlustur.Size = new System.Drawing.Size(100, 22);
            this.txtBox_sifreOlustur.TabIndex = 4;
            // 
            // txtBox_sifreTekrar
            // 
            this.txtBox_sifreTekrar.Location = new System.Drawing.Point(202, 163);
            this.txtBox_sifreTekrar.Name = "txtBox_sifreTekrar";
            this.txtBox_sifreTekrar.Size = new System.Drawing.Size(100, 22);
            this.txtBox_sifreTekrar.TabIndex = 5;
            // 
            // btn_hesapOlustur
            // 
            this.btn_hesapOlustur.Location = new System.Drawing.Point(132, 240);
            this.btn_hesapOlustur.Name = "btn_hesapOlustur";
            this.btn_hesapOlustur.Size = new System.Drawing.Size(118, 36);
            this.btn_hesapOlustur.TabIndex = 6;
            this.btn_hesapOlustur.Text = "Hesap Oluştur";
            this.btn_hesapOlustur.UseVisualStyleBackColor = true;
            this.btn_hesapOlustur.Click += new System.EventHandler(this.btn_hesapOlustur_Click);
            // 
            // frm_hesapOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_hesapOlustur);
            this.Controls.Add(this.txtBox_sifreTekrar);
            this.Controls.Add(this.txtBox_sifreOlustur);
            this.Controls.Add(this.txtBox_kullaniciAdiOlustur);
            this.Controls.Add(this.lbl_sifreTekrar);
            this.Controls.Add(this.lbl_sifreOlustur);
            this.Controls.Add(this.lbl_kullaniciAdiOlustur);
            this.Name = "frm_hesapOlustur";
            this.Text = "frm_hesapOlustur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kullaniciAdiOlustur;
        private System.Windows.Forms.Label lbl_sifreOlustur;
        private System.Windows.Forms.Label lbl_sifreTekrar;
        private System.Windows.Forms.TextBox txtBox_kullaniciAdiOlustur;
        private System.Windows.Forms.TextBox txtBox_sifreOlustur;
        private System.Windows.Forms.TextBox txtBox_sifreTekrar;
        private System.Windows.Forms.Button btn_hesapOlustur;
    }
}