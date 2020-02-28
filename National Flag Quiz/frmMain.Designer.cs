namespace National_Flag_Quiz
{
    partial class frmMain
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
            this.lblFlagTarget = new System.Windows.Forms.Label();
            this.pbFlag1 = new System.Windows.Forms.PictureBox();
            this.pbFlag3 = new System.Windows.Forms.PictureBox();
            this.pbFlag2 = new System.Windows.Forms.PictureBox();
            this.pbFlag4 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblWrong = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFlagTarget
            // 
            this.lblFlagTarget.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFlagTarget.Location = new System.Drawing.Point(93, 9);
            this.lblFlagTarget.Name = "lblFlagTarget";
            this.lblFlagTarget.Size = new System.Drawing.Size(428, 48);
            this.lblFlagTarget.TabIndex = 0;
            this.lblFlagTarget.Text = "Country";
            this.lblFlagTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbFlag1
            // 
            this.pbFlag1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFlag1.Location = new System.Drawing.Point(101, 122);
            this.pbFlag1.Margin = new System.Windows.Forms.Padding(10);
            this.pbFlag1.Name = "pbFlag1";
            this.pbFlag1.Size = new System.Drawing.Size(200, 100);
            this.pbFlag1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFlag1.TabIndex = 1;
            this.pbFlag1.TabStop = false;
            this.pbFlag1.Click += new System.EventHandler(this.pbFlag_Click);
            // 
            // pbFlag3
            // 
            this.pbFlag3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFlag3.Location = new System.Drawing.Point(101, 242);
            this.pbFlag3.Margin = new System.Windows.Forms.Padding(10);
            this.pbFlag3.Name = "pbFlag3";
            this.pbFlag3.Size = new System.Drawing.Size(200, 100);
            this.pbFlag3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFlag3.TabIndex = 2;
            this.pbFlag3.TabStop = false;
            this.pbFlag3.Click += new System.EventHandler(this.pbFlag_Click);
            // 
            // pbFlag2
            // 
            this.pbFlag2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFlag2.Location = new System.Drawing.Point(321, 122);
            this.pbFlag2.Margin = new System.Windows.Forms.Padding(10);
            this.pbFlag2.Name = "pbFlag2";
            this.pbFlag2.Size = new System.Drawing.Size(200, 100);
            this.pbFlag2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFlag2.TabIndex = 3;
            this.pbFlag2.TabStop = false;
            this.pbFlag2.Click += new System.EventHandler(this.pbFlag_Click);
            // 
            // pbFlag4
            // 
            this.pbFlag4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFlag4.Location = new System.Drawing.Point(321, 242);
            this.pbFlag4.Margin = new System.Windows.Forms.Padding(10);
            this.pbFlag4.Name = "pbFlag4";
            this.pbFlag4.Size = new System.Drawing.Size(200, 100);
            this.pbFlag4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFlag4.TabIndex = 4;
            this.pbFlag4.TabStop = false;
            this.pbFlag4.Click += new System.EventHandler(this.pbFlag_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblScore.Location = new System.Drawing.Point(12, 49);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(68, 20);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score: 0";
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWrong.Location = new System.Drawing.Point(12, 29);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(73, 20);
            this.lblWrong.TabIndex = 1;
            this.lblWrong.Text = "Wrong: 0";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCorrect.Location = new System.Drawing.Point(12, 9);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(78, 20);
            this.lblCorrect.TabIndex = 0;
            this.lblCorrect.Text = "Correct: 0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(622, 369);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblWrong);
            this.Controls.Add(this.pbFlag4);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.pbFlag2);
            this.Controls.Add(this.pbFlag3);
            this.Controls.Add(this.pbFlag1);
            this.Controls.Add(this.lblFlagTarget);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "National Flag Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFlagTarget;
        private System.Windows.Forms.PictureBox pbFlag1;
        private System.Windows.Forms.PictureBox pbFlag3;
        private System.Windows.Forms.PictureBox pbFlag2;
        private System.Windows.Forms.PictureBox pbFlag4;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblWrong;
        private System.Windows.Forms.Label lblCorrect;
    }
}

