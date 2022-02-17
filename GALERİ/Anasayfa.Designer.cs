
namespace GALERİ
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.subeler = new System.Windows.Forms.Button();
            this.musteriler = new System.Windows.Forms.Button();
            this.araclar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subeler
            // 
            this.subeler.Location = new System.Drawing.Point(322, 258);
            this.subeler.Name = "subeler";
            this.subeler.Size = new System.Drawing.Size(102, 93);
            this.subeler.TabIndex = 0;
            this.subeler.Text = "subeler";
            this.subeler.UseVisualStyleBackColor = true;
            this.subeler.Click += new System.EventHandler(this.subeler_Click);
            // 
            // musteriler
            // 
            this.musteriler.Location = new System.Drawing.Point(513, 258);
            this.musteriler.Name = "musteriler";
            this.musteriler.Size = new System.Drawing.Size(102, 93);
            this.musteriler.TabIndex = 1;
            this.musteriler.Text = "müşteriler";
            this.musteriler.UseVisualStyleBackColor = true;
            this.musteriler.Click += new System.EventHandler(this.musteriler_Click);
            // 
            // araclar
            // 
            this.araclar.Location = new System.Drawing.Point(717, 258);
            this.araclar.Name = "araclar";
            this.araclar.Size = new System.Drawing.Size(102, 93);
            this.araclar.TabIndex = 2;
            this.araclar.Text = "araçlar";
            this.araclar.UseVisualStyleBackColor = true;
            this.araclar.Click += new System.EventHandler(this.araclar_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1123, 595);
            this.Controls.Add(this.araclar);
            this.Controls.Add(this.musteriler);
            this.Controls.Add(this.subeler);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button subeler;
        private System.Windows.Forms.Button musteriler;
        private System.Windows.Forms.Button araclar;
    }
}