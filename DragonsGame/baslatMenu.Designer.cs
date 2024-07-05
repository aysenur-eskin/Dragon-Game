namespace DragonsGame
{
    partial class baslatMenu
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
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startButton.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startButton.Location = new System.Drawing.Point(589, 555);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(288, 67);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "OYNA";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Constantia", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(188, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1043, 146);
            this.label1.TabIndex = 1;
            this.label1.Text = "DRAGON GAMES";
            // 
            // baslatMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::DragonsGame.Properties.Resources.Untitled_Project__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1471, 770);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.DoubleBuffered = true;
            this.Name = "baslatMenu";
            this.Text = "baslatMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
    }
}