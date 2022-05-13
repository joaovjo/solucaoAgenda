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
    public partial class frmConsultaAgenda : Form
    {
        public frmConsultaAgenda()
        {
            InitializeComponent();
        }

        private void dS_pessoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dS_pessoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_Agenda);

        }

        private void frmConsultaAgenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.DS_pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.dS_pessoaTableAdapter.Fill(this.dataSet_Agenda.DS_pessoa);

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string coluna = cmbColuna.Text;
            int contadorTotal = dS_pessoaDataGridView.Rows.Count;

            switch (cmbColuna.Text)
            {
                case "Nome":
                    {
                        if (cmbProcura.Text == "Igual a")
                        {
                            dS_pessoaBindingSource.Filter = "[Nome] = '" + txtPesquisa.Text + "'";
                            if (dS_pessoaDataGridView.Rows.Count == 0)
                            {
                                MessageBox.Show("Nenhum resultado encontrado!");
                                lblContador.Text = dS_pessoaBindingSource.Count.ToString();
                                lblContador.Text = "Exibindo " + dS_pessoaBindingSource.Count.ToString() + " de " + dS_pessoaDataGridView.Rows.Count.ToString() + " itens.";
                            }
                            else
                            {
                                lblContador.Text = "Exibindo " + dS_pessoaBindingSource.Count.ToString() + " de " + contadorTotal + " itens.";
                            }
                        }
                        else if (cmbProcura.Text == "Que contém")
                        {
                            dS_pessoaBindingSource.Filter = "[Nome] like '%" + txtPesquisa.Text + "%'";
                            if (dS_pessoaDataGridView.Rows.Count == 0)
                            {
                                MessageBox.Show("Nenhum resultado encontrado!");
                                lblContador.Text = dS_pessoaBindingSource.Count.ToString();
                            }
                            else
                            {
                                //lblContador.Text = "Exibindo " + dS_pessoaBindingSource.Count.ToString() + " de " + dS_pessoaDataGridView.Rows.Count.ToString() + " itens.";
                                lblContador.Text = "Exibindo " + dS_pessoaBindingSource.Count.ToString() + " de " + contadorTotal + " itens.";
                                // lblContador.Text = dS_pessoaBindingSource.Count.ToString();
                            }
                        }
                        else if (cmbProcura.Text == "Todos")
                        {
                            dS_pessoaBindingSource.Filter = "";
                            if (dS_pessoaDataGridView.Rows.Count == 0)
                            {
                                MessageBox.Show("Nenhum resultado encontrado!");
                                lblContador.Text = dS_pessoaBindingSource.Count.ToString();
                            }
                            else
                            {
                                lblContador.Text = "Exibindo " + dS_pessoaBindingSource.Count.ToString() + " de " + contadorTotal + " itens.";
                            }
                        }
                        else if (cmbProcura.Text == "Que esteja entre")
                        {
                            dS_pessoaBindingSource.Filter = "[Nome]";
                        }
                        break;
                    }
            }

        }
    }
}
