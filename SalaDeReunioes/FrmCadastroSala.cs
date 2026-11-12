using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SalaDeReunioes.Models;
using SalaDeReunioes.Dados;

namespace SalaDeReunioes
{
    public partial class FrmCadastroSala : Form
    {
        public FrmCadastroSala()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarSala_Click(object sender, EventArgs e)
        {
            if (txtNomeSala.Text.Trim() == "")
            {
                MessageBox.Show("Informe o nome da sala.");
                return;
            }

            if (cmbAndar.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o andar da sala.");
                return;
            }

            int andar = int.Parse(cmbAndar.SelectedItem.ToString());

            if (txtQuantidadeAssentos.Text.Trim() == "")
            {
                MessageBox.Show("Informe a quantidade de assentos.");
                return;
            }

            int qtddAssentos;

            if (!int.TryParse(txtQuantidadeAssentos.Text, out qtddAssentos))
            {
                MessageBox.Show("Digite um número válido para a quantidade de assentos.");
                return;
            }

            if (qtddAssentos <= 0)
            {
                MessageBox.Show("A quantidade de assentos deve ser maior que zero.");
                return;
            }

            Sala sala = new Sala();
            sala.Nome = txtNomeSala.Text.Trim();
            sala.Andar = andar;
            sala.QtddAssentos = qtddAssentos;

            try
            {
                SalaRepositorio repositorio = new SalaRepositorio();
                repositorio.Cadastrar(sala);

                MessageBox.Show("Sala cadastrada com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar a sala: " + ex.Message);
            }
        }
    }
}
