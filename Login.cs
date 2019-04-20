using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Gerenc_Provas
{
    public partial class Login : Form
    {
        Thread nt;
        public Login()
        {
            InitializeComponent();
        }

        private void LogButEntrar_Click(object sender, EventArgs e)
        {
            if(LogLogin.Text == "" && LogSenha.Text == "")
            {
                this.Close();
                nt = new Thread(cadastro);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
        }

        private void cadastro()
        {
            Application.Run(new cadastros());
        }
    }
}
