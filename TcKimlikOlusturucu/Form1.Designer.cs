namespace TcKimlikOlusturucu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnuret = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnkopyala = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnuret
            // 
            this.btnuret.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnuret.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnuret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnuret.ForeColor = System.Drawing.Color.Lime;
            this.btnuret.Image = ((System.Drawing.Image)(resources.GetObject("btnuret.Image")));
            this.btnuret.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnuret.Location = new System.Drawing.Point(33, 12);
            this.btnuret.Name = "btnuret";
            this.btnuret.Size = new System.Drawing.Size(232, 41);
            this.btnuret.TabIndex = 0;
            this.btnuret.Text = "Tc Kimlik Oluştur";
            this.btnuret.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnuret.UseVisualStyleBackColor = false;
            this.btnuret.Click += new System.EventHandler(this.btnuret_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(38, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Olusturan Kimlik Numarası";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Lime;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(42, 100);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 28);
            this.textBox1.TabIndex = 2;
            // 
            // btnkopyala
            // 
            this.btnkopyala.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnkopyala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkopyala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkopyala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkopyala.ForeColor = System.Drawing.Color.Lime;
            this.btnkopyala.Image = ((System.Drawing.Image)(resources.GetObject("btnkopyala.Image")));
            this.btnkopyala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkopyala.Location = new System.Drawing.Point(42, 134);
            this.btnkopyala.Name = "btnkopyala";
            this.btnkopyala.Size = new System.Drawing.Size(121, 32);
            this.btnkopyala.TabIndex = 3;
            this.btnkopyala.Text = "Kopyala";
            this.btnkopyala.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkopyala.UseVisualStyleBackColor = false;
            this.btnkopyala.Click += new System.EventHandler(this.btnkopyala_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(295, 193);
            this.Controls.Add(this.btnkopyala);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnuret);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(311, 232);
            this.MinimumSize = new System.Drawing.Size(311, 232);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tc Kimlik Oluşturucu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnuret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnkopyala;
    }
}

