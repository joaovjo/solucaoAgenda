using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.Formularios
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaAgenda objConsultaAgenda = new frmConsultaAgenda();
            objConsultaAgenda.MdiParent = this;
            objConsultaAgenda.Show();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPessoas objCadPessoas = new frmCadPessoas();
            objCadPessoas.MdiParent = this;
            objCadPessoas.Show();
        }

        private void pessoasNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovo objNovo = new frmNovo();
            objNovo.MdiParent = this;
            objNovo.Show();
        }
    }
}
