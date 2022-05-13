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
    public partial class frmCadPessoas : Form
    {
        public frmCadPessoas()
        {
            InitializeComponent();
        }

        private void dS_pessoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dS_pessoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_Agenda);

        }

        private void frmCadPessoas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.DS_pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.dS_pessoaTableAdapter.Fill(this.dataSet_Agenda.DS_pessoa);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma exclusão?", "Excluindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                dS_pessoaBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.dataSet_Agenda);
            }
        }
    }
}
