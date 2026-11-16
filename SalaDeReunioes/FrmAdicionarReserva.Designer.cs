namespace SalaDeReunioes
{
    partial class FrmAdicionarReserva
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
            lblTitulo = new Label();
            lblSala = new Label();
            cmbSala = new ComboBox();
            lblData = new Label();
            lblInicio = new Label();
            lblFim = new Label();
            dtpData = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            dtpFim = new DateTimePicker();
            btnCadastrarReserva = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(83, 32);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(271, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Adicionar Reserva";
            // 
            // lblSala
            // 
            lblSala.AutoSize = true;
            lblSala.Font = new Font("Segoe UI", 12F);
            lblSala.Location = new Point(63, 137);
            lblSala.Name = "lblSala";
            lblSala.Size = new Size(52, 28);
            lblSala.TabIndex = 1;
            lblSala.Text = "Sala:";
            // 
            // cmbSala
            // 
            cmbSala.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSala.FormattingEnabled = true;
            cmbSala.Location = new Point(126, 137);
            cmbSala.Name = "cmbSala";
            cmbSala.Size = new Size(250, 28);
            cmbSala.TabIndex = 2;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 12F);
            lblData.Location = new Point(63, 209);
            lblData.Name = "lblData";
            lblData.Size = new Size(57, 28);
            lblData.TabIndex = 3;
            lblData.Text = "Data:";
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Font = new Font("Segoe UI", 12F);
            lblInicio.Location = new Point(63, 279);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(162, 28);
            lblInicio.TabIndex = 4;
            lblInicio.Text = "Horário de início:";
            // 
            // lblFim
            // 
            lblFim.AutoSize = true;
            lblFim.Font = new Font("Segoe UI", 12F);
            lblFim.Location = new Point(63, 350);
            lblFim.Name = "lblFim";
            lblFim.Size = new Size(189, 28);
            lblFim.TabIndex = 5;
            lblFim.Text = "Horário de término: ";
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(126, 210);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(250, 27);
            dtpData.TabIndex = 6;
            // 
            // dtpInicio
            // 
            dtpInicio.CustomFormat = "HH:mm";
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.Location = new Point(258, 281);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.ShowUpDown = true;
            dtpInicio.Size = new Size(118, 27);
            dtpInicio.TabIndex = 7;
            // 
            // dtpFim
            // 
            dtpFim.CustomFormat = "HH:mm";
            dtpFim.Format = DateTimePickerFormat.Custom;
            dtpFim.Location = new Point(258, 350);
            dtpFim.Name = "dtpFim";
            dtpFim.ShowUpDown = true;
            dtpFim.Size = new Size(118, 27);
            dtpFim.TabIndex = 8;
            // 
            // btnCadastrarReserva
            // 
            btnCadastrarReserva.BackColor = SystemColors.Info;
            btnCadastrarReserva.Font = new Font("Segoe UI", 11F);
            btnCadastrarReserva.Location = new Point(229, 429);
            btnCadastrarReserva.Name = "btnCadastrarReserva";
            btnCadastrarReserva.Size = new Size(172, 77);
            btnCadastrarReserva.TabIndex = 9;
            btnCadastrarReserva.Text = "Cadastrar Reserva";
            btnCadastrarReserva.UseVisualStyleBackColor = false;
            btnCadastrarReserva.Click += btnCadastrarReserva_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlDark;
            btnCancelar.Font = new Font("Segoe UI", 11F);
            btnCancelar.Location = new Point(28, 429);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(172, 77);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmAdicionarReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(432, 603);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrarReserva);
            Controls.Add(dtpFim);
            Controls.Add(dtpInicio);
            Controls.Add(dtpData);
            Controls.Add(lblFim);
            Controls.Add(lblInicio);
            Controls.Add(lblData);
            Controls.Add(cmbSala);
            Controls.Add(lblSala);
            Controls.Add(lblTitulo);
            Name = "FrmAdicionarReserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Reserva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSala;
        private ComboBox cmbSala;
        private Label lblData;
        private Label lblInicio;
        private Label lblFim;
        private DateTimePicker dtpData;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFim;
        private Button btnCadastrarReserva;
        private Button btnCancelar;
    }
}