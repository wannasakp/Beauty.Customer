using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beauty.CustomerPos
{
    public partial class cMain : Form
    {
        public string _connLocal_CMDFX;
        public string _connLocal_COM;
        public string _connServer_CMDBX;
        public string _connServer_COM;
        public string _CARDID;
        public string _CT_ID;
        public string _CARDLV;
        public int _COID;
        public string _CONAME;
        public bool _COSTATUS;
        public int _STATUSCT = 0; // 0:ยกเลิก , 1:สมาชิก , 2:ขาจร , 3:ชาวต่างชาติ
        public decimal _Total;
        DataSet DSCUSTOMER;
        Customer cust = new Customer();
        DataSet dsCOPRO;
        public string _sqlloadCopro = @"SELECT ID,ABBNAME,FULLNAME,QUALIFIER,DISCOUNT FROM MAS_CT_CO WHERE ACTIVATE = 'T' ORDER BY ID DESC";

        public cMain()
        {
            InitializeComponent();
            _Total = 600;
            _connLocal_CMDFX = @"Data Source=fash2.DYNDNS.INFO,1401;Initial Catalog=CMD-FX;User ID=sa;Password=0000"; ;
            _connLocal_COM = @"Data Source=fash2.DYNDNS.INFO,1401;Initial Catalog=dbBeautyCommSupport;User ID=sa;Password=0000";
            _connServer_CMDBX = @"Data Source=5COSMEDA.HOMEUNIX.COM,1833;Initial Catalog=CMD-BX;User ID=sa;Password=0211";
            _connServer_COM = @"Data Source=5COSMEDA.HOMEUNIX.COM,1833;Initial Catalog=dbBeautyCommSupport;User ID=sa;Password=0211";
        }

        public cMain(decimal Total,string connLocal_CMDFX,string connLocal_COM,string connServer_CMDBX,string connServer_COM)
        {
            InitializeComponent();
            _Total = Total;
            _connLocal_CMDFX = connLocal_CMDFX;
            _connLocal_COM = connLocal_COM;
            _connServer_CMDBX = connServer_CMDBX;
            _connServer_COM = connServer_COM; 
        }

        private void CMain_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtSearchCard;
            cbSearchType.Items.Add("รหัสบัตรสมาชิก");
            cbSearchType.Items.Add("ชื่อลูกค้า");
            cbSearchType.Items.Add("เบอร์โทรศัพท์");
            cbSearchType.Items.Add("บัตรประชาชน"); 
            cbSearchType.SelectedIndex = 0;

            dsCOPRO = GetDataSet(_connLocal_CMDFX, _sqlloadCopro);
        }

        private void CbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cleardata();
            txtSearchCard.Focus(); 
        }

        private void Seach_Data()
        {
            lsvListitem.Visible = false;
            try
            {
                if (txtSearchCard.Text == "")
                {
                    Modaldialog frm = new Modaldialog("กรุณากรอกข้อมูล", 2,1);
                    frm.ShowDialog();
                    //MessageBox.Show("กรุณากรอกข้อมูล");
                }
                else
                {
                    string type = cbSearchType.SelectedItem.ToString();
                    string sqlQuery = @"SELECT A.ID,B.CARDID,A.TITLE,A.FULLNAME,A.ADDR_MOBILE ,B.CARDLV,A.ADDR_ROW1,A.ADDR_ROW2,A.ADDR_PROVINCE,A.ADDR_ZIPCODE,A.BIRTHDATE,A.SEX
                                        FROM MAS_CT A
                                        LEFT JOIN MAS_CT_CD B ON A.ID=B.CT_ID
                                        WHERE A.CT_STATUS = 'A' ";
                    string Addition = string.Empty;


                    if (type == "รหัสบัตรสมาชิก") Addition = " AND B.CARDID = '" + txtSearchCard.Text + "'";
                    else if (type == "ชื่อลูกค้า") Addition = " AND A.FULLNAME LIKE '%" + txtSearchCard.Text + "%'";
                    else if (type == "เบอร์โทรศัพท์") Addition = " AND A.ADDR_MOBILE = " + txtSearchCard.Text + "'";
                    else if (type == "บัตรประชาชน") Addition = " AND A.PEOPLEID = " + txtSearchCard.Text + "'";
                    sqlQuery += Addition;

                    DSCUSTOMER = GetDataSet(_connLocal_CMDFX, sqlQuery);
                    DataTable dt = DSCUSTOMER.Tables[0];

                    if (dt.Rows.Count > 1)
                    {
                        lsvListitem.Items.Clear(); 
                        foreach(DataRow Rows in dt.Rows)
                        {
                            ListViewItem lst = new ListViewItem();
                            lst = lsvListitem.Items.Add(Rows["CARDID"].ToString());
                            lst.SubItems.Add(Rows["TITLE"].ToString() + " " + Rows["FULLNAME"].ToString());
                            lst.SubItems.Add(Rows["ADDR_MOBILE"].ToString());
                            lst.SubItems.Add(Rows["CARDLV"].ToString());
                            lst.SubItems.Add(Rows["ID"].ToString());

                            lst.SubItems.Add(Rows["ADDR_ROW1"].ToString());
                            lst.SubItems.Add(Rows["ADDR_ROW2"].ToString());
                            lst.SubItems.Add(Rows["ADDR_PROVINCE"].ToString());
                            lst.SubItems.Add(Rows["ADDR_ZIPCODE"].ToString());
                            lst.SubItems.Add(Rows["BIRTHDATE"].ToString());
                            lst.SubItems.Add(Rows["SEX"].ToString());
                        }

                        lsvListitem.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                        lsvListitem.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                        lsvListitem.Columns[3].Width = 0;
                        lsvListitem.Columns[4].Width = 0;
                        lsvListitem.Columns[5].Width = 0;
                        lsvListitem.Columns[6].Width = 0;
                        lsvListitem.Columns[7].Width = 0;
                        lsvListitem.Columns[8].Width = 0;
                        lsvListitem.Columns[9].Width = 0;
                        lsvListitem.FullRowSelect = true;

                        lsvListitem.Visible = true;
                    }
                    else if (dt.Rows.Count == 1)
                    {
                        _CARDID = dt.Rows[0]["CARDID"].ToString();
                        _CT_ID  = dt.Rows[0]["ID"].ToString();
                        _CARDLV = dt.Rows[0]["CARDLV"].ToString();

                        lbd_cardid.Text = dt.Rows[0]["CARDID"].ToString();
                        lbdFullname.Text = dt.Rows[0]["TITLE"].ToString() + " " + dt.Rows[0]["FULLNAME"].ToString();
                        lbdtel.Text = dt.Rows[0]["ADDR_MOBILE"].ToString();

                        string cardlv = dt.Rows[0]["CARDLV"].ToString();
                        if (cardlv == "101") lbdCardlv.Text = "PINK MEMBER";
                        else if (cardlv == "102") lbdCardlv.Text = "ROSEGOLD MEMBER";
                        else if (cardlv == "501") lbdCardlv.Text = "SILVER MEMBER";
                        else if (cardlv == "502") lbdCardlv.Text = "GOLD MEMBER";
                        else lbdCardlv.Text = "ไม่มีระดับสมาชิก";

                        cust.CARDID = dt.Rows[0]["CARDID"].ToString();
                        cust.CT_ID = dt.Rows[0]["ID"].ToString();
                        cust.FULLNAME = dt.Rows[0]["FULLNAME"].ToString();
                        cust.ADDR_ROW1 = dt.Rows[0]["ADDR_ROW1"].ToString();
                        cust.ADDR_ROW2 = dt.Rows[0]["ADDR_ROW2"].ToString();
                        cust.ADDR_PROVINCE = dt.Rows[0]["ADDR_PROVINCE"].ToString();
                        cust.ADDR_ZIPCODE = dt.Rows[0]["ADDR_ZIPCODE"].ToString();
                        cust.ADDR_MOBILE = dt.Rows[0]["ADDR_MOBILE"].ToString();
                        cust.BIRTHDATE = DateTime.Parse(dt.Rows[0]["BIRTHDATE"].ToString());
                        cust.SEX = dt.Rows[0]["SEX"].ToString();
                        lklEditcustomer.Visible = true;
                    }
                    else
                    {
                        Modaldialog frm = new Modaldialog("ไม่พบข้อมูลลูกค้า",1,1);
                        frm.ShowDialog();
                        //MessageBox.Show("ไม่พบข้อมูล");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Modaldialog frm = new Modaldialog(ex.Message, 2);
                //frm.ShowDialog();
                throw;
            }
        }

        public DataSet GetDataSet(string Connstring, string SQL) 
        {
            SqlConnection conn = new SqlConnection(Connstring);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = SQL;
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            conn.Open();
            da.Fill(ds);
            conn.Close();

            return ds;
        }

        private void TxtSearchCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (_CARDID == "" || _CARDID == null)
                {
                    if (txtSearchCard.Text == "")
                    {
                        this.Close();
                    }
                    else
                    {
                        Seach_Data();
                    }
                }
                else
                {
                    this.Close();
                }
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                _STATUSCT = 0; // ยกเลิก
                this.Close();
            }
            else {
                cleardata();
            }
        }

        public void cleardata() {
            lsvListitem.Visible = false;
            _CARDID = "";
            _CT_ID = "";
            _CARDLV = "";

            lbd_cardid.Text = "-";
            lbdFullname.Text = "-";
            lbdtel.Text = "-";
            lbdCardlv.Text = "-";
        }

        private void LsvListitem_DoubleClick(object sender, EventArgs e)
        {
            lsvListitem.Visible = false; 

            string CARDID = lsvListitem.SelectedItems[0].SubItems[0].Text;
            string FULLNAME = lsvListitem.SelectedItems[0].SubItems[1].Text;
            string TEL = lsvListitem.SelectedItems[0].SubItems[2].Text;
            string CARDLV = lsvListitem.SelectedItems[0].SubItems[3].Text;
            string CT_ID = lsvListitem.SelectedItems[0].SubItems[4].Text;
            string ADDR1 = lsvListitem.SelectedItems[0].SubItems[5].Text;
            string ADDR2 = lsvListitem.SelectedItems[0].SubItems[6].Text;
            string PROVINCE = lsvListitem.SelectedItems[0].SubItems[7].Text;
            string ZIPCODE = lsvListitem.SelectedItems[0].SubItems[8].Text;
            DateTime HBD = DateTime.Parse(lsvListitem.SelectedItems[0].SubItems[9].Text);
            string SEX = lsvListitem.SelectedItems[0].SubItems[10].Text; 
            _CARDID = CARDID;
            _CT_ID = CT_ID;
            _CARDLV = CARDLV;

            lbd_cardid.Text = CARDID;
            lbdFullname.Text = FULLNAME;
            lbdtel.Text = TEL;
            lklEditcustomer.Visible = true;
            if (CARDLV == "101") lbdCardlv.Text = "PINK MEMBER";
            else if (CARDLV == "102") lbdCardlv.Text = "ROSEGOLD MEMBER";
            else if (CARDLV == "501") lbdCardlv.Text = "SILVER MEMBER";
            else if (CARDLV == "502") lbdCardlv.Text = "GOLD MEMBER";
            else lbdCardlv.Text = "ไม่มีระดับสมาชิก";

            cust.CARDID = CARDID;
            cust.CT_ID = CT_ID;
            cust.FULLNAME = FULLNAME;
            cust.ADDR_ROW1 = ADDR1;
            cust.ADDR_ROW2 = ADDR2;
            cust.ADDR_PROVINCE = PROVINCE;
            cust.ADDR_ZIPCODE = ZIPCODE;
            cust.ADDR_MOBILE = TEL;
            cust.BIRTHDATE = HBD;
            cust.SEX = SEX;

            _STATUSCT = 1; // สมาชิก
            txtSearchCard.Focus();
        }

        private void BtnNmember_Click(object sender, EventArgs e)
        {
            _STATUSCT = 2; // ขาจร
            _CARDID = "";
            _CT_ID = "";
            _CARDLV = "";
            this.Close();
        }

        private void LklEditcustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            cEditCustomer frm = new cEditCustomer(cust, _connLocal_CMDFX);
            frm.ShowDialog();
            txtSearchCard.Focus();
        }

        private void BtnForeigner_Click(object sender, EventArgs e)
        {
            _STATUSCT = 3; // ชาวต่างชาติ
            _CARDID = "";
            _CT_ID = "";
            _CARDLV = "";
            this.Close();
        }

        private void BtnCO_Click(object sender, EventArgs e)
        {
            cCoPro frm = new cCoPro(_Total, dsCOPRO);
            frm.ShowDialog();
            _COSTATUS = frm._COSTATUS;
            if (_COSTATUS)
            {
                _COID = frm._COID;
                _CONAME = frm._CONAME;
                lbdCopro.Text = _CONAME;
                lbdCopro.Visible = true;
                lbCopro.Visible = true;
            }
            else
            {
                _COID = 0;
                _CONAME = null;
                lbdCopro.Visible = false;
                lbCopro.Visible = false;
            }
            txtSearchCard.Focus();
        }

        private void CMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                _STATUSCT = 0;
                this.Close();
                // prevent child controls from handling this event as well
                e.SuppressKeyPress = true;
            }
        }
    }
}
