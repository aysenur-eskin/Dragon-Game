namespace DragonsGame
{
    partial class Level1
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
            this.scoreText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.scoreText.Location = new System.Drawing.Point(12, 711);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(161, 40);
            this.scoreText.TabIndex = 0;
            this.scoreText.Text = "SCORE: 0";
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::DragonsGame.Properties.Resources.background11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1459, 760);
            this.Controls.Add(this.scoreText);
            this.DoubleBuffered = true;
            this.Name = "Level1";
            this.Text = "Level1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreText;
    }
}

