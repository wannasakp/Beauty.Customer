using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using k.libary;

namespace Beauty.SyncTo
{
    public partial class SyncToForm : Form
    {
        public SyncToForm()
        {
            InitializeComponent();
        }

        public bool fSync_DOCTO(string _Local_CMDFX, string _Server_CMDBX, string WH_ID, int DAY)
        {
            bool result = false;
            string sQuery = @"SELECT * FROM DOC_ST_TR WHERE WH_ID_LOAN IS NOT NULL AND WH_ID = " + WH_ID + " AND   DOCDATE BETWEEN DATEADD(DAY," + DAY + ",GETDATE()) and GETDATE() ";
            try
            {
                DataSet dsServer = cData.getDataSetWithSqlCommand(_Server_CMDBX, sQuery, 1000, true);
                DataSet dsLocal = cData.getDataSetWithSqlCommand(_Local_CMDFX, sQuery, 1000, true);
                DataTable dtServer = dsServer.Tables[0];
                DataTable dtLocal = dsLocal.Tables[0];
                int ccount = 0;
                if (dtServer.Rows.Count > 0)
                {
                    string sQueryupdate = @"UPDATE DOC_ST_TR SET DOCSTATUS=@DOCSTATUS , DOCSTATUS_TR=@DOCSTATUS_TR , UPDATEDT = @UPDATEDT WHERE DOCNO = @DOCNO";
                    foreach (DataRow Rows in dtServer.Rows)
                    {

                        foreach (DataRow lcRows in dtLocal.Rows)
                        {
                            string sv_docno = Rows["DOCNO"].ToString();
                            string lc_docno = lcRows["DOCNO"].ToString();
                            DateTime sv_updatedt = DateTime.Parse(Rows["UPDATEDT"].ToString());
                            DateTime lc_updatedt = DateTime.Parse(lcRows["UPDATEDT"].ToString());

                            if (sv_docno == lc_docno && sv_updatedt > lc_updatedt)
                            {
                                using (SqlConnection conn = new SqlConnection(_Local_CMDFX))
                                {
                                    using (SqlCommand comm = new SqlCommand())
                                    {
                                        comm.Connection = conn;
                                        comm.CommandType = CommandType.Text;
                                        comm.CommandText = sQueryupdate;
                                        comm.Parameters.AddWithValue("@DOCSTATUS", Rows["DOCSTATUS"].ToString());
                                        comm.Parameters.AddWithValue("@DOCSTATUS_TR", Rows["DOCSTATUS_TR"].ToString());
                                        comm.Parameters.AddWithValue("@UPDATEDT", DateTime.Parse(Rows["UPDATEDT"].ToString()));
                                        comm.Parameters.AddWithValue("@DOCNO", Rows["DOCNO"].ToString());
                                        conn.Open();
                                        int recordsAffected = comm.ExecuteNonQuery();
                                        ccount += recordsAffected;
                                    }
                                }
                            }
                        }
                    }
                }
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
                cMessage.ErrorMessageNotCaption(ex.Message);
            }
            return result;
        }
    }
}
