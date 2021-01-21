
namespace kutuphaneOtomasyonu
{
    partial class kitapduzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitapduzenle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbaskiyili = new System.Windows.Forms.TextBox();
            this.dataGridViewkitap = new System.Windows.Forms.DataGridView();
            this.txtkitapid = new System.Windows.Forms.TextBox();
            this.anasayfadön = new System.Windows.Forms.Button();
            this.kitapgüncelle = new System.Windows.Forms.Button();
            this.kitapsil = new System.Windows.Forms.Button();
            this.kitapekle = new System.Windows.Forms.Button();
            this.txtkitapaciklama = new System.Windows.Forms.TextBox();
            this.txtkitapyazari = new System.Windows.Forms.TextBox();
            this.txtkitapadi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.temizle = new System.Windows.Forms.Button();
            this.txtkitapdili = new System.Windows.Forms.TextBox();
            this.txtyayinevi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkitap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtyayinevi);
            this.groupBox1.Controls.Add(this.txtkitapdili);
            this.groupBox1.Controls.Add(this.temizle);
            this.groupBox1.Controls.Add(this.txtbaskiyili);
            this.groupBox1.Controls.Add(this.dataGridViewkitap);
            this.groupBox1.Controls.Add(this.txtkitapid);
            this.groupBox1.Controls.Add(this.anasayfadön);
            this.groupBox1.Controls.Add(this.kitapgüncelle);
            this.groupBox1.Controls.Add(this.kitapsil);
            this.groupBox1.Controls.Add(this.kitapekle);
            this.groupBox1.Controls.Add(this.txtkitapaciklama);
            this.groupBox1.Controls.Add(this.txtkitapyazari);
            this.groupBox1.Controls.Add(this.txtkitapadi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 510);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Düzenle";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtbaskiyili
            // 
            this.txtbaskiyili.Location = new System.Drawing.Point(139, 166);
            this.txtbaskiyili.Name = "txtbaskiyili";
            this.txtbaskiyili.Size = new System.Drawing.Size(152, 23);
            this.txtbaskiyili.TabIndex = 20;
            // 
            // dataGridViewkitap
            // 
            this.dataGridViewkitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewkitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewkitap.Location = new System.Drawing.Point(0, 262);
            this.dataGridViewkitap.Name = "dataGridViewkitap";
            this.dataGridViewkitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewkitap.Size = new System.Drawing.Size(892, 242);
            this.dataGridViewkitap.TabIndex = 19;
            this.dataGridViewkitap.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewkitap_CellEnter);
            // 
            // txtkitapid
            // 
            this.txtkitapid.Enabled = false;
            this.txtkitapid.Location = new System.Drawing.Point(139, 49);
            this.txtkitapid.Name = "txtkitapid";
            this.txtkitapid.Size = new System.Drawing.Size(152, 23);
            this.txtkitapid.TabIndex = 18;
            // 
            // anasayfadön
            // 
            this.anasayfadön.Location = new System.Drawing.Point(773, 207);
            this.anasayfadön.Name = "anasayfadön";
            this.anasayfadön.Size = new System.Drawing.Size(100, 49);
            this.anasayfadön.TabIndex = 17;
            this.anasayfadön.Text = "Ana Sayfaya Dön";
            this.anasayfadön.UseVisualStyleBackColor = true;
            this.anasayfadön.Click += new System.EventHandler(this.anasayfadön_Click);
            // 
            // kitapgüncelle
            // 
            this.kitapgüncelle.Location = new System.Drawing.Point(773, 160);
            this.kitapgüncelle.Name = "kitapgüncelle";
            this.kitapgüncelle.Size = new System.Drawing.Size(100, 41);
            this.kitapgüncelle.TabIndex = 16;
            this.kitapgüncelle.Text = "Güncelle";
            this.kitapgüncelle.UseVisualStyleBackColor = true;
            this.kitapgüncelle.Click += new System.EventHandler(this.kitapgüncelle_Click);
            // 
            // kitapsil
            // 
            this.kitapsil.Location = new System.Drawing.Point(773, 110);
            this.kitapsil.Name = "kitapsil";
            this.kitapsil.Size = new System.Drawing.Size(100, 41);
            this.kitapsil.TabIndex = 15;
            this.kitapsil.Text = "Sil";
            this.kitapsil.UseVisualStyleBackColor = true;
            this.kitapsil.Click += new System.EventHandler(this.kitapsil_Click);
            // 
            // kitapekle
            // 
            this.kitapekle.Location = new System.Drawing.Point(773, 12);
            this.kitapekle.Name = "kitapekle";
            this.kitapekle.Size = new System.Drawing.Size(100, 41);
            this.kitapekle.TabIndex = 14;
            this.kitapekle.Text = "Ekle";
            this.kitapekle.UseVisualStyleBackColor = true;
            this.kitapekle.Click += new System.EventHandler(this.kitapekle_Click);
            // 
            // txtkitapaciklama
            // 
            this.txtkitapaciklama.Location = new System.Drawing.Point(487, 104);
            this.txtkitapaciklama.Multiline = true;
            this.txtkitapaciklama.Name = "txtkitapaciklama";
            this.txtkitapaciklama.Size = new System.Drawing.Size(152, 134);
            this.txtkitapaciklama.TabIndex = 13;
            // 
            // txtkitapyazari
            // 
            this.txtkitapyazari.Location = new System.Drawing.Point(139, 128);
            this.txtkitapyazari.Name = "txtkitapyazari";
            this.txtkitapyazari.Size = new System.Drawing.Size(152, 23);
            this.txtkitapyazari.TabIndex = 9;
            // 
            // txtkitapadi
            // 
            this.txtkitapadi.Location = new System.Drawing.Point(139, 90);
            this.txtkitapadi.Name = "txtkitapadi";
            this.txtkitapadi.Size = new System.Drawing.Size(152, 23);
            this.txtkitapadi.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Açıklama:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kitap yayın evi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kitap dili:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kitap baskı yılı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitap yazarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap id:";
            // 
            // temizle
            // 
            this.temizle.Location = new System.Drawing.Point(773, 59);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(100, 41);
            this.temizle.TabIndex = 21;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = true;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // txtkitapdili
            // 
            this.txtkitapdili.Location = new System.Drawing.Point(139, 207);
            this.txtkitapdili.Name = "txtkitapdili";
            this.txtkitapdili.Size = new System.Drawing.Size(152, 23);
            this.txtkitapdili.TabIndex = 22;
            // 
            // txtyayinevi
            // 
            this.txtyayinevi.Location = new System.Drawing.Point(487, 46);
            this.txtyayinevi.Name = "txtyayinevi";
            this.txtyayinevi.Size = new System.Drawing.Size(152, 23);
            this.txtyayinevi.TabIndex = 23;
            // 
            // kitapduzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(925, 534);
            this.Controls.Add(this.groupBox1);
            this.Name = "kitapduzenle";
            this.Text = "kitapduzenle";
            this.Load += new System.EventHandler(this.kitapduzenle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkitap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button anasayfadön;
        private System.Windows.Forms.Button kitapgüncelle;
        private System.Windows.Forms.Button kitapsil;
        private System.Windows.Forms.Button kitapekle;
        private System.Windows.Forms.TextBox txtkitapaciklama;
        private System.Windows.Forms.TextBox txtkitapyazari;
        private System.Windows.Forms.TextBox txtkitapadi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewkitap;
        private System.Windows.Forms.TextBox txtkitapid;
        private System.Windows.Forms.TextBox txtbaskiyili;
        private System.Windows.Forms.Button temizle;
        private System.Windows.Forms.TextBox txtyayinevi;
        private System.Windows.Forms.TextBox txtkitapdili;
    }
}