using SalaDeReunioes.Dados;
using SalaDeReunioes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalaDeReunioes
{
    public partial class FrmExcluirReserva : Form
    {
        public FrmExcluirReserva()
        {
            InitializeComponent();
            dgvReservas.AutoGenerateColumns = false;
            CarregarReservas();
        }

        private void CarregarReservas()
        {
            ReservaRepositorio repositorio = new ReservaRepositorio();
            List<Reserva> reservas = repositorio.ConsultarTodos();

            dgvReservas.DataSource = reservas;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluirReserva_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma reserva para excluir.");
                return;
            }

            if (dgvReservas.SelectedRows[0].DataBoundItem is not Reserva reservaSelecionada)
            {
                MessageBox.Show("Não foi possível identificar a reserva selecionada.");
                return;
            }

            DialogResult resposta = MessageBox.Show("Tem certeza de que deseja excluir esta reserva?",
                                                    "Confirmar exclusão",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question
                                                   );

            if (resposta == DialogResult.No)
            {
                return;
            }

            ReservaRepositorio repositorio = new ReservaRepositorio();
            repositorio.Excluir(reservaSelecionada.Id);

            MessageBox.Show("Reserva excluída com sucesso!");
            CarregarReservas();
        }
    }
}
