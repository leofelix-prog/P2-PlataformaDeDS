namespace SalaDeReunioes
{
    partial class FrmCadastroSala
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
            txtNomeSala = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnCadastrarSala = new Button();
            btnCancelar = new Button();
            txtQuantidadeAssentos = new TextBox();
            cmbAndar = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 21);
            label1.Name = "label1";
            label1.Size = new Size(417, 41);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Sala de Reunião";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 141);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome da sala:";
            // 
            // txtNomeSala
            // 
            txtNomeSala.Location = new Point(151, 138);
            txtNomeSala.Name = "txtNomeSala";
            txtNomeSala.Size = new Size(298, 27);
            txtNomeSala.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 195);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "Andar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 250);
            label4.Name = "label4";
            label4.Size = new Size(171, 20);
            label4.TabIndex = 5;
            label4.Text = "Quantidade de assentos:";
            // 
            // btnCadastrarSala
            // 
            btnCadastrarSala.Location = new Point(410, 327);
            btnCadastrarSala.Name = "btnCadastrarSala";
            btnCadastrarSala.Size = new Size(141, 40);
            btnCadastrarSala.TabIndex = 7;
            btnCadastrarSala.Text = "Cadastrar Sala";
            btnCadastrarSala.UseVisualStyleBackColor = true;
            btnCadastrarSala.Click += btnCadastrarSala_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(242, 327);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(141, 40);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtQuantidadeAssentos
            // 
            txtQuantidadeAssentos.Location = new Point(216, 247);
            txtQuantidadeAssentos.Name = "txtQuantidadeAssentos";
            txtQuantidadeAssentos.Size = new Size(80, 27);
            txtQuantidadeAssentos.TabIndex = 6;
            // 
            // cmbAndar
            // 
            cmbAndar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAndar.FormattingEnabled = true;
            cmbAndar.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbAndar.Location = new Point(95, 192);
            cmbAndar.Name = "cmbAndar";
            cmbAndar.Size = new Size(151, 28);
            cmbAndar.TabIndex = 9;
            // 
            // FrmCadastroSala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 403);
            Controls.Add(cmbAndar);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrarSala);
            Controls.Add(txtQuantidadeAssentos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNomeSala);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCadastroSala";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Sala de Reunião";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNomeSala;
        private Label label3;
        private Label label4;
        private Button btnCadastrarSala;
        private Button btnCancelar;
        private TextBox txtQuantidadeAssentos;
        private ComboBox cmbAndar;
    }
}