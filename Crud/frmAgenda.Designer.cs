namespace Crud
{
    partial class frmAgenda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bsAgenda = new BindingSource(components);
            dataGridView1 = new DataGridView();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enderecoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lblAgenda = new Label();
            btnNovo = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)bsAgenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bsAgenda
            // 
            bsAgenda.DataMember = "ListaAgenda";
            bsAgenda.DataSource = typeof(DAL.Repositorio);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.GrayText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nomeDataGridViewTextBoxColumn, enderecoDataGridViewTextBoxColumn, telefoneDataGridViewTextBoxColumn });
            dataGridView1.Cursor = Cursors.PanNW;
            dataGridView1.DataSource = bsAgenda;
            dataGridView1.Location = new Point(46, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(497, 250);
            dataGridView1.TabIndex = 0;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            enderecoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            enderecoDataGridViewTextBoxColumn.MinimumWidth = 6;
            enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            telefoneDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            telefoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lblAgenda
            // 
            lblAgenda.AutoSize = true;
            lblAgenda.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgenda.Location = new Point(244, 9);
            lblAgenda.Name = "lblAgenda";
            lblAgenda.Size = new Size(86, 22);
            lblAgenda.TabIndex = 1;
            lblAgenda.Text = "Agenda ";
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(268, 336);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 2;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(468, 336);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(369, 336);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(3, 375);
            label1.Name = "label1";
            label1.Size = new Size(177, 16);
            label1.TabIndex = 5;
            label1.Text = "app feito por João e Henrique";
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(581, 400);
            Controls.Add(label1);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnNovo);
            Controls.Add(lblAgenda);
            Controls.Add(dataGridView1);
            Cursor = Cursors.PanNW;
            Name = "frmAgenda";
            Text = "Crud com Mongo";
            Load += frmAgenda_Load;
            ((System.ComponentModel.ISupportInitialize)bsAgenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bsAgenda;
        private DataGridView dataGridView1;
        private Label lblAgenda;
        private Button btnNovo;
        private Button btnExcluir;
        private Button btnEditar;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private Label label1;
    }
}