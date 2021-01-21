
namespace kutuphaneOtomasyonu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.kitapduzenle = new System.Windows.Forms.Button();
            this.emanetduzenle = new System.Windows.Forms.Button();
            this.uyeduzenle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kitap.png");
            this.ımageList1.Images.SetKeyName(1, "emanet.jpg");
            this.ımageList1.Images.SetKeyName(2, "üye.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(206, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kütüphane Otomasyonu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // kitapduzenle
            // 
            this.kitapduzenle.BackColor = System.Drawing.Color.Peru;
            this.kitapduzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapduzenle.ImageKey = "kitap.png";
            this.kitapduzenle.ImageList = this.ımageList1;
            this.kitapduzenle.Location = new System.Drawing.Point(90, 159);
            this.kitapduzenle.Name = "kitapduzenle";
            this.kitapduzenle.Size = new System.Drawing.Size(120, 98);
            this.kitapduzenle.TabIndex = 7;
            this.kitapduzenle.Text = "Kitap İşlemleri";
            this.kitapduzenle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kitapduzenle.UseVisualStyleBackColor = false;
            this.kitapduzenle.Click += new System.EventHandler(this.kitapduzenle_Click);
            // 
            // emanetduzenle
            // 
            this.emanetduzenle.BackColor = System.Drawing.Color.Peru;
            this.emanetduzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emanetduzenle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.emanetduzenle.ImageKey = "emanet.jpg";
            this.emanetduzenle.ImageList = this.ımageList1;
            this.emanetduzenle.Location = new System.Drawing.Point(287, 159);
            this.emanetduzenle.Name = "emanetduzenle";
            this.emanetduzenle.Size = new System.Drawing.Size(125, 98);
            this.emanetduzenle.TabIndex = 8;
            this.emanetduzenle.Text = "Emanet İşlemleri";
            this.emanetduzenle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.emanetduzenle.UseVisualStyleBackColor = false;
            this.emanetduzenle.Click += new System.EventHandler(this.button1_Click);
            // 
            // uyeduzenle
            // 
            this.uyeduzenle.BackColor = System.Drawing.Color.Peru;
            this.uyeduzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeduzenle.ImageKey = "üye.png";
            this.uyeduzenle.ImageList = this.ımageList1;
            this.uyeduzenle.Location = new System.Drawing.Point(490, 159);
            this.uyeduzenle.Name = "uyeduzenle";
            this.uyeduzenle.Size = new System.Drawing.Size(125, 98);
            this.uyeduzenle.TabIndex = 9;
            this.uyeduzenle.Text = "Üye İşlemleri";
            this.uyeduzenle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.uyeduzenle.UseVisualStyleBackColor = false;
            this.uyeduzenle.Click += new System.EventHandler(this.uyeduzenle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(744, 376);
            this.Controls.Add(this.uyeduzenle);
            this.Controls.Add(this.emanetduzenle);
            this.Controls.Add(this.kitapduzenle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kitapduzenle;
        private System.Windows.Forms.Button emanetduzenle;
        private System.Windows.Forms.Button uyeduzenle;
    }
}

