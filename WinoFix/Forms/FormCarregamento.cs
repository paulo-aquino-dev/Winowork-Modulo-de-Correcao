﻿using System;
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
    public partial class FormCarregamento : Form
    {
        public FormCarregamento()
        {
            InitializeComponent();
        }
        int i = 0;


        private void tmrCarregamento_Tick(object sender, EventArgs e)
        {

           
            if (pgbSplash.Value < 9)
            {
                pgbSplash.Value = pgbSplash.Value + 1;
            }
            else
            {
                tmrCarregamento.Stop();
                FormLogin formLogin = new FormLogin();
                this.Hide();
                formLogin.Show();
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
