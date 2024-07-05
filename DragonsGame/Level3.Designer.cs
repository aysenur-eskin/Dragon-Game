namespace DragonsGame
{
    partial class Level3
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
            this.scoreText.Location = new System.Drawing.Point(12, 760);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(161, 40);
            this.scoreText.TabIndex = 0;
            this.scoreText.Text = "SCORE: 0";
            // 
            // Level3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::DragonsGame.Properties.Resources.screenshot_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1391, 809);
            this.Controls.Add(this.scoreText);
            this.DoubleBuffered = true;
            this.Name = "Level3";
            this.Text = "Level3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreText;
    }
}