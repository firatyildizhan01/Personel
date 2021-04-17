
namespace Personel
{
    partial class formGiriş
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
            this.btnGiriş = new System.Windows.Forms.Button();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.txtKullanıcı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGiriş
            // 
            this.btnGiriş.Location = new System.Drawing.Point(144, 159);
            this.btnGiriş.Name = "btnGiriş";
            this.btnGiriş.Size = new System.Drawing.Size(75, 23);
            this.btnGiriş.TabIndex = 0;
            this.btnGiriş.Text = "Giriş";
            this.btnGiriş.UseVisualStyleBackColor = true;
            this.btnGiriş.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtŞifre
            // 
            this.txtŞifre.Location = new System.Drawing.Point(131, 124);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.Size = new System.Drawing.Size(100, 20);
            this.txtŞifre.TabIndex = 1;
            this.txtŞifre.UseSystemPasswordChar = true;
            // 
            // txtKullanıcı
            // 
            this.txtKullanıcı.Location = new System.Drawing.Point(131, 89);
            this.txtKullanıcı.Name = "txtKullanıcı";
            this.txtKullanıcı.Size = new System.Drawing.Size(100, 20);
            this.txtKullanıcı.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel Takip Sistemi Giriş";
            // 
            // formGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(336, 216);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKullanıcı);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.btnGiriş);
            this.Name = "formGiriş";
            this.Text = "formGiriş";
            this.Load += new System.EventHandler(this.formGiriş_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiriş;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.TextBox txtKullanıcı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}