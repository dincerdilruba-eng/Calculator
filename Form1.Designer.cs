namespace HesapMakinesi
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
            this.ekranLabel = new System.Windows.Forms.Label();
            this.rakam1Button = new System.Windows.Forms.Button();
            this.rakam2Button = new System.Windows.Forms.Button();
            this.rakam3Button = new System.Windows.Forms.Button();
            this.rakam6Button = new System.Windows.Forms.Button();
            this.rakam5Button = new System.Windows.Forms.Button();
            this.rakam4Button = new System.Windows.Forms.Button();
            this.rakam9Button = new System.Windows.Forms.Button();
            this.rakam8Button = new System.Windows.Forms.Button();
            this.rakam7Button = new System.Windows.Forms.Button();
            this.esittirButton = new System.Windows.Forms.Button();
            this.rakam0Button = new System.Windows.Forms.Button();
            this.temizleButton = new System.Windows.Forms.Button();
            this.boluButton = new System.Windows.Forms.Button();
            this.carpiButton = new System.Windows.Forms.Button();
            this.cikarButton = new System.Windows.Forms.Button();
            this.toplaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.ekranLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ekranLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekranLabel.Location = new System.Drawing.Point(12, 9);
            this.ekranLabel.Name = "ekranLabel";
            this.ekranLabel.Size = new System.Drawing.Size(318, 66);
            this.ekranLabel.TabIndex = 0;
            this.ekranLabel.Text = "0";
            this.ekranLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rakam1Button
            // 
            this.rakam1Button.BackColor = System.Drawing.Color.RosyBrown;
            this.rakam1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam1Button.Location = new System.Drawing.Point(12, 92);
            this.rakam1Button.Name = "rakam1Button";
            this.rakam1Button.Size = new System.Drawing.Size(75, 75);
            this.rakam1Button.TabIndex = 1;
            this.rakam1Button.Text = "1";
            this.rakam1Button.UseVisualStyleBackColor = false;
            this.rakam1Button.Click += new System.EventHandler(this.RakamButton_Click);
            // 
            // rakam2Button
            // 
            this.rakam2Button.BackColor = System.Drawing.Color.RosyBrown;
            this.rakam2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam2Button.Location = new System.Drawing.Point(93, 92);
            this.rakam2Button.Name = "rakam2Button";
            this.rakam2Button.Size = new System.Drawing.Size(75, 75);
            this.rakam2Button.TabIndex = 2;
            this.rakam2Button.Text = "2";
            this.rakam2Button.UseVisualStyleBackColor = false;
            this.rakam2Button.Click += new System.EventHandler(this.RakamButton_Click);
            // 
            // rakam3Button
            // 
            this.rakam3Button.BackColor = System.Drawing.Color.RosyBrown;
            this.rakam3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam3Button.Location = new System.Drawing.Point(174, 92);
            this.rakam3Button.Name = "rakam3Button";
            this.rakam3Button.Size = new System.Drawing.Size(75, 75);
            this.rakam3Button.TabIndex = 3;
            this.rakam3Button.Text = "3";
            this.rakam3Button.UseVisualStyleBackColor = false;
            this.rakam3Button.Click += new System.EventHandler(this.RakamButton_Click);
            // 
            // rakam6Button
            // 
            this.rakam6Button.BackColor = System.Drawing.Color.RosyBrown;
            this.rakam6Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam6Button.Location = new System.Drawing.Point(174, 173);
            this.rakam6Button.Name = "rakam6Button";
            this.rakam6Button.Size = new System.Drawing.Size(75, 75);
            this.rakam6Button.TabIndex = 6;
            this.rakam6Button.Text = "6";
            this.rakam6Button.UseVisualStyleBackColor = false;
            this.rakam6Button.Click += new System.EventHandler(this.RakamButton_Click);
            // 
            // rakam5Button
            // 
            this.rakam5Button.BackColor = System.Drawing.Color.RosyBrown;
            this.rakam5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam5Button.Location = new System.Drawing.Point(93, 173);
            this.rakam5Button.Name = "rakam5Button";
            this.rakam5Button.Size = new System.Drawing.Size(75, 75);
            this.rakam5Button.TabIndex = 5;
            this.rakam5Button.Text = "5";
            this.rakam5Button.UseVisualStyleBackColor = false;
            this.rakam5Button.Click += new System.EventHandler(this.RakamButton_Click);
            // 
            // rakam4Button
            // 
            this.rakam4Button.BackColor = System.Drawing.Color.RosyBrown;
            this.rakam4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam4Button.Location = new System.Drawing.Point(12, 173);
            this.rakam4Button.Name = "rakam4Button";
            this.rakam4Button.Size = new System.Drawing.Size(75, 75);
            this.rakam4Button.TabIndex = 4;
            this.rakam4Button.Text = "4";
            this.rakam4Button.UseVisualStyleBackColor = false;
            this.rakam4Button.Click += new System.EventHandler(this.RakamButton_Click);
            // 
            // rakam9Button
            // 
            this.rakam9Button.BackColor = System.Drawing.Color.RosyBrown;
            this.rakam9Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam9Button.Location = new System.Drawing.Point(174, 254);
            this.rakam9Button.Name = "rakam9Button";
            this.rakam9Button.Size = new System.Drawing.Size(75, 75);
            this.rakam9Button.TabIndex = 9;
            this.rakam9Button.Text = "9";
            this.rakam9Button.UseVisualStyleBackColor = false;
            this.rakam9Button.Click += new System.EventHandler(this.RakamButton_Click);
            // 
            // rakam8Button
            // 
            this.rakam8Button.BackColor = System.Drawing.Color.RosyBrown;
            this.rakam8Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam8Button.Location = new System.Drawing.Point(93, 254);
            this.rakam8Button.Name = "rakam8Button";
            this.rakam8Button.Size = new System.Drawing.Size(75, 75);
            this.rakam8Button.TabIndex = 8;
            this.rakam8Button.Text = "8";
            this.rakam8Button.UseVisualStyleBackColor = false;
            this.rakam8Button.Click += new System.EventHandler(this.RakamButton_Click);
            // 
            // rakam7Button
            // 
            this.rakam7Button.BackColor = System.Drawing.Color.RosyBrown;
            this.rakam7Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam7Button.Location = new System.Drawing.Point(12, 254);
            this.rakam7Button.Name = "rakam7Button";
            this.rakam7Button.Size = new System.Drawing.Size(75, 75);
            this.rakam7Button.TabIndex = 7;
            this.rakam7Button.Text = "7";
            this.rakam7Button.UseVisualStyleBackColor = false;
            this.rakam7Button.Click += new System.EventHandler(this.RakamButton_Click);
            // 
            // esittirButton
            // 
            this.esittirButton.BackColor = System.Drawing.Color.Bisque;
            this.esittirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.esittirButton.Location = new System.Drawing.Point(174, 335);
            this.esittirButton.Name = "esittirButton";
            this.esittirButton.Size = new System.Drawing.Size(75, 75);
            this.esittirButton.TabIndex = 12;
            this.esittirButton.Text = "=";
            this.esittirButton.UseVisualStyleBackColor = false;
            this.esittirButton.Click += new System.EventHandler(this.esittirButton_Click);
            // 
            // rakam0Button
            // 
            this.rakam0Button.BackColor = System.Drawing.Color.RosyBrown;
            this.rakam0Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam0Button.Location = new System.Drawing.Point(93, 335);
            this.rakam0Button.Name = "rakam0Button";
            this.rakam0Button.Size = new System.Drawing.Size(75, 75);
            this.rakam0Button.TabIndex = 11;
            this.rakam0Button.Text = "0";
            this.rakam0Button.UseVisualStyleBackColor = false;
            this.rakam0Button.Click += new System.EventHandler(this.RakamButton_Click);
            // 
            // temizleButton
            // 
            this.temizleButton.BackColor = System.Drawing.Color.Bisque;
            this.temizleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizleButton.Location = new System.Drawing.Point(12, 335);
            this.temizleButton.Name = "temizleButton";
            this.temizleButton.Size = new System.Drawing.Size(75, 75);
            this.temizleButton.TabIndex = 10;
            this.temizleButton.Text = "C";
            this.temizleButton.UseVisualStyleBackColor = false;
            this.temizleButton.Click += new System.EventHandler(this.temizleButton_Click);
            // 
            // boluButton
            // 
            this.boluButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.boluButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boluButton.Location = new System.Drawing.Point(255, 335);
            this.boluButton.Name = "boluButton";
            this.boluButton.Size = new System.Drawing.Size(75, 75);
            this.boluButton.TabIndex = 16;
            this.boluButton.Text = "/";
            this.boluButton.UseVisualStyleBackColor = false;
            this.boluButton.Click += new System.EventHandler(this.islemButton_Click);
            // 
            // carpiButton
            // 
            this.carpiButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.carpiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carpiButton.Location = new System.Drawing.Point(255, 254);
            this.carpiButton.Name = "carpiButton";
            this.carpiButton.Size = new System.Drawing.Size(75, 75);
            this.carpiButton.TabIndex = 15;
            this.carpiButton.Text = "X";
            this.carpiButton.UseVisualStyleBackColor = false;
            this.carpiButton.Click += new System.EventHandler(this.islemButton_Click);
            // 
            // cikarButton
            // 
            this.cikarButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cikarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikarButton.Location = new System.Drawing.Point(255, 173);
            this.cikarButton.Name = "cikarButton";
            this.cikarButton.Size = new System.Drawing.Size(75, 75);
            this.cikarButton.TabIndex = 14;
            this.cikarButton.Text = "-";
            this.cikarButton.UseVisualStyleBackColor = false;
            this.cikarButton.Click += new System.EventHandler(this.islemButton_Click);
            // 
            // toplaButton
            // 
            this.toplaButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toplaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplaButton.Location = new System.Drawing.Point(255, 92);
            this.toplaButton.Name = "toplaButton";
            this.toplaButton.Size = new System.Drawing.Size(75, 75);
            this.toplaButton.TabIndex = 13;
            this.toplaButton.Text = "+";
            this.toplaButton.UseVisualStyleBackColor = false;
            this.toplaButton.Click += new System.EventHandler(this.toplaButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(339, 416);
            this.Controls.Add(this.boluButton);
            this.Controls.Add(this.carpiButton);
            this.Controls.Add(this.cikarButton);
            this.Controls.Add(this.toplaButton);
            this.Controls.Add(this.esittirButton);
            this.Controls.Add(this.rakam0Button);
            this.Controls.Add(this.temizleButton);
            this.Controls.Add(this.rakam9Button);
            this.Controls.Add(this.rakam8Button);
            this.Controls.Add(this.rakam7Button);
            this.Controls.Add(this.rakam6Button);
            this.Controls.Add(this.rakam5Button);
            this.Controls.Add(this.rakam4Button);
            this.Controls.Add(this.rakam3Button);
            this.Controls.Add(this.rakam2Button);
            this.Controls.Add(this.rakam1Button);
            this.Controls.Add(this.ekranLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HESAP MAKİNESİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ekranLabel;
        private System.Windows.Forms.Button rakam1Button;
        private System.Windows.Forms.Button rakam2Button;
        private System.Windows.Forms.Button rakam3Button;
        private System.Windows.Forms.Button rakam6Button;
        private System.Windows.Forms.Button rakam5Button;
        private System.Windows.Forms.Button rakam4Button;
        private System.Windows.Forms.Button rakam9Button;
        private System.Windows.Forms.Button rakam8Button;
        private System.Windows.Forms.Button rakam7Button;
        private System.Windows.Forms.Button esittirButton;
        private System.Windows.Forms.Button rakam0Button;
        private System.Windows.Forms.Button temizleButton;
        private System.Windows.Forms.Button boluButton;
        private System.Windows.Forms.Button carpiButton;
        private System.Windows.Forms.Button cikarButton;
        private System.Windows.Forms.Button toplaButton;
    }
}

