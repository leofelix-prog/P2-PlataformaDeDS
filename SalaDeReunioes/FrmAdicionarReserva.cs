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
    public partial class FrmAdicionarReserva : Form
    {
        public FrmAdicionarReserva()
        {
            InitializeComponent();
            CarregarSalas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CarregarSalas()
        {
            SalaRepositorio repositorio = new SalaRepositorio();

            List<Sala> salas = repositorio.ConsultarTodos();

            cmbSala.DataSource = salas;
            cmbSala.DisplayMember = "Nome";
            cmbSala.ValueMember = "Id";
        }

        private void btnCadastrarReserva_Click(object sender, EventArgs e)
        {
            DateTime inicio = dtpData.Value.Date.AddHours(dtpInicio.Value.Hour).AddMinutes(dtpInicio.Value.Minute);

            DateTime fim = dtpData.Value.Date.AddHours(dtpFim.Value.Hour).AddMinutes(dtpFim.Value.Minute);

            if (cmbSala.SelectedValue == null)
            {
                MessageBox.Show("Selecione uma sala.");
                return;
            }

            int salaId = Convert.ToInt32(cmbSala.SelectedValue);

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

            Reserva reserva = new Reserva();
            reserva.SalaId = salaId;
            reserva.Inicio = inicio;
            reserva.Fim = fim;

            try
            {
                ReservaRepositorio repositorio = new ReservaRepositorio();
                repositorio.Cadastrar(reserva);
                MessageBox.Show("Reserva cadastrada com sucesso!");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar a reserva: " + ex.Message);
            }
        }
    }
}
