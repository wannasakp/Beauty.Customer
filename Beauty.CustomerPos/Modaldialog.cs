using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beauty.CustomerPos
{
   
    public partial class Modaldialog : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Modaldialog(string textalert,int icon,int typetext)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            

            //icon 1:warning
            //icon 2:error
            //typetext 1 : showtextcenter
            //typetext 2 : showtextbottom

            if (typetext == 1)
            {
                lbTextalert.Visible = true;
                lbTextalert2.Visible = false;
                lbTextalert.Text = textalert;
                if (icon == 1)
                {
                    picWarning.Visible = true;
                }
                else if (icon == 2)
                {
                    picError.Visible = true;
                }
            }
            else if (typetext == 2)
            {
                lbTextalert.Visible = false;
                lbTextalert2.Visible = true;
                lbTextalert2.Text = textalert;
                if (icon == 1)
                {
                    picWarning2.Visible = true;
                }
                else if (icon == 2)
                {
                    picError2.Visible = true;
                }
            }
           
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
