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
    }
}
