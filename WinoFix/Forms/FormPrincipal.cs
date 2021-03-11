using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinoFix.Forms;

namespace WinoFix
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        //CARREGA OS FORMS UTILIZADOS DENTRO DO FORM PRINCIPAL
        FormCorrecao frmCorrecao = new FormCorrecao();
        FormRelatorio frmRelatorio = new FormRelatorio();

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //MAXIMIZA O MENU LATERAL
            if (pnlMenu.Width==50)
            {
                pnlMenu.Visible = false;
                logo_min.Visible = false;
                pnlMenu.Width = 210;
                btnMenu.Location = new Point(174, 6);
                frmRelatorio.Width = 880;
                frmCorrecao.Width = 880;
                panelAnimator.ShowSync(pnlMenu);
                logoAnimator.ShowSync(logo);
            }
            //MINIMIZA O MENU LATERAL
            else
            {
                logoAnimator.Hide(logo);
                pnlMenu.Visible = false;
                logo_min.Visible = true;
                frmCorrecao.Width = 1040;
                frmRelatorio.Width = 1040;
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

        private void btnCorrecao_Click(object sender, EventArgs e)
        {
            btnCorrecao.selected = true;
            frmRelatorio.Visible = false;
            frmCorrecao.TopLevel = false;
            pnlConteudo.Controls.Add(frmCorrecao);
            frmCorrecao.FormBorderStyle = FormBorderStyle.None;
            frmCorrecao.Show();
        }
        //FECHA A APLICAÇÃO
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            frmCorrecao.Visible = false;
            frmRelatorio.TopLevel = false;
            pnlConteudo.Controls.Add(frmRelatorio);
            frmRelatorio.AutoSize = true;
            frmRelatorio.Show();

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
