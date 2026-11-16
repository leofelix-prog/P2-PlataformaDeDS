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
            lblTituloReservasRecentes = new Label();
            lblQtddReservasRecentes = new Label();
            btnSair = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(297, 21);
            label1.Name = "label1";
            label1.Size = new Size(424, 67);
            label1.TabIndex = 0;
            label1.Text = "Salas de Reunião";
            // 
            // btnConsultarSalas
            // 
            btnConsultarSalas.BackColor = SystemColors.Info;
            btnConsultarSalas.Font = new Font("Segoe UI", 11F);
            btnConsultarSalas.Location = new Point(394, 123);
            btnConsultarSalas.Name = "btnConsultarSalas";
            btnConsultarSalas.Size = new Size(200, 40);
            btnConsultarSalas.TabIndex = 1;
            btnConsultarSalas.Text = "Consultar Salas";
            btnConsultarSalas.UseVisualStyleBackColor = false;
            btnConsultarSalas.Click += btnConsultarSalas_Click;
            // 
            // btnCadastrarSala
            // 
            btnCadastrarSala.BackColor = SystemColors.Info;
            btnCadastrarSala.Font = new Font("Segoe UI", 11F);
            btnCadastrarSala.Location = new Point(394, 201);
            btnCadastrarSala.Name = "btnCadastrarSala";
            btnCadastrarSala.Size = new Size(200, 40);
            btnCadastrarSala.TabIndex = 2;
            btnCadastrarSala.Text = "Cadastrar Sala";
            btnCadastrarSala.UseVisualStyleBackColor = false;
            btnCadastrarSala.Click += btnCadastrarSala_Click;
            // 
            // btnGerenciarReservas
            // 
            btnGerenciarReservas.BackColor = SystemColors.Info;
            btnGerenciarReservas.Font = new Font("Segoe UI", 11F);
            btnGerenciarReservas.Location = new Point(394, 279);
            btnGerenciarReservas.Name = "btnGerenciarReservas";
            btnGerenciarReservas.Size = new Size(200, 40);
            btnGerenciarReservas.TabIndex = 3;
            btnGerenciarReservas.Text = "Gerenciar Reservas";
            btnGerenciarReservas.UseVisualStyleBackColor = false;
            btnGerenciarReservas.Click += btnGerenciarReservas_Click;
            // 
            // lblTituloReservasRecentes
            // 
            lblTituloReservasRecentes.AutoSize = true;
            lblTituloReservasRecentes.Font = new Font("Segoe UI", 12F);
            lblTituloReservasRecentes.Location = new Point(12, 488);
            lblTituloReservasRecentes.Name = "lblTituloReservasRecentes";
            lblTituloReservasRecentes.Size = new Size(360, 28);
            lblTituloReservasRecentes.TabIndex = 5;
            lblTituloReservasRecentes.Text = "Reservas cadastradas nos últimos 7 dias:";
            // 
            // lblQtddReservasRecentes
            // 
            lblQtddReservasRecentes.AutoSize = true;
            lblQtddReservasRecentes.Font = new Font("Segoe UI", 40F);
            lblQtddReservasRecentes.Location = new Point(378, 455);
            lblQtddReservasRecentes.Name = "lblQtddReservasRecentes";
            lblQtddReservasRecentes.Size = new Size(74, 89);
            lblQtddReservasRecentes.TabIndex = 6;
            lblQtddReservasRecentes.Text = "0";
            lblQtddReservasRecentes.Click += lblQtddReservasRecentes_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.ButtonFace;
            btnSair.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSair.Location = new Point(394, 370);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(200, 40);
            btnSair.TabIndex = 7;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(999, 553);
            Controls.Add(btnSair);
            Controls.Add(lblQtddReservasRecentes);
            Controls.Add(lblTituloReservasRecentes);
            Controls.Add(btnGerenciarReservas);
            Controls.Add(btnCadastrarSala);
            Controls.Add(btnConsultarSalas);
            Controls.Add(label1);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gerenciamento de Salas de Reunião";
            Activated += FrmPrincipal_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnConsultarSalas;
        private Button btnCadastrarSala;
        private Button btnGerenciarReservas;
        private Label lblTituloReservasRecentes;
        private Label lblQtddReservasRecentes;
        private Button btnSair;
    }
}
