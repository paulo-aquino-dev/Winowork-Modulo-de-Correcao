using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinoFix
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            
            if (pnlMenu.Width==50)
            {
                pnlMenu.Visible = false;
                logo_min.Visible = false;
                pnlMenu.Width = 210;
                btnMenu.Location = new Point(174, 6);
                panelAnimator.ShowSync(pnlMenu);
                logoAnimator.ShowSync(logo);
            }
            else
            {
                logoAnimator.Hide(logo);
                pnlMenu.Visible = false;
                logo_min.Visible = true;
                pnlMenu.Width = 50;
                panelAnimator.ShowSync(pnlMenu);
                btnMenu.Location = new Point(13, 75);
            }
        }

      

        private void entrada_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                entrada.Stop();
            }
            Opacity += .2;
        }
    }
}
