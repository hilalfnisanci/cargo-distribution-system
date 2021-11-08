
using System.Windows.Forms;

namespace yazlab_proje1
{
    partial class Giris_Ekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris_Ekrani));
            this.girisButton = new System.Windows.Forms.Button();
            this.iptalButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.kayitOlButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSifreDegistir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // girisButton
            // 
            this.girisButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(110)))));
            this.girisButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.girisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.girisButton.Location = new System.Drawing.Point(212, 324);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(93, 30);
            this.girisButton.TabIndex = 1;
            this.girisButton.Text = "GİRİŞ";
            this.girisButton.UseVisualStyleBackColor = false;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // iptalButton
            // 
            this.iptalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(110)))));
            this.iptalButton.CausesValidation = false;
            this.iptalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iptalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptalButton.ForeColor = System.Drawing.Color.White;
            this.iptalButton.Location = new System.Drawing.Point(212, 360);
            this.iptalButton.Name = "iptalButton";
            this.iptalButton.Size = new System.Drawing.Size(93, 28);
            this.iptalButton.TabIndex = 2;
            this.iptalButton.Text = "İPTAL";
            this.iptalButton.UseVisualStyleBackColor = false;
            this.iptalButton.Click += new System.EventHandler(this.iptalButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(177, 203);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(159, 20);
            this.usernameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(177, 257);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(159, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Black;
            this.usernameLabel.Location = new System.Drawing.Point(173, 179);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(105, 21);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Kullanıcı Adı:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordLabel.Location = new System.Drawing.Point(173, 233);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(54, 21);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Şifre:";
            // 
            // kayitOlButton
            // 
            this.kayitOlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(110)))));
            this.kayitOlButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kayitOlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitOlButton.ForeColor = System.Drawing.Color.White;
            this.kayitOlButton.Location = new System.Drawing.Point(196, 446);
            this.kayitOlButton.Name = "kayitOlButton";
            this.kayitOlButton.Size = new System.Drawing.Size(125, 30);
            this.kayitOlButton.TabIndex = 7;
            this.kayitOlButton.Text = "KAYIT OL";
            this.kayitOlButton.UseVisualStyleBackColor = false;
            this.kayitOlButton.Click += new System.EventHandler(this.kayitOlButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(164, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "--------------veya--------------";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(110)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 125);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(172, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "KULLANICI GİRİŞİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSifreDegistir
            // 
            this.btnSifreDegistir.FlatAppearance.BorderSize = 0;
            this.btnSifreDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifreDegistir.Location = new System.Drawing.Point(168, 283);
            this.btnSifreDegistir.Name = "btnSifreDegistir";
            this.btnSifreDegistir.Size = new System.Drawing.Size(177, 26);
            this.btnSifreDegistir.TabIndex = 2;
            this.btnSifreDegistir.Text = "Şifre Değiştirmek İçin Tıklayınız";
            this.btnSifreDegistir.UseVisualStyleBackColor = true;
            this.btnSifreDegistir.Click += new System.EventHandler(this.btnSifreDegistir_Click);
            // 
            // Giris_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(520, 500);
            this.Controls.Add(this.btnSifreDegistir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kayitOlButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.iptalButton);
            this.Controls.Add(this.girisButton);
            this.Name = "Giris_Ekrani";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Giris_Ekrani_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button girisButton;
        private System.Windows.Forms.Button iptalButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private Button kayitOlButton;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnSifreDegistir;
    }
}

