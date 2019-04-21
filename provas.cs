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
    public partial class provas : Form
    {
        public provas()
        {
            InitializeComponent();
        }

        private void Provas_Load(object sender, EventArgs e)
        {

        }

        private void ProvasDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        Thread nt;
        private void CadButCadastrar_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(gerenciador);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void gerenciador()
        {
            Application.Run(new gerenciador());
        }
    }
}
