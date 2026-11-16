namespace SalaDeReunioes
{
    partial class FrmDisponibilidadeSalas
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
            label2 = new Label();
            label3 = new Label();
            dtpDataInicial = new DateTimePicker();
            dtpDataFinal = new DateTimePicker();
            btnAplicar = new Button();
            dgvDisponibilidade = new DataGridView();
            colSala = new DataGridViewTextBoxColumn();
            colAndar = new DataGridViewTextBoxColumn();
            colHorasLivres = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDisponibilidade).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(206, 21);
            label1.Name = "label1";
            label1.Size = new Size(377, 41);
            label1.TabIndex = 0;
            label1.Text = "Disponibilidade das Salas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 121);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "Data inicial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 121);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Data final";
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.Format = DateTimePickerFormat.Short;
            dtpDataInicial.Location = new Point(106, 116);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.Size = new Size(136, 27);
            dtpDataInicial.TabIndex = 3;
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.Format = DateTimePickerFormat.Short;
            dtpDataFinal.Location = new Point(355, 116);
            dtpDataFinal.Name = "dtpDataFinal";
            dtpDataFinal.Size = new Size(136, 27);
            dtpDataFinal.TabIndex = 4;
            // 
            // btnAplicar
            // 
            btnAplicar.BackColor = SystemColors.Info;
            btnAplicar.Location = new Point(636, 109);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(118, 45);
            btnAplicar.TabIndex = 5;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // dgvDisponibilidade
            // 
            dgvDisponibilidade.AllowUserToAddRows = false;
            dgvDisponibilidade.AllowUserToDeleteRows = false;
            dgvDisponibilidade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDisponibilidade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDisponibilidade.Columns.AddRange(new DataGridViewColumn[] { colSala, colAndar, colHorasLivres });
            dgvDisponibilidade.Location = new Point(16, 174);
            dgvDisponibilidade.MultiSelect = false;
            dgvDisponibilidade.Name = "dgvDisponibilidade";
            dgvDisponibilidade.ReadOnly = true;
            dgvDisponibilidade.RowHeadersWidth = 51;
            dgvDisponibilidade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDisponibilidade.Size = new Size(738, 254);
            dgvDisponibilidade.TabIndex = 6;
            // 
            // colSala
            // 
            colSala.DataPropertyName = "Nome";
            colSala.HeaderText = "Sala";
            colSala.MinimumWidth = 6;
            colSala.Name = "colSala";
            colSala.ReadOnly = true;
            // 
            // colAndar
            // 
            colAndar.DataPropertyName = "Andar";
            colAndar.HeaderText = "Andar";
            colAndar.MinimumWidth = 6;
            colAndar.Name = "colAndar";
            colAndar.ReadOnly = true;
            // 
            // colHorasLivres
            // 
            colHorasLivres.DataPropertyName = "HorasLivres";
            colHorasLivres.HeaderText = "Horas Livres";
            colHorasLivres.MinimumWidth = 6;
            colHorasLivres.Name = "colHorasLivres";
            colHorasLivres.ReadOnly = true;
            // 
            // FrmDisponibilidadeSalas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(782, 453);
            Controls.Add(dgvDisponibilidade);
            Controls.Add(btnAplicar);
            Controls.Add(dtpDataFinal);
            Controls.Add(dtpDataInicial);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmDisponibilidadeSalas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Disponibilidade das Salas";
            ((System.ComponentModel.ISupportInitialize)dgvDisponibilidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpDataInicial;
        private DateTimePicker dtpDataFinal;
        private Button btnAplicar;
        private DataGridView dgvDisponibilidade;
        private DataGridViewTextBoxColumn colSala;
        private DataGridViewTextBoxColumn colAndar;
        private DataGridViewTextBoxColumn colHorasLivres;
    }
}