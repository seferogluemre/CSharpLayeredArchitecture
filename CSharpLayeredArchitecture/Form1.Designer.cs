namespace CSharpLayeredArchitecture
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.BtnListele = new System.Windows.Forms.Button();
            this.TextId = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoya = new System.Windows.Forms.TextBox();
            this.TxtMaas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSehir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtGörev = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGüncelleme = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnListele
            // 
            this.BtnListele.BackColor = System.Drawing.Color.Turquoise;
            this.BtnListele.ForeColor = System.Drawing.Color.White;
            this.BtnListele.Location = new System.Drawing.Point(712, 24);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(149, 56);
            this.BtnListele.TabIndex = 0;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = false;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.AliceBlue;
            label1.Location = new System.Drawing.Point(54, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 31);
            label1.TabIndex = 1;
            label1.Text = "Id:";
            // 
            // TextId
            // 
            this.TextId.Location = new System.Drawing.Point(101, 30);
            this.TextId.MaxLength = 15;
            this.TextId.Name = "TextId";
            this.TextId.Size = new System.Drawing.Size(212, 38);
            this.TextId.TabIndex = 2;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(101, 86);
            this.TxtAd.MaxLength = 45;
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(212, 38);
            this.TxtAd.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.AliceBlue;
            label2.Location = new System.Drawing.Point(46, 93);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 31);
            label2.TabIndex = 3;
            label2.Text = "Ad:";
            // 
            // TxtSoya
            // 
            this.TxtSoya.Location = new System.Drawing.Point(101, 143);
            this.TxtSoya.MaxLength = 45;
            this.TxtSoya.Name = "TxtSoya";
            this.TxtSoya.Size = new System.Drawing.Size(212, 38);
            this.TxtSoya.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.AliceBlue;
            label3.Location = new System.Drawing.Point(20, 146);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(85, 31);
            label3.TabIndex = 5;
            label3.Text = "Soyad:";
            // 
            // TxtMaas
            // 
            this.TxtMaas.Location = new System.Drawing.Point(448, 143);
            this.TxtMaas.MaxLength = 45;
            this.TxtMaas.Name = "TxtMaas";
            this.TxtMaas.Size = new System.Drawing.Size(209, 38);
            this.TxtMaas.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(367, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Maaş:";
            // 
            // TxtSehir
            // 
            this.TxtSehir.Location = new System.Drawing.Point(448, 86);
            this.TxtSehir.MaxLength = 45;
            this.TxtSehir.Name = "TxtSehir";
            this.TxtSehir.Size = new System.Drawing.Size(209, 38);
            this.TxtSehir.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(368, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Şehir:";
            // 
            // TxtGörev
            // 
            this.TxtGörev.Location = new System.Drawing.Point(448, 30);
            this.TxtGörev.MaxLength = 15;
            this.TxtGörev.Name = "TxtGörev";
            this.TxtGörev.Size = new System.Drawing.Size(209, 38);
            this.TxtGörev.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(359, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "Görev:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 337);
            this.dataGridView1.TabIndex = 13;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Lime;
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(882, 24);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(149, 56);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "Ekleme";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.Crimson;
            this.BtnSil.ForeColor = System.Drawing.Color.White;
            this.BtnSil.Location = new System.Drawing.Point(712, 121);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(149, 56);
            this.BtnSil.TabIndex = 15;
            this.BtnSil.Text = "Silme";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGüncelleme
            // 
            this.BtnGüncelleme.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnGüncelleme.ForeColor = System.Drawing.Color.White;
            this.BtnGüncelleme.Location = new System.Drawing.Point(882, 121);
            this.BtnGüncelleme.Name = "BtnGüncelleme";
            this.BtnGüncelleme.Size = new System.Drawing.Size(149, 56);
            this.BtnGüncelleme.TabIndex = 16;
            this.BtnGüncelleme.Text = "Güncelleme";
            this.BtnGüncelleme.UseVisualStyleBackColor = false;
            this.BtnGüncelleme.Click += new System.EventHandler(this.BtnGüncelleme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(94)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1043, 583);
            this.Controls.Add(this.BtnGüncelleme);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtMaas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSehir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtGörev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtSoya);
            this.Controls.Add(label3);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(label2);
            this.Controls.Add(this.TextId);
            this.Controls.Add(label1);
            this.Controls.Add(this.BtnListele);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Operation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.TextBox TextId;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSoya;
        private System.Windows.Forms.TextBox TxtMaas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSehir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtGörev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGüncelleme;
    }
}

