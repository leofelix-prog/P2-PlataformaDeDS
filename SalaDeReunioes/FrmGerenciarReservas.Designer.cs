namespace SalaDeReunioes
{
    partial class FrmGerenciarReservas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            dgvReservas = new DataGridView();
            colData = new DataGridViewTextBoxColumn();
            colInicio = new DataGridViewTextBoxColumn();
            colFim = new DataGridViewTextBoxColumn();
            colNomeSala = new DataGridViewTextBoxColumn();
            colAndarSala = new DataGridViewTextBoxColumn();
            btnAdicionarReserva = new Button();
            btnAlterarReserva = new Button();
            btnExcluirReserva = new Button();
            btnVerDisponibilidade = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Location = new Point(240, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(404, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gerenciamento de Reservas";
            // 
            // dgvReservas
            // 
            dgvReservas.AllowUserToAddRows = false;
            dgvReservas.AllowUserToDeleteRows = false;
            dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Columns.AddRange(new DataGridViewColumn[] { colData, colInicio, colFim, colNomeSala, colAndarSala });
            dgvReservas.Location = new Point(221, 114);
            dgvReservas.MultiSelect = false;
            dgvReservas.Name = "dgvReservas";
            dgvReservas.ReadOnly = true;
            dgvReservas.RowHeadersWidth = 51;
            dgvReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservas.Size = new Size(639, 339);
            dgvReservas.TabIndex = 1;
            // 
            // colData
            // 
            colData.DataPropertyName = "Inicio";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            colData.DefaultCellStyle = dataGridViewCellStyle1;
            colData.HeaderText = "Data";
            colData.MinimumWidth = 6;
            colData.Name = "colData";
            colData.ReadOnly = true;
            // 
            // colInicio
            // 
            colInicio.DataPropertyName = "Inicio";
            dataGridViewCellStyle2.Format = "HH:mm";
            colInicio.DefaultCellStyle = dataGridViewCellStyle2;
            colInicio.HeaderText = "Horário Início";
            colInicio.MinimumWidth = 6;
            colInicio.Name = "colInicio";
            colInicio.ReadOnly = true;
            // 
            // colFim
            // 
            colFim.DataPropertyName = "Fim";
            dataGridViewCellStyle3.Format = "HH:mm";
            colFim.DefaultCellStyle = dataGridViewCellStyle3;
            colFim.HeaderText = "Horário Fim";
            colFim.MinimumWidth = 6;
            colFim.Name = "colFim";
            colFim.ReadOnly = true;
            // 
            // colNomeSala
            // 
            colNomeSala.DataPropertyName = "NomeSala";
            colNomeSala.HeaderText = "Sala";
            colNomeSala.MinimumWidth = 6;
            colNomeSala.Name = "colNomeSala";
            colNomeSala.ReadOnly = true;
            // 
            // colAndarSala
            // 
            colAndarSala.DataPropertyName = "AndarSala";
            colAndarSala.HeaderText = "Andar";
            colAndarSala.MinimumWidth = 6;
            colAndarSala.Name = "colAndarSala";
            colAndarSala.ReadOnly = true;
            // 
            // btnAdicionarReserva
            // 
            btnAdicionarReserva.Location = new Point(25, 114);
            btnAdicionarReserva.Name = "btnAdicionarReserva";
            btnAdicionarReserva.Size = new Size(171, 58);
            btnAdicionarReserva.TabIndex = 2;
            btnAdicionarReserva.Text = "Adicionar Reserva";
            btnAdicionarReserva.UseVisualStyleBackColor = true;
            btnAdicionarReserva.Click += btnAdicionarReserva_Click;
            // 
            // btnAlterarReserva
            // 
            btnAlterarReserva.Location = new Point(25, 198);
            btnAlterarReserva.Name = "btnAlterarReserva";
            btnAlterarReserva.Size = new Size(171, 58);
            btnAlterarReserva.TabIndex = 3;
            btnAlterarReserva.Text = "Alterar Reserva";
            btnAlterarReserva.UseVisualStyleBackColor = true;
            btnAlterarReserva.Click += btnAlterarReserva_Click;
            // 
            // btnExcluirReserva
            // 
            btnExcluirReserva.Location = new Point(25, 286);
            btnExcluirReserva.Name = "btnExcluirReserva";
            btnExcluirReserva.Size = new Size(171, 58);
            btnExcluirReserva.TabIndex = 4;
            btnExcluirReserva.Text = "Excluir Reserva";
            btnExcluirReserva.UseVisualStyleBackColor = true;
            btnExcluirReserva.Click += btnExcluirReserva_Click;
            // 
            // btnVerDisponibilidade
            // 
            btnVerDisponibilidade.Location = new Point(25, 374);
            btnVerDisponibilidade.Name = "btnVerDisponibilidade";
            btnVerDisponibilidade.Size = new Size(171, 58);
            btnVerDisponibilidade.TabIndex = 5;
            btnVerDisponibilidade.Text = "\tVer Disponibilidade de Salas";
            btnVerDisponibilidade.UseVisualStyleBackColor = true;
            btnVerDisponibilidade.Click += btnVerDisponibilidade_Click;
            // 
            // FrmGerenciarReservas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 503);
            Controls.Add(btnVerDisponibilidade);
            Controls.Add(btnExcluirReserva);
            Controls.Add(btnAlterarReserva);
            Controls.Add(btnAdicionarReserva);
            Controls.Add(dgvReservas);
            Controls.Add(lblTitulo);
            Name = "FrmGerenciarReservas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciar Reservas";
            Load += FrmGerenciarReservas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvReservas;
        private DataGridViewTextBoxColumn colData;
        private DataGridViewTextBoxColumn colInicio;
        private DataGridViewTextBoxColumn colFim;
        private DataGridViewTextBoxColumn colNomeSala;
        private DataGridViewTextBoxColumn colAndarSala;
        private Button btnAdicionarReserva;
        private Button btnAlterarReserva;
        private Button btnExcluirReserva;
        private Button btnVerDisponibilidade;
    }
}