using SalaDeReunioes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SalaDeReunioes.Dados;

namespace SalaDeReunioes
{
    public partial class FrmAlterarSala : Form
    {
        private Sala salaSelecionada;

        internal FrmAlterarSala(Sala sala)
        {
            InitializeComponent();

            salaSelecionada = sala;

            txtNomeSala.Text = salaSelecionada.Nome;
            txtAndar.Text = salaSelecionada.Andar.ToString();
            txtQtddAssentos.Text = salaSelecionada.QtddAssentos.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeSala.Text))
            {
                MessageBox.Show("Informe o nome da sala.");
                return;
            }

            if (!int.TryParse(txtAndar.Text, out int andar) || andar < 0)
            {
                MessageBox.Show("Digite um número válido para o andar.");
                return;
            }

            if (!int.TryParse(txtQtddAssentos.Text, out int qtddAssentos) || qtddAssentos <= 0)
            {
                MessageBox.Show("Digite uma quantidade válida de assentos.");
                return;
            }

            salaSelecionada.Nome = txtNomeSala.Text.Trim();
            salaSelecionada.Andar = andar;
            salaSelecionada.QtddAssentos = qtddAssentos;

            SalaRepositorio repositorio = new SalaRepositorio();

            repositorio.Alterar(salaSelecionada);

            MessageBox.Show("Sala alterada com sucesso!");

            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
