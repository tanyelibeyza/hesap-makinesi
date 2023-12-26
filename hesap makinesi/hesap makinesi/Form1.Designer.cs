namespace hesap_makinesi
{
    partial class Form1
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
            this.txtsayi1 = new System.Windows.Forms.Label();
            this.txtsayi2 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.BtnÇıkarma = new System.Windows.Forms.Button();
            this.btnÇarp = new System.Windows.Forms.Button();
            this.btnBölme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsayi1
            // 
            this.txtsayi1.AutoSize = true;
            this.txtsayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsayi1.Location = new System.Drawing.Point(109, 63);
            this.txtsayi1.Name = "txtsayi1";
            this.txtsayi1.Size = new System.Drawing.Size(44, 16);
            this.txtsayi1.TabIndex = 0;
            this.txtsayi1.Text = "sayı1";
            // 
            // txtsayi2
            // 
            this.txtsayi2.AutoSize = true;
            this.txtsayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsayi2.Location = new System.Drawing.Point(109, 102);
            this.txtsayi2.Name = "txtsayi2";
            this.txtsayi2.Size = new System.Drawing.Size(44, 16);
            this.txtsayi2.TabIndex = 1;
            this.txtsayi2.Text = "sayı2";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(112, 165);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(48, 16);
            this.lblSonuc.TabIndex = 2;
            this.lblSonuc.Text = "sonuc";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // btnTopla
            // 
            this.btnTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTopla.Location = new System.Drawing.Point(336, 55);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(75, 28);
            this.btnTopla.TabIndex = 5;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // BtnÇıkarma
            // 
            this.BtnÇıkarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnÇıkarma.Location = new System.Drawing.Point(464, 55);
            this.BtnÇıkarma.Name = "BtnÇıkarma";
            this.BtnÇıkarma.Size = new System.Drawing.Size(84, 23);
            this.BtnÇıkarma.TabIndex = 6;
            this.BtnÇıkarma.Text = "Çıkartma";
            this.BtnÇıkarma.UseVisualStyleBackColor = true;
            this.BtnÇıkarma.Click += new System.EventHandler(this.BtnÇıkarma_Click);
            // 
            // btnÇarp
            // 
            this.btnÇarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÇarp.Location = new System.Drawing.Point(336, 95);
            this.btnÇarp.Name = "btnÇarp";
            this.btnÇarp.Size = new System.Drawing.Size(75, 23);
            this.btnÇarp.TabIndex = 7;
            this.btnÇarp.Text = "Çarp";
            this.btnÇarp.UseVisualStyleBackColor = true;
            // 
            // btnBölme
            // 
            this.btnBölme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBölme.Location = new System.Drawing.Point(464, 95);
            this.btnBölme.Name = "btnBölme";
            this.btnBölme.Size = new System.Drawing.Size(75, 23);
            this.btnBölme.TabIndex = 8;
            this.btnBölme.Text = "Bölme";
            this.btnBölme.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBölme);
            this.Controls.Add(this.btnÇarp);
            this.Controls.Add(this.BtnÇıkarma);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtsayi2);
            this.Controls.Add(this.txtsayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtsayi1;
        private System.Windows.Forms.Label txtsayi2;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button BtnÇıkarma;
        private System.Windows.Forms.Button btnÇarp;
        private System.Windows.Forms.Button btnBölme;
    }
}

