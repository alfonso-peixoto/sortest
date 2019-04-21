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

namespace Gerenc_Prova
{
    public partial class Form1 : Form
    {
        Thread nt;
        public Form1()
        {
            InitializeComponent();
        }

        private void LogButEsntar_Click(object sender, EventArgs e)
        {
            if(logUsuario.Text == "" && logSenha.Text == "")
            {
                this.Close();
                nt = new Thread(entrar);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
        }

        private void entrar()
        {
            Application.Run(new provas());
        }

        private void LogCadastrar_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(cadastro);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void cadastro()
        {
            Application.Run(new cadastros());
        }
    }
}
