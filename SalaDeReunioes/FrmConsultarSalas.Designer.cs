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
            dgvSalas.Location = new Point(65, 145);
            dgvSalas.MultiSelect = false;
            dgvSalas.Name = "dgvSalas";
            dgvSalas.ReadOnly = true;
            dgvSalas.RowHeadersWidth = 51;
            dgvSalas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalas.Size = new Size(740, 318);
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
            label2.Location = new Point(65, 109);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 2;
            label2.Text = "Pesquisar Sala";
            // 
            // txtPesquisarSala
            // 
            txtPesquisarSala.Location = new Point(173, 106);
            txtPesquisarSala.Name = "txtPesquisarSala";
            txtPesquisarSala.Size = new Size(125, 27);
            txtPesquisarSala.TabIndex = 3;
            txtPesquisarSala.TextChanged += txtPesquisarSala_TextChanged;
            // 
            // FrmConsultarSalas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 503);
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
    }
}