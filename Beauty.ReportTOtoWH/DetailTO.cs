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
    public partial class DetailTO : Form
    {
        public string _DOCNO;
        public string _connLocal_CMDFX;
        public string _sqlLoad;
        public DetailTO()
        {
            InitializeComponent();
        }
        public DetailTO(string DOCNO, string connLocal_CMDFX)
        {
            InitializeComponent();
            _DOCNO = DOCNO;
            _connLocal_CMDFX = connLocal_CMDFX;
            _sqlLoad = @"select C.MPCODE,C.FULLNAME,cast(A.QTY as decimal(10,2)) from DOC_ST_TR_I A 
                            LEFT JOIN MAS_MP_BC B ON A.BC_ID=B.ID
                            LEFT JOIN MAS_MP C ON C.ID=B.MP_ID 
                            WHERE DOCNO = '" + _DOCNO + "'";

        }

        private void DetailTO_Load(object sender, EventArgs e)
        {
            GetDataSet(); 
            kListView1.setAlternateColorRow(); 
            kListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            kListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            kListView1.FullRowSelect = true;
        }
         

        private void GetDataSet()
        {
            DataSet ds = cData.getDataSetWithSqlCommand(_connLocal_CMDFX, _sqlLoad, 1000, true);
            kListView1.addDataWithDataset(ds, true, true);
        }

        private void ToolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
