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
using k.libary;

namespace Beauty.CustomerPos
{
    public partial class cCoPro : Form
    {
        public decimal _Total;
        DataSet dsCOPRO;
        public string _sqlload = @"SELECT ID,ABBNAME,FULLNAME,QUALIFIER,DISCOUNT FROM MAS_CT_CO WHERE ACTIVATE = 'T' ORDER BY ID DESC";
        public int _COID;
        public string _CONAME;
        public bool _COSTATUS;
        public cCoPro(decimal Total,DataSet dscopro)
        {
            _Total = Total;
            dsCOPRO = dscopro;
            InitializeComponent(); 
        } 
        private void CCoPro_Load(object sender, EventArgs e)
        {
            loadDataGridview();
            
            lsvCopro2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvCopro2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lsvCopro2.Columns[0].Width = 0;
            lsvCopro2.FullRowSelect = true;
        }

        public void loadDataGridview() {
            cMain dtfrm = new cMain();
            //DataSet ds = GetDataSet(dtfrm._connLocal_CMDFX, _sqlload);  

            lsvCopro2.addDataWithDataset(dsCOPRO, false, true );
            lsvCopro2.setAlternateColorRow();
            lsvCopro2.Items[0].Selected = true;
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

        private void CCoPro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                _COSTATUS = false;
                this.Close();
                // prevent child controls from handling this event as well
                e.SuppressKeyPress = true;
            }
        }

        private void LsvCopro2_DoubleClick(object sender, EventArgs e)
        {
            entercopro(); 
        }

        private void LsvCopro2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                entercopro();
            }
        }

        public void entercopro() {
            decimal co_qualifier = decimal.Parse(lsvCopro2.SelectedItems[0].SubItems[3].Text);
            if (co_qualifier > _Total)
            {
                Modaldialog frm = new Modaldialog("จะต้องมียอดซื้อขั้นต่ำ " + co_qualifier.ToString() + " บาท", 2, 2);
                frm.ShowDialog();
            }
            else
            {
                _COID = int.Parse(lsvCopro2.SelectedItems[0].SubItems[0].Text);
                _CONAME = lsvCopro2.SelectedItems[0].SubItems[1].Text;
                _COSTATUS = true;
                this.Close();
            }
        }
    }
}
