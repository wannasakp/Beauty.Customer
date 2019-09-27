namespace Beauty.CustomerPos
{
    partial class Modaldialog
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
            this.lbTextalert = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.picError = new System.Windows.Forms.PictureBox();
            this.picWarning = new System.Windows.Forms.PictureBox();
            this.lbTextalert2 = new System.Windows.Forms.Label();
            this.picError2 = new System.Windows.Forms.PictureBox();
            this.picWarning2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarning2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTextalert
            // 
            this.lbTextalert.AutoSize = true;
            this.lbTextalert.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTextalert.Location = new System.Drawing.Point(122, 91);
            this.lbTextalert.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTextalert.Name = "lbTextalert";
            this.lbTextalert.Size = new System.Drawing.Size(108, 29);
            this.lbTextalert.TabIndex = 0;
            this.lbTextalert.Text = "Textalert";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picWarning2);
            this.panel1.Controls.Add(this.picError2);
            this.panel1.Controls.Add(this.lbTextalert2);
            this.panel1.Controls.Add(this.picError);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.picWarning);
            this.panel1.Controls.Add(this.lbTextalert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 232);
            this.panel1.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnOK.Location = new System.Drawing.Point(64, 189);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(191, 31);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "ตกลง";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // picError
            // 
            this.picError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picError.Image = global::Beauty.CustomerPos.Properties.Resources.error;
            this.picError.Location = new System.Drawing.Point(21, 49);
            this.picError.Name = "picError";
            this.picError.Size = new System.Drawing.Size(105, 101);
            this.picError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picError.TabIndex = 3;
            this.picError.TabStop = false;
            this.picError.Visible = false;
            // 
            // picWarning
            // 
            this.picWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picWarning.Image = global::Beauty.CustomerPos.Properties.Resources.kisspng_emoji_warning_sign_sticker_computer_icons_notice_5ab8c7e19e7b76_4989906015220592336492;
            this.picWarning.Location = new System.Drawing.Point(12, 42);
            this.picWarning.Name = "picWarning";
            this.picWarning.Size = new System.Drawing.Size(114, 106);
            this.picWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWarning.TabIndex = 1;
            this.picWarning.TabStop = false;
            this.picWarning.Visible = false;
            // 
            // lbTextalert2
            // 
            this.lbTextalert2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTextalert2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTextalert2.Location = new System.Drawing.Point(18, 150);
            this.lbTextalert2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTextalert2.Name = "lbTextalert2";
            this.lbTextalert2.Size = new System.Drawing.Size(298, 29);
            this.lbTextalert2.TabIndex = 4;
            this.lbTextalert2.Text = "Textalert";
            this.lbTextalert2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTextalert2.Visible = false;
            // 
            // picError2
            // 
            this.picError2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picError2.Image = global::Beauty.CustomerPos.Properties.Resources.error;
            this.picError2.Location = new System.Drawing.Point(110, 33);
            this.picError2.Name = "picError2";
            this.picError2.Size = new System.Drawing.Size(105, 101);
            this.picError2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picError2.TabIndex = 5;
            this.picError2.TabStop = false;
            this.picError2.Visible = false;
            // 
            // picWarning2
            // 
            this.picWarning2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picWarning2.Image = global::Beauty.CustomerPos.Properties.Resources.kisspng_emoji_warning_sign_sticker_computer_icons_notice_5ab8c7e19e7b76_4989906015220592336492;
            this.picWarning2.Location = new System.Drawing.Point(104, 26);
            this.picWarning2.Name = "picWarning2";
            this.picWarning2.Size = new System.Drawing.Size(114, 106);
            this.picWarning2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWarning2.TabIndex = 6;
            this.picWarning2.TabStop = false;
            this.picWarning2.Visible = false;
            // 
            // Modaldialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 232);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Modaldialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modaldialog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarning2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTextalert;
        private System.Windows.Forms.PictureBox picWarning;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox picError;
        private System.Windows.Forms.Label lbTextalert2;
        private System.Windows.Forms.PictureBox picWarning2;
        private System.Windows.Forms.PictureBox picError2;
    }
}