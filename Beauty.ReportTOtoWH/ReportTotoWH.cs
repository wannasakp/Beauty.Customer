using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using k.libary;

namespace Beauty.ReportTOtoWH
{
    public partial class ReportTotoWH : Form
    {
        public string _connLocal_CMDFX;
        public string _connLocal_COM;
        public string _connServer_CMDBX;
        public string _connServer_COM;
        public string _sqlLoad = @"SELECT A.DOCNO,CONVERT(VARCHAR,A.DOCDATE,103),cast(A.QTY as decimal(10,2)),B.WHCODE,B.ABBNAME,C.WHCODE,C.ABBNAME
                                        FROM DOC_ST_TR A
                                        LEFT JOIN MAS_WH B ON A.WH_ID=B.ID
                                        LEFT JOIN MAS_WH C ON A.WH_ID_LOAN=C.ID
                                        WHERE A.WH_ID_LOAN IS NOT NULL 
                                        ORDER BY A.DOCDATE  ";
        public ReportTotoWH(string connLocal_CMDFX)
        {
            InitializeComponent();
            _connLocal_CMDFX = connLocal_CMDFX;
        }
        public ReportTotoWH()
        {
            InitializeComponent(); 
        }
        private void ReportTotoWH_Load(object sender, EventArgs e)
        {
            GetDataSet(_connLocal_CMDFX, _sqlLoad);
            kListView1.setAlternateColorRow();


            kListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            kListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            kListView1.FullRowSelect = true;
        }

        private void GetDataSet(string Connstring, string SQL)
        {
            DataSet ds = cData.getDataSetWithSqlCommand(Connstring, SQL, 1000, true);
            kListView1.addDataWithDataset(ds,true,true);
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
            DetailTO frm = new DetailTO(DOCNO,_connLocal_CMDFX);
            frm.ShowDialog();
        }
    }
}
