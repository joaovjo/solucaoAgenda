
namespace Agenda.Formularios
{
    partial class frmConsultaAgenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataSet_Agenda = new Agenda.Dados.DataSet_Agenda();
            this.dS_pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_pessoaTableAdapter = new Agenda.Dados.DataSet_AgendaTableAdapters.DS_pessoaTableAdapter();
            this.tableAdapterManager = new Agenda.Dados.DataSet_AgendaTableAdapters.TableAdapterManager();
            this.dS_pessoaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmbColuna = new System.Windows.Forms.ComboBox();
            this.cmbProcura = new System.Windows.Forms.ComboBox();
            this.lblContador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_pessoaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet_Agenda
            // 
            this.dataSet_Agenda.DataSetName = "DataSet_Agenda";
            this.dataSet_Agenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dS_pessoaBindingSource
            // 
            this.dS_pessoaBindingSource.DataMember = "DS_pessoa";
            this.dS_pessoaBindingSource.DataSource = this.dataSet_Agenda;
            // 
            // dS_pessoaTableAdapter
            // 
            this.dS_pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DS_pessoaTableAdapter = this.dS_pessoaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Agenda.Dados.DataSet_AgendaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dS_pessoaDataGridView
            // 
            this.dS_pessoaDataGridView.AllowUserToAddRows = false;
            this.dS_pessoaDataGridView.AllowUserToDeleteRows = false;
            this.dS_pessoaDataGridView.AutoGenerateColumns = false;
            this.dS_pessoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dS_pessoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dS_pessoaDataGridView.DataSource = this.dS_pessoaBindingSource;
            this.dS_pessoaDataGridView.Location = new System.Drawing.Point(12, 60);
            this.dS_pessoaDataGridView.Name = "dS_pessoaDataGridView";
            this.dS_pessoaDataGridView.ReadOnly = true;
            this.dS_pessoaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dS_pessoaDataGridView.Size = new System.Drawing.Size(846, 220);
            this.dS_pessoaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "cidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "data_nascimento";
            this.dataGridViewTextBoxColumn4.HeaderText = "data_nascimento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn5.HeaderText = "email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(340, 12);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(350, 20);
            this.txtPesquisa.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(726, 11);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cmbColuna
            // 
            this.cmbColuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColuna.FormattingEnabled = true;
            this.cmbColuna.Items.AddRange(new object[] {
            "ID",
            "Nome",
            "Cidade"});
            this.cmbColuna.Location = new System.Drawing.Point(26, 12);
            this.cmbColuna.Name = "cmbColuna";
            this.cmbColuna.Size = new System.Drawing.Size(121, 21);
            this.cmbColuna.TabIndex = 4;
            // 
            // cmbProcura
            // 
            this.cmbProcura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcura.FormattingEnabled = true;
            this.cmbProcura.Items.AddRange(new object[] {
            "Todos",
            "Igual a",
            "Que começa com",
            "Que contém",
            "Que esteja entre",
            "Que termina com"});
            this.cmbProcura.Location = new System.Drawing.Point(183, 12);
            this.cmbProcura.Name = "cmbProcura";
            this.cmbProcura.Size = new System.Drawing.Size(121, 21);
            this.cmbProcura.TabIndex = 5;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(748, 293);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(0, 13);
            this.lblContador.TabIndex = 7;
            this.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmConsultaAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 445);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.cmbProcura);
            this.Controls.Add(this.cmbColuna);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dS_pessoaDataGridView);
            this.Name = "frmConsultaAgenda";
            this.Text = "frmConsultaAgenda";
            this.Load += new System.EventHandler(this.frmConsultaAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_pessoaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dados.DataSet_Agenda dataSet_Agenda;
        private System.Windows.Forms.BindingSource dS_pessoaBindingSource;
        private Dados.DataSet_AgendaTableAdapters.DS_pessoaTableAdapter dS_pessoaTableAdapter;
        private Dados.DataSet_AgendaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dS_pessoaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cmbColuna;
        private System.Windows.Forms.ComboBox cmbProcura;
        private System.Windows.Forms.Label lblContador;
    }
}