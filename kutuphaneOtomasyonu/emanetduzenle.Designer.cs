
namespace kutuphaneOtomasyonu
{
    partial class emanetduzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emanetduzenle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.emanettemizle = new System.Windows.Forms.Button();
            this.dataGridViewEmanet = new System.Windows.Forms.DataGridView();
            this.emanetGüncelle = new System.Windows.Forms.Button();
            this.emanetSil = new System.Windows.Forms.Button();
            this.dateTimePickerEmanetGeriAlmaTarih = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickeremanetVermeTarih = new System.Windows.Forms.DateTimePicker();
            this.anaSayfaDon = new System.Windows.Forms.Button();
            this.emanetEkle = new System.Windows.Forms.Button();
            this.txtkitapid = new System.Windows.Forms.TextBox();
            this.txtuyeid = new System.Windows.Forms.TextBox();
            this.txtemanetid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmanet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.emanettemizle);
            this.groupBox1.Controls.Add(this.dataGridViewEmanet);
            this.groupBox1.Controls.Add(this.emanetGüncelle);
            this.groupBox1.Controls.Add(this.emanetSil);
            this.groupBox1.Controls.Add(this.dateTimePickerEmanetGeriAlmaTarih);
            this.groupBox1.Controls.Add(this.dateTimePickeremanetVermeTarih);
            this.groupBox1.Controls.Add(this.anaSayfaDon);
            this.groupBox1.Controls.Add(this.emanetEkle);
            this.groupBox1.Controls.Add(this.txtkitapid);
            this.groupBox1.Controls.Add(this.txtuyeid);
            this.groupBox1.Controls.Add(this.txtemanetid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(27, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 471);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet Düzenle";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // emanettemizle
            // 
            this.emanettemizle.Location = new System.Drawing.Point(408, 127);
            this.emanettemizle.Name = "emanettemizle";
            this.emanettemizle.Size = new System.Drawing.Size(121, 46);
            this.emanettemizle.TabIndex = 18;
            this.emanettemizle.Text = "Temizle";
            this.emanettemizle.UseVisualStyleBackColor = true;
            this.emanettemizle.Click += new System.EventHandler(this.emanettemizle_Click);
            // 
            // dataGridViewEmanet
            // 
            this.dataGridViewEmanet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmanet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmanet.Location = new System.Drawing.Point(0, 189);
            this.dataGridViewEmanet.Name = "dataGridViewEmanet";
            this.dataGridViewEmanet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmanet.Size = new System.Drawing.Size(870, 276);
            this.dataGridViewEmanet.TabIndex = 17;
            this.dataGridViewEmanet.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmanet_CellEnter);
            // 
            // emanetGüncelle
            // 
            this.emanetGüncelle.Location = new System.Drawing.Point(695, 127);
            this.emanetGüncelle.Name = "emanetGüncelle";
            this.emanetGüncelle.Size = new System.Drawing.Size(121, 46);
            this.emanetGüncelle.TabIndex = 16;
            this.emanetGüncelle.Text = "Güncelle";
            this.emanetGüncelle.UseVisualStyleBackColor = true;
            this.emanetGüncelle.Click += new System.EventHandler(this.emanetGüncelle_Click);
            // 
            // emanetSil
            // 
            this.emanetSil.Location = new System.Drawing.Point(547, 127);
            this.emanetSil.Name = "emanetSil";
            this.emanetSil.Size = new System.Drawing.Size(121, 46);
            this.emanetSil.TabIndex = 15;
            this.emanetSil.Text = "Sil";
            this.emanetSil.UseVisualStyleBackColor = true;
            this.emanetSil.Click += new System.EventHandler(this.emanetSil_Click);
            // 
            // dateTimePickerEmanetGeriAlmaTarih
            // 
            this.dateTimePickerEmanetGeriAlmaTarih.Location = new System.Drawing.Point(468, 89);
            this.dateTimePickerEmanetGeriAlmaTarih.Name = "dateTimePickerEmanetGeriAlmaTarih";
            this.dateTimePickerEmanetGeriAlmaTarih.Size = new System.Drawing.Size(122, 23);
            this.dateTimePickerEmanetGeriAlmaTarih.TabIndex = 14;
            // 
            // dateTimePickeremanetVermeTarih
            // 
            this.dateTimePickeremanetVermeTarih.Location = new System.Drawing.Point(468, 55);
            this.dateTimePickeremanetVermeTarih.Name = "dateTimePickeremanetVermeTarih";
            this.dateTimePickeremanetVermeTarih.Size = new System.Drawing.Size(122, 23);
            this.dateTimePickeremanetVermeTarih.TabIndex = 13;
            // 
            // anaSayfaDon
            // 
            this.anaSayfaDon.Location = new System.Drawing.Point(695, 66);
            this.anaSayfaDon.Name = "anaSayfaDon";
            this.anaSayfaDon.Size = new System.Drawing.Size(121, 46);
            this.anaSayfaDon.TabIndex = 12;
            this.anaSayfaDon.Text = "Ana Sayfaya Dön";
            this.anaSayfaDon.UseVisualStyleBackColor = true;
            this.anaSayfaDon.Click += new System.EventHandler(this.anaSayfaDon_Click);
            // 
            // emanetEkle
            // 
            this.emanetEkle.Location = new System.Drawing.Point(269, 127);
            this.emanetEkle.Name = "emanetEkle";
            this.emanetEkle.Size = new System.Drawing.Size(121, 46);
            this.emanetEkle.TabIndex = 10;
            this.emanetEkle.Text = "Ekle";
            this.emanetEkle.UseVisualStyleBackColor = true;
            this.emanetEkle.Click += new System.EventHandler(this.emanetEkle_Click);
            // 
            // txtkitapid
            // 
            this.txtkitapid.Location = new System.Drawing.Point(87, 139);
            this.txtkitapid.Name = "txtkitapid";
            this.txtkitapid.Size = new System.Drawing.Size(167, 23);
            this.txtkitapid.TabIndex = 7;
            // 
            // txtuyeid
            // 
            this.txtuyeid.Location = new System.Drawing.Point(87, 95);
            this.txtuyeid.Name = "txtuyeid";
            this.txtuyeid.Size = new System.Drawing.Size(167, 23);
            this.txtuyeid.TabIndex = 6;
            // 
            // txtemanetid
            // 
            this.txtemanetid.Enabled = false;
            this.txtemanetid.Location = new System.Drawing.Point(87, 49);
            this.txtemanetid.Name = "txtemanetid";
            this.txtemanetid.Size = new System.Drawing.Size(167, 23);
            this.txtemanetid.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Emanet Geri Alma Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Emanet Verme Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitap id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Üye id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emanet id:";
            // 
            // emanetduzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(922, 531);
            this.Controls.Add(this.groupBox1);
            this.Name = "emanetduzenle";
            this.Text = "emanetduzenle";
            this.Load += new System.EventHandler(this.emanetduzenle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmanet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEmanetGeriAlmaTarih;
        private System.Windows.Forms.DateTimePicker dateTimePickeremanetVermeTarih;
        private System.Windows.Forms.Button anaSayfaDon;
        private System.Windows.Forms.Button emanetEkle;
        private System.Windows.Forms.TextBox txtkitapid;
        private System.Windows.Forms.TextBox txtuyeid;
        private System.Windows.Forms.TextBox txtemanetid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button emanetGüncelle;
        private System.Windows.Forms.Button emanetSil;
        private System.Windows.Forms.DataGridView dataGridViewEmanet;
        private System.Windows.Forms.Button emanettemizle;
    }
}