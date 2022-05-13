using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda.Dados.DataSet_AgendaTableAdapters;

namespace Agenda.Formularios
{
    public partial class frmNovo : Form
    {
        public frmNovo()
        {
            InitializeComponent();
        }

        private void dS_pessoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dS_pessoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_Agenda);

        }

        private void frmNovo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.DS_pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.dS_pessoaTableAdapter.Fill(this.dataSet_Agenda.DS_pessoa);

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if(btnNovo.Text == "&Novo")
            {
                Habilita_Caixas();
                //Desabilita_Controles()
                txtNome.Focus();
                btnNovo.Text = "&Gravar";

            }
            else
            {
                DS_pessoaTableAdapter taPessoa = new DS_pessoaTableAdapter();
                taPessoa.Insert(txtNome.Text, txtCidade.Text, dtpDataNasc.Value.ToString(), txtEmail.Text);
                int Ultimo = int.Parse(taPessoa.BuscarUltimoId().ToString());
                MessageBox.Show("Cadastro bem sucedido nº" + Ultimo);
                //Limpa_Caixas
                Desabilita_Caixas();
                btnNovo.Text = "&Novo";
            }
        }
        private void Habilita_Caixas()
        {
            foreach(Control c in this.Controls)
            {
                if((c is TextBox) || (c is DateTimePicker))
                {
                    c.Enabled = true;
                }
            }
        }
        private void Desabilita_Caixas()
        {
            foreach (Control c in this.Controls)
            {
                if ((c is TextBox) || (c is DateTimePicker))
                {
                    c.Enabled = false;
                }
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            DS_pessoaTableAdapter taPessoa = new DS_pessoaTableAdapter();
            DataTable dtPessoa;
            if (btnAlterar.Text == "&Alterar")
            {
                dtPessoa = taPessoa.Pesquisar_Pessoa(int.Parse(txtID.Text));
                if(dtPessoa.Rows.Count == 0) // Se não achou o ID
                {
                    MessageBox.Show("Id não cadastrado");
                }
                else
                {
                    txtNome.Text = dtPessoa.Rows[0]["nome"].ToString();
                    txtCidade.Text = dtPessoa.Rows[0]["cidade"].ToString();
                    dtpDataNasc.Value = DateTime.Parse(dtPessoa.Rows[0]["data_nascimento"].ToString());
                    txtEmail.Text = dtPessoa.Rows[0]["email"].ToString();
                    Habilita_Caixas();
                    btnAlterar.Text = "&Gravar";
                }
            }
            else // o texto do btnAlterar é "&Gravar"
            {
                taPessoa.Update(txtNome.Text, txtCidade.Text, dtpDataNasc.Value.ToString(), txtEmail.Text, int.Parse(txtID.Text));
                MessageBox.Show("Alteração bem sucedida");
                //Limpa_Caixas();
                Desabilita_Caixas();
                //Habilita_Controles();

                btnAlterar.Text = "&Alterar";

            }
        }
    }
}
