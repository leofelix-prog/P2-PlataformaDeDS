using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SalaDeReunioes.Dados;
using SalaDeReunioes.Models;

namespace SalaDeReunioes
{
    public partial class FrmConsultarSalas : Form
    {
        private int pgnAtual = 1;
        private int qtddPorPagina = 10;
        private int totalPaginas = 1;


        public FrmConsultarSalas()
        {
            InitializeComponent();
            dgvSalas.AutoGenerateColumns = false;
        }

        private void CarregarSalas(string pesquisa = "")
        {
            SalaRepositorio repositorio = new SalaRepositorio();

            List<Sala> salas = repositorio.ConsultarTodos();

            List<Sala> salasFiltradas = new List<Sala>();

            foreach (Sala sala in salas)
            {
                if (sala.Nome.ToLower().Contains(pesquisa.ToLower()))
                {
                    salasFiltradas.Add(sala);
                }
            }

            totalPaginas = (salasFiltradas.Count + qtddPorPagina - 1) / qtddPorPagina;

            if (totalPaginas == 0)
            {
                totalPaginas = 1;
            }

            if (pgnAtual > totalPaginas)
            {
                pgnAtual = totalPaginas;
            }

            lblPagina.Text = "Página " + pgnAtual + " de " + totalPaginas;

            int inicio = (pgnAtual - 1) * qtddPorPagina;

            List<Sala> salasPagina = new List<Sala>();

            for (int i = inicio; i < inicio + qtddPorPagina && i < salasFiltradas.Count; i++)
            {
                salasPagina.Add(salasFiltradas[i]);
            }

            dgvSalas.DataSource = salasPagina;
        }

        private void FrmConsultarSalas_Load(object sender, EventArgs e)
        {
            CarregarSalas();
        }

        private void txtPesquisarSala_TextChanged(object sender, EventArgs e)
        {
            pgnAtual = 1;
            CarregarSalas(txtPesquisarSala.Text);
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            if (pgnAtual < totalPaginas)
            {
                pgnAtual++;
                CarregarSalas(txtPesquisarSala.Text);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (pgnAtual > 1)
            {
                pgnAtual--;
                CarregarSalas(txtPesquisarSala.Text);
            }
        }

        private void btnAlterarSala_Click(object sender, EventArgs e)
        {
            if (dgvSalas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma sala para alterar.");
                return;
            }

            if (dgvSalas.SelectedRows[0].DataBoundItem is not Sala salaSelecionada)
            {
                MessageBox.Show("Não foi possível identificar a sala selecionada.");
                return;
            }

            FrmAlterarSala formulario = new FrmAlterarSala(salaSelecionada);

            formulario.ShowDialog();

            CarregarSalas(txtPesquisarSala.Text);
        }

        private void btnExcluirSala_Click(object sender, EventArgs e)
        {
            if (dgvSalas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma sala para excluir.");
                return;
            }

            if (dgvSalas.SelectedRows[0].DataBoundItem is not Sala salaSelecionada)
            {
                MessageBox.Show("Não foi possível identificar a sala selecionada.");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Tem certeza que deseja excluir a sala " + salaSelecionada.Nome + "?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                try
                {
                    SalaRepositorio repositorio = new SalaRepositorio();

                    repositorio.Excluir(salaSelecionada.Id);

                    MessageBox.Show("Sala excluída com sucesso!");

                    CarregarSalas(txtPesquisarSala.Text);
                }
                catch (Npgsql.PostgresException ex) when (ex.SqlState == "23503")
                {
                    MessageBox.Show("Não é possível excluir esta sala porque existem reservas vinculadas a ela.");
                }
            }
        }
    }
}
