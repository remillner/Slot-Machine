namespace Slot_Machine
{
    partial class GlitterKitty
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.reel1 = new System.Windows.Forms.PictureBox();
            this.reel3 = new System.Windows.Forms.PictureBox();
            this.reel2 = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblPlayPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reel2)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Image = global::Slot_Machine.Properties.Resources.Glitter_Logo1;
            this.picLogo.Location = new System.Drawing.Point(248, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(518, 147);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // reel1
            // 
            this.reel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reel1.Image = global::Slot_Machine.Properties.Resources._3pizzacat;
            this.reel1.Location = new System.Drawing.Point(118, 179);
            this.reel1.Name = "reel1";
            this.reel1.Size = new System.Drawing.Size(259, 234);
            this.reel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reel1.TabIndex = 1;
            this.reel1.TabStop = false;
            // 
            // reel3
            // 
            this.reel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reel3.Image = global::Slot_Machine.Properties.Resources._5tonguecat;
            this.reel3.Location = new System.Drawing.Point(671, 179);
            this.reel3.Name = "reel3";
            this.reel3.Size = new System.Drawing.Size(259, 234);
            this.reel3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reel3.TabIndex = 2;
            this.reel3.TabStop = false;
            // 
            // reel2
            // 
            this.reel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reel2.Image = global::Slot_Machine.Properties.Resources._2grumpycat2;
            this.reel2.Location = new System.Drawing.Point(393, 179);
            this.reel2.Name = "reel2";
            this.reel2.Size = new System.Drawing.Size(259, 234);
            this.reel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reel2.TabIndex = 3;
            this.reel2.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::Slot_Machine.Properties.Resources.Paws;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Black;
            this.btnPlay.Location = new System.Drawing.Point(871, 61);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(94, 87);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("High Tower Text", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.Location = new System.Drawing.Point(285, 455);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(499, 62);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Results!";
            // 
            // lblPoints
            // 
            this.lblPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPoints.Font = new System.Drawing.Font("High Tower Text", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPoints.Location = new System.Drawing.Point(42, 72);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(181, 23);
            this.lblPoints.TabIndex = 6;
            this.lblPoints.Text = "Points: 200";
            // 
            // lblPlayPoints
            // 
            this.lblPlayPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayPoints.Font = new System.Drawing.Font("High Tower Text", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayPoints.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayPoints.Location = new System.Drawing.Point(803, 22);
            this.lblPlayPoints.Name = "lblPlayPoints";
            this.lblPlayPoints.Size = new System.Drawing.Size(208, 36);
            this.lblPlayPoints.TabIndex = 7;
            this.lblPlayPoints.Text = "Points to Play: 10";
            // 
            // GlitterKitty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Slot_Machine.Properties.Resources.Purplecurtain;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 551);
            this.Controls.Add(this.lblPlayPoints);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.reel2);
            this.Controls.Add(this.reel3);
            this.Controls.Add(this.reel1);
            this.Controls.Add(this.picLogo);
            this.Name = "GlitterKitty";
            this.Text = "Slot Machine - Rebecca Millner";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reel2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox reel1;
        private System.Windows.Forms.PictureBox reel3;
        private System.Windows.Forms.PictureBox reel2;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblPlayPoints;
    }
}

