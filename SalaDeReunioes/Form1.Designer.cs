namespace SalaDeReunioes
{
    partial class FrmPrincipal
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
            label1 = new Label();
            btnConsultarSalas = new Button();
            btnCadastrarSala = new Button();
            btnGerenciarReservas = new Button();
            btnRelatorios = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(366, 33);
            label1.Name = "label1";
            label1.Size = new Size(254, 41);
            label1.TabIndex = 0;
            label1.Text = "Salas de Reunião";
            // 
            // btnConsultarSalas
            // 
            btnConsultarSalas.Font = new Font("Segoe UI", 11F);
            btnConsultarSalas.Location = new Point(394, 124);
            btnConsultarSalas.Name = "btnConsultarSalas";
            btnConsultarSalas.Size = new Size(200, 40);
            btnConsultarSalas.TabIndex = 1;
            btnConsultarSalas.Text = "Consultar Salas";
            btnConsultarSalas.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarSala
            // 
            btnCadastrarSala.Font = new Font("Segoe UI", 11F);
            btnCadastrarSala.Location = new Point(394, 202);
            btnCadastrarSala.Name = "btnCadastrarSala";
            btnCadastrarSala.Size = new Size(200, 40);
            btnCadastrarSala.TabIndex = 2;
            btnCadastrarSala.Text = "Cadastrar Sala";
            btnCadastrarSala.UseVisualStyleBackColor = true;
            btnCadastrarSala.Click += btnCadastrarSala_Click;
            // 
            // btnGerenciarReservas
            // 
            btnGerenciarReservas.Font = new Font("Segoe UI", 11F);
            btnGerenciarReservas.Location = new Point(394, 280);
            btnGerenciarReservas.Name = "btnGerenciarReservas";
            btnGerenciarReservas.Size = new Size(200, 40);
            btnGerenciarReservas.TabIndex = 3;
            btnGerenciarReservas.Text = "Gerenciar Reservas";
            btnGerenciarReservas.UseVisualStyleBackColor = true;
            // 
            // btnRelatorios
            // 
            btnRelatorios.Font = new Font("Segoe UI", 11F);
            btnRelatorios.Location = new Point(394, 355);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Size = new Size(200, 40);
            btnRelatorios.TabIndex = 4;
            btnRelatorios.Text = "Relatórios";
            btnRelatorios.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 553);
            Controls.Add(btnRelatorios);
            Controls.Add(btnGerenciarReservas);
            Controls.Add(btnCadastrarSala);
            Controls.Add(btnConsultarSalas);
            Controls.Add(label1);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gerenciamento de Salas de Reunião";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnConsultarSalas;
        private Button btnCadastrarSala;
        private Button btnGerenciarReservas;
        private Button btnRelatorios;
    }
}
