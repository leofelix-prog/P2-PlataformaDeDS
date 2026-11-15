namespace SalaDeReunioes
{
    partial class FrmAlterarReserva
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
            label1 = new Label();
            dgvReservas = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            lblSala = new Label();
            cmbSala = new ComboBox();
            lblData = new Label();
            dtpData = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            dtpFim = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCancelar = new Button();
            btnSalvarAlteracoes = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(395, 26);
            label1.Name = "label1";
            label1.Size = new Size(233, 41);
            label1.TabIndex = 0;
            label1.Text = "Alterar Reserva";
            // 
            // dgvReservas
            // 
            dgvReservas.AllowUserToAddRows = false;
            dgvReservas.AllowUserToDeleteRows = false;
            dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgvReservas.Location = new Point(33, 99);
            dgvReservas.MultiSelect = false;
            dgvReservas.Name = "dgvReservas";
            dgvReservas.ReadOnly = true;
            dgvReservas.RowHeadersWidth = 51;
            dgvReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservas.Size = new Size(646, 355);
            dgvReservas.TabIndex = 1;
            dgvReservas.SelectionChanged += dgvReservas_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Inicio";
            dataGridViewTextBoxColumn1.HeaderText = "Data";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Inicio";
            dataGridViewCellStyle1.Format = "HH:mm";
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTextBoxColumn2.HeaderText = "Horário Início";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Fim";
            dataGridViewCellStyle2.Format = "HH:mm";
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTextBoxColumn3.HeaderText = "Horário Fim";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "NomeSala";
            dataGridViewTextBoxColumn4.HeaderText = "Sala";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "AndarSala";
            dataGridViewTextBoxColumn5.HeaderText = "Andar";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // lblSala
            // 
            lblSala.AutoSize = true;
            lblSala.Location = new Point(720, 189);
            lblSala.Name = "lblSala";
            lblSala.Size = new Size(37, 20);
            lblSala.TabIndex = 2;
            lblSala.Text = "Sala";
            // 
            // cmbSala
            // 
            cmbSala.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSala.FormattingEnabled = true;
            cmbSala.Location = new Point(767, 189);
            cmbSala.Name = "cmbSala";
            cmbSala.Size = new Size(174, 28);
            cmbSala.TabIndex = 3;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(720, 251);
            lblData.Name = "lblData";
            lblData.Size = new Size(41, 20);
            lblData.TabIndex = 4;
            lblData.Text = "Data";
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(767, 251);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(174, 27);
            dtpData.TabIndex = 5;
            // 
            // dtpInicio
            // 
            dtpInicio.CustomFormat = "HH:mm";
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.Location = new Point(863, 314);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.ShowUpDown = true;
            dtpInicio.Size = new Size(78, 27);
            dtpInicio.TabIndex = 6;
            // 
            // dtpFim
            // 
            dtpFim.CustomFormat = "HH:mm";
            dtpFim.Format = DateTimePickerFormat.Custom;
            dtpFim.Location = new Point(863, 374);
            dtpFim.Name = "dtpFim";
            dtpFim.ShowUpDown = true;
            dtpFim.Size = new Size(78, 27);
            dtpFim.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(720, 314);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 8;
            label2.Text = "Horário de início";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(720, 374);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 9;
            label3.Text = "Horário de término";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.Location = new Point(734, 114);
            label4.Name = "label4";
            label4.Size = new Size(188, 37);
            label4.TabIndex = 10;
            label4.Text = "Modificações";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(571, 475);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(189, 54);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvarAlteracoes
            // 
            btnSalvarAlteracoes.Location = new Point(781, 475);
            btnSalvarAlteracoes.Name = "btnSalvarAlteracoes";
            btnSalvarAlteracoes.Size = new Size(189, 54);
            btnSalvarAlteracoes.TabIndex = 12;
            btnSalvarAlteracoes.Text = "Salvar Alterações";
            btnSalvarAlteracoes.UseVisualStyleBackColor = true;
            btnSalvarAlteracoes.Click += btnSalvarAlteracoes_Click;
            // 
            // FrmAlterarReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(btnSalvarAlteracoes);
            Controls.Add(btnCancelar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpFim);
            Controls.Add(dtpInicio);
            Controls.Add(dtpData);
            Controls.Add(lblData);
            Controls.Add(cmbSala);
            Controls.Add(lblSala);
            Controls.Add(dgvReservas);
            Controls.Add(label1);
            Name = "FrmAlterarReserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alterar Reserva";
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvReservas;
        private Label lblSala;
        private ComboBox cmbSala;
        private Label lblData;
        private DateTimePicker dtpData;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFim;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCancelar;
        private Button btnSalvarAlteracoes;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}