namespace SalaDeReunioes
{
    partial class FrmConsultarSalas
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
            label1 = new Label();
            dgvSalas = new DataGridView();
            colNome = new DataGridViewTextBoxColumn();
            colAndar = new DataGridViewTextBoxColumn();
            colAssentos = new DataGridViewTextBoxColumn();
            label2 = new Label();
            txtPesquisarSala = new TextBox();
            lblPagina = new Label();
            btnAnterior = new Button();
            btnProxima = new Button();
            btnAlterarSala = new Button();
            btnExcluirSala = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSalas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(312, 32);
            label1.Name = "label1";
            label1.Size = new Size(268, 41);
            label1.TabIndex = 0;
            label1.Text = "Salas Cadastradas";
            // 
            // dgvSalas
            // 
            dgvSalas.AllowUserToAddRows = false;
            dgvSalas.AllowUserToDeleteRows = false;
            dgvSalas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalas.Columns.AddRange(new DataGridViewColumn[] { colNome, colAndar, colAssentos });
            dgvSalas.Location = new Point(24, 144);
            dgvSalas.MultiSelect = false;
            dgvSalas.Name = "dgvSalas";
            dgvSalas.ReadOnly = true;
            dgvSalas.RowHeadersWidth = 51;
            dgvSalas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalas.Size = new Size(629, 320);
            dgvSalas.TabIndex = 1;
            // 
            // colNome
            // 
            colNome.DataPropertyName = "Nome";
            colNome.HeaderText = "Nome";
            colNome.MinimumWidth = 6;
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            // 
            // colAndar
            // 
            colAndar.DataPropertyName = "Andar";
            colAndar.HeaderText = "Nº Andar";
            colAndar.MinimumWidth = 6;
            colAndar.Name = "colAndar";
            colAndar.ReadOnly = true;
            // 
            // colAssentos
            // 
            colAssentos.DataPropertyName = "QtddAssentos";
            colAssentos.HeaderText = "Quantidade Assentos";
            colAssentos.MinimumWidth = 6;
            colAssentos.Name = "colAssentos";
            colAssentos.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 108);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 2;
            label2.Text = "Pesquisar Sala";
            // 
            // txtPesquisarSala
            // 
            txtPesquisarSala.Location = new Point(132, 105);
            txtPesquisarSala.Name = "txtPesquisarSala";
            txtPesquisarSala.Size = new Size(203, 27);
            txtPesquisarSala.TabIndex = 3;
            txtPesquisarSala.TextChanged += txtPesquisarSala_TextChanged;
            // 
            // lblPagina
            // 
            lblPagina.AutoSize = true;
            lblPagina.Location = new Point(271, 479);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(98, 20);
            lblPagina.TabIndex = 4;
            lblPagina.Text = "Página 1 de 1";
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = SystemColors.GradientActiveCaption;
            btnAnterior.Location = new Point(171, 475);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(94, 29);
            btnAnterior.TabIndex = 5;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnProxima
            // 
            btnProxima.BackColor = SystemColors.GradientActiveCaption;
            btnProxima.Location = new Point(373, 475);
            btnProxima.Name = "btnProxima";
            btnProxima.Size = new Size(94, 29);
            btnProxima.TabIndex = 6;
            btnProxima.Text = "Próxima";
            btnProxima.UseVisualStyleBackColor = false;
            btnProxima.Click += btnProxima_Click;
            // 
            // btnAlterarSala
            // 
            btnAlterarSala.BackColor = SystemColors.Info;
            btnAlterarSala.Location = new Point(699, 202);
            btnAlterarSala.Name = "btnAlterarSala";
            btnAlterarSala.Size = new Size(146, 48);
            btnAlterarSala.TabIndex = 7;
            btnAlterarSala.Text = "Alterar Sala";
            btnAlterarSala.UseVisualStyleBackColor = false;
            btnAlterarSala.Click += btnAlterarSala_Click;
            // 
            // btnExcluirSala
            // 
            btnExcluirSala.BackColor = SystemColors.Info;
            btnExcluirSala.Location = new Point(699, 302);
            btnExcluirSala.Name = "btnExcluirSala";
            btnExcluirSala.Size = new Size(146, 49);
            btnExcluirSala.TabIndex = 8;
            btnExcluirSala.Text = "Excluir Sala";
            btnExcluirSala.UseVisualStyleBackColor = false;
            btnExcluirSala.Click += btnExcluirSala_Click;
            // 
            // FrmConsultarSalas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(882, 565);
            Controls.Add(btnExcluirSala);
            Controls.Add(btnAlterarSala);
            Controls.Add(btnProxima);
            Controls.Add(btnAnterior);
            Controls.Add(lblPagina);
            Controls.Add(txtPesquisarSala);
            Controls.Add(label2);
            Controls.Add(dgvSalas);
            Controls.Add(label1);
            Name = "FrmConsultarSalas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Salas";
            Load += FrmConsultarSalas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSalas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvSalas;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colAndar;
        private DataGridViewTextBoxColumn colAssentos;
        private Label label2;
        private TextBox txtPesquisarSala;
        private Label lblPagina;
        private Button btnAnterior;
        private Button btnProxima;
        private Button btnAlterarSala;
        private Button btnExcluirSala;
    }
}