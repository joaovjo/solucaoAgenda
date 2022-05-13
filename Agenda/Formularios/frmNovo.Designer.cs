
namespace Agenda.Formularios
{
    partial class frmNovo
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label data_nascimentoLabel;
            System.Windows.Forms.Label emailLabel;
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dS_pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Agenda = new Agenda.Dados.DataSet_Agenda();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dS_pessoaTableAdapter = new Agenda.Dados.DataSet_AgendaTableAdapters.DS_pessoaTableAdapter();
            this.tableAdapterManager = new Agenda.Dados.DataSet_AgendaTableAdapters.TableAdapterManager();
            this.btnCancelar = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            data_nascimentoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS_pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(23, 27);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "id:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(23, 53);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(36, 13);
            nomeLabel.TabIndex = 7;
            nomeLabel.Text = "nome:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(23, 79);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(42, 13);
            cidadeLabel.TabIndex = 9;
            cidadeLabel.Text = "cidade:";
            // 
            // data_nascimentoLabel
            // 
            data_nascimentoLabel.AutoSize = true;
            data_nascimentoLabel.Location = new System.Drawing.Point(23, 106);
            data_nascimentoLabel.Name = "data_nascimentoLabel";
            data_nascimentoLabel.Size = new System.Drawing.Size(88, 13);
            data_nascimentoLabel.TabIndex = 11;
            data_nascimentoLabel.Text = "data nascimento:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(23, 131);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "email:";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(465, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(465, 52);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(465, 92);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(465, 172);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_pessoaBindingSource, "id", true));
            this.txtID.Location = new System.Drawing.Point(117, 24);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(101, 20);
            this.txtID.TabIndex = 6;
            // 
            // dS_pessoaBindingSource
            // 
            this.dS_pessoaBindingSource.DataMember = "DS_pessoa";
            this.dS_pessoaBindingSource.DataSource = this.dataSet_Agenda;
            // 
            // dataSet_Agenda
            // 
            this.dataSet_Agenda.DataSetName = "DataSet_Agenda";
            this.dataSet_Agenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_pessoaBindingSource, "nome", true));
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(117, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 8;
            // 
            // txtCidade
            // 
            this.txtCidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_pessoaBindingSource, "cidade", true));
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(117, 76);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(200, 20);
            this.txtCidade.TabIndex = 10;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dS_pessoaBindingSource, "data_nascimento", true));
            this.dtpDataNasc.Enabled = false;
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(117, 102);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(101, 20);
            this.dtpDataNasc.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_pessoaBindingSource, "email", true));
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(117, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 14;
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
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(465, 132);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 212);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(data_nascimentoLabel);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Name = "frmNovo";
            this.Text = "frmNovo";
            this.Load += new System.EventHandler(this.frmNovo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFechar;
        private Dados.DataSet_Agenda dataSet_Agenda;
        private System.Windows.Forms.BindingSource dS_pessoaBindingSource;
        private Dados.DataSet_AgendaTableAdapters.DS_pessoaTableAdapter dS_pessoaTableAdapter;
        private Dados.DataSet_AgendaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCancelar;
    }
}