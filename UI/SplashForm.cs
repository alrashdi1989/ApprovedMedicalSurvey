using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ApprovedMedicalSurvey.UI
{
    public partial class frmSplash : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRec, int nTopRec, int nRightRec, int nBottomRec, int nwidth, int nheight);


        public frmSplash()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            prgbarloading.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tmrloading.Enabled = true;
            prgbarloading.Value += 2;
            prgbarloading.Text = prgbarloading.Value.ToString() + "%";

            if (prgbarloading.Value == 100)
            {
                tmrloading.Enabled = false;
                frmLogin form = new frmLogin();
                form.Show();
                this.Hide();
            }

           
        }

       
    }
}
