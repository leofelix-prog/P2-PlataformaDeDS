namespace SalaDeReunioes
{
    partial class FrmAlterarSala
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
            txtNomeSala = new TextBox();
            txtAndar = new TextBox();
            txtQtddAssentos = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 175);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome da sala:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 240);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Andar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 313);
            label3.Name = "label3";
            label3.Size = new Size(171, 20);
            label3.TabIndex = 2;
            label3.Text = "Quantidade de assentos:";
            // 
            // txtNomeSala
            // 
            txtNomeSala.Location = new Point(168, 172);
            txtNomeSala.Name = "txtNomeSala";
            txtNomeSala.Size = new Size(138, 27);
            txtNomeSala.TabIndex = 3;
            // 
            // txtAndar
            // 
            txtAndar.Location = new Point(106, 237);
            txtAndar.Name = "txtAndar";
            txtAndar.Size = new Size(81, 27);
            txtAndar.TabIndex = 4;
            // 
            // txtQtddAssentos
            // 
            txtQtddAssentos.Location = new Point(225, 310);
            txtQtddAssentos.Name = "txtQtddAssentos";
            txtQtddAssentos.Size = new Size(81, 27);
            txtQtddAssentos.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(225, 393);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(156, 63);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar Alterações";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(48, 393);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(156, 63);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(124, 70);
            label4.Name = "label4";
            label4.Size = new Size(182, 41);
            label4.TabIndex = 8;
            label4.Text = "Alterar Sala";
            // 
            // FrmAlterarSala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 603);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtQtddAssentos);
            Controls.Add(txtAndar);
            Controls.Add(txtNomeSala);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmAlterarSala";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alterar Sala";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNomeSala;
        private TextBox txtAndar;
        private TextBox txtQtddAssentos;
        private Button btnSalvar;
        private Button btnCancelar;
        private Label label4;
    }
}