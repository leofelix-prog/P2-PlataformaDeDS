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
    public partial class FrmAlterarReserva : Form
    {
        public FrmAlterarReserva()
        {
            InitializeComponent();
            dgvReservas.AutoGenerateColumns = false;
            CarregarReservas();
            CarregarSalas();
        }

        private void CarregarReservas()
        {
            ReservaRepositorio repositorio = new ReservaRepositorio();
            List<Reserva> reservas = repositorio.ConsultarTodos();

            dgvReservas.DataSource = reservas;
        }

        private void CarregarSalas()
        {
            SalaRepositorio repositorio = new SalaRepositorio();
            List<Sala> salas = repositorio.ConsultarTodos();

            cmbSala.DataSource = salas;
            cmbSala.DisplayMember = "Nome";
            cmbSala.ValueMember = "Id";
        }

        private void dgvReservas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                return;
            }

            if (dgvReservas.SelectedRows[0].DataBoundItem is not Reserva reservaSelecionada)
            {
                return;
            }

            cmbSala.SelectedValue = reservaSelecionada.SalaId;
            dtpData.Value = reservaSelecionada.Inicio;
            dtpInicio.Value = reservaSelecionada.Inicio;
            dtpFim.Value = reservaSelecionada.Fim;
        }

        private void btnSalvarAlteracoes_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma reserva para alterar.");
                return;
            }

            if (dgvReservas.SelectedRows[0].DataBoundItem is not Reserva reservaSelecionada)
            {
                MessageBox.Show("Não foi possível identificar a reserva selecionada.");
                return;
            }

            if (cmbSala.SelectedValue == null)
            {
                MessageBox.Show("Selecione uma sala.");
                return;
            }

            int salaId = Convert.ToInt32(cmbSala.SelectedValue);

            DateTime inicio = dtpData.Value.Date.AddHours(dtpInicio.Value.Hour).AddMinutes(dtpInicio.Value.Minute);
            DateTime fim = dtpData.Value.Date.AddHours(dtpFim.Value.Hour).AddMinutes(dtpFim.Value.Minute);

            if (fim <= inicio)
            {
                MessageBox.Show("O horário de término deve ser posterior ao horário de início.");
                return;
            }

            if (inicio.TimeOfDay < new TimeSpan(8, 0, 0) || fim.TimeOfDay > new TimeSpan(19, 0, 0))
            {
                MessageBox.Show("As reservas devem ocorrer entre 08:00 e 19:00.");
                return;
            }

            if (inicio <= DateTime.Now)
            {
                MessageBox.Show("A reserva deve começar em uma data e horário futuros.");
                return;
            }

            reservaSelecionada.SalaId = salaId;
            reservaSelecionada.Inicio = inicio;
            reservaSelecionada.Fim = fim;

            try
            {
                ReservaRepositorio repositorio = new ReservaRepositorio();
                repositorio.Alterar(reservaSelecionada);

                MessageBox.Show("Reserva alterada com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar a reserva: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
