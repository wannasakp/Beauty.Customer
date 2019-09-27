using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerPos = Beauty.CustomerPos;
using SyncTO = Beauty.SyncTo;
using ReportTO = Beauty.ReportTOtoWH;

namespace Beauty.Customer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (CustomerPos.cMain frmcustomer = new CustomerPos.cMain())
            {
                frmcustomer.ShowDialog();
                if (frmcustomer._STATUSCT == 0)
                {

                }
                else
                {
                    MessageBox.Show("CARDID : " + frmcustomer._CARDID + " CT_ID : " + frmcustomer._CT_ID + " CARDLV : " + frmcustomer._CARDLV);
                }
                
            } 
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (SyncTO.SyncToForm frmSync = new SyncTO.SyncToForm())
            {
                try
                {
                    string Local_CMDFX = "Data Source=192.168.1.34,1701;Initial Catalog=CMD-FX;User ID=sa;Password=0000";
                    string Server_CMDBX = "Data Source=192.168.2.35,1432;Initial Catalog=CMD-BX;User ID=sa;Password=0211";
                    string WH_ID = "2";
                    int DAY = -60;
                    bool result = frmSync.fSync_DOCTO(Local_CMDFX, Server_CMDBX, WH_ID, DAY);
                    if (result)
                    {
                        MessageBox.Show("เรียบร้อย");
                    }
                    else
                    {
                        MessageBox.Show("เกิดข้อผิดพลาด");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
               
            } 
        }

        private void BtnReportTO_Click(object sender, EventArgs e)
        {
            string Local_CMDFX = "Data Source=192.168.2.37,1701;Initial Catalog=CMD-FX;User ID=sa;Password=0000";
            //string Server_CMDBX = "Data Source=192.168.2.35,1432;Initial Catalog=CMD-BX;User ID=sa;Password=0211";
            ReportTO.ReportTotoWH frm = new ReportTO.ReportTotoWH(Local_CMDFX);
            frm.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //string Local_CMDFX = "Data Source=192.168.2.37,1701;Initial Catalog=CMD-FX;User ID=sa;Password=0000";
            string Server_CMDBX = "Data Source=192.168.2.35,1432;Initial Catalog=CMD-BX;User ID=sa;Password=0211";
            ReportTO.ReportTRtoWH frm = new ReportTO.ReportTRtoWH(Server_CMDBX,"434");
            frm.ShowDialog();
        }
    }
}
