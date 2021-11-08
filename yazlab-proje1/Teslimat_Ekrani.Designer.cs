
namespace yazlab_proje1
{
    partial class Teslimat_Ekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teslimat_Ekrani));
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddressPage = new System.Windows.Forms.Button();
            this.btnDurumPage = new System.Windows.Forms.Button();
            this.adresPaneli = new System.Windows.Forms.Panel();
            this.btnEkle = new System.Windows.Forms.Button();
            this.adresLabel = new System.Windows.Forms.Label();
            this.lng_textBox = new System.Windows.Forms.TextBox();
            this.adSoyadLabel = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.durumPanel = new System.Windows.Forms.Panel();
            this.durum_text = new System.Windows.Forms.TextBox();
            this.adres_text = new System.Windows.Forms.TextBox();
            this.ad_soyad_text = new System.Windows.Forms.TextBox();
            this.Id_text = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lat_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.adresPaneli.SuspendLayout();
            this.durumPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(20, 17);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(585, 326);
            this.map.TabIndex = 2;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.map_Load);
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddressPage
            // 
            this.btnAddressPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddressPage.ForeColor = System.Drawing.Color.White;
            this.btnAddressPage.Location = new System.Drawing.Point(12, 160);
            this.btnAddressPage.Name = "btnAddressPage";
            this.btnAddressPage.Size = new System.Drawing.Size(171, 31);
            this.btnAddressPage.TabIndex = 8;
            this.btnAddressPage.Text = "Teslimat Adres Ekranı";
            this.btnAddressPage.UseVisualStyleBackColor = true;
            this.btnAddressPage.Click += new System.EventHandler(this.btnAddressPage_Click);
            // 
            // btnDurumPage
            // 
            this.btnDurumPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDurumPage.ForeColor = System.Drawing.Color.White;
            this.btnDurumPage.Location = new System.Drawing.Point(12, 219);
            this.btnDurumPage.Name = "btnDurumPage";
            this.btnDurumPage.Size = new System.Drawing.Size(171, 31);
            this.btnDurumPage.TabIndex = 9;
            this.btnDurumPage.Text = "Teslimat Durum Ekranı";
            this.btnDurumPage.UseVisualStyleBackColor = true;
            this.btnDurumPage.Click += new System.EventHandler(this.btnDurumPage_Click);
            // 
            // adresPaneli
            // 
            this.adresPaneli.Controls.Add(this.label2);
            this.adresPaneli.Controls.Add(this.label1);
            this.adresPaneli.Controls.Add(this.lat_textBox);
            this.adresPaneli.Controls.Add(this.btnEkle);
            this.adresPaneli.Controls.Add(this.adresLabel);
            this.adresPaneli.Controls.Add(this.lng_textBox);
            this.adresPaneli.Controls.Add(this.adSoyadLabel);
            this.adresPaneli.Controls.Add(this.txtAdSoyad);
            this.adresPaneli.Controls.Add(this.map);
            this.adresPaneli.Location = new System.Drawing.Point(210, 12);
            this.adresPaneli.Name = "adresPaneli";
            this.adresPaneli.Size = new System.Drawing.Size(621, 455);
            this.adresPaneli.TabIndex = 10;
            this.adresPaneli.Visible = false;
            // 
            // btnEkle
            // 
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(530, 402);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 35);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // adresLabel
            // 
            this.adresLabel.AutoSize = true;
            this.adresLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adresLabel.ForeColor = System.Drawing.Color.White;
            this.adresLabel.Location = new System.Drawing.Point(251, 360);
            this.adresLabel.Name = "adresLabel";
            this.adresLabel.Size = new System.Drawing.Size(160, 19);
            this.adresLabel.TabIndex = 6;
            this.adresLabel.Text = "Lokasyon Bilgisi Giriniz:";
            // 
            // lng_textBox
            // 
            this.lng_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lng_textBox.Location = new System.Drawing.Point(255, 414);
            this.lng_textBox.Multiline = true;
            this.lng_textBox.Name = "lng_textBox";
            this.lng_textBox.Size = new System.Drawing.Size(231, 25);
            this.lng_textBox.TabIndex = 5;
            // 
            // adSoyadLabel
            // 
            this.adSoyadLabel.AutoSize = true;
            this.adSoyadLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adSoyadLabel.ForeColor = System.Drawing.Color.White;
            this.adSoyadLabel.Location = new System.Drawing.Point(16, 360);
            this.adSoyadLabel.Name = "adSoyadLabel";
            this.adSoyadLabel.Size = new System.Drawing.Size(138, 19);
            this.adSoyadLabel.TabIndex = 4;
            this.adSoyadLabel.Text = "Ad - Soyad Giriniz:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(20, 382);
            this.txtAdSoyad.Multiline = true;
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(165, 26);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // durumPanel
            // 
            this.durumPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            this.durumPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.durumPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.durumPanel.Controls.Add(this.label6);
            this.durumPanel.Controls.Add(this.label5);
            this.durumPanel.Controls.Add(this.label4);
            this.durumPanel.Controls.Add(this.label3);
            this.durumPanel.Controls.Add(this.durum_text);
            this.durumPanel.Controls.Add(this.adres_text);
            this.durumPanel.Controls.Add(this.ad_soyad_text);
            this.durumPanel.Controls.Add(this.Id_text);
            this.durumPanel.Controls.Add(this.dataGridView1);
            this.durumPanel.Controls.Add(this.btnUpdate);
            this.durumPanel.Controls.Add(this.btnDelete);
            this.durumPanel.Location = new System.Drawing.Point(200, 1);
            this.durumPanel.Name = "durumPanel";
            this.durumPanel.Size = new System.Drawing.Size(645, 485);
            this.durumPanel.TabIndex = 11;
            this.durumPanel.Visible = false;
            // 
            // durum_text
            // 
            this.durum_text.Location = new System.Drawing.Point(526, 333);
            this.durum_text.Multiline = true;
            this.durum_text.Name = "durum_text";
            this.durum_text.Size = new System.Drawing.Size(100, 28);
            this.durum_text.TabIndex = 8;
            // 
            // adres_text
            // 
            this.adres_text.Location = new System.Drawing.Point(315, 333);
            this.adres_text.Multiline = true;
            this.adres_text.Name = "adres_text";
            this.adres_text.Size = new System.Drawing.Size(205, 28);
            this.adres_text.TabIndex = 7;
            // 
            // ad_soyad_text
            // 
            this.ad_soyad_text.Location = new System.Drawing.Point(128, 333);
            this.ad_soyad_text.Multiline = true;
            this.ad_soyad_text.Name = "ad_soyad_text";
            this.ad_soyad_text.Size = new System.Drawing.Size(184, 28);
            this.ad_soyad_text.TabIndex = 6;
            // 
            // Id_text
            // 
            this.Id_text.Location = new System.Drawing.Point(13, 333);
            this.Id_text.Multiline = true;
            this.Id_text.Name = "Id_text";
            this.Id_text.Size = new System.Drawing.Size(110, 29);
            this.Id_text.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(618, 271);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(110)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(482, 416);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 50);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(110)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(563, 416);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 50);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lat_textBox
            // 
            this.lat_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lat_textBox.Location = new System.Drawing.Point(255, 382);
            this.lat_textBox.Multiline = true;
            this.lat_textBox.Name = "lat_textBox";
            this.lat_textBox.Size = new System.Drawing.Size(231, 26);
            this.lat_textBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(214, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(214, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(125, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ad-Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(312, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lokasyon Bilgisi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(525, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Durum:";
            // 
            // Teslimat_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(843, 479);
            this.Controls.Add(this.durumPanel);
            this.Controls.Add(this.adresPaneli);
            this.Controls.Add(this.btnDurumPage);
            this.Controls.Add(this.btnAddressPage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Teslimat_Ekrani";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Teslimat_Ekrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.adresPaneli.ResumeLayout(false);
            this.adresPaneli.PerformLayout();
            this.durumPanel.ResumeLayout(false);
            this.durumPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddressPage;
        private System.Windows.Forms.Button btnDurumPage;
        private System.Windows.Forms.Panel adresPaneli;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label adresLabel;
        private System.Windows.Forms.TextBox lng_textBox;
        private System.Windows.Forms.Label adSoyadLabel;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Panel durumPanel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox durum_text;
        private System.Windows.Forms.TextBox adres_text;
        private System.Windows.Forms.TextBox ad_soyad_text;
        private System.Windows.Forms.TextBox Id_text;
        private System.Windows.Forms.TextBox lat_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}