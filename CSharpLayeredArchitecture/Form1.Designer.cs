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
            this.BtnListele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPersonId = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnListele
            // 
            this.BtnListele.BackColor = System.Drawing.Color.Turquoise;
            this.BtnListele.Location = new System.Drawing.Point(703, 16);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(149, 52);
            this.BtnListele.TabIndex = 0;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = false;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // TxtPersonId
            // 
            this.TxtPersonId.Location = new System.Drawing.Point(101, 30);
            this.TxtPersonId.MaxLength = 15;
            this.TxtPersonId.Name = "TxtPersonId";
            this.TxtPersonId.Size = new System.Drawing.Size(212, 38);
            this.TxtPersonId.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 86);
            this.textBox1.MaxLength = 45;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 38);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 143);
            this.textBox2.MaxLength = 45;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 38);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyad:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(448, 147);
            this.textBox3.MaxLength = 45;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 38);
            this.textBox3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Soyad:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(448, 90);
            this.textBox4.MaxLength = 45;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(209, 38);
            this.textBox4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Şehir:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(448, 34);
            this.textBox5.MaxLength = 15;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(209, 38);
            this.textBox5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "Görev:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(852, 314);
            this.dataGridView1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(877, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPersonId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnListele);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPersonId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

