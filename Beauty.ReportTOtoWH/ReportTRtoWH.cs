using k.libary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Beauty.ReportTOtoWH
{
    public partial class ReportTRtoWH : Form
    {
        public string _connLocal_CMDFX;
        public string _connLocal_COM;
        public string _connServer_CMDBX;
        public string _connServer_COM;
        public string _WH_ID;
        public string _sqlLoad ;
        public ReportTRtoWH()
        {
            InitializeComponent();
        }
        public ReportTRtoWH(string connServer_CMDBX, string WH_ID)
        {
            InitializeComponent();
            _connServer_CMDBX = connServer_CMDBX;
            _WH_ID = WH_ID;
            _sqlLoad = @"SELECT A.DOCNO,CONVERT(VARCHAR,A.DOCDATE,103),B.WHCODE,B.ABBNAME ,C.WHCODE,C.ABBNAME ,D.DOCNO,D.GENCODE_IN
                                    FROM DOC_ST_TR A
                                    LEFT JOIN DOC_ST_TR D ON D.REMARK=A.DOCNO 
                                    LEFT JOIN MAS_WH B ON A.WH_ID = B.ID
                                    LEFT JOIN MAS_WH C ON A.WH_ID_LOAN = C.ID
                                    WHERE  (D.DOCSTATUS_TR = 'N' OR D.DOCSTATUS_TR IS NULL) AND A.DOCSTATUS <> 'C' AND a.WH_ID_LOAN =  '" + WH_ID + "'";
        }

        private void ReportTRtoWH_Load(object sender, EventArgs e)
        {
            GetDataSet(_connServer_CMDBX, _sqlLoad);
            kListView1.setAlternateColorRow();


            kListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            kListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            kListView1.FullRowSelect = true;
        }

        private void GetDataSet(string Connstring, string SQL)
        {
            DataSet ds = cData.getDataSetWithSqlCommand(Connstring, SQL, 1000, true);
            kListView1.addDataWithDataset(ds, true, true);
        }

        private void ToolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            kListView1.ExportToExcel();
        }

        private void KListView1_DoubleClick(object sender, EventArgs e)
        {
            string DOCNO = kListView1.SelectedItems[0].SubItems[1].Text;
            DetailTO frm = new DetailTO(DOCNO, _connLocal_CMDFX);
            frm.ShowDialog();
        }
    }
}
