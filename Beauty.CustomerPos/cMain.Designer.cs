namespace Beauty.CustomerPos
{
    partial class cMain
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
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsvListitem = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbdCardlv = new System.Windows.Forms.Label();
            this.lbcardlv = new System.Windows.Forms.Label();
            this.lbdtel = new System.Windows.Forms.Label();
            this.lbdFullname = new System.Windows.Forms.Label();
            this.lbd_cardid = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbCardID = new System.Windows.Forms.Label();
            this.lklEditcustomer = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearchCard = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnForeigner = new System.Windows.Forms.Button();
            this.btnNmember = new System.Windows.Forms.Button();
            this.btnCO = new System.Windows.Forms.Button();
            this.lbdCopro = new System.Windows.Forms.Label();
            this.lbCopro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSearchType
            // 
            this.cbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSearchType.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Location = new System.Drawing.Point(29, 25);
            this.cbSearchType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(264, 36);
            this.cbSearchType.TabIndex = 0;
            this.cbSearchType.SelectedIndexChanged += new System.EventHandler(this.CbSearchType_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lsvListitem);
            this.panel1.Controls.Add(this.lbdCardlv);
            this.panel1.Controls.Add(this.lbcardlv);
            this.panel1.Controls.Add(this.lbdtel);
            this.panel1.Controls.Add(this.lbdFullname);
            this.panel1.Controls.Add(this.lbd_cardid);
            this.panel1.Controls.Add(this.lbTel);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.lbCardID);
            this.panel1.Controls.Add(this.lklEditcustomer);
            this.panel1.Controls.Add(this.lbdCopro);
            this.panel1.Controls.Add(this.lbCopro);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.panel1.Location = new System.Drawing.Point(338, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 351);
            this.panel1.TabIndex = 1;
            // 
            // lsvListitem
            // 
            this.lsvListitem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lsvListitem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvListitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lsvListitem.FullRowSelect = true;
            this.lsvListitem.GridLines = true;
            this.lsvListitem.HideSelection = false;
            this.lsvListitem.Location = new System.Drawing.Point(0, 0);
            this.lsvListitem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lsvListitem.Name = "lsvListitem";
            this.lsvListitem.Size = new System.Drawing.Size(470, 351);
            this.lsvListitem.TabIndex = 9;
            this.lsvListitem.UseCompatibleStateImageBehavior = false;
            this.lsvListitem.View = System.Windows.Forms.View.Details;
            this.lsvListitem.Visible = false;
            this.lsvListitem.DoubleClick += new System.EventHandler(this.LsvListitem_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "รหัสสมาชิก";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ชื่อลูกค้า";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "โทรศัพท์";
            this.columnHeader2.Width = 228;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CARDLV";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            // 
            // lbdCardlv
            // 
            this.lbdCardlv.AutoSize = true;
            this.lbdCardlv.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbdCardlv.Location = new System.Drawing.Point(161, 58);
            this.lbdCardlv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdCardlv.Name = "lbdCardlv";
            this.lbdCardlv.Size = new System.Drawing.Size(17, 23);
            this.lbdCardlv.TabIndex = 8;
            this.lbdCardlv.Text = "-";
            // 
            // lbcardlv
            // 
            this.lbcardlv.AutoSize = true;
            this.lbcardlv.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbcardlv.Location = new System.Drawing.Point(15, 58);
            this.lbcardlv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcardlv.Name = "lbcardlv";
            this.lbcardlv.Size = new System.Drawing.Size(119, 23);
            this.lbcardlv.TabIndex = 7;
            this.lbcardlv.Text = "ระดับสมาชิก :";
            // 
            // lbdtel
            // 
            this.lbdtel.AutoSize = true;
            this.lbdtel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbdtel.Location = new System.Drawing.Point(160, 116);
            this.lbdtel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdtel.Name = "lbdtel";
            this.lbdtel.Size = new System.Drawing.Size(17, 23);
            this.lbdtel.TabIndex = 6;
            this.lbdtel.Text = "-";
            // 
            // lbdFullname
            // 
            this.lbdFullname.AutoSize = true;
            this.lbdFullname.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbdFullname.Location = new System.Drawing.Point(160, 86);
            this.lbdFullname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdFullname.Name = "lbdFullname";
            this.lbdFullname.Size = new System.Drawing.Size(17, 23);
            this.lbdFullname.TabIndex = 5;
            this.lbdFullname.Text = "-";
            // 
            // lbd_cardid
            // 
            this.lbd_cardid.AutoSize = true;
            this.lbd_cardid.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbd_cardid.Location = new System.Drawing.Point(160, 28);
            this.lbd_cardid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbd_cardid.Name = "lbd_cardid";
            this.lbd_cardid.Size = new System.Drawing.Size(17, 23);
            this.lbd_cardid.TabIndex = 4;
            this.lbd_cardid.Text = "-";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTel.Location = new System.Drawing.Point(37, 116);
            this.lbTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(93, 23);
            this.lbTel.TabIndex = 2;
            this.lbTel.Text = "โทรศัพท์ :";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbName.Location = new System.Drawing.Point(12, 86);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(120, 23);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "ชื่อ-นามสกุล :";
            // 
            // lbCardID
            // 
            this.lbCardID.AutoSize = true;
            this.lbCardID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbCardID.Location = new System.Drawing.Point(24, 27);
            this.lbCardID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCardID.Name = "lbCardID";
            this.lbCardID.Size = new System.Drawing.Size(110, 23);
            this.lbCardID.TabIndex = 0;
            this.lbCardID.Text = "บัตรสมาชิก :";
            // 
            // lklEditcustomer
            // 
            this.lklEditcustomer.AutoSize = true;
            this.lklEditcustomer.Location = new System.Drawing.Point(37, 173);
            this.lklEditcustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lklEditcustomer.Name = "lklEditcustomer";
            this.lklEditcustomer.Size = new System.Drawing.Size(144, 23);
            this.lklEditcustomer.TabIndex = 10;
            this.lklEditcustomer.TabStop = true;
            this.lklEditcustomer.Text = "แก้ไขข้อมูลลูกค้า";
            this.lklEditcustomer.Visible = false;
            this.lklEditcustomer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LklEditcustomer_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.txtSearchCard);
            this.panel2.Controls.Add(this.cbSearchType);
            this.panel2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.panel2.Location = new System.Drawing.Point(7, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 351);
            this.panel2.TabIndex = 2;
            // 
            // txtSearchCard
            // 
            this.txtSearchCard.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchCard.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSearchCard.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSearchCard.Location = new System.Drawing.Point(29, 68);
            this.txtSearchCard.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchCard.Name = "txtSearchCard";
            this.txtSearchCard.Size = new System.Drawing.Size(264, 35);
            this.txtSearchCard.TabIndex = 3;
            this.txtSearchCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearchCard_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.btnCO);
            this.panel3.Controls.Add(this.btnForeigner);
            this.panel3.Controls.Add(this.btnNmember);
            this.panel3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.panel3.Location = new System.Drawing.Point(7, 362);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 98);
            this.panel3.TabIndex = 3;
            // 
            // btnForeigner
            // 
            this.btnForeigner.Location = new System.Drawing.Point(331, 25);
            this.btnForeigner.Margin = new System.Windows.Forms.Padding(4);
            this.btnForeigner.Name = "btnForeigner";
            this.btnForeigner.Size = new System.Drawing.Size(176, 47);
            this.btnForeigner.TabIndex = 1;
            this.btnForeigner.Text = "ชาวต่างชาติ";
            this.btnForeigner.UseVisualStyleBackColor = true;
            this.btnForeigner.Click += new System.EventHandler(this.BtnForeigner_Click);
            // 
            // btnNmember
            // 
            this.btnNmember.Location = new System.Drawing.Point(130, 25);
            this.btnNmember.Margin = new System.Windows.Forms.Padding(4);
            this.btnNmember.Name = "btnNmember";
            this.btnNmember.Size = new System.Drawing.Size(176, 47);
            this.btnNmember.TabIndex = 0;
            this.btnNmember.Text = "ขาจร";
            this.btnNmember.UseVisualStyleBackColor = true;
            this.btnNmember.Click += new System.EventHandler(this.BtnNmember_Click);
            // 
            // btnCO
            // 
            this.btnCO.Location = new System.Drawing.Point(534, 25);
            this.btnCO.Margin = new System.Windows.Forms.Padding(4);
            this.btnCO.Name = "btnCO";
            this.btnCO.Size = new System.Drawing.Size(176, 47);
            this.btnCO.TabIndex = 2;
            this.btnCO.Text = "บัตรร่วม";
            this.btnCO.UseVisualStyleBackColor = true;
            this.btnCO.Click += new System.EventHandler(this.BtnCO_Click);
            // 
            // lbdCopro
            // 
            this.lbdCopro.AutoSize = true;
            this.lbdCopro.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbdCopro.Location = new System.Drawing.Point(160, 144);
            this.lbdCopro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdCopro.Name = "lbdCopro";
            this.lbdCopro.Size = new System.Drawing.Size(17, 23);
            this.lbdCopro.TabIndex = 12;
            this.lbdCopro.Text = "-";
            // 
            // lbCopro
            // 
            this.lbCopro.AutoSize = true;
            this.lbCopro.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbCopro.Location = new System.Drawing.Point(47, 144);
            this.lbCopro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCopro.Name = "lbCopro";
            this.lbCopro.Size = new System.Drawing.Size(83, 23);
            this.lbCopro.TabIndex = 11;
            this.lbCopro.Text = "บัตรร่วม :";
            // 
            // cMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 466);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "cMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainCustomer";
            this.Load += new System.EventHandler(this.CMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CMain_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCardID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnForeigner;
        private System.Windows.Forms.Button btnNmember;
        private System.Windows.Forms.Label lbd_cardid;
        private System.Windows.Forms.Label lbdtel;
        private System.Windows.Forms.Label lbdFullname;
        private System.Windows.Forms.Label lbdCardlv;
        private System.Windows.Forms.Label lbcardlv;
        private System.Windows.Forms.ListView lsvListitem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.LinkLabel lklEditcustomer;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TextBox txtSearchCard;
        private System.Windows.Forms.Button btnCO;
        private System.Windows.Forms.Label lbdCopro;
        private System.Windows.Forms.Label lbCopro;
    }
}

