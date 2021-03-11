using System;
using System.Windows.Forms;

namespace WinoFix
{
    public partial class FormLogin : Form
    {

        private DBConnect dbConnect;
        
        public FormLogin()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
           
        }

       

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //Login.Usuario = "WPAULO_2191";
            //MessageBox.Show(Login.Usuario);
            //dbConnect.selectFuncionario();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void entrada_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                entrada.Stop();
            }
            Opacity += .2;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = new FormPrincipal();
            this.Hide();
            formPrincipal.Show();
        }
    }
}
