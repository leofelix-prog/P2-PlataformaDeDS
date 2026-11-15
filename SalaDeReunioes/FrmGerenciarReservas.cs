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
    public partial class FrmGerenciarReservas : Form
    {
        public FrmGerenciarReservas()
        {
            InitializeComponent();
            dgvReservas.AutoGenerateColumns = false;
        }

        private void CarregarReservas()
        {
            ReservaRepositorio repositorio = new ReservaRepositorio();

            List<Reserva> reservas = repositorio.ConsultarTodos();

            dgvReservas.DataSource = reservas;
        }

        private void FrmGerenciarReservas_Load(object sender, EventArgs e)
        {
            CarregarReservas();
        }

        private void btnAdicionarReserva_Click(object sender, EventArgs e)
        {
            FrmAdicionarReserva formulario = new FrmAdicionarReserva();
            formulario.ShowDialog();
            CarregarReservas();
        }

        private void btnVerDisponibilidade_Click(object sender, EventArgs e)
        {
            FrmDisponibilidadeSalas formulario = new FrmDisponibilidadeSalas();
            formulario.ShowDialog();
        }

        private void btnExcluirReserva_Click(object sender, EventArgs e)
        {
            FrmExcluirReserva formulario = new FrmExcluirReserva();
            formulario.ShowDialog();

            CarregarReservas();
        }

        private void btnAlterarReserva_Click(object sender, EventArgs e)
        {
            FrmAlterarReserva formulario = new FrmAlterarReserva();
            formulario.ShowDialog();
            CarregarReservas();
        }
    }
}
