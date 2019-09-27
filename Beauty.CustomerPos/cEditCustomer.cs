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
    public partial class cEditCustomer : Form
    {
        public Customer _customer { get; set; }
        public string _connLocal_CMDFX;
        public string _Province;
        public cEditCustomer(Customer dt,string connLocal_CMDFX)
        {
            InitializeComponent();
            _customer = dt;

            txtCardid.Text = _customer.CARDID;
            txtCtid.Text = _customer.CT_ID;
            txtFullname.Text = _customer.FULLNAME;
            txtAddr1.Text = _customer.ADDR_ROW1;
            txtAddr2.Text = _customer.ADDR_ROW2;
            _Province = _customer.ADDR_PROVINCE;
            txtZipcode.Text = _customer.ADDR_ZIPCODE;
            txtTel.Text = _customer.ADDR_MOBILE;
            txtBIRTHDATE.Value = _customer.BIRTHDATE;
            _connLocal_CMDFX = connLocal_CMDFX;
        }

        private void CEditCustomer_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            string sqlzip = @"SELECT PROVINCE FROM MAS_ZIP GROUP BY PROVINCE";
            DataSet ds = GetDataSet(_connLocal_CMDFX, sqlzip);
            DataTable dt = ds.Tables[0];
            foreach (DataRow Row in dt.Rows)
            {
                cbProvince.Items.Add(Row["PROVINCE"].ToString());
            }

            cbSex.Items.Add("ชาย");
            cbSex.Items.Add("หญิง");
            if (_Province == "กรุงเทพมหานคร")
            {
                cbProvince.SelectedItem = "กทม.";
            }
            else {
                cbProvince.SelectedItem = _Province;
            }
            
            if (_customer.SEX == "M") cbSex.SelectedIndex = 0;
            else if (_customer.SEX == "F") cbSex.SelectedIndex = 1; 
        }

        public DataSet GetDataSet(string Connstring, string SQL)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
           
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
