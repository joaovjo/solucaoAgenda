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

        // ---------------------------------------- MÉTODOS ----------------------------------------

        // ---------------------------------------- Habilitar_Caixas(); ----------------------------------------

        private void Habilitar_Caixas()
        {
            foreach (Control c in this.Controls)
            {
                if ((c is TextBox) || (c is DateTimePicker))
                {
                    c.Enabled = true;
                }
            }
        }

        // ---------------------------------------- Desabilitar_Caixas(); ----------------------------------------

        private void Desabilitar_Caixas()
        {
            foreach (Control c in this.Controls)
            {
                if ((c is TextBox) || (c is DateTimePicker))
                {
                    c.Enabled = false;
                }
            }
        }

        // ---------------------------------------- Limpar_Caixas(); ----------------------------------------

        private void Limpar_Caixas()
        {
            txtID.Text = "";
            txtNome.Text = "";
            txtCidade.Text = "";
            dtpDataNasc.Text = "";
            txtEmail.Text = "";
        }

        // ---------------------------------------- Habilitar_Controles(); ----------------------------------------

        private void Habilitar_Controles()
        {
            if (btnNovo.Text == "&Novo")
            {
                btnNovo.Enabled = true;
                btnCancelar.Enabled = false;
            }
            else if (btnAlterar.Text == "&Alterar")
            {
                btnAlterar.Enabled = true;
                btnCancelar.Enabled = false;
            }
            else
            {
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }
        // ---------------------------------------- Desabilitar_Controles(); ----------------------------------------

        private void Desabilitar_Controles()
        {
            if (btnNovo.Text == "&Gravar")
            {
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = true;
                btnFechar.Enabled = false;
            }
            else if (btnAlterar.Text == "&Gravar")
            {
                btnNovo.Enabled = false;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = true;
                btnFechar.Enabled = false;
            }
            else
            {
                btnNovo.Enabled = false;
                btnAlterar.Enabled = false;
                btnCancelar.Enabled = true;
                btnFechar.Enabled = false;
            }
        }

        // ---------------------------------------- FIM DOS MÉTODOS ----------------------------------------

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (btnNovo.Text == "&Novo")
            {
                Habilitar_Caixas();
                //Desabilitar_Controles();
                txtNome.Focus();
                btnNovo.Text = "&Gravar";

            }
            else
            {
                DS_pessoaTableAdapter taPessoa = new DS_pessoaTableAdapter();
                taPessoa.Insert(txtNome.Text, txtCidade.Text, dtpDataNasc.Value.ToString(), txtEmail.Text);
                int Ultimo = int.Parse(taPessoa.BuscarUltimoId().ToString());
                MessageBox.Show("Cadastro bem sucedido nº" + Ultimo);
                //Limpar_Caixas;
                Desabilitar_Caixas();
                btnNovo.Text = "&Novo";
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            DS_pessoaTableAdapter taPessoa = new DS_pessoaTableAdapter();
            DataTable dtPessoa;
            if (btnAlterar.Text == "&Alterar")
            {
                dtPessoa = taPessoa.Pesquisar_Pessoa(int.Parse(txtID.Text));
                if (dtPessoa.Rows.Count == 0) // Se não achou o ID
                {
                    MessageBox.Show("Id não cadastrado");
                }
                else
                {
                    txtNome.Text = dtPessoa.Rows[0]["nome"].ToString();
                    txtCidade.Text = dtPessoa.Rows[0]["cidade"].ToString();
                    dtpDataNasc.Value = DateTime.Parse(dtPessoa.Rows[0]["data_nascimento"].ToString());
                    txtEmail.Text = dtPessoa.Rows[0]["email"].ToString();
                    Habilitar_Caixas();
                    btnAlterar.Text = "&Gravar";
                }
            }
            else // o texto do btnAlterar é "&Gravar"
            {
                taPessoa.Update(txtNome.Text, txtCidade.Text, dtpDataNasc.Value.ToString(), txtEmail.Text, int.Parse(txtID.Text));
                MessageBox.Show("Alteração bem sucedida");
                //Limpar_Caixas();
                Desabilitar_Caixas();
                //Habilitar_Controles();

                btnAlterar.Text = "&Alterar";

            }
        }
    }
}
