namespace LightsOut
{
    partial class AboutForm
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
            this.GameName = new System.Windows.Forms.Label();
            this.AuthorName = new System.Windows.Forms.Label();
            this.Instructions = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.LightBulbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LightBulbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.Font = new System.Drawing.Font("Year supply of fairy cakes", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameName.ForeColor = System.Drawing.Color.Teal;
            this.GameName.Location = new System.Drawing.Point(115, 18);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(140, 32);
            this.GameName.TabIndex = 0;
            this.GameName.Text = "Lights Out!";
            // 
            // AuthorName
            // 
            this.AuthorName.AutoSize = true;
            this.AuthorName.Font = new System.Drawing.Font("X-Files", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorName.Location = new System.Drawing.Point(119, 50);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(102, 12);
            this.AuthorName.TabIndex = 2;
            this.AuthorName.Text = "By Casey Griggs";
            // 
            // Instructions
            // 
            this.Instructions.AutoSize = true;
            this.Instructions.Font = new System.Drawing.Font("X-Files", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructions.Location = new System.Drawing.Point(33, 89);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(251, 12);
            this.Instructions.TabIndex = 3;
            this.Instructions.Text = "Turn all the lights out to win the game!";
            this.Instructions.Click += new System.EventHandler(this.Instructions_Click);
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(117, 114);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // LightBulbImage
            // 
            this.LightBulbImage.Image = global::LightsOut.Properties.Resources.LightBulb3;
            this.LightBulbImage.Location = new System.Drawing.Point(53, 18);
            this.LightBulbImage.Name = "LightBulbImage";
            this.LightBulbImage.Size = new System.Drawing.Size(56, 56);
            this.LightBulbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LightBulbImage.TabIndex = 1;
            this.LightBulbImage.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 161);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(this.LightBulbImage);
            this.Controls.Add(this.GameName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.LightBulbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.PictureBox LightBulbImage;
        private System.Windows.Forms.Label AuthorName;
        private System.Windows.Forms.Label Instructions;
        private System.Windows.Forms.Button OKButton;
    }
}